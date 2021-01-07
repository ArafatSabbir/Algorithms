// Runtime: 248 ms, faster than 19.49% of C# online submissions for Final Prices With a Special Discount in a Shop.
// Memory Usage: 32.1 MB, less than 83.05% of C# online submissions for Final Prices With a Special Discount in a Shop.

public class Solution {
    public int[] FinalPrices(int[] prices)
    {
        for(int i = 0; i< prices.Length; i++)
            for(int j = i + 1; j < prices.Length; j++)
                if(prices[j] <= prices[i])
                {
                    prices[i] -= prices[j];
                    break;
                }
        
    return prices;
    }
}
