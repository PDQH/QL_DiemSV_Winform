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
    public partial class frm_Main : Form
    {
        public frm_Main()
        {
            InitializeComponent();
        }

        private void menuItem_sinhvien_Click(object sender, EventArgs e)
        {
            frm_Sinhvien frm_Sinhvien = new frm_Sinhvien();
            frm_Sinhvien.ShowDialog();
        }

        private void menuItem_khoa_Click(object sender, EventArgs e)
        {
            frm_Khoa frmKho = new frm_Khoa();
            frmKho.ShowDialog();
        }

        private void menuItem_monhoc_Click(object sender, EventArgs e)
        {
            frm_Monhoc frmMonhoc = new frm_Monhoc();
            frmMonhoc.ShowDialog();
        }

        private void menu_Nhapdiem_Click(object sender, EventArgs e)
        {
            frm_Nhapdiem frmNhapdiem = new frm_Nhapdiem();
            frmNhapdiem.ShowDialog();
        }

        private void menu_Bangdiem_Click(object sender, EventArgs e)
        {
            frm_Bangdiem frmBangdiem = new frm_Bangdiem();
            frmBangdiem.ShowDialog();
        }
    }
}
