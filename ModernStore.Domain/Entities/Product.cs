﻿using ModernStore.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ModernStore.Domain.Entities
{
    public class Product:Entity
    {
        public Product(string title, decimal price, int quantityOnHand, string image)
        {
            Title = title;
            Price = price;
            QuantityOnHand = quantityOnHand;
            Image = image;
        }

        public string Title { get; private set; }
        public decimal Price { get; private set; }
        public int QuantityOnHand { get; private set; }
        public string Image { get; private set; }
    }
}