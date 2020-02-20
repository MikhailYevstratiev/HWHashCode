using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using HashCode.Models;

namespace HashCode
{
    public static class DataParser
    {
        public static async Task<IEnumerable<IEnumerable<Library>>> ParseData()
        {
            const string pathA = @"/Users/ninja/Projects/HashCode/HashCode/HashCode/Data/a_example.txt";
            const string fileB = @"/Users/ninja/Projects/HashCode/HashCode/HashCode/Data/b_read_on.txt";
            const string fileC = @"/Users/ninja/Projects/HashCode/HashCode/HashCode/Data/c_incunabula.txt";
            const string fileD = @"/Users/ninja/Projects/HashCode/HashCode/HashCode/Data/d_tough_choices.txt";
            const string fileE = @"/Users/ninja/Projects/HashCode/HashCode/HashCode/Data/e_so_many_books.txt";
            const string fileF = @"/Users/ninja/Projects/HashCode/HashCode/HashCode/Data/f_libraries_of_the_world.txt";

            List<Task<IEnumerable<Library>>> parseDataTaskList = new List<Task<IEnumerable<Library>>>();

            try
            {
                parseDataTaskList.Add(StartParseAsync(pathA));
                parseDataTaskList.Add(StartParseAsync(fileB));
                parseDataTaskList.Add(StartParseAsync(fileC));
                parseDataTaskList.Add(StartParseAsync(fileD));
                parseDataTaskList.Add(StartParseAsync(fileE));
                parseDataTaskList.Add(StartParseAsync(fileF));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            var parsedDocumentsList = await Task.WhenAll(parseDataTaskList);



            return parsedDocumentsList;
        }

        private static Task<IEnumerable<Library>> StartParseAsync(string path)
        {
            return Task.Run(() =>
            {
                    using (StreamReader sr = new StreamReader(path, System.Text.Encoding.Default))
                    {
                        List<Library> LibraryCollection = new List<Library>();

                        string line = string.Empty;

                        const int startReadFromLine = 2;

                        int currentLine = 0;

                try
                {
                        while ((line = sr.ReadLine()) != null)
                        {
                            if (currentLine >= startReadFromLine && !string.IsNullOrEmpty(line))
                            {
                                if (currentLine % 2 == 0) // read books , sign up days and books per day
                                {
                                    var receivedLine = line.Split(' ');

                                    LibraryCollection.Add(
                                        new Library()
                                        {
                                            BooksNumber = Convert.ToInt32(receivedLine[0]),
                                            SingUpDuration = Convert.ToInt32(receivedLine[1]),
                                            BooksPerDay = Convert.ToInt32(receivedLine[2])
                                        }); ;
                                }
                                else // parse books ids
                                {
                                    var receivedLine = line.Split(' ');
                                    int[] Ids = Array.ConvertAll(receivedLine, int.Parse);

                                    LibraryCollection.Last().BooksIDs = new List<int>(Ids);
                                }
                            }

                            currentLine++;
                        }
                }
                catch (Exception ex)
                {
                        var a = path;
                }

                        return LibraryCollection as IEnumerable<Library>;
                    }
            });
        }
    }
}
