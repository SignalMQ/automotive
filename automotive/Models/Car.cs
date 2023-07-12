using automotive.Models.Interfaces;

namespace automotive.Models
{
    /// <summary>
    /// Базовый класс для автомобилья
    /// </summary>
    public class Car : Transport, ICar
    {
        public int CarPosition { get; set; }
    }
}