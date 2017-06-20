namespace MenuApi.Models
{
    public class MenuItem
    {
        public string Name;
        public float Price;

        public MenuItem(string name, float price)
        {
            Name = name;
            Price = price;
        }
    }

}