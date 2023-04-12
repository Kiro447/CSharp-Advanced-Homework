using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_Two.Models
{
    public abstract class Vehicle
    {
        public int DrivenKilometers { get; set; }
        public DateTime YearOfProduction { get; set; }
        public int HorsePower { get; set; }
        protected int FuelTankLitters { get; set; } = 100;
        protected bool IsDirty { get; set; } = false;
        public Vehicle(int drivenKilometers, DateTime yearOfProduction, int horsePower)
        {
            DrivenKilometers = drivenKilometers;
            YearOfProduction = yearOfProduction;
            HorsePower = horsePower;
        }
        public abstract void Drive();
    }
}
