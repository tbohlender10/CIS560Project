namespace CIS560_Project
{
    partial class Stats
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
            this.uxSaveNumber = new System.Windows.Forms.Button();
            this.uxNumberLabel = new System.Windows.Forms.Label();
            this.uxNumber = new System.Windows.Forms.NumericUpDown();
            this.uxSavePosition = new System.Windows.Forms.Button();
            this.uxPosition = new System.Windows.Forms.ComboBox();
            this.uxPositionLabel = new System.Windows.Forms.Label();
            this.uxSaveSeed = new System.Windows.Forms.Button();
            this.uxSaveRegion = new System.Windows.Forms.Button();
            this.uxSaveName = new System.Windows.Forms.Button();
            this.uxSaveGrade = new System.Windows.Forms.Button();
            this.uxBack = new System.Windows.Forms.Button();
            this.uxGradeLabel = new System.Windows.Forms.Label();
            this.uxGrade = new System.Windows.Forms.ComboBox();
            this.uxRegionLabel = new System.Windows.Forms.Label();
            this.uxRegion = new System.Windows.Forms.ComboBox();
            this.uxSeedLabel = new System.Windows.Forms.Label();
            this.uxSeed = new System.Windows.Forms.NumericUpDown();
            this.uxNameLabel = new System.Windows.Forms.Label();
            this.uxName = new System.Windows.Forms.TextBox();
            this.uxInfo = new System.Windows.Forms.Label();
            this.uxUpdatePlayer = new System.Windows.Forms.Button();
            this.uxUpdateTeam = new System.Windows.Forms.Button();
            this.uxViewTeam = new System.Windows.Forms.Button();
            this.uxPlayerLabel = new System.Windows.Forms.Label();
            this.uxTeamLabel = new System.Windows.Forms.Label();
            this.uxSelectPlayer = new System.Windows.Forms.ComboBox();
            this.uxSelectTeam = new System.Windows.Forms.ComboBox();
            this.uxViewPlayer = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.uxNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uxSeed)).BeginInit();
            this.SuspendLayout();
            // 
            // uxSaveNumber
            // 
            this.uxSaveNumber.Font = new System.Drawing.Font("Calisto MT", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxSaveNumber.Location = new System.Drawing.Point(503, 210);
            this.uxSaveNumber.Name = "uxSaveNumber";
            this.uxSaveNumber.Size = new System.Drawing.Size(116, 24);
            this.uxSaveNumber.TabIndex = 78;
            this.uxSaveNumber.Text = "Save Number";
            this.uxSaveNumber.UseVisualStyleBackColor = true;
            this.uxSaveNumber.Visible = false;
            this.uxSaveNumber.Click += new System.EventHandler(this.uxSaveNumber_Click);
            // 
            // uxNumberLabel
            // 
            this.uxNumberLabel.AutoSize = true;
            this.uxNumberLabel.Font = new System.Drawing.Font("Calisto MT", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxNumberLabel.Location = new System.Drawing.Point(364, 191);
            this.uxNumberLabel.Name = "uxNumberLabel";
            this.uxNumberLabel.Size = new System.Drawing.Size(61, 16);
            this.uxNumberLabel.TabIndex = 77;
            this.uxNumberLabel.Text = "Number:";
            this.uxNumberLabel.Visible = false;
            // 
            // uxNumber
            // 
            this.uxNumber.Location = new System.Drawing.Point(339, 210);
            this.uxNumber.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.uxNumber.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.uxNumber.Name = "uxNumber";
            this.uxNumber.Size = new System.Drawing.Size(120, 22);
            this.uxNumber.TabIndex = 76;
            this.uxNumber.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.uxNumber.Visible = false;
            // 
            // uxSavePosition
            // 
            this.uxSavePosition.Font = new System.Drawing.Font("Calisto MT", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxSavePosition.Location = new System.Drawing.Point(503, 379);
            this.uxSavePosition.Name = "uxSavePosition";
            this.uxSavePosition.Size = new System.Drawing.Size(116, 24);
            this.uxSavePosition.TabIndex = 75;
            this.uxSavePosition.Text = "Save Position";
            this.uxSavePosition.UseVisualStyleBackColor = true;
            this.uxSavePosition.Visible = false;
            this.uxSavePosition.Click += new System.EventHandler(this.uxSavePosition_Click);
            // 
            // uxPosition
            // 
            this.uxPosition.AllowDrop = true;
            this.uxPosition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.uxPosition.Font = new System.Drawing.Font("Calisto MT", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxPosition.FormattingEnabled = true;
            this.uxPosition.Location = new System.Drawing.Point(323, 379);
            this.uxPosition.Name = "uxPosition";
            this.uxPosition.Size = new System.Drawing.Size(150, 23);
            this.uxPosition.TabIndex = 74;
            this.uxPosition.Visible = false;
            // 
            // uxPositionLabel
            // 
            this.uxPositionLabel.AutoSize = true;
            this.uxPositionLabel.Font = new System.Drawing.Font("Calisto MT", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxPositionLabel.Location = new System.Drawing.Point(360, 360);
            this.uxPositionLabel.Name = "uxPositionLabel";
            this.uxPositionLabel.Size = new System.Drawing.Size(62, 16);
            this.uxPositionLabel.TabIndex = 73;
            this.uxPositionLabel.Text = "Position:";
            this.uxPositionLabel.Visible = false;
            // 
            // uxSaveSeed
            // 
            this.uxSaveSeed.Font = new System.Drawing.Font("Calisto MT", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxSaveSeed.Location = new System.Drawing.Point(503, 161);
            this.uxSaveSeed.Name = "uxSaveSeed";
            this.uxSaveSeed.Size = new System.Drawing.Size(116, 24);
            this.uxSaveSeed.TabIndex = 72;
            this.uxSaveSeed.Text = "Save Seed";
            this.uxSaveSeed.UseVisualStyleBackColor = true;
            this.uxSaveSeed.Visible = false;
            this.uxSaveSeed.Click += new System.EventHandler(this.uxSaveSeed_Click);
            // 
            // uxSaveRegion
            // 
            this.uxSaveRegion.Font = new System.Drawing.Font("Calisto MT", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxSaveRegion.Location = new System.Drawing.Point(503, 273);
            this.uxSaveRegion.Name = "uxSaveRegion";
            this.uxSaveRegion.Size = new System.Drawing.Size(116, 24);
            this.uxSaveRegion.TabIndex = 71;
            this.uxSaveRegion.Text = "Save Region";
            this.uxSaveRegion.UseVisualStyleBackColor = true;
            this.uxSaveRegion.Visible = false;
            this.uxSaveRegion.Click += new System.EventHandler(this.uxSaveRegion_Click);
            // 
            // uxSaveName
            // 
            this.uxSaveName.Font = new System.Drawing.Font("Calisto MT", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxSaveName.Location = new System.Drawing.Point(503, 96);
            this.uxSaveName.Name = "uxSaveName";
            this.uxSaveName.Size = new System.Drawing.Size(116, 29);
            this.uxSaveName.TabIndex = 70;
            this.uxSaveName.Text = "Save Name";
            this.uxSaveName.UseVisualStyleBackColor = true;
            this.uxSaveName.Visible = false;
            this.uxSaveName.Click += new System.EventHandler(this.uxSaveName_Click);
            // 
            // uxSaveGrade
            // 
            this.uxSaveGrade.Font = new System.Drawing.Font("Calisto MT", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxSaveGrade.Location = new System.Drawing.Point(503, 325);
            this.uxSaveGrade.Name = "uxSaveGrade";
            this.uxSaveGrade.Size = new System.Drawing.Size(116, 24);
            this.uxSaveGrade.TabIndex = 69;
            this.uxSaveGrade.Text = "Save Grade";
            this.uxSaveGrade.UseVisualStyleBackColor = true;
            this.uxSaveGrade.Visible = false;
            this.uxSaveGrade.Click += new System.EventHandler(this.uxSaveGrade_Click);
            // 
            // uxBack
            // 
            this.uxBack.Location = new System.Drawing.Point(16, 393);
            this.uxBack.Name = "uxBack";
            this.uxBack.Size = new System.Drawing.Size(116, 45);
            this.uxBack.TabIndex = 68;
            this.uxBack.Text = "Back";
            this.uxBack.UseVisualStyleBackColor = true;
            this.uxBack.Click += new System.EventHandler(this.uxBack_Click);
            // 
            // uxGradeLabel
            // 
            this.uxGradeLabel.AutoSize = true;
            this.uxGradeLabel.Font = new System.Drawing.Font("Calisto MT", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxGradeLabel.Location = new System.Drawing.Point(367, 306);
            this.uxGradeLabel.Name = "uxGradeLabel";
            this.uxGradeLabel.Size = new System.Drawing.Size(50, 16);
            this.uxGradeLabel.TabIndex = 67;
            this.uxGradeLabel.Text = "Grade:";
            this.uxGradeLabel.Visible = false;
            // 
            // uxGrade
            // 
            this.uxGrade.AllowDrop = true;
            this.uxGrade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.uxGrade.Font = new System.Drawing.Font("Calisto MT", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxGrade.FormattingEnabled = true;
            this.uxGrade.Location = new System.Drawing.Point(323, 326);
            this.uxGrade.Name = "uxGrade";
            this.uxGrade.Size = new System.Drawing.Size(150, 23);
            this.uxGrade.TabIndex = 66;
            this.uxGrade.Visible = false;
            // 
            // uxRegionLabel
            // 
            this.uxRegionLabel.AutoSize = true;
            this.uxRegionLabel.Font = new System.Drawing.Font("Calisto MT", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxRegionLabel.Location = new System.Drawing.Point(367, 253);
            this.uxRegionLabel.Name = "uxRegionLabel";
            this.uxRegionLabel.Size = new System.Drawing.Size(55, 16);
            this.uxRegionLabel.TabIndex = 65;
            this.uxRegionLabel.Text = "Region:";
            this.uxRegionLabel.Visible = false;
            // 
            // uxRegion
            // 
            this.uxRegion.AllowDrop = true;
            this.uxRegion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.uxRegion.Font = new System.Drawing.Font("Calisto MT", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxRegion.FormattingEnabled = true;
            this.uxRegion.Location = new System.Drawing.Point(323, 273);
            this.uxRegion.Name = "uxRegion";
            this.uxRegion.Size = new System.Drawing.Size(150, 23);
            this.uxRegion.TabIndex = 64;
            this.uxRegion.Visible = false;
            // 
            // uxSeedLabel
            // 
            this.uxSeedLabel.AutoSize = true;
            this.uxSeedLabel.Font = new System.Drawing.Font("Calisto MT", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxSeedLabel.Location = new System.Drawing.Point(372, 143);
            this.uxSeedLabel.Name = "uxSeedLabel";
            this.uxSeedLabel.Size = new System.Drawing.Size(40, 16);
            this.uxSeedLabel.TabIndex = 63;
            this.uxSeedLabel.Text = "Seed:";
            this.uxSeedLabel.Visible = false;
            // 
            // uxSeed
            // 
            this.uxSeed.Location = new System.Drawing.Point(339, 163);
            this.uxSeed.Maximum = new decimal(new int[] {
            16,
            0,
            0,
            0});
            this.uxSeed.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.uxSeed.Name = "uxSeed";
            this.uxSeed.Size = new System.Drawing.Size(120, 22);
            this.uxSeed.TabIndex = 62;
            this.uxSeed.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.uxSeed.Visible = false;
            // 
            // uxNameLabel
            // 
            this.uxNameLabel.AutoSize = true;
            this.uxNameLabel.Font = new System.Drawing.Font("Calisto MT", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxNameLabel.Location = new System.Drawing.Point(372, 78);
            this.uxNameLabel.Name = "uxNameLabel";
            this.uxNameLabel.Size = new System.Drawing.Size(51, 16);
            this.uxNameLabel.TabIndex = 61;
            this.uxNameLabel.Text = "Coach:";
            this.uxNameLabel.Visible = false;
            // 
            // uxName
            // 
            this.uxName.Location = new System.Drawing.Point(311, 98);
            this.uxName.Name = "uxName";
            this.uxName.Size = new System.Drawing.Size(174, 22);
            this.uxName.TabIndex = 60;
            this.uxName.Visible = false;
            // 
            // uxInfo
            // 
            this.uxInfo.AutoSize = true;
            this.uxInfo.Font = new System.Drawing.Font("Calisto MT", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxInfo.Location = new System.Drawing.Point(245, 9);
            this.uxInfo.Name = "uxInfo";
            this.uxInfo.Size = new System.Drawing.Size(260, 44);
            this.uxInfo.TabIndex = 59;
            this.uxInfo.Text = "(Stats text box)";
            this.uxInfo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // uxUpdatePlayer
            // 
            this.uxUpdatePlayer.Enabled = false;
            this.uxUpdatePlayer.Font = new System.Drawing.Font("Calisto MT", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxUpdatePlayer.Location = new System.Drawing.Point(591, 305);
            this.uxUpdatePlayer.Name = "uxUpdatePlayer";
            this.uxUpdatePlayer.Size = new System.Drawing.Size(116, 45);
            this.uxUpdatePlayer.TabIndex = 58;
            this.uxUpdatePlayer.Text = "Update Player Info";
            this.uxUpdatePlayer.UseVisualStyleBackColor = true;
            this.uxUpdatePlayer.Click += new System.EventHandler(this.uxUpdatePlayer_Click);
            // 
            // uxUpdateTeam
            // 
            this.uxUpdateTeam.Enabled = false;
            this.uxUpdateTeam.Font = new System.Drawing.Font("Calisto MT", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxUpdateTeam.Location = new System.Drawing.Point(79, 305);
            this.uxUpdateTeam.Name = "uxUpdateTeam";
            this.uxUpdateTeam.Size = new System.Drawing.Size(116, 45);
            this.uxUpdateTeam.TabIndex = 57;
            this.uxUpdateTeam.Text = "Update Team Info";
            this.uxUpdateTeam.UseVisualStyleBackColor = true;
            this.uxUpdateTeam.Click += new System.EventHandler(this.uxUpdateTeam_Click);
            // 
            // uxViewTeam
            // 
            this.uxViewTeam.Enabled = false;
            this.uxViewTeam.Font = new System.Drawing.Font("Calisto MT", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxViewTeam.Location = new System.Drawing.Point(79, 210);
            this.uxViewTeam.Name = "uxViewTeam";
            this.uxViewTeam.Size = new System.Drawing.Size(116, 45);
            this.uxViewTeam.TabIndex = 56;
            this.uxViewTeam.Text = "View Team Info";
            this.uxViewTeam.UseVisualStyleBackColor = true;
            this.uxViewTeam.Click += new System.EventHandler(this.uxViewTeam_Click);
            // 
            // uxPlayerLabel
            // 
            this.uxPlayerLabel.AutoSize = true;
            this.uxPlayerLabel.Font = new System.Drawing.Font("Calisto MT", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxPlayerLabel.Location = new System.Drawing.Point(603, 29);
            this.uxPlayerLabel.Name = "uxPlayerLabel";
            this.uxPlayerLabel.Size = new System.Drawing.Size(84, 16);
            this.uxPlayerLabel.TabIndex = 55;
            this.uxPlayerLabel.Text = "Select Player";
            // 
            // uxTeamLabel
            // 
            this.uxTeamLabel.AutoSize = true;
            this.uxTeamLabel.Font = new System.Drawing.Font("Calisto MT", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxTeamLabel.Location = new System.Drawing.Point(108, 29);
            this.uxTeamLabel.Name = "uxTeamLabel";
            this.uxTeamLabel.Size = new System.Drawing.Size(80, 16);
            this.uxTeamLabel.TabIndex = 54;
            this.uxTeamLabel.Text = "Select Team";
            // 
            // uxSelectPlayer
            // 
            this.uxSelectPlayer.AllowDrop = true;
            this.uxSelectPlayer.DisplayMember = "Select Player";
            this.uxSelectPlayer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.uxSelectPlayer.Enabled = false;
            this.uxSelectPlayer.Font = new System.Drawing.Font("Calisto MT", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxSelectPlayer.FormattingEnabled = true;
            this.uxSelectPlayer.Location = new System.Drawing.Point(579, 60);
            this.uxSelectPlayer.Name = "uxSelectPlayer";
            this.uxSelectPlayer.Size = new System.Drawing.Size(150, 23);
            this.uxSelectPlayer.Sorted = true;
            this.uxSelectPlayer.TabIndex = 53;
            this.uxSelectPlayer.SelectedIndexChanged += new System.EventHandler(this.uxSelectPlayer_SelectedIndexChanged);
            // 
            // uxSelectTeam
            // 
            this.uxSelectTeam.AllowDrop = true;
            this.uxSelectTeam.DisplayMember = "Select Team";
            this.uxSelectTeam.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.uxSelectTeam.Font = new System.Drawing.Font("Calisto MT", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxSelectTeam.FormattingEnabled = true;
            this.uxSelectTeam.Location = new System.Drawing.Point(74, 60);
            this.uxSelectTeam.MaxDropDownItems = 10;
            this.uxSelectTeam.Name = "uxSelectTeam";
            this.uxSelectTeam.Size = new System.Drawing.Size(150, 23);
            this.uxSelectTeam.Sorted = true;
            this.uxSelectTeam.TabIndex = 52;
            this.uxSelectTeam.SelectedIndexChanged += new System.EventHandler(this.uxSelectTeam_SelectedIndexChanged);
            // 
            // uxViewPlayer
            // 
            this.uxViewPlayer.Enabled = false;
            this.uxViewPlayer.Font = new System.Drawing.Font("Calisto MT", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxViewPlayer.Location = new System.Drawing.Point(591, 210);
            this.uxViewPlayer.Name = "uxViewPlayer";
            this.uxViewPlayer.Size = new System.Drawing.Size(116, 45);
            this.uxViewPlayer.TabIndex = 51;
            this.uxViewPlayer.Text = "View Player Info";
            this.uxViewPlayer.UseVisualStyleBackColor = true;
            this.uxViewPlayer.Click += new System.EventHandler(this.uxViewPlayer_Click);
            // 
            // Stats
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.uxSaveNumber);
            this.Controls.Add(this.uxNumberLabel);
            this.Controls.Add(this.uxNumber);
            this.Controls.Add(this.uxSavePosition);
            this.Controls.Add(this.uxPosition);
            this.Controls.Add(this.uxPositionLabel);
            this.Controls.Add(this.uxSaveSeed);
            this.Controls.Add(this.uxSaveRegion);
            this.Controls.Add(this.uxSaveName);
            this.Controls.Add(this.uxSaveGrade);
            this.Controls.Add(this.uxBack);
            this.Controls.Add(this.uxGradeLabel);
            this.Controls.Add(this.uxGrade);
            this.Controls.Add(this.uxRegionLabel);
            this.Controls.Add(this.uxRegion);
            this.Controls.Add(this.uxSeedLabel);
            this.Controls.Add(this.uxSeed);
            this.Controls.Add(this.uxNameLabel);
            this.Controls.Add(this.uxName);
            this.Controls.Add(this.uxInfo);
            this.Controls.Add(this.uxUpdatePlayer);
            this.Controls.Add(this.uxUpdateTeam);
            this.Controls.Add(this.uxViewTeam);
            this.Controls.Add(this.uxPlayerLabel);
            this.Controls.Add(this.uxTeamLabel);
            this.Controls.Add(this.uxSelectPlayer);
            this.Controls.Add(this.uxSelectTeam);
            this.Controls.Add(this.uxViewPlayer);
            this.Name = "Stats";
            this.Text = "Stats";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Stats_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.uxNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uxSeed)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button uxSaveNumber;
        private System.Windows.Forms.Label uxNumberLabel;
        private System.Windows.Forms.NumericUpDown uxNumber;
        private System.Windows.Forms.Button uxSavePosition;
        private System.Windows.Forms.ComboBox uxPosition;
        private System.Windows.Forms.Label uxPositionLabel;
        private System.Windows.Forms.Button uxSaveSeed;
        private System.Windows.Forms.Button uxSaveRegion;
        private System.Windows.Forms.Button uxSaveName;
        private System.Windows.Forms.Button uxSaveGrade;
        private System.Windows.Forms.Button uxBack;
        private System.Windows.Forms.Label uxGradeLabel;
        private System.Windows.Forms.ComboBox uxGrade;
        private System.Windows.Forms.Label uxRegionLabel;
        private System.Windows.Forms.ComboBox uxRegion;
        private System.Windows.Forms.Label uxSeedLabel;
        private System.Windows.Forms.NumericUpDown uxSeed;
        private System.Windows.Forms.Label uxNameLabel;
        private System.Windows.Forms.TextBox uxName;
        private System.Windows.Forms.Label uxInfo;
        private System.Windows.Forms.Button uxUpdatePlayer;
        private System.Windows.Forms.Button uxUpdateTeam;
        private System.Windows.Forms.Button uxViewTeam;
        private System.Windows.Forms.Label uxPlayerLabel;
        private System.Windows.Forms.Label uxTeamLabel;
        private System.Windows.Forms.ComboBox uxSelectPlayer;
        private System.Windows.Forms.ComboBox uxSelectTeam;
        private System.Windows.Forms.Button uxViewPlayer;
    }
}