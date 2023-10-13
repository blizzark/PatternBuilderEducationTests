using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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

        public void BildBurger()
        {
            Burger.SetBun();
            Burger.SetCutlet();
            Burger.SetSauce();
            Burger.SetLettuceLeaves();
            Burger.SetCucumbers();
            Burger.SetTomatoes();
            Burger.SetOnion();
        }


    }
}
