using Extansion1.ExtansionNumber;
using Extansion1.ExtensionArray;
using Extansion1.ExtensionSentences;
using System;
using System.Linq;

namespace Extansion1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Cube

            int number = 1;

            Console.WriteLine(number.Cube(5));

            #endregion


            #region Array

            int[] num = { 4, 5, 6 };

            num.Array();

            #endregion
             

            #region Sentence

            string sentence = "Ferhad yekdir";

            sentence.SentenceToSplit();

            #endregion                  

        }
    }
}
