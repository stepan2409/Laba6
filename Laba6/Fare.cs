using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Laba6
{
    public class Fare
    {
        public Fare(string name, int id, decimal price)
        {
            Name = name;
            Id = id;
            Price = price;
        }

        public string Name { get; set; }

        public int Id { get; set; }

        public decimal Price { get; set; }
    }
}