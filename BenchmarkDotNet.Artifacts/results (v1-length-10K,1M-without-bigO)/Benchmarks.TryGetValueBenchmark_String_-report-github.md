```

BenchmarkDotNet v0.13.11, Windows 11 (10.0.22631.2861/23H2/2023Update/SunValley3)
AMD Ryzen 7 5800H with Radeon Graphics, 1 CPU, 16 logical and 8 physical cores
.NET SDK 8.0.100
  [Host]   : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                                   | DataType | Length  | Existed | Mean              | Error             | StdDev          | Allocated |
|----------------------------------------- |--------- |-------- |-------- |------------------:|------------------:|----------------:|----------:|
| **FrozenDictionary**                         | **String**   | **10000**   | **False**   |          **4.249 ns** |         **0.6289 ns** |       **0.0345 ns** |         **-** |
| FrozenSet                                | String   | 10000   | False   |          5.880 ns |         0.4002 ns |       0.0219 ns |         - |
| HashSet                                  | String   | 10000   | False   |          6.640 ns |         0.3888 ns |       0.0213 ns |         - |
| Dictionary                               | String   | 10000   | False   |          6.838 ns |         0.1356 ns |       0.0074 ns |         - |
| ReadOnlyDictionary                       | String   | 10000   | False   |          9.411 ns |         1.8130 ns |       0.0994 ns |         - |
| ImmutableHashSet                         | String   | 10000   | False   |         18.312 ns |         4.1135 ns |       0.2255 ns |         - |
| ImmutableDictionary                      | String   | 10000   | False   |         20.337 ns |         2.3936 ns |       0.1312 ns |         - |
| &#39;List (Sorted + BinarySearch)&#39;           | String   | 10000   | False   |        413.612 ns |         8.7662 ns |       0.4805 ns |         - |
| &#39;ImmutableArray (Sorted + BinarySearch)&#39; | String   | 10000   | False   |        415.684 ns |         8.5940 ns |       0.4711 ns |         - |
| &#39;Array (Sorted + BinarySearch)&#39;          | String   | 10000   | False   |        419.095 ns |        32.2360 ns |       1.7670 ns |         - |
| SortedSet                                | String   | 10000   | False   |        420.695 ns |        54.4803 ns |       2.9862 ns |         - |
| SortedList                               | String   | 10000   | False   |        424.472 ns |        40.7379 ns |       2.2330 ns |         - |
| ImmutableSortedSet                       | String   | 10000   | False   |        428.247 ns |         2.4651 ns |       0.1351 ns |         - |
| ImmutableSortedDictionary                | String   | 10000   | False   |        436.698 ns |        27.0008 ns |       1.4800 ns |         - |
| SortedDictionary                         | String   | 10000   | False   |        457.272 ns |        29.8890 ns |       1.6383 ns |         - |
| &#39;ImmutableList (Sorted + BinarySearch)&#39;  | String   | 10000   | False   |        459.433 ns |        10.3035 ns |       0.5648 ns |         - |
| ReadOnlyCollection                       | String   | 10000   | False   |     21,917.589 ns |     2,229.0180 ns |     122.1800 ns |         - |
| LinkedList                               | String   | 10000   | False   |     24,442.698 ns |       820.9934 ns |      45.0014 ns |         - |
| Array                                    | String   | 10000   | False   |     31,310.158 ns |     2,439.7123 ns |     133.7289 ns |         - |
| List                                     | String   | 10000   | False   |     36,032.827 ns |     1,692.2691 ns |      92.7590 ns |         - |
| ImmutableArray                           | String   | 10000   | False   |     38,265.811 ns |     3,001.3509 ns |     164.5142 ns |         - |
| ImmutableList                            | String   | 10000   | False   |    276,761.241 ns |   105,388.2293 ns |   5,776.6845 ns |         - |
|                                          |          |         |         |                   |                   |                 |           |
| **FrozenDictionary**                         | **String**   | **10000**   | **True**    |          **4.795 ns** |         **1.3942 ns** |       **0.0764 ns** |         **-** |
| Dictionary                               | String   | 10000   | True    |          8.251 ns |         0.6169 ns |       0.0338 ns |         - |
| FrozenSet                                | String   | 10000   | True    |          8.302 ns |         0.3299 ns |       0.0181 ns |         - |
| HashSet                                  | String   | 10000   | True    |          8.932 ns |         1.0550 ns |       0.0578 ns |         - |
| ReadOnlyDictionary                       | String   | 10000   | True    |         10.994 ns |         0.7107 ns |       0.0390 ns |         - |
| ImmutableHashSet                         | String   | 10000   | True    |         26.219 ns |         4.9090 ns |       0.2691 ns |         - |
| ImmutableDictionary                      | String   | 10000   | True    |         26.570 ns |         1.2654 ns |       0.0694 ns |         - |
| ImmutableSortedSet                       | String   | 10000   | True    |        337.694 ns |        30.7615 ns |       1.6861 ns |         - |
| ImmutableSortedDictionary                | String   | 10000   | True    |        342.826 ns |        56.3707 ns |       3.0899 ns |         - |
| SortedSet                                | String   | 10000   | True    |        353.105 ns |        14.9858 ns |       0.8214 ns |         - |
| &#39;ImmutableList (Sorted + BinarySearch)&#39;  | String   | 10000   | True    |        371.706 ns |        17.6352 ns |       0.9666 ns |         - |
| &#39;List (Sorted + BinarySearch)&#39;           | String   | 10000   | True    |        378.703 ns |         5.7704 ns |       0.3163 ns |         - |
| &#39;Array (Sorted + BinarySearch)&#39;          | String   | 10000   | True    |        380.115 ns |         2.4875 ns |       0.1364 ns |         - |
| &#39;ImmutableArray (Sorted + BinarySearch)&#39; | String   | 10000   | True    |        382.290 ns |        39.7406 ns |       2.1783 ns |         - |
| SortedDictionary                         | String   | 10000   | True    |        395.730 ns |        39.1241 ns |       2.1445 ns |         - |
| SortedList                               | String   | 10000   | True    |        399.412 ns |        60.4917 ns |       3.3158 ns |         - |
| LinkedList                               | String   | 10000   | True    |      8,188.008 ns |     8,102.8976 ns |     444.1472 ns |         - |
| ReadOnlyCollection                       | String   | 10000   | True    |      9,710.029 ns |     2,056.4573 ns |     112.7214 ns |         - |
| Array                                    | String   | 10000   | True    |     13,404.675 ns |       444.4220 ns |      24.3603 ns |         - |
| ImmutableArray                           | String   | 10000   | True    |     15,344.647 ns |       917.8181 ns |      50.3087 ns |         - |
| List                                     | String   | 10000   | True    |     15,402.533 ns |     2,932.4938 ns |     160.7399 ns |         - |
| ImmutableList                            | String   | 10000   | True    |    117,926.693 ns |    16,507.1486 ns |     904.8125 ns |         - |
|                                          |          |         |         |                   |                   |                 |           |
| **FrozenDictionary**                         | **String**   | **1000000** | **False**   |          **4.836 ns** |         **0.0262 ns** |       **0.0014 ns** |         **-** |
| Dictionary                               | String   | 1000000 | False   |          7.154 ns |         0.1954 ns |       0.0107 ns |         - |
| FrozenSet                                | String   | 1000000 | False   |          7.217 ns |         0.4021 ns |       0.0220 ns |         - |
| HashSet                                  | String   | 1000000 | False   |          7.471 ns |         0.2080 ns |       0.0114 ns |         - |
| ReadOnlyDictionary                       | String   | 1000000 | False   |          9.636 ns |         0.1816 ns |       0.0100 ns |         - |
| ImmutableHashSet                         | String   | 1000000 | False   |         35.769 ns |         0.9016 ns |       0.0494 ns |         - |
| ImmutableDictionary                      | String   | 1000000 | False   |         43.070 ns |         2.3392 ns |       0.1282 ns |         - |
| SortedSet                                | String   | 1000000 | False   |        648.880 ns |        13.8608 ns |       0.7598 ns |         - |
| &#39;ImmutableArray (Sorted + BinarySearch)&#39; | String   | 1000000 | False   |        660.309 ns |        26.7752 ns |       1.4676 ns |         - |
| &#39;List (Sorted + BinarySearch)&#39;           | String   | 1000000 | False   |        660.605 ns |        49.5508 ns |       2.7160 ns |         - |
| &#39;Array (Sorted + BinarySearch)&#39;          | String   | 1000000 | False   |        660.839 ns |        11.6735 ns |       0.6399 ns |         - |
| SortedList                               | String   | 1000000 | False   |        676.284 ns |        30.5348 ns |       1.6737 ns |         - |
| ImmutableSortedSet                       | String   | 1000000 | False   |        682.136 ns |        31.6906 ns |       1.7371 ns |         - |
| ImmutableSortedDictionary                | String   | 1000000 | False   |        687.117 ns |        62.4764 ns |       3.4245 ns |         - |
| SortedDictionary                         | String   | 1000000 | False   |        728.249 ns |        30.8388 ns |       1.6904 ns |         - |
| &#39;ImmutableList (Sorted + BinarySearch)&#39;  | String   | 1000000 | False   |        761.132 ns |       189.1706 ns |      10.3691 ns |         - |
| ReadOnlyCollection                       | String   | 1000000 | False   |  2,907,282.778 ns |   269,014.8661 ns |  14,745.6126 ns |       4 B |
| LinkedList                               | String   | 1000000 | False   |  3,407,405.556 ns |   828,092.5688 ns |  45,390.5480 ns |       5 B |
| Array                                    | String   | 1000000 | False   |  3,466,791.453 ns |   190,159.0031 ns |  10,423.2566 ns |       5 B |
| ImmutableArray                           | String   | 1000000 | False   |  3,494,993.287 ns |   126,785.2041 ns |   6,949.5249 ns |       3 B |
| List                                     | String   | 1000000 | False   |  3,867,009.596 ns |   140,224.3858 ns |   7,686.1718 ns |       6 B |
| ImmutableList                            | String   | 1000000 | False   | 44,074,352.778 ns | 1,713,393.3458 ns |  93,916.8709 ns |      61 B |
|                                          |          |         |         |                   |                   |                 |           |
| **FrozenDictionary**                         | **String**   | **1000000** | **True**    |          **5.657 ns** |         **0.0927 ns** |       **0.0051 ns** |         **-** |
| Dictionary                               | String   | 1000000 | True    |          8.722 ns |         0.1917 ns |       0.0105 ns |         - |
| FrozenSet                                | String   | 1000000 | True    |          9.686 ns |         0.1586 ns |       0.0087 ns |         - |
| HashSet                                  | String   | 1000000 | True    |         10.256 ns |         0.3137 ns |       0.0172 ns |         - |
| ReadOnlyDictionary                       | String   | 1000000 | True    |         11.190 ns |         0.6151 ns |       0.0337 ns |         - |
| ImmutableHashSet                         | String   | 1000000 | True    |         41.445 ns |         2.7402 ns |       0.1502 ns |         - |
| ImmutableDictionary                      | String   | 1000000 | True    |         46.849 ns |         5.0369 ns |       0.2761 ns |         - |
| ImmutableSortedSet                       | String   | 1000000 | True    |        537.668 ns |         2.5466 ns |       0.1396 ns |         - |
| ImmutableSortedDictionary                | String   | 1000000 | True    |        552.101 ns |        16.8459 ns |       0.9234 ns |         - |
| &#39;List (Sorted + BinarySearch)&#39;           | String   | 1000000 | True    |        597.635 ns |        18.1276 ns |       0.9936 ns |         - |
| SortedList                               | String   | 1000000 | True    |        600.308 ns |        37.3515 ns |       2.0474 ns |         - |
| &#39;ImmutableArray (Sorted + BinarySearch)&#39; | String   | 1000000 | True    |        601.658 ns |        20.5753 ns |       1.1278 ns |         - |
| SortedDictionary                         | String   | 1000000 | True    |        606.596 ns |        45.3188 ns |       2.4841 ns |         - |
| &#39;ImmutableList (Sorted + BinarySearch)&#39;  | String   | 1000000 | True    |        607.879 ns |        57.6436 ns |       3.1596 ns |         - |
| SortedSet                                | String   | 1000000 | True    |        610.345 ns |       104.5620 ns |       5.7314 ns |         - |
| &#39;Array (Sorted + BinarySearch)&#39;          | String   | 1000000 | True    |        623.261 ns |         4.9923 ns |       0.2736 ns |         - |
| ReadOnlyCollection                       | String   | 1000000 | True    |  1,010,492.904 ns |    34,027.8734 ns |   1,865.1826 ns |       1 B |
| LinkedList                               | String   | 1000000 | True    |  1,188,231.315 ns |   162,901.1131 ns |   8,929.1597 ns |       1 B |
| Array                                    | String   | 1000000 | True    |  1,287,815.929 ns |    35,904.6447 ns |   1,968.0547 ns |       1 B |
| ImmutableArray                           | String   | 1000000 | True    |  1,291,166.819 ns |    68,377.6058 ns |   3,748.0073 ns |       1 B |
| List                                     | String   | 1000000 | True    |  1,358,457.292 ns |    14,059.0843 ns |     770.6259 ns |       2 B |
| ImmutableList                            | String   | 1000000 | True    | 15,998,994.444 ns | 2,020,700.9024 ns | 110,761.4350 ns |      12 B |
