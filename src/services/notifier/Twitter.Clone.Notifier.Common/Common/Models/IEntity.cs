using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Twitter.Clone.Notifier.Shared.Common.Models
{
    public interface IEntity
    {
        public Guid Id { get; set; }
        public DateTime CreateAt { get; set; }
    }
}
