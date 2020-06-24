using System;
namespace Colection
{
    public class GajikaryawanTetap : Gajikaryawan
    {
        public override string Nik { get; set; }
        public override string Nama { get; set; }
        public double Gajibulanan { get; set; }
        public override double Gaji() => Gajibulanan;

    }
}
