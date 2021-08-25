using HeChuyenGia.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Forms;

namespace HeChuyenGia.Algorithms
{
    class QuanLyLuat
    {
        ChuanDoanDbContext db = null;
        public QuanLyLuat()
        {
            db = new ChuanDoanDbContext();
        }
        public List<TAP_LUAT> getFullLuat()
        {
            return db.TAP_LUAT.ToList();
        }
        public void SuaLuat(string Id, string GT,string KL)
        {
            try
            {
                var getAllMaBenh = db.BENH_GA.Select(x => x.MA_BENH.Trim()).ToList();
                var getAllMaTrieuChung = db.TRIEU_CHUNG.Select(x=>x.MA_TT.Trim()).ToList();
                List<string> listKQ = new List<string>();// list mã bệnh + triệu chứng
                listKQ.AddRange(getAllMaBenh);
                listKQ.AddRange(getAllMaTrieuChung);
                var listGT = GT.Split(',').ToList();
                bool check = true;
                foreach (var res in listGT)
                {
                    if (!getAllMaTrieuChung.Contains(res.Trim()))
                        check = false;
                }
                if (db.TAP_LUAT.Find(Id.Trim()) == null)
                    check = false;
                else if(!listKQ.Contains(KL.Trim()))
                {
                    check = false;
                }
                
                if (check)
                {
                    TAP_LUAT TLnew = db.TAP_LUAT.Find(Id.Trim());
                    TLnew.GIA_THIET = GT.Trim();
                    TLnew.KET_LUAN = KL.Trim();
                    db.SaveChanges();
                    MessageBox.Show("Sửa luật thành công !");
                    return;
                }
                else
                {
                    MessageBox.Show("không tìm thấy mã luật hoặc giả thiết hoặc KL không hợp lệ !");
                    return;
                }
            }
            catch(Exception)
            {
                MessageBox.Show("Có lỗi xảy ra !");
                return;
            }
           
        }
        public void ThemLuat(string Id, string GT, string KL)
        {
            try
            {
                var getAllMaBenh = db.BENH_GA.Select(x => x.MA_BENH.Trim()).ToList();
                var getAllMaTrieuChung = db.TRIEU_CHUNG.Select(x => x.MA_TT.Trim()).ToList();
                List<string> listKQ = new List<string>();
                listKQ.AddRange(getAllMaBenh);
                listKQ.AddRange(getAllMaTrieuChung);
                var listGT = GT.Split(',').ToList();
                bool check = true;
                foreach (var res in listGT)
                {
                    if (!getAllMaTrieuChung.Contains(res.Trim()))
                        check = false;
                }
                if (db.TAP_LUAT.Find(Id.Trim()) != null)
                    check = false;
                else if (!listKQ.Contains(KL.Trim()))
                {
                    check = false;
                }
                if (check)
                {
                    TAP_LUAT TLnew = new TAP_LUAT();
                    TLnew.MA_LUAT = Id.Trim();
                    TLnew.GIA_THIET = GT.Trim();
                    TLnew.KET_LUAN = KL.Trim();
                    db.TAP_LUAT.Add(TLnew);
                    db.SaveChanges();
                    MessageBox.Show("Thêm luật thành công !");
                    return;
                }
                else
                {
                    MessageBox.Show("Thêm luật thất bại, kiểm tra lại !");
                    return;
                }
            }
            catch(Exception)
            {
                MessageBox.Show("Có lỗi xảy ra !");
                return;
            }
        }
        public void XoaLuat(string Id)
        {
            try
            {
                var res = db.TAP_LUAT.Find(Id.Trim());
                if (res != null)
                {
                    db.TAP_LUAT.Remove(res);
                    db.SaveChanges();
                    MessageBox.Show("Xoá luật thành công !");
                }
                else
                {
                    MessageBox.Show("Không tìm thấy luật để xoá !");
                }
            }
            catch(Exception)
            {
                MessageBox.Show("Có lỗi xảy ra !");
                return;
            }
           
        }
    }
}
