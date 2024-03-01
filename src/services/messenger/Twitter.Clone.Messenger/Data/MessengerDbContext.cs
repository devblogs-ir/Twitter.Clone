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
            //string cs = $"Data Source={Environment.MachineName};Initial Catalog=MessengerDB;Persist Security Info=True;User ID=sa;Password=123;TrustServerCertificate=True";
            string cs = "Data Source=.\\MSSQLSERVER2019;Initial Catalog=MessengerDB;Persist Security Info=True;User ID=sa;Password=!QAZ2wsx;TrustServerCertificate=True";
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
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(MessengerDbContext).Assembly);

            OnModelCreatingPartial(modelBuilder);
        }
        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}