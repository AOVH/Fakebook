using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Fakebook.Context;
using Fakebook.Models;
using Fakebook.ViewModels;

namespace Fakebook.Controllers
{
    public class ThreadController : Controller
    {
        // GET: Thread
        public ActionResult Index()
        {
            using (FakebookContext Fk = new FakebookContext()) {
                Home content = new Home(Fk.Threads.ToList(),Fk.Categories.ToList());              
                return View(content);
            }
          
        }

        public ActionResult Create()
        {
            ViewBag.State = "Nueva Recomendación";
            using (FakebookContext Fk = new FakebookContext())
            {
                //Creamos una instancia de un nuevo post
                Thread newThread = new Thread();
                //creamos la instancia del nuevo modelo para alta de post
                ThreadCRU AddThread = new ThreadCRU(Fk.Categories.ToList());
                //compactamos las dos instancias para poder complementar vista y modelo
                AddThread.Thread = newThread;
                return View(AddThread);
            }

        }

        public ActionResult Edit(int _id)
        {
            ViewBag.State = "Editar Recomendación";
            using (FakebookContext Fk = new FakebookContext())
            {
                //Creamos una instancia de un post para colocar nuesto elemnto editado
                Thread editThread = Fk.Threads.First(x => x.Id == _id);
                //creamos la instancia del nuevo modelo para alta de post
                ThreadCRU threadCRU = new ThreadCRU(Fk.Categories.ToList());
                //compactamos las dos instancias para poder complementar vista y modelo
                threadCRU.Thread = editThread;
                return View("Create",threadCRU);
            }

        }

        [HttpPost]
        public ActionResult AddOrEdit(ThreadCRU _threadCRUD)
        {
            Thread _thread = _threadCRUD.Thread;
            using (FakebookContext Fk = new FakebookContext())
            {
                if (Fk.Threads.Any(x => x.Id == _thread.Id))
                {
                    Thread threadEdit = Fk.Threads.First(x => x.Id == _thread.Id);
                    threadEdit.Title = _thread.Title;
                    threadEdit.Description = _thread.Description;
                    threadEdit.IdCategory = _thread.IdCategory;
                    Fk.SaveChanges();

                }
                else
                {
                    Fk.Threads.Add(_thread);
                    Fk.SaveChanges();
                }

                return RedirectToAction("Index");
            }
        }

        public ActionResult Delete(int _id)
        {
            using (FakebookContext Fk= new FakebookContext())
            {
                Thread thread= Fk.Threads.First(x=> x.Id == _id);
                return View(thread);
            }
        }

        [HttpPost]
        public ActionResult Delete(Thread _thread)
        {
            using (FakebookContext Fk = new FakebookContext())
            {
                Thread thread = Fk.Threads.First(x => x.Id == _thread.Id);
                Fk.Threads.Remove(thread);
                Fk.SaveChanges();
                return RedirectToAction("Index");
            }
        }

        public ActionResult Detail(int _id)
        {
            //consultamos en base al Id 
            using (FakebookContext Fk = new FakebookContext())
            {
                Thread threadConsultado = Fk.Threads.First(x=> x.Id == _id);
                Comment comment = new Comment();


                DetailThread detail = new DetailThread
                (
                    Fk.Categories.ToList()
                   ,Fk.Comments.Where(x=>x.IdThread== _id).ToList()
                   ,threadConsultado
                   ,comment
                );
                return View(detail);

            }

            

        }

    }
}