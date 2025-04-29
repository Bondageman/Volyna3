using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Volyna3
{
    public abstract class Vehicle
    {
        protected Dictionary<string, object> properties = new Dictionary<string, object>();

        public object this[string key]
        {
            get => properties.ContainsKey(key) ? properties[key] : null;
            set => properties[key] = value;
        }

        public abstract string GetInfo(); 
    }
}
