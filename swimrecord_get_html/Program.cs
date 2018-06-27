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
            // 全体的に固定文字列は変数に格納しましょう
            // まずは日本語でいいので、コメントアウトしながら処理を記述し、
            // 一つずつコードに起こしていくと最初は楽です

            WebClient hanfuri = new WebClient();
            // string str = hanfuri.DownloadString("http://www.swim-record.com/ranking/ranking_17/--/112100.html");
            string dataUrl = "http://www.swim-record.com/ranking/ranking_17/--/112100.html";
            string str = hanfuri.DownloadString(dataUrl);

            // StreamWriter writer = new StreamWriter(@"C:\Users\k7cab\Documents\test\test.txt");
            string outouPath = @"C:\swim\test.txt";
            StreamWriter writer = new StreamWriter(outouPath);
            writer.WriteLine(str);
            writer.Close();

            // Process p = Process.Start("C:\\Users\\k7cab\\Documents\\test\\test.txt");
            Process p = Process.Start(outouPath);

        }
    }
}
