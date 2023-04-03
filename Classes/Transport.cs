namespace automotive.Classes
{
    /// <summary>
    /// Тип данных для используемый в качестве года выпуска транспорта
    /// </summary>
    public struct Year
    {
        private int Value;
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
                return new Year { Value = _value };
            }
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
    /// Базовый класс для транспорта
    /// </summary>
    public class Transport
    {
        public string? _name { get; set; }  //имя транспорта, например:    LeapMotor
        public string? _model { get; set; } //модель транспорта, например: C11
        public Fuel _fuel { get; set; }     //тип горючего, например:      Electric
        public Year _year { get; set; }     //год выпуска, например:       2023

        public Transport(string name, string model, Fuel fuel, Year year)
        {
            _name = name;
            _model = model;
            _fuel = fuel;
            _year = year;
        }
    }
}