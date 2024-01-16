using System.Collections.Immutable;

namespace Utilities;

public static class ImmutableListExtensions
{
    public static bool ContainsBinarySearch<T>(this ImmutableList<T> collection, T item)
    {
        return collection.BinarySearch(item) >= 0;
    }

    public static bool ContainsBinarySearch<T>(this ImmutableList<T> collection, T item, int index, int length)
    {
        return collection.BinarySearch(index, length, item, null) >= 0;
    }

    public static bool ContainsBinarySearch<T>(this ImmutableList<T> collection, T item, IComparer<T> comparer)
    {
        return collection.BinarySearch(item, comparer) >= 0;
    }

    public static bool ContainsBinarySearch<T>(this ImmutableList<T> collection, T item, int index, int length, IComparer<T> comparer)
    {
        return collection.BinarySearch(index, length, item, comparer) >= 0;
    }

    public static bool TryGetValue<T>(this ImmutableList<T> collection, T value, out T? actualValue)
    {
        var index = collection.IndexOf(value);
        if (index >= 0)
        {
            actualValue = collection[index];
            return true;
        }

        actualValue = default;
        return false;
    }

    public static bool TryGetValueBinarySearch<T>(this ImmutableList<T> collection, T value, out T? actualValue)
    {
        var index = collection.BinarySearch(value);
        if (index >= 0)
        {
            actualValue = collection[index];
            return true;
        }

        actualValue = default;
        return false;
    }
}