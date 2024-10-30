using System;

namespace _07_ForeachLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Foreach Döngüsü

            //string[] cities = { "milano", "roma", "köln", "ankara", "istanbul", "milas" };

            //foreach (var item in cities)
            //{
            //    Console.WriteLine(item);
            //}

            //int[] numbers = { 45, 78, 985, 635, 74, 11, 22, 33, 41, 205, 6578, 10395 };

            //foreach (var item in numbers)
            //{
            //    if (item % 2 == 0) Console.WriteLine(item);
            //}

            //int[] numbers = { 45, 78, 985, 635, 74, 11, 22, 33, 41, 205, 6578, 10395 };

            //int total = 0;

            //foreach (var item in numbers)
            //{
            //    total += item;
            //}
            //Console.WriteLine(total);

            //List<int> numbers = new List<int>()
            //{
            //    1, 2, 3, 4, 5,8
            //};

            //foreach (var item in numbers)
            //{
            //    Console.WriteLine(item);
            //}

            //string word = "Merhaba";
            //foreach (char item in word)
            //{
            //    Console.WriteLine(item);
            //}



            #endregion

            #region Örnek Sınav Sistemi Uygulaması

            Console.Write("******C# Eğitim Kampı Sınav Uygulaması ********");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("------------------------");
            Console.Write("Sınıfınızda kaç öğrenci var? : ");
            int studentCount = int.Parse(Console.ReadLine());
            Console.WriteLine("-------------------------");

            string[] studentNames = new string[studentCount];
            double[] studentExamAvg = new double[studentCount];

            for (int i = 0; i < studentCount; i++)
            {
                Console.Write($"{i + 1}. öğrencinin ismini giriniz: ");
                studentNames[i] = Console.ReadLine();

                double totalExamResult = 0;

                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"{studentNames[i]} isimli öğrencinin {j + 1}.sınav notunu giriniz: ");
                    double value = double.Parse(Console.ReadLine());
                    totalExamResult += value;
                }
                Console.WriteLine();
                studentExamAvg[i] = totalExamResult / 3;
            }

            for (int i = 0; i < studentCount; i++)
            {
                Console.WriteLine("---------------------");

                Console.WriteLine($"{studentNames[i]} adlı öğrencinin ortalaması: {studentExamAvg[i]}");

                if (studentExamAvg[i] >= 50)
                {
                    Console.WriteLine($"{studentNames[i]} adlı öğrenci dersi geçti");
                }
                else
                {
                    Console.WriteLine($"{studentNames[i]} adlı öğrenci dersten kaldı");
                }

                Console.WriteLine("---------------------");
            }

            #endregion

            Console.ReadLine();
        }
    }
}
