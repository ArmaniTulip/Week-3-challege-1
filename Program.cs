using System.Collections.ObjectModel;
using System.Security.Cryptography.X509Certificates;

namespace Week_3_challege_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a word to check if it is a palindrome");

            string isPalindrome = Console.ReadLine();
            if (TestPalindrome(isPalindrome))
            {
                Console.WriteLine($"{isPalindrome} is a palindrome.");

            }
            else 
            {
                Console.WriteLine($"{isPalindrome} is not a palindrome.");
            }
            
            static bool TestPalindrome(string palindrome) 
                { 
                    bool IsPalindrome = false;
                    for (int i = 0; i < palindrome.Length/2; i++)
                    {
                        if (!(palindrome[i] == palindrome[palindrome.Length - 1 - i])) 
                        {
                            return false;
                        }

                    }
                    return true;
                }
            {
                
                

            }
        }

        

    }
}
