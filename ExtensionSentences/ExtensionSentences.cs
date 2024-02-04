using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Extansion1.ExtensionSentences
{
    public static class ExtensionSentences
    {      
        public static void SentenceToSplit(this string sentence)        
        {
            string[] split = sentence.Split(' ');

            foreach (var item in split)
            {
                Console.WriteLine(item);
            }                 
       
        }     

    }
}
