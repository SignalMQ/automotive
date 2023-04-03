using System.Drawing;

namespace automotive.Classes
{
    /// <summary>
    /// Базовый класс для автомобилья
    /// </summary>
    public class CarModel: Transport
    {
        /// <summary>
        /// Конструктор со свойствами для автомобилья
        /// </summary>
        public CarModel(string Name, string Model, Fuel Fuel, Year Year, Color Color, int RadCount = 4) : base(Name, Model, Fuel, Year)
        {
            this.Color = Color;
            this.RadCount = RadCount;
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
        public bool CheckCar()
        {
            byte ChecksCount = 0; //Шаг при тестировании

            if (_name != null) ChecksCount++;
            if (_model != null) ChecksCount++;
            if (BrokenRadCount == 0 && RadCount > 0) ChecksCount++;

            return ChecksCount == 3 ? true : false;
        }
        /// <summary>
        /// Недочёты найденные в машине
        /// </summary>
        public void CarErrors()
        {
            Line();
            if (_name == null) Console.WriteLine("Нет названия у машины!");
            else if (_model == null) Console.WriteLine("Нет модели у машины!");
            else if (RadCount == BrokenRadCount) Console.WriteLine("У машины нет колёс!");
            if (RadCount > 0 && BrokenRadCount > 0 && RadCount != BrokenRadCount) Console.WriteLine($"У машины не достают колёса: {RadCount - BrokenRadCount}");
            Line();
        }
        /// <summary>
        /// Выводим информацию об машине
        /// </summary>
        public void CarInfo()
        {
            Line();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"Название         => {_name}");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Модель           => {_model}");
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