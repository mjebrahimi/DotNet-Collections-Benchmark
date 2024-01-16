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
| **FrozenDictionary**                         | **O(1)**       | **RecordClassInts** | **1000**   | **False**   |     **5.176 ns** |   **0.5170 ns** |  **0.0283 ns** |         **-** |
| FrozenSet                                | O(1)       | RecordClassInts | 1000   | False   |     5.191 ns |   0.7644 ns |  0.0419 ns |         - |
| HashSet                                  | O(1)       | RecordClassInts | 1000   | False   |     7.549 ns |   0.9996 ns |  0.0548 ns |         - |
| Dictionary                               | O(1)       | RecordClassInts | 1000   | False   |     7.726 ns |   0.8976 ns |  0.0492 ns |         - |
| ReadOnlyDictionary                       | O(1)       | RecordClassInts | 1000   | False   |     9.805 ns |   0.7721 ns |  0.0423 ns |         - |
| ImmutableDictionary                      | O(1)       | RecordClassInts | 1000   | False   |    12.270 ns |   1.6867 ns |  0.0925 ns |         - |
| ImmutableHashSet                         | O(1)       | RecordClassInts | 1000   | False   |    24.816 ns |   4.9900 ns |  0.2735 ns |         - |
|                                          |            |                 |        |         |              |             |            |           |
| **FrozenDictionary**                         | **O(1)**       | **RecordClassInts** | **1000**   | **True**    |     **8.955 ns** |   **0.2284 ns** |  **0.0125 ns** |         **-** |
| FrozenSet                                | O(1)       | RecordClassInts | 1000   | True    |     9.076 ns |   0.7857 ns |  0.0431 ns |         - |
| Dictionary                               | O(1)       | RecordClassInts | 1000   | True    |    11.259 ns |   1.7723 ns |  0.0971 ns |         - |
| HashSet                                  | O(1)       | RecordClassInts | 1000   | True    |    11.447 ns |   6.2091 ns |  0.3403 ns |         - |
| ReadOnlyDictionary                       | O(1)       | RecordClassInts | 1000   | True    |    13.506 ns |   4.4403 ns |  0.2434 ns |         - |
| ImmutableDictionary                      | O(1)       | RecordClassInts | 1000   | True    |    18.264 ns |   3.0540 ns |  0.1674 ns |         - |
| ImmutableHashSet                         | O(1)       | RecordClassInts | 1000   | True    |    27.320 ns |   3.6174 ns |  0.1983 ns |         - |
|                                          |            |                 |        |         |              |             |            |           |
| **&#39;List (Sorted + BinarySearch)&#39;**           | **O(log(N))**  | **RecordClassInts** | **1000**   | **False**   |    **36.330 ns** |   **2.3378 ns** |  **0.1281 ns** |         **-** |
| &#39;Array (Sorted + BinarySearch)&#39;          | O(log(N))  | RecordClassInts | 1000   | False   |    38.017 ns |  10.1716 ns |  0.5575 ns |         - |
| &#39;ImmutableArray (Sorted + BinarySearch)&#39; | O(log(N))  | RecordClassInts | 1000   | False   |    40.870 ns |   3.3669 ns |  0.1846 ns |         - |
| SortedSet                                | O(log(N))  | RecordClassInts | 1000   | False   |    42.957 ns |   6.9818 ns |  0.3827 ns |         - |
| SortedList                               | O(log(N))  | RecordClassInts | 1000   | False   |    46.912 ns |  15.9345 ns |  0.8734 ns |         - |
| ImmutableSortedSet                       | O(log(N))  | RecordClassInts | 1000   | False   |    52.308 ns |   5.1407 ns |  0.2818 ns |         - |
| ImmutableSortedDictionary                | O(log(N))  | RecordClassInts | 1000   | False   |    53.115 ns |  14.2291 ns |  0.7799 ns |         - |
| SortedDictionary                         | O(log(N))  | RecordClassInts | 1000   | False   |    62.616 ns |   5.8585 ns |  0.3211 ns |         - |
| &#39;ImmutableList (Sorted + BinarySearch)&#39;  | O(log(N))  | RecordClassInts | 1000   | False   |    77.621 ns |  11.4404 ns |  0.6271 ns |         - |
|                                          |            |                 |        |         |              |             |            |           |
| **&#39;List (Sorted + BinarySearch)&#39;**           | **O(log(N))**  | **RecordClassInts** | **1000**   | **True**    |    **36.491 ns** |   **3.1867 ns** |  **0.1747 ns** |         **-** |
| &#39;Array (Sorted + BinarySearch)&#39;          | O(log(N))  | RecordClassInts | 1000   | True    |    37.091 ns |  14.5551 ns |  0.7978 ns |         - |
| &#39;ImmutableArray (Sorted + BinarySearch)&#39; | O(log(N))  | RecordClassInts | 1000   | True    |    39.000 ns |  10.3604 ns |  0.5679 ns |         - |
| SortedSet                                | O(log(N))  | RecordClassInts | 1000   | True    |    39.288 ns |   5.3111 ns |  0.2911 ns |         - |
| ImmutableSortedSet                       | O(log(N))  | RecordClassInts | 1000   | True    |    42.081 ns |   4.9460 ns |  0.2711 ns |         - |
| ImmutableSortedDictionary                | O(log(N))  | RecordClassInts | 1000   | True    |    42.221 ns |   1.4646 ns |  0.0803 ns |         - |
| SortedList                               | O(log(N))  | RecordClassInts | 1000   | True    |    43.424 ns |   5.0528 ns |  0.2770 ns |         - |
| SortedDictionary                         | O(log(N))  | RecordClassInts | 1000   | True    |    58.743 ns |   7.1891 ns |  0.3941 ns |         - |
| &#39;ImmutableList (Sorted + BinarySearch)&#39;  | O(log(N))  | RecordClassInts | 1000   | True    |    64.700 ns |  10.5228 ns |  0.5768 ns |         - |
|                                          |            |                 |        |         |              |             |            |           |
| **ReadOnlyCollection**                       | **O(N)**       | **RecordClassInts** | **1000**   | **False**   | **1,981.269 ns** | **268.3517 ns** | **14.7093 ns** |         **-** |
| ImmutableArray                           | O(N)       | RecordClassInts | 1000   | False   | 2,708.779 ns | 318.6023 ns | 17.4637 ns |         - |
| Array                                    | O(N)       | RecordClassInts | 1000   | False   | 2,741.353 ns | 478.5484 ns | 26.2309 ns |         - |
| List                                     | O(N)       | RecordClassInts | 1000   | False   | 2,750.610 ns | 869.1200 ns | 47.6394 ns |         - |
|                                          |            |                 |        |         |              |             |            |           |
| **ReadOnlyCollection**                       | **O(N)**       | **RecordClassInts** | **1000**   | **True**    |   **956.827 ns** | **249.2128 ns** | **13.6602 ns** |         **-** |
| ImmutableArray                           | O(N)       | RecordClassInts | 1000   | True    | 1,309.247 ns | 148.0958 ns |  8.1176 ns |         - |
| Array                                    | O(N)       | RecordClassInts | 1000   | True    | 1,314.054 ns |  45.8263 ns |  2.5119 ns |         - |
| List                                     | O(N)       | RecordClassInts | 1000   | True    | 1,315.648 ns | 388.7680 ns | 21.3097 ns |         - |
