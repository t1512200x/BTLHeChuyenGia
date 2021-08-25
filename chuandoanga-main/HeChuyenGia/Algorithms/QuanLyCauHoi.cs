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
            switch (index)
            {
                case 1:
                    foreach (var text in db.CAU_HOI.Find("CH_39").TRIEU_CHUNG.Select(x => x.TEN_TT.Trim()))
                    {
                        SiticonRadButtonChild rad = CreateRadButton(text);
                        rad.TextFlag = db.CAU_HOI.Find("CH_39").TRIEU_CHUNG.FirstOrDefault(x => x.TEN_TT.Trim() == text).MA_TT.Trim();
                        rad.ChFlag = "CH_39";
                        rad.AutoSize = false;
                        rad.Width = 160;
                        rad.CheckedChanged += Rad_CheckedChanged;
                        SiticonButtonChild btn = CreateBtnXemAnh();
                        btn.FlagMaTT = rad.TextFlag;
                        answer.Controls.Add(rad);
                        answer.Controls.Add(btn);

                    }; break;
                case 2:
                    foreach (var text in db.CAU_HOI.Find("CH_41").TRIEU_CHUNG.Select(x => x.TEN_TT.Trim()))
                    {
                        SiticonRadButtonChild rad = CreateRadButton(text);
                        rad.TextFlag = db.CAU_HOI.Find("CH_41").TRIEU_CHUNG.FirstOrDefault(x => x.TEN_TT.Trim() == text).MA_TT.Trim();
                        rad.ChFlag = "CH_41";
                        rad.AutoSize = false;
                        rad.Width = 160;
                        rad.CheckedChanged += Rad_CheckedChanged;
                        SiticonButtonChild btn = CreateBtnXemAnh();
                        btn.FlagMaTT = rad.TextFlag;
                        answer.Controls.Add(rad);
                        answer.Controls.Add(btn);
                    }; break;
                case 3:
                    foreach (var text in db.CAU_HOI.Find("CH_31").TRIEU_CHUNG.Select(x => x.TEN_TT.Trim()))
                    {
                        SititconCheckBoxChild box = CreateCheckBox(text);
                        box.AutoSize = false;
                        box.Width = 160;
                        box.CheckedChanged += Box_CheckedChanged;
                        box.TextFlag = db.CAU_HOI.Find("CH_31").TRIEU_CHUNG.FirstOrDefault(x => x.TEN_TT.Trim() == text).MA_TT.Trim();
                        SiticonButtonChild btn = CreateBtnXemAnh();
                        btn.FlagMaTT = box.TextFlag;
                        answer.Controls.Add(box);
                        answer.Controls.Add(btn);
                    }; break;
                case 4:
                    foreach (var text in db.CAU_HOI.Find("CH_30").TRIEU_CHUNG.Select(x => x.TEN_TT.Trim()))
                    {
                        SiticonRadButtonChild rad = CreateRadButton(text);
                        rad.TextFlag = db.CAU_HOI.Find("CH_30").TRIEU_CHUNG.FirstOrDefault(x => x.TEN_TT.Trim() == text).MA_TT.Trim();
                        rad.ChFlag = "CH_30";
                        rad.AutoSize = false;
                        rad.Width = 160;
                        rad.CheckedChanged += Rad_CheckedChanged;
                        SiticonButtonChild btn = CreateBtnXemAnh();
                        btn.FlagMaTT = rad.TextFlag;
                        answer.Controls.Add(rad);
                        answer.Controls.Add(btn);
                    }; break;
                case 5:
                    foreach (var text in db.CAU_HOI.Find("CH_1").TRIEU_CHUNG.Select(x => x.TEN_TT.Trim()))
                    {
                        SiticonRadButtonChild rad = CreateRadButton(text);
                        rad.TextFlag = db.CAU_HOI.Find("CH_1").TRIEU_CHUNG.FirstOrDefault(x => x.TEN_TT.Trim() == text).MA_TT.Trim();
                        rad.ChFlag = "CH_1";
                        rad.AutoSize = false;
                        rad.Width = 160;
                        rad.CheckedChanged += Rad_CheckedChanged;
                        SiticonButtonChild btn = CreateBtnXemAnh();
                        btn.FlagMaTT = rad.TextFlag;
                        answer.Controls.Add(rad);
                        answer.Controls.Add(btn);

                    }; break;
                case 6:
                    foreach (var text in db.CAU_HOI.Find("CH_13").TRIEU_CHUNG.Select(x => x.TEN_TT.Trim()))
                    {
                        SititconCheckBoxChild box = CreateCheckBox(text);
                        box.AutoSize = false;
                        box.Width = 160;
                        box.CheckedChanged += Box_CheckedChanged;
                        box.TextFlag = db.CAU_HOI.Find("CH_13").TRIEU_CHUNG.FirstOrDefault(x => x.TEN_TT.Trim() == text).MA_TT.Trim();
                        SiticonButtonChild btn = CreateBtnXemAnh();
                        btn.FlagMaTT = box.TextFlag;
                        answer.Controls.Add(box);
                        answer.Controls.Add(btn);

                    }; break;
                case 7:
                    foreach (var text in db.CAU_HOI.Find("CH_22").TRIEU_CHUNG.Select(x => x.TEN_TT.Trim()))
                    {
                        SititconCheckBoxChild box = CreateCheckBox(text);
                        box.AutoSize = false;
                        box.Width = 160;
                        box.CheckedChanged += Box_CheckedChanged;
                        box.TextFlag = db.CAU_HOI.Find("CH_22").TRIEU_CHUNG.FirstOrDefault(x => x.TEN_TT.Trim() == text).MA_TT.Trim();
                        SiticonButtonChild btn = CreateBtnXemAnh();
                        btn.FlagMaTT = box.TextFlag;
                        answer.Controls.Add(box);
                        answer.Controls.Add(btn);

                    }; break;
                case 8:
                    foreach (var text in db.CAU_HOI.Find("CH_42").TRIEU_CHUNG.Select(x => x.TEN_TT.Trim()))
                    {
                        SititconCheckBoxChild box = CreateCheckBox(text);
                        box.AutoSize = false;
                        box.Width = 160;
                        box.CheckedChanged += Box_CheckedChanged;
                        box.TextFlag = db.CAU_HOI.Find("CH_42").TRIEU_CHUNG.FirstOrDefault(x => x.TEN_TT.Trim() == text).MA_TT.Trim();
                        SiticonButtonChild btn = CreateBtnXemAnh();
                        btn.FlagMaTT = box.TextFlag;
                        answer.Controls.Add(box);
                        answer.Controls.Add(btn);

                    }; break;
                case 9:
                    foreach (var text in db.CAU_HOI.Find("CH_21").TRIEU_CHUNG.Select(x => x.TEN_TT.Trim()))
                    {
                        SititconCheckBoxChild box = CreateCheckBox(text);
                        box.AutoSize = false;
                        box.Width = 160;
                        box.CheckedChanged += Box_CheckedChanged;
                        box.TextFlag = db.CAU_HOI.Find("CH_21").TRIEU_CHUNG.FirstOrDefault(x => x.TEN_TT.Trim() == text).MA_TT.Trim();
                        SiticonButtonChild btn = CreateBtnXemAnh();
                        btn.FlagMaTT = box.TextFlag;
                        answer.Controls.Add(box);
                        answer.Controls.Add(btn);

                    }; break;
                case 10:
                    foreach (var text in db.CAU_HOI.Find("CH_20").TRIEU_CHUNG.Select(x => x.TEN_TT.Trim()))
                    {
                        SititconCheckBoxChild box = CreateCheckBox(text);
                        box.AutoSize = false;
                        box.Width = 160;
                        box.CheckedChanged += Box_CheckedChanged;
                        box.TextFlag = db.CAU_HOI.Find("CH_20").TRIEU_CHUNG.FirstOrDefault(x => x.TEN_TT.Trim() == text).MA_TT.Trim();
                        SiticonButtonChild btn = CreateBtnXemAnh();
                        btn.FlagMaTT = box.TextFlag;
                        answer.Controls.Add(box);
                        answer.Controls.Add(btn);

                    }; break;
                case 11:
                    foreach (var text in db.CAU_HOI.Find("CH_24").TRIEU_CHUNG.Select(x => x.TEN_TT.Trim()))
                    {
                        SititconCheckBoxChild box = CreateCheckBox(text);
                        box.AutoSize = false;
                        box.Width = 200;
                        box.CheckedChanged += Box_CheckedChanged;
                        box.TextFlag = db.CAU_HOI.Find("CH_24").TRIEU_CHUNG.FirstOrDefault(x => x.TEN_TT.Trim() == text).MA_TT.Trim();
                        SiticonButtonChild btn = CreateBtnXemAnh();
                        btn.FlagMaTT = box.TextFlag;
                        answer.Controls.Add(box);
                        answer.Controls.Add(btn);
                    }; break;
                case 12:
                    foreach (var text in db.CAU_HOI.Find("CH_23").TRIEU_CHUNG.Select(x => x.TEN_TT.Trim()))
                    {
                        SititconCheckBoxChild box = CreateCheckBox(text);
                        box.AutoSize = false;
                        box.Width = 160;
                        box.CheckedChanged += Box_CheckedChanged;
                        box.TextFlag = db.CAU_HOI.Find("CH_23").TRIEU_CHUNG.FirstOrDefault(x => x.TEN_TT.Trim() == text).MA_TT.Trim();
                        SiticonButtonChild btn = CreateBtnXemAnh();
                        btn.FlagMaTT = box.TextFlag;
                        answer.Controls.Add(box);
                        answer.Controls.Add(btn);
                    }; break;
                case 13:
                    foreach (var text in db.CAU_HOI.Find("CH_10").TRIEU_CHUNG.Select(x => x.TEN_TT.Trim()))
                    {
                        SititconCheckBoxChild box = CreateCheckBox(text);
                        box.AutoSize = false;
                        box.Width = 160;
                        box.CheckedChanged += Box_CheckedChanged;
                        box.TextFlag = db.CAU_HOI.Find("CH_10").TRIEU_CHUNG.FirstOrDefault(x => x.TEN_TT.Trim() == text).MA_TT.Trim();
                        SiticonButtonChild btn = CreateBtnXemAnh();
                        btn.FlagMaTT = box.TextFlag;
                        answer.Controls.Add(box);
                        answer.Controls.Add(btn);
                    }; break;
                case 14:
                    foreach (var text in db.CAU_HOI.Find("CH_34").TRIEU_CHUNG.Select(x => x.TEN_TT.Trim()))
                    {
                        SititconCheckBoxChild box = CreateCheckBox(text);
                        box.AutoSize = false;
                        box.Width = 160;
                        box.CheckedChanged += Box_CheckedChanged;
                        box.TextFlag = db.CAU_HOI.Find("CH_34").TRIEU_CHUNG.FirstOrDefault(x => x.TEN_TT.Trim() == text).MA_TT.Trim();
                        SiticonButtonChild btn = CreateBtnXemAnh();
                        btn.FlagMaTT = box.TextFlag;
                        answer.Controls.Add(box);
                        answer.Controls.Add(btn);

                    }; break;
                case 15:
                    foreach (var text in db.CAU_HOI.Find("CH_17").TRIEU_CHUNG.Select(x => x.TEN_TT.Trim()))
                    {
                        SititconCheckBoxChild box = CreateCheckBox(text);
                        box.AutoSize = false;
                        box.Width = 160;
                        box.CheckedChanged += Box_CheckedChanged;
                        box.TextFlag = db.CAU_HOI.Find("CH_17").TRIEU_CHUNG.FirstOrDefault(x => x.TEN_TT.Trim() == text).MA_TT.Trim();
                        SiticonButtonChild btn = CreateBtnXemAnh();
                        btn.FlagMaTT = box.TextFlag;
                        answer.Controls.Add(box);
                        answer.Controls.Add(btn);
                    }; break;
                case 16:
                    foreach (var text in db.CAU_HOI.Find("CH_5").TRIEU_CHUNG.Select(x => x.TEN_TT.Trim()))
                    {
                        SititconCheckBoxChild box = CreateCheckBox(text);
                        box.AutoSize = false;
                        box.Width = 160;
                        box.CheckedChanged += Box_CheckedChanged;
                        box.TextFlag = db.CAU_HOI.Find("CH_5").TRIEU_CHUNG.FirstOrDefault(x => x.TEN_TT.Trim() == text).MA_TT.Trim();
                        SiticonButtonChild btn = CreateBtnXemAnh();
                        btn.FlagMaTT = box.TextFlag;
                        answer.Controls.Add(box);
                        answer.Controls.Add(btn);

                    }; break;
                case 17:
                    foreach (var text in db.CAU_HOI.Find("CH_4").TRIEU_CHUNG.Select(x => x.TEN_TT.Trim()))
                    {
                        SititconCheckBoxChild box = CreateCheckBox(text);
                        box.AutoSize = false;
                        box.Width = 160;
                        box.CheckedChanged += Box_CheckedChanged;
                        box.TextFlag = db.CAU_HOI.Find("CH_4").TRIEU_CHUNG.FirstOrDefault(x => x.TEN_TT.Trim() == text).MA_TT.Trim();
                        SiticonButtonChild btn = CreateBtnXemAnh();
                        btn.FlagMaTT = box.TextFlag;
                        answer.Controls.Add(box);
                        answer.Controls.Add(btn);
                    }; break;
                case 18:
                    foreach (var text in db.CAU_HOI.Find("CH_36").TRIEU_CHUNG.Select(x => x.TEN_TT.Trim()))
                    {
                        SititconCheckBoxChild box = CreateCheckBox(text);
                        box.AutoSize = false;
                        box.Width = 160;
                        box.CheckedChanged += Box_CheckedChanged;
                        box.TextFlag = db.CAU_HOI.Find("CH_36").TRIEU_CHUNG.FirstOrDefault(x => x.TEN_TT.Trim() == text).MA_TT.Trim();
                        SiticonButtonChild btn = CreateBtnXemAnh();
                        btn.FlagMaTT = box.TextFlag;
                        answer.Controls.Add(box);
                        answer.Controls.Add(btn);
                    }; break;
                case 19:
                    foreach (var text in db.CAU_HOI.Find("CH_12").TRIEU_CHUNG.Select(x => x.TEN_TT.Trim()))
                    {
                        SititconCheckBoxChild box = CreateCheckBox(text);
                        box.AutoSize = false;
                        box.Width = 160;
                        box.CheckedChanged += Box_CheckedChanged;
                        box.TextFlag = db.CAU_HOI.Find("CH_12").TRIEU_CHUNG.FirstOrDefault(x => x.TEN_TT.Trim() == text).MA_TT.Trim();
                        SiticonButtonChild btn = CreateBtnXemAnh();
                        btn.FlagMaTT = box.TextFlag;
                        answer.Controls.Add(box);
                        answer.Controls.Add(btn);

                    }; break;
                case 20:
                    foreach (var text in db.CAU_HOI.Find("CH_27").TRIEU_CHUNG.Select(x => x.TEN_TT.Trim()))
                    {
                        SititconCheckBoxChild box = CreateCheckBox(text);
                        box.AutoSize = false;
                        box.Width = 160;
                        box.CheckedChanged += Box_CheckedChanged;
                        box.TextFlag = db.CAU_HOI.Find("CH_27").TRIEU_CHUNG.FirstOrDefault(x => x.TEN_TT.Trim() == text).MA_TT.Trim();
                        SiticonButtonChild btn = CreateBtnXemAnh();
                        btn.FlagMaTT = box.TextFlag;
                        answer.Controls.Add(box);
                        answer.Controls.Add(btn);

                    }; break;
                case 21:
                    foreach (var text in db.CAU_HOI.Find("CH_2").TRIEU_CHUNG.Select(x => x.TEN_TT.Trim()))
                    {
                        SititconCheckBoxChild box = CreateCheckBox(text);
                        box.AutoSize = false;
                        box.Width = 160;
                        box.CheckedChanged += Box_CheckedChanged;
                        box.TextFlag = db.CAU_HOI.Find("CH_2").TRIEU_CHUNG.FirstOrDefault(x => x.TEN_TT.Trim() == text).MA_TT.Trim();
                        SiticonButtonChild btn = CreateBtnXemAnh();
                        btn.FlagMaTT = box.TextFlag;
                        answer.Controls.Add(box);
                        answer.Controls.Add(btn);
                    }; break;
                case 22:
                    foreach (var text in db.CAU_HOI.Find("CH_44").TRIEU_CHUNG.Select(x => x.TEN_TT.Trim()))
                    {
                        SititconCheckBoxChild box = CreateCheckBox(text);
                        box.AutoSize = false;
                        box.Width = 160;
                        box.CheckedChanged += Box_CheckedChanged;
                        box.TextFlag = db.CAU_HOI.Find("CH_44").TRIEU_CHUNG.FirstOrDefault(x => x.TEN_TT.Trim() == text).MA_TT.Trim();
                        SiticonButtonChild btn = CreateBtnXemAnh();
                        btn.FlagMaTT = box.TextFlag;
                        answer.Controls.Add(box);
                        answer.Controls.Add(btn);
                    }; break;
                case 23:
                    foreach (var text in db.CAU_HOI.Find("CH_15").TRIEU_CHUNG.Select(x => x.TEN_TT.Trim()))
                    {
                        SititconCheckBoxChild box = CreateCheckBox(text);
                        box.AutoSize = false;
                        box.Width = 160;
                        box.CheckedChanged += Box_CheckedChanged;
                        box.TextFlag = db.CAU_HOI.Find("CH_15").TRIEU_CHUNG.FirstOrDefault(x => x.TEN_TT.Trim() == text).MA_TT.Trim();
                        SiticonButtonChild btn = CreateBtnXemAnh();
                        btn.FlagMaTT = box.TextFlag;
                        answer.Controls.Add(box);
                        answer.Controls.Add(btn);

                    }; break;
                case 24:
                    foreach (var text in db.CAU_HOI.Find("CH_6").TRIEU_CHUNG.Select(x => x.TEN_TT.Trim()))
                    {
                        SititconCheckBoxChild box = CreateCheckBox(text);
                        box.AutoSize = false;
                        box.Width = 160;
                        box.CheckedChanged += Box_CheckedChanged;
                        box.TextFlag = db.CAU_HOI.Find("CH_6").TRIEU_CHUNG.FirstOrDefault(x => x.TEN_TT.Trim() == text).MA_TT.Trim();
                        SiticonButtonChild btn = CreateBtnXemAnh();
                        btn.FlagMaTT = box.TextFlag;
                        answer.Controls.Add(box);
                        answer.Controls.Add(btn);

                    }; break;
                case 25:
                    foreach (var text in db.CAU_HOI.Find("CH_14").TRIEU_CHUNG.Select(x => x.TEN_TT.Trim()))
                    {
                        SititconCheckBoxChild box = CreateCheckBox(text);
                        box.AutoSize = false;
                        box.Width = 160;
                        box.CheckedChanged += Box_CheckedChanged;
                        box.TextFlag = db.CAU_HOI.Find("CH_14").TRIEU_CHUNG.FirstOrDefault(x => x.TEN_TT.Trim() == text).MA_TT.Trim();
                        SiticonButtonChild btn = CreateBtnXemAnh();
                        btn.FlagMaTT = box.TextFlag;
                        answer.Controls.Add(box);
                        answer.Controls.Add(btn);

                    }; break;
                case 26:
                    foreach (var text in db.CAU_HOI.Find("CH_33").TRIEU_CHUNG.Select(x => x.TEN_TT.Trim()))
                    {
                        SititconCheckBoxChild box = CreateCheckBox(text);
                        box.AutoSize = false;
                        box.Width = 160;
                        box.CheckedChanged += Box_CheckedChanged;
                        box.TextFlag = db.CAU_HOI.Find("CH_33").TRIEU_CHUNG.FirstOrDefault(x => x.TEN_TT.Trim() == text).MA_TT.Trim();
                        SiticonButtonChild btn = CreateBtnXemAnh();
                        btn.FlagMaTT = box.TextFlag;
                        answer.Controls.Add(box);
                        answer.Controls.Add(btn);
                    }; break;
                case 27:
                    foreach (var text in db.CAU_HOI.Find("CH_25").TRIEU_CHUNG.Select(x => x.TEN_TT.Trim()))
                    {
                        SititconCheckBoxChild box = CreateCheckBox(text);
                        box.AutoSize = false;
                        box.Width = 160;
                        box.CheckedChanged += Box_CheckedChanged;
                        box.TextFlag = db.CAU_HOI.Find("CH_25").TRIEU_CHUNG.FirstOrDefault(x => x.TEN_TT.Trim() == text).MA_TT.Trim();
                        SiticonButtonChild btn = CreateBtnXemAnh();
                        btn.FlagMaTT = box.TextFlag;
                        answer.Controls.Add(box);
                        answer.Controls.Add(btn);

                    }; break;
                case 28:
                    foreach (var text in db.CAU_HOI.Find("CH_28").TRIEU_CHUNG.Select(x => x.TEN_TT.Trim()))
                    {
                        SititconCheckBoxChild box = CreateCheckBox(text);
                        box.AutoSize = false;
                        box.Width = 160;
                        box.CheckedChanged += Box_CheckedChanged;
                        box.TextFlag = db.CAU_HOI.Find("CH_28").TRIEU_CHUNG.FirstOrDefault(x => x.TEN_TT.Trim() == text).MA_TT.Trim();
                        SiticonButtonChild btn = CreateBtnXemAnh();
                        btn.FlagMaTT = box.TextFlag;
                        answer.Controls.Add(box);
                        answer.Controls.Add(btn);

                    }; break;
                case 29:
                    foreach (var text in db.CAU_HOI.Find("CH_38").TRIEU_CHUNG.Select(x => x.TEN_TT.Trim()))
                    {
                        SititconCheckBoxChild box = CreateCheckBox(text);
                        box.AutoSize = false;
                        box.Width = 160;
                        box.CheckedChanged += Box_CheckedChanged;
                        box.TextFlag = db.CAU_HOI.Find("CH_38").TRIEU_CHUNG.FirstOrDefault(x => x.TEN_TT.Trim() == text).MA_TT.Trim();
                        SiticonButtonChild btn = CreateBtnXemAnh();
                        btn.FlagMaTT = box.TextFlag;
                        answer.Controls.Add(box);
                        answer.Controls.Add(btn);

                    }; break;
                case 30:
                    foreach (var text in db.CAU_HOI.Find("CH_35").TRIEU_CHUNG.Select(x => x.TEN_TT.Trim()))
                    {
                        SititconCheckBoxChild box = CreateCheckBox(text);
                        box.AutoSize = false;
                        box.Width = 160;
                        box.CheckedChanged += Box_CheckedChanged;
                        box.TextFlag = db.CAU_HOI.Find("CH_35").TRIEU_CHUNG.FirstOrDefault(x => x.TEN_TT.Trim() == text).MA_TT.Trim();
                        SiticonButtonChild btn = CreateBtnXemAnh();
                        btn.FlagMaTT = box.TextFlag;
                        answer.Controls.Add(box);
                        answer.Controls.Add(btn);

                    }; break;
                case 31:
                    foreach (var text in db.CAU_HOI.Find("CH_11").TRIEU_CHUNG.Select(x => x.TEN_TT.Trim()))
                    {
                        SititconCheckBoxChild box = CreateCheckBox(text);
                        box.AutoSize = false;
                        box.Width = 160;
                        box.CheckedChanged += Box_CheckedChanged;
                        box.TextFlag = db.CAU_HOI.Find("CH_11").TRIEU_CHUNG.FirstOrDefault(x => x.TEN_TT.Trim() == text).MA_TT.Trim();
                        SiticonButtonChild btn = CreateBtnXemAnh();
                        btn.FlagMaTT = box.TextFlag;
                        answer.Controls.Add(box);
                        answer.Controls.Add(btn);

                    }; break;
                case 32:
                    foreach (var text in db.CAU_HOI.Find("CH_16").TRIEU_CHUNG.Select(x => x.TEN_TT.Trim()))
                    {
                        SititconCheckBoxChild box = CreateCheckBox(text);
                        box.AutoSize = false;
                        box.Width = 160;
                        box.CheckedChanged += Box_CheckedChanged;
                        box.TextFlag = db.CAU_HOI.Find("CH_16").TRIEU_CHUNG.FirstOrDefault(x => x.TEN_TT.Trim() == text).MA_TT.Trim();
                        SiticonButtonChild btn = CreateBtnXemAnh();
                        btn.FlagMaTT = box.TextFlag;
                        answer.Controls.Add(box);
                        answer.Controls.Add(btn);

                    }; break;
                case 33:
                    foreach (var text in db.CAU_HOI.Find("CH_32").TRIEU_CHUNG.Select(x => x.TEN_TT.Trim()))
                    {
                        SititconCheckBoxChild box = CreateCheckBox(text);
                        box.AutoSize = false;
                        box.Width = 160;
                        box.CheckedChanged += Box_CheckedChanged;
                        box.TextFlag = db.CAU_HOI.Find("CH_32").TRIEU_CHUNG.FirstOrDefault(x => x.TEN_TT.Trim() == text).MA_TT.Trim();
                        SiticonButtonChild btn = CreateBtnXemAnh();
                        btn.FlagMaTT = box.TextFlag;
                        answer.Controls.Add(box);
                        answer.Controls.Add(btn);

                    }; break;
                case 34:
                    foreach (var text in db.CAU_HOI.Find("CH_26").TRIEU_CHUNG.Select(x => x.TEN_TT.Trim()))
                    {
                        SititconCheckBoxChild box = CreateCheckBox(text);
                        box.AutoSize = false;
                        box.Width = 160;
                        box.CheckedChanged += Box_CheckedChanged;
                        box.TextFlag = db.CAU_HOI.Find("CH_26").TRIEU_CHUNG.FirstOrDefault(x => x.TEN_TT.Trim() == text).MA_TT.Trim();
                        SiticonButtonChild btn = CreateBtnXemAnh();
                        btn.FlagMaTT = box.TextFlag;
                        answer.Controls.Add(box);
                        answer.Controls.Add(btn);

                    }; break;
                case 35:
                    foreach (var text in db.CAU_HOI.Find("CH_3").TRIEU_CHUNG.Select(x => x.TEN_TT.Trim()))
                    {
                        SititconCheckBoxChild box = CreateCheckBox(text);
                        box.AutoSize = false;
                        box.Width = 160;
                        box.CheckedChanged += Box_CheckedChanged;
                        box.TextFlag = db.CAU_HOI.Find("CH_3").TRIEU_CHUNG.FirstOrDefault(x => x.TEN_TT.Trim() == text).MA_TT.Trim();
                        SiticonButtonChild btn = CreateBtnXemAnh();
                        btn.FlagMaTT = box.TextFlag;
                        answer.Controls.Add(box);
                        answer.Controls.Add(btn);

                    }; break;
                case 36:
                    foreach (var text in db.CAU_HOI.Find("CH_37").TRIEU_CHUNG.Select(x => x.TEN_TT.Trim()))
                    {
                        SititconCheckBoxChild box = CreateCheckBox(text);
                        box.AutoSize = false;
                        box.Width = 160;
                        box.CheckedChanged += Box_CheckedChanged;
                        box.TextFlag = db.CAU_HOI.Find("CH_37").TRIEU_CHUNG.FirstOrDefault(x => x.TEN_TT.Trim() == text).MA_TT.Trim();
                        SiticonButtonChild btn = CreateBtnXemAnh();
                        btn.FlagMaTT = box.TextFlag;
                        answer.Controls.Add(box);
                        answer.Controls.Add(btn);

                    }; break;
                case 37:
                    foreach (var text in db.CAU_HOI.Find("CH_29").TRIEU_CHUNG.Select(x => x.TEN_TT.Trim()))
                    {
                        SititconCheckBoxChild box = CreateCheckBox(text);
                        box.AutoSize = false;
                        box.Width = 160;
                        box.CheckedChanged += Box_CheckedChanged;
                        box.TextFlag = db.CAU_HOI.Find("CH_29").TRIEU_CHUNG.FirstOrDefault(x => x.TEN_TT.Trim() == text).MA_TT.Trim();
                        SiticonButtonChild btn = CreateBtnXemAnh();
                        btn.FlagMaTT = box.TextFlag;
                        answer.Controls.Add(box);
                        answer.Controls.Add(btn);

                    }; break;
                case 38:
                    foreach (var text in db.CAU_HOI.Find("CH_8").TRIEU_CHUNG.Select(x => x.TEN_TT.Trim()))
                    {
                        SititconCheckBoxChild box = CreateCheckBox(text);
                        box.AutoSize = false;
                        box.Width = 160;
                        box.CheckedChanged += Box_CheckedChanged;
                        box.TextFlag = db.CAU_HOI.Find("CH_8").TRIEU_CHUNG.FirstOrDefault(x => x.TEN_TT.Trim() == text).MA_TT.Trim();
                        SiticonButtonChild btn = CreateBtnXemAnh();
                        btn.FlagMaTT = box.TextFlag;
                        answer.Controls.Add(box);
                        answer.Controls.Add(btn);

                    }; break;
                case 39:
                    foreach (var text in db.CAU_HOI.Find("CH_7").TRIEU_CHUNG.Select(x => x.TEN_TT.Trim()))
                    {
                        SititconCheckBoxChild box = CreateCheckBox(text);
                        box.AutoSize = false;
                        box.Width = 160;
                        box.CheckedChanged += Box_CheckedChanged;
                        box.TextFlag = db.CAU_HOI.Find("CH_7").TRIEU_CHUNG.FirstOrDefault(x => x.TEN_TT.Trim() == text).MA_TT.Trim();
                        SiticonButtonChild btn = CreateBtnXemAnh();
                        btn.FlagMaTT = box.TextFlag;
                        answer.Controls.Add(box);
                        answer.Controls.Add(btn);

                    }; break;
                case 40:
                    foreach (var text in db.CAU_HOI.Find("CH_19").TRIEU_CHUNG.Select(x => x.TEN_TT.Trim()))
                    {
                        SititconCheckBoxChild box = CreateCheckBox(text);
                        box.AutoSize = false;
                        box.Width = 160;
                        box.CheckedChanged += Box_CheckedChanged;
                        box.TextFlag = db.CAU_HOI.Find("CH_19").TRIEU_CHUNG.FirstOrDefault(x => x.TEN_TT.Trim() == text).MA_TT.Trim();
                        SiticonButtonChild btn = CreateBtnXemAnh();
                        btn.FlagMaTT = box.TextFlag;
                        answer.Controls.Add(box);
                        answer.Controls.Add(btn);

                    }; break;
                case 41:
                    foreach (var text in db.CAU_HOI.Find("CH_40").TRIEU_CHUNG.Select(x => x.TEN_TT.Trim()))
                    {
                        SititconCheckBoxChild box = CreateCheckBox(text);
                        box.AutoSize = false;
                        box.Width = 160;
                        box.CheckedChanged += Box_CheckedChanged;
                        box.TextFlag = db.CAU_HOI.Find("CH_40").TRIEU_CHUNG.FirstOrDefault(x => x.TEN_TT.Trim() == text).MA_TT.Trim();
                        SiticonButtonChild btn = CreateBtnXemAnh();
                        btn.FlagMaTT = box.TextFlag;
                        answer.Controls.Add(box);
                        answer.Controls.Add(btn);

                    }; break;
                case 42:
                    foreach (var text in db.CAU_HOI.Find("CH_43").TRIEU_CHUNG.Select(x => x.TEN_TT.Trim()))
                    {
                        SititconCheckBoxChild box = CreateCheckBox(text);
                        box.AutoSize = false;
                        box.Width = 160;
                        box.CheckedChanged += Box_CheckedChanged;
                        box.TextFlag = db.CAU_HOI.Find("CH_43").TRIEU_CHUNG.FirstOrDefault(x => x.TEN_TT.Trim() == text).MA_TT.Trim();
                        SiticonButtonChild btn = CreateBtnXemAnh();
                        btn.FlagMaTT = box.TextFlag;
                        answer.Controls.Add(box);
                        answer.Controls.Add(btn);

                    }; break;
                case 43:
                    foreach (var text in db.CAU_HOI.Find("CH_18").TRIEU_CHUNG.Select(x => x.TEN_TT.Trim()))
                    {
                        SititconCheckBoxChild box = CreateCheckBox(text);
                        box.AutoSize = false;
                        box.Width = 160;
                        box.CheckedChanged += Box_CheckedChanged;
                        box.TextFlag = db.CAU_HOI.Find("CH_18").TRIEU_CHUNG.FirstOrDefault(x => x.TEN_TT.Trim() == text).MA_TT.Trim();
                        SiticonButtonChild btn = CreateBtnXemAnh();
                        btn.FlagMaTT = box.TextFlag;
                        answer.Controls.Add(box);
                        answer.Controls.Add(btn);
                    }; break;
                case 44:
                    foreach (var text in db.CAU_HOI.Find("CH_9").TRIEU_CHUNG.Select(x => x.TEN_TT.Trim()))
                    {
                        SititconCheckBoxChild box = CreateCheckBox(text);
                        box.AutoSize = false;
                        box.Width = 160;
                        box.CheckedChanged += Box_CheckedChanged;
                        box.TextFlag = db.CAU_HOI.Find("CH_9").TRIEU_CHUNG.FirstOrDefault(x => x.TEN_TT.Trim() == text).MA_TT.Trim();
                        SiticonButtonChild btn = CreateBtnXemAnh();
                        btn.FlagMaTT = box.TextFlag;
                        answer.Controls.Add(box);
                        answer.Controls.Add(btn);

                    }; break;
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
            string res;
            switch (i)
            {
                case 1: res = db.CAU_HOI.Find("CH_39").TEN_CH; break;
                case 2: res = db.CAU_HOI.Find("CH_41").TEN_CH; break;
                case 3: res = db.CAU_HOI.Find("CH_31").TEN_CH; break;
                case 4: res = db.CAU_HOI.Find("CH_30").TEN_CH; break;
                case 5: res = db.CAU_HOI.Find("CH_1").TEN_CH; break;
                case 6: res = db.CAU_HOI.Find("CH_13").TEN_CH; break;
                case 7: res = db.CAU_HOI.Find("CH_22").TEN_CH; break;
                case 8: res = db.CAU_HOI.Find("CH_42").TEN_CH; break;
                case 9: res = db.CAU_HOI.Find("CH_21").TEN_CH; break;
                case 10: res = db.CAU_HOI.Find("CH_20").TEN_CH; break;
                case 11: res = db.CAU_HOI.Find("CH_24").TEN_CH; break;
                case 12: res = db.CAU_HOI.Find("CH_23").TEN_CH; break;
                case 13: res = db.CAU_HOI.Find("CH_10").TEN_CH; break;
                case 14: res = db.CAU_HOI.Find("CH_34").TEN_CH; break;
                case 15: res = db.CAU_HOI.Find("CH_17").TEN_CH; break;
                case 16: res = db.CAU_HOI.Find("CH_5").TEN_CH; break;
                case 17: res = db.CAU_HOI.Find("CH_4").TEN_CH; break;
                case 18: res = db.CAU_HOI.Find("CH_36").TEN_CH; break;
                case 19: res = db.CAU_HOI.Find("CH_12").TEN_CH; break;
                case 20: res = db.CAU_HOI.Find("CH_27").TEN_CH; break;
                case 21: res = db.CAU_HOI.Find("CH_2").TEN_CH; break;
                case 22: res = db.CAU_HOI.Find("CH_44").TEN_CH; break;
                case 23: res = db.CAU_HOI.Find("CH_15").TEN_CH; break;
                case 24: res = db.CAU_HOI.Find("CH_6").TEN_CH; break;
                case 25: res = db.CAU_HOI.Find("CH_14").TEN_CH; break;
                case 26: res = db.CAU_HOI.Find("CH_33").TEN_CH; break;
                case 27: res = db.CAU_HOI.Find("CH_25").TEN_CH; break;
                case 28: res = db.CAU_HOI.Find("CH_28").TEN_CH; break;
                case 29: res = db.CAU_HOI.Find("CH_38").TEN_CH; break;
                case 30: res = db.CAU_HOI.Find("CH_35").TEN_CH; break;
                case 31: res = db.CAU_HOI.Find("CH_11").TEN_CH; break;
                case 32: res = db.CAU_HOI.Find("CH_16").TEN_CH; break;
                case 33: res = db.CAU_HOI.Find("CH_32").TEN_CH; break;
                case 34: res = db.CAU_HOI.Find("CH_26").TEN_CH; break;
                case 35: res = db.CAU_HOI.Find("CH_3").TEN_CH; break;
                case 36: res = db.CAU_HOI.Find("CH_37").TEN_CH; break;
                case 37: res = db.CAU_HOI.Find("CH_29").TEN_CH; break;
                case 38: res = db.CAU_HOI.Find("CH_8").TEN_CH; break;
                case 39: res = db.CAU_HOI.Find("CH_7").TEN_CH; break;
                case 40: res = db.CAU_HOI.Find("CH_19").TEN_CH; break;
                case 41: res = db.CAU_HOI.Find("CH_40").TEN_CH; break;
                case 42: res = db.CAU_HOI.Find("CH_43").TEN_CH; break;
                case 43: res = db.CAU_HOI.Find("CH_18").TEN_CH; break;
                case 44: res = db.CAU_HOI.Find("CH_9").TEN_CH; break;
                default: res = "Kết thúc !"; break;
            }
            return res;
        }

    }
}
