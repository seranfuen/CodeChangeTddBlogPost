using System.Collections.Generic;
using System.Linq;

namespace CodeChangeTddBlogPost
{
    public class User1
    {
        private readonly Calculator _calculator;

        public User1(Calculator calculator)
        {
            _calculator = calculator;
        }

        public int Calculate(List<int> elements)
        {
            if (elements?.Any() != true) return 0;

            var result = 1;
            foreach (var element in elements) result = _calculator.Calculate(result, element);
            return result;
        }
    }
}