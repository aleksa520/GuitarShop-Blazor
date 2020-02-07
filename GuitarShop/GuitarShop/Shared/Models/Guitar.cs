using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace GuitarShop.Shared.Models
{
    public class Guitar
    {
        [Column("id")]
        public int Id { get; set; }  
        [Required]
        public string Name { get; set; }
        [Required]
        public int Price { get; set; }
    }
}
