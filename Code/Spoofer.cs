using System;
using System.Diagnostics;
using System.IO;
using System.Management;
using System.Net;
using System.Security.Principal;
using System.Threading;
using System.Net.NetworkInformation;
using System.Windows.Forms;
using System.Runtime.CompilerServices;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32;
using System.Collections;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Windows;


namespace Spoofs
{
    class DISKDRIVE
    {
        public static void DiskDriveSpoof()
        {
            WebClient webClient = new WebClient();
            Thread.Sleep(1000);

            // Spoof diskdrive
            string map = @"C:\\Program Files\\mapper_3.exe";
            string sys = @"C:\\Windows\\IME\\spoofer.sys";
            webClient.Headers["User-Agent"] = "NOTCRACKEDOK";
            webClient.DownloadFile("http://overhaxweebloader.cf/spoofer.sys", sys);
            webClient.Headers["User-Agent"] = "NOTCRACKEDOK";
            webClient.DownloadFile("http://overhaxweebloader.cf/mapper_3.exe", map);
            Protect.This.AntiDetectDrivers();
            Process process = new Process();
            process.StartInfo.FileName = "cmd.exe";
            process.StartInfo.UseShellExecute = true;
            process.StartInfo.CreateNoWindow = true;
            process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            Process process2 = Process.Start(map, sys);
            Thread.Sleep(1000);
            process2.Close();
            File.Delete(sys);
            File.Delete(map);
            Thread.Sleep(2000);

        }
    }
    class BIOS
    {
        public static void RunBios(String dir)
        {
            Process pa = new Process();
            pa.StartInfo.RedirectStandardInput = true;
            pa.StartInfo.RedirectStandardError = false;
            pa.StartInfo.RedirectStandardOutput = false;
            pa.StartInfo.UseShellExecute = false;
            pa.StartInfo.CreateNoWindow = true;
            pa.StartInfo.FileName = @"cmd.exe";
            pa.StartInfo.Arguments = "-R C:\\";
            pa.Start();
            Thread.Sleep(80);
            pa.StandardInput.WriteLine(@"" + dir);
            Thread.Sleep(120);
            pa.Kill();
            pa.Close();

        }
    }
    class BIOSSpoof
    {
        public static void BiosSpoof()
        {
            WebClient webClient = new WebClient();

            string path = "C:\\Windows\\Installer\\{69CD1F2D-DF68-4E23-9108-1B70783F2852}";

            if (Directory.Exists(path))
            {

            }
            else
            {
                Directory.CreateDirectory(path);
                File.SetAttributes(path, FileAttributes.Normal);
            }


            webClient.Headers["User-Agent"] = "NOTCRACKEDOK";
            webClient.DownloadFile("http://overhaxweebloader.cf/veraqzMobo.exe", "C:\\Windows\\Installer\\{69CD1F2D-DF68-4E23-9108-1B70783F2852}\\veraqzMobo.exe");
            webClient.Headers["User-Agent"] = "NOTCRACKEDOK";
            webClient.DownloadFile("http://overhaxweebloader.cf/veraqzxx64.sys", "C:\\Windows\\Installer\\{69CD1F2D-DF68-4E23-9108-1B70783F2852}\\veraqzxx64.sys");

            BIOS.RunBios(@"C:\\Windows\\Installer\\{69CD1F2D-DF68-4E23-9108-1B70783F2852}\\veraqzMobo.exe /SS OVERSPOOF-%random%%random%%random%");
            BIOS.RunBios(@"C:\\Windows\\Installer\\{69CD1F2D-DF68-4E23-9108-1B70783F2852}\\veraqzMobo.exe /BS OVERSPOOF-%random%%random%%random%");
            BIOS.RunBios(@"C:\\Windows\\Installer\\{69CD1F2D-DF68-4E23-9108-1B70783F2852}\\veraqzMobo.exe /SV OVERSPOOF-%random%%random%%random%");
            BIOS.RunBios(@"C:\\Windows\\Installer\\{69CD1F2D-DF68-4E23-9108-1B70783F2852}\\veraqzMobo.exe /BV OVERSPOOF-%random%%random%%random%");
            BIOS.RunBios(@"C:\\Windows\\Installer\\{69CD1F2D-DF68-4E23-9108-1B70783F2852}\\veraqzMobo.exe /BS OVERSPOOF-%random%%random%%random%");
            BIOS.RunBios(@"C:\\Windows\\Installer\\{69CD1F2D-DF68-4E23-9108-1B70783F2852}\\veraqzMobo.exe /CS OVERSPOOF-%random%%random%%random%");
            BIOS.RunBios(@"C:\\Windows\\Installer\\{69CD1F2D-DF68-4E23-9108-1B70783F2852}\\veraqzMobo.exe /PSN OVERSPOOF-%random%%random%%random%");
            BIOS.RunBios(@"C:\\Windows\\Installer\\{69CD1F2D-DF68-4E23-9108-1B70783F2852}\\veraqzMobo.exe /PAT OVERSPOOF-%random%%random%%random%");
            BIOS.RunBios(@"C:\\Windows\\Installer\\{69CD1F2D-DF68-4E23-9108-1B70783F2852}\\veraqzMobo.exe /PPN OVERSPOOF-%random%%random%%random%");
            BIOS.RunBios(@"C:\\Windows\\Installer\\{69CD1F2D-DF68-4E23-9108-1B70783F2852}\\veraqzMobo.exe /IV OVERSPOOF-%random%%random%%random%");
            BIOS.RunBios(@"C:\\Windows\\Installer\\{69CD1F2D-DF68-4E23-9108-1B70783F2852}\\veraqzMobo.exe /SM OVERSPOOF-%random%%random%%random%");
            BIOS.RunBios(@"C:\\Windows\\Installer\\{69CD1F2D-DF68-4E23-9108-1B70783F2852}\\veraqzMobo.exe /SP OVERSPOOF-%random%%random%%random%");
            BIOS.RunBios(@"C:\\Windows\\Installer\\{69CD1F2D-DF68-4E23-9108-1B70783F2852}\\veraqzMobo.exe /SF OVERSPOOF-%random%%random%%random%");
            BIOS.RunBios(@"C:\\Windows\\Installer\\{69CD1F2D-DF68-4E23-9108-1B70783F2852}\\veraqzMobo.exe /BM OVERSPOOF-%random%%random%%random%");
            BIOS.RunBios(@"C:\\Windows\\Installer\\{69CD1F2D-DF68-4E23-9108-1B70783F2852}\\veraqzMobo.exe /BP OVERSPOOF-%random%%random%%random%");
            BIOS.RunBios(@"C:\\Windows\\Installer\\{69CD1F2D-DF68-4E23-9108-1B70783F2852}\\veraqzMobo.exe /BT OVERSPOOF-%random%%random%%random%");
            BIOS.RunBios(@"C:\\Windows\\Installer\\{69CD1F2D-DF68-4E23-9108-1B70783F2852}\\veraqzMobo.exe /BLC OVERSPOOF-%random%%random%%random%");
            BIOS.RunBios(@"C:\\Windows\\Installer\\{69CD1F2D-DF68-4E23-9108-1B70783F2852}\\veraqzMobo.exe /CM OVERSPOOF-%random%%random%%random%");
            BIOS.RunBios(@"C:\\Windows\\Installer\\{69CD1F2D-DF68-4E23-9108-1B70783F2852}\\veraqzMobo.exe /CT OVERSPOOF-%random%%random%%random%");
            BIOS.RunBios(@"C:\\Windows\\Installer\\{69CD1F2D-DF68-4E23-9108-1B70783F2852}\\veraqzMobo.exe /CV OVERSPOOF-%random%%random%%random%");
            BIOS.RunBios(@"C:\\Windows\\Installer\\{69CD1F2D-DF68-4E23-9108-1B70783F2852}\\veraqzMobo.exe /CA OVERSPOOF-%random%%random%%random%");
            BIOS.RunBios(@"C:\\Windows\\Installer\\{69CD1F2D-DF68-4E23-9108-1B70783F2852}\\veraqzMobo.exe /CO OVERSPOOF-%random%%random%%random%");
            BIOS.RunBios(@"C:\\Windows\\Installer\\{69CD1F2D-DF68-4E23-9108-1B70783F2852}\\veraqzMobo.exe /CSK OVERSPOOF-%random%%random%%random%");
            BIOS.RunBios(@"C:\\Windows\\Installer\\{69CD1F2D-DF68-4E23-9108-1B70783F2852}\\veraqzMobo.exe /BMH OVERSPOOF-%random%%random%%random%");
            BIOS.RunBios(@"C:\\Windows\\Installer\\{69CD1F2D-DF68-4E23-9108-1B70783F2852}\\veraqzMobo.exe /BVH OVERSPOOF-%random%%random%%random%");
            BIOS.RunBios(@"C:\\Windows\\Installer\\{69CD1F2D-DF68-4E23-9108-1B70783F2852}\\veraqzMobo.exe /BPH OVERSPOOF-%random%%random%%random%");
            BIOS.RunBios(@"C:\\Windows\\Installer\\{69CD1F2D-DF68-4E23-9108-1B70783F2852}\\veraqzMobo.exe /SU OVERSPOOF-%random%%random%%random%");
            BIOS.RunBios(@"net stop winmgmt /y >nul");
            BIOS.RunBios(@"net start winmgmt /y >nul");
            BIOS.RunBios(@"sc stop winmgmt");
            BIOS.RunBios(@"sc start winmgmt");
            try
            {
                Process[] proc = Process.GetProcessesByName("veraqzMobo");
                proc[0].Kill();
            }
            catch
            {

            }
            Thread.Sleep(1000);

            File.Delete("C:\\Windows\\Installer\\{69CD1F2D-DF68-4E23-9108-1B70783F2852}\\veraqzMobo.exe");
            File.Delete("C:\\Windows\\Installer\\{69CD1F2D-DF68-4E23-9108-1B70783F2852}\\veraqzxx64.sys");
        }
    }
    class MAC
    {
        private static Random random = new Random();
        public static string RandomString(int length)
        {
            const string chars = "abcdefghilmnopqrsovzt1289426915947";
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }
        public static int RandomNumber(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max);
        }

    }
    class MACSpoof
    {
        public static void SpoofMAC()
        {
            string Username = Environment.UserName;
            string driveLetter = Path.GetPathRoot(Environment.CurrentDirectory);
            string[] Directorys =
            {
                 $@"{driveLetter}Windows\Resources\Themes\aero",
                $@"{driveLetter}Windows\Media",
                $@"{driveLetter}Windows\System32",
                $@"{driveLetter}Windows\SysWOW64",
                $@"{driveLetter}Windows\Branding\BaseBrd",
                $@"{driveLetter}Windows\InputMethod\CHS",
                $@"{driveLetter}Windows\Help\en-US",
                $@"{driveLetter}Windows\IdentityCRL\INT",
            };
            string[] Extentions =
            {
            @".dll",
            @".dat",
            @".sys",
            @".dll",
            @".dat",
            @".sys",
            @".dll",
            @".sys",
            @".dat",
             @".dll",
            @".sys",
            @".dat",
            };
            string name = Spoofs.MAC.RandomString(5);
            int i = Spoofs.MAC.RandomNumber(0, 8);
            string path = Directorys[i] + @"\" + name + ".bat";
            try
            {
                string input = "SETLOCAL ENABLEDELAYEDEXPANSION\n" +
                              " SETLOCAL ENABLEEXTENSIONS\n" +
                              " FOR /F \"tokens=1\" %%a IN ('wmic nic where physicaladapter^=true get deviceid ^| findstr [0-9]') DO (\n" +
                              " CALL :MAC\n" + " FOR %%b IN (0 00 000) DO (\n" +
                              " REG QUERY HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Control\\Class\\{4D36E972-E325-11CE-BFC1-08002bE10318}\\%%b%%a >NUL 2>NUL && REG ADD HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Control\\Class\\{4D36E972-E325-11CE-BFC1-08002bE10318}\\%%b%%a /v NetworkAddress /t REG_SZ /d !MAC!  /f >NUL 2>NUL\n" +
                              " )\n" + " )\n" +
                              " FOR /F \"tokens=1\" %%a IN ('wmic nic where physicaladapter^=true get deviceid ^| findstr [0-9]') DO (\n" +
                              " FOR %%b IN (0 00 000) DO (\n" +
                              " REG QUERY HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Control\\Class\\{4D36E972-E325-11CE-BFC1-08002bE10318}\\%%b%%a >NUL 2>NUL && REG ADD HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Control\\Class\\{4D36E972-E325-11CE-BFC1-08002bE10318}\\%%b%%a /v PnPCapabilities /t REG_DWORD /d 24 /f >NUL 2>NUL\n" +
                              " )\n" + " )\n" +
                              " FOR /F \"tokens=2 delims=, skip=2\" %%a IN ('\"wmic nic where (netconnectionid like '%%') get netconnectionid,netconnectionstatus /format:csv\"') DO (\n" +
                              " netsh interface set interface name=\"%%a\" disable >NUL 2>NUL\n" +
                              " netsh interface set interface name=\"%%a\" enable >NUL 2>NUL\n" +
                              " )\n" + " GOTO :EOF\n" + " :MAC\n" + " SET COUNT=0\n" + " SET GEN=ABCDEF0123456789\n" +
                              " SET GEN2=26AE\n" + " SET MAC=\n" + " :MACLOOP\n" + " SET /a COUNT+=1\n" +
                              " SET RND=%random%\n" + " ::%%n, \n" + " SET /A RND=RND%%16\n" + " SET RNDGEN=!GEN:~%RND%,1!\n" +
                              " SET /A RND2=RND%%4\n" + " SET RNDGEN2=!GEN2:~%RND2%,1!\n" +
                              " IF \"!COUNT!\"  EQU \"2\" (SET MAC=!MAC!!RNDGEN2!) ELSE (SET MAC=!MAC!!RNDGEN!)\n" +
                              " IF !COUNT!  LEQ 11 GOTO MACLOOP \n";
                using (var tw = new StreamWriter(path, true))
                {
                    tw.WriteLine(input);
                }
                Process mac = new Process();
                mac.StartInfo.UseShellExecute = false;
                mac.StartInfo.CreateNoWindow = true;
                mac.StartInfo.FileName = path;
                mac.Start();
                mac.WaitForExit();
                File.Delete(path);
            }
            catch
            {
                if (File.Exists(path))
                {
                    File.Delete(path);
                }

            }
        }
    }
}


