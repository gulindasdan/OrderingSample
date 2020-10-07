using OrderingSample.Core.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace OrderingSample.Entities
{
    public class Customer : IEntity<string>
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? ModifiedAt { get; set; }

        public virtual IEnumerable<Order> Orders { get; set; }
    }
}
