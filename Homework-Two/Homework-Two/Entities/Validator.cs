using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Homework_Two.Entities
{
    public static class Validator
    {
        public static bool Validate(Vehicle vehicle)
        {
            //if (vehicle.Id != 0)        /// Nemozam da ja koristam ovaa poso GUID staviv . . . ama ete neka sedi
            //{
            //    return true;
            //}
            //return false;
            if (String.IsNullOrEmpty(vehicle.Type) || vehicle.YearOfProduction.Year == 0) // Na Year ako stavam 0 u DB frla exepction . .
            {
                return false;
            }
            return true;
        }

    }
}
