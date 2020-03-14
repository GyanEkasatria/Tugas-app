using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
			char pilihan;
			Console.WriteLine("Kalkulator Sederhana");
			Console.WriteLine("____________________");
			Console.WriteLine("Masukkan Pilihan");
			Console.WriteLine("____________________");
			Console.WriteLine("(A)Penjumlahan (C)Perkalian");
			Console.WriteLine("(B)Pengurangan (D)Pembagian");
			Console.WriteLine("Pilihan Anda : ");
			pilihan = Convert.ToChar(Console.ReadLine());
			Console.WriteLine("\n");

			Console.Title = "Aplikasi Kalkulator";

			Console.Write("Inputkan Nilai a = ");
			int a = int.Parse(Console.ReadLine());

			Console.Write("Inputkan Nilai b = ");
			int b = Convert.ToInt32(Console.ReadLine());

			if (pilihan == 'A' || pilihan == 'a')
			{
				Console.WriteLine("Hasil Penjumlahan " + a + " + " + b + " = " + Penjumlahan(a, b));
			}
			else if (pilihan == 'B' || pilihan == 'b')
			{
				Console.WriteLine("Hasil Pengurangan {0} - {1} = {2} ", a, b, Pengurangan(a, b));
			}
			else if (pilihan == 'C' || pilihan == 'c')
			{
				Console.WriteLine("Hasil Perkalian {0} * {1} = {2}", a, b, Perkalian(a, b));
			}
			else if (pilihan == 'D' || pilihan == 'd') 
			{
				Console.WriteLine("Hasil Pembagian {0} / {1} = {2}", a, b, Pembagian(a, b));
			}
	    Console.WriteLine("\nTekan sembarang tombol untuk keluar");
		Console.ReadKey();
		}
		static int Penjumlahan(int a, int b)
		{
			return a + b;
		}
		static int Pengurangan(int a, int b)
		{
			return a - b;
		}
		static int Perkalian(int a, int b)
		{
			return a * b;
		}
		static int Pembagian(int a, int b)
		{
			return a / b;
		}
	}
}