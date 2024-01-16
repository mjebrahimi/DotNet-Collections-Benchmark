```

BenchmarkDotNet v0.13.12, Windows 11 (10.0.22631.3007/23H2/2023Update/SunValley3)
AMD Ryzen 7 5800H with Radeon Graphics, 1 CPU, 16 logical and 8 physical cores
.NET SDK 8.0.101
  [Host]   : .NET 8.0.1 (8.0.123.58001), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.1 (8.0.123.58001), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                                   | Categories | DataType | Length | Existed | Mean      | Error      | StdDev    | Allocated |
|----------------------------------------- |----------- |--------- |------- |-------- |----------:|-----------:|----------:|----------:|
| **FrozenSet**                                | **O(1)**       | **Int32**    | **1000**   | **False**   |  **1.945 ns** |  **0.0588 ns** | **0.0032 ns** |         **-** |
| FrozenDictionary                         | O(1)       | Int32    | 1000   | False   |  2.029 ns |  0.1983 ns | 0.0109 ns |         - |
| Dictionary                               | O(1)       | Int32    | 1000   | False   |  3.151 ns |  0.2901 ns | 0.0159 ns |         - |
| HashSet                                  | O(1)       | Int32    | 1000   | False   |  3.557 ns |  0.2335 ns | 0.0128 ns |         - |
| ReadOnlyDictionary                       | O(1)       | Int32    | 1000   | False   |  3.620 ns |  0.2061 ns | 0.0113 ns |         - |
| ImmutableDictionary                      | O(1)       | Int32    | 1000   | False   |  6.936 ns |  0.9263 ns | 0.0508 ns |         - |
| ImmutableHashSet                         | O(1)       | Int32    | 1000   | False   |  7.002 ns |  1.1803 ns | 0.0647 ns |         - |
|                                          |            |          |        |         |           |            |           |           |
| **FrozenDictionary**                         | **O(1)**       | **Int32**    | **1000**   | **True**    |  **2.105 ns** |  **0.2321 ns** | **0.0127 ns** |         **-** |
| FrozenSet                                | O(1)       | Int32    | 1000   | True    |  2.348 ns |  0.6690 ns | 0.0367 ns |         - |
| HashSet                                  | O(1)       | Int32    | 1000   | True    |  3.854 ns |  1.0097 ns | 0.0553 ns |         - |
| Dictionary                               | O(1)       | Int32    | 1000   | True    |  3.885 ns |  0.2723 ns | 0.0149 ns |         - |
| ReadOnlyDictionary                       | O(1)       | Int32    | 1000   | True    |  4.289 ns |  0.4145 ns | 0.0227 ns |         - |
| ImmutableDictionary                      | O(1)       | Int32    | 1000   | True    |  6.075 ns |  2.0104 ns | 0.1102 ns |         - |
| ImmutableHashSet                         | O(1)       | Int32    | 1000   | True    |  6.100 ns |  2.0314 ns | 0.1113 ns |         - |
|                                          |            |          |        |         |           |            |           |           |
| **SortedSet**                                | **O(log(N))**  | **Int32**    | **1000**   | **False**   | **12.098 ns** |  **1.9697 ns** | **0.1080 ns** |         **-** |
| SortedList                               | O(log(N))  | Int32    | 1000   | False   | 14.066 ns |  4.9435 ns | 0.2710 ns |         - |
| &#39;Array (Sorted + BinarySearch)&#39;          | O(log(N))  | Int32    | 1000   | False   | 15.108 ns |  1.4230 ns | 0.0780 ns |         - |
| &#39;ImmutableArray (Sorted + BinarySearch)&#39; | O(log(N))  | Int32    | 1000   | False   | 15.658 ns |  3.4903 ns | 0.1913 ns |         - |
| &#39;List (Sorted + BinarySearch)&#39;           | O(log(N))  | Int32    | 1000   | False   | 19.406 ns |  7.5607 ns | 0.4144 ns |         - |
| SortedDictionary                         | O(log(N))  | Int32    | 1000   | False   | 23.119 ns |  3.2485 ns | 0.1781 ns |         - |
| ImmutableSortedDictionary                | O(log(N))  | Int32    | 1000   | False   | 23.298 ns |  1.0291 ns | 0.0564 ns |         - |
| ImmutableSortedSet                       | O(log(N))  | Int32    | 1000   | False   | 23.324 ns |  2.6545 ns | 0.1455 ns |         - |
| &#39;ImmutableList (Sorted + BinarySearch)&#39;  | O(log(N))  | Int32    | 1000   | False   | 28.372 ns |  6.6657 ns | 0.3654 ns |         - |
|                                          |            |          |        |         |           |            |           |           |
| **SortedSet**                                | **O(log(N))**  | **Int32**    | **1000**   | **True**    | **11.001 ns** |  **2.1815 ns** | **0.1196 ns** |         **-** |
| &#39;ImmutableArray (Sorted + BinarySearch)&#39; | O(log(N))  | Int32    | 1000   | True    | 13.082 ns |  2.2910 ns | 0.1256 ns |         - |
| &#39;Array (Sorted + BinarySearch)&#39;          | O(log(N))  | Int32    | 1000   | True    | 13.183 ns |  1.5786 ns | 0.0865 ns |         - |
| SortedList                               | O(log(N))  | Int32    | 1000   | True    | 14.344 ns |  0.4976 ns | 0.0273 ns |         - |
| &#39;List (Sorted + BinarySearch)&#39;           | O(log(N))  | Int32    | 1000   | True    | 14.669 ns |  1.7234 ns | 0.0945 ns |         - |
| SortedDictionary                         | O(log(N))  | Int32    | 1000   | True    | 16.904 ns |  1.2891 ns | 0.0707 ns |         - |
| ImmutableSortedDictionary                | O(log(N))  | Int32    | 1000   | True    | 18.442 ns |  1.7855 ns | 0.0979 ns |         - |
| ImmutableSortedSet                       | O(log(N))  | Int32    | 1000   | True    | 18.480 ns |  4.0187 ns | 0.2203 ns |         - |
| &#39;ImmutableList (Sorted + BinarySearch)&#39;  | O(log(N))  | Int32    | 1000   | True    | 24.008 ns |  7.1657 ns | 0.3928 ns |         - |
|                                          |            |          |        |         |           |            |           |           |
| **List**                                     | **O(N)**       | **Int32**    | **1000**   | **False**   | **43.877 ns** |  **8.4752 ns** | **0.4646 ns** |         **-** |
| ReadOnlyCollection                       | O(N)       | Int32    | 1000   | False   | 44.524 ns |  4.7096 ns | 0.2581 ns |         - |
| ImmutableArray                           | O(N)       | Int32    | 1000   | False   | 68.765 ns | 10.3856 ns | 0.5693 ns |         - |
| Array                                    | O(N)       | Int32    | 1000   | False   | 70.900 ns | 79.2658 ns | 4.3448 ns |         - |
|                                          |            |          |        |         |           |            |           |           |
| **List**                                     | **O(N)**       | **Int32**    | **1000**   | **True**    | **29.495 ns** | **11.5223 ns** | **0.6316 ns** |         **-** |
| Array                                    | O(N)       | Int32    | 1000   | True    | 30.105 ns |  3.9241 ns | 0.2151 ns |         - |
| ReadOnlyCollection                       | O(N)       | Int32    | 1000   | True    | 30.159 ns |  3.3028 ns | 0.1810 ns |         - |
| ImmutableArray                           | O(N)       | Int32    | 1000   | True    | 30.334 ns |  1.9629 ns | 0.1076 ns |         - |
