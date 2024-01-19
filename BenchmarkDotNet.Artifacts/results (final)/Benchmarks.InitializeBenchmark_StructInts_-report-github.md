```

BenchmarkDotNet v0.13.11, Windows 11 (10.0.22631.2861/23H2/2023Update/SunValley3)
AMD Ryzen 7 5800H with Radeon Graphics, 1 CPU, 16 logical and 8 physical cores
.NET SDK 8.0.100
  [Host]   : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                    | DataType   | Length  | Sorted   | Mean            | Error            | StdDev        | Allocated    |
|-------------------------- |----------- |-------- |--------- |----------------:|-----------------:|--------------:|-------------:|
| **Array**                     | **StructInts** | **10000**   | **False**    |        **49.54 μs** |         **6.834 μs** |      **0.375 μs** |    **117.22 KB** |
| ImmutableArray            | StructInts | 10000   | False    |        49.57 μs |         3.416 μs |      0.187 μs |    117.22 KB |
| List                      | StructInts | 10000   | False    |        49.78 μs |        12.161 μs |      0.667 μs |    117.25 KB |
| ReadOnlyCollection        | StructInts | 10000   | False    |        52.25 μs |        12.021 μs |      0.659 μs |    117.25 KB |
| ImmutableList             | StructInts | 10000   | False    |       122.48 μs |        75.045 μs |      4.113 μs |    546.92 KB |
| LinkedList                | StructInts | 10000   | False    |       127.29 μs |        89.692 μs |      4.916 μs |    546.95 KB |
| HashSet                   | StructInts | 10000   | False    |       372.90 μs |       125.487 μs |      6.878 μs |    549.46 KB |
| Dictionary                | StructInts | 10000   | False    |       399.97 μs |       130.333 μs |      7.144 μs |    588.91 KB |
| ReadOnlyDictionary        | StructInts | 10000   | False    |       404.26 μs |        57.602 μs |      3.157 μs |    588.95 KB |
| &#39;Array (Sorted)&#39;          | StructInts | 10000   | False    |       478.77 μs |        23.994 μs |      1.315 μs |    117.22 KB |
| &#39;List (Sorted)&#39;           | StructInts | 10000   | False    |       480.98 μs |        40.213 μs |      2.204 μs |    117.25 KB |
| &#39;ImmutableArray (Sorted)&#39; | StructInts | 10000   | False    |       495.91 μs |        97.233 μs |      5.330 μs |    234.45 KB |
| SortedSet                 | StructInts | 10000   | False    |       607.60 μs |        81.035 μs |      4.442 μs |    586.02 KB |
| ImmutableSortedSet        | StructInts | 10000   | False    |       650.17 μs |       127.383 μs |      6.982 μs |    664.18 KB |
| &#39;ImmutableList (Sorted)&#39;  | StructInts | 10000   | False    |       869.22 μs |       291.586 μs |     15.983 μs |   1211.07 KB |
| FrozenDictionary          | StructInts | 10000   | False    |       874.80 μs |       300.725 μs |     16.484 μs |   1579.07 KB |
| FrozenSet                 | StructInts | 10000   | False    |       920.72 μs |       122.474 μs |      6.713 μs |   1490.77 KB |
| SortedList                | StructInts | 10000   | False    |       974.07 μs |       159.253 μs |      8.729 μs |    716.03 KB |
| SortedDictionary          | StructInts | 10000   | False    |     1,629.18 μs |       351.256 μs |     19.254 μs |   1135.95 KB |
| ImmutableHashSet          | StructInts | 10000   | False    |     2,490.51 μs |       124.379 μs |      6.818 μs |    937.58 KB |
| ImmutableSortedDictionary | StructInts | 10000   | False    |     2,547.80 μs |        70.212 μs |      3.849 μs |    1797.6 KB |
| ImmutableDictionary       | StructInts | 10000   | False    |     2,677.68 μs |       222.867 μs |     12.216 μs |    937.69 KB |
|                           |            |         |          |                 |                  |               |              |
| **List**                      | **StructInts** | **10000**   | **True**     |        **48.99 μs** |         **3.330 μs** |      **0.183 μs** |    **117.25 KB** |
| ImmutableArray            | StructInts | 10000   | True     |        49.59 μs |         3.226 μs |      0.177 μs |    117.22 KB |
| ReadOnlyCollection        | StructInts | 10000   | True     |        49.92 μs |        12.899 μs |      0.707 μs |    117.25 KB |
| Array                     | StructInts | 10000   | True     |        49.98 μs |         8.203 μs |      0.450 μs |    117.22 KB |
| &#39;ImmutableArray (Sorted)&#39; | StructInts | 10000   | True     |        61.10 μs |        15.782 μs |      0.865 μs |    117.22 KB |
| ImmutableList             | StructInts | 10000   | True     |       121.77 μs |        46.990 μs |      2.576 μs |    546.92 KB |
| LinkedList                | StructInts | 10000   | True     |       126.44 μs |        83.153 μs |      4.558 μs |    546.95 KB |
| &#39;Array (Sorted)&#39;          | StructInts | 10000   | True     |       141.70 μs |        22.323 μs |      1.224 μs |    117.22 KB |
| &#39;List (Sorted)&#39;           | StructInts | 10000   | True     |       142.81 μs |        24.564 μs |      1.346 μs |    117.25 KB |
| SortedSet                 | StructInts | 10000   | True     |       265.47 μs |        68.853 μs |      3.774 μs |    586.02 KB |
| ImmutableSortedSet        | StructInts | 10000   | True     |       303.40 μs |       184.064 μs |     10.089 μs |    664.18 KB |
| HashSet                   | StructInts | 10000   | True     |       372.84 μs |        67.339 μs |      3.691 μs |    549.46 KB |
| Dictionary                | StructInts | 10000   | True     |       395.55 μs |       109.933 μs |      6.026 μs |    588.91 KB |
| ReadOnlyDictionary        | StructInts | 10000   | True     |       405.17 μs |        53.449 μs |      2.930 μs |    588.95 KB |
| &#39;ImmutableList (Sorted)&#39;  | StructInts | 10000   | True     |       549.61 μs |       378.876 μs |     20.767 μs |   1211.07 KB |
| SortedList                | StructInts | 10000   | True     |       662.24 μs |       288.818 μs |     15.831 μs |    716.03 KB |
| FrozenDictionary          | StructInts | 10000   | True     |       869.17 μs |        44.380 μs |      2.433 μs |   1579.07 KB |
| FrozenSet                 | StructInts | 10000   | True     |       913.03 μs |        36.734 μs |      2.013 μs |   1490.77 KB |
| SortedDictionary          | StructInts | 10000   | True     |     1,104.86 μs |       166.500 μs |      9.126 μs |   1135.95 KB |
| ImmutableSortedDictionary | StructInts | 10000   | True     |     1,399.53 μs |       424.091 μs |     23.246 μs |    1797.6 KB |
| ImmutableHashSet          | StructInts | 10000   | True     |     2,540.53 μs |       188.645 μs |     10.340 μs |    937.58 KB |
| ImmutableDictionary       | StructInts | 10000   | True     |     2,666.65 μs |       514.500 μs |     28.201 μs |    937.69 KB |
|                           |            |         |          |                 |                  |               |              |
| **ImmutableArray**            | **StructInts** | **1000000** | **False**    |     **3,273.59 μs** |     **1,587.724 μs** |     **87.029 μs** |  **11718.89 KB** |
| Array                     | StructInts | 1000000 | False    |     3,279.49 μs |       701.747 μs |     38.465 μs |  11718.89 KB |
| ReadOnlyCollection        | StructInts | 1000000 | False    |     3,355.06 μs |     1,632.094 μs |     89.461 μs |  11718.91 KB |
| List                      | StructInts | 1000000 | False    |     3,385.21 μs |       924.373 μs |     50.668 μs |  11718.92 KB |
| &#39;ImmutableArray (Sorted)&#39; | StructInts | 1000000 | False    |    68,780.38 μs |     3,883.706 μs |    212.879 μs |  23437.67 KB |
| &#39;List (Sorted)&#39;           | StructInts | 1000000 | False    |    69,169.95 μs |       806.321 μs |     44.197 μs |  11718.93 KB |
| &#39;Array (Sorted)&#39;          | StructInts | 1000000 | False    |    69,460.58 μs |     1,618.659 μs |     88.724 μs |   11718.9 KB |
| ImmutableList             | StructInts | 1000000 | False    |    81,617.96 μs |    40,801.157 μs |  2,236.449 μs |   54688.2 KB |
| HashSet                   | StructInts | 1000000 | False    |    92,534.76 μs |    66,008.585 μs |  3,618.153 μs |  58517.29 KB |
| LinkedList                | StructInts | 1000000 | False    |    94,274.66 μs |    24,720.356 μs |  1,355.006 μs |  54688.35 KB |
| Dictionary                | StructInts | 1000000 | False    |    95,366.36 μs |    27,677.123 μs |  1,517.076 μs |  63058.68 KB |
| ReadOnlyDictionary        | StructInts | 1000000 | False    |    98,468.03 μs |    72,548.019 μs |  3,976.602 μs |  63058.09 KB |
| ImmutableSortedSet        | StructInts | 1000000 | False    |   152,350.92 μs |    96,443.727 μs |  5,286.406 μs |  66406.88 KB |
| SortedSet                 | StructInts | 1000000 | False    |   162,289.78 μs |     6,004.485 μs |    329.126 μs |  58594.55 KB |
| SortedList                | StructInts | 1000000 | False    |   193,554.06 μs |   145,298.959 μs |  7,964.326 μs |  75753.25 KB |
| FrozenSet                 | StructInts | 1000000 | False    |   200,634.72 μs |    96,156.317 μs |  5,270.652 μs | 157880.99 KB |
| FrozenDictionary          | StructInts | 1000000 | False    |   211,491.02 μs |    29,837.355 μs |  1,635.486 μs | 167306.29 KB |
| &#39;ImmutableList (Sorted)&#39;  | StructInts | 1000000 | False    |   252,204.45 μs |    51,242.302 μs |  2,808.763 μs | 121094.77 KB |
| SortedDictionary          | StructInts | 1000000 | False    |   739,231.10 μs |   301,149.846 μs | 16,507.039 μs | 117746.27 KB |
| ImmutableHashSet          | StructInts | 1000000 | False    | 1,345,858.57 μs |   672,216.265 μs | 36,846.442 μs |   93794.8 KB |
| ImmutableDictionary       | StructInts | 1000000 | False    | 1,354,303.10 μs |   358,864.628 μs | 19,670.581 μs |  93779.76 KB |
| ImmutableSortedDictionary | StructInts | 1000000 | False    | 1,457,313.17 μs |   687,775.763 μs | 37,699.310 μs | 179626.93 KB |
|                           |            |         |          |                 |                  |               |              |
| **List**                      | **StructInts** | **1000000** | **True**     |     **3,286.39 μs** |       **723.511 μs** |     **39.658 μs** |  **11718.92 KB** |
| ReadOnlyCollection        | StructInts | 1000000 | True     |     3,293.87 μs |       991.939 μs |     54.372 μs |  11718.91 KB |
| ImmutableArray            | StructInts | 1000000 | True     |     3,296.75 μs |       921.815 μs |     50.528 μs |  11718.88 KB |
| Array                     | StructInts | 1000000 | True     |     3,300.02 μs |       160.762 μs |      8.812 μs |  11718.88 KB |
| &#39;ImmutableArray (Sorted)&#39; | StructInts | 1000000 | True     |     4,542.70 μs |     3,562.142 μs |    195.253 μs |   11718.9 KB |
| &#39;List (Sorted)&#39;           | StructInts | 1000000 | True     |    18,011.67 μs |     3,978.985 μs |    218.102 μs |  11718.93 KB |
| &#39;Array (Sorted)&#39;          | StructInts | 1000000 | True     |    21,387.96 μs |       359.317 μs |     19.695 μs |   11718.9 KB |
| ImmutableList             | StructInts | 1000000 | True     |    84,500.11 μs |    27,701.055 μs |  1,518.388 μs |  54688.21 KB |
| HashSet                   | StructInts | 1000000 | True     |    92,074.00 μs |    22,918.486 μs |  1,256.240 μs |  58516.56 KB |
| ReadOnlyDictionary        | StructInts | 1000000 | True     |    93,465.42 μs |    24,953.649 μs |  1,367.794 μs |  63059.83 KB |
| LinkedList                | StructInts | 1000000 | True     |    94,579.08 μs |    28,793.805 μs |  1,578.286 μs |  54688.34 KB |
| Dictionary                | StructInts | 1000000 | True     |    96,648.89 μs |    43,997.786 μs |  2,411.667 μs |  63058.48 KB |
| ImmutableSortedSet        | StructInts | 1000000 | True     |   105,094.11 μs |    66,772.569 μs |  3,660.030 μs |  66407.01 KB |
| SortedSet                 | StructInts | 1000000 | True     |   109,118.06 μs |   101,020.466 μs |  5,537.273 μs |  58594.55 KB |
| SortedList                | StructInts | 1000000 | True     |   117,013.70 μs |    72,442.375 μs |  3,970.811 μs |  75753.15 KB |
| FrozenSet                 | StructInts | 1000000 | True     |   206,294.76 μs |   125,324.070 μs |  6,869.435 μs | 157881.09 KB |
| FrozenDictionary          | StructInts | 1000000 | True     |   212,502.02 μs |    37,991.836 μs |  2,082.461 μs | 167306.32 KB |
| &#39;ImmutableList (Sorted)&#39;  | StructInts | 1000000 | True     |   217,075.62 μs |    33,384.496 μs |  1,829.917 μs | 121094.81 KB |
| SortedDictionary          | StructInts | 1000000 | True     |   273,297.77 μs |   180,101.917 μs |  9,871.994 μs |  117746.1 KB |
| ImmutableSortedDictionary | StructInts | 1000000 | True     |   455,724.87 μs |   154,422.714 μs |  8,464.430 μs |  179627.3 KB |
| ImmutableHashSet          | StructInts | 1000000 | True     | 1,376,826.17 μs |   647,504.479 μs | 35,491.905 μs |  93801.93 KB |
| ImmutableDictionary       | StructInts | 1000000 | True     | 1,428,985.53 μs | 1,468,745.785 μs | 80,506.913 μs |  93779.72 KB |
