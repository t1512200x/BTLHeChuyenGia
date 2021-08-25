using ns1;
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
    public partial class Home : Form
    {
        private SiticoneRoundedButton currentBtn;
        private Form currentChildForm;
        public Home()
        {
            InitializeComponent();
        }


        private void tưVấnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frTuVan form = new frTuVan();
            form.Visible = true;
        }

        private void siticoneRoundedButton1_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            OpenChildForm(new frHome2());
        }

        private void ActivateButton(object senderBtn)
        {
            if (senderBtn != null)
            {
                DisableButton();
                currentBtn = (SiticoneRoundedButton)senderBtn;
                currentBtn.ForeColor = Color.White;
                currentBtn.FillColor = Color.FromArgb(116, 185, 255);
             }
        }
        private void DisableButton()
        {
                btn_home.ForeColor = Color.FromArgb(99, 110, 114);
                btn_home.FillColor = Color.White;
            if (currentBtn != null)
            {
                currentBtn.ForeColor = Color.FromArgb(99, 110, 114);
                currentBtn.FillColor = Color.White;
            }
        }

        private void siticonePanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void siticoneRoundedButton1_Click_1(object sender, EventArgs e)
        {
            ActivateButton(sender);
            OpenChildForm(new frTuVan());
        }

        private void siticoneRoundedButton2_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            OpenChildForm(new frTapLuat());
        }

        private void siticoneRoundedButton3_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            OpenChildForm(new frTrieuChung());
        }

        private void siticoneRoundedButton4_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            OpenChildForm(new frBenh());
        }

        private void siticoneRoundedButton5_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            OpenChildForm(new frThongTin());
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void OpenChildForm(Form childForm)
        {
            //open only form
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            //End
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(childForm);
            panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            OpenChildForm(new frHome2());
            btn_home.ForeColor = Color.White;
            btn_home.FillColor = Color.FromArgb(116, 185, 255);
        }

    }
}
