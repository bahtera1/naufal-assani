﻿using System;

namespace Bubble_Sort
{
	class program
	{
		//deklarasi array int dengan ukuran 20
		private int[] a = new int[20];

		//deklarasi variabel int untuk menyimpan banyaknya data pada array
		private int n;

		//fungsi /method untuk menerima masukan
		public void read()
		{
			//menerima angak untuk menentukan banyaknya data yang disimpan pada array
			while (true)
			{
				Console.Write("masukan banyaknya elemen pada array :");
				string s = Console.ReadLine();
				n = Int32.Parse(s);
				if (n <= 20)
					break;
				else
					Console.ReadLine("\nArray dapat mempunyai maksimal 20 elemen.\n");


			}
			Console.ReadLine("");
			Console.ReadLine(".............");
			Console.ReadLine("Masukan Elemen array");
			Console.ReadLine(".....................");

			// pengguna memasukan elemen  pada array
			for (int i = 0; i < n; i++)
			{
				Console.Write("<" + (i + 1) + "> ");
				string s1 = Console.Readline();
				a[i] = Int32.Parse(s1);
			}
		}




	};

}