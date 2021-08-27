using HeChuyenGia.EF;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Forms;

namespace HeChuyenGia.Algorithms
{
    class ChuanDoan
    {
        private ChuanDoanDbContext data;
        public ArrayList step;
        public ChuanDoan()
        {
            data = new ChuanDoanDbContext();
            step = new ArrayList();
        }
        public string SuyDienTien(List<string> GT, List<ArrayList> stepPrint)
        {
            string result = "Không tìm được bệnh";
            ChuanDoanDbContext data = new ChuanDoanDbContext();
            var getAllLuat = data.TAP_LUAT.ToList();
            List<TAP_LUAT> SAT;
            List<string> TG=new List<string>();
            TG.AddRange(GT);
            SAT = findSAT(TG, getAllLuat);
            step.Add(" ");          
            step.Add(GT);         
            step.Add(SAT.Select(x => x.MA_LUAT.Trim()).ToList());
            stepPrint.Add(step);
            while (SAT.Count != 0)
            {
                TAP_LUAT RLast = SAT[0];
                TG.Add(SAT[0].KET_LUAN.Trim());
                getAllLuat.Remove(RLast);
                SAT = findSAT(TG, getAllLuat);
                step = new ArrayList();
                step.Add(RLast.MA_LUAT.Trim());
                step.Add(GT);
                step.Add(SAT.Select(x => x.MA_LUAT.Trim()).ToList());
                stepPrint.Add(step);      
                if (checkChuanDoan(TG))
                {
                    var res = data.BENH_GA.Find(TG.Last().Trim()).MO_TA;
                    result = res;
                    break;
                }               
            }
            return result;
        }

        private bool checkChuanDoan(List<string> TG)
        {
            bool check = false;
            ChuanDoanDbContext data = new ChuanDoanDbContext();
            foreach (var res in TG)
            {
                if (data.BENH_GA.Find(res.Trim()) != null)
                {
                    check = true;
                    break;
                }
            }
            return check;
        }
        private List<TAP_LUAT> findSAT(List<string> TG, List<TAP_LUAT> getAllLuat)
        {
            List<TAP_LUAT> result = new List<TAP_LUAT>();
            foreach (var luat in getAllLuat)
            {
                int count = 0;
                string[] tapSuKien = luat.GIA_THIET.Split(',');
                for (int i = 0; i < tapSuKien.Length; i++)
                {
                    foreach (var suKien in TG)
                    {
                        if (suKien == tapSuKien[i].Trim())
                        {
                            count++;
                        }
                    }
                }
                if (checkTrung(result, luat) && !TG.Contains(luat.KET_LUAN.Trim()) && count == tapSuKien.Length && !TG.Contains(luat.KET_LUAN))
                {
                    result.Add(luat);
                }
            }
            return result;
        }
        private bool checkTrung(List<TAP_LUAT> result, TAP_LUAT R)
        {
            bool res = true;
            if (result.Count != 0)
            {
                if (result.Contains(R))
                {
                    res = false;
                }
            }
            return res;
        }
        
    }
}
