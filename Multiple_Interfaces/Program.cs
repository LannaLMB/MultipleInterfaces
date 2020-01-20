using System;
using System.Threading;

namespace Multiple_Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiate Classes
            Child child = new Child();
            Teenager teen = new Teenager();
            Adult adult = new Adult();

            // Call each method for specific classes/humans
            child.humanType();
            child.ageRange();

            // Putting space in between our outputs
            Console.WriteLine();

            teen.humanType();
            teen.ageRange();

            // Putting space in between our outputs
            Console.WriteLine();

            adult.humanType();
            adult.ageRange();
            adult.drinkingAge();  // This method doesn't apply to the other classes/types of humans therefore we don't have to use it on them

            Thread.Sleep(5000);
        }
    }
}
