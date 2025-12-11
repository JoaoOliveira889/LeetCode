public class Solution {
    private List<string> results;
    private int pairs;

    public IList<string> GenerateParenthesis(int n) {
        results = new List<string>();
        pairs = n;
        Backtrack(new StringBuilder(), 0, 0);
        
        return results;
    }

    private void Backtrack(StringBuilder currentString, int openCount, int closeCount) {
        if (currentString.Length == 2 * pairs) {
            results.Add(currentString.ToString());
            return;
        }

        if (openCount < pairs) {
            currentString.Append('(');
            Backtrack(currentString, openCount + 1, closeCount);
            currentString.Length--; 
        }
        if (closeCount < openCount) {
            currentString.Append(')');
            Backtrack(currentString, openCount, closeCount + 1);
            currentString.Length--; 
        }
    }
}