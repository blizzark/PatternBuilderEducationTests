namespace PatternBuilderEducationTests
{
    public interface IBurgerBuilder
    {
        public IBurgerBuilder SetBun();
        public IBurgerBuilder SetSauce();
        public IBurgerBuilder SetOnion();
        public IBurgerBuilder SetLettuceLeaves();
        public IBurgerBuilder SetCutlet();
        public IBurgerBuilder SetCucumbers();
        public IBurgerBuilder SetTomatoes();

        public Burger GetBurger();
    }
}
