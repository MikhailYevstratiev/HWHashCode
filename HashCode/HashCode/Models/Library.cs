using System;
using System.Collections.Generic;

namespace HashCode.Models
{
    public class Library
    {
        public int BooksNumber { get; set; }
        public int SingUpDuration { get; set; }
        public int BooksPerDay { get; set; }
        public List<int> BooksIDs { get; set; }
    }
}
