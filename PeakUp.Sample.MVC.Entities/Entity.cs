using System;

namespace PeakUp.Sample.MVC.Entities
{
    public class Entity
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();
    }
}
