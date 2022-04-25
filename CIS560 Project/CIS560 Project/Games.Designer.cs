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
            this.uxEditPlayer = new System.Windows.Forms.Button();
            this.uxGameLabel = new System.Windows.Forms.Label();
            this.uxSelectGame = new System.Windows.Forms.ComboBox();
            this.uxViewGame = new System.Windows.Forms.Button();
            this.uxUpdateGame = new System.Windows.Forms.Button();
            this.uxViewPlayer = new System.Windows.Forms.Button();
            this.uxSelectPlayer = new System.Windows.Forms.ComboBox();
            this.uxPlayerLabel = new System.Windows.Forms.Label();
            this.uxSelectTeam = new System.Windows.Forms.ComboBox();
            this.uxTeamLabel = new System.Windows.Forms.Label();
            this.uxPointsLabel = new System.Windows.Forms.Label();
            this.uxFGMLabel = new System.Windows.Forms.Label();
            this.uxFGALabel = new System.Windows.Forms.Label();
            this.uxReboundsLabel = new System.Windows.Forms.Label();
            this.uxMinutesLabel = new System.Windows.Forms.Label();
            this.uxPlayerStats = new System.Windows.Forms.Label();
            this.uxPoints = new System.Windows.Forms.NumericUpDown();
            this.uxFGM = new System.Windows.Forms.NumericUpDown();
            this.uxFGA = new System.Windows.Forms.NumericUpDown();
            this.uxRebounds = new System.Windows.Forms.NumericUpDown();
            this.uxMinutes = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.uxPoints)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uxFGM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uxFGA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uxRebounds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uxMinutes)).BeginInit();
            this.SuspendLayout();
            // 
            // uxCurrGameLabel
            // 
            this.uxCurrGameLabel.AutoSize = true;
            this.uxCurrGameLabel.Location = new System.Drawing.Point(537, 14);
            this.uxCurrGameLabel.Name = "uxCurrGameLabel";
            this.uxCurrGameLabel.Size = new System.Drawing.Size(124, 20);
            this.uxCurrGameLabel.TabIndex = 69;
            this.uxCurrGameLabel.Text = "Selected Game:";
            this.uxCurrGameLabel.Visible = false;
            // 
            // uxSave
            // 
            this.uxSave.Location = new System.Drawing.Point(737, 494);
            this.uxSave.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.uxSave.Name = "uxSave";
            this.uxSave.Size = new System.Drawing.Size(130, 56);
            this.uxSave.TabIndex = 68;
            this.uxSave.Text = "Save";
            this.uxSave.UseVisualStyleBackColor = true;
            this.uxSave.Click += new System.EventHandler(this.uxSave_Click);
            // 
            // uxBack
            // 
            this.uxBack.Location = new System.Drawing.Point(33, 494);
            this.uxBack.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.uxBack.Name = "uxBack";
            this.uxBack.Size = new System.Drawing.Size(130, 56);
            this.uxBack.TabIndex = 67;
            this.uxBack.Text = "Back";
            this.uxBack.UseVisualStyleBackColor = true;
            this.uxBack.Click += new System.EventHandler(this.uxBack_Click);
            // 
            // uxCurrPlayerLabel
            // 
            this.uxCurrPlayerLabel.AutoSize = true;
            this.uxCurrPlayerLabel.Location = new System.Drawing.Point(180, 14);
            this.uxCurrPlayerLabel.Name = "uxCurrPlayerLabel";
            this.uxCurrPlayerLabel.Size = new System.Drawing.Size(123, 20);
            this.uxCurrPlayerLabel.TabIndex = 66;
            this.uxCurrPlayerLabel.Text = "Selected Player:";
            this.uxCurrPlayerLabel.Visible = false;
            // 
            // uxEditPlayer
            // 
            this.uxEditPlayer.Enabled = false;
            this.uxEditPlayer.Location = new System.Drawing.Point(668, 355);
            this.uxEditPlayer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.uxEditPlayer.Name = "uxEditPlayer";
            this.uxEditPlayer.Size = new System.Drawing.Size(114, 68);
            this.uxEditPlayer.TabIndex = 55;
            this.uxEditPlayer.Text = "Edit Player Stats";
            this.uxEditPlayer.UseVisualStyleBackColor = true;
            this.uxEditPlayer.Click += new System.EventHandler(this.uxEditPlayer_Click);
            // 
            // uxGameLabel
            // 
            this.uxGameLabel.AutoSize = true;
            this.uxGameLabel.Location = new System.Drawing.Point(109, 55);
            this.uxGameLabel.Name = "uxGameLabel";
            this.uxGameLabel.Size = new System.Drawing.Size(106, 20);
            this.uxGameLabel.TabIndex = 54;
            this.uxGameLabel.Text = "Select Game:";
            // 
            // uxSelectGame
            // 
            this.uxSelectGame.AllowDrop = true;
            this.uxSelectGame.DisplayMember = "Select Team";
            this.uxSelectGame.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.uxSelectGame.FormattingEnabled = true;
            this.uxSelectGame.Location = new System.Drawing.Point(71, 94);
            this.uxSelectGame.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.uxSelectGame.MaxDropDownItems = 5;
            this.uxSelectGame.Name = "uxSelectGame";
            this.uxSelectGame.Size = new System.Drawing.Size(168, 28);
            this.uxSelectGame.Sorted = true;
            this.uxSelectGame.TabIndex = 53;
            this.uxSelectGame.SelectedIndexChanged += new System.EventHandler(this.uxSelectGame_SelectedIndexChanged);
            // 
            // uxViewGame
            // 
            this.uxViewGame.Enabled = false;
            this.uxViewGame.Location = new System.Drawing.Point(100, 212);
            this.uxViewGame.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.uxViewGame.Name = "uxViewGame";
            this.uxViewGame.Size = new System.Drawing.Size(114, 68);
            this.uxViewGame.TabIndex = 70;
            this.uxViewGame.Text = "View Game Stats";
            this.uxViewGame.UseVisualStyleBackColor = true;
            this.uxViewGame.Click += new System.EventHandler(this.uxViewGame_Click);
            // 
            // uxUpdateGame
            // 
            this.uxUpdateGame.Enabled = false;
            this.uxUpdateGame.Location = new System.Drawing.Point(100, 351);
            this.uxUpdateGame.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.uxUpdateGame.Name = "uxUpdateGame";
            this.uxUpdateGame.Size = new System.Drawing.Size(114, 68);
            this.uxUpdateGame.TabIndex = 71;
            this.uxUpdateGame.Text = "Update Game Stats";
            this.uxUpdateGame.UseVisualStyleBackColor = true;
            this.uxUpdateGame.Click += new System.EventHandler(this.uxUpdateGame_Click);
            // 
            // uxViewPlayer
            // 
            this.uxViewPlayer.Enabled = false;
            this.uxViewPlayer.Location = new System.Drawing.Point(668, 212);
            this.uxViewPlayer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.uxViewPlayer.Name = "uxViewPlayer";
            this.uxViewPlayer.Size = new System.Drawing.Size(114, 68);
            this.uxViewPlayer.TabIndex = 72;
            this.uxViewPlayer.Text = "View Player Stats";
            this.uxViewPlayer.UseVisualStyleBackColor = true;
            this.uxViewPlayer.Click += new System.EventHandler(this.uxViewPlayer_Click);
            // 
            // uxSelectPlayer
            // 
            this.uxSelectPlayer.AllowDrop = true;
            this.uxSelectPlayer.DisplayMember = "Select Player";
            this.uxSelectPlayer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.uxSelectPlayer.Enabled = false;
            this.uxSelectPlayer.FormattingEnabled = true;
            this.uxSelectPlayer.Location = new System.Drawing.Point(638, 94);
            this.uxSelectPlayer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.uxSelectPlayer.MaxDropDownItems = 10;
            this.uxSelectPlayer.Name = "uxSelectPlayer";
            this.uxSelectPlayer.Size = new System.Drawing.Size(168, 28);
            this.uxSelectPlayer.Sorted = true;
            this.uxSelectPlayer.TabIndex = 50;
            this.uxSelectPlayer.SelectedIndexChanged += new System.EventHandler(this.uxSelectPlayer_SelectedIndexChanged);
            // 
            // uxPlayerLabel
            // 
            this.uxPlayerLabel.AutoSize = true;
            this.uxPlayerLabel.Location = new System.Drawing.Point(665, 55);
            this.uxPlayerLabel.Name = "uxPlayerLabel";
            this.uxPlayerLabel.Size = new System.Drawing.Size(105, 20);
            this.uxPlayerLabel.TabIndex = 52;
            this.uxPlayerLabel.Text = "Select Player:";
            // 
            // uxSelectTeam
            // 
            this.uxSelectTeam.AllowDrop = true;
            this.uxSelectTeam.DisplayMember = "Select Team";
            this.uxSelectTeam.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.uxSelectTeam.Enabled = false;
            this.uxSelectTeam.FormattingEnabled = true;
            this.uxSelectTeam.Location = new System.Drawing.Point(352, 94);
            this.uxSelectTeam.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.uxSelectTeam.MaxDropDownItems = 10;
            this.uxSelectTeam.Name = "uxSelectTeam";
            this.uxSelectTeam.Size = new System.Drawing.Size(168, 28);
            this.uxSelectTeam.Sorted = true;
            this.uxSelectTeam.TabIndex = 49;
            this.uxSelectTeam.SelectedIndexChanged += new System.EventHandler(this.uxSelectTeam_SelectedIndexChanged);
            // 
            // uxTeamLabel
            // 
            this.uxTeamLabel.AutoSize = true;
            this.uxTeamLabel.Location = new System.Drawing.Point(390, 55);
            this.uxTeamLabel.Name = "uxTeamLabel";
            this.uxTeamLabel.Size = new System.Drawing.Size(102, 20);
            this.uxTeamLabel.TabIndex = 51;
            this.uxTeamLabel.Text = "Select Team:";
            // 
            // uxPointsLabel
            // 
            this.uxPointsLabel.AutoSize = true;
            this.uxPointsLabel.Location = new System.Drawing.Point(345, 176);
            this.uxPointsLabel.Name = "uxPointsLabel";
            this.uxPointsLabel.Size = new System.Drawing.Size(57, 20);
            this.uxPointsLabel.TabIndex = 57;
            this.uxPointsLabel.Text = "Points:";
            this.uxPointsLabel.Visible = false;
            // 
            // uxFGMLabel
            // 
            this.uxFGMLabel.AutoSize = true;
            this.uxFGMLabel.Location = new System.Drawing.Point(353, 236);
            this.uxFGMLabel.Name = "uxFGMLabel";
            this.uxFGMLabel.Size = new System.Drawing.Size(49, 20);
            this.uxFGMLabel.TabIndex = 59;
            this.uxFGMLabel.Text = "FGM:";
            this.uxFGMLabel.Visible = false;
            // 
            // uxFGALabel
            // 
            this.uxFGALabel.AutoSize = true;
            this.uxFGALabel.Location = new System.Drawing.Point(355, 294);
            this.uxFGALabel.Name = "uxFGALabel";
            this.uxFGALabel.Size = new System.Drawing.Size(47, 20);
            this.uxFGALabel.TabIndex = 61;
            this.uxFGALabel.Text = "FGA:";
            this.uxFGALabel.Visible = false;
            // 
            // uxReboundsLabel
            // 
            this.uxReboundsLabel.AutoSize = true;
            this.uxReboundsLabel.Location = new System.Drawing.Point(315, 355);
            this.uxReboundsLabel.Name = "uxReboundsLabel";
            this.uxReboundsLabel.Size = new System.Drawing.Size(87, 20);
            this.uxReboundsLabel.TabIndex = 63;
            this.uxReboundsLabel.Text = "Rebounds:";
            this.uxReboundsLabel.Visible = false;
            // 
            // uxMinutesLabel
            // 
            this.uxMinutesLabel.AutoSize = true;
            this.uxMinutesLabel.Location = new System.Drawing.Point(333, 418);
            this.uxMinutesLabel.Name = "uxMinutesLabel";
            this.uxMinutesLabel.Size = new System.Drawing.Size(69, 20);
            this.uxMinutesLabel.TabIndex = 65;
            this.uxMinutesLabel.Text = "Minutes:";
            this.uxMinutesLabel.Visible = false;
            // 
            // uxPlayerStats
            // 
            this.uxPlayerStats.AutoSize = true;
            this.uxPlayerStats.Location = new System.Drawing.Point(370, 208);
            this.uxPlayerStats.Name = "uxPlayerStats";
            this.uxPlayerStats.Size = new System.Drawing.Size(137, 20);
            this.uxPlayerStats.TabIndex = 73;
            this.uxPlayerStats.Text = "(player stats label)";
            // 
            // uxPoints
            // 
            this.uxPoints.Location = new System.Drawing.Point(408, 174);
            this.uxPoints.Name = "uxPoints";
            this.uxPoints.Size = new System.Drawing.Size(120, 26);
            this.uxPoints.TabIndex = 74;
            this.uxPoints.Visible = false;
            this.uxPoints.ValueChanged += new System.EventHandler(this.uxPoints_ValueChanged);
            // 
            // uxFGM
            // 
            this.uxFGM.Location = new System.Drawing.Point(408, 234);
            this.uxFGM.Name = "uxFGM";
            this.uxFGM.Size = new System.Drawing.Size(120, 26);
            this.uxFGM.TabIndex = 75;
            this.uxFGM.Visible = false;
            this.uxFGM.ValueChanged += new System.EventHandler(this.uxFGM_ValueChanged);
            // 
            // uxFGA
            // 
            this.uxFGA.Location = new System.Drawing.Point(408, 292);
            this.uxFGA.Name = "uxFGA";
            this.uxFGA.Size = new System.Drawing.Size(120, 26);
            this.uxFGA.TabIndex = 76;
            this.uxFGA.Visible = false;
            this.uxFGA.ValueChanged += new System.EventHandler(this.uxFGA_ValueChanged);
            // 
            // uxRebounds
            // 
            this.uxRebounds.Location = new System.Drawing.Point(408, 351);
            this.uxRebounds.Name = "uxRebounds";
            this.uxRebounds.Size = new System.Drawing.Size(120, 26);
            this.uxRebounds.TabIndex = 77;
            this.uxRebounds.Visible = false;
            this.uxRebounds.ValueChanged += new System.EventHandler(this.uxRebounds_ValueChanged);
            // 
            // uxMinutes
            // 
            this.uxMinutes.Location = new System.Drawing.Point(408, 416);
            this.uxMinutes.Name = "uxMinutes";
            this.uxMinutes.Size = new System.Drawing.Size(120, 26);
            this.uxMinutes.TabIndex = 78;
            this.uxMinutes.Visible = false;
            this.uxMinutes.ValueChanged += new System.EventHandler(this.uxMinutes_ValueChanged);
            // 
            // Games
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 562);
            this.Controls.Add(this.uxMinutes);
            this.Controls.Add(this.uxRebounds);
            this.Controls.Add(this.uxFGA);
            this.Controls.Add(this.uxFGM);
            this.Controls.Add(this.uxPoints);
            this.Controls.Add(this.uxPlayerStats);
            this.Controls.Add(this.uxViewPlayer);
            this.Controls.Add(this.uxUpdateGame);
            this.Controls.Add(this.uxViewGame);
            this.Controls.Add(this.uxCurrGameLabel);
            this.Controls.Add(this.uxSave);
            this.Controls.Add(this.uxBack);
            this.Controls.Add(this.uxCurrPlayerLabel);
            this.Controls.Add(this.uxMinutesLabel);
            this.Controls.Add(this.uxReboundsLabel);
            this.Controls.Add(this.uxFGALabel);
            this.Controls.Add(this.uxFGMLabel);
            this.Controls.Add(this.uxPointsLabel);
            this.Controls.Add(this.uxEditPlayer);
            this.Controls.Add(this.uxGameLabel);
            this.Controls.Add(this.uxSelectGame);
            this.Controls.Add(this.uxPlayerLabel);
            this.Controls.Add(this.uxTeamLabel);
            this.Controls.Add(this.uxSelectPlayer);
            this.Controls.Add(this.uxSelectTeam);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Games";
            this.Text = "Games";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Games_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.uxPoints)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uxFGM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uxFGA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uxRebounds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uxMinutes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label uxCurrGameLabel;
        private System.Windows.Forms.Button uxSave;
        private System.Windows.Forms.Button uxBack;
        private System.Windows.Forms.Label uxCurrPlayerLabel;
        private System.Windows.Forms.Button uxEditPlayer;
        private System.Windows.Forms.Label uxGameLabel;
        private System.Windows.Forms.ComboBox uxSelectGame;
        private System.Windows.Forms.Button uxViewGame;
        private System.Windows.Forms.Button uxUpdateGame;
        private System.Windows.Forms.Button uxViewPlayer;
        private System.Windows.Forms.ComboBox uxSelectPlayer;
        private System.Windows.Forms.Label uxPlayerLabel;
        private System.Windows.Forms.ComboBox uxSelectTeam;
        private System.Windows.Forms.Label uxTeamLabel;
        private System.Windows.Forms.Label uxPointsLabel;
        private System.Windows.Forms.Label uxFGMLabel;
        private System.Windows.Forms.Label uxFGALabel;
        private System.Windows.Forms.Label uxReboundsLabel;
        private System.Windows.Forms.Label uxMinutesLabel;
        private System.Windows.Forms.Label uxPlayerStats;
        private System.Windows.Forms.NumericUpDown uxPoints;
        private System.Windows.Forms.NumericUpDown uxFGM;
        private System.Windows.Forms.NumericUpDown uxFGA;
        private System.Windows.Forms.NumericUpDown uxRebounds;
        private System.Windows.Forms.NumericUpDown uxMinutes;
    }
}