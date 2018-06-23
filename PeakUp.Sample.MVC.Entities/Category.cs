using System;
using System.Collections.Generic;
using System.Text;

namespace PeakUp.Sample.MVC.Entities
{
    public class Category : Entity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public List<Product> Products { get; set; } = new List<Product>();
    }
}
