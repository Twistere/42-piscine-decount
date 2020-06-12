using System;
using System.Runtime;
using Tweetinvi;

namespace _42_piscine_decount
{
    class Program
    {
        static void Main(string[] args)
        {
           var userCredentials = Auth.CreateCredentials("2QAI6K3yau3BWaL5MauQuTiHM", "CmrmPNiHYDkWakRLtH8ob7tqiMmGvKkSGYCRvs9Fze1q1Ge1A0","2601286844-8ibhHLzKrbiFwOqC8tv9ecRmFbnV2NMmjElTNRM", "kyntRBYjBYLsqr92CyWbtDSArsCKdP8m3aWB3yiGdcgU4");

           var authenticatedUser = User.GetAuthenticatedUser();

           Console.WriteLine(authenticatedUser);
           Console.ReadKey();

           var tweet = Tweet.PublishTweet("C#");

           

        


        }
    }
}
