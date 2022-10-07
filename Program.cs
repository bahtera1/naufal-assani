using System;

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
				if (n<=20)
					break;
				else
					Console.WriteLine("\nArray dapat mempunyai maksimal 20 elemen.\n");
			}
			Console.ReadLine("");
			Console.ReadLine(".............");
			Console.ReadLine("Masukan Elemen array");
			Console.ReadLine(".....................");

			// pengguna memasukan elemen  pada array
			for (int i = 0; i < n; i++)
			{
				Console.Write("<" + (i + 1) + "> ");
				string s1 = Console.ReadLine();
				a[i] = Int32.Parse(s1);
			}
		}
		public void display()
        {
			//menampilkan array yang tersusun
			Console.WriteLine("");
			Console.WriteLine(.............);
			Console.WriteLine("elemen array telah tersusun");
			Console.WriteLine("....................");
			for (int j = 0; j<0; j++ )
            {
				Console.WriteLine(a[j]);
            }
			Console.WriteLine("");
        }

		public void BubbleSortArray()
        {
			for(int i= 1,i<n; i++)//for n-1 passes
            {
				//pada pass i, bandingkan n-1 elemen pertama denga elemen selanjutnya
				for (int j=0; j<n; j++)
                {
					if (a[j] > a[j+1])//jika elemen tidak dalm urutan yang benar
                    {
						//tukar elemen
						int temp;
						temp = a[j];
						a[j] = a[j+1];
						a[j+1] = temp;
                    }
                }
            }
        }

	};

}