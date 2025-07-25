﻿
namespace LongestCommonPrefix;

internal class LongestCommonPrefix
{
    public static string FindLongestCommonPrefix(string[] strs)
    {
        int shortest = strs[0].Length;
        int mathcingCount = 0;
        string result = "";
        foreach (string str in strs)
        {
            if (str.Length < shortest) shortest = str.Length;
        }
        for (int i = 0; i < shortest; i++)
        {
            char testChar = strs[0][i];
            foreach (string str in strs)
            {
                if (str[i] != testChar)
                {
                    for (int j = 0; j < mathcingCount; j++)
                    {
                        string letter = strs[0][j].ToString();
                        result += letter;
                    }
                    return result;
                }
            }
            mathcingCount++;
        }
        for (int j = 0; j < mathcingCount; j++)
        {
            string letter = strs[0][j].ToString();
            result += letter;
        }
        return result;
    }
    public static string LCPV2(string[] strs)
    {
        string shortestStr = strs[0];
        int matchingCount = 0;
        string result = "";
        foreach (string str in strs)
        {
            if (str.Length < shortestStr.Length) shortestStr = str;
        }
        for (int i = 1; i <= shortestStr.Length; i++)
        {
            char testChar = shortestStr[i - 1];
            foreach (string str in strs)
            {
                if (str[i - 1] != testChar)
                {
                    for (int j = 0; j < matchingCount; j++)
                    {
                        string letter = shortestStr[j].ToString();
                        result += letter;
                    }
                    return result;
                }
            }
            matchingCount++;
        }
        return shortestStr;
    }
}