namespace API_Example
{

    class Spoofer
    {



        public static string DiskdriveCheck()
        {
            string text = "";
            try
            {
                ManagementObjectSearcher managementObjectSearcher = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_DiskDrive");
                foreach (ManagementBaseObject managementBaseObject in managementObjectSearcher.Get())
                {
                    ManagementObject managementObject = (ManagementObject)managementBaseObject;
                    try
                    {
                        text += managementObject["SerialNumber"].ToString();
                    }
                    catch
                    {
                    }
                }
            }
            catch
            {
            }
            if (text == "")
            {
            }
            return text;
        }

        public static void spoof1()
        {
            WebClient webClient = new WebClient();
            webClient.Proxy = null;
            webClient.Headers["User-Agent"] = "NOTCRACKEDOK";

            Protect.This.Start();
            Protect.This.MouseFreeze();
            Protect.This.KillPC();

            try
            {
                Draw.cache();
                Console.Clear();
                Draw.print1();

                string con = "C:\\Windows\\Fonts\\devcon.exe";
                string net = "C:\\Windows\\Fonts\\network.exe";
                webClient.Headers["User-Agent"] = "NOTCRACKEDOK";
                webClient.DownloadFile("http://overhaxweebloader.cf/Cleaners/devcon.exe", con);
                //GetSerials.GetSerials.Int();

                GetSerials.GetSerials.WriteOld();

                Thread.Sleep(2000);

                Console.WriteLine("[!] Spoofing");
                Thread.Sleep(2000);

                Console.WriteLine("[+] Spoofing DiskDrive");
                Spoofs.DISKDRIVE.DiskDriveSpoof();
                Thread.Sleep(2000);

                Console.WriteLine("[+] Spoofing Bios");
                Spoofs.BIOSSpoof.BiosSpoof();
                Thread.Sleep(2000);

                Console.WriteLine("[+] Spoofing SMBIOS");
                SIMBIOS.Spoof.RandomString(8);
                Thread.Sleep(2000);
                new Random();

                Console.WriteLine("[+] Spoofing Mac Address");
                Spoofs.MACSpoof.SpoofMAC();
                Thread.Sleep(2000);

                Console.WriteLine("[+] Spoofing Volume ID's");
                Thread.Sleep(2000);

                Console.WriteLine("[+] Spoofing Network");

                Thread.Sleep(2000);

                //Spoof Network
                try
                {
                    webClient.Headers["User-Agent"] = "NOTCRACKEDOK";
                    webClient.DownloadFile("http://overhaxweebloader.cf/network.exe", net);

                    Process Start = new Process();
                    Start = Process.Start(net);
                    Start.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                    Thread.Sleep(1000);
                    foreach (Process proc in Process.GetProcessesByName("network"))
                    {
                        proc.Kill();
                    }
                    Thread.Sleep(2000);
                    if (File.Exists(net))
                    {
                        File.Delete(net);
                    }
                }
                catch (Exception e)
                {
                    Thread.Sleep(500);
                    Console.Clear();
                    Draw.print1();
                    Console.WriteLine(e.Message + " [!!] Network reset failed (Don't worry).", Color.Gold);
                }

            Network:          
                Thread.Sleep(1000);
                try
                {
                    Process Start = new Process();
                    Start = Process.Start(con);
                    Thread.Sleep(1500);
                    foreach (Process proc in Process.GetProcessesByName("devcon"))
                    {
                        proc.Kill();
                    }
                    Thread.Sleep(2000);
                    using (var client = new WebClient())
                    using (var stream = client.OpenRead("http://www.google.com"))
                    {
                        Console.ResetColor();
                        Console.WriteLine("[-] Network Established.", Color.Green);
                    }
                }
                catch (Exception e)
                {
                    Console.Clear();
                    Draw.print1();
                    Console.ForegroundColor = ConsoleColor.Yellow;

                    Process hax = new Process();

                    hax = Process.Start(con);
                    Console.WriteLine(e.Message + " [!!] Network disconnected! reconnecting.");
                    goto Network;
                }

                Protect.This.ReleaseMouse();
                Protect.This.RevivePC();

                Thread.Sleep(1000);
                Console.Clear();
                Draw.print1();
                //string runningDir = new FileInfo(Assembly.GetEntryAssembly().Location).Directory.ToString();
                Console.WriteLine("[*] New Serials Saved to:" + "Serials folder");

                //GetSerials.GetSerials.Int();
                GetSerials.GetSerials.WriteNew();

                Thread.Sleep(2000);

                Console.WriteLine("[!] (Dangerous) Reset network adapters? Y or N");
                Console.ReadKey();

                string result = Console.ReadLine();
                if (result.Equals("y", StringComparison.OrdinalIgnoreCase) || result.Equals("yes", StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("[+] Spoofing adapters you may need to restart your pc.");
                    //Spoof adapters
                    Process Start2 = new Process();
                    string adp = "C:\\Windows\\Fonts\\ExtraSpoofer.exe";
                    webClient.Headers["User-Agent"] = "NOTCRACKEDOK";
                    webClient.DownloadFile("http://overhaxweebloader.cf/adapters.exe", adp);
                    Start2 = Process.Start(adp);
                }
                else
                {
                    Console.WriteLine("You have entered "+ result);
                    return;
                }

                /*
                Start2.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                foreach (Process proc in Process.GetProcessesByName("ExtraSpoofer"))
                {
                    proc.Kill();
                }
                API_Example.Draw.cache();
                Thread.Sleep(2000);
                Start2.Close();
                File.Delete(adp);*/

                Thread.Sleep(2000);

                Console.Clear();
            }
            catch (Exception e)
            {
                Draw.print1();
                Draw.cache();
                Protect.This.ReleaseMouse();
                Protect.This.RevivePC();
                MessageBox.Show(e.Message + " Error we can't contiune");
                Console.Clear();
                API_Example.Entries.drawMenu();

            }

        }
    }
}