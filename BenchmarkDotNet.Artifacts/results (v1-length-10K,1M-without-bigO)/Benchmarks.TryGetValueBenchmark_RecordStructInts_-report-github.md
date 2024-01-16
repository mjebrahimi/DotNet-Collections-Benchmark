```

BenchmarkDotNet v0.13.11, Windows 11 (10.0.22631.2861/23H2/2023Update/SunValley3)
AMD Ryzen 7 5800H with Radeon Graphics, 1 CPU, 16 logical and 8 physical cores
.NET SDK 8.0.100
  [Host]   : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                                   | DataType         | Length  | Existed | Mean              | Error             | StdDev          | Allocated |
|----------------------------------------- |----------------- |-------- |-------- |------------------:|------------------:|----------------:|----------:|
| **FrozenDictionary**                         | **RecordStructInts** | **10000**   | **False**   |          **2.407 ns** |         **0.5405 ns** |       **0.0296 ns** |         **-** |
| FrozenSet                                | RecordStructInts | 10000   | False   |          2.670 ns |         0.1130 ns |       0.0062 ns |         - |
| Dictionary                               | RecordStructInts | 10000   | False   |          2.830 ns |         0.1291 ns |       0.0071 ns |         - |
| HashSet                                  | RecordStructInts | 10000   | False   |          4.499 ns |         0.9539 ns |       0.0523 ns |         - |
| ReadOnlyDictionary                       | RecordStructInts | 10000   | False   |          4.743 ns |         0.7449 ns |       0.0408 ns |         - |
| ImmutableHashSet                         | RecordStructInts | 10000   | False   |          8.819 ns |         1.6901 ns |       0.0926 ns |         - |
| ImmutableDictionary                      | RecordStructInts | 10000   | False   |          9.390 ns |         4.5359 ns |       0.2486 ns |         - |
| SortedSet                                | RecordStructInts | 10000   | False   |         14.856 ns |         4.5834 ns |       0.2512 ns |         - |
| &#39;List (Sorted + BinarySearch)&#39;           | RecordStructInts | 10000   | False   |         21.306 ns |         1.0853 ns |       0.0595 ns |         - |
| &#39;ImmutableArray (Sorted + BinarySearch)&#39; | RecordStructInts | 10000   | False   |         21.346 ns |         2.6200 ns |       0.1436 ns |         - |
| &#39;Array (Sorted + BinarySearch)&#39;          | RecordStructInts | 10000   | False   |         22.797 ns |         1.1395 ns |       0.0625 ns |         - |
| SortedList                               | RecordStructInts | 10000   | False   |         23.222 ns |         7.4397 ns |       0.4078 ns |      32 B |
| SortedDictionary                         | RecordStructInts | 10000   | False   |         32.422 ns |         3.3360 ns |       0.1829 ns |      32 B |
| &#39;ImmutableList (Sorted + BinarySearch)&#39;  | RecordStructInts | 10000   | False   |         40.188 ns |         2.1214 ns |       0.1163 ns |         - |
| ImmutableSortedSet                       | RecordStructInts | 10000   | False   |         43.816 ns |         1.0159 ns |       0.0557 ns |         - |
| ImmutableSortedDictionary                | RecordStructInts | 10000   | False   |         45.415 ns |         0.4485 ns |       0.0246 ns |         - |
| List                                     | RecordStructInts | 10000   | False   |      4,654.647 ns |       225.1488 ns |      12.3412 ns |         - |
| Array                                    | RecordStructInts | 10000   | False   |      4,663.950 ns |       204.3385 ns |      11.2005 ns |         - |
| ImmutableArray                           | RecordStructInts | 10000   | False   |      4,702.037 ns |       492.0890 ns |      26.9731 ns |         - |
| ReadOnlyCollection                       | RecordStructInts | 10000   | False   |      4,737.752 ns |     1,519.8873 ns |      83.3101 ns |         - |
| LinkedList                               | RecordStructInts | 10000   | False   |     12,257.544 ns |       129.6868 ns |       7.1086 ns |         - |
| ImmutableList                            | RecordStructInts | 10000   | False   |     86,001.660 ns |    25,973.7488 ns |   1,423.7088 ns |         - |
|                                          |                  |         |         |                   |                   |                 |           |
| **Dictionary**                               | **RecordStructInts** | **10000**   | **True**    |          **3.433 ns** |         **0.1204 ns** |       **0.0066 ns** |         **-** |
| FrozenDictionary                         | RecordStructInts | 10000   | True    |          3.807 ns |         0.4228 ns |       0.0232 ns |         - |
| HashSet                                  | RecordStructInts | 10000   | True    |          3.916 ns |         1.1195 ns |       0.0614 ns |         - |
| FrozenSet                                | RecordStructInts | 10000   | True    |          4.175 ns |         0.1878 ns |       0.0103 ns |         - |
| ReadOnlyDictionary                       | RecordStructInts | 10000   | True    |          5.329 ns |         0.3582 ns |       0.0196 ns |         - |
| ImmutableHashSet                         | RecordStructInts | 10000   | True    |          9.334 ns |         1.1838 ns |       0.0649 ns |         - |
| ImmutableDictionary                      | RecordStructInts | 10000   | True    |         10.172 ns |         5.6834 ns |       0.3115 ns |         - |
| SortedSet                                | RecordStructInts | 10000   | True    |         21.862 ns |         3.7867 ns |       0.2076 ns |         - |
| &#39;Array (Sorted + BinarySearch)&#39;          | RecordStructInts | 10000   | True    |         24.757 ns |         1.8447 ns |       0.1011 ns |         - |
| &#39;List (Sorted + BinarySearch)&#39;           | RecordStructInts | 10000   | True    |         25.121 ns |         0.4585 ns |       0.0251 ns |         - |
| &#39;ImmutableArray (Sorted + BinarySearch)&#39; | RecordStructInts | 10000   | True    |         25.153 ns |         1.6977 ns |       0.0931 ns |         - |
| SortedList                               | RecordStructInts | 10000   | True    |         26.528 ns |         2.8222 ns |       0.1547 ns |      32 B |
| SortedDictionary                         | RecordStructInts | 10000   | True    |         28.090 ns |         6.5108 ns |       0.3569 ns |      32 B |
| ImmutableSortedDictionary                | RecordStructInts | 10000   | True    |         35.862 ns |        10.0997 ns |       0.5536 ns |         - |
| ImmutableSortedSet                       | RecordStructInts | 10000   | True    |         36.091 ns |         1.1740 ns |       0.0644 ns |         - |
| &#39;ImmutableList (Sorted + BinarySearch)&#39;  | RecordStructInts | 10000   | True    |         39.737 ns |        12.6200 ns |       0.6917 ns |         - |
| Array                                    | RecordStructInts | 10000   | True    |      2,203.798 ns |        85.4949 ns |       4.6863 ns |         - |
| ReadOnlyCollection                       | RecordStructInts | 10000   | True    |      2,215.738 ns |       296.6520 ns |      16.2605 ns |         - |
| ImmutableArray                           | RecordStructInts | 10000   | True    |      2,215.773 ns |       191.8565 ns |      10.5163 ns |         - |
| List                                     | RecordStructInts | 10000   | True    |      2,253.611 ns |       525.7173 ns |      28.8163 ns |         - |
| LinkedList                               | RecordStructInts | 10000   | True    |      5,764.522 ns |       498.2289 ns |      27.3096 ns |         - |
| ImmutableList                            | RecordStructInts | 10000   | True    |     34,992.811 ns |     5,994.8958 ns |     328.6005 ns |         - |
|                                          |                  |         |         |                   |                   |                 |           |
| **FrozenDictionary**                         | **RecordStructInts** | **1000000** | **False**   |          **2.588 ns** |         **0.0824 ns** |       **0.0045 ns** |         **-** |
| Dictionary                               | RecordStructInts | 1000000 | False   |          2.726 ns |         2.7685 ns |       0.1518 ns |         - |
| FrozenSet                                | RecordStructInts | 1000000 | False   |          2.747 ns |         0.7846 ns |       0.0430 ns |         - |
| HashSet                                  | RecordStructInts | 1000000 | False   |          4.034 ns |         0.3410 ns |       0.0187 ns |         - |
| ReadOnlyDictionary                       | RecordStructInts | 1000000 | False   |          4.228 ns |         0.1351 ns |       0.0074 ns |         - |
| ImmutableDictionary                      | RecordStructInts | 1000000 | False   |         22.781 ns |         2.0760 ns |       0.1138 ns |         - |
| ImmutableHashSet                         | RecordStructInts | 1000000 | False   |         23.908 ns |         1.2392 ns |       0.0679 ns |         - |
| SortedSet                                | RecordStructInts | 1000000 | False   |         29.087 ns |         1.7481 ns |       0.0958 ns |         - |
| &#39;ImmutableArray (Sorted + BinarySearch)&#39; | RecordStructInts | 1000000 | False   |         30.519 ns |         0.9190 ns |       0.0504 ns |         - |
| &#39;List (Sorted + BinarySearch)&#39;           | RecordStructInts | 1000000 | False   |         30.847 ns |         2.5796 ns |       0.1414 ns |         - |
| &#39;Array (Sorted + BinarySearch)&#39;          | RecordStructInts | 1000000 | False   |         30.916 ns |         5.8668 ns |       0.3216 ns |         - |
| SortedList                               | RecordStructInts | 1000000 | False   |         33.546 ns |         6.7739 ns |       0.3713 ns |      32 B |
| ImmutableSortedDictionary                | RecordStructInts | 1000000 | False   |         56.614 ns |         2.2434 ns |       0.1230 ns |         - |
| ImmutableSortedSet                       | RecordStructInts | 1000000 | False   |         57.828 ns |        14.3138 ns |       0.7846 ns |         - |
| SortedDictionary                         | RecordStructInts | 1000000 | False   |         60.509 ns |         9.9576 ns |       0.5458 ns |      32 B |
| &#39;ImmutableList (Sorted + BinarySearch)&#39;  | RecordStructInts | 1000000 | False   |         68.266 ns |         2.7037 ns |       0.1482 ns |         - |
| ReadOnlyCollection                       | RecordStructInts | 1000000 | False   |    509,458.908 ns |    59,008.3441 ns |   3,234.4465 ns |         - |
| List                                     | RecordStructInts | 1000000 | False   |    530,602.452 ns |    12,917.1744 ns |     708.0339 ns |         - |
| Array                                    | RecordStructInts | 1000000 | False   |    534,161.654 ns |   150,768.6261 ns |   8,264.1371 ns |         - |
| ImmutableArray                           | RecordStructInts | 1000000 | False   |    534,353.733 ns |    71,201.0815 ns |   3,902.7715 ns |         - |
| LinkedList                               | RecordStructInts | 1000000 | False   |  2,703,241.319 ns |   471,963.0858 ns |  25,869.8893 ns |       4 B |
| ImmutableList                            | RecordStructInts | 1000000 | False   | 25,123,606.944 ns |   947,469.2515 ns |  51,933.9868 ns |      19 B |
|                                          |                  |         |         |                   |                   |                 |           |
| **Dictionary**                               | **RecordStructInts** | **1000000** | **True**    |          **3.298 ns** |         **0.2116 ns** |       **0.0116 ns** |         **-** |
| HashSet                                  | RecordStructInts | 1000000 | True    |          3.624 ns |         0.0804 ns |       0.0044 ns |         - |
| FrozenSet                                | RecordStructInts | 1000000 | True    |          4.237 ns |         0.0676 ns |       0.0037 ns |         - |
| FrozenDictionary                         | RecordStructInts | 1000000 | True    |          4.705 ns |         0.0672 ns |       0.0037 ns |         - |
| ReadOnlyDictionary                       | RecordStructInts | 1000000 | True    |          5.201 ns |         1.3719 ns |       0.0752 ns |         - |
| ImmutableHashSet                         | RecordStructInts | 1000000 | True    |         20.973 ns |         1.8380 ns |       0.1007 ns |         - |
| ImmutableDictionary                      | RecordStructInts | 1000000 | True    |         22.380 ns |         0.8040 ns |       0.0441 ns |         - |
| SortedSet                                | RecordStructInts | 1000000 | True    |         28.712 ns |         1.4345 ns |       0.0786 ns |         - |
| &#39;Array (Sorted + BinarySearch)&#39;          | RecordStructInts | 1000000 | True    |         33.953 ns |         0.2821 ns |       0.0155 ns |         - |
| &#39;ImmutableArray (Sorted + BinarySearch)&#39; | RecordStructInts | 1000000 | True    |         34.039 ns |         0.8867 ns |       0.0486 ns |         - |
| &#39;List (Sorted + BinarySearch)&#39;           | RecordStructInts | 1000000 | True    |         34.158 ns |         0.8723 ns |       0.0478 ns |         - |
| SortedList                               | RecordStructInts | 1000000 | True    |         34.383 ns |         2.5980 ns |       0.1424 ns |      32 B |
| SortedDictionary                         | RecordStructInts | 1000000 | True    |         52.666 ns |         0.8089 ns |       0.0443 ns |      32 B |
| ImmutableSortedDictionary                | RecordStructInts | 1000000 | True    |         57.556 ns |         4.2389 ns |       0.2323 ns |         - |
| ImmutableSortedSet                       | RecordStructInts | 1000000 | True    |         58.681 ns |        10.2473 ns |       0.5617 ns |         - |
| &#39;ImmutableList (Sorted + BinarySearch)&#39;  | RecordStructInts | 1000000 | True    |         67.561 ns |         1.8050 ns |       0.0989 ns |         - |
| ReadOnlyCollection                       | RecordStructInts | 1000000 | True    |    221,177.957 ns |    67,620.1693 ns |   3,706.4897 ns |         - |
| ImmutableArray                           | RecordStructInts | 1000000 | True    |    222,353.082 ns |     8,813.0957 ns |     483.0755 ns |         - |
| List                                     | RecordStructInts | 1000000 | True    |    223,303.678 ns |    11,239.9530 ns |     616.0998 ns |         - |
| Array                                    | RecordStructInts | 1000000 | True    |    226,178.255 ns |    55,657.1477 ns |   3,050.7561 ns |         - |
| LinkedList                               | RecordStructInts | 1000000 | True    |  1,150,760.699 ns |    91,770.8228 ns |   5,030.2685 ns |       1 B |
| ImmutableList                            | RecordStructInts | 1000000 | True    | 10,901,268.750 ns | 1,864,842.2345 ns | 102,218.2955 ns |      15 B |
