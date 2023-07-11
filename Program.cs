using automotive.Models;

namespace automotive
{
    internal class Program
    {
        static void Main()
        {
            List<Transport> Models = new()
            {
                new Car(), 
                new Moto()
            };

            foreach (var model in Models)
            {
                Console.WriteLine(model.ToString());
            }
        }
    }
}