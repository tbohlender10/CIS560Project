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
            this.button1 = new System.Windows.Forms.Button();
            this.uxSelectTeam = new System.Windows.Forms.ComboBox();
            this.uxSelectPlayer = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(471, 218);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 45);
            this.button1.TabIndex = 0;
            this.button1.Text = "View Player Stats";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // uxSelectTeam
            // 
            this.uxSelectTeam.AllowDrop = true;
            this.uxSelectTeam.DisplayMember = "Select Team";
            this.uxSelectTeam.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.uxSelectTeam.FormattingEnabled = true;
            this.uxSelectTeam.Location = new System.Drawing.Point(159, 40);
            this.uxSelectTeam.MaxDropDownItems = 64;
            this.uxSelectTeam.Name = "uxSelectTeam";
            this.uxSelectTeam.Size = new System.Drawing.Size(150, 24);
            this.uxSelectTeam.Sorted = true;
            this.uxSelectTeam.TabIndex = 2;
            this.uxSelectTeam.SelectedIndexChanged += new System.EventHandler(this.uxSelectTeam_SelectedIndexChanged);
            // 
            // uxSelectPlayer
            // 
            this.uxSelectPlayer.AllowDrop = true;
            this.uxSelectPlayer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.uxSelectPlayer.Enabled = false;
            this.uxSelectPlayer.FormattingEnabled = true;
            this.uxSelectPlayer.Location = new System.Drawing.Point(459, 40);
            this.uxSelectPlayer.Name = "uxSelectPlayer";
            this.uxSelectPlayer.Size = new System.Drawing.Size(150, 24);
            this.uxSelectPlayer.Sorted = true;
            this.uxSelectPlayer.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(193, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Select Team";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(496, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Select Player";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(164, 218);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(116, 45);
            this.button2.TabIndex = 6;
            this.button2.Text = "View Team Stats";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Stats
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.uxSelectPlayer);
            this.Controls.Add(this.uxSelectTeam);
            this.Controls.Add(this.button1);
            this.Name = "Stats";
            this.Text = "AddItem";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox uxSelectTeam;
        private System.Windows.Forms.ComboBox uxSelectPlayer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
    }
}