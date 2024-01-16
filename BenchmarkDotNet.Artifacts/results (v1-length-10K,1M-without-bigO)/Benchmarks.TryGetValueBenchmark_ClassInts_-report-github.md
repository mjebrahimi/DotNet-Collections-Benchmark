```

BenchmarkDotNet v0.13.11, Windows 11 (10.0.22631.2861/23H2/2023Update/SunValley3)
AMD Ryzen 7 5800H with Radeon Graphics, 1 CPU, 16 logical and 8 physical cores
.NET SDK 8.0.100
  [Host]   : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                                   | DataType  | Length  | Existed | Mean              | Error              | StdDev          | Allocated |
|----------------------------------------- |---------- |-------- |-------- |------------------:|-------------------:|----------------:|----------:|
| **FrozenDictionary**                         | **ClassInts** | **10000**   | **False**   |          **3.770 ns** |          **0.4664 ns** |       **0.0256 ns** |         **-** |
| HashSet                                  | ClassInts | 10000   | False   |          5.940 ns |          0.8974 ns |       0.0492 ns |         - |
| Dictionary                               | ClassInts | 10000   | False   |          6.066 ns |          0.4782 ns |       0.0262 ns |         - |
| FrozenSet                                | ClassInts | 10000   | False   |          7.337 ns |          0.6398 ns |       0.0351 ns |         - |
| ReadOnlyDictionary                       | ClassInts | 10000   | False   |          8.597 ns |          0.7815 ns |       0.0428 ns |         - |
| ImmutableHashSet                         | ClassInts | 10000   | False   |         12.231 ns |          3.6884 ns |       0.2022 ns |         - |
| ImmutableDictionary                      | ClassInts | 10000   | False   |         14.820 ns |          0.8342 ns |       0.0457 ns |         - |
| &#39;List (Sorted + BinarySearch)&#39;           | ClassInts | 10000   | False   |         42.861 ns |          7.7664 ns |       0.4257 ns |         - |
| &#39;ImmutableArray (Sorted + BinarySearch)&#39; | ClassInts | 10000   | False   |         46.586 ns |          6.9323 ns |       0.3800 ns |         - |
| SortedSet                                | ClassInts | 10000   | False   |         48.218 ns |          2.5211 ns |       0.1382 ns |         - |
| SortedList                               | ClassInts | 10000   | False   |         48.960 ns |          6.5928 ns |       0.3614 ns |         - |
| &#39;Array (Sorted + BinarySearch)&#39;          | ClassInts | 10000   | False   |         53.392 ns |         17.7888 ns |       0.9751 ns |         - |
| ImmutableSortedSet                       | ClassInts | 10000   | False   |         61.179 ns |          1.3570 ns |       0.0744 ns |         - |
| ImmutableSortedDictionary                | ClassInts | 10000   | False   |         63.969 ns |          1.3365 ns |       0.0733 ns |         - |
| SortedDictionary                         | ClassInts | 10000   | False   |         83.317 ns |          2.9880 ns |       0.1638 ns |         - |
| &#39;ImmutableList (Sorted + BinarySearch)&#39;  | ClassInts | 10000   | False   |         99.164 ns |         10.0219 ns |       0.5493 ns |         - |
| ReadOnlyCollection                       | ClassInts | 10000   | False   |      7,230.557 ns |        656.5635 ns |      35.9885 ns |         - |
| Array                                    | ClassInts | 10000   | False   |     16,626.595 ns |        285.5049 ns |      15.6495 ns |         - |
| List                                     | ClassInts | 10000   | False   |     16,649.606 ns |        353.1064 ns |      19.3550 ns |         - |
| ImmutableArray                           | ClassInts | 10000   | False   |     16,780.195 ns |      1,099.2721 ns |      60.2548 ns |         - |
| LinkedList                               | ClassInts | 10000   | False   |     17,176.994 ns |        707.8357 ns |      38.7989 ns |         - |
| ImmutableList                            | ClassInts | 10000   | False   |    267,576.438 ns |    112,448.5778 ns |   6,163.6860 ns |         - |
|                                          |           |         |         |                   |                    |                 |           |
| **FrozenDictionary**                         | **ClassInts** | **10000**   | **True**    |          **7.438 ns** |          **0.5708 ns** |       **0.0313 ns** |         **-** |
| Dictionary                               | ClassInts | 10000   | True    |          9.718 ns |          2.2983 ns |       0.1260 ns |         - |
| HashSet                                  | ClassInts | 10000   | True    |          9.898 ns |          1.0376 ns |       0.0569 ns |         - |
| ReadOnlyDictionary                       | ClassInts | 10000   | True    |         12.273 ns |          0.7681 ns |       0.0421 ns |         - |
| FrozenSet                                | ClassInts | 10000   | True    |         13.129 ns |          2.2271 ns |       0.1221 ns |         - |
| ImmutableHashSet                         | ClassInts | 10000   | True    |         19.622 ns |          4.4297 ns |       0.2428 ns |         - |
| ImmutableDictionary                      | ClassInts | 10000   | True    |         21.347 ns |          3.3531 ns |       0.1838 ns |         - |
| &#39;ImmutableArray (Sorted + BinarySearch)&#39; | ClassInts | 10000   | True    |         46.302 ns |          3.0365 ns |       0.1664 ns |         - |
| SortedSet                                | ClassInts | 10000   | True    |         49.645 ns |          3.8293 ns |       0.2099 ns |         - |
| &#39;List (Sorted + BinarySearch)&#39;           | ClassInts | 10000   | True    |         49.898 ns |         58.1870 ns |       3.1894 ns |         - |
| &#39;Array (Sorted + BinarySearch)&#39;          | ClassInts | 10000   | True    |         51.517 ns |         13.2461 ns |       0.7261 ns |         - |
| SortedList                               | ClassInts | 10000   | True    |         52.124 ns |          6.5596 ns |       0.3596 ns |         - |
| ImmutableSortedSet                       | ClassInts | 10000   | True    |         52.213 ns |          2.8010 ns |       0.1535 ns |         - |
| ImmutableSortedDictionary                | ClassInts | 10000   | True    |         54.088 ns |          3.9454 ns |       0.2163 ns |         - |
| SortedDictionary                         | ClassInts | 10000   | True    |         76.795 ns |         15.4817 ns |       0.8486 ns |         - |
| &#39;ImmutableList (Sorted + BinarySearch)&#39;  | ClassInts | 10000   | True    |         88.501 ns |          1.2290 ns |       0.0674 ns |         - |
| ReadOnlyCollection                       | ClassInts | 10000   | True    |      2,310.369 ns |        214.4501 ns |      11.7547 ns |         - |
| ImmutableArray                           | ClassInts | 10000   | True    |      6,730.176 ns |        420.8453 ns |      23.0679 ns |         - |
| List                                     | ClassInts | 10000   | True    |      6,798.684 ns |        823.1357 ns |      45.1188 ns |         - |
| Array                                    | ClassInts | 10000   | True    |      7,784.864 ns |        302.1104 ns |      16.5597 ns |         - |
| LinkedList                               | ClassInts | 10000   | True    |      8,925.238 ns |      6,802.8547 ns |     372.8874 ns |         - |
| ImmutableList                            | ClassInts | 10000   | True    |    121,761.241 ns |     96,766.1400 ns |   5,304.0787 ns |         - |
|                                          |           |         |         |                   |                    |                 |           |
| **FrozenDictionary**                         | **ClassInts** | **1000000** | **False**   |          **3.822 ns** |          **0.1103 ns** |       **0.0060 ns** |         **-** |
| Dictionary                               | ClassInts | 1000000 | False   |          5.897 ns |          0.3752 ns |       0.0206 ns |         - |
| HashSet                                  | ClassInts | 1000000 | False   |          6.288 ns |          1.6799 ns |       0.0921 ns |         - |
| FrozenSet                                | ClassInts | 1000000 | False   |          7.278 ns |          0.4489 ns |       0.0246 ns |         - |
| ReadOnlyDictionary                       | ClassInts | 1000000 | False   |          8.713 ns |          0.9137 ns |       0.0501 ns |         - |
| ImmutableHashSet                         | ClassInts | 1000000 | False   |         28.444 ns |          3.3050 ns |       0.1812 ns |         - |
| ImmutableDictionary                      | ClassInts | 1000000 | False   |         30.536 ns |          1.5363 ns |       0.0842 ns |         - |
| &#39;ImmutableArray (Sorted + BinarySearch)&#39; | ClassInts | 1000000 | False   |         68.552 ns |          4.9782 ns |       0.2729 ns |         - |
| &#39;Array (Sorted + BinarySearch)&#39;          | ClassInts | 1000000 | False   |         69.984 ns |          4.2618 ns |       0.2336 ns |         - |
| SortedList                               | ClassInts | 1000000 | False   |         71.734 ns |          5.4040 ns |       0.2962 ns |         - |
| SortedSet                                | ClassInts | 1000000 | False   |         75.984 ns |         12.2380 ns |       0.6708 ns |         - |
| &#39;List (Sorted + BinarySearch)&#39;           | ClassInts | 1000000 | False   |         76.026 ns |          3.6770 ns |       0.2016 ns |         - |
| ImmutableSortedSet                       | ClassInts | 1000000 | False   |         98.345 ns |          1.9104 ns |       0.1047 ns |         - |
| ImmutableSortedDictionary                | ClassInts | 1000000 | False   |         99.744 ns |         20.8362 ns |       1.1421 ns |         - |
| SortedDictionary                         | ClassInts | 1000000 | False   |        126.242 ns |         11.6134 ns |       0.6366 ns |         - |
| &#39;ImmutableList (Sorted + BinarySearch)&#39;  | ClassInts | 1000000 | False   |        151.944 ns |          4.0269 ns |       0.2207 ns |         - |
| ReadOnlyCollection                       | ClassInts | 1000000 | False   |  1,381,790.321 ns |     67,339.7283 ns |   3,691.1177 ns |       2 B |
| List                                     | ClassInts | 1000000 | False   |  1,784,944.184 ns |    138,494.8308 ns |   7,591.3690 ns |       2 B |
| Array                                    | ClassInts | 1000000 | False   |  1,915,178.125 ns |     61,719.5367 ns |   3,383.0561 ns |       2 B |
| ImmutableArray                           | ClassInts | 1000000 | False   |  1,949,111.111 ns |    612,203.8988 ns |  33,556.9615 ns |       2 B |
| LinkedList                               | ClassInts | 1000000 | False   |  2,813,582.778 ns |    306,249.9328 ns |  16,786.5922 ns |       4 B |
| ImmutableList                            | ClassInts | 1000000 | False   | 42,162,602.778 ns | 12,278,102.4804 ns | 673,004.2276 ns |      61 B |
|                                          |           |         |         |                   |                    |                 |           |
| **FrozenDictionary**                         | **ClassInts** | **1000000** | **True**    |          **7.884 ns** |          **0.8290 ns** |       **0.0454 ns** |         **-** |
| Dictionary                               | ClassInts | 1000000 | True    |          9.667 ns |          0.0833 ns |       0.0046 ns |         - |
| HashSet                                  | ClassInts | 1000000 | True    |          9.774 ns |          1.1273 ns |       0.0618 ns |         - |
| ReadOnlyDictionary                       | ClassInts | 1000000 | True    |         12.248 ns |          0.4663 ns |       0.0256 ns |         - |
| FrozenSet                                | ClassInts | 1000000 | True    |         13.719 ns |          0.6898 ns |       0.0378 ns |         - |
| ImmutableHashSet                         | ClassInts | 1000000 | True    |         38.271 ns |          1.7521 ns |       0.0960 ns |         - |
| ImmutableDictionary                      | ClassInts | 1000000 | True    |         40.155 ns |         10.5589 ns |       0.5788 ns |         - |
| &#39;ImmutableArray (Sorted + BinarySearch)&#39; | ClassInts | 1000000 | True    |         68.121 ns |         10.2640 ns |       0.5626 ns |         - |
| &#39;List (Sorted + BinarySearch)&#39;           | ClassInts | 1000000 | True    |         68.622 ns |          3.5446 ns |       0.1943 ns |         - |
| &#39;Array (Sorted + BinarySearch)&#39;          | ClassInts | 1000000 | True    |         71.894 ns |          2.6377 ns |       0.1446 ns |         - |
| SortedList                               | ClassInts | 1000000 | True    |         73.106 ns |          4.8537 ns |       0.2660 ns |         - |
| SortedSet                                | ClassInts | 1000000 | True    |         76.810 ns |          1.7792 ns |       0.0975 ns |         - |
| ImmutableSortedDictionary                | ClassInts | 1000000 | True    |         83.416 ns |          0.4703 ns |       0.0258 ns |         - |
| ImmutableSortedSet                       | ClassInts | 1000000 | True    |         86.547 ns |         21.4445 ns |       1.1754 ns |         - |
| SortedDictionary                         | ClassInts | 1000000 | True    |        117.731 ns |          3.1444 ns |       0.1724 ns |         - |
| &#39;ImmutableList (Sorted + BinarySearch)&#39;  | ClassInts | 1000000 | True    |        137.309 ns |          1.7889 ns |       0.0981 ns |         - |
| ReadOnlyCollection                       | ClassInts | 1000000 | True    |    584,749.468 ns |     16,520.1352 ns |     905.5244 ns |         - |
| List                                     | ClassInts | 1000000 | True    |    773,331.814 ns |    134,716.6410 ns |   7,384.2737 ns |       1 B |
| Array                                    | ClassInts | 1000000 | True    |    787,062.348 ns |    604,383.1748 ns |  33,128.2812 ns |       1 B |
| ImmutableArray                           | ClassInts | 1000000 | True    |    837,320.226 ns |     55,797.7248 ns |   3,058.4616 ns |       1 B |
| LinkedList                               | ClassInts | 1000000 | True    |  1,197,720.443 ns |     27,554.4472 ns |   1,510.3522 ns |       1 B |
| ImmutableList                            | ClassInts | 1000000 | True    | 18,416,844.444 ns |    893,285.1361 ns |  48,963.9726 ns |      20 B |
