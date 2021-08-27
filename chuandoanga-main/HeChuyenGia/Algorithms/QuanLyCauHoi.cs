using HeChuyenGia.EF;
using ns1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Forms;
using HeChuyenGia.Commons;
using System.Drawing;

namespace HeChuyenGia.Algorithms
{
    class QuanLyCauHoi
    {
        private ChuanDoanDbContext db;
        private PictureBox picture;
        public List<string> tapKq = new List<string>();
        public QuanLyCauHoi(PictureBox picture)
        {
            db = new ChuanDoanDbContext();
            this.picture = picture;
        }
        public void getAnswerByIndex(int index, FlowLayoutPanel answer)
        {
            if(index==1||index==2||index==4||index==5)
            {
                foreach (var text in db.CAU_HOI.Find(index).TRIEU_CHUNG.Select(x => x.TEN_TT.Trim()))
                {
                    SiticonRadButtonChild rad = CreateRadButton(text);
                    rad.TextFlag = db.CAU_HOI.Find(index).TRIEU_CHUNG.FirstOrDefault(x => x.TEN_TT.Trim() == text).MA_TT.Trim();
                    rad.ChFlag = index;
                    rad.AutoSize = false;
                    rad.Width = 160;
                    rad.CheckedChanged += Rad_CheckedChanged;                
                    SiticonButtonChild btn = CreateBtnXemAnh();
                    btn.FlagMaTT = rad.TextFlag;
                    answer.Controls.Add(rad);
                    answer.Controls.Add(btn);
                }
            }
            else
            {
                foreach (var text in db.CAU_HOI.Find(index).TRIEU_CHUNG.Select(x => x.TEN_TT.Trim()))
                {
                    SititconCheckBoxChild box = CreateCheckBox(text);
                    box.AutoSize = false;
                    box.Width = 160;
                    box.CheckedChanged += Box_CheckedChanged;
                    box.TextFlag = db.CAU_HOI.Find(index).TRIEU_CHUNG.FirstOrDefault(x => x.TEN_TT.Trim() == text).MA_TT.Trim();
                    SiticonButtonChild btn = CreateBtnXemAnh();
                    btn.FlagMaTT = box.TextFlag;
                    answer.Controls.Add(box);
                    answer.Controls.Add(btn);
                }
            }
           
        }

        private void Rad_CheckedChanged(object sender, EventArgs e)
        {

            if ((sender as SiticonRadButtonChild).Checked)
            {
                foreach (var del in db.CAU_HOI.Find((sender as SiticonRadButtonChild).ChFlag).TRIEU_CHUNG.Select(x => x.MA_TT.Trim()).ToList())
                {
                    if (tapKq.Contains(del))
                    {
                        tapKq.Remove(del);
                    }
                }
                tapKq.Add((sender as SiticonRadButtonChild).TextFlag);
            }

            else
            {

                if (tapKq.Contains((sender as SiticonRadButtonChild).TextFlag))
                {
                    tapKq.Remove((sender as SiticonRadButtonChild).TextFlag);
                }
            }
            
        }

        private void Box_CheckedChanged(object sender, EventArgs e)
        {

            if ((sender as SititconCheckBoxChild).CheckState == CheckState.Checked)
            {
                if (tapKq.Contains((sender as SititconCheckBoxChild).TextFlag))
                {
                    tapKq.Remove((sender as SititconCheckBoxChild).TextFlag);
                }
                else
                {
                    tapKq.Add((sender as SititconCheckBoxChild).TextFlag);
                }
            }
            else if ((sender as SititconCheckBoxChild).CheckState == CheckState.Unchecked)
            {
                if (tapKq.Contains((sender as SititconCheckBoxChild).TextFlag))
                {
                    tapKq.Remove((sender as SititconCheckBoxChild).TextFlag);
                }
            }

        }

        private SiticonRadButtonChild CreateRadButton(string text)
        {
            SiticonRadButtonChild rad = new SiticonRadButtonChild();
            rad.Text = text;
            return rad;
        }
        private SititconCheckBoxChild CreateCheckBox(string text)
        {
            SititconCheckBoxChild box = new SititconCheckBoxChild();
            box.Cursor = Cursors.Hand;
            box.Text = text;
            box.AutoSize = true;
            return box;
        }
        private SiticonButtonChild CreateBtnXemAnh()
        {
            SiticonButtonChild btn = new SiticonButtonChild();
            btn.Text = "Xem ảnh";
            btn.Width = 100;
            btn.Height = 20;
            btn.Cursor = Cursors.Hand;
            btn.Click += Btn_Click;
            return btn;
        }
        private void Btn_Click(object sender, EventArgs e)
        {
            string id_tt = (sender as SiticonButtonChild).FlagMaTT;
            string b = Application.StartupPath.Substring(0, (Application.StartupPath.Length - 9));
            string a = "\\Resources" + "\\" + id_tt.Trim() + ".jpg";
            picture.Image = new Bitmap(b + a);
        }

        public string getCauHoiByIndex(int i)
        {
            string res="";
            try
            {
                res = db.CAU_HOI.Find(i).TEN_CH.Trim();
            }
            catch
            {

            }
            return res;

        }

        public List<CAU_HOI> getAllCauHoi()
        {
            return db.CAU_HOI.ToList();
        }
    }
}
