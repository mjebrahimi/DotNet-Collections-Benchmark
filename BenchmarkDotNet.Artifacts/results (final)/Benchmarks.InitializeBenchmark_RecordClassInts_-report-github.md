```

BenchmarkDotNet v0.13.11, Windows 11 (10.0.22631.2861/23H2/2023Update/SunValley3)
AMD Ryzen 7 5800H with Radeon Graphics, 1 CPU, 16 logical and 8 physical cores
.NET SDK 8.0.100
  [Host]   : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                    | DataType        | Length  | Sorted   | Mean             | Error           | StdDev         | Allocated    |
|-------------------------- |---------------- |-------- |--------- |-----------------:|----------------:|---------------:|-------------:|
| **ReadOnlyCollection**        | **RecordClassInts** | **10000**   | **False**    |         **3.233 μs** |       **2.0233 μs** |      **0.1109 μs** |     **78.17 KB** |
| Array                     | RecordClassInts | 10000   | False    |         3.285 μs |       5.4106 μs |      0.2966 μs |     78.15 KB |
| ImmutableArray            | RecordClassInts | 10000   | False    |         3.366 μs |       0.6505 μs |      0.0357 μs |     78.15 KB |
| List                      | RecordClassInts | 10000   | False    |         3.922 μs |       0.7305 μs |      0.0400 μs |     78.18 KB |
| LinkedList                | RecordClassInts | 10000   | False    |       135.016 μs |      21.8643 μs |      1.1985 μs |    468.82 KB |
| ImmutableList             | RecordClassInts | 10000   | False    |       167.254 μs |      27.9156 μs |      1.5301 μs |     468.8 KB |
| HashSet                   | RecordClassInts | 10000   | False    |       248.790 μs |      30.5952 μs |      1.6770 μs |    197.49 KB |
| Dictionary                | RecordClassInts | 10000   | False    |       273.141 μs |      36.8271 μs |      2.0186 μs |    276.41 KB |
| ReadOnlyDictionary        | RecordClassInts | 10000   | False    |       284.909 μs |      32.6952 μs |      1.7921 μs |    276.45 KB |
| FrozenSet                 | RecordClassInts | 10000   | False    |       689.554 μs |     201.6468 μs |     11.0529 μs |    748.11 KB |
| &#39;ImmutableArray (Sorted)&#39; | RecordClassInts | 10000   | False    |       747.232 μs |      51.8346 μs |      2.8412 μs |     156.3 KB |
| &#39;Array (Sorted)&#39;          | RecordClassInts | 10000   | False    |       781.367 μs |      17.5308 μs |      0.9609 μs |     78.15 KB |
| &#39;List (Sorted)&#39;           | RecordClassInts | 10000   | False    |       790.429 μs |     217.3842 μs |     11.9156 μs |     78.18 KB |
| FrozenDictionary          | RecordClassInts | 10000   | False    |       800.424 μs |      65.7930 μs |      3.6063 μs |    914.99 KB |
| SortedSet                 | RecordClassInts | 10000   | False    |       855.998 μs |     124.9156 μs |      6.8470 μs |    546.95 KB |
| ImmutableSortedSet        | RecordClassInts | 10000   | False    |     1,024.883 μs |     206.0122 μs |     11.2922 μs |    546.99 KB |
| SortedList                | RecordClassInts | 10000   | False    |     1,214.383 μs |     115.9596 μs |      6.3561 μs |    364.46 KB |
| &#39;ImmutableList (Sorted)&#39;  | RecordClassInts | 10000   | False    |     1,388.404 μs |     224.9548 μs |     12.3305 μs |   1015.74 KB |
| SortedDictionary          | RecordClassInts | 10000   | False    |     2,270.468 μs |     310.6450 μs |     17.0275 μs |    823.45 KB |
| ImmutableHashSet          | RecordClassInts | 10000   | False    |     2,593.169 μs |      89.7884 μs |      4.9216 μs |    546.96 KB |
| ImmutableDictionary       | RecordClassInts | 10000   | False    |     2,650.795 μs |     239.2093 μs |     13.1119 μs |    625.19 KB |
| ImmutableSortedDictionary | RecordClassInts | 10000   | False    |     3,719.728 μs |     730.9638 μs |     40.0666 μs |    1172.6 KB |
|                           |                 |         |          |                  |                 |                |              |
| **Array**                     | **RecordClassInts** | **10000**   | **True**     |         **3.187 μs** |       **2.8327 μs** |      **0.1553 μs** |     **78.15 KB** |
| ImmutableArray            | RecordClassInts | 10000   | True     |         3.331 μs |       7.1672 μs |      0.3929 μs |     78.15 KB |
| ReadOnlyCollection        | RecordClassInts | 10000   | True     |         3.843 μs |       8.8996 μs |      0.4878 μs |     78.17 KB |
| List                      | RecordClassInts | 10000   | True     |         4.048 μs |       1.6148 μs |      0.0885 μs |     78.18 KB |
| &#39;ImmutableArray (Sorted)&#39; | RecordClassInts | 10000   | True     |        42.374 μs |       4.3584 μs |      0.2389 μs |     78.15 KB |
| LinkedList                | RecordClassInts | 10000   | True     |       129.226 μs |      34.5472 μs |      1.8937 μs |    468.82 KB |
| ImmutableList             | RecordClassInts | 10000   | True     |       169.641 μs |      22.8325 μs |      1.2515 μs |     468.8 KB |
| &#39;List (Sorted)&#39;           | RecordClassInts | 10000   | True     |       271.843 μs |      45.3316 μs |      2.4848 μs |     78.18 KB |
| HashSet                   | RecordClassInts | 10000   | True     |       275.069 μs |     151.5470 μs |      8.3068 μs |    197.49 KB |
| &#39;Array (Sorted)&#39;          | RecordClassInts | 10000   | True     |       275.517 μs |      67.3830 μs |      3.6935 μs |     78.15 KB |
| Dictionary                | RecordClassInts | 10000   | True     |       312.003 μs |     190.0113 μs |     10.4152 μs |    276.41 KB |
| ReadOnlyDictionary        | RecordClassInts | 10000   | True     |       319.528 μs |      95.9935 μs |      5.2617 μs |    276.45 KB |
| SortedSet                 | RecordClassInts | 10000   | True     |       392.659 μs |      35.0966 μs |      1.9238 μs |    546.95 KB |
| ImmutableSortedSet        | RecordClassInts | 10000   | True     |       486.520 μs |      82.1612 μs |      4.5035 μs |    546.98 KB |
| SortedList                | RecordClassInts | 10000   | True     |       681.867 μs |      55.0121 μs |      3.0154 μs |    364.46 KB |
| FrozenSet                 | RecordClassInts | 10000   | True     |       729.071 μs |      57.7670 μs |      3.1664 μs |    748.11 KB |
| FrozenDictionary          | RecordClassInts | 10000   | True     |       839.095 μs |      23.7436 μs |      1.3015 μs |    914.99 KB |
| &#39;ImmutableList (Sorted)&#39;  | RecordClassInts | 10000   | True     |       897.213 μs |     192.8053 μs |     10.5683 μs |   1015.74 KB |
| SortedDictionary          | RecordClassInts | 10000   | True     |     1,958.208 μs |     239.3256 μs |     13.1182 μs |    823.45 KB |
| ImmutableHashSet          | RecordClassInts | 10000   | True     |     2,628.180 μs |      50.0153 μs |      2.7415 μs |    546.96 KB |
| ImmutableDictionary       | RecordClassInts | 10000   | True     |     2,717.978 μs |     208.5487 μs |     11.4313 μs |    625.19 KB |
| ImmutableSortedDictionary | RecordClassInts | 10000   | True     |     3,011.636 μs |     365.3829 μs |     20.0279 μs |    1172.6 KB |
|                           |                 |         |          |                  |                 |                |              |
| **Array**                     | **RecordClassInts** | **1000000** | **False**    |     **1,699.744 μs** |     **432.5740 μs** |     **23.7108 μs** |   **7812.56 KB** |
| ImmutableArray            | RecordClassInts | 1000000 | False    |     1,701.287 μs |     332.4346 μs |     18.2219 μs |   7812.56 KB |
| List                      | RecordClassInts | 1000000 | False    |     1,925.687 μs |     478.9004 μs |     26.2501 μs |    7813.1 KB |
| ReadOnlyCollection        | RecordClassInts | 1000000 | False    |     1,980.965 μs |   1,079.5565 μs |     59.1741 μs |   7813.11 KB |
| HashSet                   | RecordClassInts | 1000000 | False    |    54,258.454 μs |   6,211.0590 μs |    340.4491 μs |  22712.03 KB |
| ReadOnlyDictionary        | RecordClassInts | 1000000 | False    |    60,075.867 μs |  54,391.3809 μs |  2,981.3751 μs |  31792.56 KB |
| Dictionary                | RecordClassInts | 1000000 | False    |    60,767.570 μs |  37,539.8938 μs |  2,057.6883 μs |  31792.49 KB |
| ImmutableList             | RecordClassInts | 1000000 | False    |    71,283.192 μs |  20,123.5615 μs |  1,103.0403 μs |  46875.37 KB |
| LinkedList                | RecordClassInts | 1000000 | False    |    89,269.006 μs |  56,804.6555 μs |  3,113.6548 μs |  46875.44 KB |
| FrozenDictionary          | RecordClassInts | 1000000 | False    |   175,977.083 μs | 279,112.0870 μs | 15,299.0753 μs | 100883.94 KB |
| FrozenSet                 | RecordClassInts | 1000000 | False    |   178,048.511 μs | 145,634.0513 μs |  7,982.6938 μs |  83011.54 KB |
| &#39;Array (Sorted)&#39;          | RecordClassInts | 1000000 | False    |   194,178.900 μs |  41,900.1069 μs |  2,296.6862 μs |   7812.56 KB |
| &#39;List (Sorted)&#39;           | RecordClassInts | 1000000 | False    |   207,235.722 μs |  49,948.6074 μs |  2,737.8517 μs |   7812.59 KB |
| &#39;ImmutableArray (Sorted)&#39; | RecordClassInts | 1000000 | False    |   208,567.000 μs |  34,686.6360 μs |  1,901.2916 μs |  15625.27 KB |
| SortedList                | RecordClassInts | 1000000 | False    |   306,761.850 μs | 150,949.6704 μs |  8,274.0608 μs |  40585.89 KB |
| SortedSet                 | RecordClassInts | 1000000 | False    |   315,208.317 μs |  15,644.5519 μs |    857.5307 μs |  54687.95 KB |
| ImmutableSortedSet        | RecordClassInts | 1000000 | False    |   324,018.883 μs |  67,800.2461 μs |  3,716.3603 μs |  54688.03 KB |
| &#39;ImmutableList (Sorted)&#39;  | RecordClassInts | 1000000 | False    |   373,668.200 μs |  94,593.5375 μs |  5,184.9910 μs | 101563.36 KB |
| ImmutableHashSet          | RecordClassInts | 1000000 | False    | 1,062,482.900 μs | 236,667.8879 μs | 12,972.5655 μs |  54693.65 KB |
| SortedDictionary          | RecordClassInts | 1000000 | False    | 1,093,100.200 μs | 485,922.6310 μs | 26,635.0591 μs |  86481.55 KB |
| ImmutableDictionary       | RecordClassInts | 1000000 | False    | 1,173,974.133 μs | 710,920.8350 μs | 38,967.9699 μs |  62512.82 KB |
| ImmutableSortedDictionary | RecordClassInts | 1000000 | False    | 1,663,175.333 μs | 389,898.9879 μs | 21,371.6792 μs |  117195.7 KB |
|                           |                 |         |          |                  |                 |                |              |
| **ImmutableArray**            | **RecordClassInts** | **1000000** | **True**     |     **3,015.545 μs** |     **226.3319 μs** |     **12.4060 μs** |   **7812.58 KB** |
| Array                     | RecordClassInts | 1000000 | True     |     3,026.706 μs |     203.1757 μs |     11.1367 μs |   7812.58 KB |
| List                      | RecordClassInts | 1000000 | True     |     3,164.733 μs |     164.9079 μs |      9.0392 μs |   7813.24 KB |
| ReadOnlyCollection        | RecordClassInts | 1000000 | True     |     3,186.602 μs |     140.3567 μs |      7.6934 μs |   7813.23 KB |
| &#39;ImmutableArray (Sorted)&#39; | RecordClassInts | 1000000 | True     |    28,134.045 μs |   1,562.6769 μs |     85.6556 μs |   7812.58 KB |
| ImmutableList             | RecordClassInts | 1000000 | True     |    84,200.256 μs |   6,973.8020 μs |    382.2576 μs |  46875.41 KB |
| &#39;List (Sorted)&#39;           | RecordClassInts | 1000000 | True     |    99,407.839 μs |  26,474.6766 μs |  1,451.1664 μs |   7812.67 KB |
| LinkedList                | RecordClassInts | 1000000 | True     |   103,702.533 μs |  42,471.4532 μs |  2,328.0037 μs |   46875.5 KB |
| &#39;Array (Sorted)&#39;          | RecordClassInts | 1000000 | True     |   104,135.887 μs |  13,458.1486 μs |    737.6865 μs |   7812.66 KB |
| ReadOnlyDictionary        | RecordClassInts | 1000000 | True     |   117,655.820 μs |  53,522.8191 μs |  2,933.7663 μs |  31792.59 KB |
| Dictionary                | RecordClassInts | 1000000 | True     |   118,498.060 μs |  12,164.2678 μs |    666.7646 μs |  31792.55 KB |
| HashSet                   | RecordClassInts | 1000000 | True     |   143,134.783 μs | 251,261.2979 μs | 13,772.4796 μs |  22711.04 KB |
| SortedSet                 | RecordClassInts | 1000000 | True     |   216,421.822 μs |  57,501.0759 μs |  3,151.8280 μs |  54690.08 KB |
| ImmutableSortedSet        | RecordClassInts | 1000000 | True     |   237,027.683 μs |  51,250.4331 μs |  2,809.2092 μs |  54688.15 KB |
| FrozenDictionary          | RecordClassInts | 1000000 | True     |   266,822.083 μs |  97,753.9983 μs |  5,358.2265 μs | 100884.43 KB |
| SortedList                | RecordClassInts | 1000000 | True     |   276,128.750 μs |  23,312.2282 μs |  1,277.8219 μs |  40585.89 KB |
| FrozenSet                 | RecordClassInts | 1000000 | True     |   313,587.333 μs | 193,974.8993 μs | 10,632.4188 μs |  83011.55 KB |
| &#39;ImmutableList (Sorted)&#39;  | RecordClassInts | 1000000 | True     |   388,608.967 μs |  95,914.1216 μs |  5,257.3767 μs | 101563.34 KB |
| SortedDictionary          | RecordClassInts | 1000000 | True     |   541,675.867 μs |  42,027.2340 μs |  2,303.6545 μs |  86480.81 KB |
| ImmutableSortedDictionary | RecordClassInts | 1000000 | True     |   652,564.900 μs | 224,292.8456 μs | 12,294.2477 μs | 117188.76 KB |
| ImmutableHashSet          | RecordClassInts | 1000000 | True     | 1,238,479.167 μs | 509,550.8916 μs | 27,930.2038 μs |  54695.41 KB |
| ImmutableDictionary       | RecordClassInts | 1000000 | True     | 1,276,222.100 μs | 487,972.3774 μs | 26,747.4126 μs |  62511.77 KB |
