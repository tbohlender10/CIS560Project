
namespace CIS560_Project
{
    partial class InsertGameSchoolStatistics
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
            this.uxSelectHomeTeam = new System.Windows.Forms.ComboBox();
            this.uxGuestTeam = new System.Windows.Forms.Label();
            this.uxHomeTeamLabel = new System.Windows.Forms.Label();
            this.uxBackButton = new System.Windows.Forms.Button();
            this.uxSaveButton = new System.Windows.Forms.Button();
            this.uxGuestScoreLabel = new System.Windows.Forms.Label();
            this.uxGuestScore = new System.Windows.Forms.NumericUpDown();
            this.uxHomeScoreLabel = new System.Windows.Forms.Label();
            this.uxHomeScore = new System.Windows.Forms.NumericUpDown();
            this.uxSelectGuestTeam = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.uxGuestScore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uxHomeScore)).BeginInit();
            this.SuspendLayout();
            // 
            // uxSelectHomeTeam
            // 
            this.uxSelectHomeTeam.AllowDrop = true;
            this.uxSelectHomeTeam.DisplayMember = "Select Team";
            this.uxSelectHomeTeam.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.uxSelectHomeTeam.Font = new System.Drawing.Font("Berlin Sans FB", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxSelectHomeTeam.FormattingEnabled = true;
            this.uxSelectHomeTeam.Location = new System.Drawing.Point(201, 95);
            this.uxSelectHomeTeam.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.uxSelectHomeTeam.MaxDropDownItems = 5;
            this.uxSelectHomeTeam.Name = "uxSelectHomeTeam";
            this.uxSelectHomeTeam.Size = new System.Drawing.Size(168, 28);
            this.uxSelectHomeTeam.Sorted = true;
            this.uxSelectHomeTeam.TabIndex = 60;
            this.uxSelectHomeTeam.SelectedIndexChanged += new System.EventHandler(this.uxSelectHomeTeam_SelectedIndexChanged);
            // 
            // uxGuestTeam
            // 
            this.uxGuestTeam.AutoSize = true;
            this.uxGuestTeam.Font = new System.Drawing.Font("Berlin Sans FB", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxGuestTeam.Location = new System.Drawing.Point(428, 96);
            this.uxGuestTeam.Name = "uxGuestTeam";
            this.uxGuestTeam.Size = new System.Drawing.Size(139, 26);
            this.uxGuestTeam.TabIndex = 59;
            this.uxGuestTeam.Text = "Guest Team: ";
            // 
            // uxHomeTeamLabel
            // 
            this.uxHomeTeamLabel.AutoSize = true;
            this.uxHomeTeamLabel.Font = new System.Drawing.Font("Berlin Sans FB", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxHomeTeamLabel.Location = new System.Drawing.Point(64, 95);
            this.uxHomeTeamLabel.Name = "uxHomeTeamLabel";
            this.uxHomeTeamLabel.Size = new System.Drawing.Size(142, 26);
            this.uxHomeTeamLabel.TabIndex = 58;
            this.uxHomeTeamLabel.Text = "Home Team: ";
            // 
            // uxBackButton
            // 
            this.uxBackButton.Font = new System.Drawing.Font("Berlin Sans FB", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxBackButton.Location = new System.Drawing.Point(69, 298);
            this.uxBackButton.Name = "uxBackButton";
            this.uxBackButton.Size = new System.Drawing.Size(134, 58);
            this.uxBackButton.TabIndex = 57;
            this.uxBackButton.Text = "Back";
            this.uxBackButton.UseVisualStyleBackColor = true;
            this.uxBackButton.Click += new System.EventHandler(this.uxBackButton_Click);
            // 
            // uxSaveButton
            // 
            this.uxSaveButton.Font = new System.Drawing.Font("Berlin Sans FB", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxSaveButton.Location = new System.Drawing.Point(602, 298);
            this.uxSaveButton.Name = "uxSaveButton";
            this.uxSaveButton.Size = new System.Drawing.Size(134, 58);
            this.uxSaveButton.TabIndex = 56;
            this.uxSaveButton.Text = "Save";
            this.uxSaveButton.UseVisualStyleBackColor = true;
            this.uxSaveButton.Click += new System.EventHandler(this.uxSaveButton_Click);
            // 
            // uxGuestScoreLabel
            // 
            this.uxGuestScoreLabel.AutoSize = true;
            this.uxGuestScoreLabel.Font = new System.Drawing.Font("Berlin Sans FB", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxGuestScoreLabel.Location = new System.Drawing.Point(451, 185);
            this.uxGuestScoreLabel.Name = "uxGuestScoreLabel";
            this.uxGuestScoreLabel.Size = new System.Drawing.Size(74, 26);
            this.uxGuestScoreLabel.TabIndex = 65;
            this.uxGuestScoreLabel.Text = "Score: ";
            // 
            // uxGuestScore
            // 
            this.uxGuestScore.Font = new System.Drawing.Font("Berlin Sans FB", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxGuestScore.Location = new System.Drawing.Point(536, 179);
            this.uxGuestScore.Name = "uxGuestScore";
            this.uxGuestScore.Size = new System.Drawing.Size(112, 27);
            this.uxGuestScore.TabIndex = 64;
            this.uxGuestScore.ValueChanged += new System.EventHandler(this.uxGuestScore_ValueChanged);
            // 
            // uxHomeScoreLabel
            // 
            this.uxHomeScoreLabel.AutoSize = true;
            this.uxHomeScoreLabel.Font = new System.Drawing.Font("Berlin Sans FB", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxHomeScoreLabel.Location = new System.Drawing.Point(68, 185);
            this.uxHomeScoreLabel.Name = "uxHomeScoreLabel";
            this.uxHomeScoreLabel.Size = new System.Drawing.Size(74, 26);
            this.uxHomeScoreLabel.TabIndex = 63;
            this.uxHomeScoreLabel.Text = "Score: ";
            // 
            // uxHomeScore
            // 
            this.uxHomeScore.Font = new System.Drawing.Font("Berlin Sans FB", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxHomeScore.Location = new System.Drawing.Point(147, 179);
            this.uxHomeScore.Name = "uxHomeScore";
            this.uxHomeScore.Size = new System.Drawing.Size(112, 27);
            this.uxHomeScore.TabIndex = 62;
            this.uxHomeScore.ValueChanged += new System.EventHandler(this.uxHomeScore_ValueChanged);
            // 
            // uxSelectGuestTeam
            // 
            this.uxSelectGuestTeam.AllowDrop = true;
            this.uxSelectGuestTeam.DisplayMember = "Select Team";
            this.uxSelectGuestTeam.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.uxSelectGuestTeam.Font = new System.Drawing.Font("Berlin Sans FB", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxSelectGuestTeam.FormattingEnabled = true;
            this.uxSelectGuestTeam.Location = new System.Drawing.Point(573, 94);
            this.uxSelectGuestTeam.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.uxSelectGuestTeam.MaxDropDownItems = 5;
            this.uxSelectGuestTeam.Name = "uxSelectGuestTeam";
            this.uxSelectGuestTeam.Size = new System.Drawing.Size(168, 28);
            this.uxSelectGuestTeam.Sorted = true;
            this.uxSelectGuestTeam.TabIndex = 66;
            this.uxSelectGuestTeam.SelectedIndexChanged += new System.EventHandler(this.uxSelectGuestTeam_SelectedIndexChanged_1);
            // 
            // InsertGameSchoolStatistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.uxSelectGuestTeam);
            this.Controls.Add(this.uxGuestScoreLabel);
            this.Controls.Add(this.uxGuestScore);
            this.Controls.Add(this.uxHomeScoreLabel);
            this.Controls.Add(this.uxHomeScore);
            this.Controls.Add(this.uxSelectHomeTeam);
            this.Controls.Add(this.uxGuestTeam);
            this.Controls.Add(this.uxHomeTeamLabel);
            this.Controls.Add(this.uxBackButton);
            this.Controls.Add(this.uxSaveButton);
            this.Name = "InsertGameSchoolStatistics";
            this.Text = "InsertGameSchoolStatistics";
            ((System.ComponentModel.ISupportInitialize)(this.uxGuestScore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uxHomeScore)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox uxSelectHomeTeam;
        private System.Windows.Forms.Label uxGuestTeam;
        private System.Windows.Forms.Label uxHomeTeamLabel;
        private System.Windows.Forms.Button uxBackButton;
        private System.Windows.Forms.Button uxSaveButton;
        private System.Windows.Forms.Label uxGuestScoreLabel;
        private System.Windows.Forms.NumericUpDown uxGuestScore;
        private System.Windows.Forms.Label uxHomeScoreLabel;
        private System.Windows.Forms.NumericUpDown uxHomeScore;
        private System.Windows.Forms.ComboBox uxSelectGuestTeam;
    }
}