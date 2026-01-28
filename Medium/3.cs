public class Solution {
    public int LengthOfLongestSubstring(string s) {
        HashSet<char> charSet = new();
        int max = 0, left = 0;

        for(int right = 0; right < s.Length; right++){
            while(charSet.Contains(s[right])){
                    charSet.Remove(s[left]);
                    left++;
                }
            charSet.Add(s[right]);
            max = Math.Max(max, right - left +1);
        }

        return max;
    }
}