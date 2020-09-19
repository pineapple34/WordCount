using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordCount
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите слово - ");
            string InputWord = Console.ReadLine();

            int wordCount = 0;
            string text = System.IO.File.ReadAllText("file.txt");
            string[] inputParsed = text.Split(' ', ',', '.') ;

            foreach (string word in inputParsed)
            {
                if (word.ToLower() == InputWord.ToLower()) wordCount++;
            }

            Console.WriteLine("Слово {0} встречается в тексте {1} раз(а)", InputWord, wordCount);

            Console.ReadKey();
        }
    }
}
