using Twitter.Clone.Messenger.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Messanger.Data.Configs
{
    public class PublicChatConfig : IEntityTypeConfiguration<PublicChat>
    {
        public void Configure(EntityTypeBuilder<PublicChat> builder)
        {
            builder.HasKey(x => x.ChatId);
            builder.HasMany(x => x.PublicMessages).
                WithOne(x => x.PublicChat).
                HasForeignKey(x => x.ChatId);
           
        }
    }
}
