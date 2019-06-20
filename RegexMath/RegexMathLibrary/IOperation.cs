﻿namespace RegexMath
{
    public interface IOperation
    {
        string Evaluate(string input);

        bool TryEvaluate(string input, out string result);
    }
}