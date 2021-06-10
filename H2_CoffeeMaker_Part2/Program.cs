using System;

namespace H2_CoffeeMaker_Part2
{
    class Program
    {
        static void Main(string[] args)
        {
            CoffeeMaker siemensCoffeeMaker = new CoffeeMaker("", 0,0,0, false, true, false);

            ((ICoffee)siemensCoffeeMaker).AddCoffeeAsIngredient();
            siemensCoffeeMaker.AddWater();
            siemensCoffeeMaker.AddIngredient();
            siemensCoffeeMaker.AddFilter();
            siemensCoffeeMaker.AddIngredient();
            siemensCoffeeMaker.TurnOn();
            siemensCoffeeMaker.BrewHotBeverage();
            siemensCoffeeMaker.TurnOff();

            ((ITea)siemensCoffeeMaker).AddTeaAsIngredient();
            siemensCoffeeMaker.AddWater();
            siemensCoffeeMaker.AddIngredient();
            siemensCoffeeMaker.TurnOn();
            siemensCoffeeMaker.BrewHotBeverage();
            siemensCoffeeMaker.TurnOff();
        }
    }
}
