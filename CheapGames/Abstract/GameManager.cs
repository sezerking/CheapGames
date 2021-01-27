using System;
using System.Collections.Generic;
using System.Text;

namespace CheapGames
{
    class GameManager
    {
        public void Buy(Games game, Person person)
        {
            Console.WriteLine(person.UserName+"'s bought: "+game.GameName+" for "+game.GamePrice);
        }
        public void ReturnGame(Games game, Person person)
        {
            Console.WriteLine(person.UserName + "'s returned " + game.GameName);
        }


    }
}
