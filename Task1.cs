namespace DotNetCourse.Tasks;

/// <summary>
/// Task 1: Acronyms, concepts, integral types (ranges), and standard values for simple types.
/// </summary>
public static class Task1
{
    public static void Run()
    {
        PrintAcronymsAndConcepts();
        Console.WriteLine();
        PrintIntegralTypes();
        Console.WriteLine();
        PrintFloatingAndOtherSimpleTypes();
    }

    static void PrintAcronymsAndConcepts()
    {
        Console.WriteLine("=== .NET acronyms and concepts ===");
        Console.WriteLine("""
            CLR  — Common Language Runtime: executes managed code (JIT, GC, exceptions, security).
            CTS  — Common Type System: rules for how types are declared and used across languages.
            CLS  — Common Language Specification: subset of CTS for cross-language public APIs.
            IL   — Intermediate Language (CIL): compiler output executed by the CLR.
            CLI  — Common Language Infrastructure: ECMA standard (runtime, CTS, metadata).
            BCL  — Base Class Library: core types in System.* used by all .NET apps.
            FCL  — Framework Class Library (legacy term): broader set of .NET libraries.
            JIT  — Just-In-Time compilation: IL → native code at run time.
            GC   — Garbage Collector: reclaims unused managed memory.

            Managed code     — Targets the CLR; gets memory management and type safety.
            Value type       — Stored on the stack (or inline); copy by value (struct, primitives).
            Reference type   — Instance on the heap; variable holds a reference (class, string).
            Strong typing    — Every expression has a type; unsafe mixes are compile errors.
            Literal          — Source-code notation for a constant value (42, 3.14m, 'A').
            """);
    }

    static void PrintIntegralTypes()
    {
        Console.WriteLine("=== Integral types (range and standard values) ===");
        Console.WriteLine($"{"Type",-8} {"Min",-22} {"Max",-22} {"Default",-8} {"Size"}");
        PrintIntegralRow("sbyte", sbyte.MinValue, sbyte.MaxValue, default(sbyte), "8-bit signed");
        PrintIntegralRow("byte", byte.MinValue, byte.MaxValue, default(byte), "8-bit unsigned");
        PrintIntegralRow("short", short.MinValue, short.MaxValue, default(short), "16-bit signed");
        PrintIntegralRow("ushort", ushort.MinValue, ushort.MaxValue, default(ushort), "16-bit unsigned");
        PrintIntegralRow("int", int.MinValue, int.MaxValue, default(int), "32-bit signed");
        PrintIntegralRow("uint", uint.MinValue, uint.MaxValue, default(uint), "32-bit unsigned");
        PrintIntegralRow("long", long.MinValue, long.MaxValue, default(long), "64-bit signed");
        PrintIntegralRow("ulong", ulong.MinValue, ulong.MaxValue, default(ulong), "64-bit unsigned");
    }

    static void PrintIntegralRow<T>(string name, T min, T max, T defaultValue, string size)
        where T : struct
    {
        Console.WriteLine($"{name,-8} {min,-22} {max,-22} {defaultValue,-8} {size}");
    }

    static void PrintFloatingAndOtherSimpleTypes()
    {
        Console.WriteLine("=== Other simple built-in types ===");
        Console.WriteLine($"bool     default: {default(bool)}   (only true / false)");
        Console.WriteLine($"char     default: {(int)default(char)} ('\\0')   range: U+0000 … U+FFFF (UTF-16 code unit)");
        Console.WriteLine($"float    Min: {float.MinValue}");
        Console.WriteLine($"         Max: {float.MaxValue}");
        Console.WriteLine($"         default: {default(float)}");
        Console.WriteLine($"double   Min: {double.MinValue}");
        Console.WriteLine($"         Max: {double.MaxValue}");
        Console.WriteLine($"         default: {default(double)}");
        Console.WriteLine($"decimal  Min: {decimal.MinValue}");
        Console.WriteLine($"         Max: {decimal.MaxValue}");
        Console.WriteLine($"         default: {default(decimal)}");
        Console.WriteLine("string   default: null (reference type; immutable text)");
    }
}
