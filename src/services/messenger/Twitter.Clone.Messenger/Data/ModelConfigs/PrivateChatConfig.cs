using Twitter.Clone.Messenger.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Messanger.Data.Configs
{

    public partial class PrivateChatConfig : IEntityTypeConfiguration<PrivateChat>
    {
        public void Configure(EntityTypeBuilder<PrivateChat> builder)
        {
            builder.HasKey(pc => pc.ChatId);
            builder.Property(pc => pc.LastMessageBrief).HasMaxLength(50);
            builder.HasMany(pc => pc.PrivateMessages).WithOne(p => p.PrivateChat).HasForeignKey(p=>p.PrivateChatId);
        }
    }
}
