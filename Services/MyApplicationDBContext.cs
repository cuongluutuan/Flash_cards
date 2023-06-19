using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Services.Models;

namespace Services
{
    public class MyApplicationDBContext : DbContext
    {
        public MyApplicationDBContext() { }

        public MyApplicationDBContext(DbContextOptions<MyApplicationDBContext> options) : base(options) { }


        public virtual DbSet<CardEntry> CardEntry { get; set; }
        public virtual DbSet<CardsCollection> CardsCollection { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                //optionsBuilder.UseSqlServer("Server=(local);uid=sa;pwd=12345;database=FlashCard;TrustServerCertificate=True");
                optionsBuilder.UseSqlServer(GetConnectionString());
            }
        }

        private string GetConnectionString()
        {
            IConfiguration config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", true, true)
                .Build();
            var strConn = config["ConnectionStrings:FlashCardDB"];
            return strConn;
        }

    }
}