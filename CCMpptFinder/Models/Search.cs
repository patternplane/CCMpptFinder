using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CCMpptFinder
{

    class Search
    {
        public static void test()
        {
            StringKMP.FindPattern_simple("ababcabakcakcabk", "aba", StringChecker);
        }
        static bool StringChecker(char a, char b)
        {
            return (a == b);
        }


        static void search()
        {

        }

    }

}
