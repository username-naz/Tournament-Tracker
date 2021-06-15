
namespace TrackerUI
{
    partial class CreatePrizeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreatePrizeForm));
            this.txtHeader = new System.Windows.Forms.Label();
            this.txtPlaceNumber = new System.Windows.Forms.Label();
            this.txtPlaceName = new System.Windows.Forms.Label();
            this.txtPrizeAmount = new System.Windows.Forms.Label();
            this.txtPrizePercentage = new System.Windows.Forms.Label();
            this.txtBoxPlaceNumber = new System.Windows.Forms.TextBox();
            this.txtboxPlaceName = new System.Windows.Forms.TextBox();
            this.txtBoxPrizeAmount = new System.Windows.Forms.TextBox();
            this.txtBoxPrizePercentage = new System.Windows.Forms.TextBox();
            this.txtVs = new System.Windows.Forms.Label();
            this.btnCreatePrize = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtHeader
            // 
            this.txtHeader.AutoSize = true;
            this.txtHeader.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(12)))), ((int)(((byte)(171)))));
            this.txtHeader.Location = new System.Drawing.Point(25, 32);
            this.txtHeader.Name = "txtHeader";
            this.txtHeader.Size = new System.Drawing.Size(191, 45);
            this.txtHeader.TabIndex = 1;
            this.txtHeader.Text = "Create Prize";
            // 
            // txtPlaceNumber
            // 
            this.txtPlaceNumber.AutoSize = true;
            this.txtPlaceNumber.Font = new System.Drawing.Font("Segoe UI Light", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPlaceNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(12)))), ((int)(((byte)(171)))));
            this.txtPlaceNumber.Location = new System.Drawing.Point(33, 106);
            this.txtPlaceNumber.Name = "txtPlaceNumber";
            this.txtPlaceNumber.Size = new System.Drawing.Size(183, 38);
            this.txtPlaceNumber.TabIndex = 3;
            this.txtPlaceNumber.Text = "Place Number";
            // 
            // txtPlaceName
            // 
            this.txtPlaceName.AutoSize = true;
            this.txtPlaceName.Font = new System.Drawing.Font("Segoe UI Light", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPlaceName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(12)))), ((int)(((byte)(171)))));
            this.txtPlaceName.Location = new System.Drawing.Point(33, 160);
            this.txtPlaceName.Name = "txtPlaceName";
            this.txtPlaceName.Size = new System.Drawing.Size(157, 38);
            this.txtPlaceName.TabIndex = 4;
            this.txtPlaceName.Text = "Place Name";
            // 
            // txtPrizeAmount
            // 
            this.txtPrizeAmount.AutoSize = true;
            this.txtPrizeAmount.Font = new System.Drawing.Font("Segoe UI Light", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPrizeAmount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(12)))), ((int)(((byte)(171)))));
            this.txtPrizeAmount.Location = new System.Drawing.Point(33, 214);
            this.txtPrizeAmount.Name = "txtPrizeAmount";
            this.txtPrizeAmount.Size = new System.Drawing.Size(177, 38);
            this.txtPrizeAmount.TabIndex = 5;
            this.txtPrizeAmount.Text = "Prize Amount";
            this.txtPrizeAmount.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtPrizePercentage
            // 
            this.txtPrizePercentage.AutoSize = true;
            this.txtPrizePercentage.Font = new System.Drawing.Font("Segoe UI Light", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPrizePercentage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(12)))), ((int)(((byte)(171)))));
            this.txtPrizePercentage.Location = new System.Drawing.Point(33, 295);
            this.txtPrizePercentage.Name = "txtPrizePercentage";
            this.txtPrizePercentage.Size = new System.Drawing.Size(210, 38);
            this.txtPrizePercentage.TabIndex = 6;
            this.txtPrizePercentage.Text = "Prize Percentage";
            // 
            // txtBoxPlaceNumber
            // 
            this.txtBoxPlaceNumber.Location = new System.Drawing.Point(264, 117);
            this.txtBoxPlaceNumber.Name = "txtBoxPlaceNumber";
            this.txtBoxPlaceNumber.Size = new System.Drawing.Size(156, 27);
            this.txtBoxPlaceNumber.TabIndex = 11;
            // 
            // txtboxPlaceName
            // 
            this.txtboxPlaceName.Location = new System.Drawing.Point(264, 171);
            this.txtboxPlaceName.Name = "txtboxPlaceName";
            this.txtboxPlaceName.Size = new System.Drawing.Size(156, 27);
            this.txtboxPlaceName.TabIndex = 12;
            // 
            // txtBoxPrizeAmount
            // 
            this.txtBoxPrizeAmount.Location = new System.Drawing.Point(264, 225);
            this.txtBoxPrizeAmount.Name = "txtBoxPrizeAmount";
            this.txtBoxPrizeAmount.Size = new System.Drawing.Size(156, 27);
            this.txtBoxPrizeAmount.TabIndex = 13;
            // 
            // txtBoxPrizePercentage
            // 
            this.txtBoxPrizePercentage.Location = new System.Drawing.Point(264, 306);
            this.txtBoxPrizePercentage.Name = "txtBoxPrizePercentage";
            this.txtBoxPrizePercentage.Size = new System.Drawing.Size(156, 27);
            this.txtBoxPrizePercentage.TabIndex = 14;
            this.txtBoxPrizePercentage.TextChanged += new System.EventHandler(this.txtBoxPrizePercentage_TextChanged);
            // 
            // txtVs
            // 
            this.txtVs.AutoSize = true;
            this.txtVs.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtVs.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtVs.Location = new System.Drawing.Point(210, 270);
            this.txtVs.Name = "txtVs";
            this.txtVs.Size = new System.Drawing.Size(43, 25);
            this.txtVs.TabIndex = 15;
            this.txtVs.Text = "-or-";
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
            this.btnCreatePrize.Location = new System.Drawing.Point(315, 381);
            this.btnCreatePrize.Name = "btnCreatePrize";
            this.btnCreatePrize.Size = new System.Drawing.Size(105, 57);
            this.btnCreatePrize.TabIndex = 16;
            this.btnCreatePrize.Text = "Create Prize";
            this.btnCreatePrize.UseVisualStyleBackColor = false;
            // 
            // CreatePrizeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(472, 480);
            this.Controls.Add(this.btnCreatePrize);
            this.Controls.Add(this.txtVs);
            this.Controls.Add(this.txtBoxPrizePercentage);
            this.Controls.Add(this.txtBoxPrizeAmount);
            this.Controls.Add(this.txtboxPlaceName);
            this.Controls.Add(this.txtBoxPlaceNumber);
            this.Controls.Add(this.txtPrizePercentage);
            this.Controls.Add(this.txtPrizeAmount);
            this.Controls.Add(this.txtPlaceName);
            this.Controls.Add(this.txtPlaceNumber);
            this.Controls.Add(this.txtHeader);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CreatePrizeForm";
            this.Text = "Create Prize";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtHeader;
        private System.Windows.Forms.Label txtPlaceNumber;
        private System.Windows.Forms.Label txtPlaceName;
        private System.Windows.Forms.Label txtPrizeAmount;
        private System.Windows.Forms.Label txtPrizePercentage;
        private System.Windows.Forms.TextBox txtBoxPlaceNumber;
        private System.Windows.Forms.TextBox txtboxPlaceName;
        private System.Windows.Forms.TextBox txtBoxPrizeAmount;
        private System.Windows.Forms.TextBox txtBoxPrizePercentage;
        private System.Windows.Forms.Label txtVs;
        private System.Windows.Forms.Button btnCreatePrize;
    }
}