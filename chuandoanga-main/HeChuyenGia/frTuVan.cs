using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HeChuyenGia.Algorithms;
using ns1;
namespace HeChuyenGia
{
    public partial class frTuVan : Form
    {
        public int index = 1;
        private QuanLyCauHoi QL;
        private List<string> result;
        private List<Control>[] listControls;
        private List<ArrayList> stepPrint;
        private int indexClick = 1;

        public frTuVan()
        {
            InitializeComponent();
            QL = new QuanLyCauHoi(picture);
            result =new List<string>();
            listControls = new List<Control>[45];
            stepPrint = new List<ArrayList>();
        }

        private void frTuVan_Load(object sender, EventArgs e)
        {
            LoadData();
            LoadCauHoi();
            LoadAnswer();
            LoadAllCauHoi();

        }

        private void LoadCauHoi()
        {
            lbSoCau.Text = index.ToString();
            lbCh.Text = QL.getCauHoiByIndex(index);
        }

        private void LoadAnswer()
        {
            QL.getAnswerByIndex(index, answer);
        }

        private void data_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void LoadData()
        {
            txt_ans.Font = new Font(txt_ans.Font.FontFamily, 14);
            txt_ans.ReadOnly = true;
        }

        private void btnBoQua_Click(object sender, EventArgs e)
        {

            if (index < 44)
            {
                index++;
                answer.Controls.Clear();
                LoadCauHoi();
                if (listControls[index] == null)
                    LoadAnswer();
                else
                    answer.Controls.AddRange(listControls[index].ToArray());
            }

        }
        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            var controls = answer.Controls.OfType<Control>().ToList();
            listControls[index] = controls;
            if (index < 44)
            {
                index++;
                answer.Controls.Clear();
                LoadCauHoi();
                LoadAnswer();

                string t = "";
                foreach (var te in QL.tapKq)
                {
                    t = t + te + "\n";
                }
                MessageBox.Show(t,"           TG");
            }
            else
            {
                string t = "";
                foreach (var te in QL.tapKq)
                {
                    t = t + te + "\n";
                }
                MessageBox.Show(t,"           TG");
            }

        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            if (index > 1)
            {
                index -= 1;
                answer.Controls.Clear();
                LoadCauHoi();
                if (listControls[index] == null)
                    LoadAnswer();
                else
                    answer.Controls.AddRange(listControls[index].ToArray());
            }
        }

        private void btnKetQua_Click(object sender, EventArgs e)
        {
            
            result = QL.tapKq;
            stepPrint = new List<ArrayList>();
            txt_ans.Text = new ChuanDoan().SuyDienTien(result, stepPrint);
            QL = new QuanLyCauHoi(picture);
            result = new List<string>();
            listControls = new List<Control>[45];
            index = 1;
            answer.Controls.Clear();
            data1.Rows.Clear();
            frTuVan_Load(sender, e);
            
        }

        private void btnXemSuyDien_Click_1(object sender, EventArgs e)
        {
           
                data1.Rows.Clear();
                data1.ColumnCount = 3;
                int i = 0;
                foreach (var res in stepPrint)
                {
                    data1.Rows.Add();
                    data1.Rows[i].Cells[0].Value = res[0].ToString();
                    data1.Rows[i].Cells[1].Value = ((res[1] as List<string>) == null) ? " " : String.Join(",", (res[1] as List<string>).ToArray());
                    data1.Rows[i].Cells[2].Value = ((res[2] as List<string>) == null) ? " " : String.Join(",", (res[2] as List<string>).ToArray());
                    i++;
                }
                stepPrint = new List<ArrayList>();           
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
           
            QL = new QuanLyCauHoi(picture);
            result = new List<string>();
            listControls = new List<Control>[45];
            stepPrint = new List<ArrayList>();
            data1.Rows.Clear();
            index = 1;
            answer.Controls.Clear();
            txt_ans.Text = "";
            picture.Image = null;
            frTuVan_Load(sender, e);
        }

        private void LoadAllCauHoi()
        {
            data.ColumnCount = 2;
            int i = 0;
            foreach (var ch in QL.getAllCauHoi())
            {
                data.Rows.Add();
                data.Rows[i].Cells[0].Value = ch.MA_CH;
                data.Rows[i].Cells[1].Value = ch.TEN_CH.Trim();
                i++;
            }
        }
        private void data_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if(index>=0)
                {
                    index = e.RowIndex + 1;
                    answer.Controls.Clear();
                    lbSoCau.Text = index.ToString();
                    lbCh.Text = QL.getCauHoiByIndex(index);
                    if (listControls[index] != null)
                    {
                        answer.Controls.AddRange(listControls[index].ToArray());
                    }
                    else
                    {
                        LoadAnswer();
                    }
                }    
                 
            }
            catch
            {

            }

        }

    }
}
