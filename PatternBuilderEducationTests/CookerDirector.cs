namespace PatternBuilderEducationTests
{
    public class CookerDirector
    {
        private readonly IBurgerBuilder Burger;

        public CookerDirector(IBurgerBuilder burger)
        {
            Burger = burger;
        }

        public void BildBurger()
        {
            Parallel.Invoke(
                () => Burger.SetBun(),
                () => Burger.SetCutletBeef(),
                () => Burger.SetSauceKetchap(),
                () => Burger.SetSauceMustard(),
                () => Burger.SetLettuceLeaves(),
                () => Burger.SetCucumbers(),
                () => Burger.SetTomatoes(),
                () => Burger.SetOnion()
                );








        }


    }
}
