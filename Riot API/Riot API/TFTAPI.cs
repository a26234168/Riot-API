using System;
using System.Windows.Forms;
using MingweiSamuel.Camille;
using MingweiSamuel.Camille.TftMatchV1;
using MingweiSamuel.Camille.TftSummonerV1;

namespace Riot_API
{
    public partial class TFTAPI : Form
    {
        private RiotApi riotApi;
        private Summoner summoner;
        private Match selectmatch;


        private string entername;
        private string APIkeynumber;
        public TFTAPI()
        {
            InitializeComponent();
        }

        private void NameTextBox_TextChanged(object sender, EventArgs e)
        {
            entername = NameTextBox.Text;
        }

        private void EnterAPITextBox_TextChanged(object sender, EventArgs e)
        {
            APIkeynumber = EnterAPITextBox.Text;
        }

        private void Search_Click(object sender, EventArgs e)
        {
            riotApi = RiotApi.NewInstance(APIkeynumber);
            summoner = riotApi.TftSummonerV1.GetBySummonerName(MingweiSamuel.Camille.Enums.Region.NA, entername);
            var matches = riotApi.TftMatchV1.GetMatchIdsByPUUID(MingweiSamuel.Camille.Enums.Region.Americas, summoner.Puuid);
            foreach (var match in matches)
            {
                MatchList.Items.Add(match);
            }


        }

        private void MatchList_SelectedIndexChanged(object sender, EventArgs e)
        {
            ParticipantList.Items.Clear();
            selectmatch = riotApi.TftMatchV1.GetMatch(MingweiSamuel.Camille.Enums.Region.Americas, (string)MatchList.SelectedItem);
            
            foreach (Participant participant in selectmatch.Info.Participants)
            {
                ParticipantList.Items.Add(participant);
            }
        }

        private void ParticipantList_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            var SelectedParticipant = (Participant)ParticipantList.SelectedItem;
            long gametime = (long)SelectedParticipant.TimeEliminated;
            TimeSpan t = TimeSpan.FromSeconds(gametime);
            GoldTextBox.Text = SelectedParticipant.GoldLeft.ToString();
            RoundDeadTextBox.Text = SelectedParticipant.LastRound.ToString();
            PlayerLevelTextBox.Text = SelectedParticipant.Level.ToString();
            PlacementTextBox.Text = SelectedParticipant.Level.ToString();
            TimeEliminatedTextBox.Text = string.Format("{0:D2}m:{1:D2}s", t.Minutes, t.Seconds);
            Unitlist.Items.Clear();
            Traitlist.Items.Clear();
            foreach (Unit unit in SelectedParticipant.Units)
            {
                Unitlist.Items.Add(unit.CharacterId);
            }
            foreach (Trait trait in SelectedParticipant.Traits)
            {
                Traitlist.Items.Add(trait.Name);
            }



        }

    }
}
