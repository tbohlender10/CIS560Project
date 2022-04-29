namespace CIS560_Project
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
            this.uxBack = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.uxPointDiff = new System.Windows.Forms.Button();
            this.uxPPG = new System.Windows.Forms.Button();
            this.uxUpsets = new System.Windows.Forms.Button();
            this.uxWins = new System.Windows.Forms.Button();
            this.uxUpsetCount = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // uxBack
            // 
            this.uxBack.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxBack.Location = new System.Drawing.Point(16, 364);
            this.uxBack.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.uxBack.Name = "uxBack";
            this.uxBack.Size = new System.Drawing.Size(127, 58);
            this.uxBack.TabIndex = 18;
            this.uxBack.Text = "Back";
            this.uxBack.UseVisualStyleBackColor = true;
            this.uxBack.Click += new System.EventHandler(this.uxBack_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Berlin Sans FB", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(407, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 19);
            this.label3.TabIndex = 17;
            this.label3.Text = "(Region 3 label)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Berlin Sans FB", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(607, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 19);
            this.label4.TabIndex = 16;
            this.label4.Text = "(Region 4 label)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Berlin Sans FB", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(215, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 19);
            this.label2.TabIndex = 15;
            this.label2.Text = "(Region 2 label)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Berlin Sans FB", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 19);
            this.label1.TabIndex = 14;
            this.label1.Text = "(Region 1 label)";
            // 
            // uxPointDiff
            // 
            this.uxPointDiff.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxPointDiff.Location = new System.Drawing.Point(557, 117);
            this.uxPointDiff.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.uxPointDiff.Name = "uxPointDiff";
            this.uxPointDiff.Size = new System.Drawing.Size(231, 79);
            this.uxPointDiff.TabIndex = 13;
            this.uxPointDiff.Text = "Most Common Margins of Victory";
            this.uxPointDiff.UseVisualStyleBackColor = true;
            this.uxPointDiff.Click += new System.EventHandler(this.uxPointDiff_Click);
            // 
            // uxPPG
            // 
            this.uxPPG.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxPPG.Location = new System.Drawing.Point(150, 246);
            this.uxPPG.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.uxPPG.Name = "uxPPG";
            this.uxPPG.Size = new System.Drawing.Size(197, 75);
            this.uxPPG.TabIndex = 12;
            this.uxPPG.Text = "Top 10 PPG";
            this.uxPPG.UseVisualStyleBackColor = true;
            this.uxPPG.Click += new System.EventHandler(this.uxPPG_Click);
            // 
            // uxUpsets
            // 
            this.uxUpsets.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxUpsets.Location = new System.Drawing.Point(427, 246);
            this.uxUpsets.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.uxUpsets.Name = "uxUpsets";
            this.uxUpsets.Size = new System.Drawing.Size(231, 75);
            this.uxUpsets.TabIndex = 11;
            this.uxUpsets.Text = "Biggest Upsets (By Seeding)";
            this.uxUpsets.UseVisualStyleBackColor = true;
            this.uxUpsets.Click += new System.EventHandler(this.uxUpsets_Click);
            // 
            // uxWins
            // 
            this.uxWins.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxWins.Location = new System.Drawing.Point(19, 120);
            this.uxWins.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.uxWins.Name = "uxWins";
            this.uxWins.Size = new System.Drawing.Size(197, 76);
            this.uxWins.TabIndex = 10;
            this.uxWins.Text = "Most Wins by School";
            this.uxWins.UseVisualStyleBackColor = true;
            this.uxWins.Click += new System.EventHandler(this.uxWins_Click);
            // 
            // uxUpsetCount
            // 
            this.uxUpsetCount.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxUpsetCount.Location = new System.Drawing.Point(281, 119);
            this.uxUpsetCount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.uxUpsetCount.Name = "uxUpsetCount";
            this.uxUpsetCount.Size = new System.Drawing.Size(231, 75);
            this.uxUpsetCount.TabIndex = 19;
            this.uxUpsetCount.Text = "Number of Upsets By Seed Difference";
            this.uxUpsetCount.UseVisualStyleBackColor = true;
            this.uxUpsetCount.Click += new System.EventHandler(this.uxUpsetCount_Click);
            // 
            // Tourney
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.uxUpsetCount);
            this.Controls.Add(this.uxBack);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.uxPointDiff);
            this.Controls.Add(this.uxPPG);
            this.Controls.Add(this.uxUpsets);
            this.Controls.Add(this.uxWins);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Tourney";
            this.Text = "Tourney";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Tourney_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button uxBack;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button uxPointDiff;
        private System.Windows.Forms.Button uxPPG;
        private System.Windows.Forms.Button uxUpsets;
        private System.Windows.Forms.Button uxWins;
        private System.Windows.Forms.Button uxUpsetCount;
    }
}