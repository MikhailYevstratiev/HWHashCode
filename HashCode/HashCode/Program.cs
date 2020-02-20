using System;
using System.Threading.Tasks;

namespace HashCode
{
    class MainClass
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Task.Run(async () =>
            {
                try
                {
                    var list = await DataParser.ParseData();
                }
                catch (Exception ex)
                {

                }
                // Do any async anything you need here without worry
            }).GetAwaiter().GetResult();
        }
    }
}
