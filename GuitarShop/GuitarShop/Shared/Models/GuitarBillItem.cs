using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace GuitarShop.Shared.Models
{
    public class GuitarBillItem
    {
        [Column("id")]
        public int Id { get; set; }
        public int Number { get; set; } = 1;
        public Guitar Guitar { get; set; }
        
        public decimal ItemPrice
        {
            get
            {
                if(Guitar == null)
                {
                    return 0;
                }
                return (Guitar.Price * Number);
            }
        }
    }
}
