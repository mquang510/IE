using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IE.Shared.Entity
{
    public class BaseEntity
    {
        public BaseEntity()
        {
            this.Id = Guid.NewGuid();
        }
        public Guid Id { get; set; }
    }
}
