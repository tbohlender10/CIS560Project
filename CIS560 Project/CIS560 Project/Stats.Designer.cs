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
            this.uxSaveName = new System.Windows.Forms.Button();
            this.uxSaveGrade = new System.Windows.Forms.Button();
            this.uxBack = new System.Windows.Forms.Button();
            this.uxGradeLabel = new System.Windows.Forms.Label();
            this.uxGrade = new System.Windows.Forms.ComboBox();
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
            this.SuspendLayout();
            // 
            // uxSaveNumber
            // 
            this.uxSaveNumber.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxSaveNumber.Location = new System.Drawing.Point(377, 168);
            this.uxSaveNumber.Margin = new System.Windows.Forms.Padding(2);
            this.uxSaveNumber.Name = "uxSaveNumber";
            this.uxSaveNumber.Size = new System.Drawing.Size(112, 25);
            this.uxSaveNumber.TabIndex = 78;
            this.uxSaveNumber.Text = "Save Number";
            this.uxSaveNumber.UseVisualStyleBackColor = true;
            this.uxSaveNumber.Visible = false;
            this.uxSaveNumber.Click += new System.EventHandler(this.uxSaveNumber_Click);
            // 
            // uxNumberLabel
            // 
            this.uxNumberLabel.AutoSize = true;
            this.uxNumberLabel.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxNumberLabel.Location = new System.Drawing.Point(265, 149);
            this.uxNumberLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.uxNumberLabel.Name = "uxNumberLabel";
            this.uxNumberLabel.Size = new System.Drawing.Size(66, 18);
            this.uxNumberLabel.TabIndex = 77;
            this.uxNumberLabel.Text = "Number:";
            this.uxNumberLabel.Visible = false;
            // 
            // uxNumber
            // 
            this.uxNumber.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxNumber.Location = new System.Drawing.Point(254, 168);
            this.uxNumber.Margin = new System.Windows.Forms.Padding(2);
            this.uxNumber.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.uxNumber.Name = "uxNumber";
            this.uxNumber.Size = new System.Drawing.Size(90, 25);
            this.uxNumber.TabIndex = 76;
            this.uxNumber.Visible = false;
            // 
            // uxSavePosition
            // 
            this.uxSavePosition.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxSavePosition.Location = new System.Drawing.Point(377, 305);
            this.uxSavePosition.Margin = new System.Windows.Forms.Padding(2);
            this.uxSavePosition.Name = "uxSavePosition";
            this.uxSavePosition.Size = new System.Drawing.Size(112, 28);
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
            this.uxPosition.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxPosition.FormattingEnabled = true;
            this.uxPosition.Location = new System.Drawing.Point(240, 307);
            this.uxPosition.Margin = new System.Windows.Forms.Padding(2);
            this.uxPosition.Name = "uxPosition";
            this.uxPosition.Size = new System.Drawing.Size(114, 26);
            this.uxPosition.TabIndex = 74;
            this.uxPosition.Visible = false;
            // 
            // uxPositionLabel
            // 
            this.uxPositionLabel.AutoSize = true;
            this.uxPositionLabel.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxPositionLabel.Location = new System.Drawing.Point(267, 281);
            this.uxPositionLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.uxPositionLabel.Name = "uxPositionLabel";
            this.uxPositionLabel.Size = new System.Drawing.Size(62, 18);
            this.uxPositionLabel.TabIndex = 73;
            this.uxPositionLabel.Text = "Position:";
            this.uxPositionLabel.Visible = false;
            // 
            // uxSaveName
            // 
            this.uxSaveName.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxSaveName.Location = new System.Drawing.Point(377, 104);
            this.uxSaveName.Margin = new System.Windows.Forms.Padding(2);
            this.uxSaveName.Name = "uxSaveName";
            this.uxSaveName.Size = new System.Drawing.Size(112, 24);
            this.uxSaveName.TabIndex = 70;
            this.uxSaveName.Text = "Save Name";
            this.uxSaveName.UseVisualStyleBackColor = true;
            this.uxSaveName.Visible = false;
            this.uxSaveName.Click += new System.EventHandler(this.uxSaveName_Click);
            // 
            // uxSaveGrade
            // 
            this.uxSaveGrade.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxSaveGrade.Location = new System.Drawing.Point(377, 248);
            this.uxSaveGrade.Margin = new System.Windows.Forms.Padding(2);
            this.uxSaveGrade.Name = "uxSaveGrade";
            this.uxSaveGrade.Size = new System.Drawing.Size(112, 26);
            this.uxSaveGrade.TabIndex = 69;
            this.uxSaveGrade.Text = "Save Grade";
            this.uxSaveGrade.UseVisualStyleBackColor = true;
            this.uxSaveGrade.Visible = false;
            this.uxSaveGrade.Click += new System.EventHandler(this.uxSaveGrade_Click);
            // 
            // uxBack
            // 
            this.uxBack.Font = new System.Drawing.Font("Berlin Sans FB", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxBack.Location = new System.Drawing.Point(12, 319);
            this.uxBack.Margin = new System.Windows.Forms.Padding(2);
            this.uxBack.Name = "uxBack";
            this.uxBack.Size = new System.Drawing.Size(87, 37);
            this.uxBack.TabIndex = 68;
            this.uxBack.Text = "Back";
            this.uxBack.UseVisualStyleBackColor = true;
            this.uxBack.Click += new System.EventHandler(this.uxBack_Click);
            // 
            // uxGradeLabel
            // 
            this.uxGradeLabel.AutoSize = true;
            this.uxGradeLabel.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxGradeLabel.Location = new System.Drawing.Point(271, 228);
            this.uxGradeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.uxGradeLabel.Name = "uxGradeLabel";
            this.uxGradeLabel.Size = new System.Drawing.Size(54, 18);
            this.uxGradeLabel.TabIndex = 67;
            this.uxGradeLabel.Text = "Grade:";
            this.uxGradeLabel.Visible = false;
            // 
            // uxGrade
            // 
            this.uxGrade.AllowDrop = true;
            this.uxGrade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.uxGrade.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxGrade.FormattingEnabled = true;
            this.uxGrade.Location = new System.Drawing.Point(240, 248);
            this.uxGrade.Margin = new System.Windows.Forms.Padding(2);
            this.uxGrade.Name = "uxGrade";
            this.uxGrade.Size = new System.Drawing.Size(114, 26);
            this.uxGrade.TabIndex = 66;
            this.uxGrade.Visible = false;
            // 
            // uxNameLabel
            // 
            this.uxNameLabel.AutoSize = true;
            this.uxNameLabel.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxNameLabel.Location = new System.Drawing.Point(265, 75);
            this.uxNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.uxNameLabel.Name = "uxNameLabel";
            this.uxNameLabel.Size = new System.Drawing.Size(52, 18);
            this.uxNameLabel.TabIndex = 61;
            this.uxNameLabel.Text = "Coach:";
            this.uxNameLabel.Visible = false;
            // 
            // uxName
            // 
            this.uxName.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxName.Location = new System.Drawing.Point(238, 104);
            this.uxName.Margin = new System.Windows.Forms.Padding(2);
            this.uxName.Name = "uxName";
            this.uxName.Size = new System.Drawing.Size(132, 25);
            this.uxName.TabIndex = 60;
            this.uxName.Visible = false;
            // 
            // uxInfo
            // 
            this.uxInfo.AutoSize = true;
            this.uxInfo.Font = new System.Drawing.Font("Berlin Sans FB", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxInfo.Location = new System.Drawing.Point(220, 72);
            this.uxInfo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.uxInfo.Name = "uxInfo";
            this.uxInfo.Size = new System.Drawing.Size(134, 21);
            this.uxInfo.TabIndex = 59;
            this.uxInfo.Text = "(Stats text box)";
            this.uxInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uxUpdatePlayer
            // 
            this.uxUpdatePlayer.Enabled = false;
            this.uxUpdatePlayer.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxUpdatePlayer.Location = new System.Drawing.Point(431, 241);
            this.uxUpdatePlayer.Margin = new System.Windows.Forms.Padding(2);
            this.uxUpdatePlayer.Name = "uxUpdatePlayer";
            this.uxUpdatePlayer.Size = new System.Drawing.Size(114, 54);
            this.uxUpdatePlayer.TabIndex = 58;
            this.uxUpdatePlayer.Text = "Update Player Info";
            this.uxUpdatePlayer.UseVisualStyleBackColor = true;
            this.uxUpdatePlayer.Click += new System.EventHandler(this.uxUpdatePlayer_Click);
            // 
            // uxUpdateTeam
            // 
            this.uxUpdateTeam.Enabled = false;
            this.uxUpdateTeam.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxUpdateTeam.Location = new System.Drawing.Point(49, 241);
            this.uxUpdateTeam.Margin = new System.Windows.Forms.Padding(2);
            this.uxUpdateTeam.Name = "uxUpdateTeam";
            this.uxUpdateTeam.Size = new System.Drawing.Size(114, 54);
            this.uxUpdateTeam.TabIndex = 57;
            this.uxUpdateTeam.Text = "Update Team Info";
            this.uxUpdateTeam.UseVisualStyleBackColor = true;
            this.uxUpdateTeam.Click += new System.EventHandler(this.uxUpdateTeam_Click);
            // 
            // uxViewTeam
            // 
            this.uxViewTeam.Enabled = false;
            this.uxViewTeam.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxViewTeam.Location = new System.Drawing.Point(49, 151);
            this.uxViewTeam.Margin = new System.Windows.Forms.Padding(2);
            this.uxViewTeam.Name = "uxViewTeam";
            this.uxViewTeam.Size = new System.Drawing.Size(114, 55);
            this.uxViewTeam.TabIndex = 56;
            this.uxViewTeam.Text = "View Team Info";
            this.uxViewTeam.UseVisualStyleBackColor = true;
            this.uxViewTeam.Click += new System.EventHandler(this.uxViewTeam_Click);
            // 
            // uxPlayerLabel
            // 
            this.uxPlayerLabel.AutoSize = true;
            this.uxPlayerLabel.Font = new System.Drawing.Font("Berlin Sans FB", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxPlayerLabel.Location = new System.Drawing.Point(438, 20);
            this.uxPlayerLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.uxPlayerLabel.Name = "uxPlayerLabel";
            this.uxPlayerLabel.Size = new System.Drawing.Size(112, 21);
            this.uxPlayerLabel.TabIndex = 55;
            this.uxPlayerLabel.Text = "Select Player";
            // 
            // uxTeamLabel
            // 
            this.uxTeamLabel.AutoSize = true;
            this.uxTeamLabel.Font = new System.Drawing.Font("Berlin Sans FB", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxTeamLabel.Location = new System.Drawing.Point(66, 21);
            this.uxTeamLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.uxTeamLabel.Name = "uxTeamLabel";
            this.uxTeamLabel.Size = new System.Drawing.Size(107, 21);
            this.uxTeamLabel.TabIndex = 54;
            this.uxTeamLabel.Text = "Select Team";
            // 
            // uxSelectPlayer
            // 
            this.uxSelectPlayer.AllowDrop = true;
            this.uxSelectPlayer.DisplayMember = "Select Player";
            this.uxSelectPlayer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.uxSelectPlayer.Enabled = false;
            this.uxSelectPlayer.Font = new System.Drawing.Font("Berlin Sans FB", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxSelectPlayer.FormattingEnabled = true;
            this.uxSelectPlayer.Location = new System.Drawing.Point(390, 47);
            this.uxSelectPlayer.Margin = new System.Windows.Forms.Padding(2);
            this.uxSelectPlayer.Name = "uxSelectPlayer";
            this.uxSelectPlayer.Size = new System.Drawing.Size(199, 29);
            this.uxSelectPlayer.Sorted = true;
            this.uxSelectPlayer.TabIndex = 53;
            this.uxSelectPlayer.SelectedIndexChanged += new System.EventHandler(this.uxSelectPlayer_SelectedIndexChanged);
            // 
            // uxSelectTeam
            // 
            this.uxSelectTeam.AllowDrop = true;
            this.uxSelectTeam.DisplayMember = "Select Team";
            this.uxSelectTeam.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.uxSelectTeam.Font = new System.Drawing.Font("Berlin Sans FB", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxSelectTeam.FormattingEnabled = true;
            this.uxSelectTeam.Location = new System.Drawing.Point(34, 49);
            this.uxSelectTeam.Margin = new System.Windows.Forms.Padding(2);
            this.uxSelectTeam.MaxDropDownItems = 10;
            this.uxSelectTeam.Name = "uxSelectTeam";
            this.uxSelectTeam.Size = new System.Drawing.Size(164, 29);
            this.uxSelectTeam.Sorted = true;
            this.uxSelectTeam.TabIndex = 52;
            this.uxSelectTeam.SelectedIndexChanged += new System.EventHandler(this.uxSelectTeam_SelectedIndexChanged);
            // 
            // uxViewPlayer
            // 
            this.uxViewPlayer.Enabled = false;
            this.uxViewPlayer.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxViewPlayer.Location = new System.Drawing.Point(431, 155);
            this.uxViewPlayer.Margin = new System.Windows.Forms.Padding(2);
            this.uxViewPlayer.Name = "uxViewPlayer";
            this.uxViewPlayer.Size = new System.Drawing.Size(114, 51);
            this.uxViewPlayer.TabIndex = 51;
            this.uxViewPlayer.Text = "View Player Info";
            this.uxViewPlayer.UseVisualStyleBackColor = true;
            this.uxViewPlayer.Click += new System.EventHandler(this.uxViewPlayer_Click);
            // 
            // Stats
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.uxSaveNumber);
            this.Controls.Add(this.uxNumberLabel);
            this.Controls.Add(this.uxNumber);
            this.Controls.Add(this.uxSavePosition);
            this.Controls.Add(this.uxPosition);
            this.Controls.Add(this.uxPositionLabel);
            this.Controls.Add(this.uxSaveName);
            this.Controls.Add(this.uxSaveGrade);
            this.Controls.Add(this.uxBack);
            this.Controls.Add(this.uxGradeLabel);
            this.Controls.Add(this.uxGrade);
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
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Stats";
            this.Text = "Team & Player Statistics";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Stats_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.uxNumber)).EndInit();
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
        private System.Windows.Forms.Button uxSaveName;
        private System.Windows.Forms.Button uxSaveGrade;
        private System.Windows.Forms.Button uxBack;
        private System.Windows.Forms.Label uxGradeLabel;
        private System.Windows.Forms.ComboBox uxGrade;
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