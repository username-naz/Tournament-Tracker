
namespace TrackerUI
{
    partial class TournamentDashboardForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TournamentDashboardForm));
            this.txtHeader = new System.Windows.Forms.Label();
            this.txtRound = new System.Windows.Forms.Label();
            this.comboRound = new System.Windows.Forms.ComboBox();
            this.btnScore = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtHeader
            // 
            this.txtHeader.AutoSize = true;
            this.txtHeader.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(12)))), ((int)(((byte)(171)))));
            this.txtHeader.Location = new System.Drawing.Point(51, 37);
            this.txtHeader.Name = "txtHeader";
            this.txtHeader.Size = new System.Drawing.Size(439, 54);
            this.txtHeader.TabIndex = 1;
            this.txtHeader.Text = "Tournament Dashboard";
            this.txtHeader.Click += new System.EventHandler(this.txtHeader_Click_1);
            // 
            // txtRound
            // 
            this.txtRound.AutoSize = true;
            this.txtRound.Font = new System.Drawing.Font("Segoe UI Light", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtRound.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(12)))), ((int)(((byte)(171)))));
            this.txtRound.Location = new System.Drawing.Point(106, 142);
            this.txtRound.Name = "txtRound";
            this.txtRound.Size = new System.Drawing.Size(319, 38);
            this.txtRound.TabIndex = 3;
            this.txtRound.Text = "Load Existing Tournament";
            // 
            // comboRound
            // 
            this.comboRound.FormattingEnabled = true;
            this.comboRound.Location = new System.Drawing.Point(145, 193);
            this.comboRound.Name = "comboRound";
            this.comboRound.Size = new System.Drawing.Size(238, 28);
            this.comboRound.TabIndex = 4;
            // 
            // btnScore
            // 
            this.btnScore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(235)))), ((int)(((byte)(245)))));
            this.btnScore.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(12)))), ((int)(((byte)(171)))));
            this.btnScore.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(12)))), ((int)(((byte)(171)))));
            this.btnScore.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(157)))), ((int)(((byte)(237)))));
            this.btnScore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnScore.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnScore.Location = new System.Drawing.Point(199, 227);
            this.btnScore.Name = "btnScore";
            this.btnScore.Size = new System.Drawing.Size(145, 37);
            this.btnScore.TabIndex = 14;
            this.btnScore.Text = "Load Tournament";
            this.btnScore.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(235)))), ((int)(((byte)(245)))));
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(12)))), ((int)(((byte)(171)))));
            this.button1.FlatAppearance.BorderSize = 2;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(12)))), ((int)(((byte)(171)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(157)))), ((int)(((byte)(237)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Location = new System.Drawing.Point(121, 324);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(293, 67);
            this.button1.TabIndex = 15;
            this.button1.Text = "Create Tournament";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // TournamentDashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(531, 425);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnScore);
            this.Controls.Add(this.comboRound);
            this.Controls.Add(this.txtRound);
            this.Controls.Add(this.txtHeader);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TournamentDashboardForm";
            this.Text = "Tournament Dashboard";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtHeader;
        private System.Windows.Forms.Label txtRound;
        private System.Windows.Forms.ComboBox comboRound;
        private System.Windows.Forms.Button btnScore;
        private System.Windows.Forms.Button button1;
    }
}