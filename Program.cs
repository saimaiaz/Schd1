using System;
using System.Net;
using System.Threading;

namespace Schd1
{
    class Program
    {
        static void Main(string[] args)
        {
            for (; ; )
            {
                SomeMethod();
                Thread.Sleep(60*60*5);
            }
        }



        static void SomeMethod()
        {
            Console.WriteLine("SomeMethod is called.");

            using (var client = new WebClient())
            {
                client.DownloadFile("https://dmama.pwa.co.th/mis/note.xml", "note.xml");
            }

        }
    }
}
