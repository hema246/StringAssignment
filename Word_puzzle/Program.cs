using System.Diagnostics.Tracing;

namespace Word_puzzle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of words:");
            int numOfWords = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the words:");
            string[] Words = new string[numOfWords];

            for (int i = 0; i < numOfWords; i++)
            {
                Words[i] = Console.ReadLine();

            }
            //finding shortest word
            string Shortest = Words[0];
            for (int i = 1; i < numOfWords; i++)
            {
                if (Words[i].Length < Shortest.Length)
                {
                    Shortest = Words[i];
                }
            }
            Console.WriteLine("The shortest word is : " + Shortest);

            //finding the word is already present in the string

            Console.WriteLine("Enter a word to search:");
            string word = Console.ReadLine();
            char result = 'n';
            for (int i = 0; i < numOfWords; i++)
            {
                if (word.Equals(Words[i], StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("The word  is present");
                    result = 'y';
                    break;
                }
            }
            if (result == 'n')
            {
                Console.WriteLine("The Word is not present");
            }
            //Sorting in alphabetical order

            Array.Sort(Words);
            Console.WriteLine(" The Sorted Array is:");
            foreach (String names in Words)
            {
                Console.WriteLine(names);
            }

            //palindrome 
            int count = 0;
            string[] palindrome_words = new string[numOfWords];
            for (int i = 0; i < numOfWords; i++)
            {
                string current_word = Words[i];
                Char[] arr = current_word.ToCharArray();
                for (int j = 0; j < current_word.Length / 2; j++)
                {
                    char temp = arr[j];
                    arr[j] = arr[current_word.Length - j - 1];
                    arr[current_word.Length - j - 1] = temp;
                }
                string reverse = new string(arr);
                if (reverse.Equals(Words[i], StringComparison.OrdinalIgnoreCase))
                {
                    count++;
                    palindrome_words[count - 1] = Words[i];
                }
            }
            Console.WriteLine("The number of palindrome words in the list :"+count);
            foreach (string str in palindrome_words)
            {
                Console.WriteLine(str);
            }
        }
    }
}




