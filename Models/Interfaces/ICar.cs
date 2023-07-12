namespace automotive.Models.Interfaces
{
    public interface ICar : ITransport
    {
        public int CarPosition { get; set; }
    }
}
