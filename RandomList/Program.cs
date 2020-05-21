using System;

namespace RandomList
{
    class Program
    {
        static void Main(string[] args)
        {
            RandomClass list = new RandomClass();
            list.Add("ali");
            list.Add("hassan");
            list.Add("nima");
            list.Add("mohamad");
            list.Add("arman");

            Console.WriteLine(list.RandomString());

        }
    }
}
