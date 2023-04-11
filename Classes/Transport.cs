namespace automotive.Classes
{
    /// <summary>
    /// Тип данных для используемый в качестве года выпуска транспорта.
    /// Принимает значение от 1000 до 9999.
    /// </summary>
    public struct Year
    {
        int value;

        private const int MAX_VALUE = 9999;
        private const int MIN_VALUE = 1000;

        public static implicit operator Year(int _value)
        {
            if (_value > MAX_VALUE | _value < MIN_VALUE)
            {
                throw new ArgumentOutOfRangeException($"Значение {_value} не входит в диапазон {MIN_VALUE} и {MAX_VALUE}");
            }
            else
            {
                return new Year { value = _value };
            }
        }

        public static explicit operator int(Year _value)
        {
            return _value.value;
        }
    }
    /// <summary>
    /// Тип перечислений для определения горючего транспорта
    /// </summary>
    public enum Fuel
    {
        Petrol,
        Diesel,
        Electric,
        Metan
    }
    /// <summary>
    /// Тип перечислений для определения типа коробки передач
    /// </summary>
    public enum Transmission
    {
        Mechanic,
        Auto,
        Semi_auto,
        None
    }
    /// <summary>
    /// Базовый класс для транспорта
    /// </summary>
    public abstract class Transport
    {
        public string? Name { get; set; }  //имя транспорта, например:     LeapMotor
        public string? Model { get; set; } //модель транспорта, например:  C11
        public Fuel Fuel { get; set; }     //тип горючего, например:       Electric
        public Year Year { get; set; }     //год выпуска, например:        2023
        public Transmission Transmission { get; set; } //тип КП, например: Auto

        /// <summary>
        /// Проверка состояния объекта
        /// </summary>
        /// <returns>bool</returns>
        public abstract bool Check();
        /// <summary>
        /// Отображает информацию об объекте
        /// </summary>
        public abstract void ShowInfo();
    }
}