using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FortuneTeller
{
    class FortuneCookie : FortuneTellingItems
    {

        public FortuneCookie(string name)
            :base(name)
        {
            this.name = "fortune cookie";

        }


        public override void TellFortune()
        {
            GenerateRandomNumber();
            SelectFortune();

        }
        public void SelectFortune()
        {
            if (computerChoice == 1)
            {
                Console.WriteLine("Your lucky numbers are 2, 5, 55, and 46");
            }
            if (computerChoice == 2)
            {
                Console.WriteLine("Be nice today: you don't know what kind of day someone else is having.");
            }
            if (computerChoice == 3)
            {
                Console.WriteLine("Your future looks bright.");
            }
            if (computerChoice == 4)
            {
                Console.WriteLine("Take it easy today if you have no long term goals.");
            }
            if (computerChoice == 5)
            {
                Console.WriteLine("Mouse eats cheese. Cheese smells up fridge.");
            }



        }
    }
}
