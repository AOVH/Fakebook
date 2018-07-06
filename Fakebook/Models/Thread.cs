using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Fakebook.Models
{
    public class Thread
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int IdCategory { get; set; }
        public string Description { get; set; }
        public DateTime Created { get; set; } = DateTime.Now;


        /// <summary>
        /// Retorna el nombre de la categoria en base al IdCategory y la lista de categorias
        /// </summary>
        /// <param name="_idCategory"></param>
        /// <param name="_categorias"></param>
        /// <returns></returns>
        public string GetNameCategory(int _idCategory,List<Category> _categorias)
        {
           return _categorias.First(x => x.Id == _idCategory).Name;
        }
    }
    
}