using System;
using System.Collections.Generic;
using System.Diagnostics;
using HashCode.Models;
using HashCode.Sort;

namespace HashCode
{
    public class MainClass
    {
        public static void Main(string[] args)
        {
            // Tests sorting algoritm duration
            //TestSortingCenter();
            
            
            
        }

        private static async void TestSortingCenter()
        {
            var libsList = new List<Library>
            {
                new Library { BooksNumber = 134, BooksPerDay = 22, SingUpDuration = 1 },
                new Library { BooksNumber = 1354, BooksPerDay = 42, SingUpDuration = 99 },
                new Library { BooksNumber = 134, BooksPerDay = 62, SingUpDuration = 944 },
                new Library { BooksNumber = 1234, BooksPerDay = 72, SingUpDuration = 95 },
                new Library { BooksNumber = 134, BooksPerDay = 28, SingUpDuration = 95 },
                new Library { BooksNumber = 1344, BooksPerDay = 772, SingUpDuration = 59 },
                new Library { BooksNumber = 14534, BooksPerDay = 82, SingUpDuration = 59 },
                new Library { BooksNumber = 134, BooksPerDay = 2, SingUpDuration = 29 },
                new Library { BooksNumber = 77134, BooksPerDay = 2, SingUpDuration = 19 },
                new Library { BooksNumber = 15634, BooksPerDay = 2, SingUpDuration = 91 },
                new Library { BooksNumber = 7134, BooksPerDay = 4, SingUpDuration = 98 },
                new Library { BooksNumber = 15634, BooksPerDay = 2, SingUpDuration = 89 },
                new Library { BooksNumber = 1344, BooksPerDay = 24, SingUpDuration = 659 },
                new Library { BooksNumber = 1434, BooksPerDay = 2, SingUpDuration = 97 },
                new Library { BooksNumber = 134, BooksPerDay = 2, SingUpDuration = 988 },
                new Library { BooksNumber = 134, BooksPerDay = 23, SingUpDuration = 9 },
                new Library { BooksNumber = 1734, BooksPerDay = 32, SingUpDuration = 69 },
                new Library { BooksNumber = 1384, BooksPerDay = 32, SingUpDuration = 1 },
                new Library { BooksNumber = 1394, BooksPerDay = 2, SingUpDuration = 93 },
                new Library { BooksNumber = 1349, BooksPerDay = 7, SingUpDuration = 94 },
                new Library { BooksNumber = 134, BooksPerDay = 8, SingUpDuration = 59 },
                new Library { BooksNumber = 1734, BooksPerDay = 2, SingUpDuration = 69 },
            };

            var watch = new Stopwatch();
            watch.Start();
            var res = SortingCenter.SortLibraries(libsList);
            watch.Stop();
            Console.WriteLine(nameof(TestSortingCenter), "Tested!", watch.ElapsedMilliseconds.ToString());
        }
    }
}
