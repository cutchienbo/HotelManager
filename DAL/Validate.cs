﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Validate : Database
    {
        public bool checkExisted(string condition, string checkValue)
        {
            string[] colAndTable = condition.Split('-');

            string query = "SELECT " + colAndTable[0] + " FROM  [" + colAndTable[1] + "] WHERE  " + colAndTable[0] + " = '" + checkValue + "'";

            SqlDataReader res = queryExecute(query);

            if(res != null)
            {
                return true;
            }

            return false;
        }

        public bool checkLength(string condition, string checkValue)
        {
            int length = checkValue.Length;

            if (condition.Contains('-'))
            {
                string[] minMax = condition.Split('-');

                int a = int.Parse(minMax[0]);
                int b = int.Parse(minMax[1]);

                int min = a > b ? b : a;
                int max = (a + b) - min;

                if (length < min || length > max)
                {
                    return true;
                }
            }
            else if (condition.Contains('>'))
            {
                int n = int.Parse(condition.Replace('>', ' ').Trim(' '));

                if(length <= n)
                {
                    return true;
                }
            }
            else if (condition.Contains('<'))
            {
                int n = int.Parse(condition.Replace('<', ' ').Trim(' '));

                if (length >= n)
                {
                    return true;
                }
            }
            else
            {
                return length == int.Parse(condition.Trim(' '));
            }

            return false;
        }
    }
}
