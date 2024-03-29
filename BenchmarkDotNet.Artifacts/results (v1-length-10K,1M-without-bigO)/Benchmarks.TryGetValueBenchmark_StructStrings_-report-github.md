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
| **Dictionary**                               | **StructStrings** | **10000**   | **False**   |          **58.18 ns** |          **2.617 ns** |         **0.143 ns** |        **40 B** |
| ReadOnlyDictionary                       | StructStrings | 10000   | False   |          58.99 ns |          7.101 ns |         0.389 ns |        40 B |
| FrozenDictionary                         | StructStrings | 10000   | False   |          59.53 ns |          3.204 ns |         0.176 ns |        40 B |
| FrozenSet                                | StructStrings | 10000   | False   |          60.02 ns |          3.396 ns |         0.186 ns |        40 B |
| HashSet                                  | StructStrings | 10000   | False   |          62.35 ns |          4.048 ns |         0.222 ns |        40 B |
| ImmutableHashSet                         | StructStrings | 10000   | False   |          73.74 ns |         11.782 ns |         0.646 ns |        40 B |
| ImmutableDictionary                      | StructStrings | 10000   | False   |          74.69 ns |          9.544 ns |         0.523 ns |        40 B |
| &#39;List (Sorted + BinarySearch)&#39;           | StructStrings | 10000   | False   |         392.17 ns |         25.084 ns |         1.375 ns |           - |
| SortedSet                                | StructStrings | 10000   | False   |         393.58 ns |         26.626 ns |         1.459 ns |           - |
| &#39;ImmutableArray (Sorted + BinarySearch)&#39; | StructStrings | 10000   | False   |         394.50 ns |         77.660 ns |         4.257 ns |           - |
| &#39;Array (Sorted + BinarySearch)&#39;          | StructStrings | 10000   | False   |         395.28 ns |         63.731 ns |         3.493 ns |           - |
| SortedList                               | StructStrings | 10000   | False   |         400.79 ns |         64.010 ns |         3.509 ns |        40 B |
| &#39;ImmutableList (Sorted + BinarySearch)&#39;  | StructStrings | 10000   | False   |         407.51 ns |         12.131 ns |         0.665 ns |           - |
| ImmutableSortedSet                       | StructStrings | 10000   | False   |         411.06 ns |         26.543 ns |         1.455 ns |           - |
| SortedDictionary                         | StructStrings | 10000   | False   |         420.32 ns |        142.980 ns |         7.837 ns |        40 B |
| ImmutableSortedDictionary                | StructStrings | 10000   | False   |         429.16 ns |        295.638 ns |        16.205 ns |           - |
| LinkedList                               | StructStrings | 10000   | False   |     923,584.85 ns |     70,025.948 ns |     3,838.358 ns |   1280003 B |
| List                                     | StructStrings | 10000   | False   |     936,486.72 ns |    117,985.425 ns |     6,467.179 ns |   1280002 B |
| ImmutableArray                           | StructStrings | 10000   | False   |     939,787.70 ns |    127,424.432 ns |     6,984.563 ns |   1280002 B |
| Array                                    | StructStrings | 10000   | False   |     948,617.38 ns |    132,125.490 ns |     7,242.244 ns |   1280001 B |
| ReadOnlyCollection                       | StructStrings | 10000   | False   |     956,563.87 ns |     55,718.622 ns |     3,054.126 ns |   1280002 B |
| ImmutableList                            | StructStrings | 10000   | False   |   1,080,233.12 ns |    177,798.487 ns |     9,745.735 ns |   1280003 B |
|                                          |               |         |         |                   |                   |                  |             |
| **FrozenSet**                                | **StructStrings** | **10000**   | **True**    |         **236.20 ns** |         **12.223 ns** |         **0.670 ns** |       **168 B** |
| FrozenDictionary                         | StructStrings | 10000   | True    |         240.67 ns |         29.735 ns |         1.630 ns |       168 B |
| ReadOnlyDictionary                       | StructStrings | 10000   | True    |         247.83 ns |         18.418 ns |         1.010 ns |       168 B |
| HashSet                                  | StructStrings | 10000   | True    |         248.98 ns |         26.253 ns |         1.439 ns |       168 B |
| Dictionary                               | StructStrings | 10000   | True    |         249.85 ns |         19.088 ns |         1.046 ns |       168 B |
| ImmutableHashSet                         | StructStrings | 10000   | True    |         257.88 ns |         29.801 ns |         1.633 ns |       168 B |
| ImmutableDictionary                      | StructStrings | 10000   | True    |         277.76 ns |        108.753 ns |         5.961 ns |       168 B |
| ImmutableSortedDictionary                | StructStrings | 10000   | True    |         329.60 ns |          6.342 ns |         0.348 ns |           - |
| ImmutableSortedSet                       | StructStrings | 10000   | True    |         331.51 ns |         29.665 ns |         1.626 ns |           - |
| &#39;ImmutableList (Sorted + BinarySearch)&#39;  | StructStrings | 10000   | True    |         337.00 ns |          8.975 ns |         0.492 ns |           - |
| SortedSet                                | StructStrings | 10000   | True    |         338.92 ns |         25.004 ns |         1.371 ns |           - |
| &#39;Array (Sorted + BinarySearch)&#39;          | StructStrings | 10000   | True    |         347.39 ns |         25.173 ns |         1.380 ns |           - |
| &#39;List (Sorted + BinarySearch)&#39;           | StructStrings | 10000   | True    |         349.13 ns |          8.212 ns |         0.450 ns |           - |
| &#39;ImmutableArray (Sorted + BinarySearch)&#39; | StructStrings | 10000   | True    |         349.52 ns |         26.747 ns |         1.466 ns |           - |
| SortedList                               | StructStrings | 10000   | True    |         361.94 ns |         10.766 ns |         0.590 ns |        40 B |
| SortedDictionary                         | StructStrings | 10000   | True    |         365.96 ns |         68.821 ns |         3.772 ns |        40 B |
| LinkedList                               | StructStrings | 10000   | True    |     355,497.22 ns |     14,179.580 ns |       777.231 ns |    499857 B |
| Array                                    | StructStrings | 10000   | True    |     363,722.89 ns |     45,494.028 ns |     2,493.681 ns |    499809 B |
| ImmutableArray                           | StructStrings | 10000   | True    |     364,811.00 ns |     51,085.248 ns |     2,800.155 ns |    499809 B |
| ReadOnlyCollection                       | StructStrings | 10000   | True    |     394,803.63 ns |     50,041.882 ns |     2,742.964 ns |    499809 B |
| List                                     | StructStrings | 10000   | True    |     412,552.11 ns |    155,782.345 ns |     8,538.956 ns |    499809 B |
| ImmutableList                            | StructStrings | 10000   | True    |     430,776.45 ns |     92,228.277 ns |     5,055.343 ns |    499857 B |
|                                          |               |         |         |                   |                   |                  |             |
| **Dictionary**                               | **StructStrings** | **1000000** | **False**   |          **59.43 ns** |          **2.951 ns** |         **0.162 ns** |        **40 B** |
| FrozenDictionary                         | StructStrings | 1000000 | False   |          60.31 ns |          2.320 ns |         0.127 ns |        40 B |
| FrozenSet                                | StructStrings | 1000000 | False   |          60.55 ns |          1.597 ns |         0.088 ns |        40 B |
| HashSet                                  | StructStrings | 1000000 | False   |          63.21 ns |          6.850 ns |         0.375 ns |        40 B |
| ReadOnlyDictionary                       | StructStrings | 1000000 | False   |          63.96 ns |          5.736 ns |         0.314 ns |        40 B |
| ImmutableDictionary                      | StructStrings | 1000000 | False   |         101.53 ns |          2.234 ns |         0.122 ns |        40 B |
| ImmutableHashSet                         | StructStrings | 1000000 | False   |         107.09 ns |          7.909 ns |         0.433 ns |        40 B |
| SortedSet                                | StructStrings | 1000000 | False   |         621.62 ns |         13.282 ns |         0.728 ns |           - |
| &#39;ImmutableArray (Sorted + BinarySearch)&#39; | StructStrings | 1000000 | False   |         625.60 ns |         11.301 ns |         0.619 ns |           - |
| &#39;List (Sorted + BinarySearch)&#39;           | StructStrings | 1000000 | False   |         626.51 ns |         12.904 ns |         0.707 ns |           - |
| &#39;Array (Sorted + BinarySearch)&#39;          | StructStrings | 1000000 | False   |         630.23 ns |          7.467 ns |         0.409 ns |           - |
| SortedList                               | StructStrings | 1000000 | False   |         645.06 ns |         18.961 ns |         1.039 ns |        40 B |
| ImmutableSortedDictionary                | StructStrings | 1000000 | False   |         665.42 ns |         12.237 ns |         0.671 ns |           - |
| ImmutableSortedSet                       | StructStrings | 1000000 | False   |         666.69 ns |         31.923 ns |         1.750 ns |           - |
| SortedDictionary                         | StructStrings | 1000000 | False   |         671.46 ns |        263.388 ns |        14.437 ns |        40 B |
| &#39;ImmutableList (Sorted + BinarySearch)&#39;  | StructStrings | 1000000 | False   |         680.26 ns |         19.224 ns |         1.054 ns |           - |
| Array                                    | StructStrings | 1000000 | False   |  95,375,416.67 ns | 14,416,335.190 ns |   790,207.978 ns | 128000141 B |
| List                                     | StructStrings | 1000000 | False   |  96,692,950.00 ns |  8,922,433.584 ns |   489,068.692 ns | 128000223 B |
| ImmutableArray                           | StructStrings | 1000000 | False   |  96,748,600.00 ns |  9,090,513.312 ns |   498,281.709 ns | 128000169 B |
| LinkedList                               | StructStrings | 1000000 | False   |  97,906,280.56 ns | 14,150,969.313 ns |   775,662.378 ns | 128000223 B |
| ReadOnlyCollection                       | StructStrings | 1000000 | False   |  98,088,872.22 ns | 20,742,448.742 ns | 1,136,963.608 ns | 128000169 B |
| ImmutableList                            | StructStrings | 1000000 | False   | 155,587,572.22 ns | 12,717,284.566 ns |   697,077.280 ns | 128000169 B |
|                                          |               |         |         |                   |                   |                  |             |
| **Dictionary**                               | **StructStrings** | **1000000** | **True**    |         **240.32 ns** |          **7.705 ns** |         **0.422 ns** |       **168 B** |
| ReadOnlyDictionary                       | StructStrings | 1000000 | True    |         247.13 ns |         10.594 ns |         0.581 ns |       168 B |
| FrozenDictionary                         | StructStrings | 1000000 | True    |         248.22 ns |         21.526 ns |         1.180 ns |       168 B |
| FrozenSet                                | StructStrings | 1000000 | True    |         252.67 ns |         18.071 ns |         0.991 ns |       168 B |
| HashSet                                  | StructStrings | 1000000 | True    |         258.11 ns |          6.363 ns |         0.349 ns |       168 B |
| ImmutableHashSet                         | StructStrings | 1000000 | True    |         285.01 ns |         36.649 ns |         2.009 ns |       168 B |
| ImmutableDictionary                      | StructStrings | 1000000 | True    |         291.33 ns |         18.670 ns |         1.023 ns |       168 B |
| ImmutableSortedSet                       | StructStrings | 1000000 | True    |         552.81 ns |         17.355 ns |         0.951 ns |           - |
| &#39;Array (Sorted + BinarySearch)&#39;          | StructStrings | 1000000 | True    |         558.81 ns |         79.830 ns |         4.376 ns |           - |
| SortedDictionary                         | StructStrings | 1000000 | True    |         559.50 ns |         54.098 ns |         2.965 ns |        40 B |
| &#39;List (Sorted + BinarySearch)&#39;           | StructStrings | 1000000 | True    |         561.16 ns |         83.636 ns |         4.584 ns |           - |
| ImmutableSortedDictionary                | StructStrings | 1000000 | True    |         572.05 ns |         13.214 ns |         0.724 ns |           - |
| &#39;ImmutableList (Sorted + BinarySearch)&#39;  | StructStrings | 1000000 | True    |         572.11 ns |         38.053 ns |         2.086 ns |           - |
| &#39;ImmutableArray (Sorted + BinarySearch)&#39; | StructStrings | 1000000 | True    |         572.50 ns |        185.995 ns |        10.195 ns |           - |
| SortedSet                                | StructStrings | 1000000 | True    |         574.15 ns |         11.655 ns |         0.639 ns |           - |
| SortedList                               | StructStrings | 1000000 | True    |         576.14 ns |         21.175 ns |         1.161 ns |        40 B |
| ImmutableArray                           | StructStrings | 1000000 | True    |  31,377,947.22 ns |  7,819,230.194 ns |   428,598.392 ns |  41035649 B |
| ReadOnlyCollection                       | StructStrings | 1000000 | True    |  31,506,655.56 ns |  6,671,614.396 ns |   365,693.697 ns |  41035625 B |
| Array                                    | StructStrings | 1000000 | True    |  31,793,125.00 ns | 17,050,390.848 ns |   934,589.456 ns |  41035649 B |
| List                                     | StructStrings | 1000000 | True    |  32,373,941.67 ns |  4,087,940.439 ns |   224,073.810 ns |  41035649 B |
| LinkedList                               | StructStrings | 1000000 | True    |  33,378,225.00 ns |  8,057,761.991 ns |   441,673.124 ns |  41035649 B |
| ImmutableList                            | StructStrings | 1000000 | True    |  51,350,069.44 ns |  8,613,835.878 ns |   472,153.411 ns |  41035649 B |
