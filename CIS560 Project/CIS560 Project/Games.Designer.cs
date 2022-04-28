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
            this.uxThreePoints = new System.Windows.Forms.NumericUpDown();
            this.uxThreePointsLabel = new System.Windows.Forms.Label();
            this.uxDeletePlayerStats = new System.Windows.Forms.Button();
            this.uxDeleteGameStats = new System.Windows.Forms.Button();
            this.uxInsertGameStats = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.uxPoints)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uxFGM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uxFGA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uxRebounds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uxMinutes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uxThreePoints)).BeginInit();
            this.SuspendLayout();
            // 
            // uxCurrGameLabel
            // 
            this.uxCurrGameLabel.AutoSize = true;
            this.uxCurrGameLabel.Font = new System.Drawing.Font("Berlin Sans FB", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxCurrGameLabel.Location = new System.Drawing.Point(110, 9);
            this.uxCurrGameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.uxCurrGameLabel.Name = "uxCurrGameLabel";
            this.uxCurrGameLabel.Size = new System.Drawing.Size(104, 17);
            this.uxCurrGameLabel.TabIndex = 69;
            this.uxCurrGameLabel.Text = "Selected Game:";
            this.uxCurrGameLabel.Visible = false;
            // 
            // uxSave
            // 
            this.uxSave.Font = new System.Drawing.Font("Berlin Sans FB", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxSave.Location = new System.Drawing.Point(491, 321);
            this.uxSave.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.uxSave.Name = "uxSave";
            this.uxSave.Size = new System.Drawing.Size(87, 36);
            this.uxSave.TabIndex = 68;
            this.uxSave.Text = "Save";
            this.uxSave.UseVisualStyleBackColor = true;
            this.uxSave.Click += new System.EventHandler(this.uxSave_Click);
            // 
            // uxBack
            // 
            this.uxBack.Font = new System.Drawing.Font("Berlin Sans FB", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxBack.Location = new System.Drawing.Point(22, 321);
            this.uxBack.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.uxBack.Name = "uxBack";
            this.uxBack.Size = new System.Drawing.Size(87, 36);
            this.uxBack.TabIndex = 67;
            this.uxBack.Text = "Back";
            this.uxBack.UseVisualStyleBackColor = true;
            this.uxBack.Click += new System.EventHandler(this.uxBack_Click);
            // 
            // uxCurrPlayerLabel
            // 
            this.uxCurrPlayerLabel.AutoSize = true;
            this.uxCurrPlayerLabel.Font = new System.Drawing.Font("Berlin Sans FB", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxCurrPlayerLabel.Location = new System.Drawing.Point(19, 9);
            this.uxCurrPlayerLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.uxCurrPlayerLabel.Name = "uxCurrPlayerLabel";
            this.uxCurrPlayerLabel.Size = new System.Drawing.Size(105, 17);
            this.uxCurrPlayerLabel.TabIndex = 66;
            this.uxCurrPlayerLabel.Text = "Selected Player:";
            this.uxCurrPlayerLabel.Visible = false;
            // 
            // uxEditPlayer
            // 
            this.uxEditPlayer.Enabled = false;
            this.uxEditPlayer.Font = new System.Drawing.Font("Berlin Sans FB", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxEditPlayer.Location = new System.Drawing.Point(457, 170);
            this.uxEditPlayer.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.uxEditPlayer.Name = "uxEditPlayer";
            this.uxEditPlayer.Size = new System.Drawing.Size(76, 44);
            this.uxEditPlayer.TabIndex = 55;
            this.uxEditPlayer.Text = "Edit Player Stats";
            this.uxEditPlayer.UseVisualStyleBackColor = true;
            this.uxEditPlayer.Click += new System.EventHandler(this.uxEditPlayer_Click);
            // 
            // uxGameLabel
            // 
            this.uxGameLabel.AutoSize = true;
            this.uxGameLabel.Font = new System.Drawing.Font("Berlin Sans FB", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxGameLabel.Location = new System.Drawing.Point(55, 36);
            this.uxGameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.uxGameLabel.Name = "uxGameLabel";
            this.uxGameLabel.Size = new System.Drawing.Size(89, 17);
            this.uxGameLabel.TabIndex = 54;
            this.uxGameLabel.Text = "Select Game:";
            // 
            // uxSelectGame
            // 
            this.uxSelectGame.AllowDrop = true;
            this.uxSelectGame.DisplayMember = "Select Team";
            this.uxSelectGame.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.uxSelectGame.DropDownWidth = 120;
            this.uxSelectGame.FormattingEnabled = true;
            this.uxSelectGame.Location = new System.Drawing.Point(22, 61);
            this.uxSelectGame.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.uxSelectGame.MaxDropDownItems = 5;
            this.uxSelectGame.Name = "uxSelectGame";
            this.uxSelectGame.Size = new System.Drawing.Size(151, 21);
            this.uxSelectGame.Sorted = true;
            this.uxSelectGame.TabIndex = 53;
            this.uxSelectGame.SelectedIndexChanged += new System.EventHandler(this.uxSelectGame_SelectedIndexChanged);
            // 
            // uxViewGame
            // 
            this.uxViewGame.Enabled = false;
            this.uxViewGame.Font = new System.Drawing.Font("Berlin Sans FB", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxViewGame.Location = new System.Drawing.Point(58, 105);
            this.uxViewGame.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.uxViewGame.Name = "uxViewGame";
            this.uxViewGame.Size = new System.Drawing.Size(76, 44);
            this.uxViewGame.TabIndex = 70;
            this.uxViewGame.Text = "View Game Stats";
            this.uxViewGame.UseVisualStyleBackColor = true;
            this.uxViewGame.Click += new System.EventHandler(this.uxViewGame_Click);
            // 
            // uxViewPlayer
            // 
            this.uxViewPlayer.Enabled = false;
            this.uxViewPlayer.Font = new System.Drawing.Font("Berlin Sans FB", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxViewPlayer.Location = new System.Drawing.Point(457, 104);
            this.uxViewPlayer.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.uxViewPlayer.Name = "uxViewPlayer";
            this.uxViewPlayer.Size = new System.Drawing.Size(76, 44);
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
            this.uxSelectPlayer.Location = new System.Drawing.Point(415, 61);
            this.uxSelectPlayer.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.uxSelectPlayer.MaxDropDownItems = 10;
            this.uxSelectPlayer.Name = "uxSelectPlayer";
            this.uxSelectPlayer.Size = new System.Drawing.Size(153, 21);
            this.uxSelectPlayer.Sorted = true;
            this.uxSelectPlayer.TabIndex = 50;
            this.uxSelectPlayer.SelectedIndexChanged += new System.EventHandler(this.uxSelectPlayer_SelectedIndexChanged);
            // 
            // uxPlayerLabel
            // 
            this.uxPlayerLabel.AutoSize = true;
            this.uxPlayerLabel.Font = new System.Drawing.Font("Berlin Sans FB", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxPlayerLabel.Location = new System.Drawing.Point(443, 36);
            this.uxPlayerLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.uxPlayerLabel.Name = "uxPlayerLabel";
            this.uxPlayerLabel.Size = new System.Drawing.Size(90, 17);
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
            this.uxSelectTeam.Location = new System.Drawing.Point(225, 61);
            this.uxSelectTeam.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.uxSelectTeam.MaxDropDownItems = 10;
            this.uxSelectTeam.Name = "uxSelectTeam";
            this.uxSelectTeam.Size = new System.Drawing.Size(139, 21);
            this.uxSelectTeam.Sorted = true;
            this.uxSelectTeam.TabIndex = 49;
            this.uxSelectTeam.SelectedIndexChanged += new System.EventHandler(this.uxSelectTeam_SelectedIndexChanged);
            // 
            // uxTeamLabel
            // 
            this.uxTeamLabel.AutoSize = true;
            this.uxTeamLabel.Font = new System.Drawing.Font("Berlin Sans FB", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxTeamLabel.Location = new System.Drawing.Point(260, 36);
            this.uxTeamLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.uxTeamLabel.Name = "uxTeamLabel";
            this.uxTeamLabel.Size = new System.Drawing.Size(87, 17);
            this.uxTeamLabel.TabIndex = 51;
            this.uxTeamLabel.Text = "Select Team:";
            // 
            // uxPointsLabel
            // 
            this.uxPointsLabel.AutoSize = true;
            this.uxPointsLabel.Font = new System.Drawing.Font("Berlin Sans FB", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxPointsLabel.Location = new System.Drawing.Point(230, 96);
            this.uxPointsLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.uxPointsLabel.Name = "uxPointsLabel";
            this.uxPointsLabel.Size = new System.Drawing.Size(39, 13);
            this.uxPointsLabel.TabIndex = 57;
            this.uxPointsLabel.Text = "Points:";
            this.uxPointsLabel.Visible = false;
            // 
            // uxFGMLabel
            // 
            this.uxFGMLabel.AutoSize = true;
            this.uxFGMLabel.Font = new System.Drawing.Font("Berlin Sans FB", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxFGMLabel.Location = new System.Drawing.Point(235, 168);
            this.uxFGMLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.uxFGMLabel.Name = "uxFGMLabel";
            this.uxFGMLabel.Size = new System.Drawing.Size(33, 13);
            this.uxFGMLabel.TabIndex = 59;
            this.uxFGMLabel.Text = "FGM:";
            this.uxFGMLabel.Visible = false;
            // 
            // uxFGALabel
            // 
            this.uxFGALabel.AutoSize = true;
            this.uxFGALabel.Font = new System.Drawing.Font("Berlin Sans FB", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxFGALabel.Location = new System.Drawing.Point(237, 206);
            this.uxFGALabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.uxFGALabel.Name = "uxFGALabel";
            this.uxFGALabel.Size = new System.Drawing.Size(32, 13);
            this.uxFGALabel.TabIndex = 61;
            this.uxFGALabel.Text = "FGA:";
            this.uxFGALabel.Visible = false;
            // 
            // uxReboundsLabel
            // 
            this.uxReboundsLabel.AutoSize = true;
            this.uxReboundsLabel.Font = new System.Drawing.Font("Berlin Sans FB", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxReboundsLabel.Location = new System.Drawing.Point(210, 246);
            this.uxReboundsLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.uxReboundsLabel.Name = "uxReboundsLabel";
            this.uxReboundsLabel.Size = new System.Drawing.Size(60, 13);
            this.uxReboundsLabel.TabIndex = 63;
            this.uxReboundsLabel.Text = "Rebounds:";
            this.uxReboundsLabel.Visible = false;
            // 
            // uxMinutesLabel
            // 
            this.uxMinutesLabel.AutoSize = true;
            this.uxMinutesLabel.Font = new System.Drawing.Font("Berlin Sans FB", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxMinutesLabel.Location = new System.Drawing.Point(222, 287);
            this.uxMinutesLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.uxMinutesLabel.Name = "uxMinutesLabel";
            this.uxMinutesLabel.Size = new System.Drawing.Size(48, 13);
            this.uxMinutesLabel.TabIndex = 65;
            this.uxMinutesLabel.Text = "Minutes:";
            this.uxMinutesLabel.Visible = false;
            // 
            // uxPlayerStats
            // 
            this.uxPlayerStats.AutoSize = true;
            this.uxPlayerStats.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxPlayerStats.Location = new System.Drawing.Point(247, 150);
            this.uxPlayerStats.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.uxPlayerStats.Name = "uxPlayerStats";
            this.uxPlayerStats.Size = new System.Drawing.Size(159, 24);
            this.uxPlayerStats.TabIndex = 73;
            this.uxPlayerStats.Text = "(player stats label)";
            // 
            // uxPoints
            // 
            this.uxPoints.Location = new System.Drawing.Point(272, 94);
            this.uxPoints.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.uxPoints.Name = "uxPoints";
            this.uxPoints.Size = new System.Drawing.Size(80, 20);
            this.uxPoints.TabIndex = 74;
            this.uxPoints.Visible = false;
            this.uxPoints.ValueChanged += new System.EventHandler(this.uxPoints_ValueChanged);
            // 
            // uxFGM
            // 
            this.uxFGM.Location = new System.Drawing.Point(272, 167);
            this.uxFGM.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.uxFGM.Name = "uxFGM";
            this.uxFGM.Size = new System.Drawing.Size(80, 20);
            this.uxFGM.TabIndex = 75;
            this.uxFGM.Visible = false;
            this.uxFGM.ValueChanged += new System.EventHandler(this.uxFGM_ValueChanged);
            // 
            // uxFGA
            // 
            this.uxFGA.Location = new System.Drawing.Point(272, 205);
            this.uxFGA.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.uxFGA.Name = "uxFGA";
            this.uxFGA.Size = new System.Drawing.Size(80, 20);
            this.uxFGA.TabIndex = 76;
            this.uxFGA.Visible = false;
            this.uxFGA.ValueChanged += new System.EventHandler(this.uxFGA_ValueChanged);
            // 
            // uxRebounds
            // 
            this.uxRebounds.Location = new System.Drawing.Point(272, 243);
            this.uxRebounds.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.uxRebounds.Name = "uxRebounds";
            this.uxRebounds.Size = new System.Drawing.Size(80, 20);
            this.uxRebounds.TabIndex = 77;
            this.uxRebounds.Visible = false;
            this.uxRebounds.ValueChanged += new System.EventHandler(this.uxRebounds_ValueChanged);
            // 
            // uxMinutes
            // 
            this.uxMinutes.Location = new System.Drawing.Point(272, 285);
            this.uxMinutes.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.uxMinutes.Name = "uxMinutes";
            this.uxMinutes.Size = new System.Drawing.Size(80, 20);
            this.uxMinutes.TabIndex = 78;
            this.uxMinutes.Visible = false;
            this.uxMinutes.ValueChanged += new System.EventHandler(this.uxMinutes_ValueChanged);
            // 
            // uxThreePoints
            // 
            this.uxThreePoints.Location = new System.Drawing.Point(272, 129);
            this.uxThreePoints.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.uxThreePoints.Name = "uxThreePoints";
            this.uxThreePoints.Size = new System.Drawing.Size(80, 20);
            this.uxThreePoints.TabIndex = 80;
            this.uxThreePoints.Visible = false;
            this.uxThreePoints.ValueChanged += new System.EventHandler(this.uxThreePoints_ValueChanged);
            // 
            // uxThreePointsLabel
            // 
            this.uxThreePointsLabel.AutoSize = true;
            this.uxThreePointsLabel.Font = new System.Drawing.Font("Berlin Sans FB", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxThreePointsLabel.Location = new System.Drawing.Point(241, 129);
            this.uxThreePointsLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.uxThreePointsLabel.Name = "uxThreePointsLabel";
            this.uxThreePointsLabel.Size = new System.Drawing.Size(29, 13);
            this.uxThreePointsLabel.TabIndex = 79;
            this.uxThreePointsLabel.Text = "3PT:";
            this.uxThreePointsLabel.Visible = false;
            // 
            // uxDeletePlayerStats
            // 
            this.uxDeletePlayerStats.Enabled = false;
            this.uxDeletePlayerStats.Font = new System.Drawing.Font("Berlin Sans FB", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxDeletePlayerStats.Location = new System.Drawing.Point(458, 245);
            this.uxDeletePlayerStats.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.uxDeletePlayerStats.Name = "uxDeletePlayerStats";
            this.uxDeletePlayerStats.Size = new System.Drawing.Size(76, 44);
            this.uxDeletePlayerStats.TabIndex = 81;
            this.uxDeletePlayerStats.Text = "Delete Player Stats";
            this.uxDeletePlayerStats.UseVisualStyleBackColor = true;
            this.uxDeletePlayerStats.Click += new System.EventHandler(this.uxDeletePlayerStats_Click);
            // 
            // uxDeleteGameStats
            // 
            this.uxDeleteGameStats.Enabled = false;
            this.uxDeleteGameStats.Font = new System.Drawing.Font("Berlin Sans FB", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxDeleteGameStats.Location = new System.Drawing.Point(58, 245);
            this.uxDeleteGameStats.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.uxDeleteGameStats.Name = "uxDeleteGameStats";
            this.uxDeleteGameStats.Size = new System.Drawing.Size(76, 44);
            this.uxDeleteGameStats.TabIndex = 82;
            this.uxDeleteGameStats.Text = "Delete Game Stats";
            this.uxDeleteGameStats.UseVisualStyleBackColor = true;
            this.uxDeleteGameStats.Click += new System.EventHandler(this.uxDeleteGameStats_Click);
            // 
            // uxInsertGameStats
            // 
            this.uxInsertGameStats.Enabled = false;
            this.uxInsertGameStats.Font = new System.Drawing.Font("Berlin Sans FB", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxInsertGameStats.Location = new System.Drawing.Point(58, 175);
            this.uxInsertGameStats.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.uxInsertGameStats.Name = "uxInsertGameStats";
            this.uxInsertGameStats.Size = new System.Drawing.Size(76, 44);
            this.uxInsertGameStats.TabIndex = 84;
            this.uxInsertGameStats.Text = "Edit Game Stats";
            this.uxInsertGameStats.UseVisualStyleBackColor = true;
            this.uxInsertGameStats.Click += new System.EventHandler(this.uxInsertGameStats_Click);
            // 
            // Games
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 365);
            this.Controls.Add(this.uxInsertGameStats);
            this.Controls.Add(this.uxDeleteGameStats);
            this.Controls.Add(this.uxDeletePlayerStats);
            this.Controls.Add(this.uxThreePoints);
            this.Controls.Add(this.uxThreePointsLabel);
            this.Controls.Add(this.uxMinutes);
            this.Controls.Add(this.uxRebounds);
            this.Controls.Add(this.uxFGA);
            this.Controls.Add(this.uxFGM);
            this.Controls.Add(this.uxPoints);
            this.Controls.Add(this.uxPlayerStats);
            this.Controls.Add(this.uxViewPlayer);
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
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "Games";
            this.Text = "Games";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Games_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.uxPoints)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uxFGM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uxFGA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uxRebounds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uxMinutes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uxThreePoints)).EndInit();
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
        private System.Windows.Forms.NumericUpDown uxThreePoints;
        private System.Windows.Forms.Label uxThreePointsLabel;
        private System.Windows.Forms.Button uxDeletePlayerStats;
        private System.Windows.Forms.Button uxDeleteGameStats;
        private System.Windows.Forms.Button uxInsertGameStats;
    }
}