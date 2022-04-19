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
            this.uxBack = new System.Windows.Forms.Button();
            this.uxSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.uxSeed)).BeginInit();
            this.SuspendLayout();
            // 
            // uxGradeLabel
            // 
            this.uxGradeLabel.AutoSize = true;
            this.uxGradeLabel.Location = new System.Drawing.Point(366, 342);
            this.uxGradeLabel.Name = "uxGradeLabel";
            this.uxGradeLabel.Size = new System.Drawing.Size(52, 17);
            this.uxGradeLabel.TabIndex = 39;
            this.uxGradeLabel.Text = "Grade:";
            this.uxGradeLabel.Visible = false;
            // 
            // uxGrade
            // 
            this.uxGrade.AllowDrop = true;
            this.uxGrade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.uxGrade.FormattingEnabled = true;
            this.uxGrade.Location = new System.Drawing.Point(322, 362);
            this.uxGrade.Name = "uxGrade";
            this.uxGrade.Size = new System.Drawing.Size(150, 24);
            this.uxGrade.Sorted = true;
            this.uxGrade.TabIndex = 38;
            this.uxGrade.Visible = false;
            // 
            // uxRegionLabel
            // 
            this.uxRegionLabel.AutoSize = true;
            this.uxRegionLabel.Location = new System.Drawing.Point(366, 289);
            this.uxRegionLabel.Name = "uxRegionLabel";
            this.uxRegionLabel.Size = new System.Drawing.Size(57, 17);
            this.uxRegionLabel.TabIndex = 37;
            this.uxRegionLabel.Text = "Region:";
            this.uxRegionLabel.Visible = false;
            // 
            // uxRegion
            // 
            this.uxRegion.AllowDrop = true;
            this.uxRegion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.uxRegion.FormattingEnabled = true;
            this.uxRegion.Location = new System.Drawing.Point(322, 309);
            this.uxRegion.Name = "uxRegion";
            this.uxRegion.Size = new System.Drawing.Size(150, 24);
            this.uxRegion.Sorted = true;
            this.uxRegion.TabIndex = 36;
            this.uxRegion.Visible = false;
            // 
            // uxSeedLabel
            // 
            this.uxSeedLabel.AutoSize = true;
            this.uxSeedLabel.Location = new System.Drawing.Point(371, 179);
            this.uxSeedLabel.Name = "uxSeedLabel";
            this.uxSeedLabel.Size = new System.Drawing.Size(45, 17);
            this.uxSeedLabel.TabIndex = 35;
            this.uxSeedLabel.Text = "Seed:";
            this.uxSeedLabel.Visible = false;
            // 
            // uxSeed
            // 
            this.uxSeed.Location = new System.Drawing.Point(338, 199);
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
            this.uxSeed.TabIndex = 34;
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
            this.uxNameLabel.Location = new System.Drawing.Point(371, 114);
            this.uxNameLabel.Name = "uxNameLabel";
            this.uxNameLabel.Size = new System.Drawing.Size(52, 17);
            this.uxNameLabel.TabIndex = 33;
            this.uxNameLabel.Text = "Coach:";
            this.uxNameLabel.Visible = false;
            // 
            // uxName
            // 
            this.uxName.Location = new System.Drawing.Point(310, 134);
            this.uxName.Name = "uxName";
            this.uxName.Size = new System.Drawing.Size(174, 22);
            this.uxName.TabIndex = 32;
            this.uxName.Visible = false;
            // 
            // uxInfo
            // 
            this.uxInfo.AutoSize = true;
            this.uxInfo.Location = new System.Drawing.Point(346, 260);
            this.uxInfo.Name = "uxInfo";
            this.uxInfo.Size = new System.Drawing.Size(102, 17);
            this.uxInfo.TabIndex = 31;
            this.uxInfo.Text = "(Stats text box)";
            // 
            // uxUpdatePlayer
            // 
            this.uxUpdatePlayer.Enabled = false;
            this.uxUpdatePlayer.Location = new System.Drawing.Point(590, 341);
            this.uxUpdatePlayer.Name = "uxUpdatePlayer";
            this.uxUpdatePlayer.Size = new System.Drawing.Size(116, 45);
            this.uxUpdatePlayer.TabIndex = 30;
            this.uxUpdatePlayer.Text = "Update Player Info";
            this.uxUpdatePlayer.UseVisualStyleBackColor = true;
            // 
            // uxUpdateTeam
            // 
            this.uxUpdateTeam.Enabled = false;
            this.uxUpdateTeam.Location = new System.Drawing.Point(78, 341);
            this.uxUpdateTeam.Name = "uxUpdateTeam";
            this.uxUpdateTeam.Size = new System.Drawing.Size(116, 45);
            this.uxUpdateTeam.TabIndex = 29;
            this.uxUpdateTeam.Text = "Update Team Info";
            this.uxUpdateTeam.UseVisualStyleBackColor = true;
            // 
            // uxViewTeam
            // 
            this.uxViewTeam.Enabled = false;
            this.uxViewTeam.Location = new System.Drawing.Point(78, 246);
            this.uxViewTeam.Name = "uxViewTeam";
            this.uxViewTeam.Size = new System.Drawing.Size(116, 45);
            this.uxViewTeam.TabIndex = 28;
            this.uxViewTeam.Text = "View Team Info";
            this.uxViewTeam.UseVisualStyleBackColor = true;
            // 
            // uxPlayerLabel
            // 
            this.uxPlayerLabel.AutoSize = true;
            this.uxPlayerLabel.Location = new System.Drawing.Point(602, 65);
            this.uxPlayerLabel.Name = "uxPlayerLabel";
            this.uxPlayerLabel.Size = new System.Drawing.Size(91, 17);
            this.uxPlayerLabel.TabIndex = 27;
            this.uxPlayerLabel.Text = "Select Player";
            // 
            // uxTeamLabel
            // 
            this.uxTeamLabel.AutoSize = true;
            this.uxTeamLabel.Location = new System.Drawing.Point(107, 65);
            this.uxTeamLabel.Name = "uxTeamLabel";
            this.uxTeamLabel.Size = new System.Drawing.Size(87, 17);
            this.uxTeamLabel.TabIndex = 26;
            this.uxTeamLabel.Text = "Select Team";
            // 
            // uxSelectPlayer
            // 
            this.uxSelectPlayer.AllowDrop = true;
            this.uxSelectPlayer.DisplayMember = "Select Player";
            this.uxSelectPlayer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.uxSelectPlayer.Enabled = false;
            this.uxSelectPlayer.FormattingEnabled = true;
            this.uxSelectPlayer.Location = new System.Drawing.Point(578, 96);
            this.uxSelectPlayer.Name = "uxSelectPlayer";
            this.uxSelectPlayer.Size = new System.Drawing.Size(150, 24);
            this.uxSelectPlayer.Sorted = true;
            this.uxSelectPlayer.TabIndex = 25;
            // 
            // uxSelectTeam
            // 
            this.uxSelectTeam.AllowDrop = true;
            this.uxSelectTeam.DisplayMember = "Select Team";
            this.uxSelectTeam.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.uxSelectTeam.FormattingEnabled = true;
            this.uxSelectTeam.Location = new System.Drawing.Point(73, 96);
            this.uxSelectTeam.MaxDropDownItems = 64;
            this.uxSelectTeam.Name = "uxSelectTeam";
            this.uxSelectTeam.Size = new System.Drawing.Size(150, 24);
            this.uxSelectTeam.Sorted = true;
            this.uxSelectTeam.TabIndex = 24;
            // 
            // uxViewPlayer
            // 
            this.uxViewPlayer.Enabled = false;
            this.uxViewPlayer.Location = new System.Drawing.Point(590, 246);
            this.uxViewPlayer.Name = "uxViewPlayer";
            this.uxViewPlayer.Size = new System.Drawing.Size(116, 45);
            this.uxViewPlayer.TabIndex = 23;
            this.uxViewPlayer.Text = "View Player Info";
            this.uxViewPlayer.UseVisualStyleBackColor = true;
            // 
            // uxBack
            // 
            this.uxBack.Location = new System.Drawing.Point(12, 393);
            this.uxBack.Name = "uxBack";
            this.uxBack.Size = new System.Drawing.Size(116, 45);
            this.uxBack.TabIndex = 40;
            this.uxBack.Text = "Back";
            this.uxBack.UseVisualStyleBackColor = true;
            // 
            // uxSave
            // 
            this.uxSave.Location = new System.Drawing.Point(638, 393);
            this.uxSave.Name = "uxSave";
            this.uxSave.Size = new System.Drawing.Size(116, 45);
            this.uxSave.TabIndex = 41;
            this.uxSave.Text = "Back";
            this.uxSave.UseVisualStyleBackColor = true;
            // 
            // Stats
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.uxSave);
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
            ((System.ComponentModel.ISupportInitialize)(this.uxSeed)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

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
        private System.Windows.Forms.Button uxBack;
        private System.Windows.Forms.Button uxSave;
    }
}