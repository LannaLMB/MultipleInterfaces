using System;
using System.Collections.Generic;
using System.Text;

namespace Multiple_Interfaces
{
    class Adult : IHuman, IAgeRange, IDrinkingAge
    {
        public void humanType()
        {
            Console.WriteLine("Adult");
        }

        public void ageRange()
        {
            Console.WriteLine("18+");
        }

        public void drinkingAge()
        {
            Console.WriteLine("The current drinking age is 21");
        }
    }
}