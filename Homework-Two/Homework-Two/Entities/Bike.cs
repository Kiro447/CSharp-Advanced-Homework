using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_Two.Entities
{
    public class Bike : Vehicle
    {
        public Bike( string type, DateTime yearOfProduction, int batchNumber, string color) : base(type, yearOfProduction, batchNumber)
        {
            Color = color;
        }

        public string Color { get; set; }
        public override void PrintVehicle()
        {
            Console.WriteLine($"Bike model : {Type} \n Bike color: {Color}");
        }
    }
}
