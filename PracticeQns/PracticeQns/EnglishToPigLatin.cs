namespace PracticeQns
{
    public class IEnglishToPigLatin
    {
        public bool IsVowel(char input)
        {
            // This is a utilty function to determine whether the input character is vowel or not.
            input = char.ToLower(input);
            if (input == 'a' || input == 'e' || input == 'i' || input == 'o' || input == 'u')
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public string TranslateWord(string word)
        {
            // This function reverses prefix of a word till it finds vowel and then adds 'ay'
            // otherwise adds 'yay' to end of string
            // Preserves case of input string and deals with punctuations
            bool startsWithCaps = char.IsUpper(word[0]);
            int punctuationFound = word.IndexOfAny(new char[] { '.', '!', '?', '\\', '-', ',' });
            string punctuations = (punctuationFound < 0) ? "" : word.Substring(punctuationFound);
            word = (punctuationFound < 0) ? word : word.Substring(0, punctuationFound);

            if (IsVowel(word[0]))
            {
                word = word + "yay";
            }
            else
            {
                int index = 0;
                char currentLeadingChar = word[index];
                string tempWindow = "";
                while (!IsVowel(currentLeadingChar) && index < word.Length)
                {
                    tempWindow = tempWindow + currentLeadingChar;
                    index++;
                    if (index < word.Length)
                        currentLeadingChar = word[index];
                }
                word = word.Substring(index) + tempWindow + "ay" + punctuations;
            }
            word = word.ToLower();
            if (startsWithCaps)
            {
                return "" + char.ToUpper(word[0]) + word.Substring(1);
            }
            return word;
        }
        public string TranslateSentence(string sentence)
        {
            // This function splits sentence into a list of words and utilizes TranslateWord
            List<string> wordsInSentence = new List<string>(sentence.Split(" "));
            string convertedSentence = "";
            foreach (string word in wordsInSentence)
            {
                convertedSentence += TranslateWord(word) + " ";
            }
            return convertedSentence;
        }
    }

    public class RunnerConverter : IEnglishToPigLatin
    {
        public void runner()
        {
            Console.WriteLine(TranslateWord("shrimp"));
            Console.WriteLine(TranslateWord("qwtyhk!?."));

            Console.WriteLine(TranslateSentence("I like to eat honey waffles"));
            Console.WriteLine(TranslateSentence("Do you Think it is going to rain today?"));
            Console.WriteLine(TranslateSentence("Do you Think, it is gOing to Rain today?"));


        }
    }
}