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

        public frTuVan()
        {
            InitializeComponent();
            QL = new QuanLyCauHoi(picture);
            result =new List<string>();
            listControls = new List<Control>[45];
        }

        private void frTuVan_Load(object sender, EventArgs e)
        {
            LoadData();
            LoadCauHoi();
            LoadAnswer();

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

        private void siticoneRoundedButton1_Click(object sender, EventArgs e)
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
        private void siticoneRoundedButton2_Click(object sender, EventArgs e)
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
                MessageBox.Show(t);
            }
            else
            {
                string t = "";
                foreach (var te in QL.tapKq)
                {
                    t = t + te + "\n";
                }
                MessageBox.Show(t);
            }

        }

        private void siticoneRoundedButton4_Click(object sender, EventArgs e)
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
            txt_ans.Text = new ChuanDoan().SuyDienTien(result);
            QL = new QuanLyCauHoi(picture);
            result = new List<string>();
            listControls = new List<Control>[45];
            index = 1;
            answer.Controls.Clear();
            frTuVan_Load(sender, e);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            QL = new QuanLyCauHoi(picture);
            result = new List<string>();
            listControls = new List<Control>[45];
            index = 1;
            answer.Controls.Clear();
            txt_ans.Text = "";
            frTuVan_Load(sender, e);
        }
    }
}
