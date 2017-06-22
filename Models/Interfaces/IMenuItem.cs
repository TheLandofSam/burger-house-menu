namespace MenuApi.Models.Interfaces
{
    public interface IMenuItem
    {
        string Name { get; set; }
        float Price {get; set; }
        int Calories {get; set; }
    }
}