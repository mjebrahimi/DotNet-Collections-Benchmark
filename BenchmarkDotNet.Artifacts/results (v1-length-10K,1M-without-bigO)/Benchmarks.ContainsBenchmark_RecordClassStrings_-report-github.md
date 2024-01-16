```

BenchmarkDotNet v0.13.11, Windows 11 (10.0.22631.2861/23H2/2023Update/SunValley3)
AMD Ryzen 7 5800H with Radeon Graphics, 1 CPU, 16 logical and 8 physical cores
.NET SDK 8.0.100
  [Host]   : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                                   | DataType           | Length  | Existed | Mean             | Error             | StdDev           | Allocated |
|----------------------------------------- |------------------- |-------- |-------- |-----------------:|------------------:|-----------------:|----------:|
| **FrozenDictionary**                         | **RecordClassStrings** | **10000**   | **False**   |         **25.18 ns** |          **0.617 ns** |         **0.034 ns** |         **-** |
| FrozenSet                                | RecordClassStrings | 10000   | False   |         25.64 ns |          2.987 ns |         0.164 ns |         - |
| HashSet                                  | RecordClassStrings | 10000   | False   |         26.93 ns |          0.943 ns |         0.052 ns |         - |
| Dictionary                               | RecordClassStrings | 10000   | False   |         27.20 ns |          1.481 ns |         0.081 ns |         - |
| ReadOnlyDictionary                       | RecordClassStrings | 10000   | False   |         29.93 ns |          1.694 ns |         0.093 ns |         - |
| ImmutableDictionary                      | RecordClassStrings | 10000   | False   |         42.49 ns |          2.247 ns |         0.123 ns |         - |
| ImmutableHashSet                         | RecordClassStrings | 10000   | False   |         52.14 ns |          0.154 ns |         0.008 ns |         - |
| SortedSet                                | RecordClassStrings | 10000   | False   |        416.25 ns |         23.430 ns |         1.284 ns |         - |
| &#39;List (Sorted + BinarySearch)&#39;           | RecordClassStrings | 10000   | False   |        427.60 ns |         19.628 ns |         1.076 ns |         - |
| &#39;ImmutableArray (Sorted + BinarySearch)&#39; | RecordClassStrings | 10000   | False   |        430.70 ns |         30.732 ns |         1.685 ns |         - |
| &#39;Array (Sorted + BinarySearch)&#39;          | RecordClassStrings | 10000   | False   |        430.78 ns |         52.814 ns |         2.895 ns |         - |
| SortedList                               | RecordClassStrings | 10000   | False   |        436.91 ns |         38.162 ns |         2.092 ns |         - |
| ImmutableSortedSet                       | RecordClassStrings | 10000   | False   |        437.89 ns |          6.211 ns |         0.340 ns |         - |
| ImmutableSortedDictionary                | RecordClassStrings | 10000   | False   |        438.77 ns |         16.709 ns |         0.916 ns |         - |
| SortedDictionary                         | RecordClassStrings | 10000   | False   |        465.11 ns |         35.685 ns |         1.956 ns |         - |
| &#39;ImmutableList (Sorted + BinarySearch)&#39;  | RecordClassStrings | 10000   | False   |        473.33 ns |         24.658 ns |         1.352 ns |         - |
| ReadOnlyCollection                       | RecordClassStrings | 10000   | False   |     41,219.17 ns |     14,609.913 ns |       800.819 ns |         - |
| ImmutableArray                           | RecordClassStrings | 10000   | False   |     45,154.70 ns |        146.701 ns |         8.041 ns |         - |
| List                                     | RecordClassStrings | 10000   | False   |     45,598.72 ns |      4,932.217 ns |       270.351 ns |         - |
| LinkedList                               | RecordClassStrings | 10000   | False   |     45,774.91 ns |     14,330.189 ns |       785.486 ns |         - |
| Array                                    | RecordClassStrings | 10000   | False   |     45,791.31 ns |      3,941.726 ns |       216.059 ns |         - |
| ImmutableList                            | RecordClassStrings | 10000   | False   |    127,897.05 ns |      7,630.415 ns |       418.249 ns |         - |
|                                          |                    |         |         |                  |                   |                  |           |
| **FrozenSet**                                | **RecordClassStrings** | **10000**   | **True**    |         **28.28 ns** |          **4.264 ns** |         **0.234 ns** |         **-** |
| FrozenDictionary                         | RecordClassStrings | 10000   | True    |         28.29 ns |          0.679 ns |         0.037 ns |         - |
| Dictionary                               | RecordClassStrings | 10000   | True    |         30.63 ns |          1.421 ns |         0.078 ns |         - |
| HashSet                                  | RecordClassStrings | 10000   | True    |         30.92 ns |          2.930 ns |         0.161 ns |         - |
| ReadOnlyDictionary                       | RecordClassStrings | 10000   | True    |         32.37 ns |          0.456 ns |         0.025 ns |         - |
| ImmutableDictionary                      | RecordClassStrings | 10000   | True    |         42.16 ns |          8.308 ns |         0.455 ns |         - |
| ImmutableHashSet                         | RecordClassStrings | 10000   | True    |         53.77 ns |          2.273 ns |         0.125 ns |         - |
| ImmutableSortedSet                       | RecordClassStrings | 10000   | True    |        355.81 ns |         71.261 ns |         3.906 ns |         - |
| ImmutableSortedDictionary                | RecordClassStrings | 10000   | True    |        362.41 ns |         74.340 ns |         4.075 ns |         - |
| SortedSet                                | RecordClassStrings | 10000   | True    |        366.92 ns |         21.522 ns |         1.180 ns |         - |
| &#39;ImmutableList (Sorted + BinarySearch)&#39;  | RecordClassStrings | 10000   | True    |        381.86 ns |         24.179 ns |         1.325 ns |         - |
| &#39;Array (Sorted + BinarySearch)&#39;          | RecordClassStrings | 10000   | True    |        383.76 ns |         54.311 ns |         2.977 ns |         - |
| &#39;ImmutableArray (Sorted + BinarySearch)&#39; | RecordClassStrings | 10000   | True    |        394.73 ns |          7.764 ns |         0.426 ns |         - |
| SortedList                               | RecordClassStrings | 10000   | True    |        396.79 ns |         22.241 ns |         1.219 ns |         - |
| &#39;List (Sorted + BinarySearch)&#39;           | RecordClassStrings | 10000   | True    |        396.80 ns |         29.209 ns |         1.601 ns |         - |
| SortedDictionary                         | RecordClassStrings | 10000   | True    |        403.29 ns |         81.464 ns |         4.465 ns |         - |
| ReadOnlyCollection                       | RecordClassStrings | 10000   | True    |     15,668.67 ns |      2,356.887 ns |       129.189 ns |         - |
| Array                                    | RecordClassStrings | 10000   | True    |     17,576.65 ns |      2,200.929 ns |       120.640 ns |         - |
| LinkedList                               | RecordClassStrings | 10000   | True    |     17,724.57 ns |      1,416.529 ns |        77.645 ns |         - |
| ImmutableArray                           | RecordClassStrings | 10000   | True    |     17,841.52 ns |      4,714.238 ns |       258.403 ns |         - |
| List                                     | RecordClassStrings | 10000   | True    |     17,899.24 ns |      3,539.749 ns |       194.026 ns |         - |
| ImmutableList                            | RecordClassStrings | 10000   | True    |     43,323.83 ns |      8,479.683 ns |       464.800 ns |         - |
|                                          |                    |         |         |                  |                   |                  |           |
| **FrozenDictionary**                         | **RecordClassStrings** | **1000000** | **False**   |         **25.79 ns** |          **0.998 ns** |         **0.055 ns** |         **-** |
| FrozenSet                                | RecordClassStrings | 1000000 | False   |         26.11 ns |          0.117 ns |         0.006 ns |         - |
| Dictionary                               | RecordClassStrings | 1000000 | False   |         28.01 ns |          6.627 ns |         0.363 ns |         - |
| HashSet                                  | RecordClassStrings | 1000000 | False   |         28.14 ns |          0.645 ns |         0.035 ns |         - |
| ReadOnlyDictionary                       | RecordClassStrings | 1000000 | False   |         28.97 ns |          1.357 ns |         0.074 ns |         - |
| ImmutableDictionary                      | RecordClassStrings | 1000000 | False   |         66.66 ns |          3.379 ns |         0.185 ns |         - |
| ImmutableHashSet                         | RecordClassStrings | 1000000 | False   |         84.65 ns |         14.768 ns |         0.809 ns |         - |
| SortedSet                                | RecordClassStrings | 1000000 | False   |        673.53 ns |         30.913 ns |         1.694 ns |         - |
| &#39;List (Sorted + BinarySearch)&#39;           | RecordClassStrings | 1000000 | False   |        706.31 ns |          8.342 ns |         0.457 ns |         - |
| ImmutableSortedSet                       | RecordClassStrings | 1000000 | False   |        711.72 ns |         27.525 ns |         1.509 ns |         - |
| ImmutableSortedDictionary                | RecordClassStrings | 1000000 | False   |        713.28 ns |         41.026 ns |         2.249 ns |         - |
| &#39;Array (Sorted + BinarySearch)&#39;          | RecordClassStrings | 1000000 | False   |        716.07 ns |         23.037 ns |         1.263 ns |         - |
| SortedList                               | RecordClassStrings | 1000000 | False   |        728.72 ns |         48.021 ns |         2.632 ns |         - |
| &#39;ImmutableArray (Sorted + BinarySearch)&#39; | RecordClassStrings | 1000000 | False   |        730.12 ns |        161.846 ns |         8.871 ns |         - |
| SortedDictionary                         | RecordClassStrings | 1000000 | False   |        753.02 ns |         19.189 ns |         1.052 ns |         - |
| &#39;ImmutableList (Sorted + BinarySearch)&#39;  | RecordClassStrings | 1000000 | False   |        783.34 ns |        284.116 ns |        15.573 ns |         - |
| ReadOnlyCollection                       | RecordClassStrings | 1000000 | False   |  8,338,470.37 ns |    140,451.729 ns |     7,698.633 ns |      20 B |
| ImmutableArray                           | RecordClassStrings | 1000000 | False   |  8,580,408.33 ns |    274,618.805 ns |    15,052.783 ns |      12 B |
| List                                     | RecordClassStrings | 1000000 | False   |  8,586,107.22 ns |    773,744.705 ns |    42,411.558 ns |      12 B |
| Array                                    | RecordClassStrings | 1000000 | False   |  8,944,730.56 ns |  9,581,470.485 ns |   525,192.729 ns |      12 B |
| LinkedList                               | RecordClassStrings | 1000000 | False   |  9,167,512.96 ns |    640,822.612 ns |    35,125.650 ns |      20 B |
| ImmutableList                            | RecordClassStrings | 1000000 | False   | 56,856,838.89 ns | 59,544,268.433 ns | 3,263,822.276 ns |      61 B |
|                                          |                    |         |         |                  |                   |                  |           |
| **FrozenSet**                                | **RecordClassStrings** | **1000000** | **True**    |         **29.23 ns** |          **0.584 ns** |         **0.032 ns** |         **-** |
| FrozenDictionary                         | RecordClassStrings | 1000000 | True    |         29.61 ns |          0.343 ns |         0.019 ns |         - |
| HashSet                                  | RecordClassStrings | 1000000 | True    |         31.62 ns |          0.601 ns |         0.033 ns |         - |
| Dictionary                               | RecordClassStrings | 1000000 | True    |         32.24 ns |          0.709 ns |         0.039 ns |         - |
| ReadOnlyDictionary                       | RecordClassStrings | 1000000 | True    |         34.27 ns |          1.164 ns |         0.064 ns |         - |
| ImmutableDictionary                      | RecordClassStrings | 1000000 | True    |         66.83 ns |          1.187 ns |         0.065 ns |         - |
| ImmutableHashSet                         | RecordClassStrings | 1000000 | True    |         82.95 ns |         16.173 ns |         0.886 ns |         - |
| ImmutableSortedDictionary                | RecordClassStrings | 1000000 | True    |        591.48 ns |          3.860 ns |         0.212 ns |         - |
| ImmutableSortedSet                       | RecordClassStrings | 1000000 | True    |        593.33 ns |         56.852 ns |         3.116 ns |         - |
| SortedSet                                | RecordClassStrings | 1000000 | True    |        623.30 ns |        167.245 ns |         9.167 ns |         - |
| SortedDictionary                         | RecordClassStrings | 1000000 | True    |        623.65 ns |         28.879 ns |         1.583 ns |         - |
| &#39;Array (Sorted + BinarySearch)&#39;          | RecordClassStrings | 1000000 | True    |        638.34 ns |        131.876 ns |         7.229 ns |         - |
| &#39;ImmutableList (Sorted + BinarySearch)&#39;  | RecordClassStrings | 1000000 | True    |        638.64 ns |         20.045 ns |         1.099 ns |         - |
| &#39;ImmutableArray (Sorted + BinarySearch)&#39; | RecordClassStrings | 1000000 | True    |        641.72 ns |         42.554 ns |         2.333 ns |         - |
| &#39;List (Sorted + BinarySearch)&#39;           | RecordClassStrings | 1000000 | True    |        648.74 ns |        288.027 ns |        15.788 ns |         - |
| SortedList                               | RecordClassStrings | 1000000 | True    |        649.14 ns |         57.733 ns |         3.165 ns |         - |
| ReadOnlyCollection                       | RecordClassStrings | 1000000 | True    |  2,660,455.90 ns |    143,022.112 ns |     7,839.525 ns |       4 B |
| ImmutableArray                           | RecordClassStrings | 1000000 | True    |  2,728,113.72 ns |     33,109.000 ns |     1,814.816 ns |       4 B |
| List                                     | RecordClassStrings | 1000000 | True    |  2,736,414.93 ns |    125,068.241 ns |     6,855.412 ns |       4 B |
| Array                                    | RecordClassStrings | 1000000 | True    |  2,769,055.56 ns |  1,260,785.658 ns |    69,107.916 ns |       4 B |
| LinkedList                               | RecordClassStrings | 1000000 | True    |  2,924,303.15 ns |    325,212.386 ns |    17,825.988 ns |       4 B |
| ImmutableList                            | RecordClassStrings | 1000000 | True    | 16,466,177.78 ns | 29,790,169.022 ns | 1,632,899.687 ns |      20 B |
