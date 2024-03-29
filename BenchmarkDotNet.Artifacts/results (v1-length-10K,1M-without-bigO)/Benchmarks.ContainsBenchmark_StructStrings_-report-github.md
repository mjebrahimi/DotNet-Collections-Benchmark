```

BenchmarkDotNet v0.13.11, Windows 11 (10.0.22631.2861/23H2/2023Update/SunValley3)
AMD Ryzen 7 5800H with Radeon Graphics, 1 CPU, 16 logical and 8 physical cores
.NET SDK 8.0.100
  [Host]   : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                                   | DataType      | Length  | Existed | Mean              | Error             | StdDev           | Allocated   |
|----------------------------------------- |-------------- |-------- |-------- |------------------:|------------------:|-----------------:|------------:|
| **ReadOnlyDictionary**                       | **StructStrings** | **10000**   | **False**   |          **58.27 ns** |          **8.292 ns** |         **0.455 ns** |        **40 B** |
| FrozenDictionary                         | StructStrings | 10000   | False   |          58.63 ns |          2.926 ns |         0.160 ns |        40 B |
| HashSet                                  | StructStrings | 10000   | False   |          61.48 ns |          7.855 ns |         0.431 ns |        40 B |
| FrozenSet                                | StructStrings | 10000   | False   |          61.54 ns |          0.318 ns |         0.017 ns |        40 B |
| Dictionary                               | StructStrings | 10000   | False   |          63.80 ns |          5.516 ns |         0.302 ns |        40 B |
| ImmutableDictionary                      | StructStrings | 10000   | False   |          71.12 ns |         12.488 ns |         0.685 ns |        40 B |
| ImmutableHashSet                         | StructStrings | 10000   | False   |          72.25 ns |         14.326 ns |         0.785 ns |        40 B |
| &#39;Array (Sorted + BinarySearch)&#39;          | StructStrings | 10000   | False   |         388.99 ns |         30.886 ns |         1.693 ns |           - |
| SortedSet                                | StructStrings | 10000   | False   |         389.36 ns |         74.675 ns |         4.093 ns |           - |
| &#39;ImmutableArray (Sorted + BinarySearch)&#39; | StructStrings | 10000   | False   |         392.51 ns |          8.244 ns |         0.452 ns |           - |
| &#39;List (Sorted + BinarySearch)&#39;           | StructStrings | 10000   | False   |         397.05 ns |         13.357 ns |         0.732 ns |           - |
| SortedList                               | StructStrings | 10000   | False   |         401.61 ns |         13.554 ns |         0.743 ns |        40 B |
| &#39;ImmutableList (Sorted + BinarySearch)&#39;  | StructStrings | 10000   | False   |         411.35 ns |         41.305 ns |         2.264 ns |           - |
| SortedDictionary                         | StructStrings | 10000   | False   |         413.46 ns |         50.250 ns |         2.754 ns |        40 B |
| ImmutableSortedDictionary                | StructStrings | 10000   | False   |         415.33 ns |         33.239 ns |         1.822 ns |           - |
| ImmutableSortedSet                       | StructStrings | 10000   | False   |         416.55 ns |         64.812 ns |         3.553 ns |           - |
| LinkedList                               | StructStrings | 10000   | False   |     904,525.43 ns |    368,342.332 ns |    20,190.086 ns |   1280003 B |
| ReadOnlyCollection                       | StructStrings | 10000   | False   |     931,972.59 ns |     80,997.386 ns |     4,439.740 ns |   1280002 B |
| Array                                    | StructStrings | 10000   | False   |     946,845.75 ns |    334,564.823 ns |    18,338.627 ns |   1280002 B |
| List                                     | StructStrings | 10000   | False   |     948,803.99 ns |     64,902.128 ns |     3,557.505 ns |   1280002 B |
| ImmutableArray                           | StructStrings | 10000   | False   |     949,636.05 ns |     81,025.402 ns |     4,441.276 ns |   1280002 B |
| ImmutableList                            | StructStrings | 10000   | False   |     954,348.83 ns |    178,342.776 ns |     9,775.569 ns |   1280003 B |
|                                          |               |         |         |                   |                   |                  |             |
| **ReadOnlyDictionary**                       | **StructStrings** | **10000**   | **True**    |         **238.08 ns** |         **16.195 ns** |         **0.888 ns** |       **168 B** |
| FrozenSet                                | StructStrings | 10000   | True    |         240.98 ns |          9.935 ns |         0.545 ns |       168 B |
| Dictionary                               | StructStrings | 10000   | True    |         248.28 ns |          6.319 ns |         0.346 ns |       168 B |
| HashSet                                  | StructStrings | 10000   | True    |         248.71 ns |         38.874 ns |         2.131 ns |       168 B |
| FrozenDictionary                         | StructStrings | 10000   | True    |         249.78 ns |         34.722 ns |         1.903 ns |       168 B |
| ImmutableHashSet                         | StructStrings | 10000   | True    |         255.40 ns |         34.860 ns |         1.911 ns |       168 B |
| ImmutableDictionary                      | StructStrings | 10000   | True    |         260.74 ns |         16.978 ns |         0.931 ns |       168 B |
| ImmutableSortedDictionary                | StructStrings | 10000   | True    |         325.29 ns |          8.490 ns |         0.465 ns |           - |
| &#39;ImmutableList (Sorted + BinarySearch)&#39;  | StructStrings | 10000   | True    |         333.79 ns |         73.001 ns |         4.001 ns |           - |
| ImmutableSortedSet                       | StructStrings | 10000   | True    |         341.06 ns |         30.372 ns |         1.665 ns |           - |
| SortedSet                                | StructStrings | 10000   | True    |         342.85 ns |        113.814 ns |         6.239 ns |           - |
| &#39;ImmutableArray (Sorted + BinarySearch)&#39; | StructStrings | 10000   | True    |         348.74 ns |         16.720 ns |         0.916 ns |           - |
| &#39;Array (Sorted + BinarySearch)&#39;          | StructStrings | 10000   | True    |         348.78 ns |         25.781 ns |         1.413 ns |           - |
| &#39;List (Sorted + BinarySearch)&#39;           | StructStrings | 10000   | True    |         350.46 ns |         39.144 ns |         2.146 ns |           - |
| SortedList                               | StructStrings | 10000   | True    |         359.00 ns |         21.958 ns |         1.204 ns |        40 B |
| SortedDictionary                         | StructStrings | 10000   | True    |         363.20 ns |         42.962 ns |         2.355 ns |        40 B |
| ImmutableList                            | StructStrings | 10000   | True    |     341,366.02 ns |     43,549.625 ns |     2,387.102 ns |    446796 B |
| LinkedList                               | StructStrings | 10000   | True    |     358,173.09 ns |     83,754.515 ns |     4,590.868 ns |    499857 B |
| ReadOnlyCollection                       | StructStrings | 10000   | True    |     366,695.62 ns |     40,503.461 ns |     2,220.131 ns |    499809 B |
| List                                     | StructStrings | 10000   | True    |     367,251.41 ns |     68,028.580 ns |     3,728.876 ns |    499809 B |
| ImmutableArray                           | StructStrings | 10000   | True    |     368,851.49 ns |     46,689.681 ns |     2,559.219 ns |    499809 B |
| Array                                    | StructStrings | 10000   | True    |     372,706.73 ns |     23,320.688 ns |     1,278.286 ns |    499809 B |
|                                          |               |         |         |                   |                   |                  |             |
| **FrozenDictionary**                         | **StructStrings** | **1000000** | **False**   |          **60.05 ns** |          **3.785 ns** |         **0.207 ns** |        **40 B** |
| FrozenSet                                | StructStrings | 1000000 | False   |          61.35 ns |          1.456 ns |         0.080 ns |        40 B |
| ReadOnlyDictionary                       | StructStrings | 1000000 | False   |          63.66 ns |          5.353 ns |         0.293 ns |        40 B |
| Dictionary                               | StructStrings | 1000000 | False   |          65.17 ns |          3.846 ns |         0.211 ns |        40 B |
| HashSet                                  | StructStrings | 1000000 | False   |          66.91 ns |         15.314 ns |         0.839 ns |        40 B |
| ImmutableDictionary                      | StructStrings | 1000000 | False   |         101.12 ns |          7.290 ns |         0.400 ns |        40 B |
| ImmutableHashSet                         | StructStrings | 1000000 | False   |         101.89 ns |          6.956 ns |         0.381 ns |        40 B |
| SortedSet                                | StructStrings | 1000000 | False   |         616.20 ns |          5.192 ns |         0.285 ns |           - |
| &#39;ImmutableArray (Sorted + BinarySearch)&#39; | StructStrings | 1000000 | False   |         632.43 ns |        120.363 ns |         6.598 ns |           - |
| &#39;Array (Sorted + BinarySearch)&#39;          | StructStrings | 1000000 | False   |         636.16 ns |         59.883 ns |         3.282 ns |           - |
| &#39;List (Sorted + BinarySearch)&#39;           | StructStrings | 1000000 | False   |         636.44 ns |         35.491 ns |         1.945 ns |           - |
| SortedList                               | StructStrings | 1000000 | False   |         645.11 ns |         43.501 ns |         2.384 ns |        40 B |
| &#39;ImmutableList (Sorted + BinarySearch)&#39;  | StructStrings | 1000000 | False   |         651.54 ns |         15.687 ns |         0.860 ns |           - |
| ImmutableSortedSet                       | StructStrings | 1000000 | False   |         668.59 ns |         26.499 ns |         1.453 ns |           - |
| ImmutableSortedDictionary                | StructStrings | 1000000 | False   |         669.59 ns |         12.099 ns |         0.663 ns |           - |
| SortedDictionary                         | StructStrings | 1000000 | False   |         677.99 ns |         33.847 ns |         1.855 ns |        40 B |
| Array                                    | StructStrings | 1000000 | False   |  95,091,486.11 ns |  8,029,018.601 ns |   440,097.602 ns | 128000169 B |
| LinkedList                               | StructStrings | 1000000 | False   |  97,047,738.89 ns |  4,990,152.560 ns |   273,527.100 ns | 128000169 B |
| ReadOnlyCollection                       | StructStrings | 1000000 | False   |  98,032,333.33 ns |  4,548,419.036 ns |   249,314.195 ns | 128000169 B |
| List                                     | StructStrings | 1000000 | False   | 100,145,550.00 ns | 31,377,981.921 ns | 1,719,933.069 ns | 128000169 B |
| ImmutableArray                           | StructStrings | 1000000 | False   | 100,738,208.33 ns |  7,776,512.995 ns |   426,256.918 ns | 128000169 B |
| ImmutableList                            | StructStrings | 1000000 | False   | 145,711,188.89 ns |  4,469,477.424 ns |   244,987.139 ns | 128000169 B |
|                                          |               |         |         |                   |                   |                  |             |
| **FrozenSet**                                | **StructStrings** | **1000000** | **True**    |         **243.78 ns** |          **9.635 ns** |         **0.528 ns** |       **168 B** |
| FrozenDictionary                         | StructStrings | 1000000 | True    |         252.57 ns |         19.415 ns |         1.064 ns |       168 B |
| HashSet                                  | StructStrings | 1000000 | True    |         259.26 ns |         18.610 ns |         1.020 ns |       168 B |
| ReadOnlyDictionary                       | StructStrings | 1000000 | True    |         260.06 ns |          1.412 ns |         0.077 ns |       168 B |
| Dictionary                               | StructStrings | 1000000 | True    |         264.20 ns |         48.228 ns |         2.644 ns |       168 B |
| ImmutableHashSet                         | StructStrings | 1000000 | True    |         286.84 ns |          6.861 ns |         0.376 ns |       168 B |
| ImmutableDictionary                      | StructStrings | 1000000 | True    |         291.90 ns |         98.978 ns |         5.425 ns |       168 B |
| &#39;ImmutableList (Sorted + BinarySearch)&#39;  | StructStrings | 1000000 | True    |         542.03 ns |          6.603 ns |         0.362 ns |           - |
| ImmutableSortedSet                       | StructStrings | 1000000 | True    |         548.27 ns |          6.691 ns |         0.367 ns |           - |
| &#39;Array (Sorted + BinarySearch)&#39;          | StructStrings | 1000000 | True    |         552.30 ns |         13.119 ns |         0.719 ns |           - |
| &#39;List (Sorted + BinarySearch)&#39;           | StructStrings | 1000000 | True    |         559.20 ns |         12.727 ns |         0.698 ns |           - |
| &#39;ImmutableArray (Sorted + BinarySearch)&#39; | StructStrings | 1000000 | True    |         559.38 ns |         96.803 ns |         5.306 ns |           - |
| SortedDictionary                         | StructStrings | 1000000 | True    |         564.96 ns |         17.604 ns |         0.965 ns |        40 B |
| ImmutableSortedDictionary                | StructStrings | 1000000 | True    |         566.47 ns |         33.632 ns |         1.843 ns |           - |
| SortedList                               | StructStrings | 1000000 | True    |         569.51 ns |         24.243 ns |         1.329 ns |        40 B |
| SortedSet                                | StructStrings | 1000000 | True    |         577.34 ns |         87.004 ns |         4.769 ns |           - |
| Array                                    | StructStrings | 1000000 | True    |  30,825,591.67 ns |  5,760,295.045 ns |   315,741.209 ns |  41035649 B |
| LinkedList                               | StructStrings | 1000000 | True    |  31,016,672.22 ns |  2,290,976.778 ns |   125,576.168 ns |  41035625 B |
| ReadOnlyCollection                       | StructStrings | 1000000 | True    |  31,466,625.00 ns |  6,630,397.332 ns |   363,434.451 ns |  41035649 B |
| List                                     | StructStrings | 1000000 | True    |  31,583,288.89 ns |  5,303,569.327 ns |   290,706.531 ns |  41035625 B |
| ImmutableArray                           | StructStrings | 1000000 | True    |  32,650,361.11 ns |  2,263,695.424 ns |   124,080.785 ns |  41035649 B |
| ImmutableList                            | StructStrings | 1000000 | True    |  40,588,894.44 ns |  2,575,861.050 ns |   141,191.636 ns |  35703105 B |
