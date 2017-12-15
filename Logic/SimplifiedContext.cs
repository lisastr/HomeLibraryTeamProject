using Logic.SimplifiedModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class SimplifiedContext : IContext
    {
        public List<Author> Authors { get; set; }
        public List<Book> Books { get; set; }
        public List<FurnitureItem> FurnitureItems { get; set; }
        public List<StorageArea> StorageAreas { get; set; }

        public SimplifiedContext()
        {
            Authors = new List<Author>();
            //TestData
            Authors.Add(new Author() { AuthorID = 0, Name = "A", Surname = "AA", Patronymic = "AAA" });
            Authors.Add(new Author() { AuthorID = 1, Name = "B", Surname = "BB", Patronymic = "BBB" });
            Authors.Add(new Author() { AuthorID = 2, Name = "C", Surname = "CC", Patronymic = "CCC" });
        }
    }
}
