using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;

namespace wget
{
    class Program
    {

        static void Main(string[] args)
        {
            var wc = new WebClient();

            if (args.Length == 1)
            {
                string ending = "";

                string pathending = args[0].Substring(args[0].Length - 4, 4);
                string[] pathcenterarray = args[0].Split('/');
                string pathcenterguess = pathcenterarray[pathcenterarray.Length - 1];

                //Console.WriteLine(pathending);
                //Console.WriteLine(pathcenterguess);

                if(pathcenterguess.Substring(pathcenterguess.Length - 4, 4) == pathending)
                {
                    ending = pathcenterguess;
                }
                else
                {
                    ending = pathcenterguess + pathending;
                }

                //Console.WriteLine(ending);

                Uri url = new Uri(args[0]);
                wc.DownloadFile(url, Environment.CurrentDirectory + "\\" + ending);
                //Console.WriteLine(Environment.CurrentDirectory);
            }
            else
            {
                Console.WriteLine("Benutze: wget <DEINE URL>");
            }
        }
    }
}
