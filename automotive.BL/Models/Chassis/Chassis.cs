namespace automotive.BL.Models.Chassis
{
    /// <summary>
    /// Класс для определения типа подвески для транспорта
    /// </summary>
    public class Chassis
    {
        public int     Id         { get; set; }
        public string? Material   { get; set; }
        public int     WheelCount { get; set; }
        public Wheel   Wheel      { get; set; } = new();
    }
}
