using System;
using MenuApi.Models.Interfaces;

namespace MenuApi.Models
{
    public class Drink : IMenuItem
    {
        public string Name { get; set; }
        public float Price { get; set; }
        public bool Alcoholic { get; set; }
        public int Calories { get; set; }

        public Drink(string name, float price, bool alcoholic, int calories)
        {
            Name = name;
            Price = price;
            Alcoholic = alcoholic;
            Calories = calories;
        }
    }
}
