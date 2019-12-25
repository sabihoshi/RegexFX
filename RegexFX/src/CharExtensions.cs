using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace RegexFX.src
{
    public static class CharExtensions
    {
        private static readonly Regex DigitRegex = new Regex(@"^\d$", RegexOptions.Compiled);
        private static readonly Regex ControlRegex = new Regex(@"^\p{C}", RegexOptions.Compiled);
        public static bool IsDigit(this char c) => DigitRegex.IsMatch(c.ToString());
        public static bool IsControl(this char c) => ControlRegex.IsMatch(c.ToString());
    }
}
