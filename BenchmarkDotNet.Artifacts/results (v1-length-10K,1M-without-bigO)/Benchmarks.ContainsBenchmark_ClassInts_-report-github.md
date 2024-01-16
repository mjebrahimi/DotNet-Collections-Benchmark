```

BenchmarkDotNet v0.13.11, Windows 11 (10.0.22631.2861/23H2/2023Update/SunValley3)
AMD Ryzen 7 5800H with Radeon Graphics, 1 CPU, 16 logical and 8 physical cores
.NET SDK 8.0.100
  [Host]   : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                                   | DataType  | Length  | Existed | Mean              | Error             | StdDev          | Allocated |
|----------------------------------------- |---------- |-------- |-------- |------------------:|------------------:|----------------:|----------:|
| **FrozenSet**                                | **ClassInts** | **10000**   | **False**   |          **3.728 ns** |         **0.0883 ns** |       **0.0048 ns** |         **-** |
| FrozenDictionary                         | ClassInts | 10000   | False   |          3.820 ns |         0.1076 ns |       0.0059 ns |         - |
| HashSet                                  | ClassInts | 10000   | False   |          6.011 ns |         0.2525 ns |       0.0138 ns |         - |
| Dictionary                               | ClassInts | 10000   | False   |          6.232 ns |         0.5428 ns |       0.0298 ns |         - |
| ReadOnlyDictionary                       | ClassInts | 10000   | False   |          8.137 ns |         0.5724 ns |       0.0314 ns |         - |
| ImmutableDictionary                      | ClassInts | 10000   | False   |         14.694 ns |         0.5238 ns |       0.0287 ns |         - |
| ImmutableHashSet                         | ClassInts | 10000   | False   |         32.197 ns |         1.2165 ns |       0.0667 ns |         - |
| SortedSet                                | ClassInts | 10000   | False   |         46.908 ns |         3.8941 ns |       0.2134 ns |         - |
| &#39;Array (Sorted + BinarySearch)&#39;          | ClassInts | 10000   | False   |         47.881 ns |         4.6103 ns |       0.2527 ns |         - |
| &#39;ImmutableArray (Sorted + BinarySearch)&#39; | ClassInts | 10000   | False   |         48.933 ns |         1.9496 ns |       0.1069 ns |         - |
| &#39;List (Sorted + BinarySearch)&#39;           | ClassInts | 10000   | False   |         49.175 ns |        17.2828 ns |       0.9473 ns |         - |
| SortedList                               | ClassInts | 10000   | False   |         49.626 ns |         3.6323 ns |       0.1991 ns |         - |
| ImmutableSortedSet                       | ClassInts | 10000   | False   |         62.591 ns |         3.3136 ns |       0.1816 ns |         - |
| ImmutableSortedDictionary                | ClassInts | 10000   | False   |         64.025 ns |         2.9507 ns |       0.1617 ns |         - |
| SortedDictionary                         | ClassInts | 10000   | False   |         79.257 ns |         2.4232 ns |       0.1328 ns |         - |
| &#39;ImmutableList (Sorted + BinarySearch)&#39;  | ClassInts | 10000   | False   |         98.593 ns |         4.4315 ns |       0.2429 ns |         - |
| ReadOnlyCollection                       | ClassInts | 10000   | False   |      7,220.661 ns |       204.2394 ns |      11.1951 ns |         - |
| ImmutableArray                           | ClassInts | 10000   | False   |     14,456.116 ns |     1,352.1449 ns |      74.1156 ns |         - |
| List                                     | ClassInts | 10000   | False   |     14,456.133 ns |     2,082.2351 ns |     114.1343 ns |         - |
| Array                                    | ClassInts | 10000   | False   |     16,676.824 ns |       310.4321 ns |      17.0158 ns |         - |
| LinkedList                               | ClassInts | 10000   | False   |     17,269.916 ns |     2,021.3105 ns |     110.7948 ns |         - |
| ImmutableList                            | ClassInts | 10000   | False   |     74,388.390 ns |     6,187.6644 ns |     339.1668 ns |         - |
|                                          |           |         |         |                   |                   |                 |           |
| **FrozenDictionary**                         | **ClassInts** | **10000**   | **True**    |          **7.349 ns** |         **0.0184 ns** |       **0.0010 ns** |         **-** |
| FrozenSet                                | ClassInts | 10000   | True    |          7.562 ns |         0.4286 ns |       0.0235 ns |         - |
| Dictionary                               | ClassInts | 10000   | True    |          9.330 ns |         2.2736 ns |       0.1246 ns |         - |
| HashSet                                  | ClassInts | 10000   | True    |          9.930 ns |         1.9745 ns |       0.1082 ns |         - |
| ReadOnlyDictionary                       | ClassInts | 10000   | True    |         11.807 ns |         0.4366 ns |       0.0239 ns |         - |
| ImmutableDictionary                      | ClassInts | 10000   | True    |         21.818 ns |         2.8187 ns |       0.1545 ns |         - |
| ImmutableHashSet                         | ClassInts | 10000   | True    |         35.074 ns |         1.1358 ns |       0.0623 ns |         - |
| &#39;Array (Sorted + BinarySearch)&#39;          | ClassInts | 10000   | True    |         44.842 ns |         2.9884 ns |       0.1638 ns |         - |
| &#39;List (Sorted + BinarySearch)&#39;           | ClassInts | 10000   | True    |         46.471 ns |         3.8386 ns |       0.2104 ns |         - |
| &#39;ImmutableArray (Sorted + BinarySearch)&#39; | ClassInts | 10000   | True    |         48.430 ns |         9.2403 ns |       0.5065 ns |         - |
| SortedSet                                | ClassInts | 10000   | True    |         48.943 ns |         9.4858 ns |       0.5200 ns |         - |
| SortedList                               | ClassInts | 10000   | True    |         49.763 ns |        15.9497 ns |       0.8743 ns |         - |
| ImmutableSortedSet                       | ClassInts | 10000   | True    |         53.390 ns |         0.7766 ns |       0.0426 ns |         - |
| ImmutableSortedDictionary                | ClassInts | 10000   | True    |         54.656 ns |         1.3181 ns |       0.0723 ns |         - |
| SortedDictionary                         | ClassInts | 10000   | True    |         71.884 ns |         3.2495 ns |       0.1781 ns |         - |
| &#39;ImmutableList (Sorted + BinarySearch)&#39;  | ClassInts | 10000   | True    |         85.275 ns |         5.9100 ns |       0.3239 ns |         - |
| ReadOnlyCollection                       | ClassInts | 10000   | True    |      2,332.954 ns |       160.8103 ns |       8.8146 ns |         - |
| Array                                    | ClassInts | 10000   | True    |      6,720.070 ns |       314.8447 ns |      17.2577 ns |         - |
| ImmutableArray                           | ClassInts | 10000   | True    |      7,774.163 ns |       282.3659 ns |      15.4774 ns |         - |
| List                                     | ClassInts | 10000   | True    |      7,821.242 ns |       878.3694 ns |      48.1464 ns |         - |
| LinkedList                               | ClassInts | 10000   | True    |      8,062.645 ns |       233.9442 ns |      12.8233 ns |         - |
| ImmutableList                            | ClassInts | 10000   | True    |     31,977.488 ns |     3,864.7556 ns |     211.8403 ns |         - |
|                                          |           |         |         |                   |                   |                 |           |
| **FrozenSet**                                | **ClassInts** | **1000000** | **False**   |          **3.788 ns** |         **0.0143 ns** |       **0.0008 ns** |         **-** |
| FrozenDictionary                         | ClassInts | 1000000 | False   |          3.866 ns |         0.1234 ns |       0.0068 ns |         - |
| Dictionary                               | ClassInts | 1000000 | False   |          5.923 ns |         0.1264 ns |       0.0069 ns |         - |
| HashSet                                  | ClassInts | 1000000 | False   |          5.941 ns |         0.1545 ns |       0.0085 ns |         - |
| ReadOnlyDictionary                       | ClassInts | 1000000 | False   |          7.905 ns |         0.5028 ns |       0.0276 ns |         - |
| ImmutableDictionary                      | ClassInts | 1000000 | False   |         30.921 ns |         1.6549 ns |       0.0907 ns |         - |
| ImmutableHashSet                         | ClassInts | 1000000 | False   |         62.865 ns |         2.1426 ns |       0.1174 ns |         - |
| &#39;Array (Sorted + BinarySearch)&#39;          | ClassInts | 1000000 | False   |         63.542 ns |         8.2635 ns |       0.4529 ns |         - |
| &#39;ImmutableArray (Sorted + BinarySearch)&#39; | ClassInts | 1000000 | False   |         65.309 ns |         3.0902 ns |       0.1694 ns |         - |
| &#39;List (Sorted + BinarySearch)&#39;           | ClassInts | 1000000 | False   |         65.948 ns |        21.5272 ns |       1.1800 ns |         - |
| SortedSet                                | ClassInts | 1000000 | False   |         75.757 ns |         2.3596 ns |       0.1293 ns |         - |
| SortedList                               | ClassInts | 1000000 | False   |         79.389 ns |        39.1873 ns |       2.1480 ns |         - |
| ImmutableSortedSet                       | ClassInts | 1000000 | False   |         98.386 ns |        12.0156 ns |       0.6586 ns |         - |
| ImmutableSortedDictionary                | ClassInts | 1000000 | False   |        103.225 ns |        10.2224 ns |       0.5603 ns |         - |
| SortedDictionary                         | ClassInts | 1000000 | False   |        120.926 ns |        29.2306 ns |       1.6022 ns |         - |
| &#39;ImmutableList (Sorted + BinarySearch)&#39;  | ClassInts | 1000000 | False   |        149.381 ns |         2.5973 ns |       0.1424 ns |         - |
| ReadOnlyCollection                       | ClassInts | 1000000 | False   |  1,311,436.415 ns |    84,575.8227 ns |   4,635.8862 ns |       2 B |
| List                                     | ClassInts | 1000000 | False   |  1,784,768.924 ns |    33,660.4600 ns |   1,845.0434 ns |       2 B |
| Array                                    | ClassInts | 1000000 | False   |  1,792,029.253 ns |   113,212.6598 ns |   6,205.5679 ns |       2 B |
| ImmutableArray                           | ClassInts | 1000000 | False   |  1,930,472.743 ns |   173,525.9235 ns |   9,511.5414 ns |       2 B |
| LinkedList                               | ClassInts | 1000000 | False   |  2,771,128.333 ns |   116,147.2837 ns |   6,366.4245 ns |       4 B |
| ImmutableList                            | ClassInts | 1000000 | False   | 28,951,583.333 ns | 4,300,910.1898 ns | 235,747.4003 ns |      61 B |
|                                          |           |         |         |                   |                   |                 |           |
| **FrozenSet**                                | **ClassInts** | **1000000** | **True**    |          **7.573 ns** |         **0.4203 ns** |       **0.0230 ns** |         **-** |
| FrozenDictionary                         | ClassInts | 1000000 | True    |          7.626 ns |         0.1285 ns |       0.0070 ns |         - |
| HashSet                                  | ClassInts | 1000000 | True    |          9.491 ns |         0.3043 ns |       0.0167 ns |         - |
| Dictionary                               | ClassInts | 1000000 | True    |          9.915 ns |         0.4537 ns |       0.0249 ns |         - |
| ReadOnlyDictionary                       | ClassInts | 1000000 | True    |         11.623 ns |         0.4966 ns |       0.0272 ns |         - |
| ImmutableDictionary                      | ClassInts | 1000000 | True    |         38.899 ns |         3.1781 ns |       0.1742 ns |         - |
| ImmutableHashSet                         | ClassInts | 1000000 | True    |         59.785 ns |         1.6491 ns |       0.0904 ns |         - |
| &#39;List (Sorted + BinarySearch)&#39;           | ClassInts | 1000000 | True    |         60.711 ns |         1.3025 ns |       0.0714 ns |         - |
| &#39;Array (Sorted + BinarySearch)&#39;          | ClassInts | 1000000 | True    |         64.569 ns |         3.7504 ns |       0.2056 ns |         - |
| &#39;ImmutableArray (Sorted + BinarySearch)&#39; | ClassInts | 1000000 | True    |         70.268 ns |        13.9092 ns |       0.7624 ns |         - |
| SortedList                               | ClassInts | 1000000 | True    |         73.889 ns |         2.4489 ns |       0.1342 ns |         - |
| SortedSet                                | ClassInts | 1000000 | True    |         80.834 ns |         3.2336 ns |       0.1772 ns |         - |
| ImmutableSortedSet                       | ClassInts | 1000000 | True    |         83.698 ns |         7.3266 ns |       0.4016 ns |         - |
| ImmutableSortedDictionary                | ClassInts | 1000000 | True    |         84.104 ns |        20.1796 ns |       1.1061 ns |         - |
| SortedDictionary                         | ClassInts | 1000000 | True    |        112.200 ns |         6.7820 ns |       0.3717 ns |         - |
| &#39;ImmutableList (Sorted + BinarySearch)&#39;  | ClassInts | 1000000 | True    |        130.486 ns |         7.4138 ns |       0.4064 ns |         - |
| ReadOnlyCollection                       | ClassInts | 1000000 | True    |    584,748.492 ns |    30,912.3876 ns |   1,694.4123 ns |         - |
| Array                                    | ClassInts | 1000000 | True    |    766,993.641 ns |    41,610.9675 ns |   2,280.8375 ns |       1 B |
| ImmutableArray                           | ClassInts | 1000000 | True    |    832,484.288 ns |    38,063.1827 ns |   2,086.3715 ns |       1 B |
| List                                     | ClassInts | 1000000 | True    |    835,686.372 ns |    83,027.3416 ns |   4,551.0088 ns |       1 B |
| LinkedList                               | ClassInts | 1000000 | True    |  1,198,061.458 ns |    33,783.9353 ns |   1,851.8115 ns |       1 B |
| ImmutableList                            | ClassInts | 1000000 | True    | 10,208,151.111 ns |   803,975.2363 ns |  44,068.5956 ns |      12 B |
