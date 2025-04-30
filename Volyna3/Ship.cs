using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Volyna3
{
    public class Ship : Vehicle
    {
        public Ship()
        {
            properties["Price"] = 0.0;
            properties["Speed"] = 0.0;
            properties["Year"] = 0;
            properties["Port"] = "";
            properties["Passengers"] = 0;
        }

        public override string GetInfo()
        {
            return $"Ship: {properties["Price"]}$, Speed: {properties["Speed"]}km/h, Year: {properties["Year"]}, " +
                   $"Port: {properties["Port"]}, Passengers: {properties["Passengers"]}";
        }
    }
}
