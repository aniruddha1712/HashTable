using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTables
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the HashTable program");
            
            string paragraph = "To be or not to be";
            FrequencyOfWords.GetFrequencyOfWords(paragraph);

            Console.ReadLine();
        }
    }
}
