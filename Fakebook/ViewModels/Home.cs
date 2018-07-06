using Fakebook.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Fakebook.ViewModels
{
    public class Home
    {
        public List<Thread> Threads { get; set; }
        public List<Category> Categories { get; set; }

        /// <summary>
        /// Para utilizar el el modelo Home es necesario que carge previamente todos los datos requeridos
        /// </summary>
        /// <param name="_threads"></param>
        /// <param name="_categories"></param>
        public Home(List<Thread> _threads, List<Category> _categories)
        {
            Threads = _threads;
            Categories = _categories;

        }


    }

}