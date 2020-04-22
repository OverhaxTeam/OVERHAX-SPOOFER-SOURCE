using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Auth
{
    class Settings
    {
        public static string AID = "599067"; // Top left of your panel next to your user photo
        public static string Secret = "WNPGy5pAHcqR5XWc89puR80xFLO2aVM6idl"; // On dashboard next to your application name
        //public static string PremiumAPIKey = "4853532628925927247"; // In Account tab, generate yourself one, only available to premium users!
        public static string Version = "1.0"; // In your applications settings
        public static string HWID()
        {
            return WindowsIdentity.GetCurrent().User.Value;
        }
        public static string Time()
        {
            string time = DateTime.Now.ToString("hh:mm tt MM/dd/yyyy");
            return time;
        }
    }
}
