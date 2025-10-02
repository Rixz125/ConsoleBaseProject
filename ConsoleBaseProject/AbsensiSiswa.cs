using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleBaseProject
{
    internal class AbsensiSiswa
    {
        static void Main(string[] args)
        {
            Console.Write("Masukkan jumlah siswa: ");
            int jumlah = int.Parse(Console.ReadLine());

            string[] nama = new string[jumlah];
            string[] status = new string[jumlah];

            for (int i = 0; i < jumlah; i++)
            {
                Console.Write($"Nama siswa ke-{i + 1}: ");
                nama[i] = Console.ReadLine();

                Console.Write("Status (Hadir/Tidak Hadir): ");
                status[i] = Console.ReadLine();
            }

            Console.WriteLine("\n=== Rekap Absensi ===");
            for (int i = 0; i < jumlah; i++)
            {
                Console.WriteLine($"{nama[i]} - {status[i]}");
            }
        }
    }
}
