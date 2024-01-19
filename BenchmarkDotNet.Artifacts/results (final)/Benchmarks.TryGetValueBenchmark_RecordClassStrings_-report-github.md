```

BenchmarkDotNet v0.13.12, Windows 11 (10.0.22631.3007/23H2/2023Update/SunValley3)
AMD Ryzen 7 5800H with Radeon Graphics, 1 CPU, 16 logical and 8 physical cores
.NET SDK 8.0.101
  [Host]   : .NET 8.0.1 (8.0.123.58001), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.1 (8.0.123.58001), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                                   | Categories | DataType           | Length | Existed | Mean        | Error        | StdDev    | Allocated |
|----------------------------------------- |----------- |------------------- |------- |-------- |------------:|-------------:|----------:|----------:|
| **FrozenDictionary**                         | **O(1)**       | **RecordClassStrings** | **1000**   | **False**   |    **26.36 ns** |     **1.391 ns** |  **0.076 ns** |         **-** |
| HashSet                                  | O(1)       | RecordClassStrings | 1000   | False   |    28.78 ns |     4.846 ns |  0.266 ns |         - |
| Dictionary                               | O(1)       | RecordClassStrings | 1000   | False   |    28.87 ns |     2.318 ns |  0.127 ns |         - |
| FrozenSet                                | O(1)       | RecordClassStrings | 1000   | False   |    29.70 ns |     3.062 ns |  0.168 ns |         - |
| ReadOnlyDictionary                       | O(1)       | RecordClassStrings | 1000   | False   |    30.32 ns |     0.650 ns |  0.036 ns |         - |
| ImmutableHashSet                         | O(1)       | RecordClassStrings | 1000   | False   |    33.02 ns |     5.427 ns |  0.297 ns |         - |
| ImmutableDictionary                      | O(1)       | RecordClassStrings | 1000   | False   |    33.59 ns |     3.003 ns |  0.165 ns |         - |
|                                          |            |                    |        |         |             |              |           |           |
| **FrozenDictionary**                         | **O(1)**       | **RecordClassStrings** | **1000**   | **True**    |    **29.57 ns** |     **7.962 ns** |  **0.436 ns** |         **-** |
| Dictionary                               | O(1)       | RecordClassStrings | 1000   | True    |    32.05 ns |     4.278 ns |  0.235 ns |         - |
| HashSet                                  | O(1)       | RecordClassStrings | 1000   | True    |    32.48 ns |     4.079 ns |  0.224 ns |         - |
| ReadOnlyDictionary                       | O(1)       | RecordClassStrings | 1000   | True    |    34.84 ns |     4.180 ns |  0.229 ns |         - |
| FrozenSet                                | O(1)       | RecordClassStrings | 1000   | True    |    35.91 ns |     3.457 ns |  0.189 ns |         - |
| ImmutableHashSet                         | O(1)       | RecordClassStrings | 1000   | True    |    37.07 ns |     4.833 ns |  0.265 ns |         - |
| ImmutableDictionary                      | O(1)       | RecordClassStrings | 1000   | True    |    38.15 ns |     0.199 ns |  0.011 ns |         - |
|                                          |            |                    |        |         |             |              |           |           |
| **SortedSet**                                | **O(log(N))**  | **RecordClassStrings** | **1000**   | **False**   |   **325.54 ns** |    **21.594 ns** |  **1.184 ns** |         **-** |
| &#39;ImmutableArray (Sorted + BinarySearch)&#39; | O(log(N))  | RecordClassStrings | 1000   | False   |   332.00 ns |    45.300 ns |  2.483 ns |         - |
| &#39;List (Sorted + BinarySearch)&#39;           | O(log(N))  | RecordClassStrings | 1000   | False   |   334.64 ns |   112.711 ns |  6.178 ns |         - |
| ImmutableSortedDictionary                | O(log(N))  | RecordClassStrings | 1000   | False   |   338.98 ns |    11.921 ns |  0.653 ns |         - |
| ImmutableSortedSet                       | O(log(N))  | RecordClassStrings | 1000   | False   |   339.99 ns |    67.104 ns |  3.678 ns |         - |
| &#39;Array (Sorted + BinarySearch)&#39;          | O(log(N))  | RecordClassStrings | 1000   | False   |   340.86 ns |    39.137 ns |  2.145 ns |         - |
| SortedList                               | O(log(N))  | RecordClassStrings | 1000   | False   |   350.56 ns |    49.175 ns |  2.695 ns |         - |
| SortedDictionary                         | O(log(N))  | RecordClassStrings | 1000   | False   |   356.53 ns |    25.994 ns |  1.425 ns |         - |
| &#39;ImmutableList (Sorted + BinarySearch)&#39;  | O(log(N))  | RecordClassStrings | 1000   | False   |   363.58 ns |    29.774 ns |  1.632 ns |         - |
|                                          |            |                    |        |         |             |              |           |           |
| **ImmutableSortedSet**                       | **O(log(N))**  | **RecordClassStrings** | **1000**   | **True**    |   **259.17 ns** |    **22.591 ns** |  **1.238 ns** |         **-** |
| SortedList                               | O(log(N))  | RecordClassStrings | 1000   | True    |   260.66 ns |    81.695 ns |  4.478 ns |         - |
| &#39;Array (Sorted + BinarySearch)&#39;          | O(log(N))  | RecordClassStrings | 1000   | True    |   265.16 ns |     2.261 ns |  0.124 ns |         - |
| ImmutableSortedDictionary                | O(log(N))  | RecordClassStrings | 1000   | True    |   266.12 ns |    35.699 ns |  1.957 ns |         - |
| &#39;List (Sorted + BinarySearch)&#39;           | O(log(N))  | RecordClassStrings | 1000   | True    |   278.72 ns |    64.938 ns |  3.559 ns |         - |
| &#39;ImmutableArray (Sorted + BinarySearch)&#39; | O(log(N))  | RecordClassStrings | 1000   | True    |   283.93 ns |    46.340 ns |  2.540 ns |         - |
| SortedSet                                | O(log(N))  | RecordClassStrings | 1000   | True    |   288.70 ns |   296.483 ns | 16.251 ns |         - |
| SortedDictionary                         | O(log(N))  | RecordClassStrings | 1000   | True    |   292.27 ns |    33.345 ns |  1.828 ns |         - |
| &#39;ImmutableList (Sorted + BinarySearch)&#39;  | O(log(N))  | RecordClassStrings | 1000   | True    |   294.36 ns |   102.286 ns |  5.607 ns |         - |
|                                          |            |                    |        |         |             |              |           |           |
| **ReadOnlyCollection**                       | **O(N)**       | **RecordClassStrings** | **1000**   | **False**   | **4,492.43 ns** |   **218.226 ns** | **11.962 ns** |         **-** |
| ImmutableArray                           | O(N)       | RecordClassStrings | 1000   | False   | 4,864.75 ns |   674.816 ns | 36.989 ns |         - |
| Array                                    | O(N)       | RecordClassStrings | 1000   | False   | 4,876.45 ns | 1,025.518 ns | 56.212 ns |         - |
| List                                     | O(N)       | RecordClassStrings | 1000   | False   | 4,918.19 ns |   873.512 ns | 47.880 ns |         - |
|                                          |            |                    |        |         |             |              |           |           |
| **ReadOnlyCollection**                       | **O(N)**       | **RecordClassStrings** | **1000**   | **True**    | **2,153.06 ns** |   **267.375 ns** | **14.656 ns** |         **-** |
| Array                                    | O(N)       | RecordClassStrings | 1000   | True    | 2,295.45 ns |   464.069 ns | 25.437 ns |         - |
| List                                     | O(N)       | RecordClassStrings | 1000   | True    | 2,321.20 ns |   713.721 ns | 39.121 ns |         - |
| ImmutableArray                           | O(N)       | RecordClassStrings | 1000   | True    | 2,408.86 ns |   614.921 ns | 33.706 ns |         - |
