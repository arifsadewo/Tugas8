using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Istu Arif Sadewo 19.11.2654 :)
namespace TugasLab8_Collection
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "TugasLab8 - Polymorphism, Inheritance, Abstraction and Collection";

            KaryawanTetap karyawanTetap = new KaryawanTetap();
            karyawanTetap.Nik = "123-234-345";
            karyawanTetap.Nama = "Michael Suyama";
            karyawanTetap.GajiBulanan = 4000000;

            KaryawanHarian karyawanHarian = new KaryawanHarian();
            karyawanHarian.Nik = "123-321-346";
            karyawanHarian.Nama = "Laura Callahan";
            karyawanHarian.JumlahJamKerja = 8;
            karyawanHarian.UpahPerJam = 13000;

            Sales sales = new Sales();
            sales.Nik = "123-333-347";
            sales.Nama = "Andrew Fuller";
            sales.JumlahPenjualan = 30;
            sales.Komisi = 45000;

            List<Karyawan> listKaryawan = new List<Karyawan>();

            listKaryawan.Add(karyawanTetap);
            listKaryawan.Add(karyawanHarian);
            listKaryawan.Add(sales);

            int NoUrut = 1;
            foreach (Karyawan karyawan in listKaryawan)
            {
                Console.WriteLine("{0}. Nik: {1}, Nama: {2}, Gaji: {3:N0}", NoUrut, karyawan.Nik, karyawan.Nama, karyawan.Gaji());
                NoUrut++;
            }
            Console.ReadKey();
        }
    }
}
