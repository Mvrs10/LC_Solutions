﻿using System;
using System.Collections.Generic;


namespace ValidParentheses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool result = isValid("{{{{");
            Console.WriteLine(result);
        }

        static bool isValid(string s)
        {
            Stack<char> stack = new Stack<char>();
            stack.Push('.');
            Dictionary<char, char> map = new Dictionary<char, char>()
            {
                {'(',')'},
                {'{','}'},
                {'[',']'}
            };            
            foreach (char c in s)
            {
                
                if (map.ContainsKey(c))
                {
                    stack.Push(map[c]);
                }
                else
                {
                    char top = stack.Pop();
                    if (top != c) return false;
                }
            }
            return stack.Count == 1;
        }
    }
}
