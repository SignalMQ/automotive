using automotive.Models;
using automotive.Services.Interfaces;

namespace automotive.Services
{
    public class CreateService: ICreateService
    {
        Car CreateCar()
        {
            return new Car();
        }
    }
}
