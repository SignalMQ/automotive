namespace automotive.Models.Objects.Chassis
{
    /// <summary>
    /// Класс для определения типа подвески для транспорта
    /// </summary>
    public class Chassis
    {
        public MaterialType ChassisMaterial   { get; set; }
        public static int   ChassisWheelCount { get; set; }
        public Wheel[]      Wheel             { get; set; } = new Wheel[ChassisWheelCount];
    }
}
