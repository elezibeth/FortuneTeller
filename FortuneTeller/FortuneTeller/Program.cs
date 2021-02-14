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

            Character liz = new Character("elezibeth");
            liz.RequestFortune();


            Console.ReadLine();
        }
    }
}
