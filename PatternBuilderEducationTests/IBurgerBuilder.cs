namespace PatternBuilderEducationTests
{
    public interface IBurgerBuilder
    {
        public void SetBun();
        public void SetSauce();
        public void SetOnion();
        public void SetLettuceLeaves();
        public void SetCutlet();
        public void SetCucumbers();
        public void SetTomatoes();

        public Burger GetBurger();
    }
}
