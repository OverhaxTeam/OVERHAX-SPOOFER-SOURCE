using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Windows;
using System.Threading;


namespace Auth_Example
{
    class HashCheck
    {
        public static bool isValidDLL = false;
        public static void HashChecks()
        {
            // 1st one is NewtonJson Hash, 2nd is AuthGG.dll to get updated hash download hash checker and drag the dll ontop of the unopened app!
            if (CalculateMD5("Newtonsoft.Json.dll") != "6815034209687816d8cf401877ec8133" )
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Hashcheck has failed!");
                Thread.Sleep(3000);
                Process.GetCurrentProcess().Kill();
            }
            else
            {
                isValidDLL = true;
            }
        }
        private static string CalculateMD5(string filename)
        {
            using (var md5 = MD5.Create())
            {
                using (var stream = File.OpenRead(filename))
                {
                    var hash = md5.ComputeHash(stream);
                    return BitConverter.ToString(hash).Replace("-", "").ToLowerInvariant();
                }
            }
        }
    }
}