namespace ProiectPAW2023_Tursim.Forms
{
    partial class Turisti
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Turisti));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.stergeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnAddTuristi = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuTuristi = new System.Windows.Forms.ToolStripMenuItem();
            this.tXTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xMLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.citireDinFisierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.btnPrintTurist = new System.Windows.Forms.Button();
            this.dgvTuristi = new System.Windows.Forms.DataGridView();
            this.printDocumentTuristi = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialogTuristi = new System.Windows.Forms.PrintPreviewDialog();
            this.contextMenuStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTuristi)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(23)))), ((int)(((byte)(40)))));
            this.contextMenuStrip1.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stergeToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(164, 42);
            // 
            // stergeToolStripMenuItem
            // 
            this.stergeToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(217)))), ((int)(((byte)(255)))));
            this.stergeToolStripMenuItem.Name = "stergeToolStripMenuItem";
            this.stergeToolStripMenuItem.Size = new System.Drawing.Size(163, 38);
            this.stergeToolStripMenuItem.Text = "Sterge ";
            this.stergeToolStripMenuItem.Click += new System.EventHandler(this.stergeToolStripMenuItem_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "manager.png");
            // 
            // btnAddTuristi
            // 
            this.btnAddTuristi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(32)))));
            this.btnAddTuristi.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(23)))), ((int)(((byte)(40)))));
            this.btnAddTuristi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddTuristi.Font = new System.Drawing.Font("Nirmala UI", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddTuristi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(99)))), ((int)(((byte)(135)))));
            this.btnAddTuristi.Location = new System.Drawing.Point(774, 855);
            this.btnAddTuristi.Name = "btnAddTuristi";
            this.btnAddTuristi.Size = new System.Drawing.Size(214, 131);
            this.btnAddTuristi.TabIndex = 1;
            this.btnAddTuristi.Text = "Adauga un nou turist";
            this.btnAddTuristi.UseVisualStyleBackColor = false;
            this.btnAddTuristi.Click += new System.EventHandler(this.btnAddTuristi_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(23)))), ((int)(((byte)(40)))));
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuTuristi,
            this.citireDinFisierToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1280, 45);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuTuristi
            // 
            this.menuTuristi.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tXTToolStripMenuItem,
            this.xMLToolStripMenuItem});
            this.menuTuristi.Font = new System.Drawing.Font("Nirmala UI", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuTuristi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(124)))), ((int)(((byte)(146)))));
            this.menuTuristi.Name = "menuTuristi";
            this.menuTuristi.Size = new System.Drawing.Size(248, 41);
            this.menuTuristi.Text = "Salvare în fisiere";
            // 
            // tXTToolStripMenuItem
            // 
            this.tXTToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(23)))), ((int)(((byte)(40)))));
            this.tXTToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(217)))), ((int)(((byte)(255)))));
            this.tXTToolStripMenuItem.Name = "tXTToolStripMenuItem";
            this.tXTToolStripMenuItem.Size = new System.Drawing.Size(211, 46);
            this.tXTToolStripMenuItem.Text = "TXT";
            this.tXTToolStripMenuItem.Click += new System.EventHandler(this.tXTToolStripMenuItem_Click);
            // 
            // xMLToolStripMenuItem
            // 
            this.xMLToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(23)))), ((int)(((byte)(40)))));
            this.xMLToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(217)))), ((int)(((byte)(255)))));
            this.xMLToolStripMenuItem.Name = "xMLToolStripMenuItem";
            this.xMLToolStripMenuItem.Size = new System.Drawing.Size(211, 46);
            this.xMLToolStripMenuItem.Text = "XML";
            this.xMLToolStripMenuItem.Click += new System.EventHandler(this.xMLToolStripMenuItem_Click);
            // 
            // citireDinFisierToolStripMenuItem
            // 
            this.citireDinFisierToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.citireDinFisierToolStripMenuItem.Font = new System.Drawing.Font("Nirmala UI", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.citireDinFisierToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(124)))), ((int)(((byte)(146)))));
            this.citireDinFisierToolStripMenuItem.Name = "citireDinFisierToolStripMenuItem";
            this.citireDinFisierToolStripMenuItem.Size = new System.Drawing.Size(226, 41);
            this.citireDinFisierToolStripMenuItem.Text = "Citire din fisier";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(23)))), ((int)(((byte)(40)))));
            this.toolStripMenuItem1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(217)))), ((int)(((byte)(255)))));
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(211, 46);
            this.toolStripMenuItem1.Text = "XML";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // btnPrintTurist
            // 
            this.btnPrintTurist.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(32)))));
            this.btnPrintTurist.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(23)))), ((int)(((byte)(40)))));
            this.btnPrintTurist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrintTurist.Font = new System.Drawing.Font("Nirmala UI", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrintTurist.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(146)))), ((int)(((byte)(89)))));
            this.btnPrintTurist.Location = new System.Drawing.Point(425, 855);
            this.btnPrintTurist.Name = "btnPrintTurist";
            this.btnPrintTurist.Size = new System.Drawing.Size(214, 131);
            this.btnPrintTurist.TabIndex = 4;
            this.btnPrintTurist.Text = "Printeaza informatiile despre turisti";
            this.btnPrintTurist.UseVisualStyleBackColor = false;
            this.btnPrintTurist.Click += new System.EventHandler(this.btnPrintTurist_Click);
            // 
            // dgvTuristi
            // 
            this.dgvTuristi.AllowUserToAddRows = false;
            this.dgvTuristi.AllowUserToDeleteRows = false;
            this.dgvTuristi.AllowUserToResizeColumns = false;
            this.dgvTuristi.AllowUserToResizeRows = false;
            this.dgvTuristi.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(32)))));
            this.dgvTuristi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvTuristi.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvTuristi.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(32)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Nirmala UI", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(217)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(32)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTuristi.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTuristi.ColumnHeadersHeight = 40;
            this.dgvTuristi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvTuristi.ContextMenuStrip = this.contextMenuStrip1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(32)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Nirmala UI", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(217)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(58)))), ((int)(((byte)(127)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTuristi.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvTuristi.EnableHeadersVisualStyles = false;
            this.dgvTuristi.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(124)))), ((int)(((byte)(146)))));
            this.dgvTuristi.Location = new System.Drawing.Point(26, 89);
            this.dgvTuristi.Name = "dgvTuristi";
            this.dgvTuristi.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(32)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(58)))), ((int)(((byte)(127)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTuristi.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvTuristi.RowHeadersWidth = 50;
            this.dgvTuristi.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvTuristi.RowTemplate.Height = 33;
            this.dgvTuristi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTuristi.Size = new System.Drawing.Size(1379, 713);
            this.dgvTuristi.TabIndex = 11;
            // 
            // printDocumentTuristi
            // 
            this.printDocumentTuristi.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocumentTuristi_PrintPage);
            // 
            // printPreviewDialogTuristi
            // 
            this.printPreviewDialogTuristi.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialogTuristi.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialogTuristi.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialogTuristi.Document = this.printDocumentTuristi;
            this.printPreviewDialogTuristi.Enabled = true;
            this.printPreviewDialogTuristi.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialogTuristi.Icon")));
            this.printPreviewDialogTuristi.Name = "printPreviewDialogTuristi";
            this.printPreviewDialogTuristi.Visible = false;
            // 
            // Turisti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(1280, 1088);
            this.Controls.Add(this.dgvTuristi);
            this.Controls.Add(this.btnPrintTurist);
            this.Controls.Add(this.btnAddTuristi);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Turisti";
            this.Text = "Turisti";
            this.Load += new System.EventHandler(this.Turisti_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTuristi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnAddTuristi;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuTuristi;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem stergeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tXTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xMLToolStripMenuItem;
        private System.Windows.Forms.Button btnPrintTurist;
        private System.Windows.Forms.DataGridView dgvTuristi;
        private System.Windows.Forms.ToolStripMenuItem citireDinFisierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Drawing.Printing.PrintDocument printDocumentTuristi;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialogTuristi;
    }
}