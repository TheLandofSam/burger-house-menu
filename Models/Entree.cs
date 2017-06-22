using MenuApi.Models.Interfaces;

namespace MenuApi.Models
{
    public class Entree : IMenuItem
    {
        public string Name { get; set; }
        public float Price { get; set; }
        public int Calories { get; set; }

        public Entree(string name, float price, int calories)
        {
            Name = name;
            Price = price;
            Calories = calories;
        }
    }
}