using automotive.Classes;
using System.Drawing;

namespace automotive
{
    internal class Program
    {
        static void Main()
        {
            List<CarModel> carModels = new()
            {
                new CarModel("Lamborghini", "Aventador", Fuel.Petrol, 12121, Color.White), // тест 1: год машины увеличим, чем допустимое значение, чтобы получить исключение
                new CarModel("Tesla", "S3", Fuel.Electric, 2017, Color.Black)
            };
            
            foreach (var model in carModels)
            {
                model.BreakRad(45); //тест 2: увеличим значение превышающее, чтобы получить исключение

                if (model.CheckCar())
                {
                    model.CarInfo();
                }
                else
                {
                    model.CarErrors();
                }
            }
        }
    }
}