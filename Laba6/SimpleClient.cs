using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Laba6
{
    public class SimpleClient : IClient
    {
        public SimpleClient(string name, decimal usedTraffic, Fare fare)
        {
            Name = name;
            UsedTraffic = usedTraffic;
            Fare = fare;
        }

        public string Name { get; set; }

        public Fare Fare { get; set; }

        public decimal UsedTraffic { get; set; }

        public decimal GetPrice()
        {
            return UsedTraffic * Fare.Price;
        }

        public override string ToString()
        {
            return $"Имя: {Name}; Тариф {Fare.Name}; Использовано трафика: {UsedTraffic} МБайт; " +
                $"Стоимость услуг: {this.GetPrice()} руб.";
        }
    }
}