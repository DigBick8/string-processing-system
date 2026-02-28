namespace StringProcessingApp.Services
{
    public class StringService
    {
        private string originalText = "";
        private string currentText = "";

        public void SetText(string text)
        {
            originalText = text;
            currentText = text;
        }

        public string GetText()
        {
            return currentText;
        }

        public string ToUpperCase()
        {
            currentText = currentText.ToUpper();
            return currentText;
        }

        public string ToLowerCase()
        {
            currentText = currentText.ToLower();
            return currentText;
        }

        public int CountCharacters()
        {
            return currentText.Length;
        }

        public bool ContainsWord(string word)
        {
            return currentText.Contains(word);
        }

        public string ReplaceWord(string oldWord, string newWord)
        {
            currentText = currentText.Replace(oldWord, newWord);
            return currentText;
        }

        public string ExtractSubstring(int startIndex, int length)
        {
            return currentText.Substring(startIndex, length);
        }

        public string TrimSpaces()
        {
            currentText = currentText.Trim();
            return currentText;
        }

        public void ResetText()
        {
            currentText = originalText;
        }
    }
}
