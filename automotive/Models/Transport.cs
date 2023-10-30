using automotive.Objects;
using automotive.Objects.Chassis;
using automotive.Objects.Engine;

namespace automotive.Models
{
    /// <summary>
    /// Базовый класс для транспорта
    /// </summary>
    public class Transport
    {
        public string? Name    { get; set; }
        public string? Model   { get; set; }
        public int     Year    { get; set; }
        public int     Mileage { get; set; }
        public Engine  Engine  { get; set; } = new();
        public Chassis Chassis { get; set; } = new();
        public Body    Body    { get; set; } = new();
    }
}