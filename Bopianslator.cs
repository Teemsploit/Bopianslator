using System;

class Program
{
    static string Bopianslate(string text)
    {
        string[] words = text.Split(' ');
        string[] bopianslatedWords = new string[words.Length];

        for (int i = 0; i < words.Length; i++)
        {
            string word = words[i];
            if (word.Length > 1)
            {
                bopianslatedWords[i] = "bopi" + word.Substring(1);
            }
            else
            {
                bopianslatedWords[i] = "bopi";
            }
        }

        return string.Join(" ", bopianslatedWords);
    }

    static void Main()
    {
        Console.WriteLine("Welcome to Bopianslateor!");
        Console.WriteLine("Type 'exit' to quit.\\n");

        while (true)
        {
            Console.Write("Enter text: ");
            string userInput = Console.ReadLine();

            if (userInput.ToLower() == "exit")
            {
                Console.WriteLine("Bopioodbye!");
                break;
            }

            string bopianslatedText = Bopianslate(userInput);
            Console.WriteLine("Bopianslated: " + bopianslatedText);
            Console.WriteLine();
        }
    }
}
