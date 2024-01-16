```

BenchmarkDotNet v0.13.12, Windows 11 (10.0.22631.3007/23H2/2023Update/SunValley3)
AMD Ryzen 7 5800H with Radeon Graphics, 1 CPU, 16 logical and 8 physical cores
.NET SDK 8.0.101
  [Host]   : .NET 8.0.1 (8.0.123.58001), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.1 (8.0.123.58001), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                                   | Categories | DataType  | Length | Existed | Mean         | Error       | StdDev     | Allocated |
|----------------------------------------- |----------- |---------- |------- |-------- |-------------:|------------:|-----------:|----------:|
| **FrozenSet**                                | **O(1)**       | **ClassInts** | **1000**   | **False**   |     **3.816 ns** |   **0.3439 ns** |  **0.0188 ns** |         **-** |
| FrozenDictionary                         | O(1)       | ClassInts | 1000   | False   |     3.970 ns |   0.8071 ns |  0.0442 ns |         - |
| Dictionary                               | O(1)       | ClassInts | 1000   | False   |     5.605 ns |   0.5061 ns |  0.0277 ns |         - |
| HashSet                                  | O(1)       | ClassInts | 1000   | False   |     5.896 ns |   0.8437 ns |  0.0462 ns |         - |
| ReadOnlyDictionary                       | O(1)       | ClassInts | 1000   | False   |     7.707 ns |   0.5068 ns |  0.0278 ns |         - |
| ImmutableDictionary                      | O(1)       | ClassInts | 1000   | False   |    10.967 ns |   0.5921 ns |  0.0325 ns |         - |
| ImmutableHashSet                         | O(1)       | ClassInts | 1000   | False   |    24.802 ns |   2.6348 ns |  0.1444 ns |         - |
|                                          |            |           |        |         |              |             |            |           |
| **FrozenSet**                                | **O(1)**       | **ClassInts** | **1000**   | **True**    |     **7.293 ns** |   **0.9093 ns** |  **0.0498 ns** |         **-** |
| FrozenDictionary                         | O(1)       | ClassInts | 1000   | True    |     7.667 ns |   2.8821 ns |  0.1580 ns |         - |
| HashSet                                  | O(1)       | ClassInts | 1000   | True    |     9.332 ns |   0.7328 ns |  0.0402 ns |         - |
| Dictionary                               | O(1)       | ClassInts | 1000   | True    |    10.268 ns |   1.6772 ns |  0.0919 ns |         - |
| ReadOnlyDictionary                       | O(1)       | ClassInts | 1000   | True    |    11.855 ns |   2.1780 ns |  0.1194 ns |         - |
| ImmutableDictionary                      | O(1)       | ClassInts | 1000   | True    |    17.843 ns |   4.8202 ns |  0.2642 ns |         - |
| ImmutableHashSet                         | O(1)       | ClassInts | 1000   | True    |    28.555 ns |   3.5986 ns |  0.1973 ns |         - |
|                                          |            |           |        |         |              |             |            |           |
| **&#39;Array (Sorted + BinarySearch)&#39;**          | **O(log(N))**  | **ClassInts** | **1000**   | **False**   |    **36.756 ns** |   **7.9028 ns** |  **0.4332 ns** |         **-** |
| &#39;List (Sorted + BinarySearch)&#39;           | O(log(N))  | ClassInts | 1000   | False   |    37.883 ns |  12.6570 ns |  0.6938 ns |         - |
| &#39;ImmutableArray (Sorted + BinarySearch)&#39; | O(log(N))  | ClassInts | 1000   | False   |    39.942 ns |   1.4205 ns |  0.0779 ns |         - |
| SortedSet                                | O(log(N))  | ClassInts | 1000   | False   |    40.534 ns |  11.2143 ns |  0.6147 ns |         - |
| SortedList                               | O(log(N))  | ClassInts | 1000   | False   |    46.525 ns |  12.5093 ns |  0.6857 ns |         - |
| ImmutableSortedDictionary                | O(log(N))  | ClassInts | 1000   | False   |    50.695 ns |   1.1834 ns |  0.0649 ns |         - |
| ImmutableSortedSet                       | O(log(N))  | ClassInts | 1000   | False   |    52.178 ns |   2.5300 ns |  0.1387 ns |         - |
| SortedDictionary                         | O(log(N))  | ClassInts | 1000   | False   |    63.056 ns |  10.0247 ns |  0.5495 ns |         - |
| &#39;ImmutableList (Sorted + BinarySearch)&#39;  | O(log(N))  | ClassInts | 1000   | False   |    77.122 ns |  19.9195 ns |  1.0919 ns |         - |
|                                          |            |           |        |         |              |             |            |           |
| **&#39;Array (Sorted + BinarySearch)&#39;**          | **O(log(N))**  | **ClassInts** | **1000**   | **True**    |    **36.618 ns** |   **2.7424 ns** |  **0.1503 ns** |         **-** |
| &#39;List (Sorted + BinarySearch)&#39;           | O(log(N))  | ClassInts | 1000   | True    |    37.077 ns |  11.5146 ns |  0.6312 ns |         - |
| SortedSet                                | O(log(N))  | ClassInts | 1000   | True    |    37.702 ns |   8.5544 ns |  0.4689 ns |         - |
| &#39;ImmutableArray (Sorted + BinarySearch)&#39; | O(log(N))  | ClassInts | 1000   | True    |    39.211 ns |   1.6640 ns |  0.0912 ns |         - |
| ImmutableSortedSet                       | O(log(N))  | ClassInts | 1000   | True    |    41.586 ns |   6.6197 ns |  0.3628 ns |         - |
| ImmutableSortedDictionary                | O(log(N))  | ClassInts | 1000   | True    |    42.858 ns |   3.6642 ns |  0.2008 ns |         - |
| SortedList                               | O(log(N))  | ClassInts | 1000   | True    |    43.436 ns |   6.7912 ns |  0.3722 ns |         - |
| SortedDictionary                         | O(log(N))  | ClassInts | 1000   | True    |    58.380 ns |   2.8560 ns |  0.1565 ns |         - |
| &#39;ImmutableList (Sorted + BinarySearch)&#39;  | O(log(N))  | ClassInts | 1000   | True    |    64.249 ns |   3.4480 ns |  0.1890 ns |         - |
|                                          |            |           |        |         |              |             |            |           |
| **ReadOnlyCollection**                       | **O(N)**       | **ClassInts** | **1000**   | **False**   |   **773.154 ns** | **161.5290 ns** |  **8.8539 ns** |         **-** |
| Array                                    | O(N)       | ClassInts | 1000   | False   | 1,495.015 ns | 156.0190 ns |  8.5519 ns |         - |
| List                                     | O(N)       | ClassInts | 1000   | False   | 1,734.703 ns | 135.2084 ns |  7.4112 ns |         - |
| ImmutableArray                           | O(N)       | ClassInts | 1000   | False   | 1,762.379 ns | 452.0526 ns | 24.7785 ns |         - |
|                                          |            |           |        |         |              |             |            |           |
| **ReadOnlyCollection**                       | **O(N)**       | **ClassInts** | **1000**   | **True**    |   **378.222 ns** |  **92.7520 ns** |  **5.0840 ns** |         **-** |
| Array                                    | O(N)       | ClassInts | 1000   | True    |   722.915 ns |  62.4702 ns |  3.4242 ns |         - |
| List                                     | O(N)       | ClassInts | 1000   | True    |   841.805 ns | 201.8899 ns | 11.0663 ns |         - |
| ImmutableArray                           | O(N)       | ClassInts | 1000   | True    |   850.812 ns | 122.4955 ns |  6.7144 ns |         - |
