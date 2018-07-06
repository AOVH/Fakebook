using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using Fakebook.Models;
namespace Fakebook.Context
{
    public class FakebookContext:DbContext
    {

        public DbSet<Comment> Comments { get; set; }
        public DbSet<Thread> Threads { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}