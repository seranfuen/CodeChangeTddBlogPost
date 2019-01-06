using FluentAssertions;
using NUnit.Framework;

namespace CodeChangeTddBlogPost
{
    [TestFixture]
    public class CalculatorTests
    {
        private Calculator _entityUnderTest;

        [SetUp]
        public void SetUp()
        {
            _entityUnderTest = new Calculator();
        }

        [Test]
        public void Calculate_two_positive_integers()
        {
            _entityUnderTest.Calculate(5, 3).Should().Be(15);
        }

        [Test]
        public void Calculate_has_commutative_property()
        {
            _entityUnderTest.Calculate(3, 5).Should().Be(15);
        }
    }
}