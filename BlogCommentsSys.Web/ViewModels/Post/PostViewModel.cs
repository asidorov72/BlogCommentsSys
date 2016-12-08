using BlogCommentsSys.Models;
//using BlogCommentsSys.Web.Infrastructure.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BlogCommentsSys.Web.ViewModels.Post
{
    //public class BlogPostViewModel : IHaveCustomMappings
    public class PostViewModel
    {
        public int Id { get; set; }

        public string UserId { get; set; }

        public string Title { get; set; }

        public string PostTxt { get; set; }

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