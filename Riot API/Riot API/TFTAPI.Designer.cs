
namespace Riot_API
{
    partial class TFTAPI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.APIKey = new System.Windows.Forms.Label();
            this.EnterAPITextBox = new System.Windows.Forms.TextBox();
            this.SummonerName = new System.Windows.Forms.Label();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.RecentMatch = new System.Windows.Forms.Label();
            this.Search = new System.Windows.Forms.Button();
            this.MatchList = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ParticipantList = new System.Windows.Forms.ListBox();
            this.Traitlist = new System.Windows.Forms.ListBox();
            this.GoldLeft = new System.Windows.Forms.Label();
            this.Unitlist = new System.Windows.Forms.ListBox();
            this.GoldTextBox = new System.Windows.Forms.TextBox();
            this.Trait = new System.Windows.Forms.Label();
            this.RoundDead = new System.Windows.Forms.Label();
            this.Unit = new System.Windows.Forms.Label();
            this.RoundDeadTextBox = new System.Windows.Forms.TextBox();
            this.TimeEliminatedTextBox = new System.Windows.Forms.TextBox();
            this.PlayerLevel = new System.Windows.Forms.Label();
            this.TimeDied = new System.Windows.Forms.Label();
            this.PlayerLevelTextBox = new System.Windows.Forms.TextBox();
            this.PlacementTextBox = new System.Windows.Forms.TextBox();
            this.PlayerPlacement = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // APIKey
            // 
            this.APIKey.AutoSize = true;
            this.APIKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.APIKey.Location = new System.Drawing.Point(6, 70);
            this.APIKey.Name = "APIKey";
            this.APIKey.Size = new System.Drawing.Size(162, 26);
            this.APIKey.TabIndex = 46;
            this.APIKey.Text = "Enter API Key: ";
            // 
            // EnterAPITextBox
            // 
            this.EnterAPITextBox.Location = new System.Drawing.Point(6, 98);
            this.EnterAPITextBox.Name = "EnterAPITextBox";
            this.EnterAPITextBox.Size = new System.Drawing.Size(166, 20);
            this.EnterAPITextBox.TabIndex = 47;
            this.EnterAPITextBox.TextChanged += new System.EventHandler(this.EnterAPITextBox_TextChanged);
            // 
            // SummonerName
            // 
            this.SummonerName.AutoSize = true;
            this.SummonerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.SummonerName.Location = new System.Drawing.Point(6, 18);
            this.SummonerName.Name = "SummonerName";
            this.SummonerName.Size = new System.Drawing.Size(141, 26);
            this.SummonerName.TabIndex = 48;
            this.SummonerName.Text = "Enter Name :";
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(6, 47);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(166, 20);
            this.NameTextBox.TabIndex = 49;
            this.NameTextBox.TextChanged += new System.EventHandler(this.NameTextBox_TextChanged);
            // 
            // RecentMatch
            // 
            this.RecentMatch.AutoSize = true;
            this.RecentMatch.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.RecentMatch.Location = new System.Drawing.Point(6, 159);
            this.RecentMatch.Name = "RecentMatch";
            this.RecentMatch.Size = new System.Drawing.Size(181, 26);
            this.RecentMatch.TabIndex = 50;
            this.RecentMatch.Text = "Recent Matches :";
            // 
            // Search
            // 
            this.Search.Location = new System.Drawing.Point(6, 124);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(166, 23);
            this.Search.TabIndex = 51;
            this.Search.Text = "Search";
            this.Search.UseVisualStyleBackColor = true;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // MatchList
            // 
            this.MatchList.FormattingEnabled = true;
            this.MatchList.Location = new System.Drawing.Point(11, 195);
            this.MatchList.Name = "MatchList";
            this.MatchList.Size = new System.Drawing.Size(176, 277);
            this.MatchList.TabIndex = 53;
            this.MatchList.SelectedIndexChanged += new System.EventHandler(this.MatchList_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ParticipantList);
            this.groupBox1.Controls.Add(this.Traitlist);
            this.groupBox1.Controls.Add(this.GoldLeft);
            this.groupBox1.Controls.Add(this.Unitlist);
            this.groupBox1.Controls.Add(this.GoldTextBox);
            this.groupBox1.Controls.Add(this.Trait);
            this.groupBox1.Controls.Add(this.RoundDead);
            this.groupBox1.Controls.Add(this.Unit);
            this.groupBox1.Controls.Add(this.RoundDeadTextBox);
            this.groupBox1.Controls.Add(this.TimeEliminatedTextBox);
            this.groupBox1.Controls.Add(this.PlayerLevel);
            this.groupBox1.Controls.Add(this.TimeDied);
            this.groupBox1.Controls.Add(this.PlayerLevelTextBox);
            this.groupBox1.Controls.Add(this.PlacementTextBox);
            this.groupBox1.Controls.Add(this.PlayerPlacement);
            this.groupBox1.Location = new System.Drawing.Point(217, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(454, 489);
            this.groupBox1.TabIndex = 56;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Match Info";
            // 
            // ParticipantList
            // 
            this.ParticipantList.FormattingEnabled = true;
            this.ParticipantList.Location = new System.Drawing.Point(6, 17);
            this.ParticipantList.Name = "ParticipantList";
            this.ParticipantList.Size = new System.Drawing.Size(176, 199);
            this.ParticipantList.TabIndex = 54;
            this.ParticipantList.SelectedIndexChanged += new System.EventHandler(this.ParticipantList_SelectedIndexChanged);
            // 
            // Traitlist
            // 
            this.Traitlist.FormattingEnabled = true;
            this.Traitlist.Location = new System.Drawing.Point(212, 244);
            this.Traitlist.Name = "Traitlist";
            this.Traitlist.Size = new System.Drawing.Size(220, 225);
            this.Traitlist.TabIndex = 70;
            // 
            // GoldLeft
            // 
            this.GoldLeft.AutoSize = true;
            this.GoldLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.GoldLeft.Location = new System.Drawing.Point(188, 16);
            this.GoldLeft.Name = "GoldLeft";
            this.GoldLeft.Size = new System.Drawing.Size(112, 26);
            this.GoldLeft.TabIndex = 57;
            this.GoldLeft.Text = "Gold Left :";
            // 
            // Unitlist
            // 
            this.Unitlist.FormattingEnabled = true;
            this.Unitlist.Location = new System.Drawing.Point(6, 244);
            this.Unitlist.Name = "Unitlist";
            this.Unitlist.Size = new System.Drawing.Size(200, 225);
            this.Unitlist.TabIndex = 69;
            // 
            // GoldTextBox
            // 
            this.GoldTextBox.Location = new System.Drawing.Point(306, 19);
            this.GoldTextBox.Name = "GoldTextBox";
            this.GoldTextBox.Size = new System.Drawing.Size(127, 20);
            this.GoldTextBox.TabIndex = 58;
            // 
            // Trait
            // 
            this.Trait.AutoSize = true;
            this.Trait.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Trait.Location = new System.Drawing.Point(207, 215);
            this.Trait.Name = "Trait";
            this.Trait.Size = new System.Drawing.Size(71, 26);
            this.Trait.TabIndex = 68;
            this.Trait.Text = "Traits:";
            // 
            // RoundDead
            // 
            this.RoundDead.AutoSize = true;
            this.RoundDead.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.RoundDead.Location = new System.Drawing.Point(189, 59);
            this.RoundDead.Name = "RoundDead";
            this.RoundDead.Size = new System.Drawing.Size(146, 26);
            this.RoundDead.TabIndex = 59;
            this.RoundDead.Text = "Round Dead :";
            // 
            // Unit
            // 
            this.Unit.AutoSize = true;
            this.Unit.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Unit.Location = new System.Drawing.Point(6, 215);
            this.Unit.Name = "Unit";
            this.Unit.Size = new System.Drawing.Size(57, 26);
            this.Unit.TabIndex = 67;
            this.Unit.Text = "Unit:";
            // 
            // RoundDeadTextBox
            // 
            this.RoundDeadTextBox.Location = new System.Drawing.Point(341, 65);
            this.RoundDeadTextBox.Name = "RoundDeadTextBox";
            this.RoundDeadTextBox.Size = new System.Drawing.Size(91, 20);
            this.RoundDeadTextBox.TabIndex = 60;
            // 
            // TimeEliminatedTextBox
            // 
            this.TimeEliminatedTextBox.Location = new System.Drawing.Point(375, 196);
            this.TimeEliminatedTextBox.Name = "TimeEliminatedTextBox";
            this.TimeEliminatedTextBox.Size = new System.Drawing.Size(54, 20);
            this.TimeEliminatedTextBox.TabIndex = 66;
            // 
            // PlayerLevel
            // 
            this.PlayerLevel.AutoSize = true;
            this.PlayerLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.PlayerLevel.Location = new System.Drawing.Point(188, 98);
            this.PlayerLevel.Name = "PlayerLevel";
            this.PlayerLevel.Size = new System.Drawing.Size(144, 26);
            this.PlayerLevel.TabIndex = 61;
            this.PlayerLevel.Text = "Player Level :";
            // 
            // TimeDied
            // 
            this.TimeDied.AutoSize = true;
            this.TimeDied.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TimeDied.Location = new System.Drawing.Point(188, 189);
            this.TimeDied.Name = "TimeDied";
            this.TimeDied.Size = new System.Drawing.Size(181, 26);
            this.TimeDied.TabIndex = 65;
            this.TimeDied.Text = "Time Eliminated :";
            // 
            // PlayerLevelTextBox
            // 
            this.PlayerLevelTextBox.Location = new System.Drawing.Point(338, 104);
            this.PlayerLevelTextBox.Name = "PlayerLevelTextBox";
            this.PlayerLevelTextBox.Size = new System.Drawing.Size(91, 20);
            this.PlayerLevelTextBox.TabIndex = 62;
            // 
            // PlacementTextBox
            // 
            this.PlacementTextBox.Location = new System.Drawing.Point(390, 153);
            this.PlacementTextBox.Name = "PlacementTextBox";
            this.PlacementTextBox.Size = new System.Drawing.Size(39, 20);
            this.PlacementTextBox.TabIndex = 64;
            // 
            // PlayerPlacement
            // 
            this.PlayerPlacement.AutoSize = true;
            this.PlayerPlacement.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.PlayerPlacement.Location = new System.Drawing.Point(188, 147);
            this.PlayerPlacement.Name = "PlayerPlacement";
            this.PlayerPlacement.Size = new System.Drawing.Size(196, 26);
            this.PlayerPlacement.TabIndex = 63;
            this.PlayerPlacement.Text = "Player Placement :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.SummonerName);
            this.groupBox2.Controls.Add(this.NameTextBox);
            this.groupBox2.Controls.Add(this.MatchList);
            this.groupBox2.Controls.Add(this.APIKey);
            this.groupBox2.Controls.Add(this.RecentMatch);
            this.groupBox2.Controls.Add(this.Search);
            this.groupBox2.Controls.Add(this.EnterAPITextBox);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(199, 489);
            this.groupBox2.TabIndex = 71;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Player Info";
            // 
            // TFTAPI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 512);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "TFTAPI";
            this.Text = "TFT API";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label APIKey;
        private System.Windows.Forms.TextBox EnterAPITextBox;
        private System.Windows.Forms.Label SummonerName;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.Label RecentMatch;
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.ListBox MatchList;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox Traitlist;
        private System.Windows.Forms.Label GoldLeft;
        private System.Windows.Forms.ListBox Unitlist;
        private System.Windows.Forms.TextBox GoldTextBox;
        private System.Windows.Forms.Label Trait;
        private System.Windows.Forms.Label RoundDead;
        private System.Windows.Forms.Label Unit;
        private System.Windows.Forms.TextBox RoundDeadTextBox;
        private System.Windows.Forms.TextBox TimeEliminatedTextBox;
        private System.Windows.Forms.Label PlayerLevel;
        private System.Windows.Forms.Label TimeDied;
        private System.Windows.Forms.TextBox PlayerLevelTextBox;
        private System.Windows.Forms.TextBox PlacementTextBox;
        private System.Windows.Forms.Label PlayerPlacement;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox ParticipantList;
    }
}

