public class Solution {
    public int MaxCoins(int[] piles) {
        Array.Sort(piles);
        
        int maxCoins = 0;
        for(int i = piles.Length/3; i < piles.Length; i +=2)
        {
            maxCoins += piles[i];
        }
        
        return maxCoins;
        
    }
}
