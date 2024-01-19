```

BenchmarkDotNet v0.13.12, Windows 11 (10.0.22631.3007/23H2/2023Update/SunValley3)
AMD Ryzen 7 5800H with Radeon Graphics, 1 CPU, 16 logical and 8 physical cores
.NET SDK 8.0.101
  [Host]   : .NET 8.0.1 (8.0.123.58001), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.1 (8.0.123.58001), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                                   | Categories | DataType   | Length | Existed | Mean         | Error         | StdDev     | Allocated |
|----------------------------------------- |----------- |----------- |------- |-------- |-------------:|--------------:|-----------:|----------:|
| **Dictionary**                               | **O(1)**       | **StructInts** | **1000**   | **False**   |     **19.37 ns** |      **4.722 ns** |   **0.259 ns** |      **32 B** |
| FrozenDictionary                         | O(1)       | StructInts | 1000   | False   |     19.79 ns |      7.674 ns |   0.421 ns |      32 B |
| FrozenSet                                | O(1)       | StructInts | 1000   | False   |     20.44 ns |      3.003 ns |   0.165 ns |      32 B |
| HashSet                                  | O(1)       | StructInts | 1000   | False   |     22.08 ns |      0.575 ns |   0.031 ns |      32 B |
| ImmutableDictionary                      | O(1)       | StructInts | 1000   | False   |     26.32 ns |      5.736 ns |   0.314 ns |      32 B |
| ImmutableHashSet                         | O(1)       | StructInts | 1000   | False   |     27.27 ns |      5.036 ns |   0.276 ns |      32 B |
| ReadOnlyDictionary                       | O(1)       | StructInts | 1000   | False   |     33.32 ns |      8.021 ns |   0.440 ns |      32 B |
|                                          |            |            |        |         |              |               |            |           |
| **FrozenDictionary**                         | **O(1)**       | **StructInts** | **1000**   | **True**    |     **34.89 ns** |      **4.106 ns** |   **0.225 ns** |      **96 B** |
| Dictionary                               | O(1)       | StructInts | 1000   | True    |     35.81 ns |      5.208 ns |   0.285 ns |      96 B |
| HashSet                                  | O(1)       | StructInts | 1000   | True    |     36.13 ns |     21.056 ns |   1.154 ns |      96 B |
| ReadOnlyDictionary                       | O(1)       | StructInts | 1000   | True    |     39.45 ns |     20.077 ns |   1.101 ns |      96 B |
| ImmutableHashSet                         | O(1)       | StructInts | 1000   | True    |     39.89 ns |     15.302 ns |   0.839 ns |      96 B |
| ImmutableDictionary                      | O(1)       | StructInts | 1000   | True    |     40.20 ns |     20.036 ns |   1.098 ns |      96 B |
| FrozenSet                                | O(1)       | StructInts | 1000   | True    |     45.59 ns |     18.131 ns |   0.994 ns |      96 B |
|                                          |            |            |        |         |              |               |            |           |
| **SortedSet**                                | **O(log(N))**  | **StructInts** | **1000**   | **False**   |     **12.72 ns** |      **5.499 ns** |   **0.301 ns** |         **-** |
| &#39;List (Sorted + BinarySearch)&#39;           | O(log(N))  | StructInts | 1000   | False   |     19.01 ns |      1.381 ns |   0.076 ns |         - |
| &#39;ImmutableArray (Sorted + BinarySearch)&#39; | O(log(N))  | StructInts | 1000   | False   |     19.09 ns |      1.804 ns |   0.099 ns |         - |
| &#39;Array (Sorted + BinarySearch)&#39;          | O(log(N))  | StructInts | 1000   | False   |     19.36 ns |      7.034 ns |   0.386 ns |         - |
| SortedList                               | O(log(N))  | StructInts | 1000   | False   |     23.61 ns |      1.590 ns |   0.087 ns |      32 B |
| SortedDictionary                         | O(log(N))  | StructInts | 1000   | False   |     27.48 ns |      2.739 ns |   0.150 ns |      32 B |
| &#39;ImmutableList (Sorted + BinarySearch)&#39;  | O(log(N))  | StructInts | 1000   | False   |     36.04 ns |      9.127 ns |   0.500 ns |         - |
| ImmutableSortedSet                       | O(log(N))  | StructInts | 1000   | False   |     36.35 ns |      0.942 ns |   0.052 ns |         - |
| ImmutableSortedDictionary                | O(log(N))  | StructInts | 1000   | False   |     36.37 ns |      3.093 ns |   0.170 ns |         - |
|                                          |            |            |        |         |              |               |            |           |
| **SortedSet**                                | **O(log(N))**  | **StructInts** | **1000**   | **True**    |     **18.54 ns** |      **3.569 ns** |   **0.196 ns** |         **-** |
| &#39;ImmutableArray (Sorted + BinarySearch)&#39; | O(log(N))  | StructInts | 1000   | True    |     20.32 ns |      1.372 ns |   0.075 ns |         - |
| &#39;Array (Sorted + BinarySearch)&#39;          | O(log(N))  | StructInts | 1000   | True    |     20.34 ns |      5.513 ns |   0.302 ns |         - |
| &#39;List (Sorted + BinarySearch)&#39;           | O(log(N))  | StructInts | 1000   | True    |     20.60 ns |      2.491 ns |   0.137 ns |         - |
| SortedList                               | O(log(N))  | StructInts | 1000   | True    |     26.04 ns |      0.961 ns |   0.053 ns |      32 B |
| ImmutableSortedDictionary                | O(log(N))  | StructInts | 1000   | True    |     26.37 ns |      6.991 ns |   0.383 ns |         - |
| SortedDictionary                         | O(log(N))  | StructInts | 1000   | True    |     27.64 ns |      4.194 ns |   0.230 ns |      32 B |
| ImmutableSortedSet                       | O(log(N))  | StructInts | 1000   | True    |     29.35 ns |      2.403 ns |   0.132 ns |         - |
| &#39;ImmutableList (Sorted + BinarySearch)&#39;  | O(log(N))  | StructInts | 1000   | True    |     31.13 ns |      6.216 ns |   0.341 ns |         - |
|                                          |            |            |        |         |              |               |            |           |
| **ReadOnlyCollection**                       | **O(N)**       | **StructInts** | **1000**   | **False**   | **12,254.54 ns** | **12,885.831 ns** | **706.316 ns** |   **64000 B** |
| Array                                    | O(N)       | StructInts | 1000   | False   | 12,541.77 ns | 16,640.837 ns | 912.140 ns |   64000 B |
| List                                     | O(N)       | StructInts | 1000   | False   | 12,764.38 ns | 10,572.542 ns | 579.517 ns |   64000 B |
| ImmutableArray                           | O(N)       | StructInts | 1000   | False   | 12,889.71 ns | 12,221.754 ns | 669.916 ns |   64000 B |
|                                          |            |            |        |         |              |               |            |           |
| **List**                                     | **O(N)**       | **StructInts** | **1000**   | **True**    |  **6,091.29 ns** |  **5,640.174 ns** | **309.157 ns** |   **30901 B** |
| ReadOnlyCollection                       | O(N)       | StructInts | 1000   | True    |  6,179.42 ns |  5,716.694 ns | 313.351 ns |   30901 B |
| Array                                    | O(N)       | StructInts | 1000   | True    |  6,261.18 ns |  7,441.955 ns | 407.919 ns |   30901 B |
| ImmutableArray                           | O(N)       | StructInts | 1000   | True    |  6,350.76 ns |  8,862.417 ns | 485.779 ns |   30901 B |
