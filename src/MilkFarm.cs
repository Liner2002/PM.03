using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace src
{
    internal class MilkFarm
    {
        int mProducts;


        internal Cheese[] chProducts;

        internal MilkFarm(int _mProducts)
        {
            this.mProducts = _mProducts;

            chProducts = new Cheese[_mProducts];

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

                this.chProducts[i] = new Cheese(brand, manufacturer, fatPer);
            }
        }
        internal void Sortirujem()
        {

            Array.Sort(this.chProducts);

        }
        internal void SaveasFile()
        {

            using (StreamWriter file = new StreamWriter("finalresult.txt", false, Encoding.UTF8))
            {

                foreach (Cheese c in this.chProducts)
                {

                    file.WriteLine(c.MakeString());

                }
            }

        }
    }
}
