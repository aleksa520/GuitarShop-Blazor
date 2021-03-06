﻿using System;
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
        public DateTime Date { get; set; }
        [NotMapped]
        public string DatumTest { get; set; }
        public User User { get; set; }
        public List<GuitarBillItem> GuitarItems { get; set; } = new List<GuitarBillItem>();

        public decimal GetTotalPrice() => GuitarItems.Sum(g => g.ItemPrice);

        public string GetFormattedTotalPrice() => GetTotalPrice().ToString("0.00");
    }
}
