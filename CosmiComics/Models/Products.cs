﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CosmiComics.Models
{
    public class Products
    {
        public int ProductsId { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public decimal Price { get; set; }
    }
}