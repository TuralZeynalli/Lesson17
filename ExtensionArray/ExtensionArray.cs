using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Extansion1.ExtensionArray
{
   public static class ExtensionArray 
   {
        public static void Array(this int [] numbers)
        {
            if (numbers.Length == 1)
            {
                Console.WriteLine(numbers[0]);
            }
            else
            {
                Console.WriteLine(numbers[0] + numbers[numbers.Length - 1]);
            }
            //return sorus
        }
       
   }
}
