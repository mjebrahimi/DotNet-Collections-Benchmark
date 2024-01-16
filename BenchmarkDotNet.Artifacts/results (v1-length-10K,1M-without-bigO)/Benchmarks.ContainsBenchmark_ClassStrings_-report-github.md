```

BenchmarkDotNet v0.13.11, Windows 11 (10.0.22631.2861/23H2/2023Update/SunValley3)
AMD Ryzen 7 5800H with Radeon Graphics, 1 CPU, 16 logical and 8 physical cores
.NET SDK 8.0.100
  [Host]   : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                                   | DataType     | Length  | Existed | Mean             | Error            | StdDev        | Allocated |
|----------------------------------------- |------------- |-------- |-------- |-----------------:|-----------------:|--------------:|----------:|
| **FrozenDictionary**                         | **ClassStrings** | **10000**   | **False**   |         **22.95 ns** |         **1.113 ns** |      **0.061 ns** |         **-** |
| FrozenSet                                | ClassStrings | 10000   | False   |         23.17 ns |         3.145 ns |      0.172 ns |         - |
| Dictionary                               | ClassStrings | 10000   | False   |         24.77 ns |         0.092 ns |      0.005 ns |         - |
| HashSet                                  | ClassStrings | 10000   | False   |         25.47 ns |         5.228 ns |      0.287 ns |         - |
| ReadOnlyDictionary                       | ClassStrings | 10000   | False   |         27.03 ns |         0.537 ns |      0.029 ns |         - |
| ImmutableDictionary                      | ClassStrings | 10000   | False   |         38.97 ns |         4.701 ns |      0.258 ns |         - |
| ImmutableHashSet                         | ClassStrings | 10000   | False   |         49.76 ns |         7.493 ns |      0.411 ns |         - |
| SortedSet                                | ClassStrings | 10000   | False   |        415.29 ns |         0.553 ns |      0.030 ns |         - |
| &#39;Array (Sorted + BinarySearch)&#39;          | ClassStrings | 10000   | False   |        422.05 ns |        11.389 ns |      0.624 ns |         - |
| &#39;List (Sorted + BinarySearch)&#39;           | ClassStrings | 10000   | False   |        423.80 ns |        29.092 ns |      1.595 ns |         - |
| &#39;ImmutableArray (Sorted + BinarySearch)&#39; | ClassStrings | 10000   | False   |        428.65 ns |        35.253 ns |      1.932 ns |         - |
| SortedList                               | ClassStrings | 10000   | False   |        435.46 ns |        21.062 ns |      1.154 ns |         - |
| ImmutableSortedSet                       | ClassStrings | 10000   | False   |        438.99 ns |        51.739 ns |      2.836 ns |         - |
| ImmutableSortedDictionary                | ClassStrings | 10000   | False   |        440.79 ns |        13.064 ns |      0.716 ns |         - |
| SortedDictionary                         | ClassStrings | 10000   | False   |        458.55 ns |        33.918 ns |      1.859 ns |         - |
| &#39;ImmutableList (Sorted + BinarySearch)&#39;  | ClassStrings | 10000   | False   |        470.21 ns |        41.693 ns |      2.285 ns |         - |
| ReadOnlyCollection                       | ClassStrings | 10000   | False   |     12,397.06 ns |    25,566.923 ns |  1,401.409 ns |         - |
| List                                     | ClassStrings | 10000   | False   |     38,521.72 ns |     5,937.339 ns |    325.446 ns |         - |
| Array                                    | ClassStrings | 10000   | False   |     38,813.18 ns |    17,442.445 ns |    956.079 ns |         - |
| ImmutableArray                           | ClassStrings | 10000   | False   |     40,012.00 ns |     1,062.444 ns |     58.236 ns |         - |
| LinkedList                               | ClassStrings | 10000   | False   |     41,013.73 ns |     9,412.057 ns |    515.907 ns |         - |
| ImmutableList                            | ClassStrings | 10000   | False   |    111,907.36 ns |     5,927.026 ns |    324.880 ns |         - |
|                                          |              |         |         |                  |                  |               |           |
| **FrozenSet**                                | **ClassStrings** | **10000**   | **True**    |         **26.45 ns** |         **0.463 ns** |      **0.025 ns** |         **-** |
| FrozenDictionary                         | ClassStrings | 10000   | True    |         27.01 ns |         0.552 ns |      0.030 ns |         - |
| Dictionary                               | ClassStrings | 10000   | True    |         29.31 ns |         6.080 ns |      0.333 ns |         - |
| HashSet                                  | ClassStrings | 10000   | True    |         29.47 ns |         0.852 ns |      0.047 ns |         - |
| ReadOnlyDictionary                       | ClassStrings | 10000   | True    |         31.14 ns |         0.896 ns |      0.049 ns |         - |
| ImmutableDictionary                      | ClassStrings | 10000   | True    |         40.57 ns |        10.890 ns |      0.597 ns |         - |
| ImmutableHashSet                         | ClassStrings | 10000   | True    |         48.56 ns |         1.307 ns |      0.072 ns |         - |
| ImmutableSortedSet                       | ClassStrings | 10000   | True    |        352.72 ns |        27.680 ns |      1.517 ns |         - |
| ImmutableSortedDictionary                | ClassStrings | 10000   | True    |        364.17 ns |        22.949 ns |      1.258 ns |         - |
| SortedSet                                | ClassStrings | 10000   | True    |        366.98 ns |        50.954 ns |      2.793 ns |         - |
| &#39;Array (Sorted + BinarySearch)&#39;          | ClassStrings | 10000   | True    |        381.10 ns |        17.814 ns |      0.976 ns |         - |
| &#39;ImmutableList (Sorted + BinarySearch)&#39;  | ClassStrings | 10000   | True    |        383.36 ns |        10.483 ns |      0.575 ns |         - |
| &#39;ImmutableArray (Sorted + BinarySearch)&#39; | ClassStrings | 10000   | True    |        383.59 ns |        27.950 ns |      1.532 ns |         - |
| &#39;List (Sorted + BinarySearch)&#39;           | ClassStrings | 10000   | True    |        387.26 ns |        97.047 ns |      5.319 ns |         - |
| SortedList                               | ClassStrings | 10000   | True    |        393.44 ns |        32.493 ns |      1.781 ns |         - |
| SortedDictionary                         | ClassStrings | 10000   | True    |        403.01 ns |        20.997 ns |      1.151 ns |         - |
| ReadOnlyCollection                       | ClassStrings | 10000   | True    |      4,767.18 ns |    11,480.220 ns |    629.270 ns |         - |
| ImmutableArray                           | ClassStrings | 10000   | True    |     14,980.92 ns |     2,415.133 ns |    132.382 ns |         - |
| LinkedList                               | ClassStrings | 10000   | True    |     15,060.80 ns |     6,089.589 ns |    333.791 ns |         - |
| Array                                    | ClassStrings | 10000   | True    |     15,677.90 ns |     2,855.121 ns |    156.499 ns |         - |
| List                                     | ClassStrings | 10000   | True    |     16,486.80 ns |     3,308.523 ns |    181.351 ns |         - |
| ImmutableList                            | ClassStrings | 10000   | True    |     39,329.18 ns |     2,521.645 ns |    138.220 ns |         - |
|                                          |              |         |         |                  |                  |               |           |
| **FrozenDictionary**                         | **ClassStrings** | **1000000** | **False**   |         **23.37 ns** |         **0.291 ns** |      **0.016 ns** |         **-** |
| FrozenSet                                | ClassStrings | 1000000 | False   |         23.43 ns |         2.173 ns |      0.119 ns |         - |
| Dictionary                               | ClassStrings | 1000000 | False   |         24.91 ns |         1.104 ns |      0.061 ns |         - |
| HashSet                                  | ClassStrings | 1000000 | False   |         25.57 ns |         3.389 ns |      0.186 ns |         - |
| ReadOnlyDictionary                       | ClassStrings | 1000000 | False   |         27.03 ns |         6.204 ns |      0.340 ns |         - |
| ImmutableDictionary                      | ClassStrings | 1000000 | False   |         61.26 ns |         1.513 ns |      0.083 ns |         - |
| ImmutableHashSet                         | ClassStrings | 1000000 | False   |         76.14 ns |         3.433 ns |      0.188 ns |         - |
| SortedSet                                | ClassStrings | 1000000 | False   |        671.12 ns |       123.206 ns |      6.753 ns |         - |
| &#39;Array (Sorted + BinarySearch)&#39;          | ClassStrings | 1000000 | False   |        694.14 ns |        99.107 ns |      5.432 ns |         - |
| &#39;ImmutableArray (Sorted + BinarySearch)&#39; | ClassStrings | 1000000 | False   |        701.37 ns |        34.165 ns |      1.873 ns |         - |
| &#39;List (Sorted + BinarySearch)&#39;           | ClassStrings | 1000000 | False   |        703.67 ns |        32.953 ns |      1.806 ns |         - |
| ImmutableSortedDictionary                | ClassStrings | 1000000 | False   |        708.40 ns |        56.974 ns |      3.123 ns |         - |
| SortedList                               | ClassStrings | 1000000 | False   |        710.03 ns |        14.190 ns |      0.778 ns |         - |
| ImmutableSortedSet                       | ClassStrings | 1000000 | False   |        717.10 ns |        36.506 ns |      2.001 ns |         - |
| SortedDictionary                         | ClassStrings | 1000000 | False   |        747.32 ns |        53.193 ns |      2.916 ns |         - |
| &#39;ImmutableList (Sorted + BinarySearch)&#39;  | ClassStrings | 1000000 | False   |        777.07 ns |         4.925 ns |      0.270 ns |         - |
| ReadOnlyCollection                       | ClassStrings | 1000000 | False   |  4,433,400.93 ns |   684,041.284 ns | 37,494.611 ns |      20 B |
| ImmutableArray                           | ClassStrings | 1000000 | False   |  8,252,192.13 ns |   510,145.386 ns | 27,962.790 ns |      10 B |
| List                                     | ClassStrings | 1000000 | False   |  8,262,300.00 ns | 1,417,219.424 ns | 77,682.579 ns |      12 B |
| Array                                    | ClassStrings | 1000000 | False   |  8,268,005.56 ns |   657,367.738 ns | 36,032.544 ns |      10 B |
| LinkedList                               | ClassStrings | 1000000 | False   |  8,808,608.33 ns |   310,629.023 ns | 17,026.625 ns |      20 B |
| ImmutableList                            | ClassStrings | 1000000 | False   | 51,367,797.22 ns | 1,435,656.484 ns | 78,693.176 ns |      61 B |
|                                          |              |         |         |                  |                  |               |           |
| **FrozenDictionary**                         | **ClassStrings** | **1000000** | **True**    |         **28.42 ns** |         **0.905 ns** |      **0.050 ns** |         **-** |
| FrozenSet                                | ClassStrings | 1000000 | True    |         28.55 ns |         0.630 ns |      0.035 ns |         - |
| Dictionary                               | ClassStrings | 1000000 | True    |         31.06 ns |         1.829 ns |      0.100 ns |         - |
| HashSet                                  | ClassStrings | 1000000 | True    |         31.70 ns |         3.367 ns |      0.185 ns |         - |
| ReadOnlyDictionary                       | ClassStrings | 1000000 | True    |         33.11 ns |         9.473 ns |      0.519 ns |         - |
| ImmutableDictionary                      | ClassStrings | 1000000 | True    |         63.61 ns |         2.467 ns |      0.135 ns |         - |
| ImmutableHashSet                         | ClassStrings | 1000000 | True    |         71.90 ns |         6.625 ns |      0.363 ns |         - |
| ImmutableSortedDictionary                | ClassStrings | 1000000 | True    |        586.35 ns |        19.760 ns |      1.083 ns |         - |
| ImmutableSortedSet                       | ClassStrings | 1000000 | True    |        589.10 ns |        16.125 ns |      0.884 ns |         - |
| SortedDictionary                         | ClassStrings | 1000000 | True    |        615.35 ns |        34.201 ns |      1.875 ns |         - |
| &#39;Array (Sorted + BinarySearch)&#39;          | ClassStrings | 1000000 | True    |        616.51 ns |        30.529 ns |      1.673 ns |         - |
| &#39;ImmutableArray (Sorted + BinarySearch)&#39; | ClassStrings | 1000000 | True    |        619.12 ns |        20.961 ns |      1.149 ns |         - |
| &#39;List (Sorted + BinarySearch)&#39;           | ClassStrings | 1000000 | True    |        624.78 ns |        20.752 ns |      1.137 ns |         - |
| SortedList                               | ClassStrings | 1000000 | True    |        626.80 ns |        17.657 ns |      0.968 ns |         - |
| SortedSet                                | ClassStrings | 1000000 | True    |        632.05 ns |        16.482 ns |      0.903 ns |         - |
| &#39;ImmutableList (Sorted + BinarySearch)&#39;  | ClassStrings | 1000000 | True    |        634.97 ns |        18.522 ns |      1.015 ns |         - |
| ReadOnlyCollection                       | ClassStrings | 1000000 | True    |  1,366,043.53 ns |   105,077.593 ns |  5,759.657 ns |       2 B |
| ImmutableArray                           | ClassStrings | 1000000 | True    |  2,610,113.72 ns |    29,989.532 ns |  1,643.827 ns |       4 B |
| List                                     | ClassStrings | 1000000 | True    |  2,620,340.62 ns |    90,437.045 ns |  4,957.160 ns |       4 B |
| Array                                    | ClassStrings | 1000000 | True    |  2,622,522.74 ns |   187,461.397 ns | 10,275.392 ns |       4 B |
| LinkedList                               | ClassStrings | 1000000 | True    |  2,824,054.07 ns |   455,061.332 ns | 24,943.447 ns |       4 B |
| ImmutableList                            | ClassStrings | 1000000 | True    | 14,130,411.11 ns |   801,608.594 ns | 43,938.872 ns |      20 B |
