using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Twitter.Clone.Notifier.Shared.Common.Models
{
    public abstract class Entity : IEntity
    {
        public Entity()
        {
            this.Id = Guid.NewGuid();
            CreateAt = DateTime.UtcNow;
        }
        public Guid Id { get ; set ; }
        public DateTime CreateAt { get ; set ; }
    }
}
