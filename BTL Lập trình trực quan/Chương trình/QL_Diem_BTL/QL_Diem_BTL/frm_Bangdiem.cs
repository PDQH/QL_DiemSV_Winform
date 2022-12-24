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
    public partial class frm_Bangdiem : Form
    {
        public frm_Bangdiem()
        {
            InitializeComponent();
        }
        Database_QLDDataContext dt = new Database_QLDDataContext();
        XuLydataDiem xl = new XuLydataDiem();
        private void frm_Bangdiem_Load(object sender, EventArgs e)
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

        }

        private void cbb_dslop_SelectedIndexChanged(object sender, EventArgs e)
        {
            trv_dssinhvien.Nodes.Clear();
            TreeNode rt = new TreeNode();
            rt.Text = "Lớp " +cbb_dslop.Text+"";
            trv_dssinhvien.Nodes.Add(rt);
            foreach (var r in dt.SinhVien_SelectMaLop(cbb_dslop.SelectedValue.ToString()))
            {
                TreeNode node = new TreeNode();
                node.Name = r.MaSV;
                node.Text = r.Hovaten;
                trv_dssinhvien.Nodes.Add(node);
            }
            trv_dssinhvien.ExpandAll();
        }

        private void trv_dssinhvien_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            btn_ExportExcel.Enabled = true;
            foreach (var r in dt.SinhVien_SelectID(e.Node.Name))
            {
                lbtt_masv.Text = e.Node.Name;
                lbtt_Hovaten.Text = r.Hovaten;
                lbtt_Ngaysinh.Text = r.NgaySinh.ToString();
                lbtt_Gioitinh.Text = r.GioiTinh;
                lbtt_Noisinh.Text = r.NoiSinh;
                lbtt_Quequan.Text = r.QueQuan;
                lbtt_Dantoc.Text = r.DanToc;
                lbtt_SDT.Text = r.SDT;
                lbtt_Ghichu.Text = r.GhiChu;
            }    
            var table = new DataTable();
            DataColumnCollection colm = table.Columns;
            if (!colm.Contains("MaMH")) table.Columns.Add("MaMH", typeof(string));
            if (!colm.Contains("TenMH")) table.Columns.Add("TenMH", typeof(string));
            if (!colm.Contains("SoTinChi")) table.Columns.Add("SoTinChi", typeof(string));
            if (!colm.Contains("DiemThi")) table.Columns.Add("DiemThi", typeof(string));
            if (!colm.Contains("ThangDiem4")) table.Columns.Add("ThangDiem4", typeof(string));
            if (!colm.Contains("DiemChu")) table.Columns.Add("DiemChu", typeof(string));
            Double tong = 0;
            int Sotinchi = 0;
            foreach(var m in dt.SelectAll_MonHoc())
            {
                //dgv_Bangdiem.Columns["MaMH"].HeaderText = "Mã môn học";
                //dgv_Bangdiem.Columns["TenMH"].HeaderText = "Tên môn học";
                DataRow r = table.NewRow();
                r["MaMH"] = m.MaMH;
                r["TenMH"] = m.TenMH;
                r["SoTinChi"] = m.SoTinChi;
                Sotinchi += Convert.ToInt32(m.SoTinChi);
                foreach(var d in dt.Search_Diem(m.MaMH, e.Node.Name))
                {
                    //dgv_Bangdiem.Columns["SoTinChi"].HeaderText = "Số tín chỉ";
                    //dgv_Bangdiem.Columns["DiemThi"].HeaderText = "Thang điểm 10";
                    //dgv_Bangdiem.Columns["ThangDiem4"].HeaderText = "Thang điểm 4";
                    //dgv_Bangdiem.Columns["DiemChu"].HeaderText = "Thang điểm chữ";
                    r["DiemThi"] = d.DiemThi;
                    r["ThangDiem4"] = xl.ThangDiem4(Convert.ToDouble(d.DiemThi));
                    r["DiemChu"] = xl.DiemChu(Convert.ToDouble(d.DiemThi));
                    tong += xl.ThangDiem4(Convert.ToDouble(d.DiemGiuaHP)) * Convert.ToDouble(m.SoTinChi); 
                }    
                table.Rows.Add(r);
            }
            Double t = Math.Round(tong / Sotinchi, 2);
            lbtt_TBCtichluytd4.Text = t.ToString();
            lbtt_XLhoctap.Text = xl.XL(t);
            dgv_Bangdiem.DataSource = table;
        }

        //Xuất dữ liệu điểm sv ra Excel 
        private void btn_ExportExcel_Click(object sender, EventArgs e)
        {
            //Khởi tạo Excel 
            Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
            //Khởi tạo WorkBook 
            Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
            //Khởi tạo WorkSheet
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
            worksheet = workbook.Sheets["Sheet1"];
            worksheet = workbook.ActiveSheet;
            app.Visible= true;
            //Đổ dl vào sheet
            worksheet.Cells[1, 1] = "BẢNG ĐIỂM CỦA SINH VIÊN";
            worksheet.Cells[3, 2] = "Mã Sinh viên:" + lbtt_masv.Text;
            worksheet.Cells[4, 2] = "Họ và tên:" + lbtt_Hovaten.Text;
            worksheet.Cells[5, 2] = "Ngày Sinh:" + lbtt_Ngaysinh.Text;
            worksheet.Cells[6, 2] = "Dân tộc:" + lbtt_Dantoc.Text;
            worksheet.Cells[7, 2] = "Giới tính:" + lbtt_Gioitinh.Text;
            worksheet.Cells[8, 2] = "Nơi sinh:" + lbtt_Noisinh.Text;
            worksheet.Cells[3, 2] = "Quê quán:" + lbtt_Quequan.Text;
            worksheet.Cells[3, 2] = "Số điện thoại:" + lbtt_SDT.Text;
            worksheet.Cells[9, 1] = "STT";
            worksheet.Cells[9, 2] = "Mã môn học";
            worksheet.Cells[9, 3] = "Tên môn học";
            worksheet.Cells[9, 4] = "Số tín chỉ";
            worksheet.Cells[9, 5] = "Thang điểm 10";
            worksheet.Cells[9, 6] = "Thang điểm 4";
            worksheet.Cells[9, 7] = "Điểm chữ";
            for(int i = 0; i < dgv_Bangdiem.RowCount -1; i++)
            {
                for(int j = 0; j < 6; j++)
                {
                    worksheet.Cells[i + 10, 1] = i + 1;
                    worksheet.Cells[i + 10, j + 2] = dgv_Bangdiem.Rows[i].Cells[j].Value;
                }    
            }
            int Xl = dgv_Bangdiem.RowCount;
            worksheet.Cells[Xl = 25, 2] = "Xếp loại học tập: " + lbtt_XLhoctap.Text;
            worksheet.Cells[Xl = 26, 2] = "TBC tích lũy thang điểm 4: " +lbtt_TBCtichluytd4.Text;
            //Trang
            worksheet.PageSetup.Orientation = Microsoft.Office.Interop.Excel.XlPageOrientation.xlPortrait;
            worksheet.PageSetup.PaperSize = Microsoft.Office.Interop.Excel.XlPaperSize.xlPaperA4;
            worksheet.PageSetup.LeftMargin = 0.7;
            worksheet.PageSetup.RightMargin = 0.7;
            worksheet.PageSetup.TopMargin = 0.75;
            worksheet.PageSetup.BottomMargin = 0.75;
            worksheet.PageSetup.HeaderMargin = 0.3;
            worksheet.PageSetup.FooterMargin = 0.3;
            //Cột
            worksheet.Range["A1"].ColumnWidth = 8.25;
            worksheet.Range["B1"].ColumnWidth = 15;
            worksheet.Range["C1"].ColumnWidth = 28;
            worksheet.Range["D1"].ColumnWidth = 11;
            worksheet.Range["E1"].ColumnWidth = 15;
            worksheet.Range["F1"].ColumnWidth = 15;
            worksheet.Range["G1"].ColumnWidth = 15;
            //Font
            worksheet.Range["A1", "G100"].Font.Name = "Times New Roman";
            worksheet.Range["A1", "G100"].Font.Size = 14;
            worksheet.Range["A1", "G1"].MergeCells= true;
            worksheet.Range["A1", "G1"].Font.Bold= true;
            worksheet.Range["A9", "G9"].Font.Bold= true;
            //Kẻ Bảng
            worksheet.Range["A9", "G" + (Xl + 10)].Borders.LineStyle = 1;
            //Định dạng Text
            worksheet.Range["A1", "G1"].HorizontalAlignment = 3;
            worksheet.Range["A9", "G9"].HorizontalAlignment = 3;
            worksheet.Range["A10", "A" + (Xl + 10)].HorizontalAlignment = 3;
            worksheet.Range["D10", "D" + (Xl + 10)].HorizontalAlignment = 3;
            worksheet.Range["E10", "E" + (Xl + 10)].HorizontalAlignment = 3;
            worksheet.Range["F10", "F" + (Xl + 10)].HorizontalAlignment = 3;
            worksheet.Range["G10", "G" + (Xl + 10)].HorizontalAlignment = 3;

        }

    }
}
