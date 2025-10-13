public class Solution {
    public int[] SuccessfulPairs(int[] spells, int[] potions, long success) {
        int n = spells.Length;
        int m = potions.Length;
        int[] result = new int[n];

        Array.Sort(potions);

        for(int i = 0; i < n; i++){
            long spell = spells[i];

            long minPotionNeeded = (success + spell -1)/spell;

            int start = 0;
            int end = m -1;
            int firstSuccessfulIndex = m;

            while(start <= end){
                int mid = start + (end - start) /2;

                if(potions[mid] >= minPotionNeeded)
                {
                    firstSuccessfulIndex = mid;
                    end = mid -1;
                }
                else 
                    start = mid +1;
            }

            int pairs = m - firstSuccessfulIndex;
            
            result[i] = pairs;
        }

        return result;
    }
}