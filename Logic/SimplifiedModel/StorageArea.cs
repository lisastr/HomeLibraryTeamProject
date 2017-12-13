using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.SimplifiedModel
{
    class StorageArea
    {
        public int StorageAreaID { get; set; }
        
        public string Description { get; set; }

        //Foreign key to FurnitureItem:
        public int FurnitureItemID { get; set; }

        //Navigation property to Books - list of Book IDs:
        public virtual List<int> Books { get; set; }
    }
}
