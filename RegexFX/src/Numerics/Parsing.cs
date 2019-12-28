using System.Text.RegularExpressions;

namespace RegexFX.Numerics
{
    public class Parsing
    {
        public Regex NumberRegex { get; } = new Regex(
            $@"^(?<{Token.Int}>[+-]?[0-9,]+)((?({Token.Int})(?<-{Token.Int}>(?<{Token.Decimal}>[.][0-9]*)?)|[.][0-9]+))(e(?<{Token.Exponent}>[+-]?[0-9]+))?",
            RegexOptions.Compiled | RegexOptions.ExplicitCapture);

        private static Regex CreateRegex(int number) => new Regex($"^{number}$", RegexOptions.Compiled);

        public bool RegexTryParseInt32(string input, out int output)
        {
            output = default;
            if (NumberRegex.IsMatch(input))
            {
                output = int.Parse(input);
                return true;
            }
            return false;
        }

        protected enum Token
        {
            Int,
            Decimal,
            Exponent
        }
    }
}