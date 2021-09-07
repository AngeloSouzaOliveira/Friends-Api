using Microsoft.EntityFrameworkCore;
using Model.Friend;


namespace DAL.DataBase
{
    public class ContextBase : DbContext
    {
       

        public ContextBase(DbContextOptions<ContextBase> options) : base(options)
        {
            Database.EnsureCreated();

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(GetStringConectionConfig());
                base.OnConfiguring(optionsBuilder);
            }
        }

        public DbSet<Friend> friends { get; set; }

       private string GetStringConectionConfig()
        {
            string strCon = "Server=LAPTOP-O8FFVHPF\\SQLEXPRESS01;Database=APIFriends;Trusted_Connection=True;MultipleActiveResultSets=true";
            return strCon;
        }
    }
}
