using System;
using System.IO;

namespace Hangman
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            
            // fnutt File.WriteAllText("words.txt", "axel haha");
            
            string aksleliljaful = File.ReadAllText("words.txt");
            
            Console.WriteLine(aksleliljaful);
            
            // Console.ReadLine();

            // string[] words = {"Hat", "Coat", "Pants"};
            // File.WriteAllLines("words.txt", words);


            if (File.Exists("words.txt"))
            {

            string [] words = File.ReadAllLines("words.txt");
            
            Console.WriteLine(words[1]);
            
            Console.ReadLine();
            }
        }
    }
}
