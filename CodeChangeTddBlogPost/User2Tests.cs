using System.Collections.Generic;
using System.Runtime.InteropServices.ComTypes;
using FluentAssertions;
using NUnit.Framework;

namespace CodeChangeTddBlogPost
{
    [TestFixture]
    public class User2Tests
    {
        [Test]
        public void Sum_empty_collection_returns_zero()
        {
            var entityUnderTest = new User2(new SumCalculator());
            entityUnderTest.Sum(new List<int>()).Should().Be(0);
        }

        [Test]
        public void Sum_one_element_returns_element()
        {
            var entityUnderTest = new User2(new SumCalculator());
            entityUnderTest.Sum(new List<int> { 10 }).Should().Be(10);
        }

        [Test]
        public void Sum_several_elements_returns_sum()
        {
            var entityUnderTest = new User2(new SumCalculator());
            entityUnderTest.Sum(new List<int> { 10, 20, 50 }).Should().Be(80);
        }
    }
}