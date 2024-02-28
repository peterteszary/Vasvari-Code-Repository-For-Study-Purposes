using System;

namespace PalindromeChecker
{
    class Program
    {
        static void Main(string[] args)
        {

            //A palindrom olyan szó vagy kifejezés, amelyet ugyanúgy írnak előre és hátra

            string[] phrases = new string[] { "Indul a görög aludni.", "Géza, kék az ég!", "Indul a pap aludni." };

            foreach (string phrase in phrases)
            {
         
                string input = phrase.Replace(" ", "").ToLower();

                //megnézi, hogy ez egy palindrom.   
                for (int i = 0; i < input.Length / 2; i++)
                {
                    if (input[i] != input[input.Length - i - 1])
                    {
                        isPalindrome = false;
                        break;
                    }
                }

                if (isPalindrome)
                {
                    Console.WriteLine(phrase + " Ez egy palindrom.");
                }
                else
                {
                    Console.WriteLine(phrase + "Ez nem palindrom.");
                }
            }
        }
    }
}