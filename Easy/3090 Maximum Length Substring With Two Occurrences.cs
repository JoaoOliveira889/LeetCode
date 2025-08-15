public class Solution
{
    public int MaximumLengthSubstring(string s)
    {

        Dictionary<char, int> occurrences = new();
        int maxLength = 0;
        int left = 0;

        for (int right = 0; right < s.Length; right++)
        {
            char currentChar = s[right];

            if (occurrences.ContainsKey(currentChar))
                occurrences[currentChar]++;
            else
                occurrences[currentChar] = 1;

            while (occurrences[currentChar] > 2)
            {
                char leftChar = s[left];
                occurrences[leftChar]--;
                left++;
            }
            maxLength = Math.Max(maxLength, right - left + 1);
        }
        return maxLength;
    }
}

public class Solution
{
    public int MaximumLengthSubstring(string s)
    {
        int[] occurrences = new int[26];
        int maxLength = 0;
        int left = 0;

        for (int right = 0; ç < s.Length; right++)
        {
            char currentChar = s[right];
            occurrences[currentChar - 'a']++;

            while (occurrences[currentChar - 'a'] > 2)
            {
                char leftChar = s[left];
                occurrences[leftChar - 'a']--;
                left++;
            }
            maxLength = Math.Max(maxLength, right - left + 1);
        }

        return maxLength;
    }
}