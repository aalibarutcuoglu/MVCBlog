using MVCBlog.DAL.ORM.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCBlog.DAL.ORM.Context
{
    public class BlogContext : DbContext
    {
        public BlogContext()

        {
            Database.Connection.ConnectionString = "Server=ALI;Database=ElectronicMarket;UID=sa;PWD=ahmetali001996";
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

        public DbSet<Post> Posts { get; set; }
        public DbSet<PostLike> PostLikes { get; set; }
        public DbSet<PostCategory> PostCategories { get; set; }
        public DbSet<WebUser> WebUsers { get; set; }
        public DbSet<AdminUser> AdminUsers { get; set; }
        public DbSet<PostImage> PostImages { get; set; }
        public DbSet<PostComment> PostComments { get; set; }


    }
}
