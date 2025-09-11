using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleBaseProject
{
    internal class dataUmur
    {

        static void Main(string[] args)
        {
            Console.Write("Masukan nama Anda: ");
            string nama = Console.ReadLine();

            Console.Write("Masukan umur Anda: ");
            int umur = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Halo   " + nama + " ,umur Anda " + umur + "tahun, ");
            Console.ReadKey();

        }
    }
}
