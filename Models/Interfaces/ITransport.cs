using automotive.Objects;
using automotive.Objects.Chassis;
using automotive.Objects.Engine;

namespace automotive.Models.Interfaces
{
    public interface ITransport
    {
        public string  TransportName    { get; set; }
        public int     TransportYear    { get; set; }
        public int     TransportMileage { get; set; }
        public Engine  TransportEngine  { get; set; }
        public Chassis TransportChassis { get; set; }
        public Body    TransportBody    { get; set; }
    }
}