```

BenchmarkDotNet v0.13.11, Windows 11 (10.0.22631.2861/23H2/2023Update/SunValley3)
AMD Ryzen 7 5800H with Radeon Graphics, 1 CPU, 16 logical and 8 physical cores
.NET SDK 8.0.100
  [Host]   : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                                   | DataType         | Length  | Existed | Mean              | Error             | StdDev         | Allocated |
|----------------------------------------- |----------------- |-------- |-------- |------------------:|------------------:|---------------:|----------:|
| **FrozenSet**                                | **RecordStructInts** | **10000**   | **False**   |          **2.403 ns** |         **0.0839 ns** |      **0.0046 ns** |         **-** |
| FrozenDictionary                         | RecordStructInts | 10000   | False   |          2.410 ns |         0.5807 ns |      0.0318 ns |         - |
| HashSet                                  | RecordStructInts | 10000   | False   |          4.436 ns |         0.8296 ns |      0.0455 ns |         - |
| Dictionary                               | RecordStructInts | 10000   | False   |          4.455 ns |         0.7163 ns |      0.0393 ns |         - |
| ReadOnlyDictionary                       | RecordStructInts | 10000   | False   |          4.714 ns |         1.0978 ns |      0.0602 ns |         - |
| ImmutableDictionary                      | RecordStructInts | 10000   | False   |          8.913 ns |         1.7241 ns |      0.0945 ns |         - |
| ImmutableHashSet                         | RecordStructInts | 10000   | False   |          9.007 ns |         1.0971 ns |      0.0601 ns |         - |
| SortedSet                                | RecordStructInts | 10000   | False   |         16.156 ns |         0.7604 ns |      0.0417 ns |         - |
| &#39;List (Sorted + BinarySearch)&#39;           | RecordStructInts | 10000   | False   |         21.394 ns |         3.9649 ns |      0.2173 ns |         - |
| &#39;ImmutableArray (Sorted + BinarySearch)&#39; | RecordStructInts | 10000   | False   |         21.396 ns |         1.3452 ns |      0.0737 ns |         - |
| &#39;Array (Sorted + BinarySearch)&#39;          | RecordStructInts | 10000   | False   |         22.829 ns |         3.0465 ns |      0.1670 ns |         - |
| SortedList                               | RecordStructInts | 10000   | False   |         22.978 ns |         0.7823 ns |      0.0429 ns |      32 B |
| SortedDictionary                         | RecordStructInts | 10000   | False   |         31.700 ns |         4.2728 ns |      0.2342 ns |      32 B |
| &#39;ImmutableList (Sorted + BinarySearch)&#39;  | RecordStructInts | 10000   | False   |         39.907 ns |         2.5514 ns |      0.1398 ns |         - |
| ImmutableSortedDictionary                | RecordStructInts | 10000   | False   |         45.290 ns |         0.5651 ns |      0.0310 ns |         - |
| ImmutableSortedSet                       | RecordStructInts | 10000   | False   |         45.517 ns |         6.0418 ns |      0.3312 ns |         - |
| Array                                    | RecordStructInts | 10000   | False   |      4,651.777 ns |       200.9877 ns |     11.0168 ns |         - |
| List                                     | RecordStructInts | 10000   | False   |      4,651.967 ns |       206.1396 ns |     11.2992 ns |         - |
| ImmutableArray                           | RecordStructInts | 10000   | False   |      4,653.403 ns |       294.7165 ns |     16.1544 ns |         - |
| ReadOnlyCollection                       | RecordStructInts | 10000   | False   |      4,677.911 ns |       295.5225 ns |     16.1986 ns |         - |
| LinkedList                               | RecordStructInts | 10000   | False   |     12,266.830 ns |       409.7900 ns |     22.4620 ns |         - |
| ImmutableList                            | RecordStructInts | 10000   | False   |     54,419.420 ns |    16,001.4659 ns |    877.0943 ns |         - |
|                                          |                  |         |         |                   |                   |                |           |
| **FrozenSet**                                | **RecordStructInts** | **10000**   | **True**    |          **3.617 ns** |         **0.3268 ns** |      **0.0179 ns** |         **-** |
| FrozenDictionary                         | RecordStructInts | 10000   | True    |          3.825 ns |         0.6432 ns |      0.0353 ns |         - |
| ReadOnlyDictionary                       | RecordStructInts | 10000   | True    |          4.964 ns |         0.2258 ns |      0.0124 ns |         - |
| HashSet                                  | RecordStructInts | 10000   | True    |          5.053 ns |         0.9931 ns |      0.0544 ns |         - |
| Dictionary                               | RecordStructInts | 10000   | True    |          5.131 ns |         0.7391 ns |      0.0405 ns |         - |
| ImmutableDictionary                      | RecordStructInts | 10000   | True    |         10.062 ns |         2.5948 ns |      0.1422 ns |         - |
| ImmutableHashSet                         | RecordStructInts | 10000   | True    |         10.342 ns |         3.1305 ns |      0.1716 ns |         - |
| SortedSet                                | RecordStructInts | 10000   | True    |         23.076 ns |        12.6639 ns |      0.6942 ns |         - |
| &#39;Array (Sorted + BinarySearch)&#39;          | RecordStructInts | 10000   | True    |         24.800 ns |         2.4308 ns |      0.1332 ns |         - |
| &#39;ImmutableArray (Sorted + BinarySearch)&#39; | RecordStructInts | 10000   | True    |         24.969 ns |         2.4141 ns |      0.1323 ns |         - |
| &#39;List (Sorted + BinarySearch)&#39;           | RecordStructInts | 10000   | True    |         25.205 ns |         1.8623 ns |      0.1021 ns |         - |
| SortedList                               | RecordStructInts | 10000   | True    |         26.736 ns |         7.0628 ns |      0.3871 ns |      32 B |
| SortedDictionary                         | RecordStructInts | 10000   | True    |         28.281 ns |         8.4192 ns |      0.4615 ns |      32 B |
| &#39;ImmutableList (Sorted + BinarySearch)&#39;  | RecordStructInts | 10000   | True    |         33.922 ns |         0.5185 ns |      0.0284 ns |         - |
| ImmutableSortedSet                       | RecordStructInts | 10000   | True    |         35.732 ns |         0.9829 ns |      0.0539 ns |         - |
| ImmutableSortedDictionary                | RecordStructInts | 10000   | True    |         36.016 ns |         2.4516 ns |      0.1344 ns |         - |
| List                                     | RecordStructInts | 10000   | True    |      2,207.361 ns |       123.7968 ns |      6.7857 ns |         - |
| ReadOnlyCollection                       | RecordStructInts | 10000   | True    |      2,240.552 ns |       606.0267 ns |     33.2184 ns |         - |
| ImmutableArray                           | RecordStructInts | 10000   | True    |      2,244.271 ns |       433.3323 ns |     23.7524 ns |         - |
| Array                                    | RecordStructInts | 10000   | True    |      2,297.869 ns |       170.9718 ns |      9.3715 ns |         - |
| LinkedList                               | RecordStructInts | 10000   | True    |      5,799.195 ns |        84.3185 ns |      4.6218 ns |         - |
| ImmutableList                            | RecordStructInts | 10000   | True    |     21,989.988 ns |     4,901.1346 ns |    268.6477 ns |         - |
|                                          |                  |         |         |                   |                   |                |           |
| **FrozenDictionary**                         | **RecordStructInts** | **1000000** | **False**   |          **2.527 ns** |         **0.1167 ns** |      **0.0064 ns** |         **-** |
| FrozenSet                                | RecordStructInts | 1000000 | False   |          2.529 ns |         0.0995 ns |      0.0055 ns |         - |
| Dictionary                               | RecordStructInts | 1000000 | False   |          3.970 ns |         0.9638 ns |      0.0528 ns |         - |
| HashSet                                  | RecordStructInts | 1000000 | False   |          4.006 ns |         0.1542 ns |      0.0084 ns |         - |
| ReadOnlyDictionary                       | RecordStructInts | 1000000 | False   |          4.196 ns |         0.1018 ns |      0.0056 ns |         - |
| ImmutableHashSet                         | RecordStructInts | 1000000 | False   |         23.629 ns |         0.9849 ns |      0.0540 ns |         - |
| ImmutableDictionary                      | RecordStructInts | 1000000 | False   |         26.203 ns |         0.6282 ns |      0.0344 ns |         - |
| SortedSet                                | RecordStructInts | 1000000 | False   |         28.046 ns |         1.0771 ns |      0.0590 ns |         - |
| &#39;List (Sorted + BinarySearch)&#39;           | RecordStructInts | 1000000 | False   |         30.574 ns |         0.5013 ns |      0.0275 ns |         - |
| &#39;ImmutableArray (Sorted + BinarySearch)&#39; | RecordStructInts | 1000000 | False   |         30.658 ns |         0.9407 ns |      0.0516 ns |         - |
| &#39;Array (Sorted + BinarySearch)&#39;          | RecordStructInts | 1000000 | False   |         30.700 ns |         0.6783 ns |      0.0372 ns |         - |
| SortedList                               | RecordStructInts | 1000000 | False   |         33.461 ns |         3.4636 ns |      0.1899 ns |      32 B |
| ImmutableSortedDictionary                | RecordStructInts | 1000000 | False   |         56.012 ns |         1.4491 ns |      0.0794 ns |         - |
| SortedDictionary                         | RecordStructInts | 1000000 | False   |         58.736 ns |         1.1398 ns |      0.0625 ns |      32 B |
| ImmutableSortedSet                       | RecordStructInts | 1000000 | False   |         60.897 ns |         7.3149 ns |      0.4010 ns |         - |
| &#39;ImmutableList (Sorted + BinarySearch)&#39;  | RecordStructInts | 1000000 | False   |         67.210 ns |         4.2968 ns |      0.2355 ns |         - |
| List                                     | RecordStructInts | 1000000 | False   |    537,089.659 ns |    54,509.5825 ns |  2,987.8542 ns |         - |
| ReadOnlyCollection                       | RecordStructInts | 1000000 | False   |    547,954.905 ns |    45,781.7714 ns |  2,509.4534 ns |         - |
| Array                                    | RecordStructInts | 1000000 | False   |    549,724.674 ns |    67,754.8272 ns |  3,713.8707 ns |         - |
| ImmutableArray                           | RecordStructInts | 1000000 | False   |    551,084.983 ns |    78,942.1390 ns |  4,327.0850 ns |         - |
| LinkedList                               | RecordStructInts | 1000000 | False   |  2,705,978.819 ns |    39,639.9223 ns |  2,172.7979 ns |       2 B |
| ImmutableList                            | RecordStructInts | 1000000 | False   | 15,092,425.000 ns | 1,168,676.3428 ns | 64,059.0939 ns |      20 B |
|                                          |                  |         |         |                   |                   |                |           |
| **FrozenSet**                                | **RecordStructInts** | **1000000** | **True**    |          **3.643 ns** |         **0.1272 ns** |      **0.0070 ns** |         **-** |
| FrozenDictionary                         | RecordStructInts | 1000000 | True    |          3.798 ns |         0.1720 ns |      0.0094 ns |         - |
| Dictionary                               | RecordStructInts | 1000000 | True    |          4.570 ns |         0.2399 ns |      0.0131 ns |         - |
| HashSet                                  | RecordStructInts | 1000000 | True    |          4.726 ns |         0.1173 ns |      0.0064 ns |         - |
| ReadOnlyDictionary                       | RecordStructInts | 1000000 | True    |          4.836 ns |         0.9586 ns |      0.0525 ns |         - |
| ImmutableHashSet                         | RecordStructInts | 1000000 | True    |         21.240 ns |         0.6278 ns |      0.0344 ns |         - |
| ImmutableDictionary                      | RecordStructInts | 1000000 | True    |         23.438 ns |         0.3337 ns |      0.0183 ns |         - |
| SortedSet                                | RecordStructInts | 1000000 | True    |         29.095 ns |         0.9032 ns |      0.0495 ns |         - |
| &#39;List (Sorted + BinarySearch)&#39;           | RecordStructInts | 1000000 | True    |         32.323 ns |         1.7496 ns |      0.0959 ns |         - |
| &#39;ImmutableArray (Sorted + BinarySearch)&#39; | RecordStructInts | 1000000 | True    |         32.349 ns |         0.5079 ns |      0.0278 ns |         - |
| &#39;Array (Sorted + BinarySearch)&#39;          | RecordStructInts | 1000000 | True    |         33.934 ns |         1.4610 ns |      0.0801 ns |         - |
| SortedList                               | RecordStructInts | 1000000 | True    |         34.058 ns |         1.3567 ns |      0.0744 ns |      32 B |
| ImmutableSortedDictionary                | RecordStructInts | 1000000 | True    |         50.435 ns |         4.7425 ns |      0.2600 ns |         - |
| SortedDictionary                         | RecordStructInts | 1000000 | True    |         50.943 ns |         4.3222 ns |      0.2369 ns |      32 B |
| ImmutableSortedSet                       | RecordStructInts | 1000000 | True    |         55.784 ns |         1.5053 ns |      0.0825 ns |         - |
| &#39;ImmutableList (Sorted + BinarySearch)&#39;  | RecordStructInts | 1000000 | True    |         56.679 ns |         0.6799 ns |      0.0373 ns |         - |
| ImmutableArray                           | RecordStructInts | 1000000 | True    |    222,768.061 ns |    13,835.8174 ns |    758.3878 ns |         - |
| ReadOnlyCollection                       | RecordStructInts | 1000000 | True    |    223,430.914 ns |    33,054.1443 ns |  1,811.8092 ns |         - |
| Array                                    | RecordStructInts | 1000000 | True    |    224,349.593 ns |    32,108.2465 ns |  1,759.9613 ns |         - |
| List                                     | RecordStructInts | 1000000 | True    |    225,138.216 ns |    27,383.6181 ns |  1,500.9885 ns |         - |
| LinkedList                               | RecordStructInts | 1000000 | True    |  1,158,649.870 ns |     5,816.9083 ns |    318.8444 ns |       1 B |
| ImmutableList                            | RecordStructInts | 1000000 | True    |  5,729,120.139 ns | 1,053,732.8264 ns | 57,758.6519 ns |       8 B |
