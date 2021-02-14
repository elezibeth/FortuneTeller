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
        public List<FortuneTellingItems> fortuneTellingItemSelected;
        string numberSelection;
        public List<string> questionAsked;

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
            fortuneTellingItemSelected = new List<FortuneTellingItems>();
            questionAsked = new List<string>();





        }

        //cando methods
        public void RunFortuneTeller()
        {
            //choose fortune teller
            DisplayListOfItems();
            //choose fortune from displaylist of items()
            //-- select fortunetellingitem
            SelectFortuneTellingItem();
            //ask a question from selected fortune telling item
            AskAQuestion();

            //--- console write ask question
            //-- store input
            //-- generate return
            //--- store return 


            //return fortune
        }


        public void DisplayListOfItems()
        {
            Console.WriteLine("Please choose an item from the list. Type in the number of your choice and press enter.");
            foreach (FortuneTellingItems items in fortuneTellingItems)
            {
                int index = fortuneTellingItems.IndexOf(items);
                int indexNumber = index + 1;
                Console.WriteLine($"{indexNumber} {fortuneTellingItems[index].name}");
            }
            numberSelection = Console.ReadLine();


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
        public void SelectFortuneTellingItem()
        {
            
            switch (numberSelection)
            {
                case "1":
                    fortuneTellingItemSelected.Add(magicEightBall);
                    
                    Console.WriteLine($"you have chosen {fortuneTellingItems[0].name}");
                    break;
                case "2":
                    fortuneTellingItemSelected.Add(flower);
                    Console.WriteLine($"you have chosen {fortuneTellingItems[1].name}");
                    break;
                case "3":
                    fortuneTellingItemSelected.Add(fortuneCookie);
                    Console.WriteLine($"you have chosen {fortuneTellingItems[2].name}");
                    break;
                default:
                    Console.WriteLine("not a valid option, please choose again");
                    numberSelection = Console.ReadLine();
                    SelectFortuneTellingItem();
                    break;



            }

        }
        public void AskAQuestion()
        {

            switch (numberSelection)
            {
                case "1":
                    

                    Console.WriteLine("What would you like to know?");
                    break;
                case "2":
                    
                    Console.WriteLine("What would you like to know?");
                    break;
                case "3":
                    
                    Console.WriteLine("Have a cookie. type 'cookie' and press enter.");
                    break;
            }
                    
            
            string input = Console.ReadLine();
            questionAsked.Add(input);

            //-- generate return
            
            fortuneTellingItemSelected[0].TellFortune();
            //--- store return (return stored as 
        }



    }
}
