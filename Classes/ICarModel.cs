using System.Drawing;

namespace automotive.Classes
{
    public interface ICarModel
    {
        Color Color { get; set; }
        string Model { get; set; }
        string Name { get; set; }
        int RadCount { get; set; }
        int BrokenRadCount { get; set; }

        void CarInfo();
        void CarErrors();
        bool CheckCar();
    }
}