using System;

namespace Open_Lab_04._03
{
    public class StringTools
    {
        public string RemoveFirstLast(string original)
        {
            string ret = "";
            int length = original.Length;
            if (length == 0)
                return original;
            else if (length == 1)
                return original;
            else
            {
                for (int i = 1; i < (length - 1); i++)
                {
                    ret = ret + original[i];
                }
                return ret;
            }
        }
    }
}