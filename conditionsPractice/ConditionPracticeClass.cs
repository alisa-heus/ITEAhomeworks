using System;
using System.Data.SqlTypes;
using System.Linq;
namespace conditionsPractice
{
    public class ConditionPracticeClass
    {
        /*TODO: The method must receive one parameter of the int type as input - a number to check.
        The method must return a boolean value, depending on whether the input parameter is even or odd*/
        public static bool IsEven(int number)
        {
            if(number%2 == 0)
            {
                return true;
            }
            return false;
            
        }

        /* TODO: Receives a string as input and returns true if the string contains only unique characters, false otherwise. */
        public static bool HasUniqueCharacters(string input)
        {
            if(input.Distinct().Count() == input.Count())
            {
                return true;
            }
            return false;
            

        }

        /* TODO: Receives an integer as input and returns true if the number is divisible by both 5 and 7, excluding zero, false otherwise. */
        public static bool IsDivisibleBy5And7(int number)
        {
            if(number%35 == 0 && number != 0)
            {
                return true;
            }
            return false;
        }

        /* TODO: Performs the specified arithmetic operation (char input paramether) on two double input paramethers and returns the result. */
        public static double PerformOperation(char operation, double number1, double number2)
        {
            double result = 0;
            switch(operation) 
            {
                case '+': result = number1 + number2;
                        break;
                case '-': result = number1 - number2;
                    break;
                case '*': result = number1 * number2;
                    break;
                case '/': result = number1 / number2;
                    break;
                default: Console.WriteLine("Not implemented operation");
                    break;
                    

            }
            return result;
        }

        /* TODO: Receives an integer as input and returns "Positive" if the number is positive, "Negative" if the number is negative, "Zero" if the number is zero. */
        public static string CheckNumber(int number)
        {
            if(number > 0)
            {
                return "Positive";
            }
            else if (number < 0)
            {
                return "Negative";
            }
            else
            {
                return "Zero";
            }
            
        }

        /* TODO: Receives a string as input and returns true if the string is a palindrome, false otherwise. */
        public static bool IsPalindrome(string input)
        {
            string input1 = input;
            string input2 = String.Join("", input.Reverse());
            //string input2 = new string (input.Reverse().ToArray());

            if(input1 == input2)
            {
                return true;
            }
            return false;    
        }

        /* TODO: Receives a int year as input paramether and returns true if the year is a leap year, false otherwise. */
        public static bool IsLeapYear(int year)
        {
            if((year % 100 == 0) && !(year % 400 == 0))
            {
                return false;
            }
            else if(year % 400 == 0 || year % 4 == 0)
            {
                return true;
            }
            return false;
                
        }


        /* TODO: Receives a character as input and returns true if the character is a vowel, false otherwise. */
        public static bool IsVowel(char character)
        {
            string vowels = "aeuioAEUIO";
            if(vowels.Contains(character)) { return true; }
            return false;
        }

        /* TODO: Converts a binary number represented as a string to its integer equivalent. */
        public static int BinaryToDecimal(string binaryNumber)
        {
            
            return Convert.ToInt32(binaryNumber, 2);

        }

        /* TODO: Converts a binary number represented as a string to its hexadecimal string equivalent. */
        public static string BinaryToHexadecimal(string binaryNumber)
        {
            return Convert.ToInt32(binaryNumber, 2).ToString("X");
        }
    }
}
