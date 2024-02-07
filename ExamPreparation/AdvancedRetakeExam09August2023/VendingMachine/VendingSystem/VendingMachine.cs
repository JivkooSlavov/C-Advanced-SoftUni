using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;

namespace VendingSystem
{
    public class VendingMachine
    {
        public int ButtonCapacity { get; set; }

        public List<Drink> Drinks { get; set; }

        public int GetCount => Drinks.Count();

        public VendingMachine(int buttonCapacity)
        {
           ButtonCapacity = buttonCapacity;
           Drinks = new List<Drink>();
        }

        public void AddDrink(Drink drink)
        {
            if (Drinks.Count == ButtonCapacity)
            {
                return;
            }
            Drinks.Add(drink);
        }

        public bool RemoveDrink(string name) => Drinks.Remove(Drinks.FirstOrDefault(x => x.Name == name));
        public Drink GetLongest()
        {
            Drink biggestDrinkValue = Drinks.OrderByDescending(m => m.Volume).FirstOrDefault();
            return biggestDrinkValue;
        }
        public Drink GetCheapest()
        {
            Drink lowestDrinkPrice = Drinks.OrderBy(x => x.Price).FirstOrDefault();
            return lowestDrinkPrice;
        }

        public string BuyDrink(string name)
        {
            Drink nameOfDrink = Drinks.FirstOrDefault(x=>x.Name== name);
            return nameOfDrink.ToString();
        }
        public string Report()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Drinks available:");
            foreach (var drink in Drinks)
            {
                sb.AppendLine(drink.ToString().TrimEnd());
            }
            return sb.ToString().TrimEnd();
        }

    }
}
