using System;
using System.Collections.Generic;
using System.Text;

namespace Multiple_Interfaces
{
    class Teenager : IHuman, IAgeRange
    {
        public void humanType()
        {
            Console.WriteLine("Teenager");
        }

        public void ageRange()
        {
            Console.WriteLine("13-19");
        }
    }
}