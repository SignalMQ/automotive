using automotive.Models.Interfaces;
using automotive.Models.Objects;
using automotive.Models.Objects.Chassis;
using automotive.Models.Objects.Engine;

namespace automotive.Models
{
    /// <summary>
    /// Базовый класс для транспорта
    /// </summary>
    public class Transport : ITransport
    {
        public string  TransportName    { get; set; } = string.Empty;
        public string  TransportModel   { get; set; } = string.Empty;
        public int     TransportYear    { get; set; }
        public int     TransportMileage { get; set; }
        public Engine  TransportEngine  { get; set; } = new();
        public Chassis TransportChassis { get; set; } = new();
        public Body    TransportBody    { get; set; } = new();
    }
}