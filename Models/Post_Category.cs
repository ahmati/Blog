namespace blog.Models
{
    public class Post_Category
    {
        public int PostId { get; set; }
        public Post Post { get; set; }

        public int Category_Id { get; set; }
        public Category Category { get; set; }
    }
}
