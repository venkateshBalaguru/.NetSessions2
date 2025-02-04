
using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace StreamReadWriteApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //GenerateHtmlPage();
            ReadTheHtmlFile();
        }

        private static void ReadTheHtmlFile()
        {
            FileStream fs = new FileStream(@"C:\venkat-html-app\DotNetSessions\Day37\Welcome.html", FileMode.Open);
            StreamReader sr = new StreamReader(fs);
            //string html = sr.ReadToEnd(); //This will read start to end line
            while (true)
            {
                var line = sr.ReadLine();
                if (line == null)
                    break;
                Console.WriteLine(line);
            }
            
            sr.Close();
            fs.Close();
        }

        public static void GenerateHtmlPage()
        {
            var myHtmlPage = $"<html>" +
                $"<body>" +
                $"<H1>Welcome to Html Page...</H1>"+
                $"</body>" +
                $"</html>";

            FileStream fs = new FileStream(@"C:\venkat-html-app\DotNetSessions\Day37\Welcome.html",FileMode.Append);


            StreamWriter sw = new StreamWriter(fs);  //this is old type
            sw.WriteLine(myHtmlPage);
            sw.Close();
            fs.Close();


            //using (StreamWriter sw = new StreamWriter(fs))   //Instead of closing the StreamWriter we can use using syntax,It is new type
            //{
            //    sw.WriteLine(myHtmlPage);
            //}


        }
    }
}

//        static void Main(string[] args)
//        {

//            GenerateHtmlFile();

//            //ReadTheHtmlfile();
//        }

//        private static void ReadTheHtmlfile()
//        {
//            var fs = new FileStream("C:\\temp\\welcome.html", FileMode.Open);
//            var sr = new StreamReader(fs);
//            // var html = sr.ReadToEnd();
//            // Console.WriteLine(html);

//            while (true)
//            {

//                var line = sr.ReadLine();
//                if (line == null) break;
//                Console.WriteLine(line);


//            }

//            sr.Close();
//            fs.Close();

//        }

//        private static void GenerateHtmlFile()
//        {

//            var myhtmlbody = $"<html>" +
//                $"<body>" +
//                $"<h1>Welcome to html Page..</h1>" +
//                $"</body>" +
//                $"</html>";

//            FileStream fs = new FileStream("C:\\venkat-html-app\\DotNetSessions\\Day37", FileMode.Append);
//            StreamWriter sw = new StreamWriter(fs);
//            sw.WriteLine(myhtmlbody);
//            sw.Close();
//            fs.Close();





//            System.Console.WriteLine("end of main");

//        }
//    }
//}