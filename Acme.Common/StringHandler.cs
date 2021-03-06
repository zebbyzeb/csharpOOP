﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acme.Common
{
    public static class StringHandler
    {
        /// <summary>
        /// Inserts space before each capital letter
        /// </summary>
        /// <param name="source"></param>
        /// <returns></returns>
        public static string InsertSpace(this string source)
        {
            string result = string.Empty;

            if (!string.IsNullOrWhiteSpace(source))
            {
                for (int i=0; i<source.Length; i++)
                {
                    if (i == 0)
                    {
                        result += source[i];
                        continue;
                    }
                    else
                    {
                        if (Char.IsUpper(source[i]) && !Char.IsWhiteSpace(source[i-1]))//could've used result.Trim()
                        {
                            result += " ";
                        }
                        result += source[i];
                    }
                }
            }
            return result;
        }
    }
}
