using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FortuneTeller
{
    class MagicEightBall : FortuneTellingItems
    {

        //members
        

        //ctor has a 
        public MagicEightBall(string name)
            :base (name)
        {

        }

        //methods can do
        public override void TellFortune()
        {
            GenerateRandomNumber();
            SelectFortune();

        }
        public void SelectFortune()
        {
            if(computerChoice == 1)
            {
                Console.WriteLine("Unknown");
                storeThisFortune = "Unknown";
            }
            if (computerChoice == 2)
            {
                Console.WriteLine("Unlikely");
                storeThisFortune = "Unknown";
            }
            if(computerChoice == 3)
            {
                Console.WriteLine("Your future looks bright");
                storeThisFortune = "Unknown";
            }
            if(computerChoice == 4)
            {
                Console.WriteLine("hahaha, give up now");
                storeThisFortune = "Unknown";
            }
            if(computerChoice == 5)
            {
                Console.WriteLine("Definitely");
                storeThisFortune = "Unknown";
            }

            
            
        }



    }
}
