```

BenchmarkDotNet v0.13.11, Windows 11 (10.0.22631.2861/23H2/2023Update/SunValley3)
AMD Ryzen 7 5800H with Radeon Graphics, 1 CPU, 16 logical and 8 physical cores
.NET SDK 8.0.100
  [Host]   : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                                   | DataType           | Length  | Existed | Mean             | Error            | StdDev         | Allocated |
|----------------------------------------- |------------------- |-------- |-------- |-----------------:|-----------------:|---------------:|----------:|
| **FrozenDictionary**                         | **RecordClassStrings** | **10000**   | **False**   |         **25.90 ns** |         **4.509 ns** |       **0.247 ns** |         **-** |
| Dictionary                               | RecordClassStrings | 10000   | False   |         27.07 ns |         1.182 ns |       0.065 ns |         - |
| HashSet                                  | RecordClassStrings | 10000   | False   |         27.80 ns |         0.546 ns |       0.030 ns |         - |
| FrozenSet                                | RecordClassStrings | 10000   | False   |         28.18 ns |         1.589 ns |       0.087 ns |         - |
| ReadOnlyDictionary                       | RecordClassStrings | 10000   | False   |         30.23 ns |         1.661 ns |       0.091 ns |         - |
| ImmutableHashSet                         | RecordClassStrings | 10000   | False   |         38.95 ns |         7.613 ns |       0.417 ns |         - |
| ImmutableDictionary                      | RecordClassStrings | 10000   | False   |         43.63 ns |         6.712 ns |       0.368 ns |         - |
| SortedSet                                | RecordClassStrings | 10000   | False   |        419.92 ns |        21.615 ns |       1.185 ns |         - |
| &#39;ImmutableArray (Sorted + BinarySearch)&#39; | RecordClassStrings | 10000   | False   |        427.84 ns |        27.070 ns |       1.484 ns |         - |
| &#39;List (Sorted + BinarySearch)&#39;           | RecordClassStrings | 10000   | False   |        428.78 ns |        37.306 ns |       2.045 ns |         - |
| SortedList                               | RecordClassStrings | 10000   | False   |        435.17 ns |        34.169 ns |       1.873 ns |         - |
| ImmutableSortedSet                       | RecordClassStrings | 10000   | False   |        435.62 ns |        23.075 ns |       1.265 ns |         - |
| &#39;Array (Sorted + BinarySearch)&#39;          | RecordClassStrings | 10000   | False   |        438.50 ns |         9.198 ns |       0.504 ns |         - |
| ImmutableSortedDictionary                | RecordClassStrings | 10000   | False   |        444.31 ns |        65.078 ns |       3.567 ns |         - |
| SortedDictionary                         | RecordClassStrings | 10000   | False   |        453.54 ns |        47.568 ns |       2.607 ns |         - |
| &#39;ImmutableList (Sorted + BinarySearch)&#39;  | RecordClassStrings | 10000   | False   |        470.15 ns |        47.106 ns |       2.582 ns |         - |
| ReadOnlyCollection                       | RecordClassStrings | 10000   | False   |     42,038.69 ns |     7,461.086 ns |     408.967 ns |         - |
| LinkedList                               | RecordClassStrings | 10000   | False   |     45,213.25 ns |     5,150.228 ns |     282.301 ns |         - |
| List                                     | RecordClassStrings | 10000   | False   |     45,298.49 ns |    19,301.770 ns |   1,057.995 ns |         - |
| ImmutableArray                           | RecordClassStrings | 10000   | False   |     45,444.80 ns |    15,504.256 ns |     849.841 ns |         - |
| Array                                    | RecordClassStrings | 10000   | False   |     45,532.79 ns |     5,414.684 ns |     296.797 ns |         - |
| ImmutableList                            | RecordClassStrings | 10000   | False   |    295,034.10 ns |    33,529.413 ns |   1,837.860 ns |         - |
|                                          |                    |         |         |                  |                  |                |           |
| **FrozenDictionary**                         | **RecordClassStrings** | **10000**   | **True**    |         **28.48 ns** |         **1.260 ns** |       **0.069 ns** |         **-** |
| Dictionary                               | RecordClassStrings | 10000   | True    |         30.64 ns |         3.070 ns |       0.168 ns |         - |
| HashSet                                  | RecordClassStrings | 10000   | True    |         31.86 ns |         0.779 ns |       0.043 ns |         - |
| ReadOnlyDictionary                       | RecordClassStrings | 10000   | True    |         33.32 ns |         1.534 ns |       0.084 ns |         - |
| FrozenSet                                | RecordClassStrings | 10000   | True    |         33.60 ns |         4.448 ns |       0.244 ns |         - |
| ImmutableHashSet                         | RecordClassStrings | 10000   | True    |         39.97 ns |         1.179 ns |       0.065 ns |         - |
| ImmutableDictionary                      | RecordClassStrings | 10000   | True    |         42.54 ns |         4.222 ns |       0.231 ns |         - |
| ImmutableSortedSet                       | RecordClassStrings | 10000   | True    |        353.43 ns |        40.363 ns |       2.212 ns |         - |
| ImmutableSortedDictionary                | RecordClassStrings | 10000   | True    |        363.83 ns |        49.211 ns |       2.697 ns |         - |
| SortedSet                                | RecordClassStrings | 10000   | True    |        375.67 ns |        88.546 ns |       4.853 ns |         - |
| &#39;List (Sorted + BinarySearch)&#39;           | RecordClassStrings | 10000   | True    |        386.18 ns |        45.833 ns |       2.512 ns |         - |
| &#39;ImmutableList (Sorted + BinarySearch)&#39;  | RecordClassStrings | 10000   | True    |        388.94 ns |         7.900 ns |       0.433 ns |         - |
| &#39;ImmutableArray (Sorted + BinarySearch)&#39; | RecordClassStrings | 10000   | True    |        390.41 ns |        20.021 ns |       1.097 ns |         - |
| &#39;Array (Sorted + BinarySearch)&#39;          | RecordClassStrings | 10000   | True    |        391.25 ns |        26.110 ns |       1.431 ns |         - |
| SortedList                               | RecordClassStrings | 10000   | True    |        395.70 ns |        22.979 ns |       1.260 ns |         - |
| SortedDictionary                         | RecordClassStrings | 10000   | True    |        400.40 ns |        18.281 ns |       1.002 ns |         - |
| ReadOnlyCollection                       | RecordClassStrings | 10000   | True    |     15,577.21 ns |     3,608.278 ns |     197.782 ns |         - |
| LinkedList                               | RecordClassStrings | 10000   | True    |     17,676.98 ns |     4,041.046 ns |     221.503 ns |         - |
| Array                                    | RecordClassStrings | 10000   | True    |     17,730.53 ns |     5,966.099 ns |     327.022 ns |         - |
| ImmutableArray                           | RecordClassStrings | 10000   | True    |     17,758.06 ns |     1,358.684 ns |      74.474 ns |         - |
| List                                     | RecordClassStrings | 10000   | True    |     17,792.24 ns |     4,254.233 ns |     233.189 ns |         - |
| ImmutableList                            | RecordClassStrings | 10000   | True    |    114,952.36 ns |    10,899.643 ns |     597.446 ns |         - |
|                                          |                    |         |         |                  |                  |                |           |
| **FrozenDictionary**                         | **RecordClassStrings** | **1000000** | **False**   |         **25.97 ns** |         **5.326 ns** |       **0.292 ns** |         **-** |
| HashSet                                  | RecordClassStrings | 1000000 | False   |         27.28 ns |         1.155 ns |       0.063 ns |         - |
| Dictionary                               | RecordClassStrings | 1000000 | False   |         28.25 ns |         1.348 ns |       0.074 ns |         - |
| FrozenSet                                | RecordClassStrings | 1000000 | False   |         28.58 ns |         0.107 ns |       0.006 ns |         - |
| ReadOnlyDictionary                       | RecordClassStrings | 1000000 | False   |         30.48 ns |         1.157 ns |       0.063 ns |         - |
| ImmutableDictionary                      | RecordClassStrings | 1000000 | False   |         63.95 ns |         4.832 ns |       0.265 ns |         - |
| ImmutableHashSet                         | RecordClassStrings | 1000000 | False   |         67.65 ns |        13.349 ns |       0.732 ns |         - |
| ImmutableSortedSet                       | RecordClassStrings | 1000000 | False   |        709.02 ns |        37.633 ns |       2.063 ns |         - |
| ImmutableSortedDictionary                | RecordClassStrings | 1000000 | False   |        710.77 ns |        69.143 ns |       3.790 ns |         - |
| &#39;Array (Sorted + BinarySearch)&#39;          | RecordClassStrings | 1000000 | False   |        717.67 ns |        85.818 ns |       4.704 ns |         - |
| &#39;ImmutableArray (Sorted + BinarySearch)&#39; | RecordClassStrings | 1000000 | False   |        719.20 ns |        18.146 ns |       0.995 ns |         - |
| &#39;List (Sorted + BinarySearch)&#39;           | RecordClassStrings | 1000000 | False   |        721.91 ns |        77.619 ns |       4.255 ns |         - |
| SortedSet                                | RecordClassStrings | 1000000 | False   |        726.09 ns |        86.679 ns |       4.751 ns |         - |
| SortedList                               | RecordClassStrings | 1000000 | False   |        727.57 ns |       190.532 ns |      10.444 ns |         - |
| SortedDictionary                         | RecordClassStrings | 1000000 | False   |        746.47 ns |        44.744 ns |       2.453 ns |         - |
| &#39;ImmutableList (Sorted + BinarySearch)&#39;  | RecordClassStrings | 1000000 | False   |        781.99 ns |        99.886 ns |       5.475 ns |         - |
| ReadOnlyCollection                       | RecordClassStrings | 1000000 | False   |  8,352,272.22 ns | 1,388,761.357 ns |  76,122.696 ns |      20 B |
| Array                                    | RecordClassStrings | 1000000 | False   |  8,594,933.89 ns |   156,183.180 ns |   8,560.927 ns |      12 B |
| List                                     | RecordClassStrings | 1000000 | False   |  8,606,883.89 ns |   779,155.531 ns |  42,708.144 ns |      12 B |
| ImmutableArray                           | RecordClassStrings | 1000000 | False   |  8,621,368.89 ns |   698,327.293 ns |  38,277.675 ns |      12 B |
| LinkedList                               | RecordClassStrings | 1000000 | False   |  9,249,350.93 ns | 3,637,978.261 ns | 199,409.864 ns |      20 B |
| ImmutableList                            | RecordClassStrings | 1000000 | False   | 44,993,066.67 ns | 1,656,615.833 ns |  90,804.704 ns |      61 B |
|                                          |                    |         |         |                  |                  |                |           |
| **FrozenDictionary**                         | **RecordClassStrings** | **1000000** | **True**    |         **29.67 ns** |         **9.247 ns** |       **0.507 ns** |         **-** |
| HashSet                                  | RecordClassStrings | 1000000 | True    |         31.16 ns |         0.804 ns |       0.044 ns |         - |
| Dictionary                               | RecordClassStrings | 1000000 | True    |         31.71 ns |         1.488 ns |       0.082 ns |         - |
| ReadOnlyDictionary                       | RecordClassStrings | 1000000 | True    |         34.79 ns |         0.854 ns |       0.047 ns |         - |
| FrozenSet                                | RecordClassStrings | 1000000 | True    |         36.26 ns |         1.682 ns |       0.092 ns |         - |
| ImmutableHashSet                         | RecordClassStrings | 1000000 | True    |         60.99 ns |        12.339 ns |       0.676 ns |         - |
| ImmutableDictionary                      | RecordClassStrings | 1000000 | True    |         64.91 ns |         3.777 ns |       0.207 ns |         - |
| ImmutableSortedSet                       | RecordClassStrings | 1000000 | True    |        586.99 ns |        16.351 ns |       0.896 ns |         - |
| ImmutableSortedDictionary                | RecordClassStrings | 1000000 | True    |        587.57 ns |         8.804 ns |       0.483 ns |         - |
| SortedSet                                | RecordClassStrings | 1000000 | True    |        619.57 ns |        63.000 ns |       3.453 ns |         - |
| SortedDictionary                         | RecordClassStrings | 1000000 | True    |        634.53 ns |       101.905 ns |       5.586 ns |         - |
| &#39;List (Sorted + BinarySearch)&#39;           | RecordClassStrings | 1000000 | True    |        635.21 ns |        33.254 ns |       1.823 ns |         - |
| &#39;ImmutableArray (Sorted + BinarySearch)&#39; | RecordClassStrings | 1000000 | True    |        641.86 ns |        28.810 ns |       1.579 ns |         - |
| &#39;Array (Sorted + BinarySearch)&#39;          | RecordClassStrings | 1000000 | True    |        643.19 ns |        58.529 ns |       3.208 ns |         - |
| SortedList                               | RecordClassStrings | 1000000 | True    |        643.33 ns |        11.605 ns |       0.636 ns |         - |
| &#39;ImmutableList (Sorted + BinarySearch)&#39;  | RecordClassStrings | 1000000 | True    |        655.01 ns |        88.082 ns |       4.828 ns |         - |
| ReadOnlyCollection                       | RecordClassStrings | 1000000 | True    |  2,664,651.04 ns |   126,225.248 ns |   6,918.832 ns |       4 B |
| Array                                    | RecordClassStrings | 1000000 | True    |  2,728,817.36 ns |   167,013.506 ns |   9,154.574 ns |       4 B |
| ImmutableArray                           | RecordClassStrings | 1000000 | True    |  2,743,122.57 ns |   411,513.414 ns |  22,556.439 ns |       4 B |
| List                                     | RecordClassStrings | 1000000 | True    |  2,771,798.96 ns |   283,466.008 ns |  15,537.728 ns |       4 B |
| LinkedList                               | RecordClassStrings | 1000000 | True    |  2,923,082.96 ns |    95,092.824 ns |   5,212.359 ns |       4 B |
| ImmutableList                            | RecordClassStrings | 1000000 | True    | 14,334,219.44 ns |   805,479.115 ns |  44,151.028 ns |      12 B |
