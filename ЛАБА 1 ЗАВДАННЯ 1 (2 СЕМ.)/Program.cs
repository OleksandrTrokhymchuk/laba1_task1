using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.Remoting.Services;
using System.Xml.Linq;

namespace laba
{
    class Program
    {

        static void Main(string[] args)
        {

            Dictionary<int, string> WordsInDictionary = new Dictionary<int, string>();
            Console.WriteLine("Enter text: ");
            string text = Console.ReadLine();

            string[] arrayOfWordsFromText = text.Split(' ');

            int index = 0;

            while (index < arrayOfWordsFromText.Length)
            {
                WordsInDictionary.Add(index, arrayOfWordsFromText[index]);
                index++;
            }
           

            Console.WriteLine($"\nNumber of words in text = {arrayOfWordsFromText.Length}\n");

            foreach (KeyValuePair<int, string> i in WordsInDictionary)
            {
                Console.WriteLine(i.Key + " " + i.Value);
            }


            Console.Write("\nEnter element: ");
            int element = int.Parse(Console.ReadLine());

            string direction;

            do
            {
                Console.Write("\nEnter direction (back/forward): ");
                direction = Console.ReadLine();

                if (direction == "forward")
                {
                    for (index = element; index < arrayOfWordsFromText.Length; index++)
                    {
                        Console.WriteLine(arrayOfWordsFromText[index]);
                    }
                    break;
                }

                if (direction == "back")
                {
                    for (index = element; index >= 0; index--)
                    {
                        Console.WriteLine(arrayOfWordsFromText[index]);
                    }
                    break;
                }
            } while (direction != "forward" || direction != "back");

            Console.ReadLine();

        }
    }
}






