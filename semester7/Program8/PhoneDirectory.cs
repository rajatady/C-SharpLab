using System.Collections;
using System.Collections.Generic;

namespace semester7.Program8
{
    public class PhoneDirectory
    {
        private Hashtable directory = new Hashtable();
        private Dictionary<long, string> dictionary = new Dictionary<long, string>();

        public void AddEntry(KeyValuePair<int, string> valuePair)
        {
            directory.Add(valuePair.Value, valuePair.Key);
            dictionary.Add(valuePair.Key, valuePair.Value);
        }

        public void SetDictionary(Dictionary<long, string> dictionary)
        {
            this.dictionary = dictionary;
            foreach (var entry in dictionary)
            {
                directory.Add(entry.Value, entry.Key);
            }
        }

        public string Search(long number)
        {
            string name;
            return dictionary.TryGetValue(number, out name) ? name : null;
        }

        public long Search(string name)
        {

            foreach (DictionaryEntry entry in directory)
            {
                if ((string) entry.Key == name)
                {
                    return (long) entry.Value;
                }
            }
            return 0;
        }
    }
}