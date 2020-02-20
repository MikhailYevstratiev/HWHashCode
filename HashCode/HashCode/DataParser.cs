using System;
using System.IO;
using System.Threading.Tasks;

namespace HashCode
{
    public static class DataParser
    {
        public static async void ParseData()
        {
            const string pathA = @"/Users/ninja/Projects/HashCode/Data/a_example.txt";
            const string fileB = @"/Users/ninja/Projects/HashCode/Data/b_read_on.txt";
            const string fileC = @"/Users/ninja/Projects/HashCode/Data/c_incunabula.txt";
            const string fileD = @"/Users/ninja/Projects/HashCode/Data/d_tough_choices.txt";
            const string fileE = @"/Users/ninja/Projects/HashCode/Data/e_so_many_books.txt";
            const string fileF = @"/Users/ninja/Projects/HashCode/Data/f_libraries_of_the_world.txt";


        }

        public static async Task StartParseAsync(string path)
        {
            using (StreamReader sr = new StreamReader(path, System.Text.Encoding.Default))
            {
                string line = string.Empty;

                while ((line = sr.ReadLine()) != null)
                {
                    
                }
            }
        }
    }
}
