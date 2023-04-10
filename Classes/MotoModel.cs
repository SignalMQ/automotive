using System.Drawing;

namespace automotive.Classes
{
    public class MotoModel : CarModel
    {
        public MotoModel(string name, string model, Fuel fuel, Year year, Color color, int radCount = 2) : base(name, model, fuel, year, color)
        {
            Name  = name;
            Model = model;
            Fuel  = fuel;
            Year  = year;
            Color = color;
        }
    }
}
