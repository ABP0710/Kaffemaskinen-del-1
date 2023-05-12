using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kaffemaskinen_del_1.Classes
{
    public class Filter
    {
        public string ingredientName { get; set; }
        public int ingredientAmount { get; set; }

        public Filter(string ingredientName, int ingredientAmount)
        {
            this.ingredientName = ingredientName;
            this.ingredientAmount = ingredientAmount;
        }

        public string FilterToString()
        {
            return $"The filter is filled with {ingredientAmount} spoons of {ingredientName}";
        }
    }
}
