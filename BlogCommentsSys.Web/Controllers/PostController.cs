using BlogCommentsSys.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
//using BlogCommentsSys.Web.Models;
using BlogCommentsSys.Models;
using Microsoft.AspNet.Identity;
using BlogCommentsSys.Web.ViewModels.Post;
using BlogCommentsSys.Web.ViewModels.Comment;

namespace BlogCommentsSys.Web.Controllers
{
    public class PostController : BaseController
    {
        //private ApplicationDbContext db = new ApplicationDbContext();
        //BlogContext db = new BlogContext();

        public PostController(IBlogCommentsSys data) : base(data)
        {
           
        }


        // GET: Posts
        public ActionResult Index()
        {
            //return View(db.Posts.ToList());
            var posts = this.Data.Posts.All().ToList();

            return View(posts);
        }

        // GET: Posts/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var post = this.Data.Posts.Find(id);
            if (post == null)
            {
                return HttpNotFound();
            }
            return View(post);
        }

        [HttpGet]
        public ActionResult Add(int? id)
        {
            string UserId = null;
            UserId = User.Identity.GetUserId();
            return View();
        }

        [HttpPost]
        public ActionResult Add(Post post)
        {
            post.Date = DateTime.Now;
            Data.Posts.Add(post);
            Data.SaveChanges();
            ViewBag.Message = "New post " + post.Title + " was created!";
            return RedirectToAction("Blog", "Home");
        }

        



        // POST: Posts/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,UserId,PostTxt,Date")] Post post)
        {
            if (ModelState.IsValid)
            {
                Data.Posts.Add(post);
                Data.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(post);
        }

        // GET: Posts/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Post post = Data.Posts.Find(id);
            if (post == null)
            {
                return HttpNotFound();
            }
            return View(post);
        }

        

        

        
    }
}
