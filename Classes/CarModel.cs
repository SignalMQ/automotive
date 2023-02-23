using System.Drawing;

namespace automotive.Classes
{
    /// <summary>
    /// Базовый класс для автомобилья
    /// </summary>
    public class CarModel: ICarModel
    {
        /// <summary>
        /// Название машины. Например: Lamborghini
        /// </summary>
        public string? Name { get; set; }
        /// <summary>
        /// Модель машины. Например: Aventador
        /// </summary>
        public string? Model { get; set; }
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
        public int BrokenRadCount { get; set; }
        /// <summary>
        /// Проверка автомобилья на соответствие
        /// </summary>
        /// <returns>True, False</returns>
        public bool CheckCar()
        {
            byte ChecksCount = 0; //Шаг при тестировании

            if (Name != null) ChecksCount++;
            if (Model != null) ChecksCount++;
            if (RadCount != BrokenRadCount && RadCount > BrokenRadCount) ChecksCount++;

            return ChecksCount >= 3;
        }
        /// <summary>
        /// Недочёты найденные в машине
        /// </summary>
        public void CarErrors()
        {
            Line();
            if (Name == null) Console.WriteLine("Нет названия у машины!");
            if (Model == null) Console.WriteLine("Нет модели у машины!");
            if (RadCount != 0 && BrokenRadCount != 0) Console.WriteLine($"У машины не достают колёса: {RadCount - BrokenRadCount}");
            else if(RadCount == 0) Console.WriteLine("У машины нет колёс!");
            Line();
        }
        /// <summary>
        /// Выводим информацию об машине
        /// </summary>
        public void CarInfo()
        {
            Line();
            Console.WriteLine("Название => ", Name);
            Line();
        }

        private void Line()
        {
            for (int i = 0; i < Console.BufferWidth; i++) //Отрисовываем до конца консоли
            {
                Console.Write("=");
            }
        }
    }
}