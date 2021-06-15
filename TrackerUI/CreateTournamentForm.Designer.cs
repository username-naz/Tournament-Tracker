
namespace TrackerUI
{
    partial class CreateTournamentForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateTournamentForm));
            this.txtHeader = new System.Windows.Forms.Label();
            this.txtTournamentName = new System.Windows.Forms.Label();
            this.txtEntryFee = new System.Windows.Forms.Label();
            this.txtSelectTeam = new System.Windows.Forms.Label();
            this.txtTeam = new System.Windows.Forms.Label();
            this.txtPrizes = new System.Windows.Forms.Label();
            this.txtBoxTournamentName = new System.Windows.Forms.TextBox();
            this.txtBoxEntryFee = new System.Windows.Forms.TextBox();
            this.comboSelectTeam = new System.Windows.Forms.ComboBox();
            this.listBoxTeam = new System.Windows.Forms.ListBox();
            this.btnRemoveSelectedTeam = new System.Windows.Forms.Button();
            this.btnRemoveSelectedPrize = new System.Windows.Forms.Button();
            this.listBoxPrizes = new System.Windows.Forms.ListBox();
            this.btnAddTeam = new System.Windows.Forms.Button();
            this.btnCreatePrize = new System.Windows.Forms.Button();
            this.btnCreateTournament = new System.Windows.Forms.Button();
            this.linkCreateTeam = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // txtHeader
            // 
            this.txtHeader.AutoSize = true;
            this.txtHeader.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(12)))), ((int)(((byte)(171)))));
            this.txtHeader.Location = new System.Drawing.Point(26, 31);
            this.txtHeader.Name = "txtHeader";
            this.txtHeader.Size = new System.Drawing.Size(296, 45);
            this.txtHeader.TabIndex = 1;
            this.txtHeader.Text = "Create Tournament";
            // 
            // txtTournamentName
            // 
            this.txtTournamentName.AutoSize = true;
            this.txtTournamentName.Font = new System.Drawing.Font("Segoe UI Light", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTournamentName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(12)))), ((int)(((byte)(171)))));
            this.txtTournamentName.Location = new System.Drawing.Point(43, 116);
            this.txtTournamentName.Name = "txtTournamentName";
            this.txtTournamentName.Size = new System.Drawing.Size(235, 38);
            this.txtTournamentName.TabIndex = 3;
            this.txtTournamentName.Text = "Tournament Name";
            // 
            // txtEntryFee
            // 
            this.txtEntryFee.AutoSize = true;
            this.txtEntryFee.Font = new System.Drawing.Font("Segoe UI Light", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtEntryFee.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(12)))), ((int)(((byte)(171)))));
            this.txtEntryFee.Location = new System.Drawing.Point(42, 207);
            this.txtEntryFee.Name = "txtEntryFee";
            this.txtEntryFee.Size = new System.Drawing.Size(127, 38);
            this.txtEntryFee.TabIndex = 4;
            this.txtEntryFee.Text = "Entry Fee";
            // 
            // txtSelectTeam
            // 
            this.txtSelectTeam.AutoSize = true;
            this.txtSelectTeam.Font = new System.Drawing.Font("Segoe UI Light", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSelectTeam.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(12)))), ((int)(((byte)(171)))));
            this.txtSelectTeam.Location = new System.Drawing.Point(42, 284);
            this.txtSelectTeam.Name = "txtSelectTeam";
            this.txtSelectTeam.Size = new System.Drawing.Size(154, 38);
            this.txtSelectTeam.TabIndex = 5;
            this.txtSelectTeam.Text = "Select Team";
            // 
            // txtTeam
            // 
            this.txtTeam.AutoSize = true;
            this.txtTeam.Font = new System.Drawing.Font("Segoe UI Light", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTeam.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(12)))), ((int)(((byte)(171)))));
            this.txtTeam.Location = new System.Drawing.Point(438, 92);
            this.txtTeam.Name = "txtTeam";
            this.txtTeam.Size = new System.Drawing.Size(186, 38);
            this.txtTeam.TabIndex = 6;
            this.txtTeam.Text = "Team / Players";
            this.txtTeam.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtPrizes
            // 
            this.txtPrizes.AutoSize = true;
            this.txtPrizes.Font = new System.Drawing.Font("Segoe UI Light", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPrizes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(12)))), ((int)(((byte)(171)))));
            this.txtPrizes.Location = new System.Drawing.Point(438, 325);
            this.txtPrizes.Name = "txtPrizes";
            this.txtPrizes.Size = new System.Drawing.Size(85, 38);
            this.txtPrizes.TabIndex = 7;
            this.txtPrizes.Text = "Prizes";
            this.txtPrizes.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtBoxTournamentName
            // 
            this.txtBoxTournamentName.Location = new System.Drawing.Point(43, 157);
            this.txtBoxTournamentName.Name = "txtBoxTournamentName";
            this.txtBoxTournamentName.Size = new System.Drawing.Size(289, 27);
            this.txtBoxTournamentName.TabIndex = 9;
            // 
            // txtBoxEntryFee
            // 
            this.txtBoxEntryFee.Location = new System.Drawing.Point(175, 218);
            this.txtBoxEntryFee.Name = "txtBoxEntryFee";
            this.txtBoxEntryFee.Size = new System.Drawing.Size(125, 27);
            this.txtBoxEntryFee.TabIndex = 10;
            // 
            // comboSelectTeam
            // 
            this.comboSelectTeam.FormattingEnabled = true;
            this.comboSelectTeam.Location = new System.Drawing.Point(42, 325);
            this.comboSelectTeam.Name = "comboSelectTeam";
            this.comboSelectTeam.Size = new System.Drawing.Size(290, 28);
            this.comboSelectTeam.TabIndex = 11;
            // 
            // listBoxTeam
            // 
            this.listBoxTeam.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBoxTeam.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listBoxTeam.ForeColor = System.Drawing.SystemColors.ControlText;
            this.listBoxTeam.FormattingEnabled = true;
            this.listBoxTeam.ItemHeight = 20;
            this.listBoxTeam.Location = new System.Drawing.Point(438, 145);
            this.listBoxTeam.Name = "listBoxTeam";
            this.listBoxTeam.Size = new System.Drawing.Size(236, 162);
            this.listBoxTeam.TabIndex = 12;
            // 
            // btnRemoveSelectedTeam
            // 
            this.btnRemoveSelectedTeam.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(235)))), ((int)(((byte)(245)))));
            this.btnRemoveSelectedTeam.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(12)))), ((int)(((byte)(171)))));
            this.btnRemoveSelectedTeam.FlatAppearance.BorderSize = 2;
            this.btnRemoveSelectedTeam.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(12)))), ((int)(((byte)(171)))));
            this.btnRemoveSelectedTeam.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(157)))), ((int)(((byte)(237)))));
            this.btnRemoveSelectedTeam.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveSelectedTeam.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnRemoveSelectedTeam.Location = new System.Drawing.Point(720, 157);
            this.btnRemoveSelectedTeam.Name = "btnRemoveSelectedTeam";
            this.btnRemoveSelectedTeam.Size = new System.Drawing.Size(105, 57);
            this.btnRemoveSelectedTeam.TabIndex = 14;
            this.btnRemoveSelectedTeam.Text = "Remove Selected";
            this.btnRemoveSelectedTeam.UseVisualStyleBackColor = false;
            // 
            // btnRemoveSelectedPrize
            // 
            this.btnRemoveSelectedPrize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(235)))), ((int)(((byte)(245)))));
            this.btnRemoveSelectedPrize.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(12)))), ((int)(((byte)(171)))));
            this.btnRemoveSelectedPrize.FlatAppearance.BorderSize = 2;
            this.btnRemoveSelectedPrize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(12)))), ((int)(((byte)(171)))));
            this.btnRemoveSelectedPrize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(157)))), ((int)(((byte)(237)))));
            this.btnRemoveSelectedPrize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveSelectedPrize.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnRemoveSelectedPrize.Location = new System.Drawing.Point(720, 461);
            this.btnRemoveSelectedPrize.Name = "btnRemoveSelectedPrize";
            this.btnRemoveSelectedPrize.Size = new System.Drawing.Size(105, 57);
            this.btnRemoveSelectedPrize.TabIndex = 16;
            this.btnRemoveSelectedPrize.Text = "Remove Selected";
            this.btnRemoveSelectedPrize.UseVisualStyleBackColor = false;
            // 
            // listBoxPrizes
            // 
            this.listBoxPrizes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBoxPrizes.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listBoxPrizes.ForeColor = System.Drawing.SystemColors.ControlText;
            this.listBoxPrizes.FormattingEnabled = true;
            this.listBoxPrizes.ItemHeight = 20;
            this.listBoxPrizes.Location = new System.Drawing.Point(438, 384);
            this.listBoxPrizes.Name = "listBoxPrizes";
            this.listBoxPrizes.Size = new System.Drawing.Size(236, 162);
            this.listBoxPrizes.TabIndex = 15;
            // 
            // btnAddTeam
            // 
            this.btnAddTeam.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(235)))), ((int)(((byte)(245)))));
            this.btnAddTeam.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(12)))), ((int)(((byte)(171)))));
            this.btnAddTeam.FlatAppearance.BorderSize = 2;
            this.btnAddTeam.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(12)))), ((int)(((byte)(171)))));
            this.btnAddTeam.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(157)))), ((int)(((byte)(237)))));
            this.btnAddTeam.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddTeam.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAddTeam.Location = new System.Drawing.Point(217, 359);
            this.btnAddTeam.Name = "btnAddTeam";
            this.btnAddTeam.Size = new System.Drawing.Size(105, 57);
            this.btnAddTeam.TabIndex = 17;
            this.btnAddTeam.Text = "Add Team";
            this.btnAddTeam.UseVisualStyleBackColor = false;
            // 
            // btnCreatePrize
            // 
            this.btnCreatePrize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(235)))), ((int)(((byte)(245)))));
            this.btnCreatePrize.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(12)))), ((int)(((byte)(171)))));
            this.btnCreatePrize.FlatAppearance.BorderSize = 2;
            this.btnCreatePrize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(12)))), ((int)(((byte)(171)))));
            this.btnCreatePrize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(157)))), ((int)(((byte)(237)))));
            this.btnCreatePrize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreatePrize.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCreatePrize.Location = new System.Drawing.Point(720, 384);
            this.btnCreatePrize.Name = "btnCreatePrize";
            this.btnCreatePrize.Size = new System.Drawing.Size(105, 57);
            this.btnCreatePrize.TabIndex = 18;
            this.btnCreatePrize.Text = "Create Prize";
            this.btnCreatePrize.UseVisualStyleBackColor = false;
            // 
            // btnCreateTournament
            // 
            this.btnCreateTournament.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(235)))), ((int)(((byte)(245)))));
            this.btnCreateTournament.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(12)))), ((int)(((byte)(171)))));
            this.btnCreateTournament.FlatAppearance.BorderSize = 2;
            this.btnCreateTournament.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(12)))), ((int)(((byte)(171)))));
            this.btnCreateTournament.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(157)))), ((int)(((byte)(237)))));
            this.btnCreateTournament.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateTournament.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCreateTournament.Location = new System.Drawing.Point(64, 489);
            this.btnCreateTournament.Name = "btnCreateTournament";
            this.btnCreateTournament.Size = new System.Drawing.Size(248, 57);
            this.btnCreateTournament.TabIndex = 19;
            this.btnCreateTournament.Text = "Create Tournament";
            this.btnCreateTournament.UseVisualStyleBackColor = false;
            // 
            // linkCreateTeam
            // 
            this.linkCreateTeam.AutoSize = true;
            this.linkCreateTeam.Location = new System.Drawing.Point(239, 298);
            this.linkCreateTeam.Name = "linkCreateTeam";
            this.linkCreateTeam.Size = new System.Drawing.Size(83, 20);
            this.linkCreateTeam.TabIndex = 20;
            this.linkCreateTeam.TabStop = true;
            this.linkCreateTeam.Text = "Create new";
            // 
            // CreateTournamentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(872, 593);
            this.Controls.Add(this.linkCreateTeam);
            this.Controls.Add(this.btnCreateTournament);
            this.Controls.Add(this.btnCreatePrize);
            this.Controls.Add(this.btnAddTeam);
            this.Controls.Add(this.btnRemoveSelectedPrize);
            this.Controls.Add(this.listBoxPrizes);
            this.Controls.Add(this.btnRemoveSelectedTeam);
            this.Controls.Add(this.listBoxTeam);
            this.Controls.Add(this.comboSelectTeam);
            this.Controls.Add(this.txtBoxEntryFee);
            this.Controls.Add(this.txtBoxTournamentName);
            this.Controls.Add(this.txtPrizes);
            this.Controls.Add(this.txtTeam);
            this.Controls.Add(this.txtSelectTeam);
            this.Controls.Add(this.txtEntryFee);
            this.Controls.Add(this.txtTournamentName);
            this.Controls.Add(this.txtHeader);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CreateTournamentForm";
            this.Text = "Create Tournament";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtHeader;
        private System.Windows.Forms.Label txtTournamentName;
        private System.Windows.Forms.Label txtEntryFee;
        private System.Windows.Forms.Label txtSelectTeam;
        private System.Windows.Forms.Label txtTeam;
        private System.Windows.Forms.Label txtPrizes;
        private System.Windows.Forms.TextBox txtBoxTournamentName;
        private System.Windows.Forms.TextBox txtBoxEntryFee;
        private System.Windows.Forms.ComboBox comboSelectTeam;
        private System.Windows.Forms.ListBox listBoxTeam;
        private System.Windows.Forms.Button btnRemoveSelectedTeam;
        private System.Windows.Forms.Button btnRemoveSelectedPrize;
        private System.Windows.Forms.ListBox listBoxPrizes;
        private System.Windows.Forms.Button btnAddTeam;
        private System.Windows.Forms.Button btnCreatePrize;
        private System.Windows.Forms.Button btnCreateTournament;
        private System.Windows.Forms.LinkLabel linkCreateTeam;
    }
}