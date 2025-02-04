// <auto-generated />

#pragma warning disable

#if NETFRAMEWORK || NETSTANDARD2_0

using System;
using System.Collections.Generic;
using Link = System.ComponentModel.DescriptionAttribute;

static partial class PolyfillExtensions
{
    /// <summary>
    /// Deconstructs the current <see cref="KeyValuePair{TKey,TValue}"/>
    /// </summary>
    /// <param name="key">The key of the current <see cref="KeyValuePair{TKey,TValue}"/>.</param>
    /// <param name="value">The value of the current <see cref="KeyValuePair{TKey,TValue}"/>.</param>
    [Link("https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.keyvaluepair-2.deconstruct")]
    public static void Deconstruct<TKey, TValue>(
        this KeyValuePair<TKey, TValue> target,
        out TKey key,
        out TValue value)
    {
        key = target.Key;
        value = target.Value;
    }
}
#endif