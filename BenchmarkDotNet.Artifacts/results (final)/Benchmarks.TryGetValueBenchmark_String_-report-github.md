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
| **FrozenDictionary**                         | **O(1)**       | **String**   | **1000**   | **False**   |     **4.421 ns** |   **0.5035 ns** |  **0.0276 ns** |         **-** |
| FrozenSet                                | O(1)       | String   | 1000   | False   |     6.279 ns |   0.4430 ns |  0.0243 ns |         - |
| Dictionary                               | O(1)       | String   | 1000   | False   |     7.095 ns |   1.3972 ns |  0.0766 ns |         - |
| HashSet                                  | O(1)       | String   | 1000   | False   |     7.151 ns |   1.3768 ns |  0.0755 ns |         - |
| ReadOnlyDictionary                       | O(1)       | String   | 1000   | False   |     9.358 ns |   1.8240 ns |  0.1000 ns |         - |
| ImmutableHashSet                         | O(1)       | String   | 1000   | False   |    15.515 ns |   3.4441 ns |  0.1888 ns |         - |
| ImmutableDictionary                      | O(1)       | String   | 1000   | False   |    16.466 ns |   8.5353 ns |  0.4678 ns |         - |
|                                          |            |          |        |         |              |             |            |           |
| **FrozenDictionary**                         | **O(1)**       | **String**   | **1000**   | **True**    |     **4.857 ns** |   **0.6566 ns** |  **0.0360 ns** |         **-** |
| Dictionary                               | O(1)       | String   | 1000   | True    |     8.973 ns |   1.2395 ns |  0.0679 ns |         - |
| HashSet                                  | O(1)       | String   | 1000   | True    |     9.021 ns |   0.4231 ns |  0.0232 ns |         - |
| FrozenSet                                | O(1)       | String   | 1000   | True    |    10.957 ns |   1.4986 ns |  0.0821 ns |         - |
| ReadOnlyDictionary                       | O(1)       | String   | 1000   | True    |    11.229 ns |   1.0306 ns |  0.0565 ns |         - |
| ImmutableHashSet                         | O(1)       | String   | 1000   | True    |    19.697 ns |   2.6280 ns |  0.1441 ns |         - |
| ImmutableDictionary                      | O(1)       | String   | 1000   | True    |    20.911 ns |   5.6117 ns |  0.3076 ns |         - |
|                                          |            |          |        |         |              |             |            |           |
| **SortedSet**                                | **O(log(N))**  | **String**   | **1000**   | **False**   |   **303.085 ns** |  **43.5154 ns** |  **2.3852 ns** |         **-** |
| &#39;Array (Sorted + BinarySearch)&#39;          | O(log(N))  | String   | 1000   | False   |   311.216 ns |  25.6718 ns |  1.4072 ns |         - |
| SortedList                               | O(log(N))  | String   | 1000   | False   |   319.730 ns |  13.0537 ns |  0.7155 ns |         - |
| &#39;ImmutableArray (Sorted + BinarySearch)&#39; | O(log(N))  | String   | 1000   | False   |   321.109 ns | 146.2676 ns |  8.0174 ns |         - |
| ImmutableSortedDictionary                | O(log(N))  | String   | 1000   | False   |   323.934 ns |  91.7163 ns |  5.0273 ns |         - |
| ImmutableSortedSet                       | O(log(N))  | String   | 1000   | False   |   336.183 ns |  32.8334 ns |  1.7997 ns |         - |
| &#39;List (Sorted + BinarySearch)&#39;           | O(log(N))  | String   | 1000   | False   |   353.234 ns |  88.7693 ns |  4.8657 ns |         - |
| &#39;ImmutableList (Sorted + BinarySearch)&#39;  | O(log(N))  | String   | 1000   | False   |   357.601 ns |  75.3227 ns |  4.1287 ns |         - |
| SortedDictionary                         | O(log(N))  | String   | 1000   | False   |   358.193 ns |  15.9219 ns |  0.8727 ns |         - |
|                                          |            |          |        |         |              |             |            |           |
| **ImmutableSortedDictionary**                | **O(log(N))**  | **String**   | **1000**   | **True**    |   **237.537 ns** |  **45.9291 ns** |  **2.5175 ns** |         **-** |
| ImmutableSortedSet                       | O(log(N))  | String   | 1000   | True    |   245.379 ns |  55.6813 ns |  3.0521 ns |         - |
| &#39;List (Sorted + BinarySearch)&#39;           | O(log(N))  | String   | 1000   | True    |   264.359 ns |  52.4840 ns |  2.8768 ns |         - |
| &#39;Array (Sorted + BinarySearch)&#39;          | O(log(N))  | String   | 1000   | True    |   264.543 ns |  23.6696 ns |  1.2974 ns |         - |
| &#39;ImmutableArray (Sorted + BinarySearch)&#39; | O(log(N))  | String   | 1000   | True    |   265.289 ns |  36.0121 ns |  1.9739 ns |         - |
| &#39;ImmutableList (Sorted + BinarySearch)&#39;  | O(log(N))  | String   | 1000   | True    |   268.966 ns |  10.2658 ns |  0.5627 ns |         - |
| SortedList                               | O(log(N))  | String   | 1000   | True    |   270.004 ns |  52.1485 ns |  2.8584 ns |         - |
| SortedDictionary                         | O(log(N))  | String   | 1000   | True    |   281.324 ns |  66.7073 ns |  3.6565 ns |         - |
| SortedSet                                | O(log(N))  | String   | 1000   | True    |   289.570 ns |  59.6427 ns |  3.2692 ns |         - |
|                                          |            |          |        |         |              |             |            |           |
| **ReadOnlyCollection**                       | **O(N)**       | **String**   | **1000**   | **False**   | **3,005.547 ns** | **436.2414 ns** | **23.9119 ns** |         **-** |
| ImmutableArray                           | O(N)       | String   | 1000   | False   | 3,938.770 ns | 526.2674 ns | 28.8465 ns |         - |
| List                                     | O(N)       | String   | 1000   | False   | 4,002.468 ns | 646.8517 ns | 35.4561 ns |         - |
| Array                                    | O(N)       | String   | 1000   | False   | 4,006.808 ns | 218.9723 ns | 12.0026 ns |         - |
|                                          |            |          |        |         |              |             |            |           |
| **ReadOnlyCollection**                       | **O(N)**       | **String**   | **1000**   | **True**    | **1,435.280 ns** | **715.1145 ns** | **39.1978 ns** |         **-** |
| ImmutableArray                           | O(N)       | String   | 1000   | True    | 1,789.514 ns | 753.6574 ns | 41.3105 ns |         - |
| List                                     | O(N)       | String   | 1000   | True    | 1,826.351 ns | 227.0355 ns | 12.4446 ns |         - |
| Array                                    | O(N)       | String   | 1000   | True    | 1,831.162 ns | 403.4804 ns | 22.1161 ns |         - |
