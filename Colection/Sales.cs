using System;
namespace Colection
{
    public class Sales : Gajikaryawan
    {
        public override string Nik {get ; set;}
        public override string Nama { get; set; }
        public double JmlhP { get; set; }
        public double Komisi { get; set; }
        public override double Gaji() => JmlhP * Komisi;
    }
}
