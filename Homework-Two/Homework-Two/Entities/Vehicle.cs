using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_Two.Entities
{
    public abstract class Vehicle
    {
        public Guid Id { get; set; }
        public string Type { get; set; } = string.Empty;
        public DateTime YearOfProduction { get; set; }
        public int BatchNumber { get; set; }

        public Vehicle(string type, DateTime yearOfProduction, int batchNumber)
        {
            Id = Guid.NewGuid();
            Type = type;
            YearOfProduction = yearOfProduction;
            BatchNumber = batchNumber;
        }

        public abstract void PrintVehicle();

    }
}
