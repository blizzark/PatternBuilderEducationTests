namespace PatternBuilderEducationTests
{
    public class BurgerBuilder : IBurgerBuilder
    {
        private readonly Burger _burger;
        public BurgerBuilder()
        {
            _burger = new();
        }
        public void SetBun()
        {
            _burger.Bun = new() { Sort = "Белая", Form = "Круглая" };
        }
        public void SetSauce()
        {
            _burger.Sauce = new List<Sauce>() {
                new Sauce() { Sort = "Горчица" },
                new Sauce() { Sort = "Кетчуп" },
                new Sauce() { Sort = "Майонез" }};
        }
        public void SetOnion()
        {
            _burger.Onion = new() { Sort = "Красный" };
        }
        public void SetLettuceLeaves()
        {
            _burger.LettuceLeaves = new() { Sort = "Айсберг" };
        }
        public void SetCutlet()
        {
            _burger.Cutlet = new() { Sort = "Говядина" };
        }
        public void SetCucumbers()
        {
            _burger.Cucumbers = new() { Sort = "Маринованные" };
        }
        public void SetTomatoes()
        {
            _burger.Tomatoes = new() { Sort = "Розовые" };
        }

        public Burger GetBurger()
        {
            return _burger;
        }
    }
}
