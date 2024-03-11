using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class CapDeTai
    {
        private int _MaCapDT;
        private String _TenCapDT;

        public int MaCapDT { get => _MaCapDT; set => _MaCapDT = value; }
        public string TenCapDT { get => _TenCapDT; set => _TenCapDT = value; }
        public CapDeTai(int macapdt,String tencapdt) { 
            this.MaCapDT = macapdt;
            this.TenCapDT = tencapdt;
        }
    }
}
