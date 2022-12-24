namespace QL_Diem_BTL
{
    partial class frm_Nhapdiem
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_huy = new System.Windows.Forms.Button();
            this.lb_dshocky = new System.Windows.Forms.Label();
            this.cbb_dshocky = new System.Windows.Forms.ComboBox();
            this.txt_tenmon = new System.Windows.Forms.TextBox();
            this.lb_tenmon = new System.Windows.Forms.Label();
            this.txt_mamon = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbb_dsmon = new System.Windows.Forms.ComboBox();
            this.btn_Delete_hocky = new System.Windows.Forms.Button();
            this.btn_Save_hocky = new System.Windows.Forms.Button();
            this.btn_Add_hocky = new System.Windows.Forms.Button();
            this.txt_tenhocky = new System.Windows.Forms.TextBox();
            this.lb_tenhocky = new System.Windows.Forms.Label();
            this.txt_mahocky = new System.Windows.Forms.TextBox();
            this.lb_mahocky = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lb_Makhoa = new System.Windows.Forms.Label();
            this.lb_dskhoa = new System.Windows.Forms.Label();
            this.cbb_dskhoa = new System.Windows.Forms.ComboBox();
            this.bl_dslop = new System.Windows.Forms.Label();
            this.cbb_dslop = new System.Windows.Forms.ComboBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.dgv_datanhapđiem = new System.Windows.Forms.DataGridView();
            this.btn_capnhatdulieu = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_datanhapđiem)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(826, 59);
            this.label1.TabIndex = 0;
            this.label1.Text = "NHẬP ĐIỂM";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_huy);
            this.groupBox2.Controls.Add(this.lb_dshocky);
            this.groupBox2.Controls.Add(this.cbb_dshocky);
            this.groupBox2.Controls.Add(this.txt_tenmon);
            this.groupBox2.Controls.Add(this.lb_tenmon);
            this.groupBox2.Controls.Add(this.txt_mamon);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.cbb_dsmon);
            this.groupBox2.Controls.Add(this.btn_Delete_hocky);
            this.groupBox2.Controls.Add(this.btn_Save_hocky);
            this.groupBox2.Controls.Add(this.btn_Add_hocky);
            this.groupBox2.Controls.Add(this.txt_tenhocky);
            this.groupBox2.Controls.Add(this.lb_tenhocky);
            this.groupBox2.Controls.Add(this.txt_mahocky);
            this.groupBox2.Controls.Add(this.lb_mahocky);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Location = new System.Drawing.Point(5, 98);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(816, 143);
            this.groupBox2.TabIndex = 38;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chọn Khoa, lớp, học kỳ, môn";
            // 
            // btn_huy
            // 
            this.btn_huy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_huy.Enabled = false;
            this.btn_huy.Location = new System.Drawing.Point(744, 97);
            this.btn_huy.Name = "btn_huy";
            this.btn_huy.Size = new System.Drawing.Size(56, 25);
            this.btn_huy.TabIndex = 41;
            this.btn_huy.Text = "Hủy";
            this.btn_huy.UseVisualStyleBackColor = true;
            // 
            // lb_dshocky
            // 
            this.lb_dshocky.Location = new System.Drawing.Point(221, 13);
            this.lb_dshocky.Name = "lb_dshocky";
            this.lb_dshocky.Size = new System.Drawing.Size(98, 21);
            this.lb_dshocky.TabIndex = 40;
            this.lb_dshocky.Text = "Danh sách học kỳ:";
            this.lb_dshocky.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbb_dshocky
            // 
            this.cbb_dshocky.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_dshocky.FormattingEnabled = true;
            this.cbb_dshocky.Location = new System.Drawing.Point(224, 37);
            this.cbb_dshocky.Name = "cbb_dshocky";
            this.cbb_dshocky.Size = new System.Drawing.Size(151, 21);
            this.cbb_dshocky.TabIndex = 39;
            this.cbb_dshocky.SelectedIndexChanged += new System.EventHandler(this.cbb_dshocky_SelectedIndexChanged);
            // 
            // txt_tenmon
            // 
            this.txt_tenmon.Enabled = false;
            this.txt_tenmon.Location = new System.Drawing.Point(528, 103);
            this.txt_tenmon.Name = "txt_tenmon";
            this.txt_tenmon.Size = new System.Drawing.Size(136, 20);
            this.txt_tenmon.TabIndex = 38;
            // 
            // lb_tenmon
            // 
            this.lb_tenmon.Location = new System.Drawing.Point(525, 75);
            this.lb_tenmon.Name = "lb_tenmon";
            this.lb_tenmon.Size = new System.Drawing.Size(75, 23);
            this.lb_tenmon.TabIndex = 37;
            this.lb_tenmon.Text = "Tên môn:";
            this.lb_tenmon.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_mamon
            // 
            this.txt_mamon.Enabled = false;
            this.txt_mamon.Location = new System.Drawing.Point(397, 103);
            this.txt_mamon.Name = "txt_mamon";
            this.txt_mamon.Size = new System.Drawing.Size(110, 20);
            this.txt_mamon.TabIndex = 36;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(394, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 23);
            this.label4.TabIndex = 35;
            this.label4.Text = "Mã môn:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(221, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 21);
            this.label2.TabIndex = 34;
            this.label2.Text = "Danh sách môn:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbb_dsmon
            // 
            this.cbb_dsmon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_dsmon.FormattingEnabled = true;
            this.cbb_dsmon.Location = new System.Drawing.Point(224, 102);
            this.cbb_dsmon.Name = "cbb_dsmon";
            this.cbb_dsmon.Size = new System.Drawing.Size(151, 21);
            this.cbb_dsmon.TabIndex = 33;
            this.cbb_dsmon.SelectedIndexChanged += new System.EventHandler(this.cbb_dsmon_SelectedIndexChanged);
            // 
            // btn_Delete_hocky
            // 
            this.btn_Delete_hocky.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Delete_hocky.Enabled = false;
            this.btn_Delete_hocky.Location = new System.Drawing.Point(686, 97);
            this.btn_Delete_hocky.Name = "btn_Delete_hocky";
            this.btn_Delete_hocky.Size = new System.Drawing.Size(56, 25);
            this.btn_Delete_hocky.TabIndex = 32;
            this.btn_Delete_hocky.Text = "Xóa";
            this.btn_Delete_hocky.UseVisualStyleBackColor = true;
            this.btn_Delete_hocky.Click += new System.EventHandler(this.btn_Delete_hocky_Click);
            // 
            // btn_Save_hocky
            // 
            this.btn_Save_hocky.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Save_hocky.Enabled = false;
            this.btn_Save_hocky.Location = new System.Drawing.Point(686, 66);
            this.btn_Save_hocky.Name = "btn_Save_hocky";
            this.btn_Save_hocky.Size = new System.Drawing.Size(114, 25);
            this.btn_Save_hocky.TabIndex = 31;
            this.btn_Save_hocky.Text = "Lưu ";
            this.btn_Save_hocky.UseVisualStyleBackColor = true;
            this.btn_Save_hocky.Click += new System.EventHandler(this.btn_Save_hocky_Click);
            // 
            // btn_Add_hocky
            // 
            this.btn_Add_hocky.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Add_hocky.Enabled = false;
            this.btn_Add_hocky.Location = new System.Drawing.Point(686, 35);
            this.btn_Add_hocky.Name = "btn_Add_hocky";
            this.btn_Add_hocky.Size = new System.Drawing.Size(114, 25);
            this.btn_Add_hocky.TabIndex = 30;
            this.btn_Add_hocky.Text = "Thêm mới";
            this.btn_Add_hocky.UseVisualStyleBackColor = true;
            this.btn_Add_hocky.Click += new System.EventHandler(this.btn_Add_hocky_Click);
            // 
            // txt_tenhocky
            // 
            this.txt_tenhocky.Enabled = false;
            this.txt_tenhocky.Location = new System.Drawing.Point(528, 38);
            this.txt_tenhocky.Name = "txt_tenhocky";
            this.txt_tenhocky.Size = new System.Drawing.Size(136, 20);
            this.txt_tenhocky.TabIndex = 29;
            // 
            // lb_tenhocky
            // 
            this.lb_tenhocky.Location = new System.Drawing.Point(525, 10);
            this.lb_tenhocky.Name = "lb_tenhocky";
            this.lb_tenhocky.Size = new System.Drawing.Size(75, 23);
            this.lb_tenhocky.TabIndex = 28;
            this.lb_tenhocky.Text = "Tên học kỳ:";
            this.lb_tenhocky.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_mahocky
            // 
            this.txt_mahocky.Enabled = false;
            this.txt_mahocky.Location = new System.Drawing.Point(397, 38);
            this.txt_mahocky.Name = "txt_mahocky";
            this.txt_mahocky.Size = new System.Drawing.Size(110, 20);
            this.txt_mahocky.TabIndex = 27;
            // 
            // lb_mahocky
            // 
            this.lb_mahocky.Location = new System.Drawing.Point(394, 11);
            this.lb_mahocky.Name = "lb_mahocky";
            this.lb_mahocky.Size = new System.Drawing.Size(75, 23);
            this.lb_mahocky.TabIndex = 26;
            this.lb_mahocky.Text = "Mã học kỳ:";
            this.lb_mahocky.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lb_Makhoa);
            this.groupBox3.Controls.Add(this.lb_dskhoa);
            this.groupBox3.Controls.Add(this.cbb_dskhoa);
            this.groupBox3.Controls.Add(this.bl_dslop);
            this.groupBox3.Controls.Add(this.cbb_dslop);
            this.groupBox3.Location = new System.Drawing.Point(7, 14);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(182, 126);
            this.groupBox3.TabIndex = 25;
            this.groupBox3.TabStop = false;
            // 
            // lb_Makhoa
            // 
            this.lb_Makhoa.Enabled = false;
            this.lb_Makhoa.Location = new System.Drawing.Point(94, 11);
            this.lb_Makhoa.Name = "lb_Makhoa";
            this.lb_Makhoa.Size = new System.Drawing.Size(65, 20);
            this.lb_Makhoa.TabIndex = 23;
            this.lb_Makhoa.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_dskhoa
            // 
            this.lb_dskhoa.Location = new System.Drawing.Point(7, 10);
            this.lb_dskhoa.Name = "lb_dskhoa";
            this.lb_dskhoa.Size = new System.Drawing.Size(91, 21);
            this.lb_dskhoa.TabIndex = 21;
            this.lb_dskhoa.Text = "Danh sách khoa:";
            this.lb_dskhoa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbb_dskhoa
            // 
            this.cbb_dskhoa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_dskhoa.FormattingEnabled = true;
            this.cbb_dskhoa.Items.AddRange(new object[] {
            "   "});
            this.cbb_dskhoa.Location = new System.Drawing.Point(10, 34);
            this.cbb_dskhoa.Name = "cbb_dskhoa";
            this.cbb_dskhoa.Size = new System.Drawing.Size(159, 21);
            this.cbb_dskhoa.TabIndex = 22;
            this.cbb_dskhoa.SelectionChangeCommitted += new System.EventHandler(this.cbb_dskhoa_SelectionChangeCommitted);
            // 
            // bl_dslop
            // 
            this.bl_dslop.Location = new System.Drawing.Point(6, 67);
            this.bl_dslop.Name = "bl_dslop";
            this.bl_dslop.Size = new System.Drawing.Size(84, 21);
            this.bl_dslop.TabIndex = 23;
            this.bl_dslop.Text = "Danh sách lớp:";
            this.bl_dslop.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbb_dslop
            // 
            this.cbb_dslop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_dslop.FormattingEnabled = true;
            this.cbb_dslop.Location = new System.Drawing.Point(9, 92);
            this.cbb_dslop.Name = "cbb_dslop";
            this.cbb_dslop.Size = new System.Drawing.Size(160, 21);
            this.cbb_dslop.TabIndex = 24;
            this.cbb_dslop.SelectedIndexChanged += new System.EventHandler(this.cbb_dslop_SelectedIndexChanged);
            this.cbb_dslop.SelectionChangeCommitted += new System.EventHandler(this.cbb_dslop_SelectionChangeCommitted);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.dgv_datanhapđiem);
            this.groupBox5.Location = new System.Drawing.Point(5, 267);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(816, 315);
            this.groupBox5.TabIndex = 39;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Danh sách điểm";
            // 
            // dgv_datanhapđiem
            // 
            this.dgv_datanhapđiem.AllowUserToAddRows = false;
            this.dgv_datanhapđiem.AllowUserToDeleteRows = false;
            this.dgv_datanhapđiem.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_datanhapđiem.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgv_datanhapđiem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_datanhapđiem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_datanhapđiem.Location = new System.Drawing.Point(3, 16);
            this.dgv_datanhapđiem.Name = "dgv_datanhapđiem";
            this.dgv_datanhapđiem.Size = new System.Drawing.Size(810, 296);
            this.dgv_datanhapđiem.TabIndex = 34;
            this.dgv_datanhapđiem.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_datanhapđiem_CellEndEdit);
            // 
            // btn_capnhatdulieu
            // 
            this.btn_capnhatdulieu.Location = new System.Drawing.Point(691, 243);
            this.btn_capnhatdulieu.Name = "btn_capnhatdulieu";
            this.btn_capnhatdulieu.Size = new System.Drawing.Size(114, 27);
            this.btn_capnhatdulieu.TabIndex = 40;
            this.btn_capnhatdulieu.Text = "Cập nhật dữ liệu";
            this.btn_capnhatdulieu.UseVisualStyleBackColor = true;
            this.btn_capnhatdulieu.Click += new System.EventHandler(this.btn_capnhatdulieu_Click);
            // 
            // frm_Nhapdiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(826, 585);
            this.Controls.Add(this.btn_capnhatdulieu);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frm_Nhapdiem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Nhập điểm";
            this.Load += new System.EventHandler(this.frm_Nhapdiem_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_datanhapđiem)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_Delete_hocky;
        private System.Windows.Forms.Button btn_Save_hocky;
        private System.Windows.Forms.Button btn_Add_hocky;
        private System.Windows.Forms.TextBox txt_tenhocky;
        private System.Windows.Forms.Label lb_tenhocky;
        private System.Windows.Forms.TextBox txt_mahocky;
        private System.Windows.Forms.Label lb_mahocky;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lb_Makhoa;
        private System.Windows.Forms.Label lb_dskhoa;
        private System.Windows.Forms.ComboBox cbb_dskhoa;
        private System.Windows.Forms.ComboBox cbb_dslop;
        private System.Windows.Forms.Label bl_dslop;
        private System.Windows.Forms.Label lb_dshocky;
        private System.Windows.Forms.ComboBox cbb_dshocky;
        private System.Windows.Forms.TextBox txt_tenmon;
        private System.Windows.Forms.Label lb_tenmon;
        private System.Windows.Forms.TextBox txt_mamon;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbb_dsmon;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.DataGridView dgv_datanhapđiem;
        private System.Windows.Forms.Button btn_huy;
        private System.Windows.Forms.Button btn_capnhatdulieu;
    }
}