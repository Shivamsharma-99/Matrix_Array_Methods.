
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Greet()
        {
            Console.WriteLine(" Welcome bro!");
        }
        public void name()
        { 
            Console.WriteLine(" Rahul !"); 
        }
        public static void msg()
        {
            Console.WriteLine(" This is last method !");
        }
        static void Main(string[] args)
        {
            Greet();

            Program obj1 = new Program();
            obj1.name();

            Program.msg();

            //int[,] arr = new int[,] { { 12,45,78},{ 12,45,78},{ 12,45,78}, };
            //Console.WriteLine("Printing Matrix: ");
            //int m = 2;
            //int n = 2;
            //for (int i = 0; i <= m; i++)
            //{
            //    for (int j = 0; j <= n; j++)
            //    {
            //        Console.Write(arr[i, j] + "\t");
            //    }
            //    Console.WriteLine();
            //}
            Console.ReadLine();
        }
    }
}
