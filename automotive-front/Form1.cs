using automotive;
using automotive.Models;
using automotive.Objects;
using automotive.Objects.Chassis;
using automotive.Objects.Engine;
using Newtonsoft.Json;
using System.Collections.ObjectModel;

namespace automotive_front
{
    public partial class Form1 : Form
    {
        private ObservableCollection<Car> cars = new ObservableCollection<Car>();
        private ObservableCollection<Chassis> chassis = new ObservableCollection<Chassis>();
        private ObservableCollection<Body> body = new ObservableCollection<Body>();
        private ObservableCollection<Engine> engine = new ObservableCollection<Engine>();
        private ObservableCollection<EngineState> engineState = new ObservableCollection<EngineState>();
        private ObservableCollection<Wheel> wheel = new ObservableCollection<Wheel>();

        public Form1()
        {
            InitializeComponent();

            this.Load += Form1_Load;
        }

        private string PrepareJson()
        {
            List<Car> sampleCars = new()
            {
                Sample.SampleData(),
                Sample.SampleData(),
                Sample.SampleData(),
                Sample.SampleData(),
                Sample.SampleData(),
                Sample.SampleData(),
                Sample.SampleData(),
                Sample.SampleData(),
                Sample.SampleData(),
                Sample.SampleData(),
                Sample.SampleData(),
                Sample.SampleData(),
                Sample.SampleData(),
                Sample.SampleData(),
                Sample.SampleData(),
                Sample.SampleData(),
                Sample.SampleData(),
                Sample.SampleData(),
                Sample.SampleData(),
                Sample.SampleData(),
            };

            string result = JsonConvert.SerializeObject(sampleCars, Formatting.None);

            return result;
        }

        private void Form1_Load(object? sender, EventArgs e)
        {
            var serialized = PrepareJson();

            var deserialized = JsonConvert.DeserializeObject<List<Car>>(serialized);

            foreach (var car in deserialized)
            {
                cars.Add(car);
                engine.Add(car.TransportEngine);
                engine.Add(car.TransportEngine);
                engineState.Add(car.TransportEngine.EngineState);
                chassis.Add(car.TransportChassis);
                body.Add(car.TransportBody);
                wheel.Add(car.TransportChassis.Wheel);
            }

            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = cars;

            dataGridView2.AutoGenerateColumns = false;
            dataGridView2.DataSource = engine;

            dataGridView3.AutoGenerateColumns = false;
            dataGridView3.DataSource = engineState;

            dataGridView4.AutoGenerateColumns = false;
            dataGridView4.DataSource = chassis;

            dataGridView5.AutoGenerateColumns = false;
            dataGridView5.DataSource = body;

            dataGridView6.AutoGenerateColumns = false;
            dataGridView6.DataSource = wheel;
        }
    }
}