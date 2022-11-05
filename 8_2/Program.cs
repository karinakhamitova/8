using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"D:\С#\1.txt";
            int sum = 0;
            Random random = new Random();
            using (StreamWriter sw = new StreamWriter(path, false))
            {
                for (int i = 0; i < 10; i++)
                {
                    sw.WriteLine(random.Next(-1000,1000));
                }
            }
            using (StreamReader sr = new StreamReader(path))
            {
                for (int i = 0; i < 10; i++)
                {
                   sum+= Convert.ToInt32(sr.ReadLine());
                }
            }
            Console.WriteLine(sum);
            Console.ReadKey();


        }
    }
}
