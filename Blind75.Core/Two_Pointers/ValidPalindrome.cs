// a s s a
// 1 2 3 4

// a s s t s s a
// 1 2 3 4 5 6 7
namespace Blind75.Core.Two_Pointers
{
    public static class ValidPalindrome
    {
        public static bool Solution(string s)
        {
            char[] filteredChars = new string(s.Where(char.IsLetterOrDigit).ToArray()).ToLower().ToCharArray();
            int left = 0;
            int right = filteredChars.Length - 1;

            while (left < right)
            {
                if (filteredChars[left] != filteredChars[right]) return false;
                left++;
                right--;
            }

            return true;
        }
    }
}
