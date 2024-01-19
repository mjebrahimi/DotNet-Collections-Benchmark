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
| **FrozenSet**                                | **O(1)**       | **RecordStructStrings** | **1000**   | **False**   |    **22.32 ns** |     **2.452 ns** |  **0.134 ns** |         **-** |
| FrozenDictionary                         | O(1)       | RecordStructStrings | 1000   | False   |    22.38 ns |     3.151 ns |  0.173 ns |         - |
| Dictionary                               | O(1)       | RecordStructStrings | 1000   | False   |    22.39 ns |     4.397 ns |  0.241 ns |         - |
| HashSet                                  | O(1)       | RecordStructStrings | 1000   | False   |    24.29 ns |     0.759 ns |  0.042 ns |         - |
| ReadOnlyDictionary                       | O(1)       | RecordStructStrings | 1000   | False   |    24.38 ns |     0.777 ns |  0.043 ns |         - |
| ImmutableDictionary                      | O(1)       | RecordStructStrings | 1000   | False   |    25.24 ns |     1.257 ns |  0.069 ns |         - |
| ImmutableHashSet                         | O(1)       | RecordStructStrings | 1000   | False   |    25.47 ns |     1.009 ns |  0.055 ns |         - |
|                                          |            |                     |        |         |             |              |           |           |
| **FrozenDictionary**                         | **O(1)**       | **RecordStructStrings** | **1000**   | **True**    |    **23.84 ns** |     **2.854 ns** |  **0.156 ns** |         **-** |
| FrozenSet                                | O(1)       | RecordStructStrings | 1000   | True    |    24.57 ns |     0.363 ns |  0.020 ns |         - |
| Dictionary                               | O(1)       | RecordStructStrings | 1000   | True    |    24.77 ns |     2.741 ns |  0.150 ns |         - |
| HashSet                                  | O(1)       | RecordStructStrings | 1000   | True    |    25.17 ns |     2.376 ns |  0.130 ns |         - |
| ImmutableDictionary                      | O(1)       | RecordStructStrings | 1000   | True    |    26.29 ns |     2.884 ns |  0.158 ns |         - |
| ImmutableHashSet                         | O(1)       | RecordStructStrings | 1000   | True    |    26.31 ns |     3.953 ns |  0.217 ns |         - |
| ReadOnlyDictionary                       | O(1)       | RecordStructStrings | 1000   | True    |    27.13 ns |     3.893 ns |  0.213 ns |         - |
|                                          |            |                     |        |         |             |              |           |           |
| **&#39;Array (Sorted + BinarySearch)&#39;**          | **O(log(N))**  | **RecordStructStrings** | **1000**   | **False**   |   **292.68 ns** |    **17.684 ns** |  **0.969 ns** |         **-** |
| SortedSet                                | O(log(N))  | RecordStructStrings | 1000   | False   |   297.21 ns |    17.594 ns |  0.964 ns |         - |
| &#39;List (Sorted + BinarySearch)&#39;           | O(log(N))  | RecordStructStrings | 1000   | False   |   307.28 ns |   114.612 ns |  6.282 ns |         - |
| ImmutableSortedSet                       | O(log(N))  | RecordStructStrings | 1000   | False   |   309.88 ns |    25.836 ns |  1.416 ns |         - |
| ImmutableSortedDictionary                | O(log(N))  | RecordStructStrings | 1000   | False   |   310.22 ns |    19.865 ns |  1.089 ns |         - |
| &#39;ImmutableList (Sorted + BinarySearch)&#39;  | O(log(N))  | RecordStructStrings | 1000   | False   |   310.73 ns |    12.765 ns |  0.700 ns |         - |
| &#39;ImmutableArray (Sorted + BinarySearch)&#39; | O(log(N))  | RecordStructStrings | 1000   | False   |   311.06 ns |    21.922 ns |  1.202 ns |         - |
| SortedList                               | O(log(N))  | RecordStructStrings | 1000   | False   |   311.69 ns |    52.478 ns |  2.877 ns |      40 B |
| SortedDictionary                         | O(log(N))  | RecordStructStrings | 1000   | False   |   329.71 ns |    25.492 ns |  1.397 ns |      40 B |
|                                          |            |                     |        |         |             |              |           |           |
| **&#39;List (Sorted + BinarySearch)&#39;**           | **O(log(N))**  | **RecordStructStrings** | **1000**   | **True**    |   **220.86 ns** |    **26.371 ns** |  **1.446 ns** |         **-** |
| &#39;ImmutableArray (Sorted + BinarySearch)&#39; | O(log(N))  | RecordStructStrings | 1000   | True    |   223.43 ns |    14.848 ns |  0.814 ns |         - |
| &#39;Array (Sorted + BinarySearch)&#39;          | O(log(N))  | RecordStructStrings | 1000   | True    |   230.00 ns |    10.977 ns |  0.602 ns |         - |
| SortedList                               | O(log(N))  | RecordStructStrings | 1000   | True    |   237.11 ns |    12.604 ns |  0.691 ns |      40 B |
| ImmutableSortedSet                       | O(log(N))  | RecordStructStrings | 1000   | True    |   238.64 ns |    19.039 ns |  1.044 ns |         - |
| &#39;ImmutableList (Sorted + BinarySearch)&#39;  | O(log(N))  | RecordStructStrings | 1000   | True    |   244.42 ns |    12.420 ns |  0.681 ns |         - |
| SortedSet                                | O(log(N))  | RecordStructStrings | 1000   | True    |   244.64 ns |    34.690 ns |  1.901 ns |         - |
| ImmutableSortedDictionary                | O(log(N))  | RecordStructStrings | 1000   | True    |   249.12 ns |    10.477 ns |  0.574 ns |         - |
| SortedDictionary                         | O(log(N))  | RecordStructStrings | 1000   | True    |   265.08 ns |    82.991 ns |  4.549 ns |      40 B |
|                                          |            |                     |        |         |             |              |           |           |
| **List**                                     | **O(N)**       | **RecordStructStrings** | **1000**   | **False**   | **2,432.59 ns** |    **42.656 ns** |  **2.338 ns** |         **-** |
| ImmutableArray                           | O(N)       | RecordStructStrings | 1000   | False   | 2,706.27 ns |   690.643 ns | 37.856 ns |         - |
| ReadOnlyCollection                       | O(N)       | RecordStructStrings | 1000   | False   | 2,721.37 ns |   987.980 ns | 54.155 ns |         - |
| Array                                    | O(N)       | RecordStructStrings | 1000   | False   | 3,002.75 ns | 1,460.037 ns | 80.030 ns |         - |
|                                          |            |                     |        |         |             |              |           |           |
| **Array**                                    | **O(N)**       | **RecordStructStrings** | **1000**   | **True**    | **1,293.04 ns** |    **67.216 ns** |  **3.684 ns** |         **-** |
| ImmutableArray                           | O(N)       | RecordStructStrings | 1000   | True    | 1,326.56 ns |   365.070 ns | 20.011 ns |         - |
| List                                     | O(N)       | RecordStructStrings | 1000   | True    | 1,409.63 ns |   102.082 ns |  5.595 ns |         - |
| ReadOnlyCollection                       | O(N)       | RecordStructStrings | 1000   | True    | 1,418.92 ns |   225.942 ns | 12.385 ns |         - |
