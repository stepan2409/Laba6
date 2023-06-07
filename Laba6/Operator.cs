using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Laba6
{
    public class Operator
    {
        private List<IClient> clients;
        private List<Fare> fares;
        private static Operator currentInstance;

        private Operator ()
        {
            clients = new List<IClient> ();
            fares = new List<Fare> ();
        }

        public decimal GetFarePrice(string name)
        {
            return fares.Find(fa => fa.Name == name).Price;
        }

        public static Operator GetInstance()
        {
            if (currentInstance == null)
            {
                currentInstance = new Operator ();
            }
            return currentInstance;
        }

        public List<string> ClientStringsList
        {
            get
            {
                List<string> ret = new List<string>();
                foreach (IClient client in clients)
                {
                    ret.Add(client.ToString());
                }
                return ret;
            }
        }

        public List<string> FareStringList
        {
            get 
            { 
                List<string> ret = new List<string>();
                foreach (Fare fare in fares)
                {
                    ret.Add($"{fare.Name}: {fare.Price} руб./МБайт");
                }
                return ret;
            }
        }

        public List<string> ClientNamesStringList
        {
            get
            {
                List<String> ret = new List<String>();
                foreach(IClient client in clients)
                {
                    ret.Add(client.Name);
                }
                return ret;
            }
        }

        public List<string> FareNamesStringList
        {
            get
            {
                List<String> ret = new List<String>();
                foreach (Fare fare in fares)
                {
                    ret.Add(fare.Name);
                }
                return ret;
            }
        }

        public decimal GetSum()
        {
            decimal ret = 0;
            foreach(IClient client in clients)
            {
                ret += client.GetPrice();
            }
            return ret;
        }

        public void AddClient(string name, decimal usedTrafic, string fareName, bool isDiscountClient, decimal discount = 0)
        {
            IClient client;
            Fare fare = fares.FirstOrDefault(fa => fa.Name == fareName);
            if (isDiscountClient)
            {
                client = new DiscountClient(name, usedTrafic, fare, discount);
            } else
            {
                client = new SimpleClient(name, usedTrafic, fare);
            }
            clients.Add(client);
        }

        public void AddFare(string name, decimal price)
        {
            fares.Add(new Fare(name, 0, price));
        }
    }
}