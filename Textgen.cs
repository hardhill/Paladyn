﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paladyn
{
    class Textgen
    {
        const string symbols = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
        private string GenText()
        {
            Random r = new Random();
            StringBuilder sb = new StringBuilder();
            Random s = new Random(10);
            var len = s.Next(3,25);
            for(int i = 1; i <= len; i++)
            {
                var index = r.Next(symbols.Length);
                Char b = symbols[index];
                sb.Append(b);
            }
            return sb.ToString();
        }

    }
}
