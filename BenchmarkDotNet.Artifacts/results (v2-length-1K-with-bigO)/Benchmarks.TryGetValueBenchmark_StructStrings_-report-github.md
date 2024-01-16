```

BenchmarkDotNet v0.13.12, Windows 11 (10.0.22631.3007/23H2/2023Update/SunValley3)
AMD Ryzen 7 5800H with Radeon Graphics, 1 CPU, 16 logical and 8 physical cores
.NET SDK 8.0.101
  [Host]   : .NET 8.0.1 (8.0.123.58001), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.1 (8.0.123.58001), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                                   | Categories | DataType      | Length | Existed | Mean          | Error         | StdDev     | Allocated |
|----------------------------------------- |----------- |-------------- |------- |-------- |--------------:|--------------:|-----------:|----------:|
| **Dictionary**                               | **O(1)**       | **StructStrings** | **1000**   | **False**   |      **51.74 ns** |      **1.866 ns** |   **0.102 ns** |      **40 B** |
| FrozenSet                                | O(1)       | StructStrings | 1000   | False   |      55.73 ns |      7.313 ns |   0.401 ns |      40 B |
| FrozenDictionary                         | O(1)       | StructStrings | 1000   | False   |      56.43 ns |     11.621 ns |   0.637 ns |      40 B |
| HashSet                                  | O(1)       | StructStrings | 1000   | False   |      57.58 ns |      2.429 ns |   0.133 ns |      40 B |
| ImmutableHashSet                         | O(1)       | StructStrings | 1000   | False   |      60.33 ns |      4.073 ns |   0.223 ns |      40 B |
| ImmutableDictionary                      | O(1)       | StructStrings | 1000   | False   |      62.28 ns |      1.738 ns |   0.095 ns |      40 B |
| ReadOnlyDictionary                       | O(1)       | StructStrings | 1000   | False   |      64.18 ns |     14.072 ns |   0.771 ns |      40 B |
|                                          |            |               |        |         |               |               |            |           |
| **ReadOnlyDictionary**                       | **O(1)**       | **StructStrings** | **1000**   | **True**    |     **267.79 ns** |     **21.585 ns** |   **1.183 ns** |     **168 B** |
| Dictionary                               | O(1)       | StructStrings | 1000   | True    |     269.36 ns |     29.235 ns |   1.602 ns |     168 B |
| HashSet                                  | O(1)       | StructStrings | 1000   | True    |     271.28 ns |     29.764 ns |   1.631 ns |     168 B |
| FrozenSet                                | O(1)       | StructStrings | 1000   | True    |     277.42 ns |     23.393 ns |   1.282 ns |     168 B |
| FrozenDictionary                         | O(1)       | StructStrings | 1000   | True    |     278.40 ns |     33.746 ns |   1.850 ns |     168 B |
| ImmutableHashSet                         | O(1)       | StructStrings | 1000   | True    |     279.63 ns |     17.725 ns |   0.972 ns |     168 B |
| ImmutableDictionary                      | O(1)       | StructStrings | 1000   | True    |     286.65 ns |     67.566 ns |   3.703 ns |     168 B |
|                                          |            |               |        |         |               |               |            |           |
| **&#39;ImmutableArray (Sorted + BinarySearch)&#39;** | **O(log(N))**  | **StructStrings** | **1000**   | **False**   |     **293.73 ns** |     **21.781 ns** |   **1.194 ns** |         **-** |
| SortedSet                                | O(log(N))  | StructStrings | 1000   | False   |     295.38 ns |     57.149 ns |   3.133 ns |         - |
| &#39;Array (Sorted + BinarySearch)&#39;          | O(log(N))  | StructStrings | 1000   | False   |     299.34 ns |     52.555 ns |   2.881 ns |         - |
| ImmutableSortedSet                       | O(log(N))  | StructStrings | 1000   | False   |     310.70 ns |     30.979 ns |   1.698 ns |         - |
| SortedList                               | O(log(N))  | StructStrings | 1000   | False   |     310.73 ns |     12.427 ns |   0.681 ns |      40 B |
| &#39;List (Sorted + BinarySearch)&#39;           | O(log(N))  | StructStrings | 1000   | False   |     312.10 ns |     37.329 ns |   2.046 ns |         - |
| SortedDictionary                         | O(log(N))  | StructStrings | 1000   | False   |     325.09 ns |     12.360 ns |   0.678 ns |      40 B |
| &#39;ImmutableList (Sorted + BinarySearch)&#39;  | O(log(N))  | StructStrings | 1000   | False   |     343.91 ns |     11.050 ns |   0.606 ns |         - |
| ImmutableSortedDictionary                | O(log(N))  | StructStrings | 1000   | False   |     351.23 ns |    144.013 ns |   7.894 ns |         - |
|                                          |            |               |        |         |               |               |            |           |
| **&#39;Array (Sorted + BinarySearch)&#39;**          | **O(log(N))**  | **StructStrings** | **1000**   | **True**    |     **222.51 ns** |     **10.986 ns** |   **0.602 ns** |         **-** |
| &#39;ImmutableArray (Sorted + BinarySearch)&#39; | O(log(N))  | StructStrings | 1000   | True    |     225.38 ns |     43.222 ns |   2.369 ns |         - |
| SortedList                               | O(log(N))  | StructStrings | 1000   | True    |     237.37 ns |     34.316 ns |   1.881 ns |      40 B |
| ImmutableSortedSet                       | O(log(N))  | StructStrings | 1000   | True    |     239.16 ns |     20.037 ns |   1.098 ns |         - |
| ImmutableSortedDictionary                | O(log(N))  | StructStrings | 1000   | True    |     243.21 ns |     16.205 ns |   0.888 ns |         - |
| SortedSet                                | O(log(N))  | StructStrings | 1000   | True    |     246.11 ns |     35.276 ns |   1.934 ns |         - |
| &#39;List (Sorted + BinarySearch)&#39;           | O(log(N))  | StructStrings | 1000   | True    |     247.74 ns |     29.818 ns |   1.634 ns |         - |
| &#39;ImmutableList (Sorted + BinarySearch)&#39;  | O(log(N))  | StructStrings | 1000   | True    |     249.16 ns |     29.421 ns |   1.613 ns |         - |
| SortedDictionary                         | O(log(N))  | StructStrings | 1000   | True    |     258.40 ns |     32.542 ns |   1.784 ns |      40 B |
|                                          |            |               |        |         |               |               |            |           |
| **Array**                                    | **O(N)**       | **StructStrings** | **1000**   | **False**   | **108,295.13 ns** |  **5,390.437 ns** | **295.468 ns** |  **128001 B** |
| ImmutableArray                           | O(N)       | StructStrings | 1000   | False   | 111,003.80 ns | 13,718.116 ns | 751.936 ns |  128001 B |
| List                                     | O(N)       | StructStrings | 1000   | False   | 112,553.83 ns | 17,199.979 ns | 942.789 ns |  128001 B |
| ReadOnlyCollection                       | O(N)       | StructStrings | 1000   | False   | 118,003.93 ns | 14,602.921 ns | 800.435 ns |  128000 B |
|                                          |            |               |        |         |               |               |            |           |
| **Array**                                    | **O(N)**       | **StructStrings** | **1000**   | **True**    |  **52,177.49 ns** |  **6,342.185 ns** | **347.637 ns** |   **61441 B** |
| ReadOnlyCollection                       | O(N)       | StructStrings | 1000   | True    |  53,090.26 ns |  9,446.782 ns | 517.810 ns |   61441 B |
| ImmutableArray                           | O(N)       | StructStrings | 1000   | True    |  53,316.98 ns |  2,918.216 ns | 159.957 ns |   61441 B |
| List                                     | O(N)       | StructStrings | 1000   | True    |  55,667.07 ns | 14,518.007 ns | 795.781 ns |   61441 B |
