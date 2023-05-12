using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Kaffemaskinen_del_1.Classes
{
    public class CoffeeMaker : Machine
    {
        public string ingredientInFilter { get; set; }
        public int waterAmountAdded { get; set; }

        public FilterHolder filterHolder { get; set; } = new FilterHolder();

        public CoffeeMaker(bool on) : base(on)
        {
            
        }


        /// <summary>
        /// adds a filter and takes the parameters for what ingrediens there is in the filter
        /// </summary>
        /// <param name="filter"></param>
        /// <returns></returns>
        public string AddFilter(Filter filter)
        {
            ingredientInFilter = filter.ingredientName;
            return filterHolder.InsertFilter(filter);
        }

        /// <summary>
        /// clean the filter holder
        /// </summary>
        /// <returns></returns>
        public string CleanHolder()
        {
            return filterHolder.emptyHolder();
        }

        /// <summary>
        /// used to add the amount of water
        /// </summary>
        /// <param name="waterAdded"></param>
        /// <returns></returns>
        public string WaterAdded(int waterAdded)
        {
            waterAmountAdded = waterAdded;
            return $"There is added {waterAmountAdded} cups of water to the machine";
        }

        /// <summary>
        /// tells the amount of and what the machine is makeing
        /// </summary>
        /// <returns></returns>
        public string Brew()
        {
            return $"Now brewing {waterAmountAdded} cups of good warm {ingredientInFilter}";
        }
     

    }
}
