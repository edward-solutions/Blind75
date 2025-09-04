//https://leetcode.com/problems/valid-parentheses/
//()[]{}
namespace Blind75.Core.Stack
{
    public static class ValidParentheses
    {
        public static bool Solution(string s)
        {
            Dictionary<char, char> charMap = new Dictionary<char, char>
            {
                { '(', ')' },
                { '{', '}' },
                { '[', ']' },
            };

            Stack<char> stack = new Stack<char>();
            
            for(int i = 0; i < s.Length; i++)
            {
                if (charMap.ContainsKey(s[i])) //if its an open, add
                {
                    stack.Push(s[i]);
                }
                else if (stack.Count > 0 && s[i] == charMap[stack.Peek()]) //if its a close, check if the current char is the charmap.value of the peek
                {
                    stack.Pop();
                }
                else
                    return false;
            }
            

            return stack.Count == 0;
        }

        
    }
}

