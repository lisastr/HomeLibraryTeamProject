using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Model
{
    class Book
    {
        public int BookID { get; set; }

        [Required]
        public string Name { get; set; }

        public DateTime PublishDate { get; set; }

        public string ISBN { get; set; }

        public string Language { get; set; }

        [Required]
        public int Quantity { get; set; }

        [Required]
        public bool IfFavotite { get; set; }

        //Navigation property to StorageAreas:
        public virtual List<StorageArea> StorageAreas { get; set; }

        //Navigation property to Authors:
        public virtual List<Author> Authors { get; set; }
    }
}
