using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    internal class module_5
    {
        /// <summary>
        /// разделение строки на слова с помощью встроенной библиотеки и функции string.Split()
        /// </summary>
        /// <param name="Text"></param>
        /// <returns></returns>
        public static string[] Split(string Text)
        {
            return Text.Split(new char[] { ' ' });

        }
        /// <summary>
        /// размещение слов в обратном порядке
        /// </summary>
        /// <param name="Phrase"></param>
        public static string ReversPhrase(string Phrase)
        {
            var splitedPhrase = Split(Phrase);
            string reversPhrase = "";
            for (int i = splitedPhrase.Length - 1; i >= 0; i--)
            {
                reversPhrase += splitedPhrase[i] + " ";
            }
           return reversPhrase;
        }
    }
}
