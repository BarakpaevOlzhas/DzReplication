using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DzReplication
{
    public abstract class Entity
    {
        public Guid Id { set; get; }

        public Entity()
        {
            Id = Guid.NewGuid();
        }
    }
}
