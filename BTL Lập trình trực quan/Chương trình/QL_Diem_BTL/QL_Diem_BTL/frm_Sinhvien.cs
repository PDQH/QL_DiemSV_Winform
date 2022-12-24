using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_Diem_BTL
{
    public partial class frm_Sinhvien : Form
    {
        public frm_Sinhvien()
        {
            InitializeComponent();
        }
        Database_QLDDataContext dt = new Database_QLDDataContext();

        private void frm_Sinhvien_Load(object sender, EventArgs e)
        {
            cbb_dskhoa.DisplayMember = "TenKhoa";
            cbb_dskhoa.ValueMember = "MaKhoa";
            cbb_dskhoa.DataSource = dt.SelectAll_Khoa();
            lb_Makhoa.DataBindings.Clear();
            lb_Makhoa.DataBindings.Add("Text", cbb_dskhoa.DataSource, "MaKhoa");
        }
        //Chọn Khoa và Lớp
        Boolean addLop = false;
        private void btn_Add_lop_Click_1(object sender, EventArgs e)
        {
            txt_malop.Text = "";
            txt_tenlop.Text = "";
            txt_malop.Enabled = true;
            txt_tenlop.Enabled = true;
            btn_Save_lop.Enabled = true;
            btn_Delete_lop.Enabled = false;
            btn_Add_lop.Enabled = false;
            btn_huylop.Enabled = true;
            txt_malop.Focus();
            addLop = true;
        }
        private void btn_Save_lop_Click_1(object sender, EventArgs e)
        {
            if (addLop)
            {
                dt.Insert_Lop(txt_malop.Text, txt_tenlop.Text, lb_Makhoa.Text);
                txt_malop.Enabled = false;
                txt_tenlop.Enabled = false;
                btn_Save_lop.Enabled = false;
                addLop = false;
                cbb_dskhoa_SelectionChangeCommitted(sender, e);
                MessageBox.Show("Đã lưu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                dt.Update_Lop(txt_malop.Text, txt_tenlop.Text, lb_Makhoa.Text);
                cbb_dskhoa_SelectionChangeCommitted(sender, e);
            }
        }

        private void btn_Delete_lop_Click_1(object sender, EventArgs e)
        {
            DialogResult dlr = MessageBox.Show("Bạn có chắc chắn muốn xóa lớp " + txt_tenlop.Text + " không?", "Thông báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlr == DialogResult.Yes)
            {
                dt.Delete_Lop(cbb_dslop.SelectedValue.ToString());
                txt_tenlop.Enabled = false;
                MessageBox.Show("Đã xóa " + txt_tenlop.Text + " thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                cbb_dskhoa_SelectionChangeCommitted(sender, e);
            }
        }

        private void btn_huylop_Click(object sender, EventArgs e)
        {
            DialogResult dlr = MessageBox.Show("Bạn có chắc chắn muốn hủy không?", "Thông báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlr == DialogResult.Yes)
            {
                cbb_dslop.DisplayMember = "TenLop";
                cbb_dslop.ValueMember = "MaLop";
                cbb_dslop.DataSource = dt.SelectAll_Lop(lb_Makhoa.Text);
                txt_malop.DataBindings.Clear();
                txt_malop.DataBindings.Add("Text", cbb_dslop.DataSource, "MaLop");
                txt_tenlop.DataBindings.Clear();
                txt_tenlop.DataBindings.Add("Text", cbb_dslop.DataSource, "TenLop");
                txt_tenlop.Enabled = false;
                txt_malop.Enabled = false;
                btn_Add_lop.Enabled = true;
                btn_huylop.Enabled = false;
                btn_Save_lop.Enabled = false;
                btn_Delete_lop.Enabled = true;

            }
        }

        private void cbb_dslop_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            dgv_datasinhvien.DataSource = dt.SinhVien_SelectMaLop(txt_malop.Text);
            txt_masv.DataBindings.Clear();
            txt_masv.DataBindings.Add("Text", dgv_datasinhvien.DataSource, "MaSV");
            txt_hovaten.DataBindings.Clear();
            txt_hovaten.DataBindings.Add("Text", dgv_datasinhvien.DataSource, "Hovaten");
            dtp_ngaysinhsv.DataBindings.Clear();
            dtp_ngaysinhsv.DataBindings.Add("Text", dgv_datasinhvien.DataSource, "NgaySinh");
            cbb_gioitinh.DataBindings.Clear();
            cbb_gioitinh.DataBindings.Add("Text", dgv_datasinhvien.DataSource, "GioiTinh");
            txt_noisinh.DataBindings.Clear();
            txt_noisinh.DataBindings.Add("Text", dgv_datasinhvien.DataSource, "NoiSinh");
            txt_quequan.DataBindings.Clear();
            txt_quequan.DataBindings.Add("Text", dgv_datasinhvien.DataSource, "QueQuan");
            txt_dantoc.DataBindings.Clear();
            txt_dantoc.DataBindings.Add("Text", dgv_datasinhvien.DataSource, "DanToc");
            txt_SDT.DataBindings.Clear();
            txt_SDT.DataBindings.Add("Text", dgv_datasinhvien.DataSource, "SDT");
            txt_ghichu.DataBindings.Clear();
            txt_ghichu.DataBindings.Add("Text", dgv_datasinhvien.DataSource, "GhiChu");
        }

        private void cbb_dskhoa_SelectionChangeCommitted(object sender, EventArgs e)
        {
            btn_Add_lop.Enabled = true;
            btn_Delete_lop.Enabled = true;
            cbb_dslop.DisplayMember = "TenLop";
            cbb_dslop.ValueMember = "MaLop";
            cbb_dslop.DataSource = dt.SelectAll_Lop(lb_Makhoa.Text);
            txt_malop.DataBindings.Clear();
            txt_malop.DataBindings.Add("Text", cbb_dslop.DataSource, "MaLop");
            txt_tenlop.DataBindings.Clear();
            txt_tenlop.DataBindings.Add("Text", cbb_dslop.DataSource, "TenLop");
        }

        //Thông tin sinh viên
        Boolean addSV = false;
        private void btn_Add_sv_Click(object sender, EventArgs e)
        {
            txt_masv.Text = "";
            txt_hovaten.Text = "";
            dtp_ngaysinhsv.Text = "1/1/1900";
            txt_dantoc.Text = "";
            txt_noisinh.Text = "";
            txt_quequan.Text = "";
            cbb_gioitinh.Text = "";
            txt_SDT.Text = "";
            txt_ghichu.Text = "";
            txt_masv.Enabled= true;
            txt_masv.Focus();
            addSV = true;
            btn_Save_sv.Enabled = true;
            btn_delete_sv.Enabled = false;
            btn_huy_sinhvien.Enabled = true;
        }

        private void btn_Save_sv_Click(object sender, EventArgs e)
        {
            if(addSV)
            {
                dt.Insert_Sinhvien(txt_masv.Text, txt_hovaten.Text, dtp_ngaysinhsv.Value, cbb_gioitinh.Text, txt_noisinh.Text, txt_quequan.Text, txt_dantoc.Text, txt_SDT.Text, txt_malop.Text, txt_ghichu.Text);
                addSV = false;
                txt_masv.Enabled = false;
                cbb_dslop_SelectedIndexChanged_1(sender, e);
                MessageBox.Show("Đã lưu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                dt.Update_Sinhvien(txt_masv.Text, txt_hovaten.Text, dtp_ngaysinhsv.Value, cbb_gioitinh.Text, txt_noisinh.Text, txt_quequan.Text, txt_dantoc.Text, txt_SDT.Text, txt_ghichu.Text);
                cbb_dslop_SelectedIndexChanged_1(sender, e);
                MessageBox.Show("Đã lưu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void btn_delete_sv_Click(object sender, EventArgs e)
        {
            DialogResult dlr = MessageBox.Show("Bạn có chắc chắn muốn xóa sinh viên " + txt_hovaten.Text + " không?", "Thông báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlr == DialogResult.Yes)
            {
                dt.Delete_Sinhvien(txt_masv.Text);
                btn_delete_sv.Enabled = false;
                MessageBox.Show("Đã xóa sinh viên " + txt_hovaten.Text + " thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                cbb_dslop_SelectedIndexChanged_1(sender, e);
            }
        }

        private void cbb_dslop_SelectionChangeCommitted(object sender, EventArgs e)
        {
            btn_Add_sv.Enabled = true;
            btn_Save_sv.Enabled = true;
            txt_hovaten.Enabled = true;
            dtp_ngaysinhsv.Enabled = true;
            txt_dantoc.Enabled = true;
            txt_noisinh.Enabled = true;
            txt_quequan.Enabled = true;
            cbb_gioitinh.Enabled=true;
            txt_SDT.Enabled=true;
            txt_ghichu.Enabled=true;
            txt_timkiemsv.Enabled=true;
        }

        private void dgv_datasinhvien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            btn_delete_sv.Enabled = true;
        }

        private void btn_huy_sinhvien_Click(object sender, EventArgs e)
        {
            DialogResult dlr = MessageBox.Show("Bạn có chắc chắn muốn hủy không?", "Thông báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlr == DialogResult.Yes)
            {
                txt_masv.Text = "";
                txt_hovaten.Text = "";
                dtp_ngaysinhsv.Text = "1/1/1900";
                txt_dantoc.Text = "";
                txt_noisinh.Text = "";
                txt_quequan.Text = "";
                cbb_gioitinh.Text = "";
                txt_SDT.Text = "";
                txt_ghichu.Text = "";
                txt_masv.Enabled = false;
                btn_huy_sinhvien.Enabled = false;
            }
            cbb_dslop_SelectedIndexChanged_1(sender, e);
        }

        private void txt_timkiemsv_KeyUp(object sender, KeyEventArgs e)
        {
            var Lst = (from s in dt.SinhVien_SelectMaLop(txt_malop.Text) where s.Hovaten.Contains(txt_timkiemsv.Text) select s).ToList();
            dgv_datasinhvien.DataSource = Lst;
            txt_masv.DataBindings.Clear();
            txt_masv.DataBindings.Add("Text", dgv_datasinhvien.DataSource, "MaSV");
            txt_hovaten.DataBindings.Clear();
            txt_hovaten.DataBindings.Add("Text", dgv_datasinhvien.DataSource, "Hovaten");
            dtp_ngaysinhsv.DataBindings.Clear();
            dtp_ngaysinhsv.DataBindings.Add("Text", dgv_datasinhvien.DataSource, "NgaySinh");
            cbb_gioitinh.DataBindings.Clear();
            cbb_gioitinh.DataBindings.Add("Text", dgv_datasinhvien.DataSource, "GioiTinh");
            txt_noisinh.DataBindings.Clear();
            txt_noisinh.DataBindings.Add("Text", dgv_datasinhvien.DataSource, "NoiSinh");
            txt_quequan.DataBindings.Clear();
            txt_quequan.DataBindings.Add("Text", dgv_datasinhvien.DataSource, "QueQuan");
            txt_dantoc.DataBindings.Clear();
            txt_dantoc.DataBindings.Add("Text", dgv_datasinhvien.DataSource, "DanToc");
            txt_SDT.DataBindings.Clear();
            txt_SDT.DataBindings.Add("Text", dgv_datasinhvien.DataSource, "SDT");
            txt_ghichu.DataBindings.Clear();
            txt_ghichu.DataBindings.Add("Text", dgv_datasinhvien.DataSource, "GhiChu");
        }

        
    }
}