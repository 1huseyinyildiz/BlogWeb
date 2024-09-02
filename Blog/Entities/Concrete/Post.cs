using Data.Entities.Concrete;

namespace Entities.Concrete
{
    public class Post : BaseClass
    {
        public string Title { get; set; } = null!;

        public string Content { get; set; } = null!;

        public int AuthorId { get; set; }

        public User Author { get; set; } = null!;
    }
}
