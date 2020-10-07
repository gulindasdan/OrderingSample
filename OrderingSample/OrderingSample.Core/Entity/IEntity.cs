using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace OrderingSample.Core.Entity
{
    public interface IEntity : IEntity<int> { }
    public interface IEntity<TKey>
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        TKey Id { get; set; }
        DateTime CreatedAt { get; set; }

        DateTime? ModifiedAt { get; set; }

    }
}
