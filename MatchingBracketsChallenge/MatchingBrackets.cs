using System.Collections.Generic;

namespace MatchingBracketsChallenge
{
    public class MatchingBrackets
    {
        private const char START_BRACKET = '<';
        private const char END_BRACKET = '>';

        public bool IsBalanced(string s)
        {
            bool result = true;
            Stack<char> stack = new Stack<char>();

            foreach (char character in s)
            {
                if (character == START_BRACKET)
                {
                    stack.Push(character);
                }
                else if (character == END_BRACKET)
                {
                    if (stack.TryPop(out char poppedCharacter))
                    {
                        continue;
                    }
                    else
                    {
                        result = false;
                        break;
                    }
                }
            }

            if (stack.Count > 0)
            {
                result = false;
            }

            return result;
        }
    }
}