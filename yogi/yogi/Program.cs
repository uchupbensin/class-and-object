using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classobj
{
    public class Program
    {
        public static void Main()
        {
            Mobil mobil1 = new Mobil();

            mobil1.Warna = "Biru";
            mobil1.JumlahPintu = 2;
            mobil1.Merk = "Porsche";
            mobil1.Model = "911 GT2 RS";
            mobil1.TahunKeluar = 2023;

            mobil1.Gas(293);
            mobil1.Klakson("Tiin");
            mobil1.Tampilkaninfo();



            Console.ReadLine();
        }
    }



}