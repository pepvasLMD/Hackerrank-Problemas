using System;
using System.Collections;

namespace Anagrams
{
    class Program
    {
        static void Main(string[] args)
        {
            bool anagrams = true;
            byte i = 0;
            Hashtable frequencyA = getFrequencyString(Console.ReadLine());
            Hashtable frequencyB = getFrequencyString(Console.ReadLine());


            if(frequencyA.Count != frequencyB.Count)
            {
                anagrams = false;
            }

            foreach(DictionaryEntry elemento in frequencyA)
            {
                if (frequencyB.ContainsKey(elemento.Key))
                {
                    if ((int)elemento.Value != (int)frequencyB[elemento.Key])
                    {
                        anagrams = false;
                        break;
                    }
                }
            }

            if (anagrams)
            {
                Console.WriteLine("Anagrams");
            }
            else
            {
                Console.WriteLine("Not Anagrams");
            }
        }

        public static Hashtable getFrequencyString(string s)
        {
            Hashtable frequency = new Hashtable();
            byte i;

            for (i = 0; i < s.Length; i++)
            {
                if (frequency.ContainsKey(s[i]))
                {
                    frequency[s[i]] = (int)frequency[s[i]] + 1;
                }
                else
                {
                    frequency.Add(s[i], 1);
                }
            }

            return frequency;
        }
    }
    
}
