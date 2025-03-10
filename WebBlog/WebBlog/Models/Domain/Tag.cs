namespace WebBlog.Models.Domain
{
    public class Tag
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public string DisplayNamae { get; set; }

        public ICollection<BlogPost> BlogPosts { get; set; }
    }
}
