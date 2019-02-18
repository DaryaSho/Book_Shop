﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Threading.Tasks;

namespace BookShop.Models
{
    public class Stock
    {
        public int Id { get; set; }
        public Book Book { get; set; }
        public int Quantity { get; set; }

    }
}
