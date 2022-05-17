using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace src
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            Console.WriteLine("Введите количество продуктов:");

            int productsMANY = Convert.ToInt32(Console.ReadLine());
        }
    }
}
