using System;
using System.Collections.Generic;
using System.Text;

namespace GuitarShop.Shared.Models
{
    public class GuitarBill
    {
        public int Id { get; set; }

        public int TotalPrice { get; set; }

        public List<Guitar> Guitars { get; set; }
    }
}
