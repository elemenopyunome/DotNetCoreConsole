using System;
using System.Net;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace DotNetCoreConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            ///Deploy this to github
            ///Running single thread (main thread) on RHEL 8 - EC2
            using (WebClient w = new WebClient())
            {
                
                for(int x=0;x<10000;x++)
                {
                    var json = w.DownloadString("https://www.learningcontainer.com/wp-content/uploads/2019/10/Sample-employee-JSON-data.json");
                    string jsontoserialize = JsonConvert.SerializeObject(json);
                    Console.WriteLine(jsontoserialize);
                    Console.WriteLine(x.ToString());
                }
                Console.WriteLine("Done");
                //Console.ReadLine();
            }
            
        }
    }
}
