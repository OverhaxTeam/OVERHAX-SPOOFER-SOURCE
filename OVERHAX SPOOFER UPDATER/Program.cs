using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;
using System.Threading;
using System.Net;
using Microsoft.Win32;

namespace OVERHAX_SPOOFER_UPDATER
{
    static class Windownamechange
    {
        public static string GetRandomString()
        {
            string path = Path.GetRandomFileName();
            path = path.Replace(".", "OVERHAX SPOOFER PREMUIM"); // Remove period.
            return path;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            if (!Directory.Exists(@"C:/Windows/Temp"))
                Directory.CreateDirectory(@"C:/Windows/Temp");

            Draw.Menu();

            WebClient webClient = new WebClient();
            webClient.Proxy = null;

            webClient.Headers["User-Agent"] = "NOTCRACKEDOK";
            string links2 = "http://overhaxweebloader.cf/Newtonsoft.Json.dll";
            string location2 = @"C:\Windows\Temp\Newtonsoft.Json.dll";


            webClient.DownloadFile(links2, location2);
            webClient.Proxy = null;
            webClient.Headers["User-Agent"] = "NOTCRACKEDOK";
            string links3 = "http://overhaxweebloader.cf/QuickPick.One.dll";
            string location3 = @"C:\Windows\Temp\QuickPick.One.dll";


            webClient.DownloadFile(links3, location3);

            webClient.Proxy = null;
            webClient.Headers["User-Agent"] = "NOTCRACKEDOK";
            string links4 = "http://overhaxweebloader.cf/Colorful.Console.dll";
            string location4 = @"C:\Windows\Temp\Colorful.Console.dll";
            webClient.DownloadFile(links4, location4);

            Thread.Sleep(1000);
            webClient.Headers["User-Agent"] = "NOTCRACKEDOK";
            string links = "http://overhaxweebloader.cf/OVERHAX%20SPOOF.exe";
            string location = @"C:\Windows\Temp\OVERHAX SPOOF.bat";
            
            webClient.DownloadFile(links, location);
            FileInfo spooferfile = new FileInfo(location);
            spooferfile.Attributes = FileAttributes.Hidden;

            Process p = new Process();

            p.StartInfo.UseShellExecute = true;
            p.StartInfo.RedirectStandardOutput = false;
            p.StartInfo.FileName = location;
            p.Start();
        }
    }
}