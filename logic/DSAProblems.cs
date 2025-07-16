namespace DSAShowcase.Logic
{
    public class DSAProblems
    {
        public int[] TwoSum(int[] nums, int target)
        {
            var map = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                int complement = target - nums[i];
                if (map.ContainsKey(complement))
                    return new int[] { map[complement], i };
                map[nums[i]] = i;
            }
            return new int[0];
        }

        public int MaxProfit(int[] prices)
        {
            int minPrice = int.MaxValue;
            int maxProfit = 0;

            foreach (int price in prices)
            {
                if (price < minPrice)
                    minPrice = price;
                else if (price - minPrice > maxProfit)
                    maxProfit = price - minPrice;
            }

            return maxProfit;
        }
    }
}
