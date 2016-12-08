using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using BlogCommentsSys.Data;
using System.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AutoMapper;
using Microsoft.AspNet.Identity;
using AutoMapper.QueryableExtensions;
using BlogCommentsSys.Web.ViewModels;
using BlogCommentsSys.Web.ViewModels.Post;
using BlogCommentsSys.Web.ViewModels.Comment;

namespace BlogCommentsSys.Web.Controllers
{
    public class HomeController : BaseController
    {
        public HomeController(IBlogCommentsSys data) : base(data)
        {
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Blog()
        {
            string UserId = null;
            string UserName = null;
            if (User.Identity.IsAuthenticated)
            {
                UserName = User.Identity.Name;
                UserId = User.Identity.GetUserId();
            }

            ViewBag.UserId = UserId;
            ViewBag.Author = UserName;

            var posts = this.Data.Posts.All().ToList();
            var comments = this.Data.Comments.All().ToList();

            ViewBag.Posts = posts.OrderByDescending(p => p.Date).ToList();
            ViewBag.Comments = comments.OrderByDescending(c => c.Date).ToList();

            ViewBag.Message = "Your posts should be here";

            return View();
        }
    }
}