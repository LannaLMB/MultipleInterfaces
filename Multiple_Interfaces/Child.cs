using System;
using System.Collections.Generic;
using System.Text;

namespace Multiple_Interfaces
{
    class Child : IHuman, IAgeRange
    {
        public void humanType()
        {
            Console.WriteLine("Child");
        }

        public void ageRange()
        {
            Console.WriteLine("1-12");
        }
    }
}