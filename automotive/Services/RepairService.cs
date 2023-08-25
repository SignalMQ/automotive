using automotive.Models;
using automotive.Objects.Chassis;
using automotive.Services.Interfaces;

namespace automotive.Services
{
    public class RepairService : IRepairService
    {
        public virtual bool Validate(Transport transport)
        {
            return true;
        }

        public virtual string ViewProblems(Transport transport)
        {
            return null;
        }

        public virtual void FixProblems(ref Transport transport, object component)
        {
            if (component is Chassis)
            {
                transport.TransportChassis.ChassisWheelCount = 4;
            }
        }
    }
}
