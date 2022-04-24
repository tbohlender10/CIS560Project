namespace CIS560_Project
{
    partial class Games
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
            this.uxCurrGameLabel = new System.Windows.Forms.Label();
            this.uxSave = new System.Windows.Forms.Button();
            this.uxBack = new System.Windows.Forms.Button();
            this.uxCurrPlayerLabel = new System.Windows.Forms.Label();
            this.uxMinutesLabel = new System.Windows.Forms.Label();
            this.uxMinutes = new System.Windows.Forms.TextBox();
            this.uxReboundsLabel = new System.Windows.Forms.Label();
            this.uxRebounds = new System.Windows.Forms.TextBox();
            this.uxFGALabel = new System.Windows.Forms.Label();
            this.uxFGA = new System.Windows.Forms.TextBox();
            this.uxFGMLabel = new System.Windows.Forms.Label();
            this.uxFGM = new System.Windows.Forms.TextBox();
            this.uxPointsLabel = new System.Windows.Forms.Label();
            this.uxPoints = new System.Windows.Forms.TextBox();
            this.uxEditPlayer = new System.Windows.Forms.Button();
            this.uxGameLabel = new System.Windows.Forms.Label();
            this.uxSelectGame = new System.Windows.Forms.ComboBox();
            this.uxPlayerLabel = new System.Windows.Forms.Label();
            this.uxTeamLabel = new System.Windows.Forms.Label();
            this.uxSelectPlayer = new System.Windows.Forms.ComboBox();
            this.uxSelectTeam = new System.Windows.Forms.ComboBox();
            this.uxViewGame = new System.Windows.Forms.Button();
            this.uxUpdateGame = new System.Windows.Forms.Button();
            this.uxViewPlayer = new System.Windows.Forms.Button();
            this.uxPlayerStats = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // uxCurrGameLabel
            // 
            this.uxCurrGameLabel.AutoSize = true;
            this.uxCurrGameLabel.Location = new System.Drawing.Point(477, 11);
            this.uxCurrGameLabel.Name = "uxCurrGameLabel";
            this.uxCurrGameLabel.Size = new System.Drawing.Size(109, 17);
            this.uxCurrGameLabel.TabIndex = 69;
            this.uxCurrGameLabel.Text = "Selected Game:";
            this.uxCurrGameLabel.Visible = false;
            // 
            // uxSave
            // 
            this.uxSave.Location = new System.Drawing.Point(655, 395);
            this.uxSave.Name = "uxSave";
            this.uxSave.Size = new System.Drawing.Size(116, 45);
            this.uxSave.TabIndex = 68;
            this.uxSave.Text = "Save";
            this.uxSave.UseVisualStyleBackColor = true;
            this.uxSave.Click += new System.EventHandler(this.uxSave_Click);
            // 
            // uxBack
            // 
            this.uxBack.Location = new System.Drawing.Point(29, 395);
            this.uxBack.Name = "uxBack";
            this.uxBack.Size = new System.Drawing.Size(116, 45);
            this.uxBack.TabIndex = 67;
            this.uxBack.Text = "Back";
            this.uxBack.UseVisualStyleBackColor = true;
            this.uxBack.Click += new System.EventHandler(this.uxBack_Click);
            // 
            // uxCurrPlayerLabel
            // 
            this.uxCurrPlayerLabel.AutoSize = true;
            this.uxCurrPlayerLabel.Location = new System.Drawing.Point(160, 11);
            this.uxCurrPlayerLabel.Name = "uxCurrPlayerLabel";
            this.uxCurrPlayerLabel.Size = new System.Drawing.Size(111, 17);
            this.uxCurrPlayerLabel.TabIndex = 66;
            this.uxCurrPlayerLabel.Text = "Selected Player:";
            this.uxCurrPlayerLabel.Visible = false;
            // 
            // uxMinutesLabel
            // 
            this.uxMinutesLabel.AutoSize = true;
            this.uxMinutesLabel.Location = new System.Drawing.Point(291, 334);
            this.uxMinutesLabel.Name = "uxMinutesLabel";
            this.uxMinutesLabel.Size = new System.Drawing.Size(61, 17);
            this.uxMinutesLabel.TabIndex = 65;
            this.uxMinutesLabel.Text = "Minutes:";
            this.uxMinutesLabel.Visible = false;
            // 
            // uxMinutes
            // 
            this.uxMinutes.Location = new System.Drawing.Point(363, 331);
            this.uxMinutes.Name = "uxMinutes";
            this.uxMinutes.Size = new System.Drawing.Size(100, 22);
            this.uxMinutes.TabIndex = 64;
            this.uxMinutes.Visible = false;
            // 
            // uxReboundsLabel
            // 
            this.uxReboundsLabel.AutoSize = true;
            this.uxReboundsLabel.Location = new System.Drawing.Point(280, 284);
            this.uxReboundsLabel.Name = "uxReboundsLabel";
            this.uxReboundsLabel.Size = new System.Drawing.Size(77, 17);
            this.uxReboundsLabel.TabIndex = 63;
            this.uxReboundsLabel.Text = "Rebounds:";
            this.uxReboundsLabel.Visible = false;
            // 
            // uxRebounds
            // 
            this.uxRebounds.Location = new System.Drawing.Point(363, 281);
            this.uxRebounds.Name = "uxRebounds";
            this.uxRebounds.Size = new System.Drawing.Size(100, 22);
            this.uxRebounds.TabIndex = 62;
            this.uxRebounds.Visible = false;
            // 
            // uxFGALabel
            // 
            this.uxFGALabel.AutoSize = true;
            this.uxFGALabel.Location = new System.Drawing.Point(310, 237);
            this.uxFGALabel.Name = "uxFGALabel";
            this.uxFGALabel.Size = new System.Drawing.Size(40, 17);
            this.uxFGALabel.TabIndex = 61;
            this.uxFGALabel.Text = "FGA:";
            this.uxFGALabel.Visible = false;
            // 
            // uxFGA
            // 
            this.uxFGA.Location = new System.Drawing.Point(363, 234);
            this.uxFGA.Name = "uxFGA";
            this.uxFGA.Size = new System.Drawing.Size(100, 22);
            this.uxFGA.TabIndex = 60;
            this.uxFGA.Visible = false;
            // 
            // uxFGMLabel
            // 
            this.uxFGMLabel.AutoSize = true;
            this.uxFGMLabel.Location = new System.Drawing.Point(310, 189);
            this.uxFGMLabel.Name = "uxFGMLabel";
            this.uxFGMLabel.Size = new System.Drawing.Size(42, 17);
            this.uxFGMLabel.TabIndex = 59;
            this.uxFGMLabel.Text = "FGM:";
            this.uxFGMLabel.Visible = false;
            // 
            // uxFGM
            // 
            this.uxFGM.Location = new System.Drawing.Point(363, 186);
            this.uxFGM.Name = "uxFGM";
            this.uxFGM.Size = new System.Drawing.Size(100, 22);
            this.uxFGM.TabIndex = 58;
            this.uxFGM.Visible = false;
            // 
            // uxPointsLabel
            // 
            this.uxPointsLabel.AutoSize = true;
            this.uxPointsLabel.Location = new System.Drawing.Point(310, 141);
            this.uxPointsLabel.Name = "uxPointsLabel";
            this.uxPointsLabel.Size = new System.Drawing.Size(51, 17);
            this.uxPointsLabel.TabIndex = 57;
            this.uxPointsLabel.Text = "Points:";
            this.uxPointsLabel.Visible = false;
            // 
            // uxPoints
            // 
            this.uxPoints.Location = new System.Drawing.Point(363, 138);
            this.uxPoints.Name = "uxPoints";
            this.uxPoints.Size = new System.Drawing.Size(100, 22);
            this.uxPoints.TabIndex = 56;
            this.uxPoints.Visible = false;
            // 
            // uxEditPlayer
            // 
            this.uxEditPlayer.Enabled = false;
            this.uxEditPlayer.Location = new System.Drawing.Point(594, 284);
            this.uxEditPlayer.Name = "uxEditPlayer";
            this.uxEditPlayer.Size = new System.Drawing.Size(101, 54);
            this.uxEditPlayer.TabIndex = 55;
            this.uxEditPlayer.Text = "Edit Player Stats";
            this.uxEditPlayer.UseVisualStyleBackColor = true;
            this.uxEditPlayer.Click += new System.EventHandler(this.uxEditPlayer_Click);
            // 
            // uxGameLabel
            // 
            this.uxGameLabel.AutoSize = true;
            this.uxGameLabel.Location = new System.Drawing.Point(97, 44);
            this.uxGameLabel.Name = "uxGameLabel";
            this.uxGameLabel.Size = new System.Drawing.Size(93, 17);
            this.uxGameLabel.TabIndex = 54;
            this.uxGameLabel.Text = "Select Game:";
            // 
            // uxSelectGame
            // 
            this.uxSelectGame.AllowDrop = true;
            this.uxSelectGame.DisplayMember = "Select Team";
            this.uxSelectGame.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.uxSelectGame.FormattingEnabled = true;
            this.uxSelectGame.Location = new System.Drawing.Point(63, 75);
            this.uxSelectGame.MaxDropDownItems = 64;
            this.uxSelectGame.Name = "uxSelectGame";
            this.uxSelectGame.Size = new System.Drawing.Size(150, 24);
            this.uxSelectGame.Sorted = true;
            this.uxSelectGame.TabIndex = 53;
            this.uxSelectGame.SelectedIndexChanged += new System.EventHandler(this.uxSelectGame_SelectedIndexChanged);
            // 
            // uxPlayerLabel
            // 
            this.uxPlayerLabel.AutoSize = true;
            this.uxPlayerLabel.Location = new System.Drawing.Point(591, 44);
            this.uxPlayerLabel.Name = "uxPlayerLabel";
            this.uxPlayerLabel.Size = new System.Drawing.Size(95, 17);
            this.uxPlayerLabel.TabIndex = 52;
            this.uxPlayerLabel.Text = "Select Player:";
            // 
            // uxTeamLabel
            // 
            this.uxTeamLabel.AutoSize = true;
            this.uxTeamLabel.Location = new System.Drawing.Point(347, 44);
            this.uxTeamLabel.Name = "uxTeamLabel";
            this.uxTeamLabel.Size = new System.Drawing.Size(91, 17);
            this.uxTeamLabel.TabIndex = 51;
            this.uxTeamLabel.Text = "Select Team:";
            // 
            // uxSelectPlayer
            // 
            this.uxSelectPlayer.AllowDrop = true;
            this.uxSelectPlayer.DisplayMember = "Select Player";
            this.uxSelectPlayer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.uxSelectPlayer.Enabled = false;
            this.uxSelectPlayer.FormattingEnabled = true;
            this.uxSelectPlayer.Location = new System.Drawing.Point(567, 75);
            this.uxSelectPlayer.MaxDropDownItems = 20;
            this.uxSelectPlayer.Name = "uxSelectPlayer";
            this.uxSelectPlayer.Size = new System.Drawing.Size(150, 24);
            this.uxSelectPlayer.Sorted = true;
            this.uxSelectPlayer.TabIndex = 50;
            this.uxSelectPlayer.SelectedIndexChanged += new System.EventHandler(this.uxSelectPlayer_SelectedIndexChanged);
            // 
            // uxSelectTeam
            // 
            this.uxSelectTeam.AllowDrop = true;
            this.uxSelectTeam.DisplayMember = "Select Team";
            this.uxSelectTeam.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.uxSelectTeam.Enabled = false;
            this.uxSelectTeam.FormattingEnabled = true;
            this.uxSelectTeam.Location = new System.Drawing.Point(313, 75);
            this.uxSelectTeam.MaxDropDownItems = 64;
            this.uxSelectTeam.Name = "uxSelectTeam";
            this.uxSelectTeam.Size = new System.Drawing.Size(150, 24);
            this.uxSelectTeam.Sorted = true;
            this.uxSelectTeam.TabIndex = 49;
            this.uxSelectTeam.SelectedIndexChanged += new System.EventHandler(this.uxSelectTeam_SelectedIndexChanged);
            // 
            // uxViewGame
            // 
            this.uxViewGame.Enabled = false;
            this.uxViewGame.Location = new System.Drawing.Point(89, 170);
            this.uxViewGame.Name = "uxViewGame";
            this.uxViewGame.Size = new System.Drawing.Size(101, 54);
            this.uxViewGame.TabIndex = 70;
            this.uxViewGame.Text = "View Game Stats";
            this.uxViewGame.UseVisualStyleBackColor = true;
            // 
            // uxUpdateGame
            // 
            this.uxUpdateGame.Enabled = false;
            this.uxUpdateGame.Location = new System.Drawing.Point(89, 281);
            this.uxUpdateGame.Name = "uxUpdateGame";
            this.uxUpdateGame.Size = new System.Drawing.Size(101, 54);
            this.uxUpdateGame.TabIndex = 71;
            this.uxUpdateGame.Text = "Update Game Stats";
            this.uxUpdateGame.UseVisualStyleBackColor = true;
            // 
            // uxViewPlayer
            // 
            this.uxViewPlayer.Enabled = false;
            this.uxViewPlayer.Location = new System.Drawing.Point(594, 170);
            this.uxViewPlayer.Name = "uxViewPlayer";
            this.uxViewPlayer.Size = new System.Drawing.Size(101, 54);
            this.uxViewPlayer.TabIndex = 72;
            this.uxViewPlayer.Text = "View Player Stats";
            this.uxViewPlayer.UseVisualStyleBackColor = true;
            this.uxViewPlayer.Click += new System.EventHandler(this.uxViewPlayer_Click);
            // 
            // uxPlayerStats
            // 
            this.uxPlayerStats.AutoSize = true;
            this.uxPlayerStats.Location = new System.Drawing.Point(329, 166);
            this.uxPlayerStats.Name = "uxPlayerStats";
            this.uxPlayerStats.Size = new System.Drawing.Size(125, 17);
            this.uxPlayerStats.TabIndex = 73;
            this.uxPlayerStats.Text = "(player stats label)";
            // 
            // Games
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.uxPlayerStats);
            this.Controls.Add(this.uxViewPlayer);
            this.Controls.Add(this.uxUpdateGame);
            this.Controls.Add(this.uxViewGame);
            this.Controls.Add(this.uxCurrGameLabel);
            this.Controls.Add(this.uxSave);
            this.Controls.Add(this.uxBack);
            this.Controls.Add(this.uxCurrPlayerLabel);
            this.Controls.Add(this.uxMinutesLabel);
            this.Controls.Add(this.uxMinutes);
            this.Controls.Add(this.uxReboundsLabel);
            this.Controls.Add(this.uxRebounds);
            this.Controls.Add(this.uxFGALabel);
            this.Controls.Add(this.uxFGA);
            this.Controls.Add(this.uxFGMLabel);
            this.Controls.Add(this.uxFGM);
            this.Controls.Add(this.uxPointsLabel);
            this.Controls.Add(this.uxPoints);
            this.Controls.Add(this.uxEditPlayer);
            this.Controls.Add(this.uxGameLabel);
            this.Controls.Add(this.uxSelectGame);
            this.Controls.Add(this.uxPlayerLabel);
            this.Controls.Add(this.uxTeamLabel);
            this.Controls.Add(this.uxSelectPlayer);
            this.Controls.Add(this.uxSelectTeam);
            this.Name = "Games";
            this.Text = "Games";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Games_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label uxCurrGameLabel;
        private System.Windows.Forms.Button uxSave;
        private System.Windows.Forms.Button uxBack;
        private System.Windows.Forms.Label uxCurrPlayerLabel;
        private System.Windows.Forms.Label uxMinutesLabel;
        private System.Windows.Forms.TextBox uxMinutes;
        private System.Windows.Forms.Label uxReboundsLabel;
        private System.Windows.Forms.TextBox uxRebounds;
        private System.Windows.Forms.Label uxFGALabel;
        private System.Windows.Forms.TextBox uxFGA;
        private System.Windows.Forms.Label uxFGMLabel;
        private System.Windows.Forms.TextBox uxFGM;
        private System.Windows.Forms.Label uxPointsLabel;
        private System.Windows.Forms.TextBox uxPoints;
        private System.Windows.Forms.Button uxEditPlayer;
        private System.Windows.Forms.Label uxGameLabel;
        private System.Windows.Forms.ComboBox uxSelectGame;
        private System.Windows.Forms.Label uxPlayerLabel;
        private System.Windows.Forms.Label uxTeamLabel;
        private System.Windows.Forms.ComboBox uxSelectPlayer;
        private System.Windows.Forms.ComboBox uxSelectTeam;
        private System.Windows.Forms.Button uxViewGame;
        private System.Windows.Forms.Button uxUpdateGame;
        private System.Windows.Forms.Button uxViewPlayer;
        private System.Windows.Forms.Label uxPlayerStats;
    }
}