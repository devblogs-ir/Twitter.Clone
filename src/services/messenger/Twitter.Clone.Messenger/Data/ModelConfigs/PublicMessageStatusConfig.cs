using Twitter.Clone.Messenger.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Messanger.Data.Configs
{
    public class PublicMessageStatusConfig : IEntityTypeConfiguration<PublicMessageStatus>
    {
        public void Configure(EntityTypeBuilder<PublicMessageStatus> builder)
        {
            builder.HasKey(s => s.PublicMessageStatusId);
            builder.HasOne(s => s.PublicMessage).
                WithMany(x => x.ParticipantStatus).HasForeignKey(x => x.PublicMessageId);
        }
    }
}
