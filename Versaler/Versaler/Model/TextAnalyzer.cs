﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Versaler
{
    public static class TextAnalyzer
    {
        public static int GetNumberOfCapitals(this string text)
        {
            int num = 0; 
            foreach (char c in text)
            {
                if (c == char.ToUpper(c) && Char.IsLetter(c))
                {
                    num++;
                }
            }
            return num;
            //for (int i = 0; i < text.Length; i++)
            //{
            //    if (text[i] == Char.ToUpper(text[i]) && Char.IsLetter(text[i]))
            //    {
            //        num++; 
            //    }
            //}
        }
    }
}