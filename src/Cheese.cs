using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace src
{
    internal class Cheese: IComparable
    {
        internal string brand;

        internal string manufacturer;

        internal int fatrep;

        internal Cheese(string brand, string manufacturer, int fatrep)
        {
            this.brand = brand;

            this.manufacturer = manufacturer;

            this.fatrep = fatrep;

        }
        public int CompareTo(object o)
        {
            Cheese c = o as Cheese;

            if (c != null)
            {

                int result = manufacturer.CompareTo(c.manufacturer);


                if (result != 0) return result;

                return fatrep.CompareTo(c.fatrep);

            }
            else
            {
                throw new Exception("Ошибка сравнения!!!");
            }

        }
    }
}
