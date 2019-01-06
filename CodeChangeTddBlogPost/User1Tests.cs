using System.Collections.Generic;
using FluentAssertions;
using NUnit.Framework;

namespace CodeChangeTddBlogPost
{
    [TestFixture]
    public class User1Tests
    {
        [Test]
        public void Calculate_empty_collection_returns_zero()
        {
            var entityUnderTest = new User1(new Calculator());
            entityUnderTest.Calculate(new List<int>()).Should().Be(0);
        }

        [Test]
        public void Calculate_one_element_returns_element()
        {
            var entityUnderTest = new User1(new Calculator());
            entityUnderTest.Calculate(new List<int> { 10 }).Should().Be(10);
        }

        [Test]
        public void Calculate_several_elements_returns_result_of_applying_calculate_to_each_element()
        {
            // Notice the new requirement
            var entityUnderTest = new User1(new Calculator());
            entityUnderTest.Calculate(new List<int> { 10, 20, 50 }).Should().Be(10000);
        }
    }

}