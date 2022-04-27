
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
            this.uxSaveButton.Location = new System.Drawing.Point(566, 227);
            this.uxSaveButton.Name = "uxSaveButton";
            this.uxSaveButton.Size = new System.Drawing.Size(134, 58);
            this.uxSaveButton.TabIndex = 0;
            this.uxSaveButton.Text = "Save";
            this.uxSaveButton.UseVisualStyleBackColor = true;
            // 
            // uxBackButton
            // 
            this.uxBackButton.Location = new System.Drawing.Point(33, 227);
            this.uxBackButton.Name = "uxBackButton";
            this.uxBackButton.Size = new System.Drawing.Size(134, 58);
            this.uxBackButton.TabIndex = 1;
            this.uxBackButton.Text = "Back";
            this.uxBackButton.UseVisualStyleBackColor = true;
            // 
            // uxHomeTeamLabel
            // 
            this.uxHomeTeamLabel.AutoSize = true;
            this.uxHomeTeamLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxHomeTeamLabel.Location = new System.Drawing.Point(28, 24);
            this.uxHomeTeamLabel.Name = "uxHomeTeamLabel";
            this.uxHomeTeamLabel.Size = new System.Drawing.Size(131, 25);
            this.uxHomeTeamLabel.TabIndex = 2;
            this.uxHomeTeamLabel.Text = "Home Team: ";
            // 
            // uxGuestTeam
            // 
            this.uxGuestTeam.AutoSize = true;
            this.uxGuestTeam.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxGuestTeam.Location = new System.Drawing.Point(395, 24);
            this.uxGuestTeam.Name = "uxGuestTeam";
            this.uxGuestTeam.Size = new System.Drawing.Size(131, 25);
            this.uxGuestTeam.TabIndex = 3;
            this.uxGuestTeam.Text = "Guest Team: ";
            // 
            // uxSelectHomeTeam
            // 
            this.uxSelectHomeTeam.AllowDrop = true;
            this.uxSelectHomeTeam.DisplayMember = "Select Team";
            this.uxSelectHomeTeam.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.uxSelectHomeTeam.FormattingEnabled = true;
            this.uxSelectHomeTeam.Location = new System.Drawing.Point(165, 25);
            this.uxSelectHomeTeam.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.uxSelectHomeTeam.MaxDropDownItems = 5;
            this.uxSelectHomeTeam.Name = "uxSelectHomeTeam";
            this.uxSelectHomeTeam.Size = new System.Drawing.Size(168, 28);
            this.uxSelectHomeTeam.Sorted = true;
            this.uxSelectHomeTeam.TabIndex = 54;
            this.uxSelectHomeTeam.SelectedIndexChanged += new System.EventHandler(this.uxSelectHomeTeam_SelectedIndexChanged);
            // 
            // uxSelectGuestTeam
            // 
            this.uxSelectGuestTeam.AllowDrop = true;
            this.uxSelectGuestTeam.DisplayMember = "Select Team";
            this.uxSelectGuestTeam.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.uxSelectGuestTeam.FormattingEnabled = true;
            this.uxSelectGuestTeam.Location = new System.Drawing.Point(532, 25);
            this.uxSelectGuestTeam.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.uxSelectGuestTeam.MaxDropDownItems = 5;
            this.uxSelectGuestTeam.Name = "uxSelectGuestTeam";
            this.uxSelectGuestTeam.Size = new System.Drawing.Size(168, 28);
            this.uxSelectGuestTeam.Sorted = true;
            this.uxSelectGuestTeam.TabIndex = 55;
            this.uxSelectGuestTeam.SelectedIndexChanged += new System.EventHandler(this.uxSelectGuestTeam_SelectedIndexChanged);
            // 
            // ChangeGameTeams
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 312);
            this.Controls.Add(this.uxSelectGuestTeam);
            this.Controls.Add(this.uxSelectHomeTeam);
            this.Controls.Add(this.uxGuestTeam);
            this.Controls.Add(this.uxHomeTeamLabel);
            this.Controls.Add(this.uxBackButton);
            this.Controls.Add(this.uxSaveButton);
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