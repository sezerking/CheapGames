using System;
using System.Collections.Generic;
using System.Text;

namespace CheapGames
{
    class PersonManager
    {
        PersonCheckManager checkManager=new PersonCheckManager();
        public void Register(Person person)
        {
            checkManager.CheckIfRealPerson(person);
            Console.WriteLine("You've successfully registered to the system: "+person.UserName);
        }

        public void Update(Person person)
        {
            Console.WriteLine("You've updated your information.");
        }

        public void Delete(Person person)
        {
            Console.WriteLine("You've deleted your account.");
        }
    }
}
