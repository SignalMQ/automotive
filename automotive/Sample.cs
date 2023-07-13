using automotive.Models;
using automotive.Objects;
using automotive.Objects.Chassis;
using automotive.Objects.Engine;
using System.Drawing;

namespace automotive
{
    public class Sample
    {
        public static Car SampleData()
        {
            Random random = new Random();

            Car car = new Car()
            {
                CarPosition = 1,
                TransportName = "Bestune",
                TransportModel = "T55",
                TransportYear = 2022,
                TransportMileage = random.Next(330000),
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