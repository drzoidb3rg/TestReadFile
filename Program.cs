using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestFileRead
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Press ESC to stop");
            do
            {
                while (!Console.KeyAvailable)
                {
                    ReadFile();

                }
            } while (Console.ReadKey(true).Key != ConsoleKey.Escape);


        }

        private static void ReadFile()
        {
            try
            {

                byte[] response = new System.Net.WebClient().DownloadData("http://load/content/test.pdf");

                Console.WriteLine("got : " + response.Length + " " + DateTime.Now.Second);
                response = null;
            }
            catch (Exception ex)
            {
                
                Console.WriteLine(ex.Message);
            }

        }
    }
}
