using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIB
{
    public static class Money
    {
        private static string typeMoney = "VND";
        public static string convertMoney(string str)
        {
            if(str.Contains("."))
            {
                str = str.Substring(0, str.IndexOf('.'));
            }

            string res = "";

            int count = 1;

            for(int i = str.Length - 1; i >= 0; i--)
            {
                if(count % 4 == 0)
                {
                    res += '.';
                    i++;
                }
                else
                {
                    res += str[i];
                }

                count++;
            }

            str = "";

            for(int i = res.Length - 1; i >= 0; i--)
            {
                str += res[i];
            }

            return str;
        }
    }
}
