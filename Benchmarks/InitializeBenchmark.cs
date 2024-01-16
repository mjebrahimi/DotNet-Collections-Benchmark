using BenchmarkDotNet.Attributes;
using BenchmarkDotNetVisualizer;
using System.Collections.Frozen;
using System.Collections.Immutable;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using Utilities;

namespace Benchmarks;

[RichHtmlExporter(
    title: "Benchmark of Collection Initializing",
    groupByColumns: ["Length", "Sorted"],
    sortByColumns: ["Mean", "Allocated"],
    spectrumColumns: ["Mean", "Allocated"],
    highlightGroups: true,
    dividerMode: RenderTableDividerMode.SeparateTables,
    htmlWrapMode: HtmlDocumentWrapMode.RichDataTables)]
[GenericTypeArguments(typeof(int))]
[GenericTypeArguments(typeof(string))]
[GenericTypeArguments(typeof(StructInts))]
[GenericTypeArguments(typeof(StructStrings))]
[GenericTypeArguments(typeof(ClassInts))]
[GenericTypeArguments(typeof(ClassStrings))]
[GenericTypeArguments(typeof(RecordStructInts))]
[GenericTypeArguments(typeof(RecordStructStrings))]
[GenericTypeArguments(typeof(RecordClassInts))]
[GenericTypeArguments(typeof(RecordClassStrings))]
[Display(Name = "Benchmark of Collection Initializing for '{0}' type", GroupName = "Benchmark of Collection Initializing")]
public class InitializeBenchmark<T> : BenchmarkBase
{
    public string[] GetDataTypeName { get; } = [typeof(T).Name];

    [ParamsSource(nameof(GetDataTypeName), Priority = -1)]
    public string DataType { get; set; }

    [Params(10_000, 1_000_000)]
    public int Length { get; set; }

    [ParamsAllValues]
    public bool Sorted { get; set; }

    private T[] _array;

    [GlobalSetup]
    public void Setup()
    {
        var arr = GetRandomUniqueArray<T>(Length);
        _array = Sorted ? arr.Sort() : arr;
    }

    [Benchmark]
    public T[] Array()
    {
        return _array.ToArray();
    }

    [Benchmark(Description = "Array (Sorted)")]
    public T[] Array_Sorted()
    {
        return _array.ToArray().Sort();
    }

    [Benchmark]
    public ImmutableArray<T> ImmutableArray()
    {
        return _array.ToImmutableArray();
    }

    [Benchmark(Description = "ImmutableArray (Sorted)")]
    public ImmutableArray<T> ImmutableArray_Sorted()
    {
        return _array.ToImmutableArray().Sort();
    }

    [Benchmark]
    public List<T> List()
    {
        return _array.ToList();
    }

    [Benchmark(Description = "List (Sorted)")]
    public List<T> List_Sorted()
    {
        var list = _array.ToList();
        list.Sort();
        return list;
    }

    [Benchmark]
    public ImmutableList<T> ImmutableList()
    {
        return _array.ToImmutableList();
    }

    [Benchmark(Description = "ImmutableList (Sorted)")]
    public ImmutableList<T> ImmutableList_Sorted()
    {
        return _array.ToImmutableList().Sort();
    }

    [Benchmark]
    public LinkedList<T> LinkedList()
    {
        return _array.ToLinkedList();
    }

    [Benchmark]
    public ReadOnlyCollection<T> ReadOnlyCollection()
    {
        return _array.ToReadOnlyCollection();
    }

    [Benchmark]
    public HashSet<T> HashSet()
    {
        return _array.ToHashSet();
    }

    [Benchmark]
    public ImmutableHashSet<T> ImmutableHashSet()
    {
        return _array.ToImmutableHashSet();
    }

    [Benchmark]
    public SortedSet<T> SortedSet()
    {
        return _array.ToSortedSet();
    }

    [Benchmark]
    public ImmutableSortedSet<T> ImmutableSortedSet()
    {
        return _array.ToImmutableSortedSet();
    }

    [Benchmark]
    public Dictionary<T, bool> Dictionary()
    {
        return _array.ToDictionary();
    }

    [Benchmark]
    public ReadOnlyDictionary<T, bool> ReadOnlyDictionary()
    {
        return _array.ToReadOnlyDictionary();
    }

    [Benchmark]
    public SortedDictionary<T, bool> SortedDictionary()
    {
        return _array.ToSortedDictionary();
    }

    [Benchmark]
    public SortedList<T, bool> SortedList()
    {
        return _array.ToSortedList();
    }

    [Benchmark]
    public ImmutableDictionary<T, bool> ImmutableDictionary()
    {
        return _array.ToImmutableDictionary();
    }

    [Benchmark]
    public ImmutableSortedDictionary<T, bool> ImmutableSortedDictionary()
    {
        return _array.ToImmutableSortedDictionary();
    }

    [Benchmark]
    public FrozenSet<T> FrozenSet()
    {
        return _array.ToFrozenSet();
    }

    [Benchmark]
    public FrozenDictionary<T, bool> FrozenDictionary()
    {
        return _array.ToFrozenDictionary();
    }
}