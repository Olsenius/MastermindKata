using NUnit.Framework;

namespace MastermindKata.Tests
{
    [TestFixture]
    public class MastermindTests
    {
        [Test]
        public void Should_not_return_any_matches_when_there_is_no_matches()
        {
            var mastermind = new Mastermind("r r r r");

            var result = mastermind.Guess("b b b b");

            result.ShouldEqual(string.Empty);
        }

        [Test]
        public void Should_return_a_match_if_there_is_a_match_in_wrong_location()
        {
            var mastermind = new Mastermind("r y y y");

            var result = mastermind.Guess("b r b b");

            result.ShouldEqual("m");
        }
    }
}