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
            return UsedTraffic * Fare.Price * ((100 - DiscountSize) / 100);
        }

        public override string ToString()
        {
            return $"Имя: {Name}; Тариф {Fare.Name}; Использовано трафика: {UsedTraffic} Мбайт; Скидка {DiscountSize}% " +
                $"Стоимость услуг: {this.GetPrice()} руб.";
        }
    }
}