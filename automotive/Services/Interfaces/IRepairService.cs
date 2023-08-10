using automotive.Models.Interfaces;

namespace automotive.Services.Interfaces
{
    public interface IRepairService
    {
        public abstract bool Validate(ITransport transport);
        public abstract string ViewProblems(ITransport transport);
        public abstract void FixProblems(ref ITransport transport, object component);
    }
}
