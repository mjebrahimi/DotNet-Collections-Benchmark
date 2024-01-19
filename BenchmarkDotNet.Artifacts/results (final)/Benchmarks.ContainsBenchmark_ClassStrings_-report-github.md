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
| **FrozenSet**                                | **O(1)**       | **ClassStrings** | **1000**   | **False**   |    **23.75 ns** |     **2.486 ns** |  **0.136 ns** |         **-** |
| FrozenDictionary                         | O(1)       | ClassStrings | 1000   | False   |    23.77 ns |     2.596 ns |  0.142 ns |         - |
| HashSet                                  | O(1)       | ClassStrings | 1000   | False   |    25.09 ns |     3.944 ns |  0.216 ns |         - |
| Dictionary                               | O(1)       | ClassStrings | 1000   | False   |    26.48 ns |     2.090 ns |  0.115 ns |         - |
| ReadOnlyDictionary                       | O(1)       | ClassStrings | 1000   | False   |    27.76 ns |     1.982 ns |  0.109 ns |         - |
| ImmutableDictionary                      | O(1)       | ClassStrings | 1000   | False   |    30.32 ns |     2.906 ns |  0.159 ns |         - |
| ImmutableHashSet                         | O(1)       | ClassStrings | 1000   | False   |    40.72 ns |    10.356 ns |  0.568 ns |         - |
|                                          |            |              |        |         |             |              |           |           |
| **FrozenSet**                                | **O(1)**       | **ClassStrings** | **1000**   | **True**    |    **27.47 ns** |     **1.917 ns** |  **0.105 ns** |         **-** |
| FrozenDictionary                         | O(1)       | ClassStrings | 1000   | True    |    27.90 ns |     1.254 ns |  0.069 ns |         - |
| Dictionary                               | O(1)       | ClassStrings | 1000   | True    |    29.96 ns |     2.548 ns |  0.140 ns |         - |
| HashSet                                  | O(1)       | ClassStrings | 1000   | True    |    30.39 ns |     3.248 ns |  0.178 ns |         - |
| ReadOnlyDictionary                       | O(1)       | ClassStrings | 1000   | True    |    32.11 ns |     4.866 ns |  0.267 ns |         - |
| ImmutableDictionary                      | O(1)       | ClassStrings | 1000   | True    |    34.77 ns |     2.034 ns |  0.111 ns |         - |
| ImmutableHashSet                         | O(1)       | ClassStrings | 1000   | True    |    45.61 ns |     7.597 ns |  0.416 ns |         - |
|                                          |            |              |        |         |             |              |           |           |
| **&#39;List (Sorted + BinarySearch)&#39;**           | **O(log(N))**  | **ClassStrings** | **1000**   | **False**   |   **318.19 ns** |    **40.186 ns** |  **2.203 ns** |         **-** |
| SortedSet                                | O(log(N))  | ClassStrings | 1000   | False   |   318.67 ns |    34.975 ns |  1.917 ns |         - |
| &#39;Array (Sorted + BinarySearch)&#39;          | O(log(N))  | ClassStrings | 1000   | False   |   320.15 ns |    20.158 ns |  1.105 ns |         - |
| &#39;ImmutableArray (Sorted + BinarySearch)&#39; | O(log(N))  | ClassStrings | 1000   | False   |   326.21 ns |    57.223 ns |  3.137 ns |         - |
| SortedList                               | O(log(N))  | ClassStrings | 1000   | False   |   327.96 ns |    21.865 ns |  1.199 ns |         - |
| ImmutableSortedDictionary                | O(log(N))  | ClassStrings | 1000   | False   |   332.48 ns |   108.409 ns |  5.942 ns |         - |
| ImmutableSortedSet                       | O(log(N))  | ClassStrings | 1000   | False   |   333.72 ns |    22.293 ns |  1.222 ns |         - |
| SortedDictionary                         | O(log(N))  | ClassStrings | 1000   | False   |   364.69 ns |    68.964 ns |  3.780 ns |         - |
| &#39;ImmutableList (Sorted + BinarySearch)&#39;  | O(log(N))  | ClassStrings | 1000   | False   |   366.50 ns |    47.879 ns |  2.624 ns |         - |
|                                          |            |              |        |         |             |              |           |           |
| **&#39;ImmutableArray (Sorted + BinarySearch)&#39;** | **O(log(N))**  | **ClassStrings** | **1000**   | **True**    |   **246.53 ns** |    **19.237 ns** |  **1.054 ns** |         **-** |
| &#39;Array (Sorted + BinarySearch)&#39;          | O(log(N))  | ClassStrings | 1000   | True    |   247.97 ns |    40.149 ns |  2.201 ns |         - |
| &#39;List (Sorted + BinarySearch)&#39;           | O(log(N))  | ClassStrings | 1000   | True    |   252.79 ns |    63.682 ns |  3.491 ns |         - |
| ImmutableSortedSet                       | O(log(N))  | ClassStrings | 1000   | True    |   253.33 ns |    65.397 ns |  3.585 ns |         - |
| SortedList                               | O(log(N))  | ClassStrings | 1000   | True    |   259.50 ns |    16.546 ns |  0.907 ns |         - |
| SortedSet                                | O(log(N))  | ClassStrings | 1000   | True    |   266.93 ns |    64.864 ns |  3.555 ns |         - |
| SortedDictionary                         | O(log(N))  | ClassStrings | 1000   | True    |   278.50 ns |    79.701 ns |  4.369 ns |         - |
| ImmutableSortedDictionary                | O(log(N))  | ClassStrings | 1000   | True    |   290.57 ns |    22.471 ns |  1.232 ns |         - |
| &#39;ImmutableList (Sorted + BinarySearch)&#39;  | O(log(N))  | ClassStrings | 1000   | True    |   290.76 ns |    17.907 ns |  0.982 ns |         - |
|                                          |            |              |        |         |             |              |           |           |
| **ReadOnlyCollection**                       | **O(N)**       | **ClassStrings** | **1000**   | **False**   |   **791.51 ns** |   **141.688 ns** |  **7.766 ns** |         **-** |
| ImmutableArray                           | O(N)       | ClassStrings | 1000   | False   | 3,974.60 ns |   342.106 ns | 18.752 ns |         - |
| List                                     | O(N)       | ClassStrings | 1000   | False   | 4,067.15 ns | 1,557.257 ns | 85.359 ns |         - |
| Array                                    | O(N)       | ClassStrings | 1000   | False   | 4,236.23 ns |   505.064 ns | 27.684 ns |         - |
|                                          |            |              |        |         |             |              |           |           |
| **ReadOnlyCollection**                       | **O(N)**       | **ClassStrings** | **1000**   | **True**    |   **392.40 ns** |    **62.709 ns** |  **3.437 ns** |         **-** |
| ImmutableArray                           | O(N)       | ClassStrings | 1000   | True    | 1,914.95 ns |   127.458 ns |  6.986 ns |         - |
| Array                                    | O(N)       | ClassStrings | 1000   | True    | 1,930.61 ns |   353.032 ns | 19.351 ns |         - |
| List                                     | O(N)       | ClassStrings | 1000   | True    | 1,995.30 ns | 1,130.778 ns | 61.982 ns |         - |
