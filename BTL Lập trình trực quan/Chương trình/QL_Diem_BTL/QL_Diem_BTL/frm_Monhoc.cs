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
    public partial class frm_Monhoc : Form
    {
        public frm_Monhoc()
        {
            InitializeComponent();
        }

        Database_QLDDataContext dt = new Database_QLDDataContext();
        private void frm_Monhoc_Load(object sender, EventArgs e)
        {
            dgv_Monhoc.DataSource = dt.SelectAll_MonHoc();
            cbb_mahocky.DataSource = dt.SelectAll_Hocky();
            cbb_mahocky.DisplayMember = "MaHK";
            cbb_mahocky.ValueMember = "MaHK";
            dgv_Monhoc.Columns["MaMH"].HeaderText = "Mã môn học";
            dgv_Monhoc.Columns["TenMH"].HeaderText = "Tên môn học";
            dgv_Monhoc.Columns["SoTinChi"].HeaderText = "Số tín chỉ";
            dgv_Monhoc.Columns["SoTiet"].HeaderText = "Số tiết";

        }

        private void dgv_Monhoc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_Mamonhoc.DataBindings.Clear();
            txt_Mamonhoc.DataBindings.Add("Text", dgv_Monhoc.DataSource, "MaMH");
            txt_Tenmonhoc.DataBindings.Clear();
            txt_Tenmonhoc.DataBindings.Add("Text", dgv_Monhoc.DataSource, "TenMH");
            nud_Sotinchi.DataBindings.Clear();
            nud_Sotinchi.DataBindings.Add("Text", dgv_Monhoc.DataSource, "SoTinChi");
            nud_Sotiet.DataBindings.Clear();
            nud_Sotiet.DataBindings.Add("Text", dgv_Monhoc.DataSource, "SoTiet");
            btn_sua_monhoc.Enabled = true;
            btn_delete_monhoc.Enabled = true;
        }

        Boolean addmonhoc = false;
        private void btn_add_monhoc_Click(object sender, EventArgs e)
        {
            txt_Mamonhoc.Text = "";
            txt_Tenmonhoc.Text = "";
            nud_Sotinchi.Value = 0;
            nud_Sotiet.Value = 0;
            txt_Mamonhoc.Enabled = true;
            txt_Tenmonhoc.Enabled = true;
            nud_Sotinchi.Enabled = true;
            nud_Sotiet.Enabled = true;
            txt_Mamonhoc.Focus();
            addmonhoc = true;
            btn_save_monhoc.Enabled = true;
            btn_Huy_monhoc.Enabled = true;
            btn_delete_monhoc.Enabled = false;
            btn_add_monhoc.Enabled = false;
            btn_sua_monhoc.Enabled = false;
            
        }

        private void btn_sua_monhoc_Click(object sender, EventArgs e)
        {
            txt_Tenmonhoc.Enabled = true;
            nud_Sotinchi.Enabled = true;
            nud_Sotiet.Enabled = true;
            btn_add_monhoc.Enabled = false;
            btn_delete_monhoc.Enabled = false;
            btn_sua_monhoc.Enabled = false;
            btn_Huy_monhoc.Enabled = true;
            btn_save_monhoc.Enabled = true;
        }

        private void btn_Huy_monhoc_Click(object sender, EventArgs e)
        {
            DialogResult dlr = MessageBox.Show("Bạn có chắc chắn muốn hủy không?", "Thông báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlr == DialogResult.Yes)
            {
                txt_Mamonhoc.Text = "";
                txt_Tenmonhoc.Text = "";
                nud_Sotinchi.Value= 0;
                nud_Sotiet.Value= 0;
                nud_Sotinchi.Enabled = false;
                nud_Sotiet.Enabled = false;
                txt_Tenmonhoc.Enabled = false;
                txt_Mamonhoc.Enabled = false;
                btn_add_monhoc.Enabled = true;
                btn_delete_monhoc.Enabled = false;
                btn_sua_monhoc.Enabled = false;
                btn_Huy_monhoc.Enabled = false;
                btn_save_monhoc.Enabled = false;
            }
            frm_Monhoc_Load(sender, e);
        }

        private void btn_delete_monhoc_Click(object sender, EventArgs e)
        {
            DialogResult dlr = MessageBox.Show("Bạn có chắc chắn muốn xóa môn " + txt_Tenmonhoc.Text + " không?", "Thông báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlr == DialogResult.Yes)
            {
                dt.Delete_MonHoc(txt_Mamonhoc.Text);
                MessageBox.Show("Đã xóa " + txt_Tenmonhoc.Text + " thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                frm_Monhoc_Load(sender, e);
                txt_Mamonhoc.Text = "";
                txt_Tenmonhoc.Text = "";
                nud_Sotinchi.Value = 0;
                nud_Sotiet.Value= 0;
                btn_delete_monhoc.Enabled = false;
                btn_sua_monhoc.Enabled = false;
            }
        }

        private void btn_save_monhoc_Click_1(object sender, EventArgs e)
        {
            if (addmonhoc)
            {
                dt.Insert_MonHoc(txt_Mamonhoc.Text, txt_Tenmonhoc.Text, nud_Sotinchi.Value, nud_Sotiet.Value, cbb_mahocky.Text);
                txt_Mamonhoc.Enabled = false;
                txt_Tenmonhoc.Enabled = false;
                nud_Sotinchi.Enabled = false;
                nud_Sotiet.Enabled = false;
                nud_Sotinchi.Value = 0;
                nud_Sotiet.Value = 0;
                btn_add_monhoc.Enabled = true;
                btn_delete_monhoc.Enabled = false;
                btn_sua_monhoc.Enabled = false;
                btn_Huy_monhoc.Enabled = false;
                btn_save_monhoc.Enabled = false;
                addmonhoc = false;
            }
            else
            {
                dt.Update_MonHoc(txt_Mamonhoc.Text, txt_Tenmonhoc.Text, nud_Sotinchi.Value, nud_Sotiet.Value);
                txt_Tenmonhoc.Enabled = false;
                nud_Sotinchi.Enabled = false;
                nud_Sotiet.Enabled = false;
                btn_sua_monhoc.Enabled = false;
                btn_delete_monhoc.Enabled = false;
                btn_add_monhoc.Enabled = true;
                btn_Huy_monhoc.Enabled = false;
                btn_save_monhoc.Enabled = false;
            }
            frm_Monhoc_Load(sender, e);
            MessageBox.Show("Đã lưu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void txt_timkiemmonhoc_KeyUp(object sender, KeyEventArgs e)
        {
            var Lst = (from s in dt.SelectAll_MonHoc() where s.TenMH.Contains(txt_timkiemmonhoc.Text) select s).ToList();
            dgv_Monhoc.DataSource = Lst;
            txt_Mamonhoc.DataBindings.Clear();
            txt_Mamonhoc.DataBindings.Add("Text", dgv_Monhoc.DataSource, "MaMH");
            txt_Tenmonhoc.DataBindings.Clear();
            txt_Tenmonhoc.DataBindings.Add("Text", dgv_Monhoc.DataSource, "TenMH");
            nud_Sotinchi.DataBindings.Clear();
            nud_Sotinchi.DataBindings.Add("Text", dgv_Monhoc.DataSource, "SoTinChi");
            nud_Sotiet.DataBindings.Clear();
            nud_Sotiet.DataBindings.Add("Text", dgv_Monhoc.DataSource, "SoTiet");
        }
    }
}