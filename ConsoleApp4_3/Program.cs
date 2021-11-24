using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Run();
        }

        public static void Run()
        {

            double a = 0;
            double b = 0;
            double c = 0;

            Console.WriteLine("Сторону прямоугольника A");
            string strA = Console.ReadLine(); 
            Console.WriteLine("Сторону прямоугольника B");
            string strB = Console.ReadLine();
            Console.WriteLine("Сторону квадрата C");
            string strC = Console.ReadLine();                  
               
                try
            {
                    a = Convert.ToDouble(strA);
                    b = Convert.ToDouble(strB);
                    c = Convert.ToDouble(strC);
                    
            }
                catch
            {
                Console.WriteLine("Не число");
                Run();
                Environment.Exit(0);
            }

            int countA = 0;
            double leftA = a;
            while (c<=leftA)
            {
                leftA -= c;
                countA++;
            }

            int countB = 0;
            double leftB = b;
            while (c<=leftB)
            {
                leftB -= c;
                countB++;
            }

            int count = 0;
            int row = 1;
            while (row<= countB)
            {
                row++;
                count += countA;
            }

            Console.WriteLine("В прямоугольник со сторонами " + a + " и " + b + " вписывается " + count + " квадратов со стороной " + c);
            Console.ReadLine();
            Run();
            Environment.Exit(0);
        }
    }
}

