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
        public CarModel(string name, string model, Fuel fuel, Year year, Color color, int radCount = 4)
        {
            Name     = name;
            Model    = model;
            Fuel     = fuel;
            Year     = year;
            Color    = color;
            RadCount = radCount;
        }

        /// <summary>
        /// Количество колёс в машине
        /// </summary>
        public int RadCount { get; set; }
        /// <summary>
        /// Цвет машины. По умолчания белый.
        /// </summary>
        public Color Color { get; set; } = Color.White;
        /// <summary>
        /// Количество сломанных колёс
        /// </summary>
        private int BrokenRadCount { get; set; }
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

            return ChecksCount == 3 ? true : false;
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
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"Название         => {Name}");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Модель           => {Model}");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"Количество колёс => {RadCount}");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($"Цвет             => {Color.Name}");
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