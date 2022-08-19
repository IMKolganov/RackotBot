using System;
using System.Text;
using Newtonsoft.Json;

namespace Telegram.Bot.Examples.WebHook.BotClasses
{
    public class EnglishWord
    {
        public int id { get; set; }
        public string word { get; set; }

        public EnglishWord()
        {
            //load from file

        }

        public static List<EnglishWord>? loadEnglishWords()
        {
            try
            {
                string path = @"Files/EnglishWords.json";
                
                EnglishWord[] englishWords = JsonConvert.DeserializeObject<EnglishWord[]>(
                    File.ReadAllText(
                        path: path, encoding: Encoding.UTF8
                    ));
                return englishWords.ToList();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                return new List<EnglishWord> { new EnglishWord() { id = 0, word = "error load file " + ex.Message } };
            }
        }
    }
}

