using Homework_Three.Entities.Enum;

namespace Homework_Three.Entities
{
    public class ItalianCar : BaseEntity
    {
        public ItalianCar(int id, string brand, string model, int maxSpeed, int horsePower, FuelType fuelType) : base(id, brand, model, maxSpeed, horsePower, fuelType)
        {
        }

        public override void Drive(string destinationName)
        {
            Console.WriteLine($"Driving to {destinationName}");
        }
    }
}
