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
           
            fortune = new TellFortune();
            fortune.RunFortuneTeller();
            RequestFortune();
        }


      
    }
}
