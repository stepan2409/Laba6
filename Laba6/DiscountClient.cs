using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Laba6
{
    public class DiscountClient : IClient
    {
        public DiscountClient(string name, decimal usedTraffic, Fare fare, decimal discountSize)
        {
            Name = name;
            UsedTraffic = usedTraffic;
            Fare = fare;
            DiscountSize = discountSize;
        }

        public string Name { get; set; }

        public Fare Fare { get; set; }

        public decimal UsedTraffic { get; set; }

        public decimal DiscountSize { get; set; }

        public decimal GetPrice()
        {
            return Math.Max(Math.Round(UsedTraffic * Fare.Price, 2) - DiscountSize, 0);
        }

        public override string ToString()
        {
            return $"Имя: {Name}; Тариф {Fare.Name}; Использовано трафика: {UsedTraffic} Мбайт; Скидка {DiscountSize} руб. " +
                $"Стоимость услуг: {this.GetPrice()} руб.";
        }
    }
}