using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnlineShoping.Models
{

    public class Manufacture
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public string Origin { get; set; }
    }

    public class Catergory
    {
        public Catergory(string name)
        {
            this.Name = name;
        }

        public string Name { get; set; }
    }

    public class ModelAddProduct
    {

        public ModelAddProduct(List<Catergory> catergories, List<Manufacture> manufactures)
        {
            Catergories = catergories;
            Manufactures = manufactures;
        }

        public List<Manufacture> Manufactures { get; set; }
        public List<Catergory> Catergories { get; set; }
    }
}