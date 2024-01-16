```

BenchmarkDotNet v0.13.12, Windows 11 (10.0.22631.3007/23H2/2023Update/SunValley3)
AMD Ryzen 7 5800H with Radeon Graphics, 1 CPU, 16 logical and 8 physical cores
.NET SDK 8.0.101
  [Host]   : .NET 8.0.1 (8.0.123.58001), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.1 (8.0.123.58001), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                                   | Categories | DataType | Length | Existed | Mean      | Error     | StdDev    | Allocated |
|----------------------------------------- |----------- |--------- |------- |-------- |----------:|----------:|----------:|----------:|
| **FrozenSet**                                | **O(1)**       | **Int32**    | **1000**   | **False**   |  **2.017 ns** | **0.1896 ns** | **0.0104 ns** |         **-** |
| FrozenDictionary                         | O(1)       | Int32    | 1000   | False   |  2.030 ns | 0.1221 ns | 0.0067 ns |         - |
| Dictionary                               | O(1)       | Int32    | 1000   | False   |  3.391 ns | 0.5301 ns | 0.0291 ns |         - |
| ReadOnlyDictionary                       | O(1)       | Int32    | 1000   | False   |  3.455 ns | 0.6222 ns | 0.0341 ns |         - |
| HashSet                                  | O(1)       | Int32    | 1000   | False   |  3.481 ns | 0.5842 ns | 0.0320 ns |         - |
| ImmutableDictionary                      | O(1)       | Int32    | 1000   | False   |  7.248 ns | 3.0504 ns | 0.1672 ns |         - |
| ImmutableHashSet                         | O(1)       | Int32    | 1000   | False   |  7.340 ns | 2.7137 ns | 0.1487 ns |         - |
|                                          |            |          |        |         |           |           |           |           |
| **FrozenDictionary**                         | **O(1)**       | **Int32**    | **1000**   | **True**    |  **2.095 ns** | **0.2315 ns** | **0.0127 ns** |         **-** |
| FrozenSet                                | O(1)       | Int32    | 1000   | True    |  2.394 ns | 0.5573 ns | 0.0305 ns |         - |
| HashSet                                  | O(1)       | Int32    | 1000   | True    |  2.853 ns | 0.5433 ns | 0.0298 ns |         - |
| Dictionary                               | O(1)       | Int32    | 1000   | True    |  4.085 ns | 0.1796 ns | 0.0098 ns |         - |
| ReadOnlyDictionary                       | O(1)       | Int32    | 1000   | True    |  4.432 ns | 0.6207 ns | 0.0340 ns |         - |
| ImmutableDictionary                      | O(1)       | Int32    | 1000   | True    |  6.307 ns | 2.3095 ns | 0.1266 ns |         - |
| ImmutableHashSet                         | O(1)       | Int32    | 1000   | True    |  6.315 ns | 0.9480 ns | 0.0520 ns |         - |
|                                          |            |          |        |         |           |           |           |           |
| **SortedSet**                                | **O(log(N))**  | **Int32**    | **1000**   | **False**   | **11.367 ns** | **2.2254 ns** | **0.1220 ns** |         **-** |
| &#39;List (Sorted + BinarySearch)&#39;           | O(log(N))  | Int32    | 1000   | False   | 14.998 ns | 2.6544 ns | 0.1455 ns |         - |
| &#39;Array (Sorted + BinarySearch)&#39;          | O(log(N))  | Int32    | 1000   | False   | 15.383 ns | 2.5442 ns | 0.1395 ns |         - |
| &#39;ImmutableArray (Sorted + BinarySearch)&#39; | O(log(N))  | Int32    | 1000   | False   | 15.764 ns | 0.6891 ns | 0.0378 ns |         - |
| SortedList                               | O(log(N))  | Int32    | 1000   | False   | 16.714 ns | 1.9644 ns | 0.1077 ns |         - |
| SortedDictionary                         | O(log(N))  | Int32    | 1000   | False   | 19.917 ns | 1.2177 ns | 0.0667 ns |         - |
| ImmutableSortedDictionary                | O(log(N))  | Int32    | 1000   | False   | 23.368 ns | 5.7702 ns | 0.3163 ns |         - |
| ImmutableSortedSet                       | O(log(N))  | Int32    | 1000   | False   | 24.754 ns | 3.4614 ns | 0.1897 ns |         - |
| &#39;ImmutableList (Sorted + BinarySearch)&#39;  | O(log(N))  | Int32    | 1000   | False   | 28.555 ns | 0.5529 ns | 0.0303 ns |         - |
|                                          |            |          |        |         |           |           |           |           |
| **SortedSet**                                | **O(log(N))**  | **Int32**    | **1000**   | **True**    | **12.824 ns** | **1.0387 ns** | **0.0569 ns** |         **-** |
| &#39;ImmutableArray (Sorted + BinarySearch)&#39; | O(log(N))  | Int32    | 1000   | True    | 13.101 ns | 1.0020 ns | 0.0549 ns |         - |
| &#39;Array (Sorted + BinarySearch)&#39;          | O(log(N))  | Int32    | 1000   | True    | 13.181 ns | 1.1741 ns | 0.0644 ns |         - |
| SortedList                               | O(log(N))  | Int32    | 1000   | True    | 13.182 ns | 1.1688 ns | 0.0641 ns |         - |
| &#39;List (Sorted + BinarySearch)&#39;           | O(log(N))  | Int32    | 1000   | True    | 13.594 ns | 3.7703 ns | 0.2067 ns |         - |
| ImmutableSortedDictionary                | O(log(N))  | Int32    | 1000   | True    | 18.594 ns | 0.5907 ns | 0.0324 ns |         - |
| ImmutableSortedSet                       | O(log(N))  | Int32    | 1000   | True    | 18.637 ns | 0.7645 ns | 0.0419 ns |         - |
| SortedDictionary                         | O(log(N))  | Int32    | 1000   | True    | 19.448 ns | 3.0688 ns | 0.1682 ns |         - |
| &#39;ImmutableList (Sorted + BinarySearch)&#39;  | O(log(N))  | Int32    | 1000   | True    | 27.142 ns | 3.5470 ns | 0.1944 ns |         - |
|                                          |            |          |        |         |           |           |           |           |
| **Array**                                    | **O(N)**       | **Int32**    | **1000**   | **False**   | **41.027 ns** | **7.8113 ns** | **0.4282 ns** |         **-** |
| ReadOnlyCollection                       | O(N)       | Int32    | 1000   | False   | 42.841 ns | 2.3381 ns | 0.1282 ns |         - |
| List                                     | O(N)       | Int32    | 1000   | False   | 42.976 ns | 8.8244 ns | 0.4837 ns |         - |
| ImmutableArray                           | O(N)       | Int32    | 1000   | False   | 68.369 ns | 6.3947 ns | 0.3505 ns |         - |
|                                          |            |          |        |         |           |           |           |           |
| **Array**                                    | **O(N)**       | **Int32**    | **1000**   | **True**    | **28.672 ns** | **3.1231 ns** | **0.1712 ns** |         **-** |
| List                                     | O(N)       | Int32    | 1000   | True    | 29.101 ns | 8.8553 ns | 0.4854 ns |         - |
| ImmutableArray                           | O(N)       | Int32    | 1000   | True    | 30.060 ns | 1.7139 ns | 0.0939 ns |         - |
| ReadOnlyCollection                       | O(N)       | Int32    | 1000   | True    | 32.001 ns | 3.3766 ns | 0.1851 ns |         - |
