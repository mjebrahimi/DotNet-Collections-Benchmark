```

BenchmarkDotNet v0.13.12, Windows 11 (10.0.22631.3007/23H2/2023Update/SunValley3)
AMD Ryzen 7 5800H with Radeon Graphics, 1 CPU, 16 logical and 8 physical cores
.NET SDK 8.0.101
  [Host]   : .NET 8.0.1 (8.0.123.58001), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.1 (8.0.123.58001), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                                   | Categories | DataType            | Length | Existed | Mean        | Error        | StdDev    | Allocated |
|----------------------------------------- |----------- |-------------------- |------- |-------- |------------:|-------------:|----------:|----------:|
| **FrozenSet**                                | **O(1)**       | **RecordStructStrings** | **1000**   | **False**   |    **22.21 ns** |     **1.835 ns** |  **0.101 ns** |         **-** |
| FrozenDictionary                         | O(1)       | RecordStructStrings | 1000   | False   |    22.56 ns |     1.629 ns |  0.089 ns |         - |
| HashSet                                  | O(1)       | RecordStructStrings | 1000   | False   |    24.82 ns |     2.684 ns |  0.147 ns |         - |
| ReadOnlyDictionary                       | O(1)       | RecordStructStrings | 1000   | False   |    25.06 ns |     5.461 ns |  0.299 ns |         - |
| ImmutableHashSet                         | O(1)       | RecordStructStrings | 1000   | False   |    25.23 ns |     3.949 ns |  0.216 ns |         - |
| Dictionary                               | O(1)       | RecordStructStrings | 1000   | False   |    25.28 ns |     4.626 ns |  0.254 ns |         - |
| ImmutableDictionary                      | O(1)       | RecordStructStrings | 1000   | False   |    25.81 ns |     7.359 ns |  0.403 ns |         - |
|                                          |            |                     |        |         |             |              |           |           |
| **FrozenSet**                                | **O(1)**       | **RecordStructStrings** | **1000**   | **True**    |    **23.66 ns** |     **0.590 ns** |  **0.032 ns** |         **-** |
| FrozenDictionary                         | O(1)       | RecordStructStrings | 1000   | True    |    24.25 ns |     1.538 ns |  0.084 ns |         - |
| ImmutableHashSet                         | O(1)       | RecordStructStrings | 1000   | True    |    26.00 ns |     5.524 ns |  0.303 ns |         - |
| Dictionary                               | O(1)       | RecordStructStrings | 1000   | True    |    26.85 ns |     1.426 ns |  0.078 ns |         - |
| ReadOnlyDictionary                       | O(1)       | RecordStructStrings | 1000   | True    |    27.11 ns |     5.703 ns |  0.313 ns |         - |
| HashSet                                  | O(1)       | RecordStructStrings | 1000   | True    |    27.57 ns |     8.223 ns |  0.451 ns |         - |
| ImmutableDictionary                      | O(1)       | RecordStructStrings | 1000   | True    |    32.56 ns |     5.833 ns |  0.320 ns |         - |
|                                          |            |                     |        |         |             |              |           |           |
| **&#39;ImmutableArray (Sorted + BinarySearch)&#39;** | **O(log(N))**  | **RecordStructStrings** | **1000**   | **False**   |   **302.08 ns** |    **44.667 ns** |  **2.448 ns** |         **-** |
| SortedSet                                | O(log(N))  | RecordStructStrings | 1000   | False   |   308.11 ns |    79.726 ns |  4.370 ns |         - |
| SortedList                               | O(log(N))  | RecordStructStrings | 1000   | False   |   316.30 ns |    29.945 ns |  1.641 ns |      40 B |
| ImmutableSortedSet                       | O(log(N))  | RecordStructStrings | 1000   | False   |   317.71 ns |    13.941 ns |  0.764 ns |         - |
| &#39;ImmutableList (Sorted + BinarySearch)&#39;  | O(log(N))  | RecordStructStrings | 1000   | False   |   317.95 ns |    65.030 ns |  3.565 ns |         - |
| ImmutableSortedDictionary                | O(log(N))  | RecordStructStrings | 1000   | False   |   319.98 ns |    36.082 ns |  1.978 ns |         - |
| &#39;Array (Sorted + BinarySearch)&#39;          | O(log(N))  | RecordStructStrings | 1000   | False   |   329.15 ns |    20.060 ns |  1.100 ns |         - |
| SortedDictionary                         | O(log(N))  | RecordStructStrings | 1000   | False   |   329.55 ns |    24.596 ns |  1.348 ns |      40 B |
| &#39;List (Sorted + BinarySearch)&#39;           | O(log(N))  | RecordStructStrings | 1000   | False   |   346.24 ns |    55.936 ns |  3.066 ns |         - |
|                                          |            |                     |        |         |             |              |           |           |
| **&#39;Array (Sorted + BinarySearch)&#39;**          | **O(log(N))**  | **RecordStructStrings** | **1000**   | **True**    |   **226.55 ns** |    **31.768 ns** |  **1.741 ns** |         **-** |
| &#39;ImmutableArray (Sorted + BinarySearch)&#39; | O(log(N))  | RecordStructStrings | 1000   | True    |   228.03 ns |    35.637 ns |  1.953 ns |         - |
| &#39;List (Sorted + BinarySearch)&#39;           | O(log(N))  | RecordStructStrings | 1000   | True    |   228.34 ns |    42.569 ns |  2.333 ns |         - |
| SortedList                               | O(log(N))  | RecordStructStrings | 1000   | True    |   240.87 ns |    37.715 ns |  2.067 ns |      40 B |
| ImmutableSortedDictionary                | O(log(N))  | RecordStructStrings | 1000   | True    |   243.17 ns |    15.062 ns |  0.826 ns |         - |
| ImmutableSortedSet                       | O(log(N))  | RecordStructStrings | 1000   | True    |   244.96 ns |    33.463 ns |  1.834 ns |         - |
| &#39;ImmutableList (Sorted + BinarySearch)&#39;  | O(log(N))  | RecordStructStrings | 1000   | True    |   247.42 ns |    56.785 ns |  3.113 ns |         - |
| SortedSet                                | O(log(N))  | RecordStructStrings | 1000   | True    |   254.76 ns |    45.153 ns |  2.475 ns |         - |
| SortedDictionary                         | O(log(N))  | RecordStructStrings | 1000   | True    |   276.39 ns |   121.579 ns |  6.664 ns |      40 B |
|                                          |            |                     |        |         |             |              |           |           |
| **ReadOnlyCollection**                       | **O(N)**       | **RecordStructStrings** | **1000**   | **False**   | **2,520.05 ns** | **1,097.121 ns** | **60.137 ns** |         **-** |
| List                                     | O(N)       | RecordStructStrings | 1000   | False   | 2,531.53 ns |    25.834 ns |  1.416 ns |         - |
| ImmutableArray                           | O(N)       | RecordStructStrings | 1000   | False   | 2,730.36 ns |   964.088 ns | 52.845 ns |         - |
| Array                                    | O(N)       | RecordStructStrings | 1000   | False   | 2,848.28 ns |   817.990 ns | 44.837 ns |         - |
|                                          |            |                     |        |         |             |              |           |           |
| **List**                                     | **O(N)**       | **RecordStructStrings** | **1000**   | **True**    | **1,336.23 ns** |   **117.732 ns** |  **6.453 ns** |         **-** |
| Array                                    | O(N)       | RecordStructStrings | 1000   | True    | 1,336.30 ns |   485.548 ns | 26.615 ns |         - |
| ImmutableArray                           | O(N)       | RecordStructStrings | 1000   | True    | 1,450.75 ns |   112.171 ns |  6.148 ns |         - |
| ReadOnlyCollection                       | O(N)       | RecordStructStrings | 1000   | True    | 1,562.09 ns |   356.915 ns | 19.564 ns |         - |
