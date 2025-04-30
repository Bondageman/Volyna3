using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Volyna3
{
    public class Car : Vehicle
    {
        public Car()
        {
            properties["Price"] = 0.0;
            properties["Speed"] = 0.0;
            properties["Year"] = 0;
        }

        public override string GetInfo()
        {
            return $"Car: {properties["Price"]}$, Speed: {properties["Speed"]}km/h, Year: {properties["Year"]}";
        }
    }
}
