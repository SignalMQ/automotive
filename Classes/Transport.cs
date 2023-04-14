using System.Reflection.Metadata.Ecma335;

namespace automotive.Classes
{
    /// <summary>
    /// Тип данных для используемый в качестве года выпуска транспорта.
    /// Принимает значение от 1000 до 9999.
    /// </summary>
    public struct Year
    {
        private int value;

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
            return (int)_value.value;
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
        private string?      _name;         //имя транспорта, например:    LeapMotor
        private string?      _model;        //модель транспорта, например: C11
        private Fuel         _fuel;         //тип горючего, например:      Electric
        private Year         _year;         //год выпуска, например:       2023
        private Transmission _transmission; //тип КП, например:            Auto
        
        public string? Name 
        { 
            get { return _name;  }
            set { _name = value; } 
        }

        public string? Model 
        { 
            get { return _model; }
            set { _model = value;}
        } 

        public Fuel Fuel 
        {
            get { return _fuel;  }
            set { _fuel = value; }
        }

        public Year Year 
        { 
            get { return _year;  }
            set { _year = value; }
        }     

        public Transmission Transmission 
        { 
            get { return _transmission;  }
            set { _transmission = value; }
        } 

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