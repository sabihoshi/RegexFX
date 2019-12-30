using System;
using System.Text.RegularExpressions;

namespace RegexFX.String
{
    public static partial class StringExtensions
    {
        [Flags]
        public enum StringComparison
        {
            None = 0,
            IgnoreCase = 1<<0
        }

        public static int IndexOfRegex(this string s, string search, int? startIndex = null, int? count = null,
            StringComparison comparison = StringComparison.None)
        {
            string value = s.SubstringRegex(startIndex ?? 0, count ?? s.Length);
            Console.WriteLine(value);
            var regex = new Regex($@"(?<offset>.*?){search}", (RegexOptions)comparison).Match(value);
            return regex.Success ? regex.Groups["offset"].Value.Length + (startIndex ?? 0) : -1;
        }

        public static int IndexOf(this string s, char search, int? startIndex = null, int? count = null,
            StringComparison comparison = StringComparison.None) =>
            IndexOfRegex(s, search.ToString(), startIndex ?? 0, count ?? s.Length, comparison);

        public static int LastIndexOfRegex(this string s, string search, int? startIndex = null, int? count = null,
            StringComparison comparison = StringComparison.None)
        {
            string value = s.SubstringRegex(startIndex ?? 0, count ?? s.Length);
            var regex = new Regex($@"(?<offset>.*){search}", (RegexOptions)comparison).Match(value);
            return regex.Success ? regex.Groups["offset"].Value.Length + (startIndex ?? 0) : -1;
        }

        public static int LastIndexOfRegex(this string s, char search, int? startIndex = null, int? count = null,
            StringComparison comparison = StringComparison.None) =>
            LastIndexOfRegex(s, search.ToString(), startIndex ?? 0, count ?? s.Length, comparison);

        public static int IndexOfAny(this string s, char[] search, int? startIndex = null, int? count = null,
            StringComparison comparison = StringComparison.None)
        {
            string value = s.SubstringRegex(startIndex ?? 0, count ?? s.Length);
            var regex = new Regex($@"(?<offset>.*?)({string.Join("|", search)})", (RegexOptions)comparison).Match(value);
            return regex.Success ? regex.Groups["offset"].Value.Length + (startIndex ?? 0) : -1;
        }

        public static int LastIndexOfAny(this string s, char[] search, int? startIndex = null, int? count = null,
            StringComparison comparison = StringComparison.None)
        {
            string value = s.SubstringRegex(startIndex ?? 0, count ?? s.Length);
            var regex = new Regex($@"(?<offset>.*)({string.Join("|", search)})", (RegexOptions)comparison).Match(value);
            return regex.Success ? regex.Groups["offset"].Value.Length + (startIndex ?? 0) : -1;
        }
    }
}