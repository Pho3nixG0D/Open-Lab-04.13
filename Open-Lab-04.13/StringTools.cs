using System;

namespace Open_Lab_04._13
{
    public class StringTools
    {
        public string GetLongestCommonSequence(string str1, string str2)
        {
            int x = 0;
            int i = 0;
            string longsub = "";

            for (i = 1; i <= str1.Length; i++)
            {
                for (x = 0; x <= str1.Length - i; x++)
                {
                    if (str2.Contains(str1.Substring(x, i)))
                    {
                        longsub = str1.Substring(x, i);
                    }
                }
            }
            return longsub;
        }
    }
}