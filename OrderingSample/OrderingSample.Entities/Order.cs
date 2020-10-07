using OrderingSample.Core.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace OrderingSample.Entities
{
    public class Order : IEntity<string>
    {
        public string Id { get ; set ; }
        public string ImageUrl { get; set; }
        public string CustomerId { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }
        public string Status { get; set; }
        public DateTime CreatedAt { get ; set ; }
        public DateTime? ModifiedAt { get ; set ; }

        public virtual Customer Customer { get; set; }
    }
}
