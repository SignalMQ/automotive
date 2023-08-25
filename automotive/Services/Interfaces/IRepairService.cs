using automotive.Models;

namespace automotive.Services.Interfaces
{
    public interface IRepairService
    {
        public abstract bool Validate(Transport transport);
        public abstract string ViewProblems(Transport transport);
        public abstract void FixProblems(ref Transport transport, object component);
    }
}
