using System.Buffers;
using System.Collections.Frozen;
using System.Collections.Immutable;
using System.Collections.ObjectModel;

namespace Utilities;

public static class CollectionExtensions
{
    public static SortedSet<TKey> ToSortedSet<TKey>(this IEnumerable<TKey> collection)
    {
        return new SortedSet<TKey>(collection);
    }

    public static Dictionary<TKey, bool> ToDictionary<TKey>(this IEnumerable<TKey> collection) where TKey : notnull
    {
        return collection.ToDictionary(p => p, _ => false);
    }

    public static ImmutableDictionary<TKey, bool> ToImmutableDictionary<TKey>(this IEnumerable<TKey> collection) where TKey : notnull
    {
        return collection.ToImmutableDictionary(p => p, _ => false);
    }

    public static ImmutableSortedDictionary<TKey, bool> ToImmutableSortedDictionary<TKey>(this IEnumerable<TKey> collection) where TKey : notnull
    {
        return collection.ToImmutableSortedDictionary(p => p, _ => false);
    }

    public static FrozenDictionary<TKey, bool> ToFrozenDictionary<TKey>(this IEnumerable<TKey> collection) where TKey : notnull
    {
        return collection.ToFrozenDictionary(p => p, _ => false);
    }

    public static SortedDictionary<TKey, bool> ToSortedDictionary<TKey>(this IEnumerable<TKey> collection) where TKey : notnull
    {
        return new SortedDictionary<TKey, bool>(collection.ToDictionary());
    }

    public static ReadOnlyDictionary<TKey, bool> ToReadOnlyDictionary<TKey>(this IEnumerable<TKey> collection) where TKey : notnull
    {
        return new ReadOnlyDictionary<TKey, bool>(collection.ToDictionary());
    }

    public static SortedList<TKey, bool> ToSortedList<TKey>(this IEnumerable<TKey> collection) where TKey : notnull
    {
        return new SortedList<TKey, bool>(collection.ToDictionary());
    }

    public static ReadOnlyCollection<TKey> ToReadOnlyCollection<TKey>(this IEnumerable<TKey> collection)
    {
        //this idea could be implemented for other collections as well
        //ArgumentNullException.ThrowIfNull(collection);
        //if ((collection.TryGetNonEnumeratedCount(out var count) && count == 0) || collection.Any() is false)
        //    return ReadOnlyCollection<TKey>.Empty;

        return new ReadOnlyCollection<TKey>(collection.ToArray());
    }

    public static LinkedList<TKey> ToLinkedList<TKey>(this IEnumerable<TKey> collection)
    {
        return new LinkedList<TKey>(collection);
    }
}