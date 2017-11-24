using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Service.DAO
{
    public class FlexibleObject
    {
        private Dictionary<string, Property> properties = new Dictionary<string, Property>();

        public string this[string name]
        {
            get
            {
                if (properties.ContainsKey(name))
                {
                    return properties[name].Value;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                if (properties.ContainsKey(name))
                {
                    properties[name].Value = value;
                }
                else
                {
                    properties.Add(name, new Property(name, "string", value));
                }
            }
        }
    }
}