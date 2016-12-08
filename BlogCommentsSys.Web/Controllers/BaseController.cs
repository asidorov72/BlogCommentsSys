using BlogCommentsSys.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;

namespace BlogCommentsSys.Web.Controllers
{
    public class BaseController : Controller
    {
        private BlogContext blogContext;

        public BaseController(IBlogCommentsSys data)
        {
            this.Data = data;
        }

        protected IBlogCommentsSys Data { get; set; }
    }
}