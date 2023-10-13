namespace PatternBuilderEducationTests
{
    public class BurgerBuilder : IBurgerBuilder
    {
        private readonly Burger _burger;
        public BurgerBuilder()
        {
            _burger = new();
        }
        public IBurgerBuilder SetBun()
        {
            _burger.Bun = new() { Sort = "Белая", Form = "Круглая" };
            return this;
        }
        public IBurgerBuilder SetSauce()
        {
            _burger.Sauce = new List<Sauce>() {
                new Sauce() { Sort = "Горчица" },
                new Sauce() { Sort = "Кетчуп" },
                new Sauce() { Sort = "Майонез" }};
            return this;

        }
        public IBurgerBuilder SetOnion()
        {
            _burger.Onion = new() { Sort = "Красный" };
            return this;

        }
        public IBurgerBuilder SetLettuceLeaves()
        {
            _burger.LettuceLeaves = new() { Sort = "Айсберг" };
            return this;

        }
        public IBurgerBuilder SetCutlet()
        {
            _burger.Cutlet = new() { Sort = "Говядина" };
            return this;

        }
        public IBurgerBuilder SetCucumbers()
        {
            _burger.Cucumbers = new() { Sort = "Маринованные" };
            return this;

        }
        public IBurgerBuilder SetTomatoes()
        {
            _burger.Tomatoes = new() { Sort = "Розовые" };
            return this;

        }

        public Burger GetBurger()
        {
            return _burger;
        }
    }
}
