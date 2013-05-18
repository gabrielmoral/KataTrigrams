namespace KataTrigrams
{
    public class Analizer
    {
        private static string SeparatorKeyWords = " ";

        public static Trigram Extract(string inputText)
        {
            string[] words = inputText.Split();
            Trigram trigram = new Trigram();

            for (int i = 0; i < words.Length; i++)
            {
                if (ContinueReadWords(words, i))
                {
                    string keyWords = ExtractKeyWords(words, i);
                    string valueWord = ExtractValueWord(words, i);
                    trigram.Pull(keyWords, valueWord);
                }
            }

            return trigram;
        }

        private static bool ContinueReadWords(string[] words, int i)
        {
            return words.Length - i >= 3;
        }

        private static string ExtractValueWord(string[] words, int i)
        {
            return words[i + 2];
        }

        private static string ExtractKeyWords(string[] words, int i)
        {
            return words[i] + SeparatorKeyWords + words[i + 1];
        }
    }
}
