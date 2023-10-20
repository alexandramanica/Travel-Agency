namespace ProiectPAW2023_Tursim.Base
{
    partial class RateExperience
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RateExperience));
            this.comboBoxRate = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.lbStatistici = new System.Windows.Forms.Label();
            this.btnRate = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBoxRate
            // 
            this.comboBoxRate.FormattingEnabled = true;
            this.comboBoxRate.Location = new System.Drawing.Point(298, 187);
            this.comboBoxRate.Name = "comboBoxRate";
            this.comboBoxRate.Size = new System.Drawing.Size(231, 33);
            this.comboBoxRate.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(23)))), ((int)(((byte)(40)))));
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 75);
            this.panel1.TabIndex = 10;
            // 
            // btnClose
            // 
            this.btnClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClose.BackgroundImage")));
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Location = new System.Drawing.Point(739, 26);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(32, 46);
            this.btnClose.TabIndex = 8;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lbStatistici
            // 
            this.lbStatistici.AutoSize = true;
            this.lbStatistici.Font = new System.Drawing.Font("Segoe UI", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStatistici.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(124)))), ((int)(((byte)(146)))));
            this.lbStatistici.Location = new System.Drawing.Point(12, 98);
            this.lbStatistici.Name = "lbStatistici";
            this.lbStatistici.Size = new System.Drawing.Size(415, 40);
            this.lbStatistici.TabIndex = 9;
            this.lbStatistici.Text = "Rate your experience with us";
            // 
            // btnRate
            // 
            this.btnRate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRate.Font = new System.Drawing.Font("Nirmala UI", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(99)))), ((int)(((byte)(135)))));
            this.btnRate.Location = new System.Drawing.Point(251, 292);
            this.btnRate.Name = "btnRate";
            this.btnRate.Size = new System.Drawing.Size(303, 73);
            this.btnRate.TabIndex = 11;
            this.btnRate.Text = "Rate your experience";
            this.btnRate.UseVisualStyleBackColor = true;
            this.btnRate.Click += new System.EventHandler(this.btnRate_Click);
            // 
            // RateExperience
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRate);
            this.Controls.Add(this.lbStatistici);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.comboBoxRate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RateExperience";
            this.Text = "RateExperience";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxRate;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lbStatistici;
        private System.Windows.Forms.Button btnRate;
    }
}