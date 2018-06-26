using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Net;
using System.Diagnostics;
using System.Threading.Tasks;

namespace get_HTML
{
    class Program
    {
        static void Main(string[] args)
        {

            WebClient hanfuri = new WebClient();
            string str = hanfuri.DownloadString("http://www.swim-record.com/ranking/ranking_17/--/112100.html");


            StreamWriter writer = new StreamWriter(@"C:\Users\k7cab\Documents\test\test.txt");
            writer.WriteLine(str);
            writer.Close();

            Process p = Process.Start("C:\\Users\\k7cab\\Documents\\test\\test.txt");

        }
    }
}
