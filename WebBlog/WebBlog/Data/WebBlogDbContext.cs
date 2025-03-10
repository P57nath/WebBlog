using Microsoft.EntityFrameworkCore;
using WebBlog.Models.Domain;

namespace WebBlog.Data
{
    public class WebBlogDbContext : DbContext
    {
        public WebBlogDbContext(DbContextOptions options) : base(options)
        {

        }


        public DbSet<BlogPost> BlogPosts{ get; set; }// One Blogpost have one or above tags  & ViceBarca

        public DbSet<Tag> Tags { get; set; } //Many to Many relationship  to Blogpost

    }
}
