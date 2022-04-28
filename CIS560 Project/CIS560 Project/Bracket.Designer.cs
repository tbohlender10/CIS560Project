
namespace CIS560_Project
{
    partial class Bracket
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
            this.uxTourney = new System.Windows.Forms.Button();
            this.uxGames = new System.Windows.Forms.Button();
            this.uxStats = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // uxTourney
            // 
            this.uxTourney.Font = new System.Drawing.Font("Berlin Sans FB", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxTourney.Location = new System.Drawing.Point(236, 25);
            this.uxTourney.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.uxTourney.Name = "uxTourney";
            this.uxTourney.Size = new System.Drawing.Size(170, 106);
            this.uxTourney.TabIndex = 134;
            this.uxTourney.Text = "View Tournament Statistics";
            this.uxTourney.UseVisualStyleBackColor = true;
            this.uxTourney.Click += new System.EventHandler(this.uxTourney_Click);
            // 
            // uxGames
            // 
            this.uxGames.Font = new System.Drawing.Font("Berlin Sans FB", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxGames.Location = new System.Drawing.Point(436, 25);
            this.uxGames.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.uxGames.Name = "uxGames";
            this.uxGames.Size = new System.Drawing.Size(170, 106);
            this.uxGames.TabIndex = 133;
            this.uxGames.Text = "Edit Games";
            this.uxGames.UseVisualStyleBackColor = true;
            this.uxGames.Click += new System.EventHandler(this.uxGames_Click);
            // 
            // uxStats
            // 
            this.uxStats.Font = new System.Drawing.Font("Berlin Sans FB", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxStats.Location = new System.Drawing.Point(30, 25);
            this.uxStats.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.uxStats.Name = "uxStats";
            this.uxStats.Size = new System.Drawing.Size(170, 106);
            this.uxStats.TabIndex = 132;
            this.uxStats.Text = "Player/Team Information";
            this.uxStats.UseVisualStyleBackColor = true;
            this.uxStats.Click += new System.EventHandler(this.uxStats_Click);
            // 
            // Bracket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(660, 175);
            this.Controls.Add(this.uxTourney);
            this.Controls.Add(this.uxGames);
            this.Controls.Add(this.uxStats);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Bracket";
            this.Text = "March Madness Stats Tracker";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button uxTourney;
        private System.Windows.Forms.Button uxGames;
        private System.Windows.Forms.Button uxStats;
    }
}

