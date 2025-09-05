public static class SolutLongestPalindromeion
{
    public static int Solution(string s)
    {
        Dictionary<char, int> collect = new Dictionary<char, int>();
        int odd = 0;
        int even = 0;

        foreach (char a in s)
        {
            if (collect.ContainsKey(a))
            {
                collect[a]++;
            }
            else
            {
                collect.Add(a, 1);
            }
        }

        foreach (var record in collect)
        {
            even += record.Value / 2;
            if (odd == 0) odd = record.Value % 2;
        }

        return odd + even * 2;

    }
}