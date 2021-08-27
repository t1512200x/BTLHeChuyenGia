using HeChuyenGia.EF;
using ns1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HeChuyenGia
{
    public partial class frTrieuChung : Form
    {
        public frTrieuChung()
        {
            InitializeComponent();
        }

        private void frTrieuChung_Load(object sender, EventArgs e)
        {
            data.ColumnCount = 3;
            data.AllowUserToOrderColumns = true;
            data.AllowUserToResizeColumns = true;
            int i = 0;
            using (ChuanDoanDbContext db = new ChuanDoanDbContext())
            {
                foreach(var res in db.TRIEU_CHUNG)
                {
                    data.Rows.Add();
                    data.Rows[i].Cells[0].Value = i + 1;
                    data.Rows[i].Cells[1].Value = res.MA_TT;
                    data.Rows[i].Cells[2].Value = res.TEN_TT;
                    i++;
                }    
            }    
        }

      
        private void data_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            ImgTT.SizeMode = PictureBoxSizeMode.StretchImage;

        }

        private void data_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index != -1)
            {
                DataGridViewRow selectedRows = data.Rows[index];
                string id_tt = selectedRows.Cells[1].Value.ToString();
                string b = Application.StartupPath.Substring(0, (Application.StartupPath.Length - 9));
                string a = "\\Resources" + "\\" + id_tt.Trim() + ".jpg";
                ImgTT.Image = new Bitmap(b + a);
            }
        }
    }
}
