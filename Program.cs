using System;

namespace AI15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, What is your name?");
            var name = Console.ReadLine();
            Console.WriteLine("Hello" + " " + name +"!  How are you doing today????");
            var doing = Console.ReadLine();
            Console.WriteLine("Glad to hear you are doing" + " " + doing + ". By the way, what is your favorite color?");
            var color = Console.ReadLine();
            Console.WriteLine("Wow!" + " " + color + " is a really good choice...my fav is actually purple...");
            Console.WriteLine("What is your spirit animal?");
            var spirit = Console.ReadLine();
            Console.WriteLine("Cool, I like" + " " + spirit +"!  What is your fav hobby?");
            var hobby = Console.ReadLine();
            Console.WriteLine("OMG...I am all about some" + " " + hobby + ". By the way, are you a Mac or Windows kind of person?");
            var winmac = Console.ReadLine();
            Console.WriteLine("Wow!" + " " + winmac + " is the worst choice...LOL! TTYL sucker!");
        }
    }
}
