using System;
using System.Collections.Generic;
using System.Text;

namespace BirdsLayingEggs
{
    class BrokenEgg : Egg
    {
        public BrokenEgg(double size, string color) : base(size, color)
        {
            Console.WriteLine("A bird laid a broken egg");
        }
    }
}
