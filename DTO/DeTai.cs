using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DeTai
    {
        private int _MaDT;
        private String _TenDT;
        private bool? _TinhTrang;
        private int _MaCapDT;
        private DateTime? _NgayNhanDT;
        private String _ChuNhiemDT;

        public int MaDT { get => _MaDT; set => _MaDT = value; }
        public string TenDT { get => _TenDT; set => _TenDT = value; }
        public bool? TinhTrang { get => _TinhTrang; set => _TinhTrang = value; }
        public int MaCapDT { get => _MaCapDT; set => _MaCapDT = value; }
        public DateTime? NgayNhanDT { get => _NgayNhanDT; set => _NgayNhanDT = value; }
        public string ChuNhiemDT { get => _ChuNhiemDT; set => _ChuNhiemDT = value; }
       
        public DeTai(int madt,String tendt,bool? tinhtrang,int macapdt,DateTime? ngaynhandt,String chunhiemdt)
        {
            this.MaDT= madt;
            this.TenDT= tendt;
            this.TinhTrang= tinhtrang;
            this.MaCapDT= macapdt;
            this.NgayNhanDT= ngaynhandt;
            this.ChuNhiemDT= chunhiemdt;
        }

    }
}
