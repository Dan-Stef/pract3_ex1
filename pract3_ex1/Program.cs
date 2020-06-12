using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pract3_ex1
{
    class Program
    {
        public static int Func(int x)
        {
            x = Math.Abs(x);
            if (x < 10)
                throw new Exception("Число однозначное");
            else
                return x / 10 % 10;
        }

        public static int FindFx(int a, int b, int c, int z)
        {
            return z = Func(a) + Func(b) - Func(c);
        }

        static void Main(string[] args)
        {
            int x;
            Console.WriteLine("Enret the number x: ");
            x = Convert.ToInt32(Console.ReadLine());
            Func(x);
            Console.WriteLine(Func(x));
            int z = 0;
            Console.WriteLine("Enret the number a: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enret the number b: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enret the number c: ");
            int c = Convert.ToInt32(Console.ReadLine());
            FindFx(a, b, c, z);
            Console.WriteLine("The amount is: " + FindFx(a,b,c,z));
            

            Console.ReadKey();
        }
    }
}
