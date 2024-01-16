using BenchmarkDotNet.Attributes;
using BenchmarkDotNetVisualizer;
using System.Collections.Frozen;
using System.Collections.Immutable;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using Utilities;

namespace Benchmarks;

[RichHtmlExporter(
    title: "Benchmark of Collection Searching (Contains method)",
    groupByColumns: ["Existed"],
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
[Display(Name = "Benchmark of Collection Searching (Contains method) for '{0}' type", GroupName = "Benchmark of Collection Searching (Contains method)")]
public class ContainsBenchmark<T> : BenchmarkBase
{
    public string[] GetDataTypeName => [typeof(T).Name];

    [ParamsSource(nameof(GetDataTypeName), Priority = -1)]
    public string DataType { get; set; }

    [Params(1000)]
    public int Length { get; set; }

    [ParamsAllValues]
    public bool Existed { get; set; }

    private T[] _itemsToFind;

    private T[] _array;
    private T[] _arraySorted;
    private ImmutableArray<T> _immutableArray;
    private ImmutableArray<T> _immutableArraySorted;

    private List<T> _list;
    private List<T> _listSorted;
    //private ImmutableList<T> _immutableList;
    private ImmutableList<T> _immutableListSorted;

    //private LinkedList<T> _linkedList;
    private ReadOnlyCollection<T> _readOnlyCollection;

    private HashSet<T> _hashSet;
    private ImmutableHashSet<T> _immutableHashSet;

    private SortedSet<T> _sortedSet;
    private ImmutableSortedSet<T> _immutableSortedSet;

    private Dictionary<T, bool> _dictionary;
    private ReadOnlyDictionary<T, bool> _readOnlyDictionary;
    private SortedDictionary<T, bool> _sortedDictionary;
    private SortedList<T, bool> _sortedList;
    private ImmutableDictionary<T, bool> _immutableDictionary;
    private ImmutableSortedDictionary<T, bool> _immutableSortedDictionary;

    private FrozenSet<T> _frozenSet;
    private FrozenDictionary<T, bool> _frozenDictionary;

    [GlobalSetup]
    public void Setup()
    {
        //============== Sorted by Speed ==============
        //1. FrozenSet - FrozenDictionary
        //2. Dictionary - HashSet
        //3. ImmutableDictionary - ImmutableHashSet
        //4. SortedSet
        //5. ImmutableSortedDictionary
        //6. ImmutableSortedSet

        var array = GetRandomUniqueArray<T>(Length);
        _itemsToFind = Existed ? GetExistedItemsToFind(array) : GetNotExistedItemsToFind(array);

        _array = array.ToArray();
        _arraySorted = array.ToArray().Sort();

        _immutableArray = array.ToImmutableArray();
        _immutableArraySorted = array.ToImmutableArray().Sort();

        _list = array.ToList();
        _listSorted = array.ToList();
        _listSorted.Sort();

        //_immutableList = array.ToImmutableList();
        _immutableListSorted = array.ToImmutableList().Sort();

        //_linkedList = array.ToLinkedList();
        _readOnlyCollection = array.ToReadOnlyCollection();

        _hashSet = array.ToHashSet();
        _immutableHashSet = array.ToImmutableHashSet();

        _sortedSet = array.ToSortedSet();
        _immutableSortedSet = array.ToImmutableSortedSet();

        _dictionary = array.ToDictionary();
        _readOnlyDictionary = array.ToReadOnlyDictionary();
        _sortedDictionary = array.ToSortedDictionary();
        _sortedList = array.ToSortedList();
        _immutableDictionary = array.ToImmutableDictionary();
        _immutableSortedDictionary = array.ToImmutableSortedDictionary();

        _frozenSet = array.ToFrozenSet();
        _frozenDictionary = array.ToFrozenDictionary();
    }

    [Benchmark(OperationsPerInvoke = 12), BenchmarkCategory("O(N)")]
    public void Array()
    {
        foreach (var item in _itemsToFind)
        {
            var exists = _array.Contains(item);
        }
    }

    [Benchmark(OperationsPerInvoke = 12, Description = "Array (Sorted + BinarySearch)"), BenchmarkCategory("O(log(N))")]
    public void Array_ContainsBinarySearch()
    {
        foreach (var item in _itemsToFind)
        {
            var exists = _arraySorted.ContainsBinarySearch(item);
        }
    }

    [Benchmark(OperationsPerInvoke = 12), BenchmarkCategory("O(N)")]
    public void ImmutableArray()
    {
        foreach (var item in _itemsToFind)
        {
            var exists = _immutableArray.Contains(item);
        }
    }

    [Benchmark(OperationsPerInvoke = 12, Description = "ImmutableArray (Sorted + BinarySearch)"), BenchmarkCategory("O(log(N))")]
    public void ImmutableArray_ContainsBinarySearch()
    {
        foreach (var item in _itemsToFind)
        {
            var exists = _immutableArraySorted.ContainsBinarySearch(item);
        }
    }

    [Benchmark(OperationsPerInvoke = 12), BenchmarkCategory("O(N)")]
    public void List()
    {
        foreach (var item in _itemsToFind)
        {
            var exists = _list.Contains(item);
        }
    }

    [Benchmark(OperationsPerInvoke = 12, Description = "List (Sorted + BinarySearch)"), BenchmarkCategory("O(log(N))")]
    public void List_ContainsBinarySearch()
    {
        foreach (var item in _itemsToFind)
        {
            var exists = _listSorted.ContainsBinarySearch(item);
        }
    }

    //[Benchmark(OperationsPerInvoke = 12), BenchmarkCategory("O(N)")]
    //public void ImmutableList()
    //{
    //    foreach (var item in _itemsToFind)
    //    {
    //        var exists = _immutableList.Contains(item);
    //    }
    //}

    [Benchmark(OperationsPerInvoke = 12, Description = "ImmutableList (Sorted + BinarySearch)"), BenchmarkCategory("O(log(N))")]
    public void ImmutableList_ContainsBinarySearch()
    {
        foreach (var item in _itemsToFind)
        {
            var exists = _immutableListSorted.ContainsBinarySearch(item);
        }
    }

    //[Benchmark(OperationsPerInvoke = 12), BenchmarkCategory("O(N)")]
    //public void LinkedList()
    //{
    //    foreach (var item in _itemsToFind)
    //    {
    //        var exists = _linkedList.Contains(item);
    //    }
    //}

    [Benchmark(OperationsPerInvoke = 12), BenchmarkCategory("O(N)")]
    public void ReadOnlyCollection()
    {
        foreach (var item in _itemsToFind)
        {
            var exists = _readOnlyCollection.Contains(item);
        }
    }

    [Benchmark(OperationsPerInvoke = 12), BenchmarkCategory("O(1)")]
    public void HashSet()
    {
        foreach (var item in _itemsToFind)
        {
            var exists = _hashSet.Contains(item);
        }
    }

    [Benchmark(OperationsPerInvoke = 12), BenchmarkCategory("O(1)")]
    public void ImmutableHashSet()
    {
        foreach (var item in _itemsToFind)
        {
            var exists = _immutableHashSet.Contains(item);
        }
    }

    [Benchmark(OperationsPerInvoke = 12), BenchmarkCategory("O(log(N))")]
    public void SortedSet()
    {
        foreach (var item in _itemsToFind)
        {
            var exists = _sortedSet.Contains(item);
        }
    }

    [Benchmark(OperationsPerInvoke = 12), BenchmarkCategory("O(log(N))")]
    public void ImmutableSortedSet()
    {
        foreach (var item in _itemsToFind)
        {
            var exists = _immutableSortedSet.Contains(item);
        }
    }

    [Benchmark(OperationsPerInvoke = 12), BenchmarkCategory("O(1)")]
    public void Dictionary()
    {
        foreach (var item in _itemsToFind)
        {
            var exists = _dictionary.ContainsKey(item);
        }
    }

    [Benchmark(OperationsPerInvoke = 12), BenchmarkCategory("O(1)")]
    public void ReadOnlyDictionary()
    {
        foreach (var item in _itemsToFind)
        {
            var exists = _readOnlyDictionary.ContainsKey(item);
        }
    }

    [Benchmark(OperationsPerInvoke = 12), BenchmarkCategory("O(log(N))")]
    public void SortedDictionary()
    {
        foreach (var item in _itemsToFind)
        {
            var exists = _sortedDictionary.ContainsKey(item);
        }
    }

    [Benchmark(OperationsPerInvoke = 12), BenchmarkCategory("O(log(N))")]
    public void SortedList()
    {
        foreach (var item in _itemsToFind)
        {
            var exists = _sortedList.ContainsKey(item);
        }
    }

    [Benchmark(OperationsPerInvoke = 12), BenchmarkCategory("O(1)")]
    public void ImmutableDictionary()
    {
        foreach (var item in _itemsToFind)
        {
            var exists = _immutableDictionary.ContainsKey(item);
        }
    }

    [Benchmark(OperationsPerInvoke = 12), BenchmarkCategory("O(log(N))")]
    public void ImmutableSortedDictionary()
    {
        foreach (var item in _itemsToFind)
        {
            var exists = _immutableSortedDictionary.ContainsKey(item);
        }
    }

    [Benchmark(OperationsPerInvoke = 12), BenchmarkCategory("O(1)")]
    public void FrozenSet()
    {
        foreach (var item in _itemsToFind)
        {
            var exists = _frozenSet.Contains(item);
        }
    }

    [Benchmark(OperationsPerInvoke = 12), BenchmarkCategory("O(1)")]
    public void FrozenDictionary()
    {
        foreach (var item in _itemsToFind)
        {
            var exists = _frozenDictionary.ContainsKey(item);
        }
    }

    #region Delegate
    //private Func<int, bool> _frozenFunc1;
    //private Action<int[]> _frozenFunc2;
    //private Action _frozenFunc3;

    //[GlobalSetup]
    //public void Setup()
    //{
    //    _frozenFunc1 = frozenDic.ContainsKey;
    //    _frozenFunc2 = (findItem) =>
    //    {
    //        foreach (var item in findItem)
    //            frozenDic.ContainsKey(item);
    //    };
    //    _frozenFunc3 = () =>
    //    {
    //        foreach (var item in items)
    //            frozenDic.ContainsKey(item);
    //    };
    //}

    //[Benchmark]
    //public void FrozenDictionary_Func1()
    //{
    //    foreach (var item in _findItems)
    //        _frozenFunc1(item);
    //}

    //[Benchmark]
    //public void FrozenDictionary_Func2()
    //{
    //    _frozenFunc2(_findItems);
    //}

    //[Benchmark]
    //public void FrozenDictionary_Func3()
    //{
    //    _frozenFunc3();
    //}
    #endregion
}