using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Twitter.Clone.Notifier.Features.ShortMessage.Models
{
    public class  ShortMessageModel
    {
        public string PhoneNumber { get; set; } = string.Empty;
        public string MessageBody { get; set; } = string.Empty;
    }
    public static partial class Extensions
    {
        public static ShortMessageModel Map(this ShortMessageModel model)
        {
            return new ShortMessageModel
            {
                PhoneNumber = model.PhoneNumber,
                MessageBody = model.MessageBody,
            };
        }

        public static List<ShortMessageModel> Map(this List<ShortMessageModel> model)
        {
            return model.Select(x => new ShortMessageModel
            {
                PhoneNumber = x.PhoneNumber,
                MessageBody = x.MessageBody,
            }).ToList();
        }
    }
}
