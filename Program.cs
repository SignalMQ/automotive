using automotive.Classes;
using System.Drawing;

namespace automotive
{
    internal class Program
    {
        static void Main()
        {
            Engine engine = 100;
            
            List<Transport> Models = new()
            {
                new CarModel ("Lamborghini", "Aventador", Fuel.Petrol, Transmission.Auto, 2023, Color.White),
                new MotoModel("BMW",         "S 1000 RR", Fuel.Petrol,                    2023, Color.Black, 2)
            };

            foreach (var model in Models)
            {
                if (model.Check())
                {
                    model.ShowInfo();
                }
            }
        }
    }
}