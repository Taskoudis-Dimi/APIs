﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FullStackAppAPI.Models
{
    public class Products
    {

        public int Prodid { get; set; }
        public string ProdName { get; set; }
        public int ProdQty { get; set; }
        public int ProdPrice { get; set; }
        public string ProdCat { get; set; }

    }
}