using System;
using RegexFX.String;
using Shouldly;
using Xunit;

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

        [Theory]
        [InlineData("")]
        [InlineData("         ")]
        [InlineData("abcdefghijkl")]
        [InlineData("abcdefghijkl    ")]
        [InlineData("      0123456789")]
        [InlineData("    012345   6789   ")]
        [InlineData("      0123456789  ")]
        public void Trim_ShouldBe(string input) { input.TrimRegex().ShouldBe(input.Trim()); }

        [Theory]
        [InlineData("")]
        [InlineData("         ")]
        [InlineData("abcdefghijkl")]
        [InlineData("abcdefghijkl    ")]
        [InlineData("      0123456789")]
        [InlineData("    012345   6789   ")]
        [InlineData("      0123456789  ")]
        public void TrimStart_ShouldBe(string input) { input.TrimStartRegex().ShouldBe(input.TrimStart()); }

        [Theory]
        [InlineData("")]
        [InlineData("         ")]
        [InlineData("abcdefghijkl")]
        [InlineData("abcdefghijkl    ")]
        [InlineData("      0123456789")]
        [InlineData("    012345   6789   ")]
        [InlineData("      0123456789  ")]
        public void TrimEnd_ShouldBe(string input) { input.TrimEndRegex().ShouldBe(input.TrimEnd()); }

        [Theory]
        [InlineData("", "")]
        [InlineData("", "      ")]
        [InlineData("         ", "")]
        [InlineData("abcdefghijkl", "abcd")]
        [InlineData("       abcdefghijkl", "ijkl")]
        [InlineData("abcdefghijkl    ", "bcd")]
        [InlineData("      0123456789", "0123")]
        [InlineData("    012345   6789   ", "    ")]
        [InlineData("      0123456789  ", "9 ")]
        [InlineData("  012 34 56  789  ", " 9 d ")]
        public void StartsWith_ShouldBe(string input, string search)
        {
            input.StartsWithRegex(search).ShouldBe(input.StartsWith(search));
        }

        [Theory]
        [InlineData("", "")]
        [InlineData("", "      ")]
        [InlineData("         ", "")]
        [InlineData("abcdefghijkl", "abcd")]
        [InlineData("       abcdefghijkl", "ijkl")]
        [InlineData("abcdefghijkl    ", "bcd")]
        [InlineData("      0123456789", "0123")]
        [InlineData("    012345   6789   ", "    ")]
        [InlineData("      0123456789  ", "9 ")]
        [InlineData("  012 34 56  789  ", " 9 d ")]
        public void EndsWith_ShouldBe(string input, string search)
        {
            input.EndsWithRegex(search).ShouldBe(input.EndsWith(search));
        }

        [Theory]
        [InlineData("", "")]
        [InlineData("", "      ")]
        [InlineData("         ", "")]
        [InlineData("abcdefghijkl", "abcd")]
        [InlineData("       abcdefghijkl", "ijkl")]
        [InlineData("abcdefghijkl    ", "bcd")]
        [InlineData("      0123456789", "0123")]
        [InlineData("    012345   6789   ", "    ")]
        [InlineData("      0123456789  ", "9 ")]
        [InlineData("  012 34 56  789  ", " 9 d ")]
        public void Contains_ShouldBe(string input, string search)
        {
            input.ContainsRegex(search).ShouldBe(input.Contains(search));
        }
    }
}