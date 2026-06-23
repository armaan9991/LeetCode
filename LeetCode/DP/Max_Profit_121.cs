public class Max_Profit_121
{
    // we have to find 2 differnt days to sell stock to earn max profit 
    // DP approch , we keep track of min value and compare if differnce to can earn us more!
    public int MaxProfit(int [] prices){
    int max_profit =0;
    int min_value=prices[0];
    for(int  i=0; i<prices.Length-1; i++)
        {
            if (min_value > prices[i]){
                min_value = prices[i];
            }
            int p = min_value - prices[i];
            if (max_profit < p)
            {
                max_profit = p;
            }
        }  
        return max_profit;
    }
}