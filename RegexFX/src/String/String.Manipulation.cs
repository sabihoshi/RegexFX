using System;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using System.Text.RegularExpressions;

namespace RegexFX.String
{
    public static partial class StringExtensions
    {
        public static string SubstringRegex(this string s, int startIndex, int length = 1)
        {
            if (startIndex < 0)
                throw new ArgumentOutOfRangeException(nameof(startIndex), "StartIndex cannot be less than zero.");

            if (startIndex > s.Length)
                throw new ArgumentOutOfRangeException(nameof(startIndex),
                    "StartIndex cannot be larger than length of string.");

            if (length < 0)
                throw new ArgumentOutOfRangeException(nameof(length), "Length cannot be less than zero.");

            if (startIndex > s.Length - length)
                throw new ArgumentOutOfRangeException(nameof(length),
                    "Index and length must refer to a location within the string.");

            if (length == 0)
                return string.Empty;

            if (startIndex == 0 && length == s.Length)
                return s;

            var regex = new Regex($@"(?<=.{{{startIndex}}}).{{{length}}}");
            return regex.Match(s).Value;
        }

        public static string TrimRegex(this string s)
        {
            return s.TrimStartRegex().TrimEndRegex();
        }

        public static string TrimStartRegex(this string s)
        {
            return Regex.Replace(s, @"^\s*", string.Empty, RegexOptions.Compiled);
        }

        public static string TrimEndRegex(this string s)
        {
            return Regex.Replace(s, @"\s*$", string.Empty, RegexOptions.Compiled);
        }
    }
}