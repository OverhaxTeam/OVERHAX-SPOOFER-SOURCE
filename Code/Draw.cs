using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Security;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System;
using System.Drawing;
using Console = Colorful.Console;



namespace API_Example
{
    class Draw
    {

        

        public static void print1()
        {

            try
            {
                Protect.This.checkConnection();
                Console.WriteLine("");
                Console.WriteLine("");
                WebClient wb = new WebClient();
                wb.Proxy = null;
                wb.Headers["User-Agent"] = "NOTCRACKEDOK";
                string news = wb.DownloadString("http://overhaxweebloader.cf/spoofernews.txt");
                Console.WriteLine(news, Color.LightPink);
                Console.WriteLine("");

            } catch
            {
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("Internet required, no news it's Available ", Color.LightPink);
                Console.WriteLine("");
            } 

        }

        public static void cache()
        {
            string spoofbat = @"C:\Program Files\spoof.bat";
            string drivesys = @"C:\Program Files\Disk.sys";
            string sdstor = @"C:\Program Files\sdstor.sys";
            string spoofersys = @"C:\Program Files\spoofer.sys";
            string mapperexe = @"C:\Program Files\Mapper.exe";
            string volt_cleanbat = @"C:\Program Files\volt_clean.bat";
            string clean_tracesbat = @"C:\Program Files\Clean_Traces.bat";
            string spoofer = @"C:\Program Files\Spoofer.exe";
            string biosexe = @"C:\Program Files\bios.exe";
            string biossys = @"C:\Program Files\bios.sys";
            string voltexe = @"C:\Program Files\volt.EXE";
            string amifldrv64 = @"C:\Program Files\amifldrv64.sys";
            string biosbat = @"C:\Program Files\bios.bat";
            string macbat = @"C:\Program Files\mac.bat";
            string spoofsys = @"C:\Program Files\spoof.sys";
            string spoofsysbat = @"C:\Program Files\spoofsys.bat";
            string apex = @"C:\Program Files\aaaapex.exe";
            string cleaner1 = @"C:\Windows\cleaner_1.exe";
            string cleaner2 = @"C:\Windows\cleaner_2.exe";
            string cleaner3 = @"C:\Windows\cleaner_3.bat";
            string overhaxclean = @"C:\Windows\overhax clean.bat";
            string overhaxregspoof = @"C:\Windows\overhaxregspoof.bat";
            string overhaxregclean = @"C:\Windows\overhaxregclean.bat";
            string overhaxoverlay = @"C:\Windows\overhax.exe";
            //string devcon = @"C:\Windows\Fonts\devcon.exe";
            string overhaxaltclean = @"C:\Windows\Fonts\OVERHAXALTCLEAN.exe";

            File.Delete(overhaxaltclean);
            //File.Delete(devcon);
            File.Delete(overhaxoverlay);
            File.Delete(spoofbat);
            File.Delete(drivesys);
            File.Delete(sdstor);
            File.Delete(spoofersys);
            File.Delete(mapperexe);
            File.Delete(volt_cleanbat);
            File.Delete(clean_tracesbat);
            File.Delete(spoofer);
            File.Delete(biosexe);
            File.Delete(biossys);
            File.Delete(voltexe);
            File.Delete(amifldrv64);
            File.Delete(biosbat);
            File.Delete(macbat);
            File.Delete(spoofsys);
            File.Delete(spoofsysbat);
            File.Delete(apex);
            File.Delete(cleaner1);
            File.Delete(cleaner2);
            File.Delete(cleaner3);
            File.Delete(overhaxclean);
            File.Delete(overhaxregspoof);
            File.Delete(overhaxregclean);
            return;
        }
    }

}
