using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FortuneTeller
{
    abstract class Character
    {

        //members
        //-name
        public string characterName;
        public List<string> charactersFortune;

        //has a
        //--name
        public Character(string characterName)
        {
            this.characterName = characterName;
            charactersFortune = new List<string>();
        }

        //can do

        //--request fortune
        public void RequestFortune()
        {
            //display list of fortune telling items
            //choose fortune telling item
            //ask a question
            //store question in a list at index 0
            //generate fortune
            //store fortune in a list at index 0
        }


       public void DisplayLastFortune()
        {
            Console.WriteLine("haha");
        }
    }
}
