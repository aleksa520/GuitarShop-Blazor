using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;

namespace GuitarShop.Shared.Models
{
    public class GuitarBill
    {
        [Column("id")]
        public int Id { get; set; }

        public List<Guitar> Guitars { get; set; } = new List<Guitar>();

        public decimal GetTotalPrice() => Guitars.Sum(g => g.Price);

        public string GetFormattedTotalPrice() => GetTotalPrice().ToString("0.00");
    }
}
