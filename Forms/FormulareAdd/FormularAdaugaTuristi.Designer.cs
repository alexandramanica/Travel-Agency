namespace ProiectPAW2023_Tursim.Forms
{
    partial class FormularAdaugaTuristi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormularAdaugaTuristi));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel11 = new System.Windows.Forms.Panel();
            this.panel12 = new System.Windows.Forms.Panel();
            this.tbId = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel10 = new System.Windows.Forms.Panel();
            this.dtDataNastere = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.btnAddTuristForm = new System.Windows.Forms.Button();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.tbMail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.tbTelefon = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.tbPrenume = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tbNume = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel11.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(23)))), ((int)(((byte)(40)))));
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 75);
            this.panel1.TabIndex = 1;
            // 
            // btnClose
            // 
            this.btnClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClose.BackgroundImage")));
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Location = new System.Drawing.Point(709, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(32, 46);
            this.btnClose.TabIndex = 8;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ProiectPAW2023_Tursim.Resource1.icons8_user_64;
            this.pictureBox1.Location = new System.Drawing.Point(313, 104);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(113, 97);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // panel11
            // 
            this.panel11.Controls.Add(this.panel12);
            this.panel11.Controls.Add(this.tbId);
            this.panel11.Controls.Add(this.label6);
            this.panel11.Location = new System.Drawing.Point(27, 218);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(698, 93);
            this.panel11.TabIndex = 23;
            this.panel11.TabStop = true;
            // 
            // panel12
            // 
            this.panel12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(23)))), ((int)(((byte)(40)))));
            this.panel12.ForeColor = System.Drawing.Color.Coral;
            this.panel12.Location = new System.Drawing.Point(289, 66);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(452, 1);
            this.panel12.TabIndex = 4;
            // 
            // tbId
            // 
            this.tbId.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(124)))), ((int)(((byte)(146)))));
            this.tbId.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbId.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(23)))), ((int)(((byte)(40)))));
            this.tbId.Location = new System.Drawing.Point(241, 36);
            this.tbId.Multiline = true;
            this.tbId.Name = "tbId";
            this.tbId.Size = new System.Drawing.Size(454, 40);
            this.tbId.TabIndex = 4;
            this.tbId.Text = "Introdu id";
            this.tbId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbId.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tbId_MouseClick);
            this.tbId.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbId_KeyDown);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(23)))), ((int)(((byte)(40)))));
            this.label6.Location = new System.Drawing.Point(60, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 40);
            this.label6.TabIndex = 0;
            this.label6.Text = "Id";
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.dtDataNastere);
            this.panel10.Controls.Add(this.label5);
            this.panel10.Location = new System.Drawing.Point(30, 698);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(698, 86);
            this.panel10.TabIndex = 18;
            // 
            // dtDataNastere
            // 
            this.dtDataNastere.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(23)))), ((int)(((byte)(40)))));
            this.dtDataNastere.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(124)))), ((int)(((byte)(146)))));
            this.dtDataNastere.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(23)))), ((int)(((byte)(40)))));
            this.dtDataNastere.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(23)))), ((int)(((byte)(40)))));
            this.dtDataNastere.CalendarTrailingForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(23)))), ((int)(((byte)(40)))));
            this.dtDataNastere.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtDataNastere.Location = new System.Drawing.Point(361, 26);
            this.dtDataNastere.Name = "dtDataNastere";
            this.dtDataNastere.Size = new System.Drawing.Size(272, 39);
            this.dtDataNastere.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(23)))), ((int)(((byte)(40)))));
            this.label5.Location = new System.Drawing.Point(60, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(196, 40);
            this.label5.TabIndex = 0;
            this.label5.Text = "Data Nastere";
            // 
            // btnAddTuristForm
            // 
            this.btnAddTuristForm.FlatAppearance.BorderSize = 2;
            this.btnAddTuristForm.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(217)))), ((int)(((byte)(255)))));
            this.btnAddTuristForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddTuristForm.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddTuristForm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(23)))), ((int)(((byte)(40)))));
            this.btnAddTuristForm.Location = new System.Drawing.Point(45, 811);
            this.btnAddTuristForm.Name = "btnAddTuristForm";
            this.btnAddTuristForm.Size = new System.Drawing.Size(286, 97);
            this.btnAddTuristForm.TabIndex = 22;
            this.btnAddTuristForm.TabStop = false;
            this.btnAddTuristForm.Text = "Add";
            this.btnAddTuristForm.UseVisualStyleBackColor = true;
            this.btnAddTuristForm.Click += new System.EventHandler(this.btnAddTuristForm_Click);
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.panel9);
            this.panel8.Controls.Add(this.tbMail);
            this.panel8.Controls.Add(this.label4);
            this.panel8.Location = new System.Drawing.Point(30, 596);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(698, 87);
            this.panel8.TabIndex = 19;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(23)))), ((int)(((byte)(40)))));
            this.panel9.ForeColor = System.Drawing.Color.Coral;
            this.panel9.Location = new System.Drawing.Point(289, 66);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(452, 1);
            this.panel9.TabIndex = 4;
            // 
            // tbMail
            // 
            this.tbMail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbMail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(124)))), ((int)(((byte)(146)))));
            this.tbMail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbMail.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(23)))), ((int)(((byte)(40)))));
            this.tbMail.Location = new System.Drawing.Point(259, 34);
            this.tbMail.Multiline = true;
            this.tbMail.Name = "tbMail";
            this.tbMail.Size = new System.Drawing.Size(454, 40);
            this.tbMail.TabIndex = 4;
            this.tbMail.Text = "Introdu email";
            this.tbMail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbMail.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tbMail_MouseClick);
            this.tbMail.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbMail_KeyDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(23)))), ((int)(((byte)(40)))));
            this.label4.Location = new System.Drawing.Point(60, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 40);
            this.label4.TabIndex = 0;
            this.label4.Text = "Email";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.panel7);
            this.panel6.Controls.Add(this.tbTelefon);
            this.panel6.Controls.Add(this.label3);
            this.panel6.Location = new System.Drawing.Point(30, 503);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(698, 87);
            this.panel6.TabIndex = 20;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(23)))), ((int)(((byte)(40)))));
            this.panel7.ForeColor = System.Drawing.Color.Coral;
            this.panel7.Location = new System.Drawing.Point(289, 66);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(452, 1);
            this.panel7.TabIndex = 4;
            // 
            // tbTelefon
            // 
            this.tbTelefon.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbTelefon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(124)))), ((int)(((byte)(146)))));
            this.tbTelefon.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbTelefon.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTelefon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(23)))), ((int)(((byte)(40)))));
            this.tbTelefon.Location = new System.Drawing.Point(259, 34);
            this.tbTelefon.Multiline = true;
            this.tbTelefon.Name = "tbTelefon";
            this.tbTelefon.Size = new System.Drawing.Size(454, 40);
            this.tbTelefon.TabIndex = 4;
            this.tbTelefon.Text = "Introdu telefon";
            this.tbTelefon.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbTelefon.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tbTelefon_MouseClick);
            this.tbTelefon.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbTelefon_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(23)))), ((int)(((byte)(40)))));
            this.label3.Location = new System.Drawing.Point(60, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 40);
            this.label3.TabIndex = 0;
            this.label3.Text = "Telefon";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Controls.Add(this.tbPrenume);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Location = new System.Drawing.Point(30, 410);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(698, 87);
            this.panel4.TabIndex = 21;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(23)))), ((int)(((byte)(40)))));
            this.panel5.ForeColor = System.Drawing.Color.Coral;
            this.panel5.Location = new System.Drawing.Point(289, 66);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(452, 1);
            this.panel5.TabIndex = 4;
            // 
            // tbPrenume
            // 
            this.tbPrenume.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbPrenume.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(124)))), ((int)(((byte)(146)))));
            this.tbPrenume.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbPrenume.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPrenume.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(23)))), ((int)(((byte)(40)))));
            this.tbPrenume.Location = new System.Drawing.Point(265, 34);
            this.tbPrenume.Multiline = true;
            this.tbPrenume.Name = "tbPrenume";
            this.tbPrenume.Size = new System.Drawing.Size(454, 40);
            this.tbPrenume.TabIndex = 4;
            this.tbPrenume.Text = "Introdu prenume";
            this.tbPrenume.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbPrenume.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tbPrenume_MouseClick);
            this.tbPrenume.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbPrenume_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(23)))), ((int)(((byte)(40)))));
            this.label1.Location = new System.Drawing.Point(60, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Prenume";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.tbNume);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(27, 317);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(698, 87);
            this.panel2.TabIndex = 17;
            this.panel2.TabStop = true;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(23)))), ((int)(((byte)(40)))));
            this.panel3.ForeColor = System.Drawing.Color.Coral;
            this.panel3.Location = new System.Drawing.Point(289, 66);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(452, 1);
            this.panel3.TabIndex = 4;
            // 
            // tbNume
            // 
            this.tbNume.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbNume.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(124)))), ((int)(((byte)(146)))));
            this.tbNume.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbNume.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNume.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(23)))), ((int)(((byte)(40)))));
            this.tbNume.Location = new System.Drawing.Point(247, 33);
            this.tbNume.Multiline = true;
            this.tbNume.Name = "tbNume";
            this.tbNume.Size = new System.Drawing.Size(454, 40);
            this.tbNume.TabIndex = 4;
            this.tbNume.Text = "Introdu nume";
            this.tbNume.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbNume.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tbNume_MouseClick);
            this.tbNume.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbNume_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(23)))), ((int)(((byte)(40)))));
            this.label2.Location = new System.Drawing.Point(60, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 40);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nume";
            // 
            // btnClear
            // 
            this.btnClear.FlatAppearance.BorderSize = 2;
            this.btnClear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(217)))), ((int)(((byte)(255)))));
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(23)))), ((int)(((byte)(40)))));
            this.btnClear.Location = new System.Drawing.Point(411, 811);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(286, 97);
            this.btnClear.TabIndex = 24;
            this.btnClear.TabStop = false;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // FormularAdaugaTuristi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(124)))), ((int)(((byte)(146)))));
            this.ClientSize = new System.Drawing.Size(776, 1047);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel11);
            this.Controls.Add(this.panel10);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnAddTuristForm);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.panel6);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormularAdaugaTuristi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Adauga un nou turist";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel11.ResumeLayout(false);
            this.panel11.PerformLayout();
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.TextBox tbId;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.DateTimePicker dtDataNastere;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnAddTuristForm;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.TextBox tbMail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.TextBox tbTelefon;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox tbPrenume;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox tbNume;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnClear;
    }
}