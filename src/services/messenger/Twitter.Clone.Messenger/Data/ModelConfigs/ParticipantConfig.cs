using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Twitter.Clone.Messenger.Models;

namespace Messanger.Data.Configs
{
    public class ParticipantConfig : IEntityTypeConfiguration<Participant>
    {
        public void Configure(EntityTypeBuilder<Participant> builder)
        {
            builder.HasKey(x => x.UserId);

            builder.HasOne(x => x.PublicChat).WithMany(x => x.Participants);

        }
    }
}
