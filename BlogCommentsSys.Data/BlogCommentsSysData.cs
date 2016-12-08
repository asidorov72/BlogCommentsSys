namespace BlogCommentsSys.Data
{
    using BlogCommentsSys.Data.Repositories;
    using BlogCommentsSys.Models;

    using System;
    using System.Collections.Generic;
    using System.Data.Entity;

    public class BlogCommentsSysData : IBlogCommentsSys
    {
        private DbContext context;
        private Dictionary<Type, object> repositories;

        public BlogCommentsSysData()
            : this(new BlogContext())
        {
        }

        public BlogCommentsSysData(DbContext context)
        {
            this.context = context;
            this.repositories = new Dictionary<Type, object>();
        }

        public DbContext Context
        {
            get
            {
                return this.context;
            }
        }

        public IRepository<ApplicationUser> Users
        {
            get { return this.GetRepository<ApplicationUser>(); }
        }

        public IRepository<Post> Posts
        {
            get { return this.GetRepository<Post>(); }
        }

        public IRepository<Comment> Comments
        {
            get { return this.GetRepository<Comment>(); }
        }

        private IRepository<T> GetRepository<T>() where T : class
        {
            var typeOfRepository = typeof(T);
            if (!this.repositories.ContainsKey(typeOfRepository))
            {
                var newRepository = Activator.CreateInstance(typeof(Repository<T>), context);
                this.repositories.Add(typeOfRepository, newRepository);
            }

            return (IRepository<T>)this.repositories[typeOfRepository];
        }

        public int SaveChanges()
        {
            return this.context.SaveChanges();
        }

        public void Dispose()
        {
            this.context.Dispose();
        }

        public object Entry(Post post)
        {
            throw new NotImplementedException();
        }
    }
}