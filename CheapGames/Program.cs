using System;
using System.Collections.Generic;

namespace CheapGames
{
    class Program
    {
        static void Main(string[] args)
        {

            Person person1 = new Person {DateOfBirth=new System.DateTime(2001,1,2), FirstName = "Sezer", LastName = "Karakaş", NationalityId = "25545258896", UserName="ÇılgınÇocuk",Password="123456789",Id=92536 };
            Person person2 = new Person { DateOfBirth = new System.DateTime(2000, 11, 18), FirstName = "Alya", LastName = "Şeker", NationalityId = "15574284115", UserName = "ŞekerKız", Password = "987654321", Id = 62598 };
            Person person3 = new Person { DateOfBirth = new System.DateTime(2001, 10, 12), FirstName = "Fatma", LastName = "Karakaş", NationalityId = "23578469589", UserName = "Laviva", Password = "39440463", Id = 32862 };
            Person person4 = new Person { DateOfBirth = new System.DateTime(1988, 5, 3), FirstName = "Fatih", LastName = "Yılmaz", NationalityId = "36541298773", UserName = "GofretAdam", Password = "654987321", Id = 64587 };


            PersonManager personManager = new PersonManager();
            personManager.Register(person1);
            Console.WriteLine("\n");
            personManager.Register(person2);
            Console.WriteLine("\n");
            personManager.Register(person3);
            Console.WriteLine("\n");
            personManager.Register(person4);
            Console.WriteLine("\n");

            Console.WriteLine("------------------------Games--------------------------");
            Console.WriteLine("\n");

            Games game1 = new Games();
            game1.GameName = "Assassin's Creed";
            game1.GamePrice = 50;
            System.Console.WriteLine("Game: "+game1.GameName + " : Price: "+ game1.GamePrice);
            Console.WriteLine("\n");

            Games game2 = new Games();
            game2.GameName = "Call Of Duty 1";
            game2.GamePrice = 60;
            Console.WriteLine("Game: " + game2.GameName + " : Price: " + game2.GamePrice);
            Console.WriteLine("\n");

            Games game3 = new Games();
            game3.GameName = "Red Dead Redemption 2";
            game3.GamePrice = 400;
            Console.WriteLine("Game: " + game3.GameName + " : Price: " + game3.GamePrice);
            Console.WriteLine("\n");

            Games game4 = new Games();
            game4.GameName = "Last Of Us 2";
            game4.GamePrice = 900;
            Console.WriteLine("Game: " + game4.GameName + " : Price: " + game4.GamePrice);
            Console.WriteLine("\n");

            Games game5 = new Games();
            game5.GameName = "Mount And Blade: Bannerlord";
            game5.GamePrice = 150;
            Console.WriteLine("Game: " + game5.GameName + " : Price: " + game5.GamePrice);
            Console.WriteLine("\n");

            Console.WriteLine("----------------------------------------------------------");

            GameManager manager = new GameManager();
            manager.Buy(game1, person2);
            Console.WriteLine("\n");

            IDiscountService discount1 = new SummerSaleDiscount();
            discount1.Discount(game1);
            Console.WriteLine("\n");

            discount1.UpdateDiscount(game4);
            Console.WriteLine("\n");

            IDiscountService discount2 = new WinterSaleDiscount();
            discount2.UpdateDiscount(game5);
            Console.WriteLine("\n");


            manager.ReturnGame(game1, person1);
            Console.WriteLine("\n");

            manager.Buy(game4, person3);
            Console.WriteLine("\n");


            manager.Buy(game1,person1);
            Console.WriteLine("\n");

            discount2.RemoveDiscount();

            Console.ReadLine();
        }
    }
}
