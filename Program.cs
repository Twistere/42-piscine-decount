using System;
using Tweetinvi;
using System.IO;
using Tweetinvi.Parameters;
using System.Threading;


namespace _42_piscine_decount
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int jours = Int32.Parse(args[0]);

            while (jours > 0)
            {
                Console.WriteLine($"Il reste : {jours}");
                jours -= 1;
                Thread.Sleep(100);
            }
            
        }
    }
}
