using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class DTDAO
    {
        private static DTDAO instance;
        public static DTDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new DTDAO();
                return instance;
            }
            private set => instance = value;
        }
        private DTDAO() { }
        public CapDeTai GetCapDT(DataRow i)
        {
            return new CapDeTai(
                (int)i["MaCapDT"],
                i["TenCapDT"].ToString()
                );
        }
        public List<CapDeTai> GetAllCapDT()
        {
            List<CapDeTai> listDT = new List<CapDeTai>();
            string query = "select * from CapDeTai";
            foreach (DataRow row in DataProvider.Instance.GetRecords(query).Rows)
            {
                listDT.Add(GetCapDT(row));
            }
            return listDT;
        }
        public DeTai GetDT(DataRow i)
        {

            int maDT = i["MaDT"] != DBNull.Value ? (int)i["MaDT"] : 0;
            string tenDT = i["TenDT"] != DBNull.Value ? i["TenDT"].ToString() : string.Empty;
            DateTime? ngayNhanDT = i["NgayNhanDT"] != DBNull.Value ? (DateTime?)i["NgayNhanDT"] : null;
            string chunhiemDT = i["ChuNhiemDT"] != DBNull.Value ? i["ChuNhiemDT"].ToString() : string.Empty;
           
            bool? tinhTrang = i["TinhTrang"] != DBNull.Value ? (bool?)i["TinhTrang"] : null;
            

            int macapDT = i["MaCapDT"] != DBNull.Value ? (int)i["MaCapDT"] : 0;



            return new DeTai(maDT,tenDT,tinhTrang,macapDT,ngayNhanDT,chunhiemDT);

        }
        public List<DeTai> GetAllDT()
        {
            List<DeTai> listDT = new List<DeTai>();
            string query = "select * from DeTai";
            foreach (DataRow row in DataProvider.Instance.GetRecords(query).Rows)
            {
                listDT.Add(GetDT(row));
            }
            return listDT;
        }
        public List<string> GetNameColumn()
        {
            List<string> listCL = new List<string>();
            string query = "select top 0 * from DeTai";
            foreach (DataColumn col in DataProvider.Instance.GetRecords(query).Columns)
            {
                string columnName = col.ColumnName;
                listCL.Add(columnName);
            }
            return listCL;
        }

        public void UpdateDT(DeTai s)
        {
            string query = "UPDATE DeTai SET TenDT='" + s.TenDT + "', TinhTrang='" + s.TinhTrang + "', MaCapDT=" + s.MaCapDT + ", NgayNhanDT='" + s.NgayNhanDT + "', ChuNhiemDT='" + s.ChuNhiemDT + "'  WHERE MaDT=" + s.MaDT;
            DataProvider.Instance.ExecuteDB(query);
            Console.WriteLine("Ham nay da duoc goi");
            Console.WriteLine(DataProvider.Instance.ExecuteDB(query).ToString());
        }
        public void DeleteSV(string mdt)
        {
            string query = "DELETE FROM DeTai WHERE MaDT = " + mdt;
            DataProvider.Instance.ExecuteDB(query);


        }
        public List<DeTai> GetDTSearch(string tenDT)
        {
            List<DeTai> listDT = new List<DeTai>();
            string query = "select * from DeTai where TenDT ='" + tenDT + "'";
            foreach (DataRow row in DataProvider.Instance.GetRecords(query).Rows)
            {
                listDT.Add(GetDT(row));
            }
            Console.WriteLine(DataProvider.Instance.GetRecords(query).ToString());
            Console.WriteLine("Da vao day");
            return listDT;
            
        }
        public void AddDT(DeTai d)
        {
            string query = "INSERT INTO DeTai(MaDT,TenDT,TinhTrang,MaCapDT,NgayNhanDT,ChuNhiemDT) VALUES(" + d.MaDT + ",'" + d.TenDT + "','" + d.TinhTrang + "'," + d.MaCapDT + ",'" + d.NgayNhanDT + "','" + d.ChuNhiemDT + "')";
            DataProvider.Instance.ExecuteDB(query);

        }

    }
}
