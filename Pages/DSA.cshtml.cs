using Microsoft.AspNetCore.Mvc.RazorPages;
using DSAShowcase.Logic;

namespace DSAShowcase.Pages
{
    public class DSAModel : PageModel
    {
        public string TwoSumResult { get; private set; }
        public int MaxProfitResult { get; private set; }

        public void OnGet()
        {
            var solver = new DSAProblems();

            // Sample input for TwoSum
            var result = solver.TwoSum(new[] { 2, 7, 11, 15 }, 9);
            TwoSumResult = $"[{result[0]}, {result[1]}]";

            // Sample input for MaxProfit
            MaxProfitResult = solver.MaxProfit(new[] { 7, 1, 5, 3, 6, 4 });
        }
    }
}