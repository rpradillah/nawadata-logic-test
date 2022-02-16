using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NawaDataLogic.App
{
    class Test01
    {
        public Test01()
        {
            Console.WriteLine("Input one line of words :");
            string sWords = Console.ReadLine();

            Result(sWords.ToLower());
        }

        // STRING SORTING
        public string sortString(string word)
        {
            char[] result = word.ToArray();
            Array.Sort(result);
            return new string(result);
        }

        public void Result(string sWords)
        {
            // VOWEL VARIABLE
            string aVowel = "aiueo";
            string resultVowel = string.Empty;
            string resultConsonant = string.Empty;

            for (int i = 0; i < sWords.Length; i++)
            {
                // IGNORE WHITE SPACE
                if (sWords[i].ToString() != " ")
                {
                    var sTemp = string.Empty;
                    for (int j = 0; j < aVowel.Length; j++)
                    {
                        if (sWords[i] == aVowel[j])
                        {
                            resultVowel += sWords[i];
                            sTemp = string.Empty;
                            break;
                        }
                        else
                        {
                            sTemp = sWords[i].ToString();
                        }
                    }
                    resultConsonant += sTemp;
                }
            }

            Console.WriteLine("Vowel Characters : " + sortString(resultVowel));
            Console.WriteLine("Consonant Characters : " + sortString(resultConsonant));
        }
    }
}
