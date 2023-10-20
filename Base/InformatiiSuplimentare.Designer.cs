namespace ProiectPAW2023_Tursim.Base
{
    partial class InformatiiSuplimentare
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InformatiiSuplimentare));
            this.lbStatistici = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tbInfo = new System.Windows.Forms.TextBox();
            this.btnClipboard = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbStatistici
            // 
            this.lbStatistici.AutoSize = true;
            this.lbStatistici.Font = new System.Drawing.Font("Segoe UI", 14.125F, System.Drawing.FontStyle.Bold);
            this.lbStatistici.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(124)))), ((int)(((byte)(146)))));
            this.lbStatistici.Location = new System.Drawing.Point(24, 91);
            this.lbStatistici.Name = "lbStatistici";
            this.lbStatistici.Size = new System.Drawing.Size(448, 51);
            this.lbStatistici.TabIndex = 1;
            this.lbStatistici.Text = "Informatii suplimentare";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(23)))), ((int)(((byte)(40)))));
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(682, 75);
            this.panel1.TabIndex = 9;
            // 
            // btnClose
            // 
            this.btnClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClose.BackgroundImage")));
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Location = new System.Drawing.Point(638, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(32, 46);
            this.btnClose.TabIndex = 8;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(217)))), ((int)(((byte)(255)))));
            this.label7.Location = new System.Drawing.Point(27, 161);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(616, 32);
            this.label7.TabIndex = 10;
            this.label7.Text = "Drag and drop un fisier pentru a-i afla locatia exacta";
            // 
            // panel2
            // 
            this.panel2.AllowDrop = true;
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(124)))), ((int)(((byte)(146)))));
            this.panel2.Location = new System.Drawing.Point(27, 239);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(615, 159);
            this.panel2.TabIndex = 11;
            this.panel2.DragDrop += new System.Windows.Forms.DragEventHandler(this.panel2_DragDrop);
            this.panel2.DragEnter += new System.Windows.Forms.DragEventHandler(this.panel2_DragEnter);
            // 
            // tbInfo
            // 
            this.tbInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(124)))), ((int)(((byte)(146)))));
            this.tbInfo.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(32)))));
            this.tbInfo.Location = new System.Drawing.Point(30, 460);
            this.tbInfo.Multiline = true;
            this.tbInfo.Name = "tbInfo";
            this.tbInfo.ReadOnly = true;
            this.tbInfo.Size = new System.Drawing.Size(613, 331);
            this.tbInfo.TabIndex = 12;
            // 
            // btnClipboard
            // 
            this.btnClipboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClipboard.Font = new System.Drawing.Font("Nirmala UI", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClipboard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(190)))), ((int)(((byte)(240)))));
            this.btnClipboard.Location = new System.Drawing.Point(339, 839);
            this.btnClipboard.Name = "btnClipboard";
            this.btnClipboard.Size = new System.Drawing.Size(303, 73);
            this.btnClipboard.TabIndex = 13;
            this.btnClipboard.Text = "Copy to clipboard";
            this.btnClipboard.UseVisualStyleBackColor = true;
            this.btnClipboard.Click += new System.EventHandler(this.btnClipboard_Click);
            // 
            // InformatiiSuplimentare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(682, 980);
            this.Controls.Add(this.btnClipboard);
            this.Controls.Add(this.tbInfo);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbStatistici);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "InformatiiSuplimentare";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InformatiiSuplimentare";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbStatistici;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox tbInfo;
        private System.Windows.Forms.Button btnClipboard;
    }
}