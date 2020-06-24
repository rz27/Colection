using System;
using System.Collections.Generic;

namespace Colection
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Tugas Lab 8 ";

            GajikaryawanTetap GajikaryawanTetap = new GajikaryawanTetap();
            GajikaryawanTetap.Nik = "123456789";
            GajikaryawanTetap.Nama = "Feizal Reza";
            GajikaryawanTetap.Gajibulanan = 5000000;

            Gajikaryawanharian gajikaryawanharian = new Gajikaryawanharian();
            gajikaryawanharian.Nik = "123678";
            gajikaryawanharian.Nama = "Aminudin";
            gajikaryawanharian.Jamkerja = 8;
            gajikaryawanharian.UpahPerjam = 200000;

            Sales sales = new Sales();
            sales.Nik = "1234567";
            sales.Nama = "Ami";
            sales.JmlhP = 30;
            sales.Komisi = 45000;

            List<Gajikaryawan> gajikaryawans = new List<Gajikaryawan>();
            gajikaryawans.Add(GajikaryawanTetap);
            gajikaryawans.Add(gajikaryawanharian);
            gajikaryawans.Add(sales);

            int noUrut = 1;

            foreach ( Gajikaryawan gajikaryawan in gajikaryawans)
            {
                Console.WriteLine("{0}. Nik : {1}, Nama : {2}, Gaji : Rp.{3 : 0}",
                    noUrut, gajikaryawan.Nik, gajikaryawan.Nama, gajikaryawan.Gaji());

                noUrut++;
            }


        }
    }
}
