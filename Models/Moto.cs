using System.Drawing;

namespace automotive.Models
{
    public class Moto : Transport
    {
        /// <summary>
        /// Базовый конструктор для класса мотоцикла
        /// </summary>
        public Moto(string name, string model, Fuel fuel, Year year, Color color, int radCount = 2)
        {

        }

        public Color Color { get; set; }
        public int RadCount { get; set; } = 2;

        public override bool Check()
        {
            Console.WriteLine("MotoModel: Пока нет реализации!"); //заглушка
            return true; //заглушка
        }

        public override void ShowInfo()
        {
            Console.WriteLine("MotoModel: Пока нет реализации!"); //заглушка
        }
    }
}
