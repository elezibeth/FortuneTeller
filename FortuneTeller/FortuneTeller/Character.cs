using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FortuneTeller
{
    class Character
    {

        //members
        //-name
        public string characterName;
        public List<string> charactersFortune;
        public TellFortune fortune;

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
            //new Tell Fortune instance
            fortune = new TellFortune();
            //run fortune teller on fortune;
            fortune.RunFortuneTeller();


            //choose fortune telling item
            //ask a question
            //store question in a list at index 0
            //generate fortune
            //store fortune in a list at index 0
            RequestFortune();
        }


       public void DisplayLastFortune()
        {
            Console.WriteLine("haha");
        }
    }
}
