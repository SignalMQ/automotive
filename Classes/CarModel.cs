using System.Drawing;

namespace automotive.Classes
{
    /// <summary>
    /// Базовый класс для автомобилья
    /// </summary>
    public class CarModel : Transport
    {
        /// <summary>
        /// Конструктор со свойствами для автомобилья
        /// </summary>
        public CarModel(string name, string model, Fuel fuel, Transmission transmission, Year year, Color color, int radCount = 4)
        {
            Name         = name;
            Model        = model;
            Fuel         = fuel;
            Transmission = transmission;
            Year         = year;
            Color        = color;
            RadCount     = radCount;
        }

        private int   _radCount;            // Количество колёс в машине
        private Color _color = Color.White; // Цвет машины. По умолчания белый.
        private int   _brokenRadCount;      // Количество сломанных колёс

        public int RadCount 
        { 
            get { return _radCount;  }
            set { _radCount = value; }
        }

        public Color Color 
        { 
            get { return _color;  }
            set { _color = value; }
        }

        private int BrokenRadCount
        {
            get { return _brokenRadCount;  }
            set { _brokenRadCount = value; }
        }

        /// <summary>
        /// Проверка автомобилья на соответствие
        /// </summary>
        /// <returns>True, False</returns>
        public override bool Check()
        {
            byte ChecksCount = 0; //Шаг при тестировании

            if (Name          != null) ChecksCount++;
            if (Model         != null) ChecksCount++;
            if (BrokenRadCount == 0 && RadCount > 0) ChecksCount++;

            return ChecksCount == 3;
        }

        /// <summary>
        /// Недочёты найденные в машине
        /// </summary>
        public void CarErrors()
        {
            Line();
            if (Name                                            == null) Console.WriteLine("Нет названия у машины!");
            else if (Model                                      == null) Console.WriteLine("Нет модели у машины!");
            else if (RadCount                                   == BrokenRadCount) Console.WriteLine("У машины нет колёс!");
            if (RadCount > 0 && BrokenRadCount > 0 && RadCount != BrokenRadCount) Console.WriteLine($"У машины не достают колёса: {RadCount - BrokenRadCount}");
            Line();
        }

        /// <summary>
        /// Выводим информацию об машине
        /// </summary>
        public override void ShowInfo()
        {
            Line();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"Название            => {Name}");
            Console.WriteLine($"Модель              => {Model}");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Год выпуска         => {(int)Year}");
            Console.WriteLine($"Тип каробки передач => {Transmission}");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"Количество колёс    => {RadCount}");
            Console.WriteLine($"Цвет                => {Color.Name}");
            Console.ForegroundColor = ConsoleColor.White;
            Line();
        }
        private static void Line() //наложение линии-разделителья
        {
            for (int i = 0; i < Console.BufferWidth; i++) //Отрисовываем до конца консоли
            {
                Console.Write("=");
            }
        }

        /// <summary>
        /// Ломаем колёса машины
        /// </summary>
        public void BreakRad(int count)
        {
            if (count <= RadCount)
            {
                BrokenRadCount += count;
            }
            else
            {
                throw new Exception($"Значение {count} выходит за границы доступного: {RadCount}");
            }
        }
    }
}