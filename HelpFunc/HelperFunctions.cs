using System;
namespace Telegram.Bot.Examples.WebHook.HelpFunc
{
    public class HelperFunctions
    {
        public HelperFunctions()
        {
        }

        public static string GetRandomEnglishWords()
        {
            try
            {
                List<string> englishWords = new List<string>() { "chair", "disappear", "gave", "hug", "knee" };//todo: create load in file english words
                Random rand = new Random();
                string word = englishWords[index: rand.Next(1, 5)];
                return word;
            }
            catch (Exception ex)
            {
                return "Error GetRandomEnglishWords: " + ex.Message;
            }

        }
    }
}

