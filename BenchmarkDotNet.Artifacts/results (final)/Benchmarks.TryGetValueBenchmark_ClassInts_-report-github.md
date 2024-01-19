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
| **FrozenDictionary**                         | **O(1)**       | **ClassInts** | **1000**   | **False**   |     **3.893 ns** |   **0.1170 ns** |  **0.0064 ns** |         **-** |
| Dictionary                               | O(1)       | ClassInts | 1000   | False   |     5.800 ns |   0.6555 ns |  0.0359 ns |         - |
| HashSet                                  | O(1)       | ClassInts | 1000   | False   |     6.058 ns |   0.5716 ns |  0.0313 ns |         - |
| FrozenSet                                | O(1)       | ClassInts | 1000   | False   |     7.170 ns |   0.7202 ns |  0.0395 ns |         - |
| ReadOnlyDictionary                       | O(1)       | ClassInts | 1000   | False   |     8.227 ns |   0.4546 ns |  0.0249 ns |         - |
| ImmutableHashSet                         | O(1)       | ClassInts | 1000   | False   |    10.564 ns |   2.0148 ns |  0.1104 ns |         - |
| ImmutableDictionary                      | O(1)       | ClassInts | 1000   | False   |    11.503 ns |   2.1492 ns |  0.1178 ns |         - |
|                                          |            |           |        |         |              |             |            |           |
| **FrozenDictionary**                         | **O(1)**       | **ClassInts** | **1000**   | **True**    |     **7.734 ns** |   **1.7179 ns** |  **0.0942 ns** |         **-** |
| Dictionary                               | O(1)       | ClassInts | 1000   | True    |     9.370 ns |   1.2367 ns |  0.0678 ns |         - |
| HashSet                                  | O(1)       | ClassInts | 1000   | True    |     9.552 ns |   1.4827 ns |  0.0813 ns |         - |
| ReadOnlyDictionary                       | O(1)       | ClassInts | 1000   | True    |    12.288 ns |   2.8657 ns |  0.1571 ns |         - |
| FrozenSet                                | O(1)       | ClassInts | 1000   | True    |    13.617 ns |   1.1161 ns |  0.0612 ns |         - |
| ImmutableHashSet                         | O(1)       | ClassInts | 1000   | True    |    15.310 ns |   5.3803 ns |  0.2949 ns |         - |
| ImmutableDictionary                      | O(1)       | ClassInts | 1000   | True    |    17.573 ns |   0.7587 ns |  0.0416 ns |         - |
|                                          |            |           |        |         |              |             |            |           |
| **&#39;List (Sorted + BinarySearch)&#39;**           | **O(log(N))**  | **ClassInts** | **1000**   | **False**   |    **36.647 ns** |   **9.3205 ns** |  **0.5109 ns** |         **-** |
| &#39;Array (Sorted + BinarySearch)&#39;          | O(log(N))  | ClassInts | 1000   | False   |    37.925 ns |   5.4951 ns |  0.3012 ns |         - |
| &#39;ImmutableArray (Sorted + BinarySearch)&#39; | O(log(N))  | ClassInts | 1000   | False   |    39.116 ns |  16.9538 ns |  0.9293 ns |         - |
| SortedSet                                | O(log(N))  | ClassInts | 1000   | False   |    42.620 ns |   8.3177 ns |  0.4559 ns |         - |
| SortedList                               | O(log(N))  | ClassInts | 1000   | False   |    48.149 ns |  42.0762 ns |  2.3063 ns |         - |
| ImmutableSortedSet                       | O(log(N))  | ClassInts | 1000   | False   |    48.278 ns |  11.8497 ns |  0.6495 ns |         - |
| ImmutableSortedDictionary                | O(log(N))  | ClassInts | 1000   | False   |    52.262 ns |   4.9041 ns |  0.2688 ns |         - |
| SortedDictionary                         | O(log(N))  | ClassInts | 1000   | False   |    60.603 ns |   4.7155 ns |  0.2585 ns |         - |
| &#39;ImmutableList (Sorted + BinarySearch)&#39;  | O(log(N))  | ClassInts | 1000   | False   |    79.511 ns |  20.5448 ns |  1.1261 ns |         - |
|                                          |            |           |        |         |              |             |            |           |
| **&#39;List (Sorted + BinarySearch)&#39;**           | **O(log(N))**  | **ClassInts** | **1000**   | **True**    |    **36.386 ns** |   **5.4246 ns** |  **0.2973 ns** |         **-** |
| &#39;ImmutableArray (Sorted + BinarySearch)&#39; | O(log(N))  | ClassInts | 1000   | True    |    38.523 ns |   1.1629 ns |  0.0637 ns |         - |
| &#39;Array (Sorted + BinarySearch)&#39;          | O(log(N))  | ClassInts | 1000   | True    |    39.157 ns |   7.1774 ns |  0.3934 ns |         - |
| ImmutableSortedSet                       | O(log(N))  | ClassInts | 1000   | True    |    39.679 ns |   2.4508 ns |  0.1343 ns |         - |
| SortedSet                                | O(log(N))  | ClassInts | 1000   | True    |    39.951 ns |  15.2387 ns |  0.8353 ns |         - |
| ImmutableSortedDictionary                | O(log(N))  | ClassInts | 1000   | True    |    42.528 ns |   4.8931 ns |  0.2682 ns |         - |
| SortedList                               | O(log(N))  | ClassInts | 1000   | True    |    43.552 ns |   5.2954 ns |  0.2903 ns |         - |
| SortedDictionary                         | O(log(N))  | ClassInts | 1000   | True    |    59.154 ns |   9.6093 ns |  0.5267 ns |         - |
| &#39;ImmutableList (Sorted + BinarySearch)&#39;  | O(log(N))  | ClassInts | 1000   | True    |    68.583 ns |   4.8163 ns |  0.2640 ns |         - |
|                                          |            |           |        |         |              |             |            |           |
| **ReadOnlyCollection**                       | **O(N)**       | **ClassInts** | **1000**   | **False**   |   **773.975 ns** | **105.2108 ns** |  **5.7670 ns** |         **-** |
| ImmutableArray                           | O(N)       | ClassInts | 1000   | False   | 1,504.838 ns | 258.8998 ns | 14.1912 ns |         - |
| List                                     | O(N)       | ClassInts | 1000   | False   | 1,508.505 ns | 109.9052 ns |  6.0243 ns |         - |
| Array                                    | O(N)       | ClassInts | 1000   | False   | 1,736.114 ns | 224.0401 ns | 12.2804 ns |         - |
|                                          |            |           |        |         |              |             |            |           |
| **ReadOnlyCollection**                       | **O(N)**       | **ClassInts** | **1000**   | **True**    |   **265.686 ns** |  **38.7472 ns** |  **2.1239 ns** |         **-** |
| List                                     | O(N)       | ClassInts | 1000   | True    |   726.899 ns |  89.2420 ns |  4.8917 ns |         - |
| Array                                    | O(N)       | ClassInts | 1000   | True    |   841.566 ns |  78.2787 ns |  4.2907 ns |         - |
| ImmutableArray                           | O(N)       | ClassInts | 1000   | True    |   852.207 ns | 251.4988 ns | 13.7855 ns |         - |
