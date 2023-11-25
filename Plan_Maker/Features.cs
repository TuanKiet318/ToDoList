using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plan_Maker
{
    class KMPAlgorithm
    {
        static int[] ComputeLPSArray(string pattern)
        {
            int m = pattern.Length;
            int[] lps = new int[m];
            int len = 0;
            int i = 1;

            while (i < m)
            {
                if (pattern[i] == pattern[len])
                {
                    len++;
                    lps[i] = len;
                    i++;
                }
                else
                {
                    if (len != 0)
                    {
                        len = lps[len - 1];
                    }
                    else
                    {
                        lps[i] = 0;
                        i++;
                    }
                }
            }

            return lps;
        }

        public static bool KMPSearch(string text, string pattern)
        {
            int n = text.Length;
            int m = pattern.Length;

            int[] lps = ComputeLPSArray(pattern);

            int i = 0; 
            int j = 0; 

            while (i < n)
            {
                if (pattern[j] == text[i])
                {
                    j++;
                    i++;
                }

                if (j == m)
                {
                    return true;
                }
                else if (i < n && pattern[j] != text[i])
                {
                    if (j != 0)
                    {
                        j = lps[j - 1];
                    }
                    else
                    {
                        i++;
                    }
                }
            }

            return false;
        }
    }

}
