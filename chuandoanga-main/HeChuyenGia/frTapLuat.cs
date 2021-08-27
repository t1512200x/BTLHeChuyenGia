using HeChuyenGia.Algorithms;
using HeChuyenGia.EF;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HeChuyenGia
{
    public partial class frTapLuat : Form
    {
        private QuanLyLuat QL;
        public frTapLuat()
        {
            InitializeComponent();
            QL = new QuanLyLuat();
        }

        private void frTapLuat_Load(object sender, EventArgs e)
        {
            txt_luat.Font = new Font(txt_luat.Font.FontFamily, 12);
            txt_noidung.Font = new Font(txt_noidung.Font.FontFamily, 12);
            txt_kq.Font = new Font(txt_kq.Font.FontFamily, 12);
            HienThi();
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            QL.SuaLuat(txt_luat.Text, txt_noidung.Text, txt_kq.Text);
            HienThi();

        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            QL.ThemLuat(txt_luat.Text, txt_noidung.Text, txt_kq.Text);
            HienThi();

        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            QL.XoaLuat(txt_luat.Text);
            HienThi();
        }
        private void data_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int index = e.RowIndex;
                txt_luat.Text = data.Rows[index].Cells[1].Value.ToString();
                txt_noidung.Text = data.Rows[index].Cells[2].Value.ToString();
                txt_kq.Text = data.Rows[index].Cells[3].Value.ToString();
            }
            catch(Exception)
            {

            }
        }

       
        public void HienThi()
        {
            data.Rows.Clear();
            data.ColumnCount = 4;
            int i = 0;
            foreach (var res in QL.getFullLuat())
            {
                data.Rows.Add();
                data.Rows[i].Cells[0].Value = i + 1;
                data.Rows[i].Cells[1].Value = res.MA_LUAT.ToString();
                data.Rows[i].Cells[2].Value = res.GIA_THIET.ToString();
                data.Rows[i].Cells[3].Value = res.KET_LUAN.ToString();
                i++;
            }
        }

    }
}
