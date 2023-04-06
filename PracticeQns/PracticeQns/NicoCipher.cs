namespace PracticeQns
{
    public class NicoCipherEncoder
    {
        public int[] KeyToNumeric(string key)
        {
            int[] numericKey = new int[key.Length];
            string sortedKey = String.Concat(key.OrderBy(c => c));
            List<KeyValuePair<int, char>> pairs = new List<KeyValuePair<int, char>>();
            for (int index = 0; index < key.Length; index++)
            {
                pairs.Add(new KeyValuePair<int, char>(numericKey[index], key[index]));
            }
            int position = 0;
            foreach (var pair in pairs.OrderBy(pair => pair.Key))
            {
                numericKey[position] = pair.Value;
                position++;
            }
            return numericKey;
        }
        public string NicoCipher(string message, string key)
        {
            int spacesToAdd = key.Length - message.Length % key.Length;
            for (int offset = 0; offset < spacesToAdd;offset++){
                message += " ";
            }
            int[] numericKey = KeyToNumeric(key);
            string encodedMessage = "";
            // foreach (int rank in numericKey)
            // {
            //     Console.WriteLine(rank);
            // }
            int maxRun = message.Length / key.Length;
            for (int iteration = 0; iteration < maxRun; iteration++)
            {
                int startIndex = key.Length * iteration;
                int lengthOfTempWindow = message.Length - startIndex;
                string tempWindow = message.Substring(startIndex,
                (lengthOfTempWindow < key.Length) ? lengthOfTempWindow : key.Length);
                List<KeyValuePair<int, char>> pairs = new List<KeyValuePair<int, char>>();
                for (int index = 0; index < tempWindow.Length; index++)
                {
                    pairs.Add(new KeyValuePair<int, char>(numericKey[index], tempWindow[index]));
                }
                foreach (var pair in pairs.OrderBy(pair => pair.Key))
                {
                    encodedMessage += pair.Value;
                }
            }
            return encodedMessage;
        }
        public void EncoderRunner()
        {
            Console.WriteLine(NicoCipher("mubashirhassan", "crazy"));
            Console.WriteLine(NicoCipher("edabitisamazing", "matt"));
            Console.WriteLine(NicoCipher("iloveher", "612345"));

        }
    }
}