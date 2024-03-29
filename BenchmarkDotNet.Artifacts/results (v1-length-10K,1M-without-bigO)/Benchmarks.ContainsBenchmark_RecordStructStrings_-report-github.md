```

BenchmarkDotNet v0.13.11, Windows 11 (10.0.22631.2861/23H2/2023Update/SunValley3)
AMD Ryzen 7 5800H with Radeon Graphics, 1 CPU, 16 logical and 8 physical cores
.NET SDK 8.0.100
  [Host]   : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                                   | DataType            | Length  | Existed | Mean             | Error            | StdDev         | Allocated |
|----------------------------------------- |-------------------- |-------- |-------- |-----------------:|-----------------:|---------------:|----------:|
| **FrozenDictionary**                         | **RecordStructStrings** | **10000**   | **False**   |         **21.44 ns** |         **0.752 ns** |       **0.041 ns** |         **-** |
| FrozenSet                                | RecordStructStrings | 10000   | False   |         21.90 ns |         1.118 ns |       0.061 ns |         - |
| Dictionary                               | RecordStructStrings | 10000   | False   |         23.49 ns |         2.337 ns |       0.128 ns |         - |
| ReadOnlyDictionary                       | RecordStructStrings | 10000   | False   |         24.38 ns |         0.215 ns |       0.012 ns |         - |
| HashSet                                  | RecordStructStrings | 10000   | False   |         24.78 ns |         0.952 ns |       0.052 ns |         - |
| ImmutableDictionary                      | RecordStructStrings | 10000   | False   |         32.00 ns |         0.440 ns |       0.024 ns |         - |
| ImmutableHashSet                         | RecordStructStrings | 10000   | False   |         34.14 ns |         0.536 ns |       0.029 ns |         - |
| SortedSet                                | RecordStructStrings | 10000   | False   |        380.36 ns |        10.178 ns |       0.558 ns |         - |
| &#39;List (Sorted + BinarySearch)&#39;           | RecordStructStrings | 10000   | False   |        389.62 ns |        30.643 ns |       1.680 ns |         - |
| &#39;ImmutableArray (Sorted + BinarySearch)&#39; | RecordStructStrings | 10000   | False   |        390.69 ns |        23.877 ns |       1.309 ns |         - |
| &#39;Array (Sorted + BinarySearch)&#39;          | RecordStructStrings | 10000   | False   |        391.52 ns |        22.045 ns |       1.208 ns |         - |
| SortedList                               | RecordStructStrings | 10000   | False   |        399.09 ns |        15.332 ns |       0.840 ns |      40 B |
| ImmutableSortedDictionary                | RecordStructStrings | 10000   | False   |        409.86 ns |        38.127 ns |       2.090 ns |         - |
| &#39;ImmutableList (Sorted + BinarySearch)&#39;  | RecordStructStrings | 10000   | False   |        411.17 ns |        30.584 ns |       1.676 ns |         - |
| ImmutableSortedSet                       | RecordStructStrings | 10000   | False   |        412.38 ns |        27.411 ns |       1.503 ns |         - |
| SortedDictionary                         | RecordStructStrings | 10000   | False   |        413.01 ns |        37.449 ns |       2.053 ns |      40 B |
| ImmutableArray                           | RecordStructStrings | 10000   | False   |     24,062.53 ns |    11,355.396 ns |     622.428 ns |         - |
| List                                     | RecordStructStrings | 10000   | False   |     24,295.94 ns |    11,534.320 ns |     632.235 ns |         - |
| Array                                    | RecordStructStrings | 10000   | False   |     24,373.29 ns |     6,299.859 ns |     345.317 ns |         - |
| ReadOnlyCollection                       | RecordStructStrings | 10000   | False   |     27,381.09 ns |    27,380.030 ns |   1,500.792 ns |         - |
| LinkedList                               | RecordStructStrings | 10000   | False   |     27,701.25 ns |    37,349.737 ns |   2,047.265 ns |         - |
| ImmutableList                            | RecordStructStrings | 10000   | False   |     93,742.17 ns |    26,556.172 ns |   1,455.633 ns |         - |
|                                          |                     |         |         |                  |                  |                |           |
| **FrozenSet**                                | **RecordStructStrings** | **10000**   | **True**    |         **23.26 ns** |         **0.870 ns** |       **0.048 ns** |         **-** |
| FrozenDictionary                         | RecordStructStrings | 10000   | True    |         23.63 ns |         8.178 ns |       0.448 ns |         - |
| ReadOnlyDictionary                       | RecordStructStrings | 10000   | True    |         25.75 ns |         1.076 ns |       0.059 ns |         - |
| HashSet                                  | RecordStructStrings | 10000   | True    |         25.96 ns |         0.249 ns |       0.014 ns |         - |
| Dictionary                               | RecordStructStrings | 10000   | True    |         26.07 ns |         1.964 ns |       0.108 ns |         - |
| ImmutableHashSet                         | RecordStructStrings | 10000   | True    |         28.59 ns |         3.350 ns |       0.184 ns |         - |
| ImmutableDictionary                      | RecordStructStrings | 10000   | True    |         33.40 ns |         5.259 ns |       0.288 ns |         - |
| &#39;ImmutableList (Sorted + BinarySearch)&#39;  | RecordStructStrings | 10000   | True    |        328.98 ns |        19.465 ns |       1.067 ns |         - |
| ImmutableSortedDictionary                | RecordStructStrings | 10000   | True    |        329.15 ns |         3.192 ns |       0.175 ns |         - |
| SortedSet                                | RecordStructStrings | 10000   | True    |        342.70 ns |        33.757 ns |       1.850 ns |         - |
| &#39;ImmutableArray (Sorted + BinarySearch)&#39; | RecordStructStrings | 10000   | True    |        348.95 ns |        16.037 ns |       0.879 ns |         - |
| &#39;Array (Sorted + BinarySearch)&#39;          | RecordStructStrings | 10000   | True    |        349.09 ns |         9.301 ns |       0.510 ns |         - |
| &#39;List (Sorted + BinarySearch)&#39;           | RecordStructStrings | 10000   | True    |        349.48 ns |        31.934 ns |       1.750 ns |         - |
| ImmutableSortedSet                       | RecordStructStrings | 10000   | True    |        351.23 ns |        26.145 ns |       1.433 ns |         - |
| SortedList                               | RecordStructStrings | 10000   | True    |        360.30 ns |        29.745 ns |       1.630 ns |      40 B |
| SortedDictionary                         | RecordStructStrings | 10000   | True    |        395.50 ns |        35.544 ns |       1.948 ns |      40 B |
| LinkedList                               | RecordStructStrings | 10000   | True    |     10,862.44 ns |     2,206.110 ns |     120.924 ns |         - |
| ReadOnlyCollection                       | RecordStructStrings | 10000   | True    |     10,907.26 ns |     2,010.043 ns |     110.177 ns |         - |
| ImmutableArray                           | RecordStructStrings | 10000   | True    |     11,050.33 ns |     3,610.866 ns |     197.924 ns |         - |
| List                                     | RecordStructStrings | 10000   | True    |     11,103.87 ns |     6,470.978 ns |     354.696 ns |         - |
| Array                                    | RecordStructStrings | 10000   | True    |     11,167.57 ns |     9,214.455 ns |     505.075 ns |         - |
| ImmutableList                            | RecordStructStrings | 10000   | True    |     29,935.21 ns |       858.435 ns |      47.054 ns |         - |
|                                          |                     |         |         |                  |                  |                |           |
| **FrozenSet**                                | **RecordStructStrings** | **1000000** | **False**   |         **22.25 ns** |         **1.296 ns** |       **0.071 ns** |         **-** |
| FrozenDictionary                         | RecordStructStrings | 1000000 | False   |         22.36 ns |         1.478 ns |       0.081 ns |         - |
| Dictionary                               | RecordStructStrings | 1000000 | False   |         24.17 ns |         1.831 ns |       0.100 ns |         - |
| ReadOnlyDictionary                       | RecordStructStrings | 1000000 | False   |         24.36 ns |         0.682 ns |       0.037 ns |         - |
| HashSet                                  | RecordStructStrings | 1000000 | False   |         25.01 ns |         2.143 ns |       0.117 ns |         - |
| ImmutableHashSet                         | RecordStructStrings | 1000000 | False   |         59.19 ns |         1.614 ns |       0.088 ns |         - |
| ImmutableDictionary                      | RecordStructStrings | 1000000 | False   |         59.74 ns |         2.075 ns |       0.114 ns |         - |
| SortedSet                                | RecordStructStrings | 1000000 | False   |        623.20 ns |        41.765 ns |       2.289 ns |         - |
| &#39;List (Sorted + BinarySearch)&#39;           | RecordStructStrings | 1000000 | False   |        630.29 ns |        18.487 ns |       1.013 ns |         - |
| &#39;ImmutableArray (Sorted + BinarySearch)&#39; | RecordStructStrings | 1000000 | False   |        631.44 ns |         7.551 ns |       0.414 ns |         - |
| &#39;Array (Sorted + BinarySearch)&#39;          | RecordStructStrings | 1000000 | False   |        632.48 ns |        12.645 ns |       0.693 ns |         - |
| SortedList                               | RecordStructStrings | 1000000 | False   |        643.70 ns |        16.302 ns |       0.894 ns |      40 B |
| &#39;ImmutableList (Sorted + BinarySearch)&#39;  | RecordStructStrings | 1000000 | False   |        660.74 ns |        30.100 ns |       1.650 ns |         - |
| SortedDictionary                         | RecordStructStrings | 1000000 | False   |        668.34 ns |         9.140 ns |       0.501 ns |      40 B |
| ImmutableSortedSet                       | RecordStructStrings | 1000000 | False   |        670.00 ns |        40.361 ns |       2.212 ns |         - |
| ImmutableSortedDictionary                | RecordStructStrings | 1000000 | False   |        675.26 ns |       115.669 ns |       6.340 ns |         - |
| Array                                    | RecordStructStrings | 1000000 | False   |  6,176,823.81 ns |   804,872.253 ns |  44,117.764 ns |       9 B |
| List                                     | RecordStructStrings | 1000000 | False   |  6,290,098.02 ns |   546,782.940 ns |  29,971.018 ns |       9 B |
| ImmutableArray                           | RecordStructStrings | 1000000 | False   |  6,314,780.16 ns |   417,781.242 ns |  22,900.000 ns |       9 B |
| ReadOnlyCollection                       | RecordStructStrings | 1000000 | False   |  6,351,645.24 ns |   533,365.361 ns |  29,235.555 ns |       9 B |
| LinkedList                               | RecordStructStrings | 1000000 | False   |  7,038,290.28 ns |   834,432.581 ns |  45,738.065 ns |      10 B |
| ImmutableList                            | RecordStructStrings | 1000000 | False   | 39,007,180.56 ns | 5,726,719.281 ns | 313,900.808 ns |      37 B |
|                                          |                     |         |         |                  |                  |                |           |
| **FrozenDictionary**                         | **RecordStructStrings** | **1000000** | **True**    |         **25.70 ns** |         **2.451 ns** |       **0.134 ns** |         **-** |
| FrozenSet                                | RecordStructStrings | 1000000 | True    |         26.27 ns |         2.880 ns |       0.158 ns |         - |
| HashSet                                  | RecordStructStrings | 1000000 | True    |         28.33 ns |         2.320 ns |       0.127 ns |         - |
| ReadOnlyDictionary                       | RecordStructStrings | 1000000 | True    |         28.59 ns |         0.881 ns |       0.048 ns |         - |
| Dictionary                               | RecordStructStrings | 1000000 | True    |         28.60 ns |         1.266 ns |       0.069 ns |         - |
| ImmutableDictionary                      | RecordStructStrings | 1000000 | True    |         52.57 ns |         4.664 ns |       0.256 ns |         - |
| ImmutableHashSet                         | RecordStructStrings | 1000000 | True    |         52.59 ns |         1.589 ns |       0.087 ns |         - |
| &#39;ImmutableList (Sorted + BinarySearch)&#39;  | RecordStructStrings | 1000000 | True    |        540.98 ns |        32.904 ns |       1.804 ns |         - |
| SortedDictionary                         | RecordStructStrings | 1000000 | True    |        544.87 ns |        27.357 ns |       1.500 ns |      40 B |
| ImmutableSortedDictionary                | RecordStructStrings | 1000000 | True    |        547.36 ns |        23.140 ns |       1.268 ns |         - |
| ImmutableSortedSet                       | RecordStructStrings | 1000000 | True    |        551.33 ns |         7.321 ns |       0.401 ns |         - |
| &#39;List (Sorted + BinarySearch)&#39;           | RecordStructStrings | 1000000 | True    |        557.31 ns |         5.870 ns |       0.322 ns |         - |
| &#39;Array (Sorted + BinarySearch)&#39;          | RecordStructStrings | 1000000 | True    |        560.08 ns |        52.229 ns |       2.863 ns |         - |
| &#39;ImmutableArray (Sorted + BinarySearch)&#39; | RecordStructStrings | 1000000 | True    |        563.98 ns |        18.054 ns |       0.990 ns |         - |
| SortedSet                                | RecordStructStrings | 1000000 | True    |        575.96 ns |        29.370 ns |       1.610 ns |         - |
| SortedList                               | RecordStructStrings | 1000000 | True    |        580.90 ns |        28.415 ns |       1.558 ns |      40 B |
| ReadOnlyCollection                       | RecordStructStrings | 1000000 | True    |  1,969,147.44 ns |   348,343.929 ns |  19,093.906 ns |       2 B |
| ImmutableArray                           | RecordStructStrings | 1000000 | True    |  1,969,354.47 ns |   195,061.022 ns |  10,691.953 ns |       2 B |
| List                                     | RecordStructStrings | 1000000 | True    |  1,978,549.22 ns |   230,667.829 ns |  12,643.682 ns |       2 B |
| Array                                    | RecordStructStrings | 1000000 | True    |  2,052,829.77 ns | 1,627,657.417 ns |  89,217.395 ns |       2 B |
| LinkedList                               | RecordStructStrings | 1000000 | True    |  2,166,957.81 ns |   183,876.610 ns |  10,078.897 ns |       2 B |
| ImmutableList                            | RecordStructStrings | 1000000 | True    | 10,422,968.33 ns | 2,205,144.293 ns | 120,871.400 ns |      12 B |
