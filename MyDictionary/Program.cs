using System;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {

            MyDictionary<int, string> musteriler = new MyDictionary<int, string>();
            musteriler.Add(1, "Alihan");
            musteriler.Add(2, "Ferhan");
            musteriler.Add(3, "İbrahim");

        }
    }
}
