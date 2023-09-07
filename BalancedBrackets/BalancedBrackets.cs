using System;
namespace BalancedBrackets
{
	public class BalancedBrackets
	{
        /**
         * The function HasBalancedBrackets should return true if and only if
         * the input string has a set of "balanced" brackets.
         *
         * That is, whether it consists entirely of pairs of opening/closing
         * brackets (in that order), none of which mis-nest. We consider a bracket
         * to be square-brackets: [ or ].
         *
         * The string may contain non-bracket characters as well.
         *
         * These strings have balanced brackets:
         *  "[LaunchCode]", "Launch[Code]", "[]LaunchCode", "", "[]"
         *
         * While these do not:
         *   "[LaunchCode", "Launch]Code[", "[", "]["
         *
         * parameter str - to be validated
         * returns true if balanced, false otherwise
        */

        public static bool HasBalancedBrackets(String str)
        {
            int brackets = 0;
            foreach (char ch in str.ToCharArray())
            {
                if (brackets >= 0) //if the number of brackets is 0 or more keep iterating thru the array
                {
                    if (ch == '[') //if the first bracket we are looking for, an opening bracket, exists then we add 1 to our brackets variable.
                    {
                        brackets++;
                    }
                    else if (ch == ']') //we are still iterating, so if the next bracket we encounter is a closing bracket then we minus 1 from our brackets variable
                    {
                        brackets--;
                    }
                }//we iterate thru as long as our brackets variable is == or more to 0, if it is -1 or less then we know that the brackets are unbalanced because for the number to be negative would imply there wasnt an opening bracket to add to our variable before a closing bracket minus from our variable
                
            }
            return brackets == 0; //we return true only if brackets is EQUAL to 0 after the iteration. 
        }
    }
}

