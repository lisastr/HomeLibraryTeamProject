using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.SimplifiedModel
{
    class Author
    {
        public int AuthorID { get; set; }

        public string Name { get; set; }

        public string Surname { get; set; }

        public string Patronymic { get; set; }

        //Navigation property to Books - list of Book IDs:
        public List<int> Books { get; set; }
    }
}
