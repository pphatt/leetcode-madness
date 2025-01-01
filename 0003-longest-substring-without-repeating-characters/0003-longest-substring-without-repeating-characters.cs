public class Solution
{
    public int LengthOfLongestSubstring(string s)
    {
        HashSet<char> charSet = new HashSet<char>();

        int left = 0;
        int right = 0;

        int maxLength = 0;

        while (right < s.Length)
        {
            if (!charSet.Contains(s[right]))
            {
                charSet.Add(s[right]);

                right++;

                maxLength = Math.Max(maxLength, charSet.Count);
            }
            else
            {
                charSet.Remove(s[left]);

                left++;
            }
        }

        return maxLength;
    }
}