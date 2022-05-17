using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace src
{
    class MilkFarm
    {
        int mProducts;


        internal MilkFarm(int _mProducts)
        {
            this.mProducts = _mProducts;


        }

        internal void Zapolnim()
        {
            string brand;

            string manufacturer;

            int fatPer;

            for (int i = 0; i < this.mProducts; i++)
            {
                Console.WriteLine("Марка:");

                brand = Console.ReadLine();

                Console.WriteLine("Производитель:");

                manufacturer = Console.ReadLine();

                Console.WriteLine("Процент жирности:");

                fatPer = Convert.ToInt32(Console.ReadLine());


            }
        }
    }
}
