﻿using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class Product //entity
    {
        public int Id { get; set; }
        public int CatogoryId { get; set; }
        public string ProductName { get; set; }
        public double UnıtPrice { get; set; }
        public int UnitsInStock { get; set; }

    }
}