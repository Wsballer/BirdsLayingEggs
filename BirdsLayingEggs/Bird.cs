using System;
using System.Collections.Generic;
using System.Text;

namespace BirdsLayingEggs
{
    class Bird
    {
        public static Random Randomizer = new Random();
        public virtual Egg[] LayEggs(int numberOfEggs)
        {
            Console.Error.WriteLine("Bird.LayEggs shoud never get called");
            return new Egg[0];
        }
    }
}
