using automotive.Objects;

namespace automotive.Objects.Engine
{
    /// <summary>
    /// Класс для определения двигателя транспорта
    /// </summary>
    public class Engine
    {
        public FuelType EngineFuel { get; set; }
        public double EnginePower { get; set; }
        public string EngineModel { get; set; } = string.Empty;
        public double EngineCapacity { get; set; }
        public double EngineConsumption { get; set; }
        public int EngineCilindersCount { get; set; }
        public EngineState EngineState { get; set; } = new EngineState();
    }
}
