using automotive.Models.Interfaces;
using automotive.Models.Objects;

namespace automotive.Models
{
    /// <summary>
    /// Базовый класс для транспорта
    /// </summary>
    public abstract class Transport : ITransport
    {
        private string? _name;              //имя транспорта, например:    LeapMotor
        private string? _model;             //модель транспорта, например: C11
        private Fuel _fuel;                 //тип горючего, например:      Electric
        private int _year;                  //год выпуска, например:       2023
        private Transmission _transmission; //тип КП, например:            Auto

        public string? Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public string? Model
        {
            get { return _model; }
            set { _model = value; }
        }

        public Fuel Fuel
        {
            get { return _fuel; }
            set { _fuel = value; }
        }

        public int Year
        {
            get { return _year; }
            set 
            { 
                if(value >= 0 && value <= 100)
                {
                    _year = value;
                }
            }
        }

        public Transmission Transmission
        {
            get { return _transmission; }
            set { _transmission = value; }
        }
    }
}