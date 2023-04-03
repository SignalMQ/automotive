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
                new CarModel("Lamborghini", "Aventador", Fuel.Petrol, 2023, Color.White),
                new CarModel("Tesla", "S3", Fuel.Electric, 2017, Color.Black)
            };
            
            foreach (var model in carModels)
            {
                model.BreakRad(0); //специально сломаем машину

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