using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    internal class Dict
    {
        public static string Convert(int i)
        {
            // TODO
            Dictionary<int,string> dict = new Dictionary<int,string>();
            dict.Add(0, "zero");
            dict.Add(1, "one");
            dict.Add(2, "two");
            dict.Add(3, "three");
            dict.Add(4, "four");
            dict.Add(5, "five");

            if(dict.ContainsKey(i))
            {
                return dict[i];
            }
            else
            {
                return "nope";
            }
        }
    }
}
