using automotive.Models;
using automotive.Objects;
using automotive.Objects.Chassis;
using automotive.Objects.Engine;
using Newtonsoft.Json;
using System.Drawing;

namespace automotive
{
    internal class Program
    {
        static void Main()
        {
            Car car = new Car()
            {
                CarPosition = 1,
                TransportName = "Bestune",
                TransportModel = "T55",
                TransportYear = 2022,
                TransportMileage = 330000,
                TransportBody = new Body
                {
                    Height = 4437,
                    Width = 1850,
                    Color = Color.White,
                    Material = MaterialType.Aluminum
                },
                TransportChassis = new Chassis
                {
                    ChassisMaterial = MaterialType.Steel,
                    ChassisWheelCount = 4,
                    Wheel = new Wheel
                    {
                        WheelDiameter = 18,
                        WheelMaterialType = MaterialType.Rubber
                    }
                },
                TransportEngine = new Engine
                {
                    EngineFuel = FuelType.Petrol,
                    EngineCapacity = 1.5,
                    EngineCilindersCount = 4,
                    EngineConsumption = 6.6,
                    EngineModel = "Evro-6",
                    EnginePower = 160,
                    EngineState = new EngineState
                    {
                        AntiFreezeLevel = 100,
                        BrakeFluidLevel = 100,
                        FuelLevel = 100,
                        OilLevel = 100,
                        PowerLevel = 100,
                        TransmissionOilLevel = 100,
                        IsStarted = false
                    }
                }
            };

            var json = JsonConvert.SerializeObject(car, Formatting.Indented);
            
            Console.WriteLine(json);
        }
    }
}