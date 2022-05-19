using System.Data.Common;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace EL
{
    public partial class PostsContext : DbContext
    {
        public PostsContext()
            : base("name=PostsContext")
        {
            Database.SetInitializer<PostsContext>(new PostDbInitializer<PostsContext>());
        }

        public PostsContext(DbConnection connection, IDatabaseInitializer<PostsContext> initializer) :base (connection,true)
        {
            Database.SetInitializer<PostsContext>(initializer);
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.HasDefaultSchema("Comments");
        }


        public virtual DbSet<Comment> Comments { get; set; }
        public virtual DbSet<Post> Posts { get; set; }
        public virtual DbSet<User> Users { get; set; }
    }
}