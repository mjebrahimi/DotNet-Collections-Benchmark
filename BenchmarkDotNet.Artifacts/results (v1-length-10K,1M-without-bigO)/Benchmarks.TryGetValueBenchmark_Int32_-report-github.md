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
| **FrozenSet**                                | **Int32**    | **10000**   | **False**   |          **1.959 ns** |         **0.1934 ns** |       **0.0106 ns** |         **-** |
| FrozenDictionary                         | Int32    | 10000   | False   |          1.970 ns |         0.2247 ns |       0.0123 ns |         - |
| Dictionary                               | Int32    | 10000   | False   |          3.509 ns |         0.5088 ns |       0.0279 ns |         - |
| ReadOnlyDictionary                       | Int32    | 10000   | False   |          3.604 ns |         0.1344 ns |       0.0074 ns |         - |
| HashSet                                  | Int32    | 10000   | False   |          3.652 ns |         0.2647 ns |       0.0145 ns |         - |
| ImmutableHashSet                         | Int32    | 10000   | False   |          9.166 ns |         2.6366 ns |       0.1445 ns |         - |
| ImmutableDictionary                      | Int32    | 10000   | False   |         10.768 ns |         1.7359 ns |       0.0952 ns |         - |
| SortedSet                                | Int32    | 10000   | False   |         14.664 ns |         4.0326 ns |       0.2210 ns |         - |
| SortedDictionary                         | Int32    | 10000   | False   |         17.387 ns |         1.7328 ns |       0.0950 ns |         - |
| SortedList                               | Int32    | 10000   | False   |         17.832 ns |         1.9632 ns |       0.1076 ns |         - |
| &#39;Array (Sorted + BinarySearch)&#39;          | Int32    | 10000   | False   |         19.808 ns |         6.4120 ns |       0.3515 ns |         - |
| &#39;ImmutableArray (Sorted + BinarySearch)&#39; | Int32    | 10000   | False   |         19.858 ns |         4.0214 ns |       0.2204 ns |         - |
| &#39;List (Sorted + BinarySearch)&#39;           | Int32    | 10000   | False   |         21.117 ns |         3.7406 ns |       0.2050 ns |         - |
| ImmutableSortedDictionary                | Int32    | 10000   | False   |         31.184 ns |         0.7615 ns |       0.0417 ns |         - |
| ImmutableSortedSet                       | Int32    | 10000   | False   |         34.143 ns |         0.3912 ns |       0.0214 ns |         - |
| &#39;ImmutableList (Sorted + BinarySearch)&#39;  | Int32    | 10000   | False   |         35.684 ns |         2.6445 ns |       0.1450 ns |         - |
| ReadOnlyCollection                       | Int32    | 10000   | False   |        460.687 ns |        44.7022 ns |       2.4503 ns |         - |
| Array                                    | Int32    | 10000   | False   |        468.797 ns |        12.7902 ns |       0.7011 ns |         - |
| List                                     | Int32    | 10000   | False   |        470.247 ns |         9.0854 ns |       0.4980 ns |         - |
| ImmutableArray                           | Int32    | 10000   | False   |        600.752 ns |        45.9412 ns |       2.5182 ns |         - |
| LinkedList                               | Int32    | 10000   | False   |      9,742.836 ns |       355.5653 ns |      19.4897 ns |         - |
| ImmutableList                            | Int32    | 10000   | False   |     73,926.671 ns |     1,962.4834 ns |     107.5703 ns |         - |
|                                          |          |         |         |                   |                   |                 |           |
| **FrozenDictionary**                         | **Int32**    | **10000**   | **True**    |          **2.044 ns** |         **0.5327 ns** |       **0.0292 ns** |         **-** |
| FrozenSet                                | Int32    | 10000   | True    |          2.216 ns |         0.4615 ns |       0.0253 ns |         - |
| HashSet                                  | Int32    | 10000   | True    |          2.720 ns |         0.6715 ns |       0.0368 ns |         - |
| Dictionary                               | Int32    | 10000   | True    |          3.582 ns |         0.2308 ns |       0.0126 ns |         - |
| ReadOnlyDictionary                       | Int32    | 10000   | True    |          4.253 ns |         0.7134 ns |       0.0391 ns |         - |
| ImmutableHashSet                         | Int32    | 10000   | True    |          7.768 ns |         0.2245 ns |       0.0123 ns |         - |
| ImmutableDictionary                      | Int32    | 10000   | True    |          7.811 ns |         4.6614 ns |       0.2555 ns |         - |
| SortedSet                                | Int32    | 10000   | True    |         13.927 ns |        17.3467 ns |       0.9508 ns |         - |
| SortedDictionary                         | Int32    | 10000   | True    |         14.779 ns |         0.5968 ns |       0.0327 ns |         - |
| &#39;List (Sorted + BinarySearch)&#39;           | Int32    | 10000   | True    |         18.645 ns |         2.7044 ns |       0.1482 ns |         - |
| &#39;Array (Sorted + BinarySearch)&#39;          | Int32    | 10000   | True    |         18.767 ns |         1.9968 ns |       0.1095 ns |         - |
| &#39;ImmutableArray (Sorted + BinarySearch)&#39; | Int32    | 10000   | True    |         18.852 ns |         3.2068 ns |       0.1758 ns |         - |
| SortedList                               | Int32    | 10000   | True    |         20.517 ns |         2.2945 ns |       0.1258 ns |         - |
| ImmutableSortedDictionary                | Int32    | 10000   | True    |         22.382 ns |         3.5657 ns |       0.1954 ns |         - |
| ImmutableSortedSet                       | Int32    | 10000   | True    |         22.457 ns |         1.2856 ns |       0.0705 ns |         - |
| &#39;ImmutableList (Sorted + BinarySearch)&#39;  | Int32    | 10000   | True    |         32.961 ns |         0.4419 ns |       0.0242 ns |         - |
| Array                                    | Int32    | 10000   | True    |        308.254 ns |        41.8601 ns |       2.2945 ns |         - |
| ImmutableArray                           | Int32    | 10000   | True    |        308.935 ns |       116.9158 ns |       6.4086 ns |         - |
| List                                     | Int32    | 10000   | True    |        309.536 ns |        22.6334 ns |       1.2406 ns |         - |
| ReadOnlyCollection                       | Int32    | 10000   | True    |        310.036 ns |        51.4445 ns |       2.8198 ns |         - |
| LinkedList                               | Int32    | 10000   | True    |      4,914.579 ns |       289.2145 ns |      15.8528 ns |         - |
| ImmutableList                            | Int32    | 10000   | True    |     34,017.872 ns |     4,997.1929 ns |     273.9130 ns |         - |
|                                          |          |         |         |                   |                   |                 |           |
| **FrozenSet**                                | **Int32**    | **1000000** | **False**   |          **1.978 ns** |         **0.1995 ns** |       **0.0109 ns** |         **-** |
| FrozenDictionary                         | Int32    | 1000000 | False   |          1.992 ns |         0.3760 ns |       0.0206 ns |         - |
| Dictionary                               | Int32    | 1000000 | False   |          3.509 ns |         0.2113 ns |       0.0116 ns |         - |
| ReadOnlyDictionary                       | Int32    | 1000000 | False   |          3.608 ns |         0.0478 ns |       0.0026 ns |         - |
| HashSet                                  | Int32    | 1000000 | False   |          3.691 ns |         0.1490 ns |       0.0082 ns |         - |
| ImmutableHashSet                         | Int32    | 1000000 | False   |         22.884 ns |         4.1942 ns |       0.2299 ns |         - |
| ImmutableDictionary                      | Int32    | 1000000 | False   |         23.471 ns |         1.8984 ns |       0.1041 ns |         - |
| SortedList                               | Int32    | 1000000 | False   |         25.620 ns |         1.9767 ns |       0.1083 ns |         - |
| SortedSet                                | Int32    | 1000000 | False   |         26.490 ns |         3.1413 ns |       0.1722 ns |         - |
| &#39;List (Sorted + BinarySearch)&#39;           | Int32    | 1000000 | False   |         27.436 ns |         0.5253 ns |       0.0288 ns |         - |
| &#39;Array (Sorted + BinarySearch)&#39;          | Int32    | 1000000 | False   |         28.039 ns |         7.8397 ns |       0.4297 ns |         - |
| &#39;ImmutableArray (Sorted + BinarySearch)&#39; | Int32    | 1000000 | False   |         29.808 ns |         2.0538 ns |       0.1126 ns |         - |
| SortedDictionary                         | Int32    | 1000000 | False   |         38.649 ns |         1.2274 ns |       0.0673 ns |         - |
| ImmutableSortedDictionary                | Int32    | 1000000 | False   |         46.217 ns |         3.3395 ns |       0.1831 ns |         - |
| ImmutableSortedSet                       | Int32    | 1000000 | False   |         49.356 ns |         3.3014 ns |       0.1810 ns |         - |
| &#39;ImmutableList (Sorted + BinarySearch)&#39;  | Int32    | 1000000 | False   |         62.535 ns |        15.8926 ns |       0.8711 ns |         - |
| ImmutableArray                           | Int32    | 1000000 | False   |     47,506.297 ns |    11,037.9828 ns |     605.0291 ns |         - |
| ReadOnlyCollection                       | Int32    | 1000000 | False   |     64,560.829 ns |    38,867.5733 ns |   2,130.4628 ns |         - |
| List                                     | Int32    | 1000000 | False   |     64,911.117 ns |    43,299.3212 ns |   2,373.3819 ns |         - |
| Array                                    | Int32    | 1000000 | False   |     66,157.279 ns |    21,266.2804 ns |   1,165.6766 ns |         - |
| LinkedList                               | Int32    | 1000000 | False   |  2,324,664.106 ns |   529,406.5788 ns |  29,018.5610 ns |       2 B |
| ImmutableList                            | Int32    | 1000000 | False   | 18,440,760.185 ns | 3,030,217.3074 ns | 166,096.4356 ns |      20 B |
|                                          |          |         |         |                   |                   |                 |           |
| **FrozenDictionary**                         | **Int32**    | **1000000** | **True**    |          **2.124 ns** |         **0.1508 ns** |       **0.0083 ns** |         **-** |
| FrozenSet                                | Int32    | 1000000 | True    |          2.279 ns |         0.1072 ns |       0.0059 ns |         - |
| HashSet                                  | Int32    | 1000000 | True    |          2.361 ns |         0.2938 ns |       0.0161 ns |         - |
| Dictionary                               | Int32    | 1000000 | True    |          3.549 ns |         0.0450 ns |       0.0025 ns |         - |
| ReadOnlyDictionary                       | Int32    | 1000000 | True    |          4.066 ns |         0.0256 ns |       0.0014 ns |         - |
| ImmutableDictionary                      | Int32    | 1000000 | True    |         20.882 ns |         1.8710 ns |       0.1026 ns |         - |
| ImmutableHashSet                         | Int32    | 1000000 | True    |         21.961 ns |         6.3410 ns |       0.3476 ns |         - |
| &#39;Array (Sorted + BinarySearch)&#39;          | Int32    | 1000000 | True    |         26.323 ns |         3.2708 ns |       0.1793 ns |         - |
| &#39;List (Sorted + BinarySearch)&#39;           | Int32    | 1000000 | True    |         26.629 ns |         1.4326 ns |       0.0785 ns |         - |
| &#39;ImmutableArray (Sorted + BinarySearch)&#39; | Int32    | 1000000 | True    |         26.630 ns |         0.6553 ns |       0.0359 ns |         - |
| SortedSet                                | Int32    | 1000000 | True    |         27.132 ns |         1.4553 ns |       0.0798 ns |         - |
| SortedList                               | Int32    | 1000000 | True    |         29.848 ns |         7.0715 ns |       0.3876 ns |         - |
| SortedDictionary                         | Int32    | 1000000 | True    |         31.777 ns |         0.5178 ns |       0.0284 ns |         - |
| ImmutableSortedSet                       | Int32    | 1000000 | True    |         39.724 ns |         0.5877 ns |       0.0322 ns |         - |
| ImmutableSortedDictionary                | Int32    | 1000000 | True    |         39.770 ns |         1.8522 ns |       0.1015 ns |         - |
| &#39;ImmutableList (Sorted + BinarySearch)&#39;  | Int32    | 1000000 | True    |         60.708 ns |         3.9078 ns |       0.2142 ns |         - |
| ReadOnlyCollection                       | Int32    | 1000000 | True    |     25,829.938 ns |     5,863.1261 ns |     321.3777 ns |         - |
| List                                     | Int32    | 1000000 | True    |     26,321.679 ns |     2,630.2687 ns |     144.1739 ns |         - |
| ImmutableArray                           | Int32    | 1000000 | True    |     26,621.719 ns |    11,345.8882 ns |     621.9064 ns |         - |
| Array                                    | Int32    | 1000000 | True    |     26,680.024 ns |    17,711.8170 ns |     970.8445 ns |         - |
| LinkedList                               | Int32    | 1000000 | True    |    947,099.392 ns |    47,129.5129 ns |   2,583.3276 ns |       1 B |
| ImmutableList                            | Int32    | 1000000 | True    |  7,399,004.630 ns |   655,541.6658 ns |  35,932.4507 ns |      10 B |
