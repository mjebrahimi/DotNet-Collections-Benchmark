```

BenchmarkDotNet v0.13.11, Windows 11 (10.0.22631.2861/23H2/2023Update/SunValley3)
AMD Ryzen 7 5800H with Radeon Graphics, 1 CPU, 16 logical and 8 physical cores
.NET SDK 8.0.100
  [Host]   : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                                   | DataType | Length  | Existed | Mean              | Error             | StdDev         | Allocated |
|----------------------------------------- |--------- |-------- |-------- |------------------:|------------------:|---------------:|----------:|
| **FrozenSet**                                | **Int32**    | **10000**   | **False**   |          **1.893 ns** |         **0.1552 ns** |      **0.0085 ns** |         **-** |
| FrozenDictionary                         | Int32    | 10000   | False   |          1.965 ns |         0.2159 ns |      0.0118 ns |         - |
| Dictionary                               | Int32    | 10000   | False   |          3.307 ns |         0.1200 ns |      0.0066 ns |         - |
| ReadOnlyDictionary                       | Int32    | 10000   | False   |          3.568 ns |         0.1037 ns |      0.0057 ns |         - |
| HashSet                                  | Int32    | 10000   | False   |          3.700 ns |         0.1216 ns |      0.0067 ns |         - |
| ImmutableHashSet                         | Int32    | 10000   | False   |          8.907 ns |         0.8915 ns |      0.0489 ns |         - |
| ImmutableDictionary                      | Int32    | 10000   | False   |         10.634 ns |         1.6088 ns |      0.0882 ns |         - |
| SortedSet                                | Int32    | 10000   | False   |         17.198 ns |         4.0517 ns |      0.2221 ns |         - |
| SortedList                               | Int32    | 10000   | False   |         17.280 ns |         0.2933 ns |      0.0161 ns |         - |
| &#39;ImmutableArray (Sorted + BinarySearch)&#39; | Int32    | 10000   | False   |         19.835 ns |         2.5010 ns |      0.1371 ns |         - |
| SortedDictionary                         | Int32    | 10000   | False   |         20.147 ns |         0.4049 ns |      0.0222 ns |         - |
| &#39;Array (Sorted + BinarySearch)&#39;          | Int32    | 10000   | False   |         21.115 ns |         1.0456 ns |      0.0573 ns |         - |
| &#39;List (Sorted + BinarySearch)&#39;           | Int32    | 10000   | False   |         21.333 ns |         3.0855 ns |      0.1691 ns |         - |
| ImmutableSortedSet                       | Int32    | 10000   | False   |         31.211 ns |         1.5195 ns |      0.0833 ns |         - |
| ImmutableSortedDictionary                | Int32    | 10000   | False   |         31.766 ns |         2.8564 ns |      0.1566 ns |         - |
| &#39;ImmutableList (Sorted + BinarySearch)&#39;  | Int32    | 10000   | False   |         35.119 ns |         2.5066 ns |      0.1374 ns |         - |
| ImmutableArray                           | Int32    | 10000   | False   |        405.502 ns |        13.5435 ns |      0.7424 ns |         - |
| List                                     | Int32    | 10000   | False   |        469.122 ns |        18.7025 ns |      1.0251 ns |         - |
| ReadOnlyCollection                       | Int32    | 10000   | False   |        471.783 ns |        31.7151 ns |      1.7384 ns |         - |
| Array                                    | Int32    | 10000   | False   |        481.898 ns |        76.2375 ns |      4.1788 ns |         - |
| LinkedList                               | Int32    | 10000   | False   |      9,767.371 ns |       891.4771 ns |     48.8649 ns |         - |
| ImmutableList                            | Int32    | 10000   | False   |     31,139.836 ns |     8,499.5219 ns |    465.8875 ns |         - |
|                                          |          |         |         |                   |                   |                |           |
| **FrozenSet**                                | **Int32**    | **10000**   | **True**    |          **1.770 ns** |         **0.0227 ns** |      **0.0012 ns** |         **-** |
| FrozenDictionary                         | Int32    | 10000   | True    |          2.057 ns |         0.6566 ns |      0.0360 ns |         - |
| HashSet                                  | Int32    | 10000   | True    |          3.576 ns |         0.1296 ns |      0.0071 ns |         - |
| Dictionary                               | Int32    | 10000   | True    |          3.744 ns |         0.0714 ns |      0.0039 ns |         - |
| ReadOnlyDictionary                       | Int32    | 10000   | True    |          3.996 ns |         0.0757 ns |      0.0041 ns |         - |
| ImmutableHashSet                         | Int32    | 10000   | True    |          7.367 ns |         1.1163 ns |      0.0612 ns |         - |
| ImmutableDictionary                      | Int32    | 10000   | True    |          7.870 ns |         4.0025 ns |      0.2194 ns |         - |
| SortedSet                                | Int32    | 10000   | True    |         13.755 ns |         0.5206 ns |      0.0285 ns |         - |
| SortedDictionary                         | Int32    | 10000   | True    |         14.730 ns |         1.5886 ns |      0.0871 ns |         - |
| SortedList                               | Int32    | 10000   | True    |         17.665 ns |         3.8027 ns |      0.2084 ns |         - |
| &#39;ImmutableArray (Sorted + BinarySearch)&#39; | Int32    | 10000   | True    |         18.273 ns |         2.3144 ns |      0.1269 ns |         - |
| &#39;List (Sorted + BinarySearch)&#39;           | Int32    | 10000   | True    |         18.366 ns |         1.8255 ns |      0.1001 ns |         - |
| &#39;Array (Sorted + BinarySearch)&#39;          | Int32    | 10000   | True    |         18.472 ns |         4.0431 ns |      0.2216 ns |         - |
| ImmutableSortedDictionary                | Int32    | 10000   | True    |         22.300 ns |         0.9265 ns |      0.0508 ns |         - |
| ImmutableSortedSet                       | Int32    | 10000   | True    |         22.464 ns |         0.5504 ns |      0.0302 ns |         - |
| &#39;ImmutableList (Sorted + BinarySearch)&#39;  | Int32    | 10000   | True    |         28.291 ns |         3.1888 ns |      0.1748 ns |         - |
| List                                     | Int32    | 10000   | True    |        308.576 ns |        28.8124 ns |      1.5793 ns |         - |
| ImmutableArray                           | Int32    | 10000   | True    |        309.090 ns |        64.2613 ns |      3.5224 ns |         - |
| ReadOnlyCollection                       | Int32    | 10000   | True    |        310.978 ns |        27.6335 ns |      1.5147 ns |         - |
| Array                                    | Int32    | 10000   | True    |        313.594 ns |        17.7108 ns |      0.9708 ns |         - |
| LinkedList                               | Int32    | 10000   | True    |      4,863.413 ns |       185.8908 ns |     10.1893 ns |         - |
| ImmutableList                            | Int32    | 10000   | True    |     15,062.054 ns |     1,903.2108 ns |    104.3214 ns |         - |
|                                          |          |         |         |                   |                   |                |           |
| **FrozenSet**                                | **Int32**    | **1000000** | **False**   |          **1.924 ns** |         **0.1320 ns** |      **0.0072 ns** |         **-** |
| FrozenDictionary                         | Int32    | 1000000 | False   |          2.003 ns |         0.0714 ns |      0.0039 ns |         - |
| Dictionary                               | Int32    | 1000000 | False   |          3.350 ns |         0.1260 ns |      0.0069 ns |         - |
| ReadOnlyDictionary                       | Int32    | 1000000 | False   |          3.526 ns |         0.0417 ns |      0.0023 ns |         - |
| HashSet                                  | Int32    | 1000000 | False   |          3.623 ns |         0.0973 ns |      0.0053 ns |         - |
| ImmutableHashSet                         | Int32    | 1000000 | False   |         21.602 ns |         0.5801 ns |      0.0318 ns |         - |
| ImmutableDictionary                      | Int32    | 1000000 | False   |         21.610 ns |         0.4073 ns |      0.0223 ns |         - |
| SortedList                               | Int32    | 1000000 | False   |         24.807 ns |         0.3309 ns |      0.0181 ns |         - |
| SortedSet                                | Int32    | 1000000 | False   |         26.249 ns |         1.9686 ns |      0.1079 ns |         - |
| &#39;List (Sorted + BinarySearch)&#39;           | Int32    | 1000000 | False   |         28.310 ns |         0.7358 ns |      0.0403 ns |         - |
| &#39;ImmutableArray (Sorted + BinarySearch)&#39; | Int32    | 1000000 | False   |         29.907 ns |         0.2416 ns |      0.0132 ns |         - |
| &#39;Array (Sorted + BinarySearch)&#39;          | Int32    | 1000000 | False   |         30.450 ns |         2.8173 ns |      0.1544 ns |         - |
| SortedDictionary                         | Int32    | 1000000 | False   |         36.025 ns |         0.5668 ns |      0.0311 ns |         - |
| ImmutableSortedDictionary                | Int32    | 1000000 | False   |         46.567 ns |         1.5057 ns |      0.0825 ns |         - |
| ImmutableSortedSet                       | Int32    | 1000000 | False   |         50.147 ns |         3.2111 ns |      0.1760 ns |         - |
| &#39;ImmutableList (Sorted + BinarySearch)&#39;  | Int32    | 1000000 | False   |         61.684 ns |         9.4820 ns |      0.5197 ns |         - |
| ReadOnlyCollection                       | Int32    | 1000000 | False   |     56,274.753 ns |    71,149.9526 ns |  3,899.9690 ns |         - |
| List                                     | Int32    | 1000000 | False   |     59,293.039 ns |   105,902.2941 ns |  5,804.8621 ns |         - |
| ImmutableArray                           | Int32    | 1000000 | False   |     69,886.146 ns |    41,027.6718 ns |  2,248.8651 ns |         - |
| Array                                    | Int32    | 1000000 | False   |     70,346.216 ns |    14,460.6221 ns |    792.6355 ns |         - |
| LinkedList                               | Int32    | 1000000 | False   |  2,310,114.410 ns |    44,426.2648 ns |  2,435.1535 ns |       2 B |
| ImmutableList                            | Int32    | 1000000 | False   | 11,592,849.306 ns |   427,218.4872 ns | 23,417.2869 ns |      15 B |
|                                          |          |         |         |                   |                   |                |           |
| **FrozenSet**                                | **Int32**    | **1000000** | **True**    |          **1.845 ns** |         **1.2660 ns** |      **0.0694 ns** |         **-** |
| FrozenDictionary                         | Int32    | 1000000 | True    |          2.031 ns |         0.0454 ns |      0.0025 ns |         - |
| Dictionary                               | Int32    | 1000000 | True    |          3.548 ns |         0.0898 ns |      0.0049 ns |         - |
| HashSet                                  | Int32    | 1000000 | True    |          3.576 ns |         0.1074 ns |      0.0059 ns |         - |
| ReadOnlyDictionary                       | Int32    | 1000000 | True    |          3.793 ns |         0.1506 ns |      0.0083 ns |         - |
| ImmutableHashSet                         | Int32    | 1000000 | True    |         20.233 ns |         1.6160 ns |      0.0886 ns |         - |
| ImmutableDictionary                      | Int32    | 1000000 | True    |         20.699 ns |         3.5760 ns |      0.1960 ns |         - |
| SortedSet                                | Int32    | 1000000 | True    |         24.971 ns |         2.0611 ns |      0.1130 ns |         - |
| &#39;Array (Sorted + BinarySearch)&#39;          | Int32    | 1000000 | True    |         26.632 ns |         2.5879 ns |      0.1419 ns |         - |
| &#39;ImmutableArray (Sorted + BinarySearch)&#39; | Int32    | 1000000 | True    |         26.841 ns |         2.2636 ns |      0.1241 ns |         - |
| &#39;List (Sorted + BinarySearch)&#39;           | Int32    | 1000000 | True    |         26.996 ns |         6.2035 ns |      0.3400 ns |         - |
| SortedList                               | Int32    | 1000000 | True    |         30.295 ns |         1.1263 ns |      0.0617 ns |         - |
| SortedDictionary                         | Int32    | 1000000 | True    |         32.126 ns |         1.4585 ns |      0.0799 ns |         - |
| ImmutableSortedSet                       | Int32    | 1000000 | True    |         38.704 ns |         1.2155 ns |      0.0666 ns |         - |
| ImmutableSortedDictionary                | Int32    | 1000000 | True    |         39.851 ns |         2.5638 ns |      0.1405 ns |         - |
| &#39;ImmutableList (Sorted + BinarySearch)&#39;  | Int32    | 1000000 | True    |         48.664 ns |         2.1723 ns |      0.1191 ns |         - |
| Array                                    | Int32    | 1000000 | True    |     27,025.976 ns |    29,054.2127 ns |  1,592.5594 ns |         - |
| ImmutableArray                           | Int32    | 1000000 | True    |     27,262.696 ns |    24,316.5979 ns |  1,332.8748 ns |         - |
| ReadOnlyCollection                       | Int32    | 1000000 | True    |     27,729.070 ns |    19,972.4817 ns |  1,094.7591 ns |         - |
| List                                     | Int32    | 1000000 | True    |     28,765.956 ns |    35,038.0899 ns |  1,920.5559 ns |         - |
| LinkedList                               | Int32    | 1000000 | True    |    963,799.718 ns |    41,773.9850 ns |  2,289.7731 ns |       1 B |
| ImmutableList                            | Int32    | 1000000 | True    |  4,335,084.091 ns | 1,762,912.8615 ns | 96,631.2026 ns |       6 B |
