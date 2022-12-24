namespace QL_Diem_BTL
{
    partial class frm_Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Main));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menu_Capnhat = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItem_sinhvien = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItem_khoa = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItem_monhoc = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_Nhapdiem = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_Bangdiem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.AliceBlue;
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_Capnhat,
            this.menu_Nhapdiem,
            this.menu_Bangdiem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menu_Capnhat
            // 
            this.menu_Capnhat.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItem_sinhvien,
            this.menuItem_khoa,
            this.menuItem_monhoc});
            this.menu_Capnhat.Name = "menu_Capnhat";
            this.menu_Capnhat.Size = new System.Drawing.Size(67, 20);
            this.menu_Capnhat.Text = "Cập nhật";
            // 
            // menuItem_sinhvien
            // 
            this.menuItem_sinhvien.Name = "menuItem_sinhvien";
            this.menuItem_sinhvien.Size = new System.Drawing.Size(180, 22);
            this.menuItem_sinhvien.Text = "Sinh viên";
            this.menuItem_sinhvien.Click += new System.EventHandler(this.menuItem_sinhvien_Click);
            // 
            // menuItem_khoa
            // 
            this.menuItem_khoa.Name = "menuItem_khoa";
            this.menuItem_khoa.Size = new System.Drawing.Size(180, 22);
            this.menuItem_khoa.Text = "Khoa";
            this.menuItem_khoa.Click += new System.EventHandler(this.menuItem_khoa_Click);
            // 
            // menuItem_monhoc
            // 
            this.menuItem_monhoc.Name = "menuItem_monhoc";
            this.menuItem_monhoc.Size = new System.Drawing.Size(180, 22);
            this.menuItem_monhoc.Text = "Môn Học";
            this.menuItem_monhoc.Click += new System.EventHandler(this.menuItem_monhoc_Click);
            // 
            // menu_Nhapdiem
            // 
            this.menu_Nhapdiem.Name = "menu_Nhapdiem";
            this.menu_Nhapdiem.Size = new System.Drawing.Size(79, 20);
            this.menu_Nhapdiem.Text = "Nhập Điểm";
            this.menu_Nhapdiem.Click += new System.EventHandler(this.menu_Nhapdiem_Click);
            // 
            // menu_Bangdiem
            // 
            this.menu_Bangdiem.Name = "menu_Bangdiem";
            this.menu_Bangdiem.Size = new System.Drawing.Size(76, 20);
            this.menu_Bangdiem.Text = "Bảng điểm";
            this.menu_Bangdiem.Click += new System.EventHandler(this.menu_Bangdiem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::QL_Diem_BTL.Properties.Resources._2022_04_20;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(800, 450);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // frm_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phần mềm Quản lý Điểm ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menu_Capnhat;
        private System.Windows.Forms.ToolStripMenuItem menuItem_sinhvien;
        private System.Windows.Forms.ToolStripMenuItem menuItem_khoa;
        private System.Windows.Forms.ToolStripMenuItem menuItem_monhoc;
        private System.Windows.Forms.ToolStripMenuItem menu_Bangdiem;
        private System.Windows.Forms.ToolStripMenuItem menu_Nhapdiem;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

