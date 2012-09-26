using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.IO;

namespace ConsoleTestWcfRESTWebServices
{
    class Test
    {

        private HttpWebRequest myTestPage; //(HttpWebRequest)WebRequest.Create("http://localhost:53581/ResumeService/");

        public string GetPageHeader(string pageURL)
        {
            string header;
            StringBuilder body = new StringBuilder();

            myTestPage = (HttpWebRequest)WebRequest.Create(pageURL);
            HttpWebResponse myResponsePage = (HttpWebResponse)myTestPage.GetResponse();

            Console.WriteLine("Response Header:  {0}", myResponsePage.Headers.ToString());
            header = myResponsePage.Headers.ToString();

            Stream receiver = myResponsePage.GetResponseStream();
            Encoding encode = System.Text.Encoding.GetEncoding("utf-8");

            StreamReader sr = new StreamReader(receiver, encode);
            char[] inputStream = new char[256];

            while (sr.Read(inputStream, 0, 256) > 0)
            {
                body.Append(new String(inputStream));
            }

            myResponsePage.Close();

            return body.ToString();
            
        }

    }


    class Program
    {
        static void Main(string[] args)
        {
            Test myTest = new Test();
            string testPage = "http://localhost:53581/ResumeService/";

            string testBody = myTest.GetPageHeader(testPage);
            Console.WriteLine(testBody);
            Console.Read();
        }
    }
}
