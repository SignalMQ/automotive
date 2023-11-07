using System.ComponentModel.DataAnnotations.Schema;

namespace automotive.BL.Models
{
    [Table("Moto")]
    public class Moto : Transport
    {
        public int Position { get; set; }
        public int Height   { get; set; }
        public int Width    { get; set; }
        public int Weight   { get; set; }
    }
}
