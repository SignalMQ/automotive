using automotive.Models;
using automotive.Models.Interfaces;
using automotive.Objects.Chassis;
using automotive.Services.Interfaces;

namespace automotive.Services
{
    public class RepairService : IRepairService
    {
        public virtual bool Validate(ITransport transport)
        {
            return true;
        }

        public virtual string ViewProblems(ITransport transport)
        {
            return null;
        }

        public virtual void FixProblems(ref ITransport transport, object component)
        {
            if (component is Chassis)
            {
                transport.TransportChassis.ChassisWheelCount = 4;
            }
        }
    }
}
