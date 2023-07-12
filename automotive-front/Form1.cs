using automotive;
using automotive.Models;
using automotive.Objects;
using automotive.Objects.Chassis;
using automotive.Objects.Engine;
using System.Collections.ObjectModel;

namespace automotive_front
{
    public partial class Form1 : Form
    {
        ObservableCollection<Car> cars = new ObservableCollection<Car>();
        ObservableCollection<Chassis> chassis = new ObservableCollection<Chassis>();
        ObservableCollection<Body> body = new ObservableCollection<Body>();
        ObservableCollection<Engine> engine = new ObservableCollection<Engine>();
        ObservableCollection<EngineState> engineState = new ObservableCollection<EngineState>();
        ObservableCollection<Wheel> wheel = new ObservableCollection<Wheel>();


        public Form1()
        {
            InitializeComponent();

            Load += Form1_Load;
        }

        private void Form1_Load(object? sender, EventArgs e)
        {
            List<Car> sampleCars = new List<Car>
            {
                Sample.SampleVoid(),
                Sample.SampleVoid(),
                Sample.SampleVoid(),
                Sample.SampleVoid(),
                Sample.SampleVoid(),
                Sample.SampleVoid(),
                Sample.SampleVoid(),
                Sample.SampleVoid(),
                Sample.SampleVoid(),
                Sample.SampleVoid(),
                Sample.SampleVoid(),
                Sample.SampleVoid(),
                Sample.SampleVoid(),
                Sample.SampleVoid(),
                Sample.SampleVoid(),
                Sample.SampleVoid(),
                Sample.SampleVoid(),
                Sample.SampleVoid(),
                Sample.SampleVoid(),
                Sample.SampleVoid(),
                new Car()
            };

            foreach (var car in sampleCars)
            {
                cars.Add(car);
                chassis.Add(car.TransportChassis);
                body.Add(car.TransportBody);
                engine.Add(car.TransportEngine);
                engineState.Add(car.TransportEngine.EngineState);
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