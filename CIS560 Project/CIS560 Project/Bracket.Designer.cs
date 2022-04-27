
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
            this.uxMarchCalendar = new System.Windows.Forms.MonthCalendar();
            this.SuspendLayout();
            // 
            // uxTourney
            // 
            this.uxTourney.Font = new System.Drawing.Font("Berlin Sans FB", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxTourney.Location = new System.Drawing.Point(20, 226);
            this.uxTourney.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.uxTourney.Name = "uxTourney";
            this.uxTourney.Size = new System.Drawing.Size(113, 69);
            this.uxTourney.TabIndex = 134;
            this.uxTourney.Text = "View Tournament Statistics";
            this.uxTourney.UseVisualStyleBackColor = true;
            this.uxTourney.Click += new System.EventHandler(this.uxTourney_Click);
            // 
            // uxGames
            // 
            this.uxGames.Font = new System.Drawing.Font("Berlin Sans FB", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxGames.Location = new System.Drawing.Point(20, 115);
            this.uxGames.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.uxGames.Name = "uxGames";
            this.uxGames.Size = new System.Drawing.Size(113, 69);
            this.uxGames.TabIndex = 133;
            this.uxGames.Text = "Edit Games";
            this.uxGames.UseVisualStyleBackColor = true;
            this.uxGames.Click += new System.EventHandler(this.uxGames_Click);
            // 
            // uxStats
            // 
            this.uxStats.Font = new System.Drawing.Font("Berlin Sans FB", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxStats.Location = new System.Drawing.Point(20, 16);
            this.uxStats.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.uxStats.Name = "uxStats";
            this.uxStats.Size = new System.Drawing.Size(113, 69);
            this.uxStats.TabIndex = 132;
            this.uxStats.Text = "Player/Team Information";
            this.uxStats.UseVisualStyleBackColor = true;
            this.uxStats.Click += new System.EventHandler(this.uxStats_Click);
            // 
            // uxMarchCalendar
            // 
            this.uxMarchCalendar.Location = new System.Drawing.Point(186, 90);
            this.uxMarchCalendar.MaxDate = new System.DateTime(2022, 3, 31, 0, 0, 0, 0);
            this.uxMarchCalendar.MaxSelectionCount = 1;
            this.uxMarchCalendar.MinDate = new System.DateTime(2022, 3, 1, 0, 0, 0, 0);
            this.uxMarchCalendar.Name = "uxMarchCalendar";
            this.uxMarchCalendar.TabIndex = 135;
            // 
            // Bracket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(440, 326);
            this.Controls.Add(this.uxMarchCalendar);
            this.Controls.Add(this.uxTourney);
            this.Controls.Add(this.uxGames);
            this.Controls.Add(this.uxStats);
            this.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.Name = "Bracket";
            this.Text = "March Madness Stats Tracker";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button uxTourney;
        private System.Windows.Forms.Button uxGames;
        private System.Windows.Forms.Button uxStats;
        private System.Windows.Forms.MonthCalendar uxMarchCalendar;
    }
}

