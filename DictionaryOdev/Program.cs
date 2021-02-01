using System;

namespace DictionaryOdev
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> sehirler = new MyDictionary<int, string>();
            sehirler.Add(34, "İstanbul");
            sehirler.Add(16, "Bursa");
            sehirler.Add(06, "Ankara");
            sehirler.Add(10, "Balıkesir");
            sehirler.Add(67, "Zonguldak");

            
        }
    }
}
