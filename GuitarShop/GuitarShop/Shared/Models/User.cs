using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace GuitarShop.Shared.Models
{
    public class User
    {
        [Column("id")]
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public override string ToString()
        {
            return FirstName + " " + LastName;
        }
    }
}
