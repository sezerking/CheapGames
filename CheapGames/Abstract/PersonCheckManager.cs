using System;
using System.Collections.Generic;
using System.Text;

namespace CheapGames
{
    public class PersonCheckManager : IPersonCheckService
    {
        public void CheckIfRealPerson(Person person)
        {
            Console.WriteLine("Valid person.");
        }
    }
}
