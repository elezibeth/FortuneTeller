using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FortuneTeller
{
    abstract class FortuneTellingItems
    {
        //member variables
        public string name;
        public int ourRandomNumber;
        public int computerChoice;
        

        //ctor has a
        public FortuneTellingItems(string name)
            
        {
            this.name = name;
        }

        //methods can do

        public abstract void TellFortune();

        public void GenerateRandomNumber()
        {
            Random number = new Random();
            ourRandomNumber = number.Next(1, 5);
            computerChoice = ourRandomNumber;
            Console.WriteLine($"your random number selection is {computerChoice}");
        }


    }
}
