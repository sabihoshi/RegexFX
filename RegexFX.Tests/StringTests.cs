using System;
using RegexFX.String;
using Shouldly;
using Xunit;
using Xunit.Sdk;

namespace RegexFX.Tests
{
    public class StringTests
    {
        [Theory]
        [InlineData("abcdefghijkl", "e")]
        [InlineData("abcdefghijkl", "ijl")]
        [InlineData("0123456789", "89")]
        [InlineData("0123456789", "11")]
        [InlineData("0123456789", "12")]
        public void IndexOf_ShouldBe(string input, string search)
        {
            input.IndexOfRegex(search).ShouldBe(input.IndexOf(search, StringComparison.InvariantCulture));
        }

        [Theory]
        [InlineData("abcdefghijkl", 0, 5)]
        [InlineData("abcdefghijkl", 0, 3)]
        [InlineData("0123456789", 2, 3)]
        [InlineData("0123456789", 0, 2)]
        [InlineData("0123456789", 0, 0)]
        public void Substring_ShouldBe(string input, int start, int length)
        {
            input.SubstringRegex(start, length).ShouldBe(input.Substring(start, length));
        }
    }
}
