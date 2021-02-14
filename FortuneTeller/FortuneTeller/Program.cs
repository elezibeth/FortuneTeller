using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FortuneTeller
{
    class Program
    {
        static void Main(string[] args)
        {
            TellFortune tell = new TellFortune();
            tell.DisplayListOfItems();
            Console.WriteLine("index of items in tell fortune class:");
            tell.DisplayIndexOfItems();



            Console.ReadLine();
        }
    }
}
