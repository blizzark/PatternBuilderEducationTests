﻿

using PatternBuilderEducationTests;

class Program
{
    static void Main()
    {
        Console.WriteLine("Состав бургера:");

        var burger = new BurgerBuilder();

        var cookBurger = new CookerDirector(burger);

        cookBurger.BildBurger();

        Console.WriteLine(burger.GetBurger());
    }
}