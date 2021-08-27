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
    public partial class frBenh : Form
    {
        public frBenh()
        {
            InitializeComponent();
        }

        private void frBenh_Load(object sender, EventArgs e)
        {
            int index = 0;
            data.ColumnCount = 3;
            foreach(var res in new ChuanDoanDbContext().BENH_GA.ToList())
            {
                data.Rows.Add();
                data.Rows[index].Cells[0].Value = index + 1;
                data.Rows[index].Cells[1].Value= res.MA_BENH.Trim();
                data.Rows[index].Cells[2].Value = res.MO_TA.Trim();
                index++;
            }
        }
    }
}
