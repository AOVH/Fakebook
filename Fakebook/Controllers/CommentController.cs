using Fakebook.Context;
using Fakebook.Models;
using Fakebook.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Fakebook.Controllers
{
    public class CommentController : Controller
    {
        // GET: Comment
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult AddComment(DetailThread _detailThread)
        {
            using (FakebookContext Fk = new FakebookContext())
            {
                _detailThread.Comment.IdThread = _detailThread.Thread.Id;
                Fk.Comments.Add(_detailThread.Comment);
                Fk.SaveChanges();
                return RedirectToAction("Detail", "Thread",new{_id = _detailThread.Thread.Id });
            }

        }
    }
}