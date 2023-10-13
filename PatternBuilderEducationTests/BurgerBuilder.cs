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
            _burger.Bun = new() { new Bun { Sort = "Белая", Form = "Круглая" } };
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
            _burger.Onion = new() { new Onion { Sort = "Красный" } };
            return this;

        }
        public IBurgerBuilder SetLettuceLeaves()
        {
            _burger.LettuceLeaves = new() { new LettuceLeaves { Sort = "Айсберг" } };
            return this;

        }

        public IBurgerBuilder SetCheese()
        {
            _burger.Cheese = new() { new Cheese { Sort = "Пармезан" } };
            return this;

        }
        public IBurgerBuilder SetCutlet()
        {
            _burger.Cutlet = new() { new Cutlet { Sort = "Говядина" } };
            return this;

        }
        public IBurgerBuilder SetCucumbers()
        {
            _burger.Cucumbers = new() { new Cucumbers { Sort = "Маринованные" } };
            return this;

        }
        public IBurgerBuilder SetTomatoes()
        {
            _burger.Tomatoes = new() { new Tomatoes { Sort = "Розовые" } };
            return this;

        }

        public Burger GetBurger()
        {
            return _burger;
        }
    }
}
