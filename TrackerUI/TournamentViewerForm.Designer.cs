
namespace TrackerUI
{
    partial class TournamentViewerForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TournamentViewerForm));
            this.txtHeader = new System.Windows.Forms.Label();
            this.txtTournamentName = new System.Windows.Forms.Label();
            this.txtRound = new System.Windows.Forms.Label();
            this.comboRound = new System.Windows.Forms.ComboBox();
            this.checkUnplayed = new System.Windows.Forms.CheckBox();
            this.listBoxMatchup = new System.Windows.Forms.ListBox();
            this.txtTeamOne = new System.Windows.Forms.Label();
            this.txtTeamOneScore = new System.Windows.Forms.Label();
            this.txtBoxTeamOneScoreValue = new System.Windows.Forms.TextBox();
            this.textBoxTeamTwoScore = new System.Windows.Forms.TextBox();
            this.txtTeamTwoScore = new System.Windows.Forms.Label();
            this.txtTeamTwo = new System.Windows.Forms.Label();
            this.txtVs = new System.Windows.Forms.Label();
            this.btnScore = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtHeader
            // 
            this.txtHeader.AutoSize = true;
            this.txtHeader.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(12)))), ((int)(((byte)(171)))));
            this.txtHeader.Location = new System.Drawing.Point(21, 28);
            this.txtHeader.Name = "txtHeader";
            this.txtHeader.Size = new System.Drawing.Size(210, 45);
            this.txtHeader.TabIndex = 0;
            this.txtHeader.Text = "Tournament :";
            // 
            // txtTournamentName
            // 
            this.txtTournamentName.AutoSize = true;
            this.txtTournamentName.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTournamentName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(12)))), ((int)(((byte)(171)))));
            this.txtTournamentName.Location = new System.Drawing.Point(243, 28);
            this.txtTournamentName.Name = "txtTournamentName";
            this.txtTournamentName.Size = new System.Drawing.Size(140, 45);
            this.txtTournamentName.TabIndex = 1;
            this.txtTournamentName.Text = "<none>";
            this.txtTournamentName.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtRound
            // 
            this.txtRound.AutoSize = true;
            this.txtRound.Font = new System.Drawing.Font("Segoe UI Light", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtRound.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(12)))), ((int)(((byte)(171)))));
            this.txtRound.Location = new System.Drawing.Point(33, 82);
            this.txtRound.Name = "txtRound";
            this.txtRound.Size = new System.Drawing.Size(95, 38);
            this.txtRound.TabIndex = 2;
            this.txtRound.Text = "Round";
            this.txtRound.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // comboRound
            // 
            this.comboRound.FormattingEnabled = true;
            this.comboRound.Location = new System.Drawing.Point(134, 92);
            this.comboRound.Name = "comboRound";
            this.comboRound.Size = new System.Drawing.Size(77, 28);
            this.comboRound.TabIndex = 3;
            // 
            // checkUnplayed
            // 
            this.checkUnplayed.AutoSize = true;
            this.checkUnplayed.ForeColor = System.Drawing.Color.Black;
            this.checkUnplayed.Location = new System.Drawing.Point(238, 142);
            this.checkUnplayed.Name = "checkUnplayed";
            this.checkUnplayed.Size = new System.Drawing.Size(128, 24);
            this.checkUnplayed.TabIndex = 4;
            this.checkUnplayed.Text = "Unplayed Only";
            this.checkUnplayed.UseVisualStyleBackColor = true;
            this.checkUnplayed.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // listBoxMatchup
            // 
            this.listBoxMatchup.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBoxMatchup.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listBoxMatchup.ForeColor = System.Drawing.SystemColors.ControlText;
            this.listBoxMatchup.FormattingEnabled = true;
            this.listBoxMatchup.ItemHeight = 20;
            this.listBoxMatchup.Location = new System.Drawing.Point(33, 172);
            this.listBoxMatchup.Name = "listBoxMatchup";
            this.listBoxMatchup.Size = new System.Drawing.Size(333, 302);
            this.listBoxMatchup.TabIndex = 5;
            // 
            // txtTeamOne
            // 
            this.txtTeamOne.AutoSize = true;
            this.txtTeamOne.Font = new System.Drawing.Font("Segoe UI Light", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTeamOne.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(12)))), ((int)(((byte)(171)))));
            this.txtTeamOne.Location = new System.Drawing.Point(397, 172);
            this.txtTeamOne.Name = "txtTeamOne";
            this.txtTeamOne.Size = new System.Drawing.Size(130, 38);
            this.txtTeamOne.TabIndex = 6;
            this.txtTeamOne.Text = "<team 1>";
            this.txtTeamOne.Click += new System.EventHandler(this.txtTeamOne_Click);
            // 
            // txtTeamOneScore
            // 
            this.txtTeamOneScore.AutoSize = true;
            this.txtTeamOneScore.Font = new System.Drawing.Font("Segoe UI Light", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTeamOneScore.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(12)))), ((int)(((byte)(171)))));
            this.txtTeamOneScore.Location = new System.Drawing.Point(397, 210);
            this.txtTeamOneScore.Name = "txtTeamOneScore";
            this.txtTeamOneScore.Size = new System.Drawing.Size(114, 38);
            this.txtTeamOneScore.TabIndex = 7;
            this.txtTeamOneScore.Text = "<score>";
            // 
            // txtBoxTeamOneScoreValue
            // 
            this.txtBoxTeamOneScoreValue.Location = new System.Drawing.Point(517, 221);
            this.txtBoxTeamOneScoreValue.Name = "txtBoxTeamOneScoreValue";
            this.txtBoxTeamOneScoreValue.Size = new System.Drawing.Size(125, 27);
            this.txtBoxTeamOneScoreValue.TabIndex = 8;
            // 
            // textBoxTeamTwoScore
            // 
            this.textBoxTeamTwoScore.Location = new System.Drawing.Point(517, 350);
            this.textBoxTeamTwoScore.Name = "textBoxTeamTwoScore";
            this.textBoxTeamTwoScore.Size = new System.Drawing.Size(125, 27);
            this.textBoxTeamTwoScore.TabIndex = 11;
            // 
            // txtTeamTwoScore
            // 
            this.txtTeamTwoScore.AutoSize = true;
            this.txtTeamTwoScore.Font = new System.Drawing.Font("Segoe UI Light", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTeamTwoScore.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(12)))), ((int)(((byte)(171)))));
            this.txtTeamTwoScore.Location = new System.Drawing.Point(397, 339);
            this.txtTeamTwoScore.Name = "txtTeamTwoScore";
            this.txtTeamTwoScore.Size = new System.Drawing.Size(114, 38);
            this.txtTeamTwoScore.TabIndex = 10;
            this.txtTeamTwoScore.Text = "<score>";
            // 
            // txtTeamTwo
            // 
            this.txtTeamTwo.AutoSize = true;
            this.txtTeamTwo.Font = new System.Drawing.Font("Segoe UI Light", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTeamTwo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(12)))), ((int)(((byte)(171)))));
            this.txtTeamTwo.Location = new System.Drawing.Point(397, 301);
            this.txtTeamTwo.Name = "txtTeamTwo";
            this.txtTeamTwo.Size = new System.Drawing.Size(134, 38);
            this.txtTeamTwo.TabIndex = 9;
            this.txtTeamTwo.Text = "<team 2>";
            // 
            // txtVs
            // 
            this.txtVs.AutoSize = true;
            this.txtVs.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtVs.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtVs.Location = new System.Drawing.Point(426, 268);
            this.txtVs.Name = "txtVs";
            this.txtVs.Size = new System.Drawing.Size(33, 25);
            this.txtVs.TabIndex = 12;
            this.txtVs.Text = "VS";
            this.txtVs.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // btnScore
            // 
            this.btnScore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(235)))), ((int)(((byte)(245)))));
            this.btnScore.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(12)))), ((int)(((byte)(171)))));
            this.btnScore.FlatAppearance.BorderSize = 2;
            this.btnScore.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(12)))), ((int)(((byte)(171)))));
            this.btnScore.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(157)))), ((int)(((byte)(237)))));
            this.btnScore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnScore.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnScore.Location = new System.Drawing.Point(537, 411);
            this.btnScore.Name = "btnScore";
            this.btnScore.Size = new System.Drawing.Size(105, 57);
            this.btnScore.TabIndex = 13;
            this.btnScore.Text = "Score";
            this.btnScore.UseVisualStyleBackColor = false;
            this.btnScore.Click += new System.EventHandler(this.btnScore_Click);
            // 
            // TournamentViewerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(696, 521);
            this.Controls.Add(this.btnScore);
            this.Controls.Add(this.txtVs);
            this.Controls.Add(this.textBoxTeamTwoScore);
            this.Controls.Add(this.txtTeamTwoScore);
            this.Controls.Add(this.txtTeamTwo);
            this.Controls.Add(this.txtBoxTeamOneScoreValue);
            this.Controls.Add(this.txtTeamOneScore);
            this.Controls.Add(this.txtTeamOne);
            this.Controls.Add(this.listBoxMatchup);
            this.Controls.Add(this.checkUnplayed);
            this.Controls.Add(this.comboRound);
            this.Controls.Add(this.txtRound);
            this.Controls.Add(this.txtTournamentName);
            this.Controls.Add(this.txtHeader);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TournamentViewerForm";
            this.Text = "Tournament Viewer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtHeader;
        private System.Windows.Forms.Label txtTournamentName;
        private System.Windows.Forms.Label txtRound;
        private System.Windows.Forms.ComboBox comboRound;
        private System.Windows.Forms.CheckBox checkUnplayed;
        private System.Windows.Forms.ListBox listBoxMatchup;
        private System.Windows.Forms.Label txtTeamOne;
        private System.Windows.Forms.Label txtTeamOneScore;
        private System.Windows.Forms.TextBox txtBoxTeamOneScoreValue;
        private System.Windows.Forms.TextBox textBoxTeamTwoScore;
        private System.Windows.Forms.Label txtTeamTwoScore;
        private System.Windows.Forms.Label txtTeamTwo;
        private System.Windows.Forms.Label txtVs;
        private System.Windows.Forms.Button btnScore;
    }
}

