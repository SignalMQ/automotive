namespace automotive.Models.Engine
{
    /// <summary>
    /// Класс определяющее состояние двигателя
    /// </summary>
    public class EngineState
    {
        public int    Id                   { get; set; }
        public bool   IsStarted            { get; set; }
        public double FuelLevel            { get; set; }
        public double PowerLevel           { get; set; }
        public double AntiFreezeLevel      { get; set; }
        public double OilLevel             { get; set; }
        public double TransmissionOilLevel { get; set; }
        public double BrakeFluidLevel      { get; set; }
    }
}
