```

BenchmarkDotNet v0.13.11, Windows 11 (10.0.22631.2861/23H2/2023Update/SunValley3)
AMD Ryzen 7 5800H with Radeon Graphics, 1 CPU, 16 logical and 8 physical cores
.NET SDK 8.0.100
  [Host]   : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                                   | DataType     | Length  | Existed | Mean             | Error            | StdDev         | Allocated |
|----------------------------------------- |------------- |-------- |-------- |-----------------:|-----------------:|---------------:|----------:|
| **FrozenDictionary**                         | **ClassStrings** | **10000**   | **False**   |         **23.12 ns** |         **1.206 ns** |       **0.066 ns** |         **-** |
| Dictionary                               | ClassStrings | 10000   | False   |         25.03 ns |         0.676 ns |       0.037 ns |         - |
| HashSet                                  | ClassStrings | 10000   | False   |         25.26 ns |         0.385 ns |       0.021 ns |         - |
| FrozenSet                                | ClassStrings | 10000   | False   |         25.41 ns |         0.884 ns |       0.048 ns |         - |
| ReadOnlyDictionary                       | ClassStrings | 10000   | False   |         26.47 ns |         0.975 ns |       0.053 ns |         - |
| ImmutableHashSet                         | ClassStrings | 10000   | False   |         37.54 ns |         7.719 ns |       0.423 ns |         - |
| ImmutableDictionary                      | ClassStrings | 10000   | False   |         37.61 ns |        10.063 ns |       0.552 ns |         - |
| SortedSet                                | ClassStrings | 10000   | False   |        414.25 ns |       127.037 ns |       6.963 ns |         - |
| &#39;List (Sorted + BinarySearch)&#39;           | ClassStrings | 10000   | False   |        419.64 ns |        12.418 ns |       0.681 ns |         - |
| &#39;ImmutableArray (Sorted + BinarySearch)&#39; | ClassStrings | 10000   | False   |        421.78 ns |        20.011 ns |       1.097 ns |         - |
| &#39;Array (Sorted + BinarySearch)&#39;          | ClassStrings | 10000   | False   |        426.28 ns |        34.448 ns |       1.888 ns |         - |
| SortedList                               | ClassStrings | 10000   | False   |        430.89 ns |        13.937 ns |       0.764 ns |         - |
| ImmutableSortedSet                       | ClassStrings | 10000   | False   |        434.63 ns |        36.606 ns |       2.006 ns |         - |
| ImmutableSortedDictionary                | ClassStrings | 10000   | False   |        440.29 ns |       110.336 ns |       6.048 ns |         - |
| SortedDictionary                         | ClassStrings | 10000   | False   |        458.81 ns |         8.690 ns |       0.476 ns |         - |
| &#39;ImmutableList (Sorted + BinarySearch)&#39;  | ClassStrings | 10000   | False   |        471.68 ns |        51.416 ns |       2.818 ns |         - |
| ReadOnlyCollection                       | ClassStrings | 10000   | False   |     13,488.36 ns |    21,869.081 ns |   1,198.718 ns |         - |
| Array                                    | ClassStrings | 10000   | False   |     39,152.93 ns |    18,368.601 ns |   1,006.845 ns |         - |
| ImmutableArray                           | ClassStrings | 10000   | False   |     39,406.23 ns |     5,705.045 ns |     312.713 ns |         - |
| List                                     | ClassStrings | 10000   | False   |     40,887.59 ns |     5,944.014 ns |     325.811 ns |         - |
| LinkedList                               | ClassStrings | 10000   | False   |     41,153.40 ns |    11,880.649 ns |     651.218 ns |         - |
| ImmutableList                            | ClassStrings | 10000   | False   |    296,772.93 ns |    22,249.870 ns |   1,219.590 ns |         - |
|                                          |              |         |         |                  |                  |                |           |
| **FrozenDictionary**                         | **ClassStrings** | **10000**   | **True**    |         **26.93 ns** |         **2.151 ns** |       **0.118 ns** |         **-** |
| HashSet                                  | ClassStrings | 10000   | True    |         29.22 ns |         1.950 ns |       0.107 ns |         - |
| Dictionary                               | ClassStrings | 10000   | True    |         29.56 ns |         1.952 ns |       0.107 ns |         - |
| FrozenSet                                | ClassStrings | 10000   | True    |         31.75 ns |         1.114 ns |       0.061 ns |         - |
| ReadOnlyDictionary                       | ClassStrings | 10000   | True    |         32.32 ns |         2.778 ns |       0.152 ns |         - |
| ImmutableHashSet                         | ClassStrings | 10000   | True    |         37.10 ns |         4.562 ns |       0.250 ns |         - |
| ImmutableDictionary                      | ClassStrings | 10000   | True    |         39.86 ns |         0.881 ns |       0.048 ns |         - |
| ImmutableSortedSet                       | ClassStrings | 10000   | True    |        346.88 ns |        27.945 ns |       1.532 ns |         - |
| ImmutableSortedDictionary                | ClassStrings | 10000   | True    |        354.21 ns |        17.837 ns |       0.978 ns |         - |
| SortedSet                                | ClassStrings | 10000   | True    |        370.60 ns |        29.373 ns |       1.610 ns |         - |
| &#39;List (Sorted + BinarySearch)&#39;           | ClassStrings | 10000   | True    |        379.98 ns |        22.417 ns |       1.229 ns |         - |
| &#39;Array (Sorted + BinarySearch)&#39;          | ClassStrings | 10000   | True    |        384.93 ns |        14.287 ns |       0.783 ns |         - |
| &#39;ImmutableList (Sorted + BinarySearch)&#39;  | ClassStrings | 10000   | True    |        386.19 ns |        23.717 ns |       1.300 ns |         - |
| &#39;ImmutableArray (Sorted + BinarySearch)&#39; | ClassStrings | 10000   | True    |        388.72 ns |        11.621 ns |       0.637 ns |         - |
| SortedList                               | ClassStrings | 10000   | True    |        392.79 ns |        89.993 ns |       4.933 ns |         - |
| SortedDictionary                         | ClassStrings | 10000   | True    |        400.91 ns |        31.472 ns |       1.725 ns |         - |
| ReadOnlyCollection                       | ClassStrings | 10000   | True    |      4,289.57 ns |     7,833.287 ns |     429.369 ns |         - |
| LinkedList                               | ClassStrings | 10000   | True    |     15,221.73 ns |     1,539.270 ns |      84.373 ns |         - |
| Array                                    | ClassStrings | 10000   | True    |     15,232.61 ns |     5,197.365 ns |     284.885 ns |         - |
| List                                     | ClassStrings | 10000   | True    |     15,567.46 ns |     2,259.223 ns |     123.836 ns |         - |
| ImmutableArray                           | ClassStrings | 10000   | True    |     16,875.20 ns |     3,404.065 ns |     186.588 ns |         - |
| ImmutableList                            | ClassStrings | 10000   | True    |    114,270.82 ns |    28,055.332 ns |   1,537.807 ns |         - |
|                                          |              |         |         |                  |                  |                |           |
| **FrozenDictionary**                         | **ClassStrings** | **1000000** | **False**   |         **23.37 ns** |         **0.880 ns** |       **0.048 ns** |         **-** |
| Dictionary                               | ClassStrings | 1000000 | False   |         24.86 ns |         3.916 ns |       0.215 ns |         - |
| HashSet                                  | ClassStrings | 1000000 | False   |         25.32 ns |         1.613 ns |       0.088 ns |         - |
| FrozenSet                                | ClassStrings | 1000000 | False   |         26.00 ns |         1.342 ns |       0.074 ns |         - |
| ReadOnlyDictionary                       | ClassStrings | 1000000 | False   |         27.31 ns |         2.592 ns |       0.142 ns |         - |
| ImmutableHashSet                         | ClassStrings | 1000000 | False   |         62.47 ns |         4.334 ns |       0.238 ns |         - |
| ImmutableDictionary                      | ClassStrings | 1000000 | False   |         64.92 ns |         4.759 ns |       0.261 ns |         - |
| SortedSet                                | ClassStrings | 1000000 | False   |        664.67 ns |        80.877 ns |       4.433 ns |         - |
| &#39;Array (Sorted + BinarySearch)&#39;          | ClassStrings | 1000000 | False   |        699.78 ns |        10.722 ns |       0.588 ns |         - |
| &#39;List (Sorted + BinarySearch)&#39;           | ClassStrings | 1000000 | False   |        702.58 ns |        51.457 ns |       2.821 ns |         - |
| ImmutableSortedSet                       | ClassStrings | 1000000 | False   |        703.18 ns |        41.692 ns |       2.285 ns |         - |
| SortedList                               | ClassStrings | 1000000 | False   |        708.36 ns |        13.551 ns |       0.743 ns |         - |
| &#39;ImmutableArray (Sorted + BinarySearch)&#39; | ClassStrings | 1000000 | False   |        714.88 ns |        61.849 ns |       3.390 ns |         - |
| ImmutableSortedDictionary                | ClassStrings | 1000000 | False   |        727.66 ns |        75.119 ns |       4.118 ns |         - |
| SortedDictionary                         | ClassStrings | 1000000 | False   |        745.82 ns |        30.930 ns |       1.695 ns |         - |
| &#39;ImmutableList (Sorted + BinarySearch)&#39;  | ClassStrings | 1000000 | False   |        777.64 ns |         5.193 ns |       0.285 ns |         - |
| ReadOnlyCollection                       | ClassStrings | 1000000 | False   |  4,470,545.37 ns |   676,934.353 ns |  37,105.056 ns |      20 B |
| List                                     | ClassStrings | 1000000 | False   |  8,206,606.67 ns |    63,702.217 ns |   3,491.733 ns |      12 B |
| ImmutableArray                           | ClassStrings | 1000000 | False   |  8,221,751.39 ns |   107,273.000 ns |   5,879.995 ns |      10 B |
| Array                                    | ClassStrings | 1000000 | False   |  8,299,572.22 ns | 1,720,533.171 ns |  94,308.229 ns |      10 B |
| LinkedList                               | ClassStrings | 1000000 | False   |  8,900,280.56 ns | 2,690,297.812 ns | 147,464.301 ns |      12 B |
| ImmutableList                            | ClassStrings | 1000000 | False   | 44,329,483.33 ns | 2,122,528.704 ns | 116,342.960 ns |      61 B |
|                                          |              |         |         |                  |                  |                |           |
| **FrozenDictionary**                         | **ClassStrings** | **1000000** | **True**    |         **28.25 ns** |         **1.025 ns** |       **0.056 ns** |         **-** |
| HashSet                                  | ClassStrings | 1000000 | True    |         30.70 ns |         2.226 ns |       0.122 ns |         - |
| Dictionary                               | ClassStrings | 1000000 | True    |         30.84 ns |         1.758 ns |       0.096 ns |         - |
| ReadOnlyDictionary                       | ClassStrings | 1000000 | True    |         32.77 ns |         1.713 ns |       0.094 ns |         - |
| FrozenSet                                | ClassStrings | 1000000 | True    |         34.26 ns |         0.976 ns |       0.054 ns |         - |
| ImmutableDictionary                      | ClassStrings | 1000000 | True    |         61.08 ns |         5.356 ns |       0.294 ns |         - |
| ImmutableHashSet                         | ClassStrings | 1000000 | True    |         63.00 ns |         3.055 ns |       0.167 ns |         - |
| ImmutableSortedDictionary                | ClassStrings | 1000000 | True    |        585.65 ns |        35.181 ns |       1.928 ns |         - |
| ImmutableSortedSet                       | ClassStrings | 1000000 | True    |        593.48 ns |        48.361 ns |       2.651 ns |         - |
| SortedDictionary                         | ClassStrings | 1000000 | True    |        609.99 ns |        22.016 ns |       1.207 ns |         - |
| SortedSet                                | ClassStrings | 1000000 | True    |        616.80 ns |        41.705 ns |       2.286 ns |         - |
| &#39;List (Sorted + BinarySearch)&#39;           | ClassStrings | 1000000 | True    |        619.53 ns |        22.590 ns |       1.238 ns |         - |
| &#39;ImmutableArray (Sorted + BinarySearch)&#39; | ClassStrings | 1000000 | True    |        620.31 ns |        37.736 ns |       2.068 ns |         - |
| SortedList                               | ClassStrings | 1000000 | True    |        630.28 ns |        22.548 ns |       1.236 ns |         - |
| &#39;Array (Sorted + BinarySearch)&#39;          | ClassStrings | 1000000 | True    |        630.81 ns |       243.530 ns |      13.349 ns |         - |
| &#39;ImmutableList (Sorted + BinarySearch)&#39;  | ClassStrings | 1000000 | True    |        651.87 ns |        29.814 ns |       1.634 ns |         - |
| ReadOnlyCollection                       | ClassStrings | 1000000 | True    |  1,332,282.20 ns |   403,310.773 ns |  22,106.824 ns |       2 B |
| ImmutableArray                           | ClassStrings | 1000000 | True    |  2,620,489.50 ns |   549,130.002 ns |  30,099.668 ns |       4 B |
| List                                     | ClassStrings | 1000000 | True    |  2,623,128.82 ns |    81,528.375 ns |   4,468.845 ns |       4 B |
| Array                                    | ClassStrings | 1000000 | True    |  2,631,549.48 ns |    44,442.952 ns |   2,436.068 ns |       4 B |
| LinkedList                               | ClassStrings | 1000000 | True    |  2,798,158.52 ns |   247,990.662 ns |  13,593.205 ns |       4 B |
| ImmutableList                            | ClassStrings | 1000000 | True    | 14,122,673.15 ns |   987,621.752 ns |  54,134.881 ns |      20 B |
