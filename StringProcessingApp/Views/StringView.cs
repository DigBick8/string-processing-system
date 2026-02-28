using System;
using StringProcessingApp.Services;

namespace StringProcessingApp.Views
{
    public class StringView
    {
        private StringService service = new StringService();

        public void Run()
        {
            bool running = true;

            while (running)
            {
                DisplayMenu();
                Console.Write("Choose an option: ");
                string choice = Console.ReadLine();

                Console.WriteLine();

                switch (choice)
                {
                    case "1":
                        EnterText();
                        break;

                    case "2":
                        Console.WriteLine("Current Text: " + service.GetText());
                        break;

                    case "3":
                        Console.WriteLine("UPPERCASE: " + service.ToUpperCase());
                        break;

                    case "4":
                        Console.WriteLine("lowercase: " + service.ToLowerCase());
                        break;

                    case "5":
                        Console.WriteLine("Character Count: " + service.CountCharacters());
                        break;

                    case "6":
                        CheckContains();
                        break;

                    case "7":
                        ReplaceWord();
                        break;

                    case "8":
                        ExtractSubstring();
                        break;

                    case "9":
                        Console.WriteLine("Trimmed Text: " + service.TrimSpaces());
                        break;

                    case "10":
                        service.ResetText();
                        Console.WriteLine("Text has been reset.");
                        break;

                    case "11":
                        running = false;
                        break;

                    default:
                        Console.WriteLine("Invalid option. Try again.");
                        break;
                }

                Console.WriteLine();
            }
        }

        private void DisplayMenu()
        {
            Console.WriteLine("---Menu Options---");
            Console.WriteLine("1. Enter Text");
            Console.WriteLine("2. View Current Text");
            Console.WriteLine("3. Convert to UPPERCASE");
            Console.WriteLine("4. Convert to lowercase");
            Console.WriteLine("5. Count Characters");
            Console.WriteLine("6. Check if Contains Word");
            Console.WriteLine("7. Replace Word");
            Console.WriteLine("8. Extract Substring");
            Console.WriteLine("9. Trim Spaces");
            Console.WriteLine("10. Reset Text");
            Console.WriteLine("11. Exit");
        }

        private void EnterText()
        {
            Console.Write("Enter text: ");
            string input = Console.ReadLine();
            service.SetText(input);
            Console.WriteLine("Text saved.");
        }

        private void CheckContains()
        {
            Console.Write("Enter word to search: ");
            string word = Console.ReadLine();

            bool result = service.ContainsWord(word);

            if (result)
                Console.WriteLine("The text contains the word.");
            else
                Console.WriteLine("The text does NOT contain the word.");
        }

        private void ReplaceWord()
        {
            Console.Write("Enter word to replace: ");
            string oldWord = Console.ReadLine();

            Console.Write("Enter new word: ");
            string newWord = Console.ReadLine();

            Console.WriteLine("Updated Text: " + service.ReplaceWord(oldWord, newWord));
        }

        private void ExtractSubstring()
        {
            try
            {
                Console.Write("Enter start index: ");
                int start = int.Parse(Console.ReadLine());

                Console.Write("Enter length: ");
                int length = int.Parse(Console.ReadLine());

                string result = service.ExtractSubstring(start, length);
                Console.WriteLine("Extracted Substring: " + result);
            }
            catch
            {
                Console.WriteLine("Invalid index or length.");
            }
        }
    }
}
