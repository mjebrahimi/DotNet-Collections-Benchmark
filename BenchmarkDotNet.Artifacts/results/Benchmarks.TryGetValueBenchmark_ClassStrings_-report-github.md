```

BenchmarkDotNet v0.13.12, Windows 11 (10.0.22631.3007/23H2/2023Update/SunValley3)
AMD Ryzen 7 5800H with Radeon Graphics, 1 CPU, 16 logical and 8 physical cores
.NET SDK 8.0.101
  [Host]   : .NET 8.0.1 (8.0.123.58001), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.1 (8.0.123.58001), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                                   | Categories | DataType     | Length | Existed | Mean        | Error        | StdDev    | Allocated |
|----------------------------------------- |----------- |------------- |------- |-------- |------------:|-------------:|----------:|----------:|
| **FrozenDictionary**                         | **O(1)**       | **ClassStrings** | **1000**   | **False**   |    **23.98 ns** |     **0.452 ns** |  **0.025 ns** |         **-** |
| FrozenSet                                | O(1)       | ClassStrings | 1000   | False   |    26.46 ns |     0.456 ns |  0.025 ns |         - |
| HashSet                                  | O(1)       | ClassStrings | 1000   | False   |    26.76 ns |     0.408 ns |  0.022 ns |         - |
| Dictionary                               | O(1)       | ClassStrings | 1000   | False   |    26.80 ns |     1.645 ns |  0.090 ns |         - |
| ReadOnlyDictionary                       | O(1)       | ClassStrings | 1000   | False   |    27.73 ns |     2.351 ns |  0.129 ns |         - |
| ImmutableDictionary                      | O(1)       | ClassStrings | 1000   | False   |    30.47 ns |     2.660 ns |  0.146 ns |         - |
| ImmutableHashSet                         | O(1)       | ClassStrings | 1000   | False   |    30.72 ns |     0.623 ns |  0.034 ns |         - |
|                                          |            |              |        |         |             |              |           |           |
| **FrozenDictionary**                         | **O(1)**       | **ClassStrings** | **1000**   | **True**    |    **27.86 ns** |     **4.357 ns** |  **0.239 ns** |         **-** |
| Dictionary                               | O(1)       | ClassStrings | 1000   | True    |    30.29 ns |     6.321 ns |  0.346 ns |         - |
| HashSet                                  | O(1)       | ClassStrings | 1000   | True    |    30.82 ns |     5.325 ns |  0.292 ns |         - |
| ReadOnlyDictionary                       | O(1)       | ClassStrings | 1000   | True    |    33.20 ns |     8.883 ns |  0.487 ns |         - |
| FrozenSet                                | O(1)       | ClassStrings | 1000   | True    |    33.70 ns |     5.565 ns |  0.305 ns |         - |
| ImmutableHashSet                         | O(1)       | ClassStrings | 1000   | True    |    34.40 ns |     2.157 ns |  0.118 ns |         - |
| ImmutableDictionary                      | O(1)       | ClassStrings | 1000   | True    |    35.85 ns |     4.065 ns |  0.223 ns |         - |
|                                          |            |              |        |         |             |              |           |           |
| **SortedSet**                                | **O(log(N))**  | **ClassStrings** | **1000**   | **False**   |   **321.25 ns** |    **66.400 ns** |  **3.640 ns** |         **-** |
| &#39;List (Sorted + BinarySearch)&#39;           | O(log(N))  | ClassStrings | 1000   | False   |   323.10 ns |    96.490 ns |  5.289 ns |         - |
| SortedList                               | O(log(N))  | ClassStrings | 1000   | False   |   335.78 ns |   106.597 ns |  5.843 ns |         - |
| &#39;Array (Sorted + BinarySearch)&#39;          | O(log(N))  | ClassStrings | 1000   | False   |   336.69 ns |    38.143 ns |  2.091 ns |         - |
| &#39;ImmutableArray (Sorted + BinarySearch)&#39; | O(log(N))  | ClassStrings | 1000   | False   |   337.24 ns |    81.554 ns |  4.470 ns |         - |
| ImmutableSortedDictionary                | O(log(N))  | ClassStrings | 1000   | False   |   338.19 ns |    37.666 ns |  2.065 ns |         - |
| SortedDictionary                         | O(log(N))  | ClassStrings | 1000   | False   |   362.20 ns |     9.752 ns |  0.535 ns |         - |
| ImmutableSortedSet                       | O(log(N))  | ClassStrings | 1000   | False   |   362.93 ns |    12.923 ns |  0.708 ns |         - |
| &#39;ImmutableList (Sorted + BinarySearch)&#39;  | O(log(N))  | ClassStrings | 1000   | False   |   380.81 ns |    42.232 ns |  2.315 ns |         - |
|                                          |            |              |        |         |             |              |           |           |
| **ImmutableSortedSet**                       | **O(log(N))**  | **ClassStrings** | **1000**   | **True**    |   **259.80 ns** |    **19.087 ns** |  **1.046 ns** |         **-** |
| ImmutableSortedDictionary                | O(log(N))  | ClassStrings | 1000   | True    |   260.24 ns |    32.740 ns |  1.795 ns |         - |
| SortedList                               | O(log(N))  | ClassStrings | 1000   | True    |   266.62 ns |    35.902 ns |  1.968 ns |         - |
| SortedSet                                | O(log(N))  | ClassStrings | 1000   | True    |   271.12 ns |    31.895 ns |  1.748 ns |         - |
| &#39;List (Sorted + BinarySearch)&#39;           | O(log(N))  | ClassStrings | 1000   | True    |   279.69 ns |    37.823 ns |  2.073 ns |         - |
| &#39;Array (Sorted + BinarySearch)&#39;          | O(log(N))  | ClassStrings | 1000   | True    |   284.16 ns |    61.323 ns |  3.361 ns |         - |
| &#39;ImmutableArray (Sorted + BinarySearch)&#39; | O(log(N))  | ClassStrings | 1000   | True    |   287.29 ns |    22.202 ns |  1.217 ns |         - |
| &#39;ImmutableList (Sorted + BinarySearch)&#39;  | O(log(N))  | ClassStrings | 1000   | True    |   289.97 ns |    49.846 ns |  2.732 ns |         - |
| SortedDictionary                         | O(log(N))  | ClassStrings | 1000   | True    |   323.84 ns |    54.871 ns |  3.008 ns |         - |
|                                          |            |              |        |         |             |              |           |           |
| **ReadOnlyCollection**                       | **O(N)**       | **ClassStrings** | **1000**   | **False**   |   **806.45 ns** |    **25.769 ns** |  **1.412 ns** |         **-** |
| ImmutableArray                           | O(N)       | ClassStrings | 1000   | False   | 4,104.14 ns |   561.662 ns | 30.787 ns |         - |
| Array                                    | O(N)       | ClassStrings | 1000   | False   | 4,278.42 ns | 1,175.071 ns | 64.410 ns |         - |
| List                                     | O(N)       | ClassStrings | 1000   | False   | 4,405.76 ns |   631.143 ns | 34.595 ns |         - |
|                                          |            |              |        |         |             |              |           |           |
| **ReadOnlyCollection**                       | **O(N)**       | **ClassStrings** | **1000**   | **True**    |   **326.04 ns** |    **53.764 ns** |  **2.947 ns** |         **-** |
| List                                     | O(N)       | ClassStrings | 1000   | True    | 1,956.09 ns |   813.244 ns | 44.577 ns |         - |
| ImmutableArray                           | O(N)       | ClassStrings | 1000   | True    | 1,983.68 ns |   248.286 ns | 13.609 ns |         - |
| Array                                    | O(N)       | ClassStrings | 1000   | True    | 2,075.47 ns |   640.796 ns | 35.124 ns |         - |
