﻿using System;
using System.Collections.Generic;
using System.Text;
using Shouldly;
using Xunit;

namespace RegexMath.Tests
{
    public class RegexMathTests
    {
        [Theory]
        [InlineData("Math.PI", Math.PI)]
        [InlineData("Math.E", Math.E)]
        public void Constants_ShouldCalculate(string input, double expected)
        {
            RoughEqual(expected, out var low, out var high);
            RegexMath.Evaluate(input).ShouldBeInRange(low, high);
        }

        [Theory]
        [InlineData("5+5", 10)]
        [InlineData("5+5+(30)+30+(30)", 100)]
        [InlineData("9+3+(491)+597+28+(727+7)", 1862)]
        public void Add_ShouldCalculate(string input, double expected)
        {
            RoughEqual(expected, out var low, out var high);
            RegexMath.Evaluate(input).ShouldBeInRange(low, high);
        }

        [Theory]
        [InlineData("5-5", 0)]
        [InlineData("5-5-(30)-30-(30)", -90)]
        [InlineData("9-3-(491)-597-28-(727-7)", -1830)]
        public void Subtract_ShouldCalculate(string input, double expected)
        {
            RoughEqual(expected, out var low, out var high);
            RegexMath.Evaluate(input).ShouldBeInRange(low, high);
        }

        [Theory]
        [InlineData("2^8", 256)]
        [InlineData("Math.Pow(2|8)", 256)]
        [InlineData("2^3^2", 512)]
        public void Exponent_ShouldCalculate(string input, double expected)
        {
            RoughEqual(expected, out var low, out var high);
            RegexMath.Evaluate(input).ShouldBeInRange(low, high);
        }

        [Theory]
        [InlineData("sqrt(4)", 2)]
        [InlineData("Math.Root(4|2)", 2)]
        [InlineData("Math.Sqrt(4)", 2)]
        [InlineData("Math.Sqrt(255)", 15.96871942267131199907024517698061384156734970437542667323)]
        public void Sqrt_ShouldCalculate(string input, double expected)
        {
            RoughEqual(expected, out var low, out var high);
            RegexMath.Evaluate(input).ShouldBeInRange(low, high);
        }

        [Fact]
        public void Factorial_ShouldCalculate()
        {
            var input = "5!";
            RegexMath.Evaluate(input).ShouldBe(120);
        }

        [Fact]
        public void Complicated_ShouldCalculate()
        {
            var input = "10*5(sqrt(4))";
            RegexMath.Evaluate(input).ShouldBe(100);
        }
        private void RoughEqual(double expected, out double low, out double high,
                                double tolerance = 0.00000000000001)
        {
            low = expected - tolerance;
            high = expected + tolerance;
        }

    }
}
