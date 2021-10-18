using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task2Lab8
{
    class Program
    {
        static void Main(string[] args)
        {
            //Программно создайте текстовый файл и запишите в него 10 случайных чисел. Затем программно откройте созданный файл, рассчитайте сумму чисел в нем, ответ выведите на консоль.            
            const int n = 10;
            string path = "FindSum.txt";
            StreamWriter sw = File.CreateText(path);
            Random rnd = new Random();
            for (int i = 0; i < n; i++)
            {
                sw.Write("{0} ", rnd.Next(100));
            }
            sw.Close();
            StreamReader sr = new StreamReader(path);
            string number = "";
            number = sr.ReadLine();
            Console.WriteLine(number);
            sr.Close();
            Console.WriteLine();
            string masTrim = number.Trim(' ');
            string[] massive = masTrim.Split();
            foreach (string s in massive)
            {
                Console.WriteLine("{0}", s);
            }
            int S;
            S = massive.Count();
            int[] mas = new int[S];            
            for (int i = 0; i < S; i++)
            {
                mas[i] = int.Parse(massive[i]);
            }
            int sum = 0;
            for (int i = 0; i < S; i++)
            {
                sum += mas[i];
            }
            Console.WriteLine("Сумма чисел равна {0}", sum);
            Console.ReadKey();
        }
    }
}
