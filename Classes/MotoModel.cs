using System.Drawing;

namespace automotive.Classes
{
    public class MotoModel : Transport
    {
        /// <summary>
        /// Базовый конструктор для класса мотоцикла
        /// </summary>
        /// <param name="name"></param>
        /// <param name="model"></param>
        /// <param name="fuel"></param>
        /// <param name="color"></param>
        /// <param name="radCount"></param>
        public MotoModel(string name, string model, Fuel fuel, Year year, Color color, int radCount = 2)
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
