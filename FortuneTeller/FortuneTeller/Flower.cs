using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FortuneTeller
{
    class Flower : FortuneTellingItems
    {
        public Flower(string name)
            :base (name)
        {
            this.name = "flower";

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
                Console.WriteLine("Unknown");
            }
            if (computerChoice == 2)
            {
                Console.WriteLine("Unlikely");
            }
            if (computerChoice == 3)
            {
                Console.WriteLine("Your future looks bright");
            }
            if (computerChoice == 4)
            {
                Console.WriteLine("It's not going to snow forever.");
            }
            if (computerChoice == 5)
            {
                Console.WriteLine("Definitely");
            }



        }
    }
}
