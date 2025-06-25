using System;

namespace ExcelSheetColumnNumber;

internal class Solution
{
    internal static int TitleToNumber(string columnTitle)
    {
        int BASE = 64;
        int result = 0;
        int last = columnTitle.Length - 1;
        for (int i = 0; i < columnTitle.Length; i++)
        {
            int value = columnTitle[last - i] - BASE;
            result += value * (int)Math.Pow(26, i);
        }
        return result;
    }
}
