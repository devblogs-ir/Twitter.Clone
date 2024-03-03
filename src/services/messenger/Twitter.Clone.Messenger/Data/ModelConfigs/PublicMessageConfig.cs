using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Twitter.Clone.Messenger.Models;

namespace Messanger.Data.Configs
{
    public class PublicMessageConfig : IEntityTypeConfiguration<PublicMessage>
    {
        public void Configure(EntityTypeBuilder<PublicMessage> builder)
        {
            builder.HasKey(x => x.Id);
            builder.HasOne(x => x.PublicChat).
                WithMany(x => x.PublicMessages).
                HasForeignKey(x => x.ChatId);

            builder.HasMany(x => x.ParticipantStatus).WithOne(x => x.PublicMessage).
                HasForeignKey(x=>x.PublicMessageId);
        }
    }
}
