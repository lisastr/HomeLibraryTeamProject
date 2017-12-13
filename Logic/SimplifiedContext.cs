using Logic.SimplifiedModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class SimplifiedContext
    {
        public List<Author> Authors { get; set; }
        public List<Book> Books { get; set; }
        public List<FurnitureItem> FurnitureItems { get; set; }
        public List<StorageArea> StorageAreas { get; set; }

        public SimplifiedContext()
        {

        }
    }
}
