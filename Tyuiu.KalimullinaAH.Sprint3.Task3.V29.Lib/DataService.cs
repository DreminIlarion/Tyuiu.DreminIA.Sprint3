﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.DreminIA.Sprint3.Task3.V29.Lib
{
    public class DataService : ISprint3Task3V29
    {
        public string DeleteCharInString(string value, char item)
        {
            string res = "";
            foreach (char chr in value)
            {
                if (chr != item)
                {
                    res += chr;


                }
                
            }return res;
        }
    }
}
