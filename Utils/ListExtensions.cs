using System.Collections.ObjectModel;

namespace Utilities;

public static class ListExtensions
{
    public static bool ContainsBinarySearch<T>(this List<T> collection, T item)
    {
        return collection.BinarySearch(item) >= 0;
    }

    public static bool ContainsBinarySearch<T>(this List<T> collection, T item, int index, int length)
    {
        return collection.BinarySearch(index, length, item, null) >= 0;
    }

    public static bool ContainsBinarySearch<T>(this List<T> collection, T item, IComparer<T> comparer)
    {
        return collection.BinarySearch(item, comparer) >= 0;
    }

    public static bool ContainsBinarySearch<T>(this List<T> collection, T item, int index, int length, IComparer<T> comparer)
    {
        return collection.BinarySearch(index, length, item, comparer) >= 0;
    }

    public static bool TryGetValue<T>(this List<T> collection, T value, out T? actualValue)
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

    public static bool TryGetValueBinarySearch<T>(this List<T> collection, T value, out T? actualValue)
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

    #region ReadOnlyCollection and LinkedList
    public static bool TryGetValue<T>(this ReadOnlyCollection<T> collection, T value, out T? actualValue)
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

    public static bool TryGetValue<T>(this LinkedList<T> collection, T value, out T? actualValue)
    {
        var node = collection.Find(value);
        if (node is not null)
        {
            actualValue = node.Value;
            return true;
        }

        actualValue = default;
        return false;
    }
    #endregion
}