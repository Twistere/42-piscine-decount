using System;
using System.Runtime;
using Tweetinvi;

namespace _42_piscine_decount
{
    class Program
    {
        static void Main(string[] args)
        {
           var userCredentials = Auth.CreateCredentials("", "","", "");

           var authenticatedUser = User.GetAuthenticatedUser();

           var tweet = Tweet.PublishTweet("C#");

           
        }
    }
}
