using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FortuneTeller
{
    class TellFortune
    {

        //members
        MagicEightBall magicEightBall;
        public List<FortuneTellingItems> fortuneTellingItems;
        Flower flower;
        FortuneCookie fortuneCookie;

        //ctor
        public TellFortune()
        {
            fortuneTellingItems = new List<FortuneTellingItems>();
            magicEightBall = new MagicEightBall("magic eight ball");
            fortuneTellingItems.Add(magicEightBall);
            flower = new Flower("flower");
            fortuneTellingItems.Add(flower);
            fortuneCookie = new FortuneCookie("fortune cookie");
            fortuneTellingItems.Add(fortuneCookie);





        }

        //cando methods
        public void RunFortuneTeller()
        {
            //choose fortune teller
            DisplayListOfItems();
            //return fortune
        }


        public void DisplayListOfItems()
        {
            foreach (FortuneTellingItems items in fortuneTellingItems)
            {
                int index = fortuneTellingItems.IndexOf(items);
                int indexNumber = index + 1;
                Console.WriteLine($"{indexNumber} {fortuneTellingItems[index].name}");
            }

        }

        public void DisplayIndexOfItems()
        {
            foreach (FortuneTellingItems items in fortuneTellingItems)
            {
                int index = fortuneTellingItems.IndexOf(items);
                int indexNumber = index + 1;
                Console.WriteLine($"{index} {fortuneTellingItems[index].name}");
            }

        }



    }
}
