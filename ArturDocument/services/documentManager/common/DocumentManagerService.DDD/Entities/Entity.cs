using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentManagerService.DDD
{
    public abstract class Entity<T> : IEntity<T>
    {
        public Entity()
        {
            
        }
        public Entity(T id)
        {
            Id = id;
        }
        public T Id { get; set; }
    }
}
