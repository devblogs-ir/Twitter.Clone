using Twitter.Clone.Messenger.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Messanger.Data.Configs
{
    public class PrivateMessageConfig : IEntityTypeConfiguration<PrivateMessage>

    {
        public void Configure(EntityTypeBuilder<PrivateMessage> builder)
        {
            builder.HasKey(x => x.PrivateMessageId);
            builder.HasOne(x=>x.PrivateChat).
                WithMany(y=>y.PrivateMessages).
                HasForeignKey(x=>x.PrivateChatId);
        }
    }
}
