using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResponsiPemrograman4508
{
    internal class Karyawan
    {
        public string Nik{get; set;}
        public string Nama { get; set; }
        public float GajiBulanan { get; set; }

        public Karyawan (string Nik, string Nama, float GajiBulanan)
        {
            this.Nik = Nik;
            this.Nama = Nama;
            if(GajiBulanan > 0)
            {
                this.GajiBulanan = GajiBulanan;
            } else 
            {
                this.GajiBulanan = 0;
            }
        }

    }
}
