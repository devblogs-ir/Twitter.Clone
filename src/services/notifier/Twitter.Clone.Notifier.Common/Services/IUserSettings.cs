using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Twitter.Clone.Notifier.Shared.Services
{
    public interface IUserSettings
    {
        object GetAsync(string userId);
    }
}
