using Homework_Three.Entities.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_Three.Entities
{
    public class JapaneseCar : BaseEntity
    {
        public JapaneseCar(int id, string brand, string model, int maxSpeed, int horsePower, FuelType fuelType) : base(id, brand, model, maxSpeed, horsePower, fuelType)
        {
        }

        public override void Drive(string destinationName)
        {
            Console.WriteLine($"Driving to {destinationName}");
        }
    }
}
