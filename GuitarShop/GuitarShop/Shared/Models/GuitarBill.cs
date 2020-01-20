using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GuitarShop.Shared.Models
{
    public class GuitarBill
    {
        public int Id { get; set; }

        public List<GuitarBillItem> Guitars { get; set; } = new List<GuitarBillItem>();

        public decimal GetTotalPrice() => Guitars.Sum(p => p.GetTotalPrice());

        public string GetFormattedTotalPrice() => GetTotalPrice().ToString("0.00");
    }
}
