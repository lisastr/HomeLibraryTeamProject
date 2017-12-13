using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.SimplifiedModel
{
    public class FurnitureItem
    {
        public int FurnitureItemID { get; set; }
        
        public string Description { get; set; }

        //Navigation property to StorageAreas - list of StorageArea IDs:
        public List<int> StorageAreas { get; set; }
    }
}
