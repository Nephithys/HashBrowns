using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hasher
{
    class Hashing
    {
        public string getUseInput()
        {
            Console.WriteLine("Enter a password");
            string useString = Console.ReadLine();
            return useString;
        }

        public int hash(string useString)
            {
                int res = 0;
                foreach (char c in useString)
                {
                    int d = c - 'A' + 1;
                    res = 26 * res + d;
                }
                return res;
            }

        public void resultingHash(string useString)
        {
            

            var ss = new[] { useString };
            foreach (var s in ss)
            {
                Console.WriteLine("{0} - {1}", s, hash(s));
            }
        }

        
    }
}