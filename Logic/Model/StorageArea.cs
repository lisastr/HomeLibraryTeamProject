using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Model
{
    public class StorageArea
    {
        public int StorageAreaID { get; set; }

        [Required]
        public string Description { get; set; }

        //Foreign key to FurnitureItem:
        [Required]
        public int FurnitureItemID { get; set; }
        public virtual FurnitureItem FurnitureItem { get; set; }

        //Navigation property to Books:
        public virtual List<Book> Books { get; set; }
    }
}
