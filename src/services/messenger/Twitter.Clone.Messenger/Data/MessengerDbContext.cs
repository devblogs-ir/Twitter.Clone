using Twitter.Clone.Messenger.Models;
using Messanger.Data.Configs;
using Microsoft.EntityFrameworkCore;

namespace Messanger.Data
{

    public partial class MessengerDbContext : DbContext
    {
        public MessengerDbContext(DbContextOptions options) : base(options)
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            string cs = $"Data Source={Environment.MachineName};Initial Catalog=MessengerDB;Persist Security Info=True;User ID=sa;Password=123;TrustServerCertificate=True";
            optionsBuilder.EnableSensitiveDataLogging(true);
            optionsBuilder.UseSqlServer(cs);
        }

        public virtual DbSet<Participant> Participants { get; set; }
        public virtual DbSet<PrivateChat> PrivateChats { get; set; }
        public virtual DbSet<PrivateMessage> PrivateMessages { get; set; }
        public virtual DbSet<PublicChat> PublicChats { get; set; }
        public virtual DbSet<PublicMessage> PublicMessages { get; set; }
        public virtual DbSet<PublicMessageStatus> PublicMessageStatus { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ParticipantConfig());
            modelBuilder.ApplyConfiguration(new PrivateChatConfig());
            modelBuilder.ApplyConfiguration(new PrivateMessageConfig());
            modelBuilder.ApplyConfiguration(new PublicChatConfig());
            modelBuilder.ApplyConfiguration(new PublicChatConfig());
            modelBuilder.ApplyConfiguration(new PublicMessageConfig());
            modelBuilder.ApplyConfiguration(new PublicMessageStatusConfig());
            OnModelCreatingPartial(modelBuilder);
        }
        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}