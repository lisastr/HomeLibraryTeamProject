using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.SimplifiedModel
{
    class Book
    {
        public int BookID { get; set; }
        
        public string Name { get; set; }

        public DateTime PublishDate { get; set; }

        public string ISBN { get; set; }

        public string Language { get; set; }
        
        public int Quantity { get; set; }
        
        public bool IfFavotite { get; set; }

        //Navigation property to StorageAreas - list of StorageArea IDs:
        public List<int> StorageAreas { get; set; }

        //Navigation property to Authors - list of Author IDs:
        public List<int> Authors { get; set; }
    }
}
