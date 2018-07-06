using Fakebook.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Fakebook.ViewModels
{
    public class DetailThread
    {
        public List<Category> Categories { get; set; }
        public List<Comment> Comments { get; set; }
        public Thread Thread { get; set; }
        public Comment Comment { get; set; }

        /// <summary>
        /// Para poder acceder al detalle del Thread es necesario cargar toda la infomación previa
        /// </summary>
        /// <param name="_categories"></param>
        /// <param name="_comments"></param>
        /// <param name="_thread"></param>
        /// <param name="_comment"></param>
        public DetailThread
        (
            List<Category> _categories
            , List<Comment> _comments
            , Thread _thread
            , Comment _comment
        )
        {
            Categories = _categories;
            Comments = _comments;
            Thread = _thread;
            Comment = _comment;

        } 

        public DetailThread()
        {

        }
    }
}