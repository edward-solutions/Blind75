public static class BestTimeToBuyAndSellStock
{
    public static int Solution(int[] prices)
    {
        int lowestStock = prices[0];
        int maxProfit = 0;
        for (int i = 0; i < prices.Length; i++)
        {
            if (lowestStock >= prices[i])
            {
                lowestStock = prices[i];
            }
            if (maxProfit < prices[i] - lowestStock)
                maxProfit = prices[i] - lowestStock;
        }
        return maxProfit;
    }
}