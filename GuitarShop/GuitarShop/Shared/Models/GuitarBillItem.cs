using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace GuitarShop.Shared.Models
{
    public class GuitarBillItem
    {
        [Column("id")]
        public int Id { get; set; }
        public Guitar Guitar { get; set; }
    }
}
