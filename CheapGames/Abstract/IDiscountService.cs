using System;
using System.Collections.Generic;
using System.Text;

namespace CheapGames
{
    public interface IDiscountService
    {
        public void Discount(Games game);
        public void UpdateDiscount(Games game);
        public void RemoveDiscount();
    }
}
