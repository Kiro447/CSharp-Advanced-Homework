using Homework_Three.Entities.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_Three.Entities
{
    public abstract class BaseEntity
    {
        public int Id { get; set; }
        public string Brand { get; set; } = string.Empty;
        public string Model { get; set; } = string.Empty;
        public int MaxSpeed { get; set; }
        public int HorsePower { get; set; }
        public FuelType FuelType { get; set; }

        public BaseEntity(int id, string brand, string model, int maxSpeed, int horsePower, FuelType fuelType)
        {
            Id = id;
            Brand = brand;
            Model = model;
            MaxSpeed = maxSpeed;
            HorsePower = horsePower;
            FuelType = fuelType;
        }
        public abstract void Drive(string destinationName);
    }
}
