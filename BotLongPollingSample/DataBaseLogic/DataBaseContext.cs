using Microsoft.EntityFrameworkCore;
using BotLongPollingSample.DataBaseLogic.Tables;

namespace BotLongPollingSample.DataBaseLogic
{
    internal class DataBaseContext : DbContext
    {
        public DbSet<Users> Users { get; set; }
        public DbSet<UserWords> UserWords { get; set; }
        public DbSet<WordsTranslation> WordsTranslation { get; set; }
        public DataBaseContext()
        {
            Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=postgres;Username=molly;Password=666");

        }
    }
}
