using Homework_Two.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_Two.Models
{
    public class Truck : Vehicle, ICarWash
    {
        public Truck(int drivenKilometers, DateTime yearOfProduction, int horsePower) : base(drivenKilometers, yearOfProduction, horsePower)
        {
        }

        public override void Drive()
        {
            if (FuelTankLitters > 0)
            {
                Console.WriteLine("wrm wrm wrm");
                FuelTankLitters -= 50;
                Console.WriteLine($"You have left {FuelTankLitters} litters in the fuel.");
                if (FuelTankLitters == 0)
                {
                    Console.WriteLine("You need to put fuel in your car nigg for another ride");
                    Console.WriteLine("Wash your car it is Dirty.");
                    IsDirty = true;
                }
            }
            Console.WriteLine("GAS EMPTY FUEL IT UP ");
        }

        public void WashCar()
        {
            throw new NotImplementedException();
        }

        public void WashTrailer()
        {
            if (IsDirty)
            {
                Console.WriteLine("Washing car");
                IsDirty = false;
            }
            Console.WriteLine("Your trailer is clean:)");
        }
    }
}
