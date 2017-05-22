using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Football
{
    class Hashing
    {
        public string hash(string a)
        {
            long mod = 1000000009;
            long ans = 0;
            long b = 257;
            long c = 1;
            for (int i=0; i<a.Length; i++)
            {
                long d = a[i];
                long e = (d * c)%mod;
                c = (c * b)%mod;
                ans = (ans + e)% mod;
            }
            return ans.ToString();
        }
    }
}
