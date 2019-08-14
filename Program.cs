using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Schd1
{
    class Program
    {
        static void Main(string[] args)
        {
            for (; ; )
            {
                SomeMethod();
                Thread.Sleep(1000*60*60);
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
