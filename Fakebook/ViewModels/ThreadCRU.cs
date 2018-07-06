using Fakebook.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Fakebook.ViewModels
{
    public class ThreadCRU
    {
        public List<Thread> Threads { get; set; }
        public List<Category> Categories { get; set; }
        public Thread Thread { get;set; }

        /// <summary>
        /// Para utilizar el el modelo ThreadCRU es necesario que carge previamente todos los datos requeridos
        /// </summary>
        /// <param name="_categories"></param>
        public ThreadCRU(List<Category> _categories)
        {

            Categories = _categories;

        }
        public ThreadCRU()
        {

        }
    }

    
}