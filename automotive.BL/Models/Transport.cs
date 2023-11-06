namespace automotive.BL.Models
{
    /// <summary>
    /// Базовый класс для транспорта
    /// </summary>
    public class Transport
    {
        public int             Id      { get; set; }
        public string?         Name    { get; set; }
        public string?         Model   { get; set; }
        public int             Year    { get; set; }
        public int             Mileage { get; set; }
        public Engine.Engine   Engine  { get; set; } = new();
        public Chassis.Chassis Chassis { get; set; } = new();
        public Body.Body       Body    { get; set; } = new();
    }
}
