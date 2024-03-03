using Microsoft.EntityFrameworkCore;
using Twitter.Clone.Messenger.Models;

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
            
        }

        public virtual DbSet<Participant> Participants { get; set; }
        public virtual DbSet<PrivateChat> PrivateChats { get; set; }
        public virtual DbSet<PrivateMessage> PrivateMessages { get; set; }
        public virtual DbSet<PublicChat> PublicChats { get; set; }
        public virtual DbSet<PublicMessage> PublicMessages { get; set; }
        public virtual DbSet<PublicMessageStatus> PublicMessageStatus { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(MessengerDbContext).Assembly);

            OnModelCreatingPartial(modelBuilder);
        }
        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}