namespace MvcFriends.Data
{
    public class FriendContext : DbContext
    {
        public FriendContext(DbContextOptions<FriendContext> options) : base(options)
        {

        }
        public DbSet<Friend> Friends { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //這裡是建立種子資料
            modelBuilder.Entity<Friend>().HasData(
                new Friend { Id = 1, Name = "Mary", Email = "mary@gmail.com", Mobile = "0922-355822" },
                new Friend { Id = 2, Name = "David", Email = "david@gmail.com", Mobile = "0933-123456" },
                new Friend { Id = 3, Name = "Rose", Email = "rose@gmail.com", Mobile = "0955-888-163" }
            );
         }
    }
}