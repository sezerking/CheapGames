using System;
using System.Collections.Generic;
using System.Text;

namespace CheapGames
{
    class WinterSaleDiscount : IDiscountService
    {
        public void Discount(Games game)
        {
            game.GamePrice = (int)(game.GamePrice * 0.75);
            Console.WriteLine(game.GameName + "'s new price: " + game.GamePrice);
        }

        public void RemoveDiscount()
        {
           
            //kaldırılması için gerekli olan kodlar ...
            Console.WriteLine("Winter Sale is ended.");
        }

        public void UpdateDiscount(Games game)
        {

            //güncellenmesi için gerekli kodlar...
            game.GamePrice = (int)(game.GamePrice * 0.2);
            Console.WriteLine(game.GameName+"'s discount has updated to "+game.GamePrice);
        }
    }
}
