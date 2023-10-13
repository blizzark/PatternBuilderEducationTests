using System.Threading.Tasks;

namespace PatternBuilderEducationTests
{
    public class CookerDirector
    {
        private readonly IBurgerBuilder Burger;

        public CookerDirector(IBurgerBuilder burger)
        {
            Burger = burger;
        }

        public async Task BildBurger()
        {
            Task[]? taskBurger = new Task[] {
                Task.Factory.StartNew(() => Burger.SetBun()),
                Task.Factory.StartNew(() => Burger.SetCutletBeef()),
                Task.Factory.StartNew(() => Burger.SetSauceKetchap()),
                Task.Factory.StartNew(() => Burger.SetSauceMustard()),
                Task.Factory.StartNew(() => Burger.SetLettuceLeaves()),
                Task.Factory.StartNew(() => Burger.SetCucumbers()),
                Task.Factory.StartNew(() => Burger.SetTomatoes()),
                Task.Factory.StartNew(() => Burger.SetOnion())
            };

            Task.WaitAll(taskBurger); // ожидаем завершения всех задач


        }


    }
}
