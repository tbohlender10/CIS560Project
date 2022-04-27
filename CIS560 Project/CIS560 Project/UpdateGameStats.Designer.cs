
namespace CIS560_Project
{
    partial class UpdateGameStats
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
            this.uxSaveButton = new System.Windows.Forms.Button();
            this.uxBackButton = new System.Windows.Forms.Button();
            this.uxGuestScoreLabel = new System.Windows.Forms.Label();
            this.uxGuestScore = new System.Windows.Forms.NumericUpDown();
            this.uxHomeScoreLabel = new System.Windows.Forms.Label();
            this.uxHomeScore = new System.Windows.Forms.NumericUpDown();
            this.uxGuestSchoolLabel = new System.Windows.Forms.Label();
            this.uxHomeSchoolLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.uxGuestScore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uxHomeScore)).BeginInit();
            this.SuspendLayout();
            // 
            // uxSaveButton
            // 
            this.uxSaveButton.Font = new System.Drawing.Font("Berlin Sans FB", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxSaveButton.Location = new System.Drawing.Point(355, 126);
            this.uxSaveButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.uxSaveButton.Name = "uxSaveButton";
            this.uxSaveButton.Size = new System.Drawing.Size(97, 47);
            this.uxSaveButton.TabIndex = 15;
            this.uxSaveButton.Text = "Save";
            this.uxSaveButton.UseVisualStyleBackColor = true;
            this.uxSaveButton.Click += new System.EventHandler(this.uxSaveButton_Click);
            // 
            // uxBackButton
            // 
            this.uxBackButton.Font = new System.Drawing.Font("Berlin Sans FB", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxBackButton.Location = new System.Drawing.Point(40, 126);
            this.uxBackButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.uxBackButton.Name = "uxBackButton";
            this.uxBackButton.Size = new System.Drawing.Size(97, 47);
            this.uxBackButton.TabIndex = 14;
            this.uxBackButton.Text = "Back";
            this.uxBackButton.UseVisualStyleBackColor = true;
            this.uxBackButton.Click += new System.EventHandler(this.uxBackButton_Click);
            // 
            // uxGuestScoreLabel
            // 
            this.uxGuestScoreLabel.AutoSize = true;
            this.uxGuestScoreLabel.Font = new System.Drawing.Font("Berlin Sans FB", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxGuestScoreLabel.Location = new System.Drawing.Point(293, 75);
            this.uxGuestScoreLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.uxGuestScoreLabel.Name = "uxGuestScoreLabel";
            this.uxGuestScoreLabel.Size = new System.Drawing.Size(49, 17);
            this.uxGuestScoreLabel.TabIndex = 13;
            this.uxGuestScoreLabel.Text = "Score: ";
            // 
            // uxGuestScore
            // 
            this.uxGuestScore.Font = new System.Drawing.Font("Berlin Sans FB", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxGuestScore.Location = new System.Drawing.Point(350, 71);
            this.uxGuestScore.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.uxGuestScore.Name = "uxGuestScore";
            this.uxGuestScore.Size = new System.Drawing.Size(75, 21);
            this.uxGuestScore.TabIndex = 12;
            this.uxGuestScore.ValueChanged += new System.EventHandler(this.uxGuestScore_ValueChanged);
            // 
            // uxHomeScoreLabel
            // 
            this.uxHomeScoreLabel.AutoSize = true;
            this.uxHomeScoreLabel.Font = new System.Drawing.Font("Berlin Sans FB", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxHomeScoreLabel.Location = new System.Drawing.Point(38, 75);
            this.uxHomeScoreLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.uxHomeScoreLabel.Name = "uxHomeScoreLabel";
            this.uxHomeScoreLabel.Size = new System.Drawing.Size(49, 17);
            this.uxHomeScoreLabel.TabIndex = 11;
            this.uxHomeScoreLabel.Text = "Score: ";
            // 
            // uxHomeScore
            // 
            this.uxHomeScore.Font = new System.Drawing.Font("Berlin Sans FB", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxHomeScore.Location = new System.Drawing.Point(91, 71);
            this.uxHomeScore.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.uxHomeScore.Name = "uxHomeScore";
            this.uxHomeScore.Size = new System.Drawing.Size(75, 21);
            this.uxHomeScore.TabIndex = 10;
            this.uxHomeScore.ValueChanged += new System.EventHandler(this.uxHomeScore_ValueChanged);
            // 
            // uxGuestSchoolLabel
            // 
            this.uxGuestSchoolLabel.AutoSize = true;
            this.uxGuestSchoolLabel.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxGuestSchoolLabel.Location = new System.Drawing.Point(321, 24);
            this.uxGuestSchoolLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.uxGuestSchoolLabel.Name = "uxGuestSchoolLabel";
            this.uxGuestSchoolLabel.Size = new System.Drawing.Size(93, 18);
            this.uxGuestSchoolLabel.TabIndex = 9;
            this.uxGuestSchoolLabel.Text = "Guest School:";
            // 
            // uxHomeSchoolLabel
            // 
            this.uxHomeSchoolLabel.AutoSize = true;
            this.uxHomeSchoolLabel.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxHomeSchoolLabel.Location = new System.Drawing.Point(62, 29);
            this.uxHomeSchoolLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.uxHomeSchoolLabel.Name = "uxHomeSchoolLabel";
            this.uxHomeSchoolLabel.Size = new System.Drawing.Size(96, 18);
            this.uxHomeSchoolLabel.TabIndex = 8;
            this.uxHomeSchoolLabel.Text = "Home School:";
            // 
            // UpdateGameStats
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 199);
            this.Controls.Add(this.uxSaveButton);
            this.Controls.Add(this.uxBackButton);
            this.Controls.Add(this.uxGuestScoreLabel);
            this.Controls.Add(this.uxGuestScore);
            this.Controls.Add(this.uxHomeScoreLabel);
            this.Controls.Add(this.uxHomeScore);
            this.Controls.Add(this.uxGuestSchoolLabel);
            this.Controls.Add(this.uxHomeSchoolLabel);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "UpdateGameStats";
            this.Text = "UpdatePlayerGameStats";
            ((System.ComponentModel.ISupportInitialize)(this.uxGuestScore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uxHomeScore)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button uxSaveButton;
        private System.Windows.Forms.Button uxBackButton;
        private System.Windows.Forms.Label uxGuestScoreLabel;
        private System.Windows.Forms.NumericUpDown uxGuestScore;
        private System.Windows.Forms.Label uxHomeScoreLabel;
        private System.Windows.Forms.NumericUpDown uxHomeScore;
        private System.Windows.Forms.Label uxGuestSchoolLabel;
        private System.Windows.Forms.Label uxHomeSchoolLabel;
    }
}