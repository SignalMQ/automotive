using automotive.BL.Models;
using automotive.BL.Enums;
using automotive.BL.Models.Body;
using automotive.BL.Models.Chassis;
using automotive.BL.Models.Engine;
using System.Drawing;

namespace automotive.BL.Services
{
    public class Sample
    {
        public Car SampleData()
        {
            Random random = new Random();

            Car car = new Car()
            {
                Position = 1,
                Name = "Bestune",
                Model = "T55",
                Year = 2022,
                Mileage = random.Next(330000),
                Body = new Body
                {
                    Height = 4437,
                    Width = 1850,
                    Color = nameof(Color.White),
                    Material = nameof(MaterialType.Aluminum)
                },
                Chassis = new Chassis
                {
                    Material = nameof(MaterialType.Steel),
                    WheelCount = 2,
                    Wheel = new Wheel
                    {
                        Diameter = 18,
                        Material = nameof(MaterialType.Rubber)
                    }
                },
                Engine = new Engine
                {
                    Fuel = nameof(FuelType.Petrol),
                    Capacity = 1.5,
                    CilindersCount = 4,
                    Consumption = 6.6,
                    Model = "Evro-6",
                    Power = 160,
                    State = new EngineState
                    {
                        AntiFreezeLevel = random.Next(100),
                        BrakeFluidLevel = random.Next(100),
                        FuelLevel = random.Next(100),
                        OilLevel = random.Next(100),
                        PowerLevel = random.Next(100),
                        TransmissionOilLevel = random.Next(100),
                        IsStarted = random.Next(2) == 1 ? true : false
                    }
                }
            };

            return car;
        }
    }
}