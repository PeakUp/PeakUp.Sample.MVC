using System;
using System.Collections.Generic;
using System.Text;

namespace PeakUp.Sample.MVC.Entities
{
    public class Product : Entity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public double InStock { get; set; }
        public string CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
