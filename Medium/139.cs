public class Solution {
    public bool WordBreak(string s, IList<string> wordDict) {
        HashSet<string> words = new(wordDict);
        int sSize = s.Length;

        bool[] dp = new bool[sSize + 1];
        dp[0] = true;

        for(int i = 1; i <= sSize; i++){
            for(int j = 0; j < i; j++)
            {
                if(dp[j] && words.Contains(s.Substring(j, i - j))){
                    dp[i] = true;
                    break;
                }               
            }
        }

        return dp[sSize];
    }
}