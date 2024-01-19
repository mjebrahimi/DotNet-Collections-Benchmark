```

BenchmarkDotNet v0.13.12, Windows 11 (10.0.22631.3007/23H2/2023Update/SunValley3)
AMD Ryzen 7 5800H with Radeon Graphics, 1 CPU, 16 logical and 8 physical cores
.NET SDK 8.0.101
  [Host]   : .NET 8.0.1 (8.0.123.58001), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.1 (8.0.123.58001), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                                   | Categories | DataType | Length | Existed | Mean         | Error       | StdDev     | Allocated |
|----------------------------------------- |----------- |--------- |------- |-------- |-------------:|------------:|-----------:|----------:|
| **FrozenSet**                                | **O(1)**       | **String**   | **1000**   | **False**   |     **4.308 ns** |   **0.0803 ns** |  **0.0044 ns** |         **-** |
| FrozenDictionary                         | O(1)       | String   | 1000   | False   |     4.405 ns |   0.4932 ns |  0.0270 ns |         - |
| HashSet                                  | O(1)       | String   | 1000   | False   |     6.841 ns |   1.0581 ns |  0.0580 ns |         - |
| Dictionary                               | O(1)       | String   | 1000   | False   |     7.015 ns |   1.8951 ns |  0.1039 ns |         - |
| ReadOnlyDictionary                       | O(1)       | String   | 1000   | False   |     8.961 ns |   2.6484 ns |  0.1452 ns |         - |
| ImmutableDictionary                      | O(1)       | String   | 1000   | False   |    16.405 ns |   2.8413 ns |  0.1557 ns |         - |
| ImmutableHashSet                         | O(1)       | String   | 1000   | False   |    26.570 ns |   3.4740 ns |  0.1904 ns |         - |
|                                          |            |          |        |         |              |             |            |           |
| **FrozenSet**                                | **O(1)**       | **String**   | **1000**   | **True**    |     **4.452 ns** |   **0.1191 ns** |  **0.0065 ns** |         **-** |
| FrozenDictionary                         | O(1)       | String   | 1000   | True    |     4.987 ns |   0.4987 ns |  0.0273 ns |         - |
| HashSet                                  | O(1)       | String   | 1000   | True    |     8.720 ns |   0.2512 ns |  0.0138 ns |         - |
| Dictionary                               | O(1)       | String   | 1000   | True    |     8.825 ns |   1.4643 ns |  0.0803 ns |         - |
| ReadOnlyDictionary                       | O(1)       | String   | 1000   | True    |    11.300 ns |   2.2122 ns |  0.1213 ns |         - |
| ImmutableDictionary                      | O(1)       | String   | 1000   | True    |    21.104 ns |   2.9163 ns |  0.1599 ns |         - |
| ImmutableHashSet                         | O(1)       | String   | 1000   | True    |    28.374 ns |   1.4515 ns |  0.0796 ns |         - |
|                                          |            |          |        |         |              |             |            |           |
| **SortedSet**                                | **O(log(N))**  | **String**   | **1000**   | **False**   |   **307.629 ns** |  **40.8524 ns** |  **2.2393 ns** |         **-** |
| &#39;List (Sorted + BinarySearch)&#39;           | O(log(N))  | String   | 1000   | False   |   312.884 ns |  14.2113 ns |  0.7790 ns |         - |
| &#39;ImmutableArray (Sorted + BinarySearch)&#39; | O(log(N))  | String   | 1000   | False   |   313.269 ns |  57.7894 ns |  3.1676 ns |         - |
| &#39;Array (Sorted + BinarySearch)&#39;          | O(log(N))  | String   | 1000   | False   |   314.854 ns | 105.9571 ns |  5.8079 ns |         - |
| SortedList                               | O(log(N))  | String   | 1000   | False   |   322.710 ns | 107.3378 ns |  5.8835 ns |         - |
| ImmutableSortedSet                       | O(log(N))  | String   | 1000   | False   |   323.908 ns |  61.6276 ns |  3.3780 ns |         - |
| ImmutableSortedDictionary                | O(log(N))  | String   | 1000   | False   |   330.652 ns | 116.2749 ns |  6.3734 ns |         - |
| &#39;ImmutableList (Sorted + BinarySearch)&#39;  | O(log(N))  | String   | 1000   | False   |   356.776 ns |  58.3859 ns |  3.2003 ns |         - |
| SortedDictionary                         | O(log(N))  | String   | 1000   | False   |   361.296 ns | 118.4797 ns |  6.4943 ns |         - |
|                                          |            |          |        |         |              |             |            |           |
| **ImmutableSortedDictionary**                | **O(log(N))**  | **String**   | **1000**   | **True**    |   **241.350 ns** |  **79.5247 ns** |  **4.3590 ns** |         **-** |
| ImmutableSortedSet                       | O(log(N))  | String   | 1000   | True    |   248.392 ns |  79.2214 ns |  4.3424 ns |         - |
| &#39;ImmutableList (Sorted + BinarySearch)&#39;  | O(log(N))  | String   | 1000   | True    |   264.561 ns |  56.0615 ns |  3.0729 ns |         - |
| &#39;List (Sorted + BinarySearch)&#39;           | O(log(N))  | String   | 1000   | True    |   266.752 ns |  27.9816 ns |  1.5338 ns |         - |
| &#39;ImmutableArray (Sorted + BinarySearch)&#39; | O(log(N))  | String   | 1000   | True    |   267.570 ns |  31.6018 ns |  1.7322 ns |         - |
| &#39;Array (Sorted + BinarySearch)&#39;          | O(log(N))  | String   | 1000   | True    |   268.204 ns | 102.9788 ns |  5.6446 ns |         - |
| SortedList                               | O(log(N))  | String   | 1000   | True    |   271.979 ns |  22.9028 ns |  1.2554 ns |         - |
| SortedSet                                | O(log(N))  | String   | 1000   | True    |   272.019 ns |  76.0691 ns |  4.1696 ns |         - |
| SortedDictionary                         | O(log(N))  | String   | 1000   | True    |   280.641 ns |  10.9002 ns |  0.5975 ns |         - |
|                                          |            |          |        |         |              |             |            |           |
| **ReadOnlyCollection**                       | **O(N)**       | **String**   | **1000**   | **False**   | **2,851.432 ns** | **683.4577 ns** | **37.4626 ns** |         **-** |
| List                                     | O(N)       | String   | 1000   | False   | 3,747.693 ns | 485.0937 ns | 26.5896 ns |         - |
| ImmutableArray                           | O(N)       | String   | 1000   | False   | 4,042.309 ns | 569.2436 ns | 31.2022 ns |         - |
| Array                                    | O(N)       | String   | 1000   | False   | 4,171.897 ns | 475.1176 ns | 26.0428 ns |         - |
|                                          |            |          |        |         |              |             |            |           |
| **ReadOnlyCollection**                       | **O(N)**       | **String**   | **1000**   | **True**    | **1,392.430 ns** |  **60.8564 ns** |  **3.3357 ns** |         **-** |
| List                                     | O(N)       | String   | 1000   | True    | 1,836.948 ns |  69.8249 ns |  3.8273 ns |         - |
| Array                                    | O(N)       | String   | 1000   | True    | 1,838.527 ns | 646.2116 ns | 35.4210 ns |         - |
| ImmutableArray                           | O(N)       | String   | 1000   | True    | 1,869.762 ns | 776.7829 ns | 42.5781 ns |         - |
