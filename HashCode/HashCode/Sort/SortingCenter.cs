using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HashCode.Models;

namespace HashCode.Sort
{
    public static class SortingCenter
    {
        public static Task<List<Library>> SortLibrariesAsync(IList<Library> initList)
        {
            return Task.Run(() => SortLibraries(initList));
        }

        public static List<Library> SortLibraries(IList<Library> libs)
        {
            return libs
                .AsParallel()
                .OrderByDescending(lib => lib.BooksPerDay)
                .ToList()
                .AsParallel()
                .OrderBy(lib => lib.SingUpDuration)
                .ToList();
        }
    }
}