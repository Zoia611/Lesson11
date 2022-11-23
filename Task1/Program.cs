using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        struct Function
        {
            static void Main(string[] args)
            {
                Console.WriteLine("В уравнении 0 = k*x -b, задайте коэффициенты k и b");
                double k = Convert.ToDouble(Console.ReadLine());
                double b = Convert.ToDouble(Console.ReadLine());
                Function function = new Function(k, b);
                Console.WriteLine("Решение: {0}", function.Root());
                Console.ReadKey();
            }
        }
        
    }
}
