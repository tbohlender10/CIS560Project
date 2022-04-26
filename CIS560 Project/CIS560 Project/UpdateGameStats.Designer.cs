
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
            this.uxHomeSchoolLabel = new System.Windows.Forms.Label();
            this.uxGuestSchoolLabel = new System.Windows.Forms.Label();
            this.uxHomeScore = new System.Windows.Forms.NumericUpDown();
            this.uxHomeScoreLabel = new System.Windows.Forms.Label();
            this.uxGuestScoreLabel = new System.Windows.Forms.Label();
            this.uxGuestScore = new System.Windows.Forms.NumericUpDown();
            this.uxBackButton = new System.Windows.Forms.Button();
            this.uxSaveButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.uxHomeScore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uxGuestScore)).BeginInit();
            this.SuspendLayout();
            // 
            // uxHomeSchoolLabel
            // 
            this.uxHomeSchoolLabel.AutoSize = true;
            this.uxHomeSchoolLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxHomeSchoolLabel.Location = new System.Drawing.Point(55, 37);
            this.uxHomeSchoolLabel.Name = "uxHomeSchoolLabel";
            this.uxHomeSchoolLabel.Size = new System.Drawing.Size(165, 29);
            this.uxHomeSchoolLabel.TabIndex = 0;
            this.uxHomeSchoolLabel.Text = "Home School:";
            // 
            // uxGuestSchoolLabel
            // 
            this.uxGuestSchoolLabel.AutoSize = true;
            this.uxGuestSchoolLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxGuestSchoolLabel.Location = new System.Drawing.Point(404, 37);
            this.uxGuestSchoolLabel.Name = "uxGuestSchoolLabel";
            this.uxGuestSchoolLabel.Size = new System.Drawing.Size(163, 29);
            this.uxGuestSchoolLabel.TabIndex = 1;
            this.uxGuestSchoolLabel.Text = "Guest School:";
            // 
            // uxHomeScore
            // 
            this.uxHomeScore.Location = new System.Drawing.Point(136, 110);
            this.uxHomeScore.Name = "uxHomeScore";
            this.uxHomeScore.Size = new System.Drawing.Size(113, 26);
            this.uxHomeScore.TabIndex = 2;
            this.uxHomeScore.ValueChanged += new System.EventHandler(this.uxHomeScore_ValueChanged);
            // 
            // uxHomeScoreLabel
            // 
            this.uxHomeScoreLabel.AutoSize = true;
            this.uxHomeScoreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxHomeScoreLabel.Location = new System.Drawing.Point(55, 108);
            this.uxHomeScoreLabel.Name = "uxHomeScoreLabel";
            this.uxHomeScoreLabel.Size = new System.Drawing.Size(75, 25);
            this.uxHomeScoreLabel.TabIndex = 3;
            this.uxHomeScoreLabel.Text = "Score: ";
            // 
            // uxGuestScoreLabel
            // 
            this.uxGuestScoreLabel.AutoSize = true;
            this.uxGuestScoreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxGuestScoreLabel.Location = new System.Drawing.Point(404, 108);
            this.uxGuestScoreLabel.Name = "uxGuestScoreLabel";
            this.uxGuestScoreLabel.Size = new System.Drawing.Size(75, 25);
            this.uxGuestScoreLabel.TabIndex = 5;
            this.uxGuestScoreLabel.Text = "Score: ";
            // 
            // uxGuestScore
            // 
            this.uxGuestScore.Location = new System.Drawing.Point(485, 110);
            this.uxGuestScore.Name = "uxGuestScore";
            this.uxGuestScore.Size = new System.Drawing.Size(113, 26);
            this.uxGuestScore.TabIndex = 4;
            this.uxGuestScore.ValueChanged += new System.EventHandler(this.uxGuestScore_ValueChanged);
            // 
            // uxBackButton
            // 
            this.uxBackButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxBackButton.Location = new System.Drawing.Point(60, 194);
            this.uxBackButton.Name = "uxBackButton";
            this.uxBackButton.Size = new System.Drawing.Size(146, 72);
            this.uxBackButton.TabIndex = 6;
            this.uxBackButton.Text = "Back";
            this.uxBackButton.UseVisualStyleBackColor = true;
            this.uxBackButton.Click += new System.EventHandler(this.uxBackButton_Click);
            // 
            // uxSaveButton
            // 
            this.uxSaveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxSaveButton.Location = new System.Drawing.Point(514, 194);
            this.uxSaveButton.Name = "uxSaveButton";
            this.uxSaveButton.Size = new System.Drawing.Size(146, 72);
            this.uxSaveButton.TabIndex = 7;
            this.uxSaveButton.Text = "Save";
            this.uxSaveButton.UseVisualStyleBackColor = true;
            this.uxSaveButton.Click += new System.EventHandler(this.uxSaveButton_Click);
            // 
            // UpdateGameStats
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 306);
            this.Controls.Add(this.uxSaveButton);
            this.Controls.Add(this.uxBackButton);
            this.Controls.Add(this.uxGuestScoreLabel);
            this.Controls.Add(this.uxGuestScore);
            this.Controls.Add(this.uxHomeScoreLabel);
            this.Controls.Add(this.uxHomeScore);
            this.Controls.Add(this.uxGuestSchoolLabel);
            this.Controls.Add(this.uxHomeSchoolLabel);
            this.Name = "UpdateGameStats";
            this.Text = "UpdateGameStats";
            ((System.ComponentModel.ISupportInitialize)(this.uxHomeScore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uxGuestScore)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label uxHomeSchoolLabel;
        private System.Windows.Forms.Label uxGuestSchoolLabel;
        private System.Windows.Forms.NumericUpDown uxHomeScore;
        private System.Windows.Forms.Label uxHomeScoreLabel;
        private System.Windows.Forms.Label uxGuestScoreLabel;
        private System.Windows.Forms.NumericUpDown uxGuestScore;
        private System.Windows.Forms.Button uxBackButton;
        private System.Windows.Forms.Button uxSaveButton;
    }
}