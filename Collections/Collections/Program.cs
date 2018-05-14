using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input a sentence of a phrase : ");
            string sentence = Console.ReadLine();

            var charFrequencies = GetCharFrequecy(sentence);

            foreach (var key in charFrequencies.Keys)
            {
                Console.WriteLine($" {key} apprears {charFrequencies[key]} times");
            }
        }

        /// <summary>
        /// Calculate the frequency of each charector in a given sentence or phrase. 
        /// </summary>
        static Dictionary<char, int> GetCharFrequecy(string sentence)
        {
            Dictionary<char, int> frequency = new Dictionary<char, int>();

            foreach (var key in sentence)
            {
                if (frequency.ContainsKey(key))
                {
                    frequency[key]++;
                }
                else
                {
                    frequency.Add(key, 1);
                }
            }

            return frequency;
        }
    }
}
