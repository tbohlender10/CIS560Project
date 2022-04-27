
namespace CIS560_Project
{
    partial class ChangeGameTeams
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
            this.uxHomeTeamLabel = new System.Windows.Forms.Label();
            this.uxGuestTeam = new System.Windows.Forms.Label();
            this.uxSelectHomeTeam = new System.Windows.Forms.ComboBox();
            this.uxSelectGuestTeam = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // uxSaveButton
            // 
            this.uxSaveButton.Font = new System.Drawing.Font("Berlin Sans FB", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxSaveButton.Location = new System.Drawing.Point(377, 148);
            this.uxSaveButton.Margin = new System.Windows.Forms.Padding(2);
            this.uxSaveButton.Name = "uxSaveButton";
            this.uxSaveButton.Size = new System.Drawing.Size(89, 38);
            this.uxSaveButton.TabIndex = 0;
            this.uxSaveButton.Text = "Save";
            this.uxSaveButton.UseVisualStyleBackColor = true;
            // 
            // uxBackButton
            // 
            this.uxBackButton.Font = new System.Drawing.Font("Berlin Sans FB", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxBackButton.Location = new System.Drawing.Point(22, 148);
            this.uxBackButton.Margin = new System.Windows.Forms.Padding(2);
            this.uxBackButton.Name = "uxBackButton";
            this.uxBackButton.Size = new System.Drawing.Size(89, 38);
            this.uxBackButton.TabIndex = 1;
            this.uxBackButton.Text = "Back";
            this.uxBackButton.UseVisualStyleBackColor = true;
            // 
            // uxHomeTeamLabel
            // 
            this.uxHomeTeamLabel.AutoSize = true;
            this.uxHomeTeamLabel.Font = new System.Drawing.Font("Berlin Sans FB", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxHomeTeamLabel.Location = new System.Drawing.Point(19, 16);
            this.uxHomeTeamLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.uxHomeTeamLabel.Name = "uxHomeTeamLabel";
            this.uxHomeTeamLabel.Size = new System.Drawing.Size(95, 17);
            this.uxHomeTeamLabel.TabIndex = 2;
            this.uxHomeTeamLabel.Text = "Home Team: ";
            // 
            // uxGuestTeam
            // 
            this.uxGuestTeam.AutoSize = true;
            this.uxGuestTeam.Font = new System.Drawing.Font("Berlin Sans FB", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxGuestTeam.Location = new System.Drawing.Point(261, 17);
            this.uxGuestTeam.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.uxGuestTeam.Name = "uxGuestTeam";
            this.uxGuestTeam.Size = new System.Drawing.Size(90, 17);
            this.uxGuestTeam.TabIndex = 3;
            this.uxGuestTeam.Text = "Guest Team: ";
            // 
            // uxSelectHomeTeam
            // 
            this.uxSelectHomeTeam.AllowDrop = true;
            this.uxSelectHomeTeam.DisplayMember = "Select Team";
            this.uxSelectHomeTeam.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.uxSelectHomeTeam.Font = new System.Drawing.Font("Berlin Sans FB", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxSelectHomeTeam.FormattingEnabled = true;
            this.uxSelectHomeTeam.Location = new System.Drawing.Point(110, 16);
            this.uxSelectHomeTeam.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.uxSelectHomeTeam.MaxDropDownItems = 5;
            this.uxSelectHomeTeam.Name = "uxSelectHomeTeam";
            this.uxSelectHomeTeam.Size = new System.Drawing.Size(113, 21);
            this.uxSelectHomeTeam.Sorted = true;
            this.uxSelectHomeTeam.TabIndex = 54;
            this.uxSelectHomeTeam.SelectedIndexChanged += new System.EventHandler(this.uxSelectHomeTeam_SelectedIndexChanged);
            // 
            // uxSelectGuestTeam
            // 
            this.uxSelectGuestTeam.AllowDrop = true;
            this.uxSelectGuestTeam.DisplayMember = "Select Team";
            this.uxSelectGuestTeam.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.uxSelectGuestTeam.Font = new System.Drawing.Font("Berlin Sans FB", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxSelectGuestTeam.FormattingEnabled = true;
            this.uxSelectGuestTeam.Location = new System.Drawing.Point(355, 16);
            this.uxSelectGuestTeam.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.uxSelectGuestTeam.MaxDropDownItems = 5;
            this.uxSelectGuestTeam.Name = "uxSelectGuestTeam";
            this.uxSelectGuestTeam.Size = new System.Drawing.Size(113, 21);
            this.uxSelectGuestTeam.Sorted = true;
            this.uxSelectGuestTeam.TabIndex = 55;
            this.uxSelectGuestTeam.SelectedIndexChanged += new System.EventHandler(this.uxSelectGuestTeam_SelectedIndexChanged);
            // 
            // ChangeGameTeams
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 203);
            this.Controls.Add(this.uxSelectGuestTeam);
            this.Controls.Add(this.uxSelectHomeTeam);
            this.Controls.Add(this.uxGuestTeam);
            this.Controls.Add(this.uxHomeTeamLabel);
            this.Controls.Add(this.uxBackButton);
            this.Controls.Add(this.uxSaveButton);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ChangeGameTeams";
            this.Text = "ChangeGameTeams";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button uxSaveButton;
        private System.Windows.Forms.Button uxBackButton;
        private System.Windows.Forms.Label uxHomeTeamLabel;
        private System.Windows.Forms.Label uxGuestTeam;
        private System.Windows.Forms.ComboBox uxSelectHomeTeam;
        private System.Windows.Forms.ComboBox uxSelectGuestTeam;
    }
}