using System;

namespace LAB_Project1
{
    class Program
    {
        static void Main(string[] args)
        {
      
            Console.WriteLine("  WAP to accept 2 strings and do the foll");

            Compare();

            rev();

            palindrome();

            Upper_LowerCase();

            RemoveSpaces();
    
            rand();
           
            Console.ReadKey();
        }




        static void Compare()
        {
            string str1 = "Good Evening";
            string str2 = "Good Evening";

            if (str1 == str2)
            {
                Console.WriteLine($"  {str1} and {str2} have same value.");
            }
            else
            {
                Console.WriteLine($"  {str1} and {str2} are different.");
            }
        }

        static void rev()
        {
            string inputText = "Good Evening";
            char[] myChar = inputText.ToCharArray();
            Array.Reverse(myChar);
            Console.Write("  reverse of word " + inputText + " is ");
            foreach (char character in myChar)
            {
                Console.Write(character);
            }
            Console.WriteLine();
        }

        static void palindrome()
        {
            string a = "mom";
            char[] arr = a.ToCharArray();
            Array.Reverse(arr);

            string b = new string(arr);
            if (a.ToLower().Equals(b.ToLower()))
            {
                Console.WriteLine("  The Word "+ a + " It`s Palindrome");
            }
            else
            {
                Console.WriteLine("  The Word " + a + " it's not Palindrome");
            }
        }

        static void Upper_LowerCase()
        {
            string inputText = "Good Evening";
            Console.WriteLine("  Upper Case " + inputText.ToUpper());
            Console.WriteLine("  ____");
            Console.WriteLine("  Lower Case " + inputText.ToLower());
        }

        static void RemoveSpaces()
        {
            string inputText = "  Good Evening ";
            inputText = inputText.Replace(" ", String.Empty);

            Console.WriteLine("  Remove Spaces from : " + inputText);
        }

        static int rand()
        {

            int _min = 100000;
            int _max = 999999;
            Random _rdm = new Random();
            Console.WriteLine(_rdm.Next(_min, _max));
            return _rdm.Next(_min, _max);
        }



    }
}


