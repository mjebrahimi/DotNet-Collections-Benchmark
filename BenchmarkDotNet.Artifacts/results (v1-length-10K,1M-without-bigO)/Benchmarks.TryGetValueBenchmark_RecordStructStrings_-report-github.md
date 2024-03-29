```

BenchmarkDotNet v0.13.11, Windows 11 (10.0.22631.2861/23H2/2023Update/SunValley3)
AMD Ryzen 7 5800H with Radeon Graphics, 1 CPU, 16 logical and 8 physical cores
.NET SDK 8.0.100
  [Host]   : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                                   | DataType            | Length  | Existed | Mean             | Error             | StdDev         | Allocated |
|----------------------------------------- |-------------------- |-------- |-------- |-----------------:|------------------:|---------------:|----------:|
| **FrozenDictionary**                         | **RecordStructStrings** | **10000**   | **False**   |         **21.60 ns** |          **2.119 ns** |       **0.116 ns** |         **-** |
| FrozenSet                                | RecordStructStrings | 10000   | False   |         21.74 ns |          0.130 ns |       0.007 ns |         - |
| Dictionary                               | RecordStructStrings | 10000   | False   |         22.33 ns |          2.043 ns |       0.112 ns |         - |
| ReadOnlyDictionary                       | RecordStructStrings | 10000   | False   |         24.19 ns |          3.243 ns |       0.178 ns |         - |
| HashSet                                  | RecordStructStrings | 10000   | False   |         24.51 ns |          0.419 ns |       0.023 ns |         - |
| ImmutableHashSet                         | RecordStructStrings | 10000   | False   |         28.92 ns |          0.524 ns |       0.029 ns |         - |
| ImmutableDictionary                      | RecordStructStrings | 10000   | False   |         32.79 ns |          2.973 ns |       0.163 ns |         - |
| SortedSet                                | RecordStructStrings | 10000   | False   |        382.53 ns |         14.169 ns |       0.777 ns |         - |
| &#39;ImmutableArray (Sorted + BinarySearch)&#39; | RecordStructStrings | 10000   | False   |        391.08 ns |        151.770 ns |       8.319 ns |         - |
| &#39;Array (Sorted + BinarySearch)&#39;          | RecordStructStrings | 10000   | False   |        394.51 ns |         63.457 ns |       3.478 ns |         - |
| &#39;List (Sorted + BinarySearch)&#39;           | RecordStructStrings | 10000   | False   |        397.73 ns |         18.543 ns |       1.016 ns |         - |
| SortedList                               | RecordStructStrings | 10000   | False   |        400.66 ns |         39.484 ns |       2.164 ns |      40 B |
| &#39;ImmutableList (Sorted + BinarySearch)&#39;  | RecordStructStrings | 10000   | False   |        408.25 ns |          6.565 ns |       0.360 ns |         - |
| ImmutableSortedDictionary                | RecordStructStrings | 10000   | False   |        409.67 ns |          2.758 ns |       0.151 ns |         - |
| ImmutableSortedSet                       | RecordStructStrings | 10000   | False   |        412.74 ns |         56.090 ns |       3.074 ns |         - |
| SortedDictionary                         | RecordStructStrings | 10000   | False   |        423.23 ns |         38.262 ns |       2.097 ns |      40 B |
| ReadOnlyCollection                       | RecordStructStrings | 10000   | False   |     23,688.19 ns |      7,092.085 ns |     388.741 ns |         - |
| List                                     | RecordStructStrings | 10000   | False   |     24,136.84 ns |      5,145.209 ns |     282.026 ns |         - |
| Array                                    | RecordStructStrings | 10000   | False   |     26,200.49 ns |     13,029.083 ns |     714.168 ns |         - |
| ImmutableArray                           | RecordStructStrings | 10000   | False   |     26,412.08 ns |     27,879.532 ns |   1,528.171 ns |         - |
| LinkedList                               | RecordStructStrings | 10000   | False   |     26,457.93 ns |      3,747.818 ns |     205.431 ns |         - |
| ImmutableList                            | RecordStructStrings | 10000   | False   |    116,258.27 ns |     67,390.867 ns |   3,693.921 ns |         - |
|                                          |                     |         |         |                  |                   |                |           |
| **FrozenDictionary**                         | **RecordStructStrings** | **10000**   | **True**    |         **23.14 ns** |          **1.087 ns** |       **0.060 ns** |         **-** |
| FrozenSet                                | RecordStructStrings | 10000   | True    |         24.03 ns |          2.902 ns |       0.159 ns |         - |
| HashSet                                  | RecordStructStrings | 10000   | True    |         24.41 ns |          0.611 ns |       0.033 ns |         - |
| Dictionary                               | RecordStructStrings | 10000   | True    |         24.47 ns |          1.848 ns |       0.101 ns |         - |
| ReadOnlyDictionary                       | RecordStructStrings | 10000   | True    |         26.34 ns |          0.756 ns |       0.041 ns |         - |
| ImmutableHashSet                         | RecordStructStrings | 10000   | True    |         30.17 ns |          2.338 ns |       0.128 ns |         - |
| ImmutableDictionary                      | RecordStructStrings | 10000   | True    |         33.30 ns |          0.245 ns |       0.013 ns |         - |
| ImmutableSortedDictionary                | RecordStructStrings | 10000   | True    |        329.49 ns |         15.530 ns |       0.851 ns |         - |
| ImmutableSortedSet                       | RecordStructStrings | 10000   | True    |        333.13 ns |         88.855 ns |       4.870 ns |         - |
| SortedSet                                | RecordStructStrings | 10000   | True    |        337.86 ns |         37.443 ns |       2.052 ns |         - |
| &#39;ImmutableList (Sorted + BinarySearch)&#39;  | RecordStructStrings | 10000   | True    |        340.02 ns |         76.093 ns |       4.171 ns |         - |
| &#39;ImmutableArray (Sorted + BinarySearch)&#39; | RecordStructStrings | 10000   | True    |        349.03 ns |         34.986 ns |       1.918 ns |         - |
| &#39;List (Sorted + BinarySearch)&#39;           | RecordStructStrings | 10000   | True    |        350.77 ns |          3.781 ns |       0.207 ns |         - |
| &#39;Array (Sorted + BinarySearch)&#39;          | RecordStructStrings | 10000   | True    |        352.55 ns |         21.362 ns |       1.171 ns |         - |
| SortedList                               | RecordStructStrings | 10000   | True    |        358.42 ns |         21.242 ns |       1.164 ns |      40 B |
| SortedDictionary                         | RecordStructStrings | 10000   | True    |        359.58 ns |         52.234 ns |       2.863 ns |      40 B |
| ImmutableArray                           | RecordStructStrings | 10000   | True    |     10,023.04 ns |      3,065.372 ns |     168.023 ns |         - |
| List                                     | RecordStructStrings | 10000   | True    |     10,153.92 ns |      2,323.432 ns |     127.355 ns |         - |
| Array                                    | RecordStructStrings | 10000   | True    |     10,768.02 ns |      1,927.372 ns |     105.646 ns |         - |
| ReadOnlyCollection                       | RecordStructStrings | 10000   | True    |     10,893.45 ns |      2,335.048 ns |     127.992 ns |         - |
| LinkedList                               | RecordStructStrings | 10000   | True    |     11,745.09 ns |        669.630 ns |      36.705 ns |         - |
| ImmutableList                            | RecordStructStrings | 10000   | True    |     43,287.40 ns |     19,678.029 ns |   1,078.619 ns |         - |
|                                          |                     |         |         |                  |                   |                |           |
| **FrozenDictionary**                         | **RecordStructStrings** | **1000000** | **False**   |         **22.44 ns** |          **2.083 ns** |       **0.114 ns** |         **-** |
| FrozenSet                                | RecordStructStrings | 1000000 | False   |         22.46 ns |          2.595 ns |       0.142 ns |         - |
| Dictionary                               | RecordStructStrings | 1000000 | False   |         23.33 ns |          1.857 ns |       0.102 ns |         - |
| HashSet                                  | RecordStructStrings | 1000000 | False   |         24.36 ns |          1.054 ns |       0.058 ns |         - |
| ReadOnlyDictionary                       | RecordStructStrings | 1000000 | False   |         24.67 ns |          1.430 ns |       0.078 ns |         - |
| ImmutableHashSet                         | RecordStructStrings | 1000000 | False   |         58.69 ns |          3.459 ns |       0.190 ns |         - |
| ImmutableDictionary                      | RecordStructStrings | 1000000 | False   |         59.11 ns |         12.512 ns |       0.686 ns |         - |
| SortedSet                                | RecordStructStrings | 1000000 | False   |        618.58 ns |         73.690 ns |       4.039 ns |         - |
| &#39;ImmutableArray (Sorted + BinarySearch)&#39; | RecordStructStrings | 1000000 | False   |        627.77 ns |         28.643 ns |       1.570 ns |         - |
| &#39;List (Sorted + BinarySearch)&#39;           | RecordStructStrings | 1000000 | False   |        632.09 ns |         49.970 ns |       2.739 ns |         - |
| &#39;Array (Sorted + BinarySearch)&#39;          | RecordStructStrings | 1000000 | False   |        634.89 ns |         68.514 ns |       3.755 ns |         - |
| ImmutableSortedDictionary                | RecordStructStrings | 1000000 | False   |        662.68 ns |         42.566 ns |       2.333 ns |         - |
| SortedList                               | RecordStructStrings | 1000000 | False   |        664.99 ns |         34.747 ns |       1.905 ns |      40 B |
| &#39;ImmutableList (Sorted + BinarySearch)&#39;  | RecordStructStrings | 1000000 | False   |        665.42 ns |        118.566 ns |       6.499 ns |         - |
| SortedDictionary                         | RecordStructStrings | 1000000 | False   |        666.87 ns |        120.539 ns |       6.607 ns |      40 B |
| ImmutableSortedSet                       | RecordStructStrings | 1000000 | False   |        688.77 ns |        348.631 ns |      19.110 ns |         - |
| ReadOnlyCollection                       | RecordStructStrings | 1000000 | False   |  6,107,904.76 ns |    377,885.726 ns |  20,713.192 ns |       9 B |
| ImmutableArray                           | RecordStructStrings | 1000000 | False   |  6,192,821.83 ns |  1,065,613.457 ns |  58,409.869 ns |       9 B |
| Array                                    | RecordStructStrings | 1000000 | False   |  6,304,925.40 ns |    394,293.563 ns |  21,612.561 ns |       9 B |
| List                                     | RecordStructStrings | 1000000 | False   |  6,313,763.10 ns |    932,277.674 ns |  51,101.285 ns |       9 B |
| LinkedList                               | RecordStructStrings | 1000000 | False   |  6,987,311.90 ns |  1,320,436.027 ns |  72,377.554 ns |       9 B |
| ImmutableList                            | RecordStructStrings | 1000000 | False   | 46,129,208.33 ns |  1,402,866.824 ns |  76,895.864 ns |      61 B |
|                                          |                     |         |         |                  |                   |                |           |
| **FrozenDictionary**                         | **RecordStructStrings** | **1000000** | **True**    |         **25.37 ns** |          **0.353 ns** |       **0.019 ns** |         **-** |
| Dictionary                               | RecordStructStrings | 1000000 | True    |         25.96 ns |          0.798 ns |       0.044 ns |         - |
| HashSet                                  | RecordStructStrings | 1000000 | True    |         26.32 ns |          1.219 ns |       0.067 ns |         - |
| FrozenSet                                | RecordStructStrings | 1000000 | True    |         26.56 ns |          4.923 ns |       0.270 ns |         - |
| ReadOnlyDictionary                       | RecordStructStrings | 1000000 | True    |         28.56 ns |          1.238 ns |       0.068 ns |         - |
| ImmutableDictionary                      | RecordStructStrings | 1000000 | True    |         53.27 ns |          1.826 ns |       0.100 ns |         - |
| ImmutableHashSet                         | RecordStructStrings | 1000000 | True    |         54.84 ns |          5.264 ns |       0.289 ns |         - |
| SortedDictionary                         | RecordStructStrings | 1000000 | True    |        547.27 ns |         35.832 ns |       1.964 ns |      40 B |
| ImmutableSortedDictionary                | RecordStructStrings | 1000000 | True    |        552.22 ns |         76.439 ns |       4.190 ns |         - |
| ImmutableSortedSet                       | RecordStructStrings | 1000000 | True    |        554.41 ns |         30.816 ns |       1.689 ns |         - |
| &#39;ImmutableArray (Sorted + BinarySearch)&#39; | RecordStructStrings | 1000000 | True    |        558.71 ns |         40.890 ns |       2.241 ns |         - |
| &#39;Array (Sorted + BinarySearch)&#39;          | RecordStructStrings | 1000000 | True    |        565.38 ns |        293.350 ns |      16.080 ns |         - |
| &#39;ImmutableList (Sorted + BinarySearch)&#39;  | RecordStructStrings | 1000000 | True    |        572.92 ns |         23.367 ns |       1.281 ns |         - |
| SortedSet                                | RecordStructStrings | 1000000 | True    |        581.01 ns |         69.202 ns |       3.793 ns |         - |
| SortedList                               | RecordStructStrings | 1000000 | True    |        593.75 ns |         81.008 ns |       4.440 ns |      40 B |
| &#39;List (Sorted + BinarySearch)&#39;           | RecordStructStrings | 1000000 | True    |        600.57 ns |         56.209 ns |       3.081 ns |         - |
| ReadOnlyCollection                       | RecordStructStrings | 1000000 | True    |  1,963,115.93 ns |    100,263.290 ns |   5,495.769 ns |       2 B |
| List                                     | RecordStructStrings | 1000000 | True    |  1,973,972.87 ns |     51,705.746 ns |   2,834.166 ns |       2 B |
| Array                                    | RecordStructStrings | 1000000 | True    |  1,995,079.51 ns |    236,542.284 ns |  12,965.681 ns |       2 B |
| ImmutableArray                           | RecordStructStrings | 1000000 | True    |  2,050,006.68 ns |    794,448.374 ns |  43,546.396 ns |       2 B |
| LinkedList                               | RecordStructStrings | 1000000 | True    |  2,198,941.75 ns |    966,263.534 ns |  52,964.165 ns |       1 B |
| ImmutableList                            | RecordStructStrings | 1000000 | True    | 15,400,626.85 ns | 15,092,427.185 ns | 827,266.861 ns |      20 B |
