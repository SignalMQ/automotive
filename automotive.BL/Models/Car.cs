using System.ComponentModel.DataAnnotations.Schema;

namespace automotive.BL.Models
{
    [Table("Car")]
    /// <summary>
    /// Базовый класс для автомобилья
    /// </summary>
    public class Car: Transport
    {
        public int Position  { get; set; }
        public int Height    { get; set; }
        public int Width     { get; set; }
        public int Weight    { get; set; }
        public int Clearance { get; set; }
    }
}