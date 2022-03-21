using System.Collections.Generic;
using System.Security.Principal;
using System.Text;

namespace KnockKnock.Web.Services
{
    public class ReverseWordsService : IReverseWordsService
    {

        public string Reverse(string sentence)
        {
            if (string.IsNullOrEmpty(sentence)) return string.Empty;

            const string token = "^^|";
            const string singleSpace = " ";
            
            if (!sentence.Contains(singleSpace))
                return ReverseWord(sentence);

            // replace the each space with a token, then parse out each word
            var wordList = sentence.Replace(singleSpace, "^^|&&&" ).Split("&&&");

            return ReverseWordsInSentence(wordList, token, singleSpace);
        }

        private string ReverseWordsInSentence(IList<string> wordList, string Token, string SingleSpace)
        {
            var output = new StringBuilder();
            foreach (var word in wordList)
            {
                if (word == Token)
                {
                    output.Append(SingleSpace);
                }
                else
                {
                    var temp = word.Contains(Token)
                        ? string.Concat(ReverseWord(word.Replace(Token, "")), SingleSpace)
                        : ReverseWord(word);

                    output.Append(temp);
                }
            }

            return output.ToString();
        }


        private string ReverseWord(string word)
        {
            if (string.IsNullOrEmpty(word)) return string.Empty;

            var length = word.Length;
            var newArray = word.ToCharArray();
            var j = length - 1;
            for (var i = 0; i < j; i++, j--)
            {
                var temp = newArray[i];
                newArray[i] = newArray[j];
                newArray[j] = temp;
            }

            return new string(newArray);
        }
    }
}