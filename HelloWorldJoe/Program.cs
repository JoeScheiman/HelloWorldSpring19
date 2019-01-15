using System;

namespace HelloWorldJoe
{
    class Program
    {
        static void Main(string[] args)
        {
            string message = "Hello, World!";
            Console.WriteLine(message);

            bool yo = true;
            //yo = (bool)0;
            Console.WriteLine(yo);

            double doubleValue = 2.16440330489723961032;
            Console.WriteLine(doubleValue);

            float floatValue = 2.16440330489723961032f;
            Console.WriteLine(floatValue);



            int age = 33;
            if (age >= 16)
            {
                Console.WriteLine($"You are {age}, so you are legal to drive.");
            }


            int heightInInches = 42;

            if (heightInInches >= 60)
            {
                Console.WriteLine("You are tall enough to ride.");
            }
            else if (heightInInches >= 30)
            {
                Console.WriteLine("Try the teacups. They look fun.");
            }
            else
            {
                Console.WriteLine("I'm sorry, too short.");
            }

            /******************************
            Switch/case
            ***************/

            string ageGroup = "youngster";

            switch (ageGroup)
            {
                case "adult":
                    Console.WriteLine("You can ride the rollercoaster!");
                    break;
                case "youngster":
                    Console.WriteLine("The teacups are fun.");
                    break;
                default:
                    Console.WriteLine("Oh, you must be a toddler. Toddle on!");
                    break;
            }

            /*****
             * String compare
             * */

            String shoeDescription = "Their shoes were clean and neat";

            if (shoeDescription.Equals("Their shoes were clean and neat"))
            {
                Console.WriteLine("This is odd, because, you know,");
                Console.WriteLine("They hadn't any feet.");
            }

            String myGreeting = "Hello";

            Console.WriteLine(myGreeting.ToUpper()); // print "HELLO"
            Console.WriteLine(myGreeting.ToLower()); // prints "hello"
            Console.WriteLine(myGreeting); // prints "Hello"

            string palindrome = "A dog, a panic, in a pagoda";
            int palindromeLength = palindrome.Length;
            Console.WriteLine($"{palindrome} has {palindromeLength} characters.");
            /*
            Trim trims the whitespace from the start &end of a String; useful to clean user input   " bar ".Trim()  "bar"
            ToCharArray returns an array of chars that make up the string.  "bar".ToCharArray()['b', 'a', 'r']
            IndexOf returns the index of the first occurence of a substring in this String  "fooBar".IndexOf("Bar") 3
            Contains	indicates whether this String contains a substring	"fooBar".Contains("Ba")	true
            StartsWith	indicates whether this String starts with another	"foo".StartsWith("f")	true
            EndsWith	indicates whether this String ends with another	"baz".EndsWith("az")	true
            Substring	returns a new string starting at the specified index, optionally with a length	"hello".Substring(1)
            "hello".Substring(1, 3)	"ello"
            "ell"
            */

            

            Console.ReadLine();







        }
    }
}
