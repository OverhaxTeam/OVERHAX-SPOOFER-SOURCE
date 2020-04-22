using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.IO;


namespace GetSerials
{
    class GetSerials
    {
        public static void Int()
        {

            Process.Start(new ProcessStartInfo("cmd.exe", "/c CMD /C \"ECHO DISKDRIVE SERIAL && wmic diskdrive get SerialNumber && ECHO BIOS SERIAL && WMIC BIOS GET SERIALNUMBER\"")
            {
                CreateNoWindow = false,
                UseShellExecute = false
        });
        }
        public static void WriteOld()
        {
            //Disk drive
            string path = @"Serials";
            // If directory does not exist make it
            Directory.CreateDirectory(path);

            if (File.Exists(@"Serials\OldHddSerials.txt"))
            {
                File.Delete(@"Serials\OldHddSerials.txt");

                //new FileStream("OldSerials.txt", FileMode.Truncate);
                //return;
            }

            System.Diagnostics.Process process = new System.Diagnostics.Process();
            System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
            startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            startInfo.FileName = "cmd.exe";
            startInfo.Arguments = "/C ECHO DISKDRIVE SERIAL && wmic diskdrive get SerialNumber" + "> Serials\\OldHddSerials.txt";
            process.StartInfo = startInfo;
            process.Start();
            process.WaitForExit();
            startInfo.RedirectStandardOutput = true;
            startInfo.UseShellExecute = false;
            startInfo.CreateNoWindow = true;

            //Bios

            string path1 = @"Serials";
            Directory.CreateDirectory(path1);


            if (File.Exists(@"Serials\OldBiosSerials.txt"))
            {
                File.Delete(@"Serials\OldBiosSerials.txt");
                //new FileStream("OldSerials.txt", FileMode.Truncate);
                //return;
            }

            System.Diagnostics.Process process1 = new System.Diagnostics.Process();
            System.Diagnostics.ProcessStartInfo startInfo1 = new System.Diagnostics.ProcessStartInfo();
            startInfo1.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            startInfo1.FileName = "cmd.exe";
            startInfo1.Arguments = "/C ECHO BIOS SERIAL && wmic BIOS get SerialNumber" + "> Serials\\OldBiosSerials.txt";
            process1.StartInfo = startInfo1;
            process1.Start();
            process1.WaitForExit();
            startInfo1.RedirectStandardOutput = true;
            startInfo1.UseShellExecute = false;
            startInfo1.CreateNoWindow = true;
        }
        public static void WriteNew()
        {
            string path = @"Serials";
            // If directory does not exist make it
            Directory.CreateDirectory(path);

            if (File.Exists(@"Serials\NewHddSerials.txt"))
            {
                File.Delete(@"Serials\NewHddSerials.txt");
                //new FileStream("NewSerials.txt", FileMode.Truncate);
                //return;
            }
            System.Diagnostics.Process process = new System.Diagnostics.Process();
            System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
            startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            startInfo.FileName = "cmd.exe";
            startInfo.Arguments = "/C ECHO DISKDRIVE SERIAL && wmic diskdrive get SerialNumber" + "> Serials\\NewHddSerials.txt";
            process.StartInfo = startInfo;
            process.Start();
            process.WaitForExit();
            startInfo.RedirectStandardOutput = true;
            startInfo.UseShellExecute = false;
            startInfo.CreateNoWindow = true;

            //Bios

            string path1 = @"Serials";
            // If directory does not exist make it
            Directory.CreateDirectory(path1);


            if (File.Exists(@"Serials\NewBiosSerials.txt"))
            {
                File.Delete(@"Serials\NewBiosSerials.txt");
                //new FileStream("NewSerials.txt", FileMode.Truncate);
                //return;
            }
            System.Diagnostics.Process process1 = new System.Diagnostics.Process();
            System.Diagnostics.ProcessStartInfo startInfo1 = new System.Diagnostics.ProcessStartInfo();
            startInfo1.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            startInfo1.FileName = "cmd.exe";
            startInfo1.Arguments = "/C ECHO BIOS SERIAL && WMIC BIOS GET SERIALNUMBER" + "> Serials\\NewBiosSerials.txt";
            process1.StartInfo = startInfo1;
            process1.Start();
            process1.WaitForExit();
            startInfo1.RedirectStandardOutput = true;
            startInfo1.UseShellExecute = false;
            startInfo1.CreateNoWindow = true;
        }
    }
}
