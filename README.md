# RegexFX [![CodeFactor](https://www.codefactor.io/repository/github/hizamakura/regexfx/badge)](https://www.codefactor.io/repository/github/hizamakura/regexfx)

A Regex library that uses Regex, made for Regex, in Regex. Ignore CodeFactor in saying anything above A. This is just horrible.

## Why?
You might have seen [RegexMath](https://github.com/hizamakura/RegexMath), a math engine written in Regex. Now, this is a project that aims to replace most of the common string functionality (or anything that can be done with strings/chars/int turned to strings) into Regex.

## Examples
```cs
"Foo Bar".IndexOfRegex("a");
// 5

```cs
"Foo Bar".SubstringRegex(1, 4);
// oo B
```

```cs
"   Foo Bar    ".Trim()
// Foo Bar
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

## TODO:
- Split
- Numerics
- Padding