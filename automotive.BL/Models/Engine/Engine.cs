namespace automotive.Models.Engine
{
    /// <summary>
    /// Класс для определения двигателя транспорта
    /// </summary>
    public class Engine
    {
        public int         Id             { get; set; }
        public string?     Fuel           { get; set; }
        public double      Power          { get; set; }
        public string?     Model          { get; set; }
        public double      Capacity       { get; set; }
        public double      Consumption    { get; set; }
        public int         CilindersCount { get; set; }
        public EngineState State          { get; set; } = new EngineState();
    }
}
