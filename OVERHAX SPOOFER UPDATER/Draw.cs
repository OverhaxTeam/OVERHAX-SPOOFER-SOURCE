using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Reflection;
using System.Security;
using System.Threading;
using System.Windows;

namespace OVERHAX_SPOOFER_UPDATER
{
    class Draw
    {
        public static void Delete()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;

            string Newtonsoftxml = @"C:\Windows\Temp\Newtonsoft.Json.xml";
            string NewtonsoftJson = @"C:\Windows\Temp\Newtonsoft.Json.dll";
            string QuickPickOne = @"C:\Windows\Temp\QuickPick.One.dll";
            string QuickPickOneCLR = @"C:\Windows\Temp\QuickPickOneCLR.dll";
            string OVERHAXSPOOF = @"C:\Windows\Temp\OVERHAX SPOOF.bat";
            string Colorful = @"C:\Windows\Temp\Colorful.Console.dll";
            try
            {
                System.IO.File.SetAttributes(OVERHAXSPOOF, FileAttributes.Normal);
                if (File.Exists(OVERHAXSPOOF))
                {
                    Console.WriteLine("Deleting old files...");
                    Thread.Sleep(2000);
                }
                File.Delete(Newtonsoftxml);
                File.Delete(NewtonsoftJson);
                File.Delete(QuickPickOne);
                File.Delete(QuickPickOneCLR);
                File.Delete(OVERHAXSPOOF);
                File.Delete(Colorful);
                Console.Clear(); 
            }
            catch
            {
                Console.WriteLine("Error Deleting old file");
                Thread.Sleep(2000);
            }
            return;
        }
        public static void Menu()
        {
            Delete();

            Console.Title = Windownamechange.GetRandomString();
            Console.BackgroundColor = ConsoleColor.White;

            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Clear();

            Console.Write("Getting latest version... \n");
        }
    }
}
