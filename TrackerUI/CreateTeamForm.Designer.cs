
namespace TrackerUI
{
    partial class CreateTeamForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateTeamForm));
            this.txtHeader = new System.Windows.Forms.Label();
            this.txtTeamName = new System.Windows.Forms.Label();
            this.txtSelectTeamMember = new System.Windows.Forms.Label();
            this.comboSelectTeamMember = new System.Windows.Forms.ComboBox();
            this.txtBoxTeamName = new System.Windows.Forms.TextBox();
            this.btnAddMember = new System.Windows.Forms.Button();
            this.groupCreateMember = new System.Windows.Forms.GroupBox();
            this.btnCreateMember = new System.Windows.Forms.Button();
            this.txtBoxPhoneNumber = new System.Windows.Forms.TextBox();
            this.txtPhoneNumber = new System.Windows.Forms.Label();
            this.txtBoxEmail = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.Label();
            this.txtBoxLastName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.Label();
            this.txtBoxFirstName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.Label();
            this.listBoxTeamMembers = new System.Windows.Forms.ListBox();
            this.btnRemoveSelectedMember = new System.Windows.Forms.Button();
            this.btnCreateTeam = new System.Windows.Forms.Button();
            this.groupCreateMember.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtHeader
            // 
            this.txtHeader.AutoSize = true;
            this.txtHeader.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(12)))), ((int)(((byte)(171)))));
            this.txtHeader.Location = new System.Drawing.Point(24, 32);
            this.txtHeader.Name = "txtHeader";
            this.txtHeader.Size = new System.Drawing.Size(198, 45);
            this.txtHeader.TabIndex = 1;
            this.txtHeader.Text = "Create Team";
            // 
            // txtTeamName
            // 
            this.txtTeamName.AutoSize = true;
            this.txtTeamName.Font = new System.Drawing.Font("Segoe UI Light", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTeamName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(12)))), ((int)(((byte)(171)))));
            this.txtTeamName.Location = new System.Drawing.Point(24, 105);
            this.txtTeamName.Name = "txtTeamName";
            this.txtTeamName.Size = new System.Drawing.Size(157, 38);
            this.txtTeamName.TabIndex = 3;
            this.txtTeamName.Text = "Team Name";
            // 
            // txtSelectTeamMember
            // 
            this.txtSelectTeamMember.AutoSize = true;
            this.txtSelectTeamMember.Font = new System.Drawing.Font("Segoe UI Light", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSelectTeamMember.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(12)))), ((int)(((byte)(171)))));
            this.txtSelectTeamMember.Location = new System.Drawing.Point(24, 176);
            this.txtSelectTeamMember.Name = "txtSelectTeamMember";
            this.txtSelectTeamMember.Size = new System.Drawing.Size(261, 38);
            this.txtSelectTeamMember.TabIndex = 4;
            this.txtSelectTeamMember.Text = "Select Team Member";
            // 
            // comboSelectTeamMember
            // 
            this.comboSelectTeamMember.FormattingEnabled = true;
            this.comboSelectTeamMember.Location = new System.Drawing.Point(34, 217);
            this.comboSelectTeamMember.Name = "comboSelectTeamMember";
            this.comboSelectTeamMember.Size = new System.Drawing.Size(277, 28);
            this.comboSelectTeamMember.TabIndex = 5;
            // 
            // txtBoxTeamName
            // 
            this.txtBoxTeamName.Location = new System.Drawing.Point(34, 146);
            this.txtBoxTeamName.Name = "txtBoxTeamName";
            this.txtBoxTeamName.Size = new System.Drawing.Size(277, 27);
            this.txtBoxTeamName.TabIndex = 9;
            // 
            // btnAddMember
            // 
            this.btnAddMember.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(235)))), ((int)(((byte)(245)))));
            this.btnAddMember.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(12)))), ((int)(((byte)(171)))));
            this.btnAddMember.FlatAppearance.BorderSize = 2;
            this.btnAddMember.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(12)))), ((int)(((byte)(171)))));
            this.btnAddMember.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(157)))), ((int)(((byte)(237)))));
            this.btnAddMember.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddMember.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAddMember.Location = new System.Drawing.Point(34, 251);
            this.btnAddMember.Name = "btnAddMember";
            this.btnAddMember.Size = new System.Drawing.Size(144, 50);
            this.btnAddMember.TabIndex = 14;
            this.btnAddMember.Text = "Add Member";
            this.btnAddMember.UseVisualStyleBackColor = false;
            this.btnAddMember.Click += new System.EventHandler(this.btnAddMember_Click);
            // 
            // groupCreateMember
            // 
            this.groupCreateMember.Controls.Add(this.btnCreateMember);
            this.groupCreateMember.Controls.Add(this.txtBoxPhoneNumber);
            this.groupCreateMember.Controls.Add(this.txtPhoneNumber);
            this.groupCreateMember.Controls.Add(this.txtBoxEmail);
            this.groupCreateMember.Controls.Add(this.txtEmail);
            this.groupCreateMember.Controls.Add(this.txtBoxLastName);
            this.groupCreateMember.Controls.Add(this.txtLastName);
            this.groupCreateMember.Controls.Add(this.txtBoxFirstName);
            this.groupCreateMember.Controls.Add(this.txtFirstName);
            this.groupCreateMember.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupCreateMember.Location = new System.Drawing.Point(24, 345);
            this.groupCreateMember.Name = "groupCreateMember";
            this.groupCreateMember.Size = new System.Drawing.Size(431, 366);
            this.groupCreateMember.TabIndex = 15;
            this.groupCreateMember.TabStop = false;
            this.groupCreateMember.Text = "Add new member";
            // 
            // btnCreateMember
            // 
            this.btnCreateMember.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(235)))), ((int)(((byte)(245)))));
            this.btnCreateMember.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(12)))), ((int)(((byte)(171)))));
            this.btnCreateMember.FlatAppearance.BorderSize = 2;
            this.btnCreateMember.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(12)))), ((int)(((byte)(171)))));
            this.btnCreateMember.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(157)))), ((int)(((byte)(237)))));
            this.btnCreateMember.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateMember.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCreateMember.Location = new System.Drawing.Point(236, 288);
            this.btnCreateMember.Name = "btnCreateMember";
            this.btnCreateMember.Size = new System.Drawing.Size(166, 57);
            this.btnCreateMember.TabIndex = 16;
            this.btnCreateMember.Text = "Create Member";
            this.btnCreateMember.UseVisualStyleBackColor = false;
            this.btnCreateMember.Click += new System.EventHandler(this.btnCreateMember_Click);
            // 
            // txtBoxPhoneNumber
            // 
            this.txtBoxPhoneNumber.Location = new System.Drawing.Point(178, 230);
            this.txtBoxPhoneNumber.Name = "txtBoxPhoneNumber";
            this.txtBoxPhoneNumber.Size = new System.Drawing.Size(224, 34);
            this.txtBoxPhoneNumber.TabIndex = 23;
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.AutoSize = true;
            this.txtPhoneNumber.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPhoneNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(12)))), ((int)(((byte)(171)))));
            this.txtPhoneNumber.Location = new System.Drawing.Point(31, 230);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(144, 28);
            this.txtPhoneNumber.TabIndex = 22;
            this.txtPhoneNumber.Text = "Phone Number";
            // 
            // txtBoxEmail
            // 
            this.txtBoxEmail.Location = new System.Drawing.Point(178, 170);
            this.txtBoxEmail.Name = "txtBoxEmail";
            this.txtBoxEmail.Size = new System.Drawing.Size(224, 34);
            this.txtBoxEmail.TabIndex = 21;
            // 
            // txtEmail
            // 
            this.txtEmail.AutoSize = true;
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(12)))), ((int)(((byte)(171)))));
            this.txtEmail.Location = new System.Drawing.Point(31, 173);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(59, 28);
            this.txtEmail.TabIndex = 20;
            this.txtEmail.Text = "Email";
            // 
            // txtBoxLastName
            // 
            this.txtBoxLastName.Location = new System.Drawing.Point(178, 115);
            this.txtBoxLastName.Name = "txtBoxLastName";
            this.txtBoxLastName.Size = new System.Drawing.Size(224, 34);
            this.txtBoxLastName.TabIndex = 19;
            // 
            // txtLastName
            // 
            this.txtLastName.AutoSize = true;
            this.txtLastName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtLastName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(12)))), ((int)(((byte)(171)))));
            this.txtLastName.Location = new System.Drawing.Point(31, 115);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(103, 28);
            this.txtLastName.TabIndex = 18;
            this.txtLastName.Text = "Last Name";
            // 
            // txtBoxFirstName
            // 
            this.txtBoxFirstName.Location = new System.Drawing.Point(178, 50);
            this.txtBoxFirstName.Name = "txtBoxFirstName";
            this.txtBoxFirstName.Size = new System.Drawing.Size(224, 34);
            this.txtBoxFirstName.TabIndex = 17;
            // 
            // txtFirstName
            // 
            this.txtFirstName.AutoSize = true;
            this.txtFirstName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtFirstName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(12)))), ((int)(((byte)(171)))));
            this.txtFirstName.Location = new System.Drawing.Point(31, 50);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(106, 28);
            this.txtFirstName.TabIndex = 16;
            this.txtFirstName.Text = "First Name";
            // 
            // listBoxTeamMembers
            // 
            this.listBoxTeamMembers.FormattingEnabled = true;
            this.listBoxTeamMembers.ItemHeight = 20;
            this.listBoxTeamMembers.Location = new System.Drawing.Point(526, 145);
            this.listBoxTeamMembers.Name = "listBoxTeamMembers";
            this.listBoxTeamMembers.Size = new System.Drawing.Size(330, 464);
            this.listBoxTeamMembers.TabIndex = 16;
            // 
            // btnRemoveSelectedMember
            // 
            this.btnRemoveSelectedMember.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(235)))), ((int)(((byte)(245)))));
            this.btnRemoveSelectedMember.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(12)))), ((int)(((byte)(171)))));
            this.btnRemoveSelectedMember.FlatAppearance.BorderSize = 2;
            this.btnRemoveSelectedMember.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(12)))), ((int)(((byte)(171)))));
            this.btnRemoveSelectedMember.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(157)))), ((int)(((byte)(237)))));
            this.btnRemoveSelectedMember.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveSelectedMember.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnRemoveSelectedMember.Location = new System.Drawing.Point(879, 146);
            this.btnRemoveSelectedMember.Name = "btnRemoveSelectedMember";
            this.btnRemoveSelectedMember.Size = new System.Drawing.Size(98, 57);
            this.btnRemoveSelectedMember.TabIndex = 24;
            this.btnRemoveSelectedMember.Text = "Remove Selected";
            this.btnRemoveSelectedMember.UseVisualStyleBackColor = false;
            this.btnRemoveSelectedMember.Click += new System.EventHandler(this.btnRemoveSelectedMember_Click);
            // 
            // btnCreateTeam
            // 
            this.btnCreateTeam.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(235)))), ((int)(((byte)(245)))));
            this.btnCreateTeam.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(12)))), ((int)(((byte)(171)))));
            this.btnCreateTeam.FlatAppearance.BorderSize = 2;
            this.btnCreateTeam.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(12)))), ((int)(((byte)(171)))));
            this.btnCreateTeam.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(157)))), ((int)(((byte)(237)))));
            this.btnCreateTeam.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateTeam.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCreateTeam.Location = new System.Drawing.Point(553, 636);
            this.btnCreateTeam.Name = "btnCreateTeam";
            this.btnCreateTeam.Size = new System.Drawing.Size(279, 57);
            this.btnCreateTeam.TabIndex = 24;
            this.btnCreateTeam.Text = "Create Team";
            this.btnCreateTeam.UseVisualStyleBackColor = false;
            // 
            // CreateTeamForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 753);
            this.Controls.Add(this.btnCreateTeam);
            this.Controls.Add(this.btnRemoveSelectedMember);
            this.Controls.Add(this.listBoxTeamMembers);
            this.Controls.Add(this.groupCreateMember);
            this.Controls.Add(this.btnAddMember);
            this.Controls.Add(this.txtBoxTeamName);
            this.Controls.Add(this.comboSelectTeamMember);
            this.Controls.Add(this.txtSelectTeamMember);
            this.Controls.Add(this.txtTeamName);
            this.Controls.Add(this.txtHeader);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CreateTeamForm";
            this.Text = "Create Team";
            this.groupCreateMember.ResumeLayout(false);
            this.groupCreateMember.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtHeader;
        private System.Windows.Forms.Label txtTeamName;
        private System.Windows.Forms.Label txtSelectTeamMember;
        private System.Windows.Forms.ComboBox comboSelectTeamMember;
        private System.Windows.Forms.TextBox txtBoxTeamName;
        private System.Windows.Forms.Button btnAddMember;
        private System.Windows.Forms.GroupBox groupCreateMember;
        private System.Windows.Forms.TextBox txtBoxFirstName;
        private System.Windows.Forms.Label txtFirstName;
        private System.Windows.Forms.Button btnCreateMember;
        private System.Windows.Forms.TextBox txtBoxPhoneNumber;
        private System.Windows.Forms.Label txtPhoneNumber;
        private System.Windows.Forms.TextBox txtBoxEmail;
        private System.Windows.Forms.Label txtEmail;
        private System.Windows.Forms.TextBox txtBoxLastName;
        private System.Windows.Forms.Label txtLastName;
        private System.Windows.Forms.ListBox listBoxTeamMembers;
        private System.Windows.Forms.Button btnRemoveSelectedMember;
        private System.Windows.Forms.Button btnCreateTeam;
    }
}