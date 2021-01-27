using System;
using System.Collections.Generic;
using System.Text;

namespace CheapGames
{
    class SummerSaleDiscount : IDiscountService
    {
        public void RemoveDiscount()
        {
            //kaldırılması için gerekli olan kodlar ...
            Console.WriteLine("Summer Sale is ended.");
        }

        public void Discount(Games game)
        {
            game.GamePrice = (int)(game.GamePrice * 0.5);
            Console.WriteLine(game.GameName + "'s new price: " + game.GamePrice);
        }

        public void UpdateDiscount(Games game)
        {
            //güncellenmesi için gerekli kodlar...
            game.GamePrice = (int)(game.GamePrice * 0.199);
            Console.WriteLine(game.GameName + "'s discount has updated to " + game.GamePrice);
        }
    }
}
