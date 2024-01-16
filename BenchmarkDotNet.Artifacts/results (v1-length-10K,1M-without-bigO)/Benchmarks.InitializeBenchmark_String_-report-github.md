```

BenchmarkDotNet v0.13.11, Windows 11 (10.0.22631.2861/23H2/2023Update/SunValley3)
AMD Ryzen 7 5800H with Radeon Graphics, 1 CPU, 16 logical and 8 physical cores
.NET SDK 8.0.100
  [Host]   : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                    | DataType | Length  | Sorted   | Mean             | Error           | StdDev         | Allocated    |
|-------------------------- |--------- |-------- |--------- |-----------------:|----------------:|---------------:|-------------:|
| **Array**                     | **String**   | **10000**   | **False**    |         **3.082 μs** |       **1.4452 μs** |      **0.0792 μs** |     **78.15 KB** |
| ReadOnlyCollection        | String   | 10000   | False    |         3.264 μs |       1.9583 μs |      0.1073 μs |     78.17 KB |
| List                      | String   | 10000   | False    |         3.441 μs |       7.3789 μs |      0.4045 μs |     78.18 KB |
| ImmutableArray            | String   | 10000   | False    |         3.509 μs |       4.1891 μs |      0.2296 μs |     78.15 KB |
| LinkedList                | String   | 10000   | False    |       132.915 μs |      71.4812 μs |      3.9181 μs |    468.82 KB |
| ImmutableList             | String   | 10000   | False    |       168.067 μs |      45.9805 μs |      2.5203 μs |     468.8 KB |
| HashSet                   | String   | 10000   | False    |       241.259 μs |      85.9293 μs |      4.7101 μs |    197.49 KB |
| Dictionary                | String   | 10000   | False    |       265.932 μs |      72.5120 μs |      3.9746 μs |    276.41 KB |
| ReadOnlyDictionary        | String   | 10000   | False    |       274.805 μs |     183.2727 μs |     10.0458 μs |    276.45 KB |
| FrozenDictionary          | String   | 10000   | False    |     1,328.777 μs |     360.1661 μs |     19.7419 μs |   1044.19 KB |
| FrozenSet                 | String   | 10000   | False    |     1,432.992 μs |     283.4411 μs |     15.5364 μs |    945.63 KB |
| ImmutableHashSet          | String   | 10000   | False    |     2,544.854 μs |      46.8374 μs |      2.5673 μs |    546.96 KB |
| ImmutableDictionary       | String   | 10000   | False    |     2,632.661 μs |     104.5148 μs |      5.7288 μs |    625.19 KB |
| &#39;List (Sorted)&#39;           | String   | 10000   | False    |     5,106.965 μs |     323.4403 μs |     17.7289 μs |     78.18 KB |
| &#39;Array (Sorted)&#39;          | String   | 10000   | False    |     5,156.343 μs |     456.6855 μs |     25.0325 μs |     78.15 KB |
| &#39;ImmutableArray (Sorted)&#39; | String   | 10000   | False    |     5,192.886 μs |     382.7892 μs |     20.9820 μs |     156.3 KB |
| SortedSet                 | String   | 10000   | False    |     5,684.240 μs |      15.3213 μs |      0.8398 μs |    546.95 KB |
| ImmutableSortedSet        | String   | 10000   | False    |     5,760.166 μs |      63.8999 μs |      3.5026 μs |    546.99 KB |
| &#39;ImmutableList (Sorted)&#39;  | String   | 10000   | False    |     5,806.514 μs |     395.1956 μs |     21.6620 μs |   1015.75 KB |
| SortedList                | String   | 10000   | False    |     6,016.551 μs |     581.2126 μs |     31.8582 μs |    364.46 KB |
| SortedDictionary          | String   | 10000   | False    |     6,019.642 μs |     753.5865 μs |     41.3066 μs |    823.45 KB |
| ImmutableSortedDictionary | String   | 10000   | False    |    11,013.998 μs |     901.2197 μs |     49.3989 μs |   1172.61 KB |
|                           |          |         |          |                  |                 |                |              |
| **Array**                     | **String**   | **10000**   | **True**     |         **3.384 μs** |       **0.6123 μs** |      **0.0336 μs** |     **78.15 KB** |
| List                      | String   | 10000   | True     |         3.390 μs |       6.9443 μs |      0.3806 μs |     78.18 KB |
| ReadOnlyCollection        | String   | 10000   | True     |         3.469 μs |       8.3808 μs |      0.4594 μs |     78.17 KB |
| ImmutableArray            | String   | 10000   | True     |         3.508 μs |       3.7295 μs |      0.2044 μs |     78.15 KB |
| LinkedList                | String   | 10000   | True     |       132.986 μs |      42.0566 μs |      2.3053 μs |    468.82 KB |
| ImmutableList             | String   | 10000   | True     |       175.379 μs |      43.6300 μs |      2.3915 μs |     468.8 KB |
| HashSet                   | String   | 10000   | True     |       283.599 μs |      58.9940 μs |      3.2337 μs |    197.49 KB |
| ReadOnlyDictionary        | String   | 10000   | True     |       332.409 μs |     101.4497 μs |      5.5608 μs |    276.45 KB |
| Dictionary                | String   | 10000   | True     |       334.870 μs |      38.4409 μs |      2.1071 μs |    276.41 KB |
| &#39;ImmutableArray (Sorted)&#39; | String   | 10000   | True     |       434.603 μs |      44.2187 μs |      2.4238 μs |     78.15 KB |
| FrozenDictionary          | String   | 10000   | True     |     1,441.103 μs |     169.0297 μs |      9.2651 μs |   1044.19 KB |
| FrozenSet                 | String   | 10000   | True     |     1,549.158 μs |     104.7570 μs |      5.7421 μs |    945.63 KB |
| ImmutableHashSet          | String   | 10000   | True     |     2,709.511 μs |      80.3507 μs |      4.4043 μs |    546.96 KB |
| ImmutableDictionary       | String   | 10000   | True     |     2,794.094 μs |     310.0152 μs |     16.9930 μs |    625.19 KB |
| &#39;Array (Sorted)&#39;          | String   | 10000   | True     |     3,506.397 μs |     498.9666 μs |     27.3500 μs |     78.15 KB |
| &#39;List (Sorted)&#39;           | String   | 10000   | True     |     3,529.088 μs |      53.9706 μs |      2.9583 μs |     78.18 KB |
| SortedSet                 | String   | 10000   | True     |     4,029.597 μs |     223.0525 μs |     12.2263 μs |    546.95 KB |
| ImmutableSortedSet        | String   | 10000   | True     |     4,155.903 μs |     303.9817 μs |     16.6623 μs |    546.99 KB |
| &#39;ImmutableList (Sorted)&#39;  | String   | 10000   | True     |     4,170.982 μs |     227.3010 μs |     12.4591 μs |   1015.75 KB |
| SortedList                | String   | 10000   | True     |     4,363.556 μs |   1,050.7135 μs |     57.5932 μs |    364.46 KB |
| SortedDictionary          | String   | 10000   | True     |     7,403.146 μs |     354.1086 μs |     19.4099 μs |    823.45 KB |
| ImmutableSortedDictionary | String   | 10000   | True     |    13,859.086 μs |   3,273.3076 μs |    179.4210 μs |   1172.61 KB |
|                           |          |         |          |                  |                 |                |              |
| **Array**                     | **String**   | **1000000** | **False**    |     **1,746.981 μs** |     **139.7051 μs** |      **7.6577 μs** |   **7812.55 KB** |
| ImmutableArray            | String   | 1000000 | False    |     1,772.569 μs |     459.9215 μs |     25.2098 μs |   7812.54 KB |
| List                      | String   | 1000000 | False    |     2,453.267 μs |   7,053.5751 μs |    386.6303 μs |   7812.97 KB |
| ReadOnlyCollection        | String   | 1000000 | False    |     2,472.077 μs |   5,686.9779 μs |    311.7225 μs |   7812.93 KB |
| HashSet                   | String   | 1000000 | False    |    54,896.483 μs |  11,518.4062 μs |    631.3627 μs |  22710.99 KB |
| Dictionary                | String   | 1000000 | False    |    61,127.048 μs |  17,542.0509 μs |    961.5390 μs |  31792.54 KB |
| ReadOnlyDictionary        | String   | 1000000 | False    |    61,574.407 μs |  47,143.1108 μs |  2,584.0730 μs |  31792.55 KB |
| ImmutableList             | String   | 1000000 | False    |    66,808.562 μs |  23,036.6145 μs |  1,262.7146 μs |  46875.28 KB |
| LinkedList                | String   | 1000000 | False    |    84,810.195 μs | 127,968.6701 μs |  7,014.3946 μs |  46875.44 KB |
| FrozenDictionary          | String   | 1000000 | False    |   618,932.333 μs | 344,649.1826 μs | 18,891.3847 μs |  116757.2 KB |
| FrozenSet                 | String   | 1000000 | False    |   625,179.800 μs | 182,285.7280 μs |  9,991.6958 μs |  105720.5 KB |
| ImmutableHashSet          | String   | 1000000 | False    | 1,050,838.967 μs | 278,968.9573 μs | 15,291.2299 μs |  54693.22 KB |
| ImmutableDictionary       | String   | 1000000 | False    | 1,168,491.733 μs | 415,813.9788 μs | 22,792.1673 μs |  62510.23 KB |
| &#39;ImmutableArray (Sorted)&#39; | String   | 1000000 | False    | 1,254,252.433 μs | 324,487.6591 μs | 17,786.2635 μs |  15625.44 KB |
| &#39;Array (Sorted)&#39;          | String   | 1000000 | False    | 1,261,504.233 μs | 576,329.9109 μs | 31,590.5872 μs |   7812.91 KB |
| &#39;List (Sorted)&#39;           | String   | 1000000 | False    | 1,272,296.833 μs | 478,908.4966 μs | 26,250.5907 μs |   7812.95 KB |
| SortedSet                 | String   | 1000000 | False    | 1,412,164.933 μs | 269,920.7288 μs | 14,795.2660 μs |  54687.96 KB |
| ImmutableSortedSet        | String   | 1000000 | False    | 1,421,397.567 μs | 361,533.8070 μs | 19,816.8879 μs |  54687.72 KB |
| &#39;ImmutableList (Sorted)&#39;  | String   | 1000000 | False    | 1,440,594.067 μs | 266,695.2884 μs | 14,618.4687 μs | 101563.09 KB |
| SortedList                | String   | 1000000 | False    | 1,480,264.133 μs |  38,461.1768 μs |  2,108.1869 μs |  40590.23 KB |
| SortedDictionary          | String   | 1000000 | False    | 2,126,734.967 μs | 154,987.8238 μs |  8,495.4056 μs |  86480.41 KB |
| ImmutableSortedDictionary | String   | 1000000 | False    | 3,508,576.867 μs | 651,009.5004 μs | 35,684.0275 μs | 117189.05 KB |
|                           |          |         |          |                  |                 |                |              |
| **Array**                     | **String**   | **1000000** | **True**     |     **2,969.073 μs** |     **541.6576 μs** |     **29.6901 μs** |   **7812.54 KB** |
| ImmutableArray            | String   | 1000000 | True     |     2,974.764 μs |      41.5475 μs |      2.2774 μs |   7812.54 KB |
| List                      | String   | 1000000 | True     |     3,629.443 μs |      72.8493 μs |      3.9931 μs |   7813.17 KB |
| ReadOnlyCollection        | String   | 1000000 | True     |     3,656.048 μs |     941.6703 μs |     51.6161 μs |   7813.17 KB |
| ImmutableList             | String   | 1000000 | True     |    81,748.695 μs |   2,857.6000 μs |    156.6347 μs |  46875.35 KB |
| LinkedList                | String   | 1000000 | True     |    99,761.672 μs |  48,386.5606 μs |  2,652.2307 μs |  46875.43 KB |
| Dictionary                | String   | 1000000 | True     |   126,735.980 μs |  18,979.3715 μs |  1,040.3234 μs |  31792.56 KB |
| ReadOnlyDictionary        | String   | 1000000 | True     |   128,017.127 μs |   9,535.4952 μs |    522.6727 μs |   31792.6 KB |
| HashSet                   | String   | 1000000 | True     |   132,884.167 μs | 316,320.4412 μs | 17,338.5908 μs |  22711.04 KB |
| &#39;ImmutableArray (Sorted)&#39; | String   | 1000000 | True     |   145,644.625 μs |   3,754.8296 μs |    205.8149 μs |   7812.62 KB |
| &#39;Array (Sorted)&#39;          | String   | 1000000 | True     | 1,129,643.800 μs | 232,987.6063 μs | 12,770.8369 μs |   7812.91 KB |
| &#39;List (Sorted)&#39;           | String   | 1000000 | True     | 1,155,808.467 μs | 124,886.7293 μs |  6,845.4630 μs |   7812.66 KB |
| ImmutableHashSet          | String   | 1000000 | True     | 1,201,671.967 μs | 418,921.0586 μs | 22,962.4768 μs |  54692.52 KB |
| FrozenDictionary          | String   | 1000000 | True     | 1,281,507.900 μs | 488,857.8781 μs | 26,795.9499 μs |  116757.2 KB |
| ImmutableDictionary       | String   | 1000000 | True     | 1,283,939.367 μs | 258,452.0170 μs | 14,166.6272 μs |  62507.51 KB |
| SortedSet                 | String   | 1000000 | True     | 1,297,840.200 μs |  62,071.7623 μs |  3,402.3627 μs |  54687.96 KB |
| FrozenSet                 | String   | 1000000 | True     | 1,302,989.867 μs | 266,099.4049 μs | 14,585.8063 μs |  105720.5 KB |
| ImmutableSortedSet        | String   | 1000000 | True     | 1,319,996.033 μs | 307,105.0436 μs | 16,833.4637 μs |  54687.72 KB |
| SortedDictionary          | String   | 1000000 | True     | 1,383,237.633 μs |  82,906.9823 μs |  4,544.4115 μs |  86480.08 KB |
| &#39;ImmutableList (Sorted)&#39;  | String   | 1000000 | True     | 1,413,845.300 μs |  97,149.9951 μs |  5,325.1190 μs | 101563.08 KB |
| SortedList                | String   | 1000000 | True     | 1,436,318.133 μs | 173,547.0921 μs |  9,512.7017 μs |  40590.23 KB |
| ImmutableSortedDictionary | String   | 1000000 | True     | 2,494,466.167 μs | 121,183.0003 μs |  6,642.4492 μs | 117188.78 KB |
