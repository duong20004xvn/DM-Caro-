namespace DM_Caro_
{
    partial class frmCaRo
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.playerVsPlayerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnPvsP = new System.Windows.Forms.Button();
            this.btnChoiMoi = new System.Windows.Forms.Button();
            this.pnlBanCo = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.tmChayChu = new System.Windows.Forms.Timer(this.components);
            this.pnlChu = new System.Windows.Forms.Panel();
            this.lblChuoi = new System.Windows.Forms.Label();
            this.lblX_Y = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.pnlNut = new System.Windows.Forms.Panel();
            this.btnNut1 = new System.Windows.Forms.Button();
            this.ptbPic = new System.Windows.Forms.PictureBox();
            this.pnlHinh = new System.Windows.Forms.Panel();
            this.btnMini = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlChu.SuspendLayout();
            this.pnlNut.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbPic)).BeginInit();
            this.pnlHinh.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 35);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(103, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.playerVsPlayerToolStripMenuItem});
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.newToolStripMenuItem.Text = "&New";
            // 
            // playerVsPlayerToolStripMenuItem
            // 
            this.playerVsPlayerToolStripMenuItem.Name = "playerVsPlayerToolStripMenuItem";
            this.playerVsPlayerToolStripMenuItem.Size = new System.Drawing.Size(193, 26);
            this.playerVsPlayerToolStripMenuItem.Text = "Player vs Player";
            this.playerVsPlayerToolStripMenuItem.Click += new System.EventHandler(this.PvsP);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(122, 26);
            this.exitToolStripMenuItem.Text = "&Exit";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.undoToolStripMenuItem,
            this.redoToolStripMenuItem});
            this.editToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(49, 24);
            this.editToolStripMenuItem.Text = "&Edit";
            // 
            // undoToolStripMenuItem
            // 
            this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            this.undoToolStripMenuItem.Size = new System.Drawing.Size(128, 26);
            this.undoToolStripMenuItem.Text = "&Undo";
            this.undoToolStripMenuItem.Click += new System.EventHandler(this.undoToolStripMenuItem_Click);
            // 
            // redoToolStripMenuItem
            // 
            this.redoToolStripMenuItem.Name = "redoToolStripMenuItem";
            this.redoToolStripMenuItem.Size = new System.Drawing.Size(128, 26);
            this.redoToolStripMenuItem.Text = "&Redo";
            this.redoToolStripMenuItem.Click += new System.EventHandler(this.redoToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DM_Caro_.Properties.Resources.images;
            this.pictureBox1.Location = new System.Drawing.Point(12, 65);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(178, 180);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // btnThoat
            // 
            this.btnThoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThoat.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnThoat.Location = new System.Drawing.Point(12, 503);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(65, 62);
            this.btnThoat.TabIndex = 3;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            // 
            // btnPvsP
            // 
            this.btnPvsP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPvsP.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnPvsP.Location = new System.Drawing.Point(12, 443);
            this.btnPvsP.Name = "btnPvsP";
            this.btnPvsP.Size = new System.Drawing.Size(92, 61);
            this.btnPvsP.TabIndex = 3;
            this.btnPvsP.Text = "Player vs player";
            this.btnPvsP.UseVisualStyleBackColor = true;
            // 
            // btnChoiMoi
            // 
            this.btnChoiMoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChoiMoi.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnChoiMoi.Location = new System.Drawing.Point(70, 503);
            this.btnChoiMoi.Name = "btnChoiMoi";
            this.btnChoiMoi.Size = new System.Drawing.Size(120, 62);
            this.btnChoiMoi.TabIndex = 3;
            this.btnChoiMoi.Text = "Chơi mới";
            this.btnChoiMoi.UseVisualStyleBackColor = true;
            // 
            // pnlBanCo
            // 
            this.pnlBanCo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(50)))), ((int)(((byte)(120)))));
            this.pnlBanCo.Location = new System.Drawing.Point(196, 65);
            this.pnlBanCo.Name = "pnlBanCo";
            this.pnlBanCo.Size = new System.Drawing.Size(501, 501);
            this.pnlBanCo.TabIndex = 4;
            this.pnlBanCo.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlBanCo_Paint);
            this.pnlBanCo.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pnlBanCo_MouseClick);
            this.pnlBanCo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlBanCo_MouseMove);
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button2.Location = new System.Drawing.Point(686, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(27, 32);
            this.button2.TabIndex = 8;
            this.button2.Text = "x";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // tmChayChu
            // 
            this.tmChayChu.Tick += new System.EventHandler(this.tmChayChu_Tick);
            // 
            // pnlChu
            // 
            this.pnlChu.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlChu.Controls.Add(this.lblChuoi);
            this.pnlChu.Location = new System.Drawing.Point(13, 251);
            this.pnlChu.Name = "pnlChu";
            this.pnlChu.Size = new System.Drawing.Size(177, 186);
            this.pnlChu.TabIndex = 5;
            // 
            // lblChuoi
            // 
            this.lblChuoi.AutoSize = true;
            this.lblChuoi.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblChuoi.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblChuoi.Location = new System.Drawing.Point(6, 191);
            this.lblChuoi.Name = "lblChuoi";
            this.lblChuoi.Size = new System.Drawing.Size(0, 20);
            this.lblChuoi.TabIndex = 1;
            // 
            // lblX_Y
            // 
            this.lblX_Y.AutoSize = true;
            this.lblX_Y.Location = new System.Drawing.Point(600, 571);
            this.lblX_Y.Name = "lblX_Y";
            this.lblX_Y.Size = new System.Drawing.Size(32, 19);
            this.lblX_Y.TabIndex = 6;
            this.lblX_Y.Text = "0, 0";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(12, 571);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(46, 19);
            this.lblStatus.TabIndex = 7;
            this.lblStatus.Text = "Ready";
            // 
            // pnlNut
            // 
            this.pnlNut.BackColor = System.Drawing.Color.Black;
            this.pnlNut.Controls.Add(this.btnNut1);
            this.pnlNut.Location = new System.Drawing.Point(-10, 354);
            this.pnlNut.Name = "pnlNut";
            this.pnlNut.Size = new System.Drawing.Size(723, 268);
            this.pnlNut.TabIndex = 0;
            // 
            // btnNut1
            // 
            this.btnNut1.BackColor = System.Drawing.Color.Black;
            this.btnNut1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnNut1.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnNut1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnNut1.Location = new System.Drawing.Point(14, 9);
            this.btnNut1.Name = "btnNut1";
            this.btnNut1.Size = new System.Drawing.Size(709, 235);
            this.btnNut1.TabIndex = 0;
            this.btnNut1.Text = "Player VS Player";
            this.btnNut1.UseVisualStyleBackColor = false;
            this.btnNut1.Click += new System.EventHandler(this.btnNut1_Click);
            // 
            // ptbPic
            // 
            this.ptbPic.BackgroundImage = global::DM_Caro_.Properties.Resources.game2;
            this.ptbPic.Location = new System.Drawing.Point(28, 38);
            this.ptbPic.Name = "ptbPic";
            this.ptbPic.Size = new System.Drawing.Size(627, 295);
            this.ptbPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbPic.TabIndex = 0;
            this.ptbPic.TabStop = false;
            // 
            // pnlHinh
            // 
            this.pnlHinh.BackColor = System.Drawing.Color.Black;
            this.pnlHinh.Controls.Add(this.ptbPic);
            this.pnlHinh.Location = new System.Drawing.Point(0, 62);
            this.pnlHinh.Name = "pnlHinh";
            this.pnlHinh.Size = new System.Drawing.Size(713, 295);
            this.pnlHinh.TabIndex = 0;
            // 
            // btnMini
            // 
            this.btnMini.FlatAppearance.BorderSize = 0;
            this.btnMini.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMini.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.btnMini.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnMini.Location = new System.Drawing.Point(654, 3);
            this.btnMini.Name = "btnMini";
            this.btnMini.Size = new System.Drawing.Size(27, 32);
            this.btnMini.TabIndex = 8;
            this.btnMini.Text = "-";
            this.btnMini.UseVisualStyleBackColor = true;
            this.btnMini.Click += new System.EventHandler(this.btnMini_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(-1, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 28);
            this.label1.TabIndex = 9;
            this.label1.Text = "Caro Version 1.00 BETA";
            // 
            // frmCaRo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(717, 617);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnMini);
            this.Controls.Add(this.pnlHinh);
            this.Controls.Add(this.pnlNut);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblX_Y);
            this.Controls.Add(this.pnlChu);
            this.Controls.Add(this.pnlBanCo);
            this.Controls.Add(this.btnChoiMoi);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnPvsP);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "frmCaRo";
            this.Text = "Caro ver 1.00";
            this.Load += new System.EventHandler(this.frmCaRo_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmCaRo_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmCaro_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.frmCaro_MouseUp);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlChu.ResumeLayout(false);
            this.pnlChu.PerformLayout();
            this.pnlNut.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ptbPic)).EndInit();
            this.pnlHinh.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem playerVsPlayerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem redoToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnPvsP;
        private System.Windows.Forms.Button btnChoiMoi;
        private System.Windows.Forms.Panel pnlBanCo;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Timer tmChayChu;
        private System.Windows.Forms.Panel pnlChu;
        private System.Windows.Forms.Label lblChuoi;
        private System.Windows.Forms.Label lblX_Y;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Panel pnlNut;
        private System.Windows.Forms.Button btnNut1;
        private System.Windows.Forms.PictureBox ptbPic;
        private System.Windows.Forms.Panel pnlHinh;
        private System.Windows.Forms.Button btnMini;
        private System.Windows.Forms.Label label1;


    }
}

