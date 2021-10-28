using System;
using System.Collections.Generic;
using System.Text;

namespace Day5_Practice_Programs
{
    class Leap_Year
    {
        public int Y;

        public void Year()
        {
            Console.WriteLine("Enter a Year YYYY ");
            Y = Convert.ToInt32(Console.ReadLine());
            if (Y >= 1000 && Y < 10000)
            {
                if (Y % 400 == 0 || Y % 4 == 0)
                {
                    Console.WriteLine("It's a Leap Year");
                }
                else if (Y % 100 != 0)
                {
                    Console.WriteLine("It's Not a Leap Year");
                }
            }
            else
            {
                Console.WriteLine("Enter a four digit year value");
            }
        }

    }
}
