```

BenchmarkDotNet v0.13.11, Windows 11 (10.0.22631.2861/23H2/2023Update/SunValley3)
AMD Ryzen 7 5800H with Radeon Graphics, 1 CPU, 16 logical and 8 physical cores
.NET SDK 8.0.100
  [Host]   : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                                   | DataType   | Length  | Existed | Mean             | Error            | StdDev         | Allocated  |
|----------------------------------------- |----------- |-------- |-------- |-----------------:|-----------------:|---------------:|-----------:|
| **FrozenSet**                                | **StructInts** | **10000**   | **False**   |         **15.49 ns** |         **7.297 ns** |       **0.400 ns** |       **32 B** |
| FrozenDictionary                         | StructInts | 10000   | False   |         15.55 ns |         4.088 ns |       0.224 ns |       32 B |
| SortedSet                                | StructInts | 10000   | False   |         15.69 ns |         1.636 ns |       0.090 ns |          - |
| ReadOnlyDictionary                       | StructInts | 10000   | False   |         17.13 ns |         4.493 ns |       0.246 ns |       32 B |
| HashSet                                  | StructInts | 10000   | False   |         17.13 ns |         4.154 ns |       0.228 ns |       32 B |
| Dictionary                               | StructInts | 10000   | False   |         17.13 ns |         5.707 ns |       0.313 ns |       32 B |
| &#39;Array (Sorted + BinarySearch)&#39;          | StructInts | 10000   | False   |         21.34 ns |         1.019 ns |       0.056 ns |          - |
| &#39;List (Sorted + BinarySearch)&#39;           | StructInts | 10000   | False   |         22.79 ns |         0.925 ns |       0.051 ns |          - |
| &#39;ImmutableArray (Sorted + BinarySearch)&#39; | StructInts | 10000   | False   |         22.80 ns |         1.665 ns |       0.091 ns |          - |
| SortedList                               | StructInts | 10000   | False   |         23.22 ns |         1.748 ns |       0.096 ns |       32 B |
| ImmutableHashSet                         | StructInts | 10000   | False   |         28.03 ns |         8.310 ns |       0.456 ns |       32 B |
| ImmutableDictionary                      | StructInts | 10000   | False   |         29.06 ns |         7.314 ns |       0.401 ns |       32 B |
| SortedDictionary                         | StructInts | 10000   | False   |         29.36 ns |         0.665 ns |       0.036 ns |       32 B |
| &#39;ImmutableList (Sorted + BinarySearch)&#39;  | StructInts | 10000   | False   |         40.30 ns |         4.550 ns |       0.249 ns |          - |
| ImmutableSortedDictionary                | StructInts | 10000   | False   |         44.04 ns |         1.930 ns |       0.106 ns |          - |
| ImmutableSortedSet                       | StructInts | 10000   | False   |         45.35 ns |         1.418 ns |       0.078 ns |          - |
| ImmutableArray                           | StructInts | 10000   | False   |     92,088.59 ns |    12,583.946 ns |     689.769 ns |   640000 B |
| Array                                    | StructInts | 10000   | False   |     94,097.20 ns |    16,533.553 ns |     906.260 ns |   640000 B |
| List                                     | StructInts | 10000   | False   |     94,204.54 ns |    33,545.683 ns |   1,838.752 ns |   640000 B |
| ReadOnlyCollection                       | StructInts | 10000   | False   |     96,002.80 ns |    17,546.888 ns |     961.804 ns |   640000 B |
| LinkedList                               | StructInts | 10000   | False   |    123,252.68 ns |    16,623.882 ns |     911.211 ns |   640000 B |
| ImmutableList                            | StructInts | 10000   | False   |    173,945.00 ns |    32,394.414 ns |   1,775.647 ns |   640000 B |
|                                          |            |         |         |                  |                  |                |            |
| **SortedSet**                                | **StructInts** | **10000**   | **True**    |         **21.77 ns** |         **2.537 ns** |       **0.139 ns** |          **-** |
| &#39;List (Sorted + BinarySearch)&#39;           | StructInts | 10000   | True    |         24.78 ns |         0.915 ns |       0.050 ns |          - |
| &#39;ImmutableArray (Sorted + BinarySearch)&#39; | StructInts | 10000   | True    |         24.98 ns |         7.345 ns |       0.403 ns |          - |
| &#39;Array (Sorted + BinarySearch)&#39;          | StructInts | 10000   | True    |         25.00 ns |         2.793 ns |       0.153 ns |          - |
| SortedDictionary                         | StructInts | 10000   | True    |         26.00 ns |         1.993 ns |       0.109 ns |       32 B |
| SortedList                               | StructInts | 10000   | True    |         27.76 ns |         3.181 ns |       0.174 ns |       32 B |
| FrozenSet                                | StructInts | 10000   | True    |         28.68 ns |        13.667 ns |       0.749 ns |       96 B |
| FrozenDictionary                         | StructInts | 10000   | True    |         29.38 ns |        13.167 ns |       0.722 ns |       96 B |
| ReadOnlyDictionary                       | StructInts | 10000   | True    |         29.52 ns |        10.983 ns |       0.602 ns |       96 B |
| Dictionary                               | StructInts | 10000   | True    |         29.70 ns |        11.793 ns |       0.646 ns |       96 B |
| HashSet                                  | StructInts | 10000   | True    |         29.93 ns |        10.121 ns |       0.555 ns |       96 B |
| &#39;ImmutableList (Sorted + BinarySearch)&#39;  | StructInts | 10000   | True    |         34.76 ns |         1.277 ns |       0.070 ns |          - |
| ImmutableSortedDictionary                | StructInts | 10000   | True    |         35.49 ns |         5.207 ns |       0.285 ns |          - |
| ImmutableSortedSet                       | StructInts | 10000   | True    |         36.04 ns |         3.233 ns |       0.177 ns |          - |
| ImmutableHashSet                         | StructInts | 10000   | True    |         37.40 ns |         8.905 ns |       0.488 ns |       96 B |
| ImmutableDictionary                      | StructInts | 10000   | True    |         38.70 ns |        16.038 ns |       0.879 ns |       96 B |
| List                                     | StructInts | 10000   | True    |     46,844.04 ns |    39,433.205 ns |   2,161.467 ns |   300576 B |
| ReadOnlyCollection                       | StructInts | 10000   | True    |     46,847.21 ns |    34,586.110 ns |   1,895.781 ns |   300576 B |
| ImmutableArray                           | StructInts | 10000   | True    |     48,968.06 ns |    40,634.333 ns |   2,227.305 ns |   300576 B |
| Array                                    | StructInts | 10000   | True    |     49,333.11 ns |    31,901.107 ns |   1,748.607 ns |   300576 B |
| LinkedList                               | StructInts | 10000   | True    |     60,574.24 ns |    22,463.542 ns |   1,231.303 ns |   300576 B |
| ImmutableList                            | StructInts | 10000   | True    |     72,392.88 ns |    46,356.638 ns |   2,540.964 ns |   274101 B |
|                                          |            |         |         |                  |                  |                |            |
| **FrozenSet**                                | **StructInts** | **1000000** | **False**   |         **15.83 ns** |         **1.114 ns** |       **0.061 ns** |       **32 B** |
| FrozenDictionary                         | StructInts | 1000000 | False   |         16.02 ns |         0.725 ns |       0.040 ns |       32 B |
| Dictionary                               | StructInts | 1000000 | False   |         17.04 ns |         1.630 ns |       0.089 ns |       32 B |
| HashSet                                  | StructInts | 1000000 | False   |         17.07 ns |         3.388 ns |       0.186 ns |       32 B |
| ReadOnlyDictionary                       | StructInts | 1000000 | False   |         17.14 ns |         2.704 ns |       0.148 ns |       32 B |
| SortedSet                                | StructInts | 1000000 | False   |         28.42 ns |         0.951 ns |       0.052 ns |          - |
| &#39;ImmutableArray (Sorted + BinarySearch)&#39; | StructInts | 1000000 | False   |         30.63 ns |         1.501 ns |       0.082 ns |          - |
| &#39;List (Sorted + BinarySearch)&#39;           | StructInts | 1000000 | False   |         30.69 ns |         1.329 ns |       0.073 ns |          - |
| &#39;Array (Sorted + BinarySearch)&#39;          | StructInts | 1000000 | False   |         30.86 ns |         2.709 ns |       0.148 ns |          - |
| SortedList                               | StructInts | 1000000 | False   |         32.81 ns |         1.392 ns |       0.076 ns |       32 B |
| ImmutableDictionary                      | StructInts | 1000000 | False   |         55.34 ns |         4.406 ns |       0.241 ns |       32 B |
| ImmutableSortedDictionary                | StructInts | 1000000 | False   |         56.11 ns |         0.356 ns |       0.020 ns |          - |
| ImmutableHashSet                         | StructInts | 1000000 | False   |         56.48 ns |         2.026 ns |       0.111 ns |       32 B |
| ImmutableSortedSet                       | StructInts | 1000000 | False   |         61.02 ns |         1.297 ns |       0.071 ns |          - |
| SortedDictionary                         | StructInts | 1000000 | False   |         63.09 ns |         0.976 ns |       0.054 ns |       32 B |
| &#39;ImmutableList (Sorted + BinarySearch)&#39;  | StructInts | 1000000 | False   |         66.84 ns |         2.886 ns |       0.158 ns |          - |
| Array                                    | StructInts | 1000000 | False   | 11,451,568.06 ns | 2,555,052.081 ns | 140,051.026 ns | 64000015 B |
| ImmutableArray                           | StructInts | 1000000 | False   | 11,484,548.61 ns | 2,918,092.550 ns | 159,950.499 ns | 64000015 B |
| List                                     | StructInts | 1000000 | False   | 11,694,918.75 ns | 1,606,206.417 ns |  88,041.594 ns | 64000015 B |
| ReadOnlyCollection                       | StructInts | 1000000 | False   | 11,870,701.39 ns | 5,120,833.515 ns | 280,690.164 ns | 64000015 B |
| LinkedList                               | StructInts | 1000000 | False   | 12,247,570.37 ns | 1,835,317.877 ns | 100,599.966 ns | 64000020 B |
| ImmutableList                            | StructInts | 1000000 | False   | 30,995,344.44 ns |   306,960.925 ns |  16,825.564 ns | 64000061 B |
|                                          |            |         |         |                  |                  |                |            |
| **SortedSet**                                | **StructInts** | **1000000** | **True**    |         **28.31 ns** |         **3.505 ns** |       **0.192 ns** |          **-** |
| FrozenSet                                | StructInts | 1000000 | True    |         29.45 ns |         4.770 ns |       0.261 ns |       96 B |
| FrozenDictionary                         | StructInts | 1000000 | True    |         29.56 ns |         2.251 ns |       0.123 ns |       96 B |
| ReadOnlyDictionary                       | StructInts | 1000000 | True    |         30.15 ns |         7.197 ns |       0.394 ns |       96 B |
| Dictionary                               | StructInts | 1000000 | True    |         30.17 ns |         7.777 ns |       0.426 ns |       96 B |
| HashSet                                  | StructInts | 1000000 | True    |         30.38 ns |        11.398 ns |       0.625 ns |       96 B |
| &#39;List (Sorted + BinarySearch)&#39;           | StructInts | 1000000 | True    |         33.93 ns |         2.028 ns |       0.111 ns |          - |
| SortedList                               | StructInts | 1000000 | True    |         33.99 ns |         2.052 ns |       0.112 ns |       32 B |
| &#39;ImmutableArray (Sorted + BinarySearch)&#39; | StructInts | 1000000 | True    |         34.00 ns |         0.729 ns |       0.040 ns |          - |
| &#39;Array (Sorted + BinarySearch)&#39;          | StructInts | 1000000 | True    |         34.02 ns |         2.165 ns |       0.119 ns |          - |
| SortedDictionary                         | StructInts | 1000000 | True    |         49.71 ns |         0.177 ns |       0.010 ns |       32 B |
| ImmutableSortedDictionary                | StructInts | 1000000 | True    |         51.63 ns |         1.200 ns |       0.066 ns |          - |
| &#39;ImmutableList (Sorted + BinarySearch)&#39;  | StructInts | 1000000 | True    |         57.67 ns |         0.227 ns |       0.012 ns |          - |
| ImmutableSortedSet                       | StructInts | 1000000 | True    |         58.14 ns |         0.312 ns |       0.017 ns |          - |
| ImmutableHashSet                         | StructInts | 1000000 | True    |         60.93 ns |         2.346 ns |       0.129 ns |       96 B |
| ImmutableDictionary                      | StructInts | 1000000 | True    |         63.14 ns |         6.177 ns |       0.339 ns |       96 B |
| List                                     | StructInts | 1000000 | True    |  4,963,164.20 ns |   122,083.745 ns |   6,691.822 ns | 27782359 B |
| ReadOnlyCollection                       | StructInts | 1000000 | True    |  5,033,124.31 ns | 1,497,539.415 ns |  82,085.189 ns | 27782360 B |
| ImmutableArray                           | StructInts | 1000000 | True    |  5,056,685.80 ns | 1,988,945.596 ns | 109,020.820 ns | 27782359 B |
| Array                                    | StructInts | 1000000 | True    |  5,171,685.19 ns | 1,104,780.782 ns |  60,556.763 ns | 27782359 B |
| LinkedList                               | StructInts | 1000000 | True    |  5,960,763.19 ns |   520,745.052 ns |  28,543.793 ns | 27782360 B |
| ImmutableList                            | StructInts | 1000000 | True    | 12,102,097.22 ns | 1,383,806.017 ns |  75,851.077 ns | 25116021 B |
