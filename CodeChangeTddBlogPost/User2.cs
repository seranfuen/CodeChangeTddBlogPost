using System.Collections.Generic;
using System.Linq;

namespace CodeChangeTddBlogPost
{
    public class User2
    {
        private readonly ICalculator _calculator;

        public User2(ICalculator calculator)
        {
            _calculator = calculator;
        }

        public int Sum(List<int> elements)
        {
            if (elements?.Any() != true) return 0;

            var result = 0;
            foreach (var element in elements) result = _calculator.Calculate(result, element);
            return result;
        }
    }
}