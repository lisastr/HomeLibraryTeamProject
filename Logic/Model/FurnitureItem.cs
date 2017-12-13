using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Model
{
    public class FurnitureItem
    {
        public int FurnitureItemID { get; set; }

        [Required]
        public string Description { get; set; }

        //Navigation property to StorageAreas:
        public virtual List<StorageArea> StorageAreas { get; set; }
    }
}
