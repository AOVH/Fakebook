using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Fakebook.Models
{
    public class Comment
    {
        public int Id { get;  set; }
        public string Author { get; set; }
        public string CommentText { get; set; }
        public int IdThread { get; set; }
        public DateTime Created { get; set; } = DateTime.Now;

    }
}