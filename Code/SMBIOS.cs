using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIMBIOS
{
    class Spoof
    {
        public static string RandomString(int length)
        {
            return new string((from s in Enumerable.Repeat<string>("0123456789", length)
                               select s[Spoof.random.Next(s.Length)]).ToArray<char>());
        }

        private static Random random = new Random();
    }
}
