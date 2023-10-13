namespace PatternBuilderEducationTests
{
    public interface IBurgerBuilder
    {
        public IBurgerBuilder SetBun(); // можно разделить также на белый/чёрный, круглая булка или длинная.. 
        public IBurgerBuilder SetSauceKetchap();
        public IBurgerBuilder SetSauceMustard();
        public IBurgerBuilder SetSauceMayonnaise();

        public IBurgerBuilder SetOnion(); // можно разделить также на белый/красный
        public IBurgerBuilder SetLettuceLeaves(); // можно разделить также на разные виды салатов
        public IBurgerBuilder SetCutletBeef();
        public IBurgerBuilder SetCutletChicken();

        public IBurgerBuilder SetCheese(); // можно разделить также на разные виды сыров 
        public IBurgerBuilder SetCucumbers(); // и т.д.
        public IBurgerBuilder SetTomatoes();

        public Burger GetBurger();
    }
}
