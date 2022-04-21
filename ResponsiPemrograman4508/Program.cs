using ResponsiPemrograman4508;
using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Karyawan paijo = new Karyawan("1234", "Paijo", 1000000);
            Karyawan jono = new Karyawan("5678", "Jono", 2000000);

            Console.WriteLine("No  Nik/Nama           GajiBulanan");
            Console.WriteLine("==================================");
            Console.WriteLine("1. " + paijo.Nik+ "/" + paijo.Nama + "           "+ paijo.GajiBulanan);
            Console.WriteLine("2. " + jono.Nik + "/" + jono.Nama + "            " + jono.GajiBulanan);

            Console.WriteLine("");
            Console.WriteLine("Kenaikan Gaji 10%");
            Console.WriteLine("No  Nik/Nama           GajiBulanan");
            Console.WriteLine("==================================");
            paijo.GajiBulanan = (float)(paijo.GajiBulanan + (0.1 * paijo.GajiBulanan));
            Console.WriteLine("1. " + paijo.Nik + "/" + paijo.Nama + "           " + paijo.GajiBulanan);
            jono.GajiBulanan = (float)(jono.GajiBulanan + (0.1 * jono.GajiBulanan));
            Console.WriteLine("2. " + jono.Nik + "/" + jono.Nama + "            " + jono.GajiBulanan);
        }
    }
}