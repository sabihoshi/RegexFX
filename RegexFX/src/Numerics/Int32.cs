using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace RegexFX.Numerics
{
    public class Int32 : Parsing<int>
    {
        protected override string Overflow { get; }

    }
}
