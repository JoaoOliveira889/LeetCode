public class Solution {
    public int RomanToInt(string s) {
        Dictionary<char, int> romanMap = new()
        {
            { 'I', 1 },
            { 'V', 5 },
            { 'X', 10 },
            { 'L', 50 },
            { 'C', 100 },
            { 'D', 500 },
            { 'M', 1000 }
        };

        int result = 0, prevValue = 0;

        for(int i = s.Length -1; i >= 0; i--){
            int currentValue = romanMap[s[i]];

            if (currentValue < prevValue)
                result -= currentValue;
            else
                result += currentValue;

            prevValue = currentValue;
        }

        return result;
    }
}