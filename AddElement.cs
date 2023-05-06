using System;
using System.Collections;

namespace HashTableExample
{
    class AddElement
    {
        static void Main(string[] args)
        {
            Hashtable hashtable = new Hashtable();

            hashtable.Add("key1", "value1");
            hashtable.Add("key2", "value2");
            hashtable.Add("key3", "value3");

            foreach (DictionaryEntry entry in hashtable)
            {
                Console.WriteLine($"{entry.Key}: {entry.Value}");
            }
        }
    }
}