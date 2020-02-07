using GuitarShop.Shared.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace GuitarShop.Shared
{
    public class Session
    {
        private static Session instance;

        public static Session Instance
        {
            get
            {
                if (instance == null)
                    instance = new Session();
                return instance;
            }
        }

        public GuitarBill Bill { get; set; }

        private Session()
        {
            Bill = new GuitarBill();
        }
    }
}
