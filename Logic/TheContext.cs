using Logic.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class TheContext : DbContext, IContext
    {
        public DbSet<Author> Authors { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<FurnitureItem> FurnitureItems { get; set; }
        public DbSet<StorageArea> StorageAreas { get; set; }

        public TheContext()
        {

        }
    }
}
