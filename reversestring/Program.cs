using System;

namespace reversestring
{
    class Program
    {
        static void Main(string[] args)
        {
            string hello = "Hello World!";


            var helloWorld = hello.ToCharArray();

            Array.Reverse(helloWorld);

            string reverseStr = new string(helloWorld);



        }
    }
}
