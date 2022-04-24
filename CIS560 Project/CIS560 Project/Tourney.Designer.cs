﻿namespace CIS560_Project
{
    partial class Tourney
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
            this.uxWins = new System.Windows.Forms.Button();
            this.uxUpsets = new System.Windows.Forms.Button();
            this.uxPPG = new System.Windows.Forms.Button();
            this.uxPointDiff = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.uxBack = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // uxWins
            // 
            this.uxWins.Location = new System.Drawing.Point(69, 44);
            this.uxWins.Name = "uxWins";
            this.uxWins.Size = new System.Drawing.Size(104, 76);
            this.uxWins.TabIndex = 0;
            this.uxWins.Text = "Most Wins by School";
            this.uxWins.UseVisualStyleBackColor = true;
            this.uxWins.Click += new System.EventHandler(this.uxWins_Click);
            // 
            // uxUpsets
            // 
            this.uxUpsets.Location = new System.Drawing.Point(601, 44);
            this.uxUpsets.Name = "uxUpsets";
            this.uxUpsets.Size = new System.Drawing.Size(105, 70);
            this.uxUpsets.TabIndex = 1;
            this.uxUpsets.Text = "Top 5 Upsets (By seeding)";
            this.uxUpsets.UseVisualStyleBackColor = true;
            this.uxUpsets.Click += new System.EventHandler(this.uxUpsets_Click);
            // 
            // uxPPG
            // 
            this.uxPPG.Location = new System.Drawing.Point(238, 55);
            this.uxPPG.Name = "uxPPG";
            this.uxPPG.Size = new System.Drawing.Size(99, 55);
            this.uxPPG.TabIndex = 2;
            this.uxPPG.Text = "Top 10 PPG (By Region)";
            this.uxPPG.UseVisualStyleBackColor = true;
            this.uxPPG.Click += new System.EventHandler(this.uxPPG_Click);
            // 
            // uxPointDiff
            // 
            this.uxPointDiff.Location = new System.Drawing.Point(414, 44);
            this.uxPointDiff.Name = "uxPointDiff";
            this.uxPointDiff.Size = new System.Drawing.Size(111, 79);
            this.uxPointDiff.TabIndex = 3;
            this.uxPointDiff.Text = "Top 5 Team Point Differentials";
            this.uxPointDiff.UseVisualStyleBackColor = true;
            this.uxPointDiff.Click += new System.EventHandler(this.uxPointDiff_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "(Region 1 label)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(235, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "(Region 2 label)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(598, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "(Region 4 label)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(411, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "(Region 3 label)";
            // 
            // uxBack
            // 
            this.uxBack.Location = new System.Drawing.Point(12, 380);
            this.uxBack.Name = "uxBack";
            this.uxBack.Size = new System.Drawing.Size(127, 58);
            this.uxBack.TabIndex = 8;
            this.uxBack.Text = "Back";
            this.uxBack.UseVisualStyleBackColor = true;
            this.uxBack.Click += new System.EventHandler(this.uxBack_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(342, 200);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(144, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Smaller Queries Here";
            // 
            // Tourney
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.uxBack);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.uxPointDiff);
            this.Controls.Add(this.uxPPG);
            this.Controls.Add(this.uxUpsets);
            this.Controls.Add(this.uxWins);
            this.Name = "Tourney";
            this.Text = "Tourney";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Tourney_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button uxWins;
        private System.Windows.Forms.Button uxUpsets;
        private System.Windows.Forms.Button uxPPG;
        private System.Windows.Forms.Button uxPointDiff;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button uxBack;
        private System.Windows.Forms.Label label5;
    }
}