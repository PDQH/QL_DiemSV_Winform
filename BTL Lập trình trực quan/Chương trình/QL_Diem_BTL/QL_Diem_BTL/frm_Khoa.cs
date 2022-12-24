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
    public partial class frm_Khoa : Form
    {
        public frm_Khoa()
        {
            InitializeComponent();
        }

        Database_QLDDataContext dt = new Database_QLDDataContext();
        private void frm_Khoa_Load(object sender, EventArgs e)
        {
            
            dgv_dataKhoa.DataSource = dt.SelectAll_Khoa();
            btn_Huy.Enabled = false;
            btn_save_khoa.Enabled = false;
            dgv_dataKhoa.Columns["MaKhoa"].HeaderText = "Mã Khoa";
            dgv_dataKhoa.Columns["TenKhoa"].HeaderText = "Tên Khoa";

        }
        Boolean addkhoa = false;
        private void btn_add_khoa_Click_1(object sender, EventArgs e)
        {
            txt_makhoa.Text = "";
            txt_tenkhoa.Text = "";
            txt_makhoa.Enabled = true;
            txt_tenkhoa.Enabled = true;
            txt_makhoa.Focus();
            addkhoa = true;
            btn_save_khoa.Enabled = true;
            btn_Huy.Enabled = true;
            btn_add_khoa.Enabled = false;
            btn_delete_khoa.Enabled=false;
            btn_sua.Enabled = false;
        }
        private void btn_save_khoa_Click_1(object sender, EventArgs e)
        {
            if (addkhoa)
            {
                dt.Insert_Khoa(txt_makhoa.Text, txt_tenkhoa.Text);
                txt_makhoa.Enabled = false;
                txt_tenkhoa.Enabled = false;
                btn_add_khoa.Enabled = true;
                btn_delete_khoa.Enabled = false;
                btn_sua.Enabled = false;
                addkhoa = false;  
            }
            else
            {
                dt.Update_Khoa(txt_makhoa.Text, txt_tenkhoa.Text);
                txt_tenkhoa.Enabled = false;
                btn_sua.Enabled = false;
                btn_delete_khoa.Enabled = false;
                btn_add_khoa.Enabled = true;
            }    
            frm_Khoa_Load(sender, e);
            MessageBox.Show("Đã lưu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void btn_delete_khoa_Click_1(object sender, EventArgs e)
        {
            DialogResult dlr = MessageBox.Show("Bạn có chắc chắn muốn xóa khoa " + txt_tenkhoa.Text + " không?", "Thông báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlr == DialogResult.Yes)
            {
                dt.Delete_Khoa(txt_makhoa.Text);
                txt_makhoa.Text = "";
                txt_tenkhoa.Text = "";
                btn_delete_khoa.Enabled= false;
                btn_sua.Enabled = false;
            }
            frm_Khoa_Load(sender, e);
        }

        private void dgv_dataKhoa_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_makhoa.DataBindings.Clear();
            txt_makhoa.DataBindings.Add("Text", dgv_dataKhoa.DataSource, "MaKhoa");
            txt_tenkhoa.DataBindings.Clear();
            txt_tenkhoa.DataBindings.Add("Text", dgv_dataKhoa.DataSource, "TenKhoa");
            btn_sua.Enabled = true;
            btn_delete_khoa.Enabled = true;
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            txt_tenkhoa.Enabled= true;
            btn_add_khoa.Enabled = false;
            btn_delete_khoa.Enabled = false;
            btn_sua.Enabled= false;
            btn_Huy.Enabled= true;
            btn_save_khoa.Enabled = true;
        }

        private void btn_Huy_Click(object sender, EventArgs e)
        {
            DialogResult dlr = MessageBox.Show("Bạn có chắc chắn muốn hủy không?", "Thông báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlr == DialogResult.Yes)
            {
                txt_makhoa.Text = "";
                txt_tenkhoa.Text = "";
                txt_tenkhoa.Enabled = false;
                txt_makhoa.Enabled = false;
                btn_add_khoa.Enabled = true;
                btn_delete_khoa.Enabled = false;
                btn_sua.Enabled= false;
                btn_Huy.Enabled = false;
                btn_save_khoa.Enabled = false;
                
            }
            frm_Khoa_Load(sender, e);
        }

        private void txt_timkiemkhoa_KeyUp(object sender, KeyEventArgs e)
        {
            var Lst = (from s in dt.Khoas where s.TenKhoa.Contains(txt_timkiemkhoa.Text) select s).ToList();
            dgv_dataKhoa.DataSource = Lst;
            txt_makhoa.DataBindings.Clear();
            txt_makhoa.DataBindings.Add("Text", dgv_dataKhoa.DataSource, "MaKhoa");
            txt_tenkhoa.DataBindings.Clear();
            txt_tenkhoa.DataBindings.Add("Text", dgv_dataKhoa.DataSource, "TenKhoa");
        }
    }
}
