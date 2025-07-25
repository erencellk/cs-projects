using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_ForEachLoop
{
    internal class Program7
    {

        static void Main(string[] args)
        {




            Console.WriteLine("Sınav Uygulaması");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("------------------------------");
            Console.Write("Sınıfınızda kaç öğrenci var : ");
            int ogrenciSayisi = int.Parse(Console.ReadLine());
            Console.WriteLine("------------------------------");


            string[] studentNames = new string[ogrenciSayisi];
            double[,] studentExamAvg = new double[ogrenciSayisi, 3];


            for (int i = 0; i < ogrenciSayisi; i++)
            {
                Console.Write($"{i + 1}. öğrencinin ismini giriniz : ");
                studentNames[i] = Console.ReadLine();

            }


            // her öğrenci icin 3 sınav girişi


            for (int k = 0; k < studentNames.Length; k++)
            {
                Console.WriteLine();
                Console.WriteLine($"{studentNames[k]} için gerekli notlari giriniz : ");
                Console.WriteLine();
                double totalExamResult = 0;
                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"{j + 1}. sınav notunuz giriniz : ");
                    studentExamAvg[k, j] = double.Parse(Console.ReadLine());
                    totalExamResult += studentExamAvg[k, j];
                }

                double sonNot = totalExamResult /= 3;

                Console.WriteLine($"{studentNames[k]} öğrencinin not ortalaması : " + sonNot);
            }
        }


   

    }
}

