using System;
using System.Collections.Generic;
using System.Text;

namespace Extansion1.ExtansionNumber
{
    public static class ExtensionNumber
    {
        public static int Cube(this int number, int toCube) 
        {
            return toCube * toCube * toCube;
        }      
    }
}
