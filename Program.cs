using automotive.Classes;
using System.Drawing;

namespace automotive
{
    internal class Program
    {
        static void Main()
        {
            ICarModel car = new CarModel()
            {
                Name = "Lamborghini",
                Model = "Aventador",
                Color = Color.Black,
                RadCount = 4
            };

            if (car.CheckCar())
            {
                car.CarInfo();
            }
            else
            {
                car.CarErrors();
            }
        }
    }
}