using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class DTBUS

    {
        private static DTBUS instance;

        public static DTBUS Instance
        {
            get
            {
                if (instance == null)
                    instance = new DTBUS();
                return instance;
            }

        }
        private DTBUS() { }
        public List<CBBItem> GetCapDTCBB()
        {
            List<CBBItem> listCDTCBB = new List<CBBItem>();
            foreach (CapDeTai cdt in DTDAO.Instance.GetAllCapDT())
            {
                listCDTCBB.Add(new CBBItem
                {
                    Text = cdt.TenCapDT,
                    value = cdt.MaCapDT
                });
            }
            return listCDTCBB;
        }
        public List<CBBItem> GetListCBBCN()
        {
            List<CBBItem> listCBBCN = new List<CBBItem>();
            foreach (DeTai dt in DTDAO.Instance.GetAllDT())
            {
                listCBBCN.Add(new CBBItem
                {
                    Text = dt.ChuNhiemDT,
                    value = dt.MaDT
                });
            }
            return listCBBCN;
        }
        public List<string> GetListCBBSort()
        {
            List<string> listSort = new List<string>();
            foreach (string cln in DTDAO.Instance.GetNameColumn())
            {
                listSort.Add(cln);
            }
            return listSort;

        }
        public List<DeTai> GetListDT(string tenDT)
        {
            List<DeTai> listDT = new List<DeTai>();
            if (tenDT == null)
            {
                listDT = DTDAO.Instance.GetAllDT();
            }
            if (tenDT != null)
            {
                listDT = DTDAO.Instance.GetDTSearch(tenDT);
            }
            Console.WriteLine(tenDT);
            return listDT;
        }
        public DeTai GetSVByMaDT(string m)
        {
            DeTai d = null;
            foreach (DeTai dt in DTDAO.Instance.GetAllDT())
            {
                if (dt.MaDT.ToString() == m)
                {
                    d = dt; ;
                    break;
                }

            }
            return d;
        }
        public void ExcuteDB(DeTai d)
        {
            if (DTBUS.Instance.GetSVByMaDT(d.MaDT.ToString()) != null && d.MaDT == DTBUS.Instance.GetSVByMaDT(d.MaDT.ToString()).MaDT)
            {
                DTDAO.Instance.UpdateDT(d);
            }
            else
            {
                DTDAO.Instance.AddDT(d);

            }
        }
        public void DelDT(List<string> LMDT)
        {
            foreach (string mdt in LMDT)
            {
                DTDAO.Instance.DeleteSV(mdt);
                Console.WriteLine(mdt);
            }
        }
    }
}
