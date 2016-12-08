using BlogCommentsSys.Models;
//using BlogCommentsSys.Web.Infrastructure.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BlogCommentsSys.Web.ViewModels.Comment
{
    //public class BlogPostViewModel : IHaveCustomMappings
    public class CommentViewModel
    {
        public int Id { get; set; }

        public string UserId { get; set; }

        public int PostId { get; set; }

        public string Author { get; set; }

        public string CommentTxt { get; set; }

        public DateTime Date { get; set; }

        //public string Author { get; set; }

        /*
        public void CreateMappings(AutoMapper.IConfiguration configuration)
        {
            configuration.CreateMap<BlogPost, BlogPostViewModel>()
                .ForMember(p => p.CategoryName, opt => opt.MapFrom(b => b.Category.Title));
        }
        */
    }
}