using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternBuilderEducationTests
{

    /*
     * я пока не вижу смысла делать отдельный Директор для создания другого варианта продукта.
     * Зачем делать отдельный Директор, когда можно добавить в старый новый метод?
     */
    public class CookerBigBurgerDirector
    {
        private readonly IBurgerBuilder Burger;

        public CookerBigBurgerDirector(IBurgerBuilder burger)
        {
            Burger = burger;
        }


        /// <summary>
        /// // Тут может быть разница какая-то, но её не будет у меня
        /// </summary>
        public void BildBurger()
        {
            Parallel.Invoke(
                () => Burger.SetBun(),
                () => Burger.SetCutletChicken(),
                () => Burger.SetCutletChicken(),
                () => Burger.SetSauceMayonnaise(),
                () => Burger.SetSauceMustard(),
                () => Burger.SetLettuceLeaves(),
                () => Burger.SetCucumbers(),
                () => Burger.SetTomatoes(),
                () => Burger.SetOnion(),
                () => Burger.SetOnion(),
                () => Burger.SetOnion()
                );

        }
    }
}
