```

BenchmarkDotNet v0.13.12, Windows 11 (10.0.22631.3007/23H2/2023Update/SunValley3)
AMD Ryzen 7 5800H with Radeon Graphics, 1 CPU, 16 logical and 8 physical cores
.NET SDK 8.0.101
  [Host]   : .NET 8.0.1 (8.0.123.58001), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.1 (8.0.123.58001), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                                   | Categories | DataType        | Length | Existed | Mean         | Error       | StdDev     | Allocated |
|----------------------------------------- |----------- |---------------- |------- |-------- |-------------:|------------:|-----------:|----------:|
| **FrozenDictionary**                         | **O(1)**       | **RecordClassInts** | **1000**   | **False**   |     **5.194 ns** |   **0.7240 ns** |  **0.0397 ns** |         **-** |
| HashSet                                  | O(1)       | RecordClassInts | 1000   | False   |     7.548 ns |   1.1088 ns |  0.0608 ns |         - |
| Dictionary                               | O(1)       | RecordClassInts | 1000   | False   |     7.600 ns |   0.4069 ns |  0.0223 ns |         - |
| FrozenSet                                | O(1)       | RecordClassInts | 1000   | False   |     8.372 ns |   2.3347 ns |  0.1280 ns |         - |
| ReadOnlyDictionary                       | O(1)       | RecordClassInts | 1000   | False   |    10.164 ns |   0.2854 ns |  0.0156 ns |         - |
| ImmutableHashSet                         | O(1)       | RecordClassInts | 1000   | False   |    12.355 ns |  22.2775 ns |  1.2211 ns |         - |
| ImmutableDictionary                      | O(1)       | RecordClassInts | 1000   | False   |    12.672 ns |   1.4525 ns |  0.0796 ns |         - |
|                                          |            |                 |        |         |              |             |            |           |
| **FrozenDictionary**                         | **O(1)**       | **RecordClassInts** | **1000**   | **True**    |     **9.072 ns** |   **1.9789 ns** |  **0.1085 ns** |         **-** |
| Dictionary                               | O(1)       | RecordClassInts | 1000   | True    |    10.990 ns |   1.1794 ns |  0.0646 ns |         - |
| HashSet                                  | O(1)       | RecordClassInts | 1000   | True    |    11.522 ns |   0.1271 ns |  0.0070 ns |         - |
| ReadOnlyDictionary                       | O(1)       | RecordClassInts | 1000   | True    |    14.022 ns |   3.9835 ns |  0.2183 ns |         - |
| FrozenSet                                | O(1)       | RecordClassInts | 1000   | True    |    15.024 ns |   2.8637 ns |  0.1570 ns |         - |
| ImmutableHashSet                         | O(1)       | RecordClassInts | 1000   | True    |    17.343 ns |   1.9307 ns |  0.1058 ns |         - |
| ImmutableDictionary                      | O(1)       | RecordClassInts | 1000   | True    |    18.683 ns |   0.2690 ns |  0.0147 ns |         - |
|                                          |            |                 |        |         |              |             |            |           |
| **&#39;List (Sorted + BinarySearch)&#39;**           | **O(log(N))**  | **RecordClassInts** | **1000**   | **False**   |    **35.829 ns** |   **4.2373 ns** |  **0.2323 ns** |         **-** |
| &#39;ImmutableArray (Sorted + BinarySearch)&#39; | O(log(N))  | RecordClassInts | 1000   | False   |    37.963 ns |   5.9526 ns |  0.3263 ns |         - |
| &#39;Array (Sorted + BinarySearch)&#39;          | O(log(N))  | RecordClassInts | 1000   | False   |    38.351 ns |   0.5361 ns |  0.0294 ns |         - |
| SortedSet                                | O(log(N))  | RecordClassInts | 1000   | False   |    42.326 ns |   1.5997 ns |  0.0877 ns |         - |
| SortedList                               | O(log(N))  | RecordClassInts | 1000   | False   |    45.018 ns |   1.2270 ns |  0.0673 ns |         - |
| ImmutableSortedSet                       | O(log(N))  | RecordClassInts | 1000   | False   |    48.499 ns |   2.4406 ns |  0.1338 ns |         - |
| ImmutableSortedDictionary                | O(log(N))  | RecordClassInts | 1000   | False   |    51.219 ns |   3.1487 ns |  0.1726 ns |         - |
| SortedDictionary                         | O(log(N))  | RecordClassInts | 1000   | False   |    60.654 ns |   7.8538 ns |  0.4305 ns |         - |
| &#39;ImmutableList (Sorted + BinarySearch)&#39;  | O(log(N))  | RecordClassInts | 1000   | False   |    77.948 ns |  20.7042 ns |  1.1349 ns |         - |
|                                          |            |                 |        |         |              |             |            |           |
| **&#39;List (Sorted + BinarySearch)&#39;**           | **O(log(N))**  | **RecordClassInts** | **1000**   | **True**    |    **36.092 ns** |   **2.9012 ns** |  **0.1590 ns** |         **-** |
| &#39;ImmutableArray (Sorted + BinarySearch)&#39; | O(log(N))  | RecordClassInts | 1000   | True    |    38.337 ns |   1.5912 ns |  0.0872 ns |         - |
| &#39;Array (Sorted + BinarySearch)&#39;          | O(log(N))  | RecordClassInts | 1000   | True    |    38.776 ns |   2.8983 ns |  0.1589 ns |         - |
| ImmutableSortedSet                       | O(log(N))  | RecordClassInts | 1000   | True    |    39.638 ns |   3.9449 ns |  0.2162 ns |         - |
| SortedSet                                | O(log(N))  | RecordClassInts | 1000   | True    |    41.549 ns |   5.9498 ns |  0.3261 ns |         - |
| ImmutableSortedDictionary                | O(log(N))  | RecordClassInts | 1000   | True    |    41.881 ns |  12.7739 ns |  0.7002 ns |         - |
| SortedList                               | O(log(N))  | RecordClassInts | 1000   | True    |    42.708 ns |   7.4337 ns |  0.4075 ns |         - |
| SortedDictionary                         | O(log(N))  | RecordClassInts | 1000   | True    |    58.112 ns |   7.0183 ns |  0.3847 ns |         - |
| &#39;ImmutableList (Sorted + BinarySearch)&#39;  | O(log(N))  | RecordClassInts | 1000   | True    |    68.878 ns |  12.2219 ns |  0.6699 ns |         - |
|                                          |            |                 |        |         |              |             |            |           |
| **ReadOnlyCollection**                       | **O(N)**       | **RecordClassInts** | **1000**   | **False**   | **1,975.733 ns** | **238.1570 ns** | **13.0542 ns** |         **-** |
| Array                                    | O(N)       | RecordClassInts | 1000   | False   | 2,684.823 ns |  17.6806 ns |  0.9691 ns |         - |
| ImmutableArray                           | O(N)       | RecordClassInts | 1000   | False   | 2,686.475 ns | 126.7973 ns |  6.9502 ns |         - |
| List                                     | O(N)       | RecordClassInts | 1000   | False   | 2,788.096 ns | 560.3955 ns | 30.7172 ns |         - |
|                                          |            |                 |        |         |              |             |            |           |
| **ReadOnlyCollection**                       | **O(N)**       | **RecordClassInts** | **1000**   | **True**    |   **955.457 ns** |  **83.5770 ns** |  **4.5811 ns** |         **-** |
| List                                     | O(N)       | RecordClassInts | 1000   | True    | 1,293.321 ns |  66.5020 ns |  3.6452 ns |         - |
| Array                                    | O(N)       | RecordClassInts | 1000   | True    | 1,312.305 ns | 338.6813 ns | 18.5643 ns |         - |
| ImmutableArray                           | O(N)       | RecordClassInts | 1000   | True    | 1,315.318 ns | 152.2331 ns |  8.3444 ns |         - |
