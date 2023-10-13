

using PatternBuilderEducationTests;

class Program
{
    static async Task Main()
    {
        Console.WriteLine("Заказано 2 бургера");

        var burger = new BurgerBuilder();

        var cookBurger = new CookerDirector(burger);

       

       

        var burgerTwo = new BurgerBuilder();

        var cookBurgerTwo = new CookerBigBurgerDirector(burgerTwo);

        await cookBurger.BildBurger();
        cookBurgerTwo.BildBurger();

        Console.WriteLine("Состав первого готового бургера:");
        Console.WriteLine(burger.GetBurger());
        Console.WriteLine("\n\nСостав второго готового бургера:");
        Console.WriteLine(burgerTwo.GetBurger());
    }
}