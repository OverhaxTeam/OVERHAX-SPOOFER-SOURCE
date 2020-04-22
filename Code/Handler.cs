using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Security;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
namespace Auth
{
    class Handler
    {
        private static Dictionary<string, object> Vars = new Dictionary<string, object>();
        private static Random random = new Random();
        public static string HashKeys(int length)
        {
            const string chars = "123456789";
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }
        public static int RandomNumber()
        {
            var rnd = new Random(DateTime.Now.Millisecond);
            int pik = rnd.Next(10, 50);
            return pik;
        }
        public static void Initialize()
        {
            Authentication.OpenEncryption();
            using (var client = new WebClient())
            {
                try
                {
                    client.Proxy = null;
                    HttpWebRequest.DefaultWebProxy = new WebProxy();
                    client.Headers["User-Agent"] = "AuthGG";
                    var values = new NameValueCollection();
                    int iblis = RandomNumber();
                    string optimization = HashKeys(iblis);
                    values["type"] = "start";
                    values["aid"] = Settings.AID;
                    values["secret"] = Settings.Secret;
                    values["random"] = iblis.ToString();
                    var response = client.UploadValues("https://api.auth.gg/version2/api.php", values);
                    var resp = Encoding.Default.GetString(response);
                    dynamic json = JsonConvert.DeserializeObject(resp);
                    ProgramInfo.APIKey = (string)json.hashed;
                    ProgramInfo.Status = (string)json.status;
                    ProgramInfo.Hash = (string)json.hash;
                    ProgramInfo.Version = (string)json.version;
                    ProgramInfo.DownloadLink = (string)json.downloadlink;
                    ProgramInfo.Freemode = (string)json.freemode;
                    ProgramInfo.Login = (string)json.login;
                    ProgramInfo.Register = (string)json.register;
                    ProgramInfo.DeveloperMode = (string)json.developermode;
                    ProgramInfo.Application = (string)json.applicationname;
                    if (ProgramInfo.Status == "Failed")
                    {
                        MessageBox.Show("Premium API key does not match!", "OverhaxSpoofer | Licensing System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Process.GetCurrentProcess().Kill();
                    }
                    if (ProgramInfo.Status == "Disabled")
                    {
                        MessageBox.Show("This application is disabled!", "OverhaxSpoofer | Licensing System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Process.GetCurrentProcess().Kill();
                    }
                    if (ProgramInfo.DeveloperMode == "Disabled")
                    {
                        if (ProgramInfo.Version != Settings.Version)
                        {
                            MessageBox.Show($"Update [{ProgramInfo.Version}] is available!", "OverhaxSpoofer | Licensing System", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Process.Start(ProgramInfo.DownloadLink);
                        }
                        string CurrentHash = CalculateMD5(Application.ExecutablePath);
                        if (ProgramInfo.Hash != CurrentHash)
                        {
                            MessageBox.Show("Hashes do not match, file tampering possible!", "OverhaxSpoofer | Licensing System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            Process.GetCurrentProcess().Kill();
                        }
                    }
                    else
                    {
                        MessageBox.Show($"Developer mode is enabled, bypassing security checks!", "OverhaxSpoofer | Licensing System", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch
                {
                    MessageBox.Show("Something went wrong!", "OverhaxSpoofer Licensing System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            Authentication.CloseEncryption();
        }
        public static void Log(string username, string action)
        {
            Authentication.OpenEncryption();
            using (var client = new WebClient())
            {
                try
                {
                    client.Proxy = null;
                    HttpWebRequest.DefaultWebProxy = new WebProxy();
                    client.Headers["User-Agent"] = "AuthGG";
                    var values = new NameValueCollection();
                    values["type"] = "log";
                    values["aid"] = Settings.AID;
                    values["secret"] = Settings.Secret;
                    values["time"] = Settings.Time();
                    values["username"] = username;
                    values["pcuser"] = Environment.UserName;
                    values["action"] = action;
                    var response = client.UploadValues("https://api.auth.gg/version2/api.php", values);
                }
                catch
                {
                    MessageBox.Show("Something went wrong!", "OverhaxSpoofer Licensing System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            Authentication.CloseEncryption();
        }
        public static bool Login(string username, string password)
        {
            if (ProgramInfo.Login != "Enabled")
            {
                MessageBox.Show("Login is not available at this time!", "OverhaxSpoofer Licensing System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Process.GetCurrentProcess().Kill();
            }
            using (var client = new WebClient())
            {
                try
                {
                    Authentication.OpenEncryption();
                    client.Proxy = null;
                    HttpWebRequest.DefaultWebProxy = new WebProxy();
                    client.Headers["User-Agent"] = "AuthGG";
                    var values = new NameValueCollection();
                    int iblis = RandomNumber();
                    string optimization = HashKeys(iblis);
                    values["type"] = "login";
                    values["username"] = username;
                    values["password"] = password;
                    values["hwid"] = Settings.HWID();
                    values["aid"] = Settings.AID;
                    values["secret"] = Settings.Secret;
                    values["time"] = Settings.Time();
                    values["random"] = iblis.ToString();
                    var response = client.UploadValues("https://api.auth.gg/version2/api.php", values);
                    var resp = Encoding.Default.GetString(response);
                    dynamic json = JsonConvert.DeserializeObject(resp);
                    Authentication.CloseEncryption();
                    if ((string)json.status == "Failed")
                    {
                        MessageBox.Show("Premium API key does not match!", "OverhaxSpoofer | Licensing System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Process.GetCurrentProcess().Kill();
                    }
                    switch ((string)json.result)
                    {
                        case "success":
                            UserInfo.ID = (string)json.id;
                            UserInfo.Logged_In = bool.Parse((string)json.logged_in);
                            UserInfo.Username = (string)json.username;
                            UserInfo.Email = (string)json.email;
                            UserInfo.HWID = (string)json.hwid;
                            UserInfo.Variable = (string)json.variable;
                            UserInfo.Expiry = (string)json.expiry;
                            UserInfo.Rank = (string)json.rank;
                            UserInfo.IP = (string)json.ip;
                            Vars = JsonConvert.DeserializeObject<Dictionary<string, object>>(json.vars.ToString());
                            MessageBox.Show($"Welcome back, {username}!", $"{ProgramInfo.Application}", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return true;
                        case "invalid_details":
                            MessageBox.Show("Please check your credentials!", $"{ProgramInfo.Application}", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return false;
                        case "invalid_hwid":
                            MessageBox.Show("Invalid HWID, please do not attempt to share accounts!", $"{ProgramInfo.Application}", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return false;
                        case "hwid_updated":
                            MessageBox.Show("Your HWID has been updated, relogin!", $"{ProgramInfo.Application}", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return false;
                        case "time_expired":
                            MessageBox.Show("Your subscription has expired!", $"{ProgramInfo.Application}", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return false;
                        case "net_error":
                            MessageBox.Show("Something went wrong!", $"{ProgramInfo.Application}", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return false;
                        default:
                            MessageBox.Show("Something went wrong!", $"{ProgramInfo.Application}", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return false;
                    }
                }
                catch
                {
                    MessageBox.Show("Something went wrong!", $"{ProgramInfo.Application}", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
        }
        public static bool Register(string username, string password, string email, string token)
        {
            if (ProgramInfo.Register != "Enabled")
            {
                MessageBox.Show("Register is not available at this time!", "OverhaxSpoofer Licensing System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Process.GetCurrentProcess().Kill();
            }
            try
            {
                Authentication.OpenEncryption();
                using (var client = new WebClient())
                {
                    client.Proxy = null;
                    HttpWebRequest.DefaultWebProxy = new WebProxy();
                    client.Headers["User-Agent"] = "AuthGG";
                    var values = new NameValueCollection();
                    values["type"] = "register";
                    values["username"] = username;
                    values["password"] = password;
                    values["email"] = email;
                    values["token"] = token;
                    values["hwid"] = Settings.HWID();
                    values["aid"] = Settings.AID;
                    values["secret"] = Settings.Secret;
                    var response = client.UploadValues("https://api.auth.gg/version2/api.php", values);
                    var resp = Encoding.Default.GetString(response);
                    dynamic json = JsonConvert.DeserializeObject(resp);
                    Authentication.CloseEncryption();
                    switch ((string)json.result)
                    {
                        case "success":
                            MessageBox.Show($"{username}, you have successfully registered!", $"{ProgramInfo.Application}", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return true;
                        case "invalid_token":
                            MessageBox.Show("Invalid License!", $"{ProgramInfo.Application}", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return false;
                        case "email_used":
                            MessageBox.Show("Email is invalid or in use!", $"{ProgramInfo.Application}", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return false;
                        case "invalid_username":
                            MessageBox.Show("Invalid Username!", $"{ProgramInfo.Application}", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return false;
                        default:
                            MessageBox.Show("Something went wrong!", $"{ProgramInfo.Application}", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return false;
                    }
                }
            }
            catch
            {
                MessageBox.Show("Something went wrong!", $"{ProgramInfo.Application}", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        public static bool Login_Register_Redeem_With_Key(string key)
        {
            bool response = Login(key, key);
            if (response)
            {
                return true;
            }
            else
            {
                bool response1 = Register(key, key, key, key);
                if (response1)
                {
                    MessageBox.Show("Success, please restart application!", ProgramInfo.Application, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Process.GetCurrentProcess().Kill();
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        public static bool RedeemToken(string username, string password, string token)
        {
            try
            {
                Authentication.OpenEncryption();
                using (var client = new WebClient())
                {
                    client.Proxy = null;
                    HttpWebRequest.DefaultWebProxy = new WebProxy();
                    client.Headers["User-Agent"] = "AuthGG";
                    var values = new NameValueCollection();
                    values["type"] = "redeem";
                    values["username"] = username;
                    values["password"] = password;
                    values["token"] = token;
                    values["aid"] = Settings.AID;
                    values["secret"] = Settings.Secret;
                    var response = client.UploadValues("https://api.auth.gg/version2/api.php", values);
                    var resp = Encoding.Default.GetString(response);
                    dynamic json = JsonConvert.DeserializeObject(resp);
                    Authentication.CloseEncryption();
                    switch ((string)json.result)
                    {
                        case "success":
                            return true;
                        case "invalid_token":
                            MessageBox.Show("Invalid License!", $"{ProgramInfo.Application}", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return false;
                        case "invalid_details":
                            MessageBox.Show("Invalid Credentials!", $"{ProgramInfo.Application}", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return false;
                        case "net_error":
                            MessageBox.Show("Something went wrong!", $"{ProgramInfo.Application}", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return false;
                        default:
                            MessageBox.Show("Something went wrong!", $"{ProgramInfo.Application}", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return false;
                    }
                }
            }
            catch
            {
                MessageBox.Show("Something went wrong!", "Auth.GG Licensing System", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }
        internal class Authentication
        {
            public static void OpenEncryption()
            {
                ServicePointManager.ServerCertificateValidationCallback += PinPublicKey;
            }
            public static void CloseEncryption()
            {
                ServicePointManager.ServerCertificateValidationCallback = delegate { return true; };
            }
            private static bool PinPublicKey(object sender, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors)
            {
                return certificate != null && certificate.GetPublicKeyString() == _key;
            }
            private const string _key = "041B6566A801CC518B5AC35FE91FCF4BDD9E94F3AE8156DF327083B7DA8A62D5CE2A4C25245F1567A0AC51EF12C549E8D62CC27DB1398DE17F62015ADF00207D5D";
        }
        private static string CalculateMD5(string filename)
        {
            string result;
            using (MD5 md = MD5.Create())
            {
                using (FileStream fileStream = File.OpenRead(filename))
                {
                    byte[] value = md.ComputeHash(fileStream);
                    result = BitConverter.ToString(value).Replace("-", "").ToLowerInvariant();
                }
            }
            return result;
        }
        public static string GetVariable(string variable)
        {
            try
            {
                if (UserInfo.Logged_In)
                {
                    return Vars[variable].ToString();
                }
                else
                {
                    if (ProgramInfo.Freemode == "Enabled")
                    {
                        return Vars[variable].ToString();
                    }
                    else
                    {
                        MessageBox.Show("Attempting to get variable without being logged in!", $"{ProgramInfo.Application}", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return "[ERROR] : You are not logged in!";
                    }
                }
            }
            catch
            {
                return "[ERROR] : Variable does not exist!";
            }
        }
    }
}
