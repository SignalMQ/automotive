namespace automotive.Models.Objects.Engine
{
    /// <summary>
    /// Класс для определения двигателя транспорта
    /// </summary>
    public class Engine
    {
        /// <summary>
        /// Тип топлива, на котором работает двигатель транспорта
        /// </summary>
        public FuelType    EngineFuel           { get; set; }
        /// <summary>
        /// Сколько лошадей издаёт двигатель
        /// </summary>
        public double      EnginePower          { get; set; }
        public string      EngineModel          { get; set; } = string.Empty;
        public double      EngineCapacity       { get; set; }
        public double      EngineConsumption    { get; set; }
        public int         EngineCilindersCount { get; set; }
        public EngineState EngineState          { get; set; } = new EngineState();
    }
}
