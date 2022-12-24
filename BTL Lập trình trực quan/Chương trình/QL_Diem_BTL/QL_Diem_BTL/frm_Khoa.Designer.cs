namespace QL_Diem_BTL
{
    partial class frm_Khoa
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
            this.dgv_dataKhoa = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_tenkhoa = new System.Windows.Forms.TextBox();
            this.lb_tenkhoa = new System.Windows.Forms.Label();
            this.txt_makhoa = new System.Windows.Forms.TextBox();
            this.lb_makhoa = new System.Windows.Forms.Label();
            this.btn_Huy = new System.Windows.Forms.Button();
            this.btn_sua = new System.Windows.Forms.Button();
            this.btn_delete_khoa = new System.Windows.Forms.Button();
            this.btn_save_khoa = new System.Windows.Forms.Button();
            this.btn_add_khoa = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txt_timkiemkhoa = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_dataKhoa)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_dataKhoa
            // 
            this.dgv_dataKhoa.AllowUserToAddRows = false;
            this.dgv_dataKhoa.AllowUserToDeleteRows = false;
            this.dgv_dataKhoa.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_dataKhoa.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgv_dataKhoa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv_dataKhoa.Location = new System.Drawing.Point(6, 19);
            this.dgv_dataKhoa.Name = "dgv_dataKhoa";
            this.dgv_dataKhoa.ReadOnly = true;
            this.dgv_dataKhoa.Size = new System.Drawing.Size(307, 222);
            this.dgv_dataKhoa.TabIndex = 0;
            this.dgv_dataKhoa.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_dataKhoa_CellContentClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txt_tenkhoa);
            this.groupBox2.Controls.Add(this.lb_tenkhoa);
            this.groupBox2.Controls.Add(this.txt_makhoa);
            this.groupBox2.Controls.Add(this.lb_makhoa);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox2.Location = new System.Drawing.Point(8, 194);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(313, 81);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin Khoa";
            // 
            // txt_tenkhoa
            // 
            this.txt_tenkhoa.Enabled = false;
            this.txt_tenkhoa.Location = new System.Drawing.Point(80, 45);
            this.txt_tenkhoa.Name = "txt_tenkhoa";
            this.txt_tenkhoa.Size = new System.Drawing.Size(217, 20);
            this.txt_tenkhoa.TabIndex = 3;
            // 
            // lb_tenkhoa
            // 
            this.lb_tenkhoa.AutoSize = true;
            this.lb_tenkhoa.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lb_tenkhoa.Location = new System.Drawing.Point(21, 48);
            this.lb_tenkhoa.Name = "lb_tenkhoa";
            this.lb_tenkhoa.Size = new System.Drawing.Size(57, 13);
            this.lb_tenkhoa.TabIndex = 2;
            this.lb_tenkhoa.Text = "Tên Khoa:";
            // 
            // txt_makhoa
            // 
            this.txt_makhoa.Enabled = false;
            this.txt_makhoa.Location = new System.Drawing.Point(80, 19);
            this.txt_makhoa.Name = "txt_makhoa";
            this.txt_makhoa.Size = new System.Drawing.Size(217, 20);
            this.txt_makhoa.TabIndex = 1;
            // 
            // lb_makhoa
            // 
            this.lb_makhoa.AutoSize = true;
            this.lb_makhoa.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lb_makhoa.Location = new System.Drawing.Point(21, 22);
            this.lb_makhoa.Name = "lb_makhoa";
            this.lb_makhoa.Size = new System.Drawing.Size(53, 13);
            this.lb_makhoa.TabIndex = 0;
            this.lb_makhoa.Text = "Mã Khoa:";
            // 
            // btn_Huy
            // 
            this.btn_Huy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Huy.Location = new System.Drawing.Point(161, 57);
            this.btn_Huy.Name = "btn_Huy";
            this.btn_Huy.Size = new System.Drawing.Size(88, 28);
            this.btn_Huy.TabIndex = 8;
            this.btn_Huy.Text = "Hủy";
            this.btn_Huy.UseVisualStyleBackColor = true;
            this.btn_Huy.Click += new System.EventHandler(this.btn_Huy_Click);
            // 
            // btn_sua
            // 
            this.btn_sua.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_sua.Enabled = false;
            this.btn_sua.Location = new System.Drawing.Point(115, 14);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(88, 28);
            this.btn_sua.TabIndex = 7;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.UseVisualStyleBackColor = true;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // btn_delete_khoa
            // 
            this.btn_delete_khoa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_delete_khoa.Enabled = false;
            this.btn_delete_khoa.Location = new System.Drawing.Point(209, 14);
            this.btn_delete_khoa.Name = "btn_delete_khoa";
            this.btn_delete_khoa.Size = new System.Drawing.Size(88, 28);
            this.btn_delete_khoa.TabIndex = 6;
            this.btn_delete_khoa.Text = "Xóa";
            this.btn_delete_khoa.UseVisualStyleBackColor = true;
            this.btn_delete_khoa.Click += new System.EventHandler(this.btn_delete_khoa_Click_1);
            // 
            // btn_save_khoa
            // 
            this.btn_save_khoa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_save_khoa.Location = new System.Drawing.Point(67, 57);
            this.btn_save_khoa.Name = "btn_save_khoa";
            this.btn_save_khoa.Size = new System.Drawing.Size(88, 28);
            this.btn_save_khoa.TabIndex = 5;
            this.btn_save_khoa.Text = "Lưu ";
            this.btn_save_khoa.UseVisualStyleBackColor = true;
            this.btn_save_khoa.Click += new System.EventHandler(this.btn_save_khoa_Click_1);
            // 
            // btn_add_khoa
            // 
            this.btn_add_khoa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_add_khoa.Location = new System.Drawing.Point(21, 14);
            this.btn_add_khoa.Name = "btn_add_khoa";
            this.btn_add_khoa.Size = new System.Drawing.Size(88, 28);
            this.btn_add_khoa.TabIndex = 4;
            this.btn_add_khoa.Text = "Thêm mới";
            this.btn_add_khoa.UseVisualStyleBackColor = true;
            this.btn_add_khoa.Click += new System.EventHandler(this.btn_add_khoa_Click_1);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.dgv_dataKhoa);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox1.Location = new System.Drawing.Point(328, 125);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(319, 249);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách Khoa";
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(653, 66);
            this.label3.TabIndex = 6;
            this.label3.Text = "CẬP NHẬT KHOA";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txt_timkiemkhoa);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(8, 125);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(313, 52);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            // 
            // txt_timkiemkhoa
            // 
            this.txt_timkiemkhoa.Location = new System.Drawing.Point(106, 19);
            this.txt_timkiemkhoa.Name = "txt_timkiemkhoa";
            this.txt_timkiemkhoa.Size = new System.Drawing.Size(191, 20);
            this.txt_timkiemkhoa.TabIndex = 3;
            this.txt_timkiemkhoa.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_timkiemkhoa_KeyUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tìm kiếm khoa:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btn_sua);
            this.groupBox4.Controls.Add(this.btn_add_khoa);
            this.groupBox4.Controls.Add(this.btn_Huy);
            this.groupBox4.Controls.Add(this.btn_save_khoa);
            this.groupBox4.Controls.Add(this.btn_delete_khoa);
            this.groupBox4.Location = new System.Drawing.Point(8, 281);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(313, 93);
            this.groupBox4.TabIndex = 10;
            this.groupBox4.TabStop = false;
            // 
            // frm_Khoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 380);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frm_Khoa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cập nhật Khoa";
            this.Load += new System.EventHandler(this.frm_Khoa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_dataKhoa)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_dataKhoa;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_delete_khoa;
        private System.Windows.Forms.Button btn_save_khoa;
        private System.Windows.Forms.Button btn_add_khoa;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Button btn_Huy;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txt_timkiemkhoa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_tenkhoa;
        private System.Windows.Forms.Label lb_tenkhoa;
        private System.Windows.Forms.TextBox txt_makhoa;
        private System.Windows.Forms.Label lb_makhoa;
    }
}