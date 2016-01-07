using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;

namespace Hasher
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashing newHashing = new Hashing();
            string getUI = newHashing.getUseInput();
            int printInt = newHashing.hash(getUI);
            newHashing.resultingHash(getUI);
            

            //var awesomeList = new CustomDictionary<string>();

            //{ awesomeList = getUI[printInt]; }

        }
    }
}
