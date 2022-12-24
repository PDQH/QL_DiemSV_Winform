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
    public partial class frm_Nhapdiem : Form
    {
        public frm_Nhapdiem()
        {
            InitializeComponent();
        }
        Database_QLDDataContext dt = new Database_QLDDataContext();

        private void frm_Nhapdiem_Load(object sender, EventArgs e)
        {
            cbb_dskhoa.DisplayMember = "TenKhoa";
            cbb_dskhoa.ValueMember = "MaKhoa";
            cbb_dskhoa.DataSource = dt.SelectAll_Khoa();
            lb_Makhoa.DataBindings.Clear();
            lb_Makhoa.DataBindings.Add("Text", cbb_dskhoa.DataSource, "MaKhoa");
        }

        private void cbb_dskhoa_SelectionChangeCommitted(object sender, EventArgs e)
        {
            cbb_dslop.DisplayMember = "TenLop";
            cbb_dslop.ValueMember = "MaLop";
            cbb_dslop.DataSource = dt.SelectAll_Lop(lb_Makhoa.Text);
            //cbb_dslop_SelectionChangeCommitted(sender, e);
        }

        private void cbb_dslop_SelectionChangeCommitted(object sender, EventArgs e)
        {
            cbb_dshocky.DataSource = dt.SelectAll_Hocky();
            cbb_dshocky.DisplayMember = "TenHK";
            cbb_dshocky.ValueMember = "MaHK";
            txt_mahocky.DataBindings.Clear();
            txt_mahocky.DataBindings.Add("Text", cbb_dshocky.DataSource, "MaHK");
            txt_tenhocky.DataBindings.Clear();
            txt_tenhocky.DataBindings.Add("Text", cbb_dshocky.DataSource, "TenHK");
            btn_Add_hocky.Enabled = true;
            btn_Delete_hocky.Enabled=true;
            
        }

        Boolean addHK = false;
        private void btn_Add_hocky_Click(object sender, EventArgs e)
        {
            txt_mahocky.Text = "";
            txt_tenhocky.Text = "";
            txt_mahocky.Enabled= true;
            txt_tenhocky.Enabled = true;
            btn_Save_hocky.Enabled =true;
            txt_mahocky.Focus();
            addHK= true;
        }

        private void btn_Save_hocky_Click(object sender, EventArgs e)
        {
            if (addHK)
            {
                dt.Insert_Hocky(txt_mahocky.Text, txt_tenhocky.Text);
                txt_mahocky.Enabled = false;
                txt_tenhocky.Enabled = false;
                btn_Save_hocky.Enabled = false;
                addHK = false;
                cbb_dslop_SelectionChangeCommitted(sender, e);
                MessageBox.Show("Đã lưu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                dt.Update_Hocky(txt_mahocky.Text, txt_tenhocky.Text);
                cbb_dslop_SelectionChangeCommitted(sender, e);
            }
        }

        private void btn_Delete_hocky_Click(object sender, EventArgs e)
        {
            DialogResult dlr = MessageBox.Show("Bạn có chắc chắn muốn xóa " + txt_tenhocky.Text + " không?", "Thông báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlr == DialogResult.Yes)
            {
                MessageBox.Show("Đã xóa " + txt_tenhocky.Text + " thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                dt.Delete_Hocky(cbb_dshocky.SelectedValue.ToString());
                cbb_dslop_SelectionChangeCommitted(sender, e); 
            }
        }

        private void cbb_dshocky_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbb_dsmon.ValueMember = "MaMH";
            cbb_dsmon.DisplayMember = "TenMH";
            cbb_dsmon.DataSource = dt.MonHoc_SelectMaHK(cbb_dshocky.SelectedValue.ToString());
            txt_mamon.DataBindings.Clear();
            txt_mamon.DataBindings.Add("Text", cbb_dsmon.DataSource, "MaMH");
            txt_tenmon.DataBindings.Clear();
            txt_tenmon.DataBindings.Add("Text", cbb_dsmon.DataSource, "TenMH");

        }

        private void btn_capnhatdulieu_Click(object sender, EventArgs e)
        {
            foreach(var m in dt.SelectAll_MonHoc())
            {
                foreach(var s in dt.SelectAll_SinhVien())
                {
                    if(dt.Search_Diem(m.MaMH,s.MaSV).Count() == 0)
                    {
                        dt.Insert_Diem(m.MaMH, s.MaSV);
                    }
                }
            }
            MessageBox.Show("Cập nhật dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void cbb_dsmon_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgv_datanhapđiem.DataSource = dt.BangDiem(cbb_dslop.SelectedValue.ToString(), txt_mamon.Text);
        }

        private void cbb_dslop_SelectedIndexChanged(object sender, EventArgs e)
        {
            //cbb_dsmon_SelectedIndexChanged(sender, e);
        }

        private void dgv_datanhapđiem_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            int i = dgv_datanhapđiem.CurrentCell.RowIndex;
            if (!string.IsNullOrEmpty(dgv_datanhapđiem.Rows[i].Cells["DiemCC"].Value.ToString()))
            {
                dt.Diem_UpdateDiemCC(Convert.ToDouble(dgv_datanhapđiem.Rows[i].Cells["DiemCC"].Value),
                    txt_mamon.Text, dgv_datanhapđiem.Rows[i].Cells["MaSV"].Value.ToString());
            }
            if (!string.IsNullOrEmpty(dgv_datanhapđiem.Rows[i].Cells[2].Value.ToString()))
            {
                dt.Diem_UpdateDiemGiuaHP(Convert.ToDouble(dgv_datanhapđiem.Rows[i].Cells["DiemGiuaHP"].Value),
                    txt_mamon.Text, dgv_datanhapđiem.Rows[i].Cells["MaSV"].Value.ToString());
            }
            if (!string.IsNullOrEmpty(dgv_datanhapđiem.Rows[i].Cells[3].Value.ToString()))
            {
                dt.Diem_UpdateDiemThi(Convert.ToDouble(dgv_datanhapđiem.Rows[i].Cells["DiemThi"].Value),
                    txt_mamon.Text, dgv_datanhapđiem.Rows[i].Cells["MaSV"].Value.ToString());
            }

        }
    }
}
