namespace automotive.Models
{
    /// <summary>
    /// Базовый класс для автомобилья
    /// </summary>
    public class Car: Transport
    {
        public int CarPosition { get; set; }
        public int CarHeight   { get; set; }
        public int CarWidth    { get; set; }
        public int CarWeight   { get; set; }
    }
}