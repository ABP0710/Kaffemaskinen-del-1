using Kaffemaskinen_del_1.Classes;

namespace Kaffemaskinen_del_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CoffeeMaker coffeeMaker = new CoffeeMaker(true);
            Console.WriteLine(coffeeMaker.OnOff());
            Console.WriteLine(coffeeMaker.WaterAdded(8));
            Console.WriteLine(coffeeMaker.AddFilter(new Filter("coffee", 7)));
            Console.WriteLine(coffeeMaker.filterHolder.filter.FilterToString());
            Console.WriteLine(coffeeMaker.OnOff());
            Console.WriteLine(coffeeMaker.Brew());
            Console.WriteLine(coffeeMaker.OnOff());
            Console.WriteLine(coffeeMaker.CleanHolder());
            Console.WriteLine();


            Console.WriteLine(coffeeMaker.OnOff());
            Console.WriteLine(coffeeMaker.WaterAdded(10));
            Console.WriteLine(coffeeMaker.AddFilter(new Filter("Tea", 2)));
            Console.WriteLine(coffeeMaker.filterHolder.filter.FilterToString());
            Console.WriteLine(coffeeMaker.OnOff());
            Console.WriteLine(coffeeMaker.Brew());
            Console.WriteLine(coffeeMaker.OnOff());
            Console.WriteLine(coffeeMaker.CleanHolder());
            Console.WriteLine();


            Console.WriteLine(coffeeMaker.OnOff());
            Console.WriteLine(coffeeMaker.WaterAdded(1));
            Console.WriteLine(coffeeMaker.AddFilter(new Filter("espresso", 2)));
            Console.WriteLine(coffeeMaker.filterHolder.filter.FilterToString());
            Console.WriteLine(coffeeMaker.OnOff());
            Console.WriteLine(coffeeMaker.Brew());
            Console.WriteLine(coffeeMaker.OnOff());
            Console.WriteLine(coffeeMaker.CleanHolder());
            Console.WriteLine();
        }
    }
}