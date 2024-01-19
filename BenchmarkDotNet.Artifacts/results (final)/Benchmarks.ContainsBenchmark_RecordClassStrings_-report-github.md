```

BenchmarkDotNet v0.13.12, Windows 11 (10.0.22631.3007/23H2/2023Update/SunValley3)
AMD Ryzen 7 5800H with Radeon Graphics, 1 CPU, 16 logical and 8 physical cores
.NET SDK 8.0.101
  [Host]   : .NET 8.0.1 (8.0.123.58001), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.1 (8.0.123.58001), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                                   | Categories | DataType           | Length | Existed | Mean        | Error        | StdDev     | Allocated |
|----------------------------------------- |----------- |------------------- |------- |-------- |------------:|-------------:|-----------:|----------:|
| **FrozenDictionary**                         | **O(1)**       | **RecordClassStrings** | **1000**   | **False**   |    **25.92 ns** |     **2.374 ns** |   **0.130 ns** |         **-** |
| FrozenSet                                | O(1)       | RecordClassStrings | 1000   | False   |    26.26 ns |     1.393 ns |   0.076 ns |         - |
| HashSet                                  | O(1)       | RecordClassStrings | 1000   | False   |    28.05 ns |     2.253 ns |   0.123 ns |         - |
| Dictionary                               | O(1)       | RecordClassStrings | 1000   | False   |    28.83 ns |     2.408 ns |   0.132 ns |         - |
| ReadOnlyDictionary                       | O(1)       | RecordClassStrings | 1000   | False   |    31.49 ns |    16.353 ns |   0.896 ns |         - |
| ImmutableDictionary                      | O(1)       | RecordClassStrings | 1000   | False   |    33.48 ns |     2.234 ns |   0.122 ns |         - |
| ImmutableHashSet                         | O(1)       | RecordClassStrings | 1000   | False   |    42.86 ns |     1.952 ns |   0.107 ns |         - |
|                                          |            |                    |        |         |             |              |            |           |
| **FrozenDictionary**                         | **O(1)**       | **RecordClassStrings** | **1000**   | **True**    |    **29.58 ns** |     **1.497 ns** |   **0.082 ns** |         **-** |
| FrozenSet                                | O(1)       | RecordClassStrings | 1000   | True    |    30.00 ns |     4.983 ns |   0.273 ns |         - |
| HashSet                                  | O(1)       | RecordClassStrings | 1000   | True    |    31.74 ns |     2.855 ns |   0.156 ns |         - |
| Dictionary                               | O(1)       | RecordClassStrings | 1000   | True    |    32.38 ns |     3.036 ns |   0.166 ns |         - |
| ReadOnlyDictionary                       | O(1)       | RecordClassStrings | 1000   | True    |    34.29 ns |     9.329 ns |   0.511 ns |         - |
| ImmutableDictionary                      | O(1)       | RecordClassStrings | 1000   | True    |    37.16 ns |     8.882 ns |   0.487 ns |         - |
| ImmutableHashSet                         | O(1)       | RecordClassStrings | 1000   | True    |    46.25 ns |    18.905 ns |   1.036 ns |         - |
|                                          |            |                    |        |         |             |              |            |           |
| **SortedSet**                                | **O(log(N))**  | **RecordClassStrings** | **1000**   | **False**   |   **317.64 ns** |    **38.209 ns** |   **2.094 ns** |         **-** |
| &#39;List (Sorted + BinarySearch)&#39;           | O(log(N))  | RecordClassStrings | 1000   | False   |   323.40 ns |    60.876 ns |   3.337 ns |         - |
| ImmutableSortedSet                       | O(log(N))  | RecordClassStrings | 1000   | False   |   328.30 ns |    51.427 ns |   2.819 ns |         - |
| &#39;ImmutableArray (Sorted + BinarySearch)&#39; | O(log(N))  | RecordClassStrings | 1000   | False   |   329.34 ns |    36.805 ns |   2.017 ns |         - |
| ImmutableSortedDictionary                | O(log(N))  | RecordClassStrings | 1000   | False   |   331.05 ns |    55.125 ns |   3.022 ns |         - |
| SortedList                               | O(log(N))  | RecordClassStrings | 1000   | False   |   336.31 ns |    38.138 ns |   2.090 ns |         - |
| &#39;Array (Sorted + BinarySearch)&#39;          | O(log(N))  | RecordClassStrings | 1000   | False   |   339.42 ns |    77.495 ns |   4.248 ns |         - |
| SortedDictionary                         | O(log(N))  | RecordClassStrings | 1000   | False   |   351.50 ns |    80.959 ns |   4.438 ns |         - |
| &#39;ImmutableList (Sorted + BinarySearch)&#39;  | O(log(N))  | RecordClassStrings | 1000   | False   |   360.58 ns |    25.333 ns |   1.389 ns |         - |
|                                          |            |                    |        |         |             |              |            |           |
| **&#39;Array (Sorted + BinarySearch)&#39;**          | **O(log(N))**  | **RecordClassStrings** | **1000**   | **True**    |   **244.25 ns** |     **8.281 ns** |   **0.454 ns** |         **-** |
| SortedList                               | O(log(N))  | RecordClassStrings | 1000   | True    |   252.07 ns |    18.249 ns |   1.000 ns |         - |
| &#39;ImmutableArray (Sorted + BinarySearch)&#39; | O(log(N))  | RecordClassStrings | 1000   | True    |   252.85 ns |     5.312 ns |   0.291 ns |         - |
| ImmutableSortedSet                       | O(log(N))  | RecordClassStrings | 1000   | True    |   259.55 ns |    41.467 ns |   2.273 ns |         - |
| SortedSet                                | O(log(N))  | RecordClassStrings | 1000   | True    |   267.18 ns |    20.429 ns |   1.120 ns |         - |
| ImmutableSortedDictionary                | O(log(N))  | RecordClassStrings | 1000   | True    |   268.77 ns |    26.501 ns |   1.453 ns |         - |
| &#39;List (Sorted + BinarySearch)&#39;           | O(log(N))  | RecordClassStrings | 1000   | True    |   278.04 ns |    20.006 ns |   1.097 ns |         - |
| &#39;ImmutableList (Sorted + BinarySearch)&#39;  | O(log(N))  | RecordClassStrings | 1000   | True    |   281.55 ns |    19.408 ns |   1.064 ns |         - |
| SortedDictionary                         | O(log(N))  | RecordClassStrings | 1000   | True    |   282.38 ns |    39.371 ns |   2.158 ns |         - |
|                                          |            |                    |        |         |             |              |            |           |
| **ReadOnlyCollection**                       | **O(N)**       | **RecordClassStrings** | **1000**   | **False**   | **4,265.90 ns** | **2,208.460 ns** | **121.053 ns** |         **-** |
| Array                                    | O(N)       | RecordClassStrings | 1000   | False   | 4,688.74 ns |   336.325 ns |  18.435 ns |         - |
| List                                     | O(N)       | RecordClassStrings | 1000   | False   | 4,809.68 ns | 3,317.271 ns | 181.831 ns |         - |
| ImmutableArray                           | O(N)       | RecordClassStrings | 1000   | False   | 5,396.69 ns |   422.152 ns |  23.140 ns |         - |
|                                          |            |                    |        |         |             |              |            |           |
| **ReadOnlyCollection**                       | **O(N)**       | **RecordClassStrings** | **1000**   | **True**    | **1,961.72 ns** |   **474.574 ns** |  **26.013 ns** |         **-** |
| Array                                    | O(N)       | RecordClassStrings | 1000   | True    | 2,276.44 ns |   434.718 ns |  23.828 ns |         - |
| ImmutableArray                           | O(N)       | RecordClassStrings | 1000   | True    | 2,320.26 ns |   733.383 ns |  40.199 ns |         - |
| List                                     | O(N)       | RecordClassStrings | 1000   | True    | 2,511.55 ns |   183.376 ns |  10.051 ns |         - |
