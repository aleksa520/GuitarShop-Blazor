using System;
using System.Collections.Generic;
using System.Text;

namespace GuitarShop.Shared.Models
{
    public class GuitarBillItem
    {
        public int Id { get; set; }
        public int GuitarBillId { get; set; }
        public int Amount { get; set; }
        public Guitar Guitar { get; set; }
        public decimal GetTotalPrice()
        {
            return Guitar.Price*Amount;
        }
    }
}
