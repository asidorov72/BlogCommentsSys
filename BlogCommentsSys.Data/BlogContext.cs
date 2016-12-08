using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BlogCommentsSys.Models;
using System.Data.Entity;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace BlogCommentsSys.Data
{
    public class BlogContext : IdentityDbContext<ApplicationUser>
    {
        public DbSet<Post> Posts { get; set; }
        public DbSet<Comment> Comments { get; set; }

        public BlogContext() : base("BlogCommentsSystemConnection")
        {

        }

        public static BlogContext Create()
        {
            return new BlogContext();
        }
    }

}