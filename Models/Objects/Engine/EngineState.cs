namespace automotive.Models.Objects.Engine
{
    /// <summary>
    /// Класс определяющее состояние двигателя
    /// </summary>
    public class EngineState
    {
        bool   IsStarted            { get; set; }
        double FuelLevel            { get; set; }
        double PowerLevel           { get; set; }
        double AntiFreezeLevel      { get; set; }
        double OilLevel             { get; set; }
        double TransmissionOilLevel { get; set; }
        double BrakeFluidLevel      { get; set; }
    }
}
