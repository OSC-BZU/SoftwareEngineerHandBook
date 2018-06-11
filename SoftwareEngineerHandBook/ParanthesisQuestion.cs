using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;
namespace SoftwareEngineerHandBook
{
    public class ParanthesisQuestion
    {

        public static char[,] tokens;

        /// <summary>
        ///  Balanced Brackets source: hacker rank.
        /// </summary>
        public ParanthesisQuestion()
        {
            tokens = new char[,] { { '{', '}' }, { '(', ')' }, { '[', ']' } };
            
            List<string> itemsToBeChecked = new List<string>()
              {
            "{[()]}",            "{[(])}","{{[[(())]]}}"
        };
            
            foreach (string item in itemsToBeChecked)
            {
                if (checkIfBalanced(item))
                {
                    Console.WriteLine("YES");
                }
                else
                {
                    Console.WriteLine("NO");
                }
            }
        }
        public static bool matches(char openTerm, char closeTerm)
        {
            for (int i = 0; i < tokens.Length/2; i++)
            {
                if (tokens[i, 0] == openTerm)
                {
                    return tokens[i, 1] == closeTerm;
                }
            }
            return false;
        }
        public static bool isOpenTerm(char element)
        {
            for (int i = 0; i < tokens.Length/2; i++)
            {
                if (tokens[i, 0] == element)
                {
                    return true;
                }
            }
            return false;
        }


        public static bool checkIfBalanced(string text)
        {
            Stack<char> kontrolStack = new Stack<char>();


            for (int i = 0; i < text.Length; i++)
            {
                if (isOpenTerm(text[i]))
                {
                    kontrolStack.Push(text[i]);
                }
                else
                {
                    if (kontrolStack.Count() == 0)
                    {
                        return false;
                    }
                    char top = kontrolStack.Pop();
                    if (!matches(top, text[i]))
                    {
                        return false;
                    }
                }
            }
            return kontrolStack.Count() == 0;
        }
    }

}