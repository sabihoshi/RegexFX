<<<<<<< HEAD

# RegexFX [![CodeFactor](https://www.codefactor.io/repository/github/hizamakura/regexfx/badge)](https://www.codefactor.io/repository/github/hizamakura/regexfx)

# RegexMath [![Build Status](https://dev.azure.com/kaworinakano/RegexMath/_apis/build/status/hizamakura.RegexMath?branchName=master)](https://dev.azure.com/kaworinakano/RegexMath/_build/latest?definitionId=1&branchName=master) [![CodeFactor](https://www.codefactor.io/repository/github/hizamakura/regexmath/badge/master)](https://www.codefactor.io/repository/github/hizamakura/regexmath/overview/master)

A Regex library that uses Regex, made for Regex, in Regex. Ignore CodeFactor in saying anything above A. This is just horrible.

## Why?

You might have seen [RegexMath](https://github.com/hizamakura/RegexMath), a math engine written in Regex. Now, this is a project that aims to replace most of the common string functionality (or anything that can be done with strings/chars/int turned to strings) into Regex. (In the process of merging)

## Examples

````cs
"Foo Bar".IndexOfRegex("a");
// 5

```cs
"Foo Bar".SubstringRegex(1, 4);
// oo B
````

```cs
"   Foo Bar    ".Trim()
// Foo Bar
```

```cs
RegexMath.Evaluate("5+(-5(0.431e4*(5)(4)))*3.430e2(.509194e-5)-40.05245");
// -787.80921602

Regexmath.Evaluate("sqrt(5)+5^2PI+H_3/log(e, 3)");
// 82.444656232727
```

```cs
var input = "broken";
RegexMath.TryEvaluate(input, our var result);
// False
```

## Reliability

It tries to copy some of the exceptions and behavior present in the native implementation. I try to, but it will take awhile to make it quite exact. After all, I don't understand code so optimized (after all, I am using Regex for a library, how optimized do I need to be?)

## Features

### String manipulation:

    - Substring
    - Trim
    - TrimStart/TrimEnd

### Search:

    - IndexOf
    - LastIndexOf
    - IndexOfAny
    - LastIndexOfAny
    - StartsWith/EndsWith
    - Contains

### Standard Arithmetic:

    `^`, `**`, `*`, `/`, `%`, `+`, and `-`

### Constants:

    `PI` and `E`

### Standard Math functions:

    - `sqrt(x)`
    - `cbrt(x)`
    - `root(x, y)`
    - `log_x(y)` or `log(x, y)`
    - `min(x, y)` or `max(x, y)`

    and a lot more...

### Programming constructs:

    - Modulo
    - Remainder
    - Bitshift

### Complex calcuations:

    - Factorial on non-natural numbers
    - Euler Beta functions
    - Error functions
    - Sigmoid: Logistic functions
    - Gamma functions
    - Harmonic numbers
    - Trigonometry

## TODO:

### String Manipulations

    - Split
    - Numerics
    - Padding

### Math

    - Summation in the form of `Σ/sum/sigma[i=1, 6][3i + 4]`
    - Product in the form of `Π/prod/product[i=1, 3][3i + 4]`
    - Variable substitution
    - Differential equations
    - Numerical stability
    - Conversion between radian, degree, and grad

Some of the functions can be found in [Math.Net](https://numerics.mathdotnet.com/Functions.html) or [Typing Math as text](https://www.purplemath.com/modules/mathtext3.htm)
