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
            Thread.Sleep(1000); // имитация работы (взятие со склада, обжарка, назрезка и т.д.)
            if (_burger.Bun == null)
                _burger.Bun = new() { new Bun { Sort = "Белая", Form = "Круглая" } };
            else
                _burger.Bun.Add(new Bun { Sort = "Белая", Form = "Круглая" });

            return this;
        }
        public IBurgerBuilder SetSauceKetchap()
        {
            Thread.Sleep(1000); // имитация работы (взятие со склада, обжарка, назрезка и т.д.)

            if (_burger.Sauce == null)
                _burger.Sauce = new List<Sauce>() {new Sauce() { Sort = "Кетчуп" }};
            else
                _burger.Sauce.Add(new Sauce() { Sort = "Кетчуп" });
            return this;

        }

        public IBurgerBuilder SetSauceMustard()
        {
            Thread.Sleep(1000); // имитация работы (взятие со склада, обжарка, назрезка и т.д.)

            if (_burger.Sauce == null)
                _burger.Sauce = new List<Sauce>() { new Sauce() { Sort = "Горчица" } };
            else
                _burger.Sauce.Add(new Sauce() { Sort = "Горчица" });
            return this;

        }

        public IBurgerBuilder SetSauceMayonnaise()
        {
            Thread.Sleep(1000); // имитация работы (взятие со склада, обжарка, назрезка и т.д.)

            if (_burger.Sauce == null)
                _burger.Sauce = new List<Sauce>() { new Sauce() { Sort = "Майонез" } };
            else
                _burger.Sauce.Add(new Sauce() { Sort = "Майонез" });
            return this;

        }
        public IBurgerBuilder SetOnion()
        {
            Thread.Sleep(1000); // имитация работы (взятие со склада, обжарка, назрезка и т.д.)

            if (_burger.Onion == null)
                _burger.Onion = new() { new Onion { Sort = "Красный" } };
            else
                _burger.Onion.Add(new Onion { Sort = "Красный" });
            return this;

        }
        public IBurgerBuilder SetLettuceLeaves()
        {
            Thread.Sleep(1000); // имитация работы (взятие со склада, обжарка, назрезка и т.д.)

            if (_burger.LettuceLeaves == null)
                _burger.LettuceLeaves = new() { new LettuceLeaves { Sort = "Айсберг" } };
            else
                _burger.LettuceLeaves.Add(new LettuceLeaves { Sort = "Айсберг" });
            return this;

        }

        public IBurgerBuilder SetCheese()
        {
            Thread.Sleep(1000); // имитация работы (взятие со склада, обжарка, назрезка и т.д.)

            if (_burger.Cheese == null)
                _burger.Cheese = new() { new Cheese { Sort = "Пармезан" } };
            else
                _burger.Cheese.Add(new Cheese { Sort = "Пармезан" });
            return this;

        }
        public IBurgerBuilder SetCutletBeef()
        {
            Thread.Sleep(1000); // имитация работы (взятие со склада, обжарка, назрезка и т.д.)

            if (_burger.Cutlet == null)
                _burger.Cutlet = new() { new Cutlet { Sort = "Говядина" } };
            else
                _burger.Cutlet.Add(new Cutlet { Sort = "Говядина" });
            return this;

        }

        public IBurgerBuilder SetCutletChicken()
        {
            Thread.Sleep(1000); // имитация работы (взятие со склада, обжарка, назрезка и т.д.)

            if (_burger.Cutlet == null)
                _burger.Cutlet = new() { new Cutlet { Sort = "Кура" } };
            else
                _burger.Cutlet.Add(new Cutlet { Sort = "Кура" });
            return this;

        }
        public IBurgerBuilder SetCucumbers()
        {
            Thread.Sleep(1000); // имитация работы (взятие со склада, обжарка, назрезка и т.д.)

            if (_burger.Cucumbers == null)
                _burger.Cucumbers = new() { new Cucumbers { Sort = "Маринованные" } };
            else
                _burger.Cucumbers.Add(new Cucumbers { Sort = "Маринованные" });
            return this;

        }
        public IBurgerBuilder SetTomatoes()
        {
            Thread.Sleep(1000); // имитация работы (взятие со склада, обжарка, назрезка и т.д.)

            if (_burger.Tomatoes == null)
                _burger.Tomatoes = new() { new Tomatoes { Sort = "Розовые" } };
            else
                _burger.Tomatoes.Add(new Tomatoes { Sort = "Розовые" });
            return this;

        }

        public Burger GetBurger()
        {
            return _burger;
        }
    }
}
