namespace BlogCommentsSys.Data
{
    using BlogCommentsSys.Data.Repositories;
    using BlogCommentsSys.Models;
    using System.Data.Entity;

    public interface IBlogCommentsSys
    {
        IRepository<ApplicationUser> Users { get; }

        IRepository<Post> Posts { get; }

        IRepository<Comment> Comments { get; }

        DbContext Context { get; }

        int SaveChanges();
    }
}