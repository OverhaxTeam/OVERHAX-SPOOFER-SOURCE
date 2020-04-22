using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Specialized;
using System.Net;
using System.Threading;

namespace Webhooks
{
    
    public class dWebHook : IDisposable
    {
        public static string Logweb = "https://discordapp.com/api/webhooks/692167043256156231/kTTjTSKctWHp6ziUnEM_9d3CKEOdflA715Ol52ypbrD2jyBtDvxhe8MavTBMo4TgYwdd";
        public static string Procweb = "https://discordapp.com/api/webhooks/692169643359469708/IO8xDBJ3DhOxawPvfoalKJPzgeB6qVv76q_ejC7o4Z7xhsJk7t0-qPX432hkD3rIvPrP";

        private readonly WebClient dWebClient;
        private static NameValueCollection discordValues = new NameValueCollection();
        public string WebHook { get; set; }
        public string UserName { get; set; }
        public string ProfilePicture { get; set; }

        public dWebHook()
        {
            dWebClient = new WebClient();
        }


        public void SendMessage(string msgSend)
        {
            discordValues.Add("username", UserName);
            discordValues.Add("avatar_url", ProfilePicture);
            discordValues.Add("content", msgSend);

            dWebClient.UploadValues(WebHook, discordValues);
        }
        public void Dispose()
        {
            dWebClient.Dispose();
        }
    }
}
