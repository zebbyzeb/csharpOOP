using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acme.Common
{
    public class StringHandler
    {
        public string InsertSpace(string source)
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
                        if (Char.IsUpper(source[i]))
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
