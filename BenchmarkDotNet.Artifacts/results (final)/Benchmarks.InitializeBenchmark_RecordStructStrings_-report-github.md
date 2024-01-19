```

BenchmarkDotNet v0.13.11, Windows 11 (10.0.22631.2861/23H2/2023Update/SunValley3)
AMD Ryzen 7 5800H with Radeon Graphics, 1 CPU, 16 logical and 8 physical cores
.NET SDK 8.0.100
  [Host]   : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                    | DataType            | Length  | Sorted   | Mean           | Error         | StdDev       | Allocated    |
|-------------------------- |-------------------- |-------- |--------- |---------------:|--------------:|-------------:|-------------:|
| **Array**                     | **RecordStructStrings** | **10000**   | **False**    |       **109.1 μs** |       **9.29 μs** |      **0.51 μs** |    **234.42 KB** |
| ReadOnlyCollection        | RecordStructStrings | 10000   | False    |       109.8 μs |       9.23 μs |      0.51 μs |    234.45 KB |
| ImmutableArray            | RecordStructStrings | 10000   | False    |       111.2 μs |      11.88 μs |      0.65 μs |    234.42 KB |
| List                      | RecordStructStrings | 10000   | False    |       111.2 μs |      10.19 μs |      0.56 μs |    234.45 KB |
| LinkedList                | RecordStructStrings | 10000   | False    |       157.4 μs |      28.76 μs |      1.58 μs |    625.07 KB |
| ImmutableList             | RecordStructStrings | 10000   | False    |       210.7 μs |      13.17 μs |      0.72 μs |    625.05 KB |
| HashSet                   | RecordStructStrings | 10000   | False    |       598.2 μs |     323.13 μs |     17.71 μs |    355.36 KB |
| Dictionary                | RecordStructStrings | 10000   | False    |       638.9 μs |     274.32 μs |     15.04 μs |    434.28 KB |
| ReadOnlyDictionary        | RecordStructStrings | 10000   | False    |       674.7 μs |     618.83 μs |     33.92 μs |    434.32 KB |
| FrozenSet                 | RecordStructStrings | 10000   | False    |     1,231.4 μs |     103.98 μs |      5.70 μs |   1219.54 KB |
| FrozenDictionary          | RecordStructStrings | 10000   | False    |     1,257.2 μs |     168.31 μs |      9.23 μs |   1387.48 KB |
| ImmutableHashSet          | RecordStructStrings | 10000   | False    |     2,697.5 μs |     643.19 μs |     35.26 μs |    703.21 KB |
| ImmutableDictionary       | RecordStructStrings | 10000   | False    |     2,891.3 μs |     104.80 μs |      5.74 μs |    781.46 KB |
| &#39;List (Sorted)&#39;           | RecordStructStrings | 10000   | False    |     5,895.5 μs |     561.16 μs |     30.76 μs |    234.46 KB |
| &#39;Array (Sorted)&#39;          | RecordStructStrings | 10000   | False    |     5,979.4 μs |     170.51 μs |      9.35 μs |    234.42 KB |
| &#39;ImmutableArray (Sorted)&#39; | RecordStructStrings | 10000   | False    |     6,083.9 μs |     884.51 μs |     48.48 μs |    468.85 KB |
| SortedDictionary          | RecordStructStrings | 10000   | False    |     6,330.0 μs |     886.22 μs |     48.58 μs |   1137.59 KB |
| ImmutableSortedSet        | RecordStructStrings | 10000   | False    |     6,563.3 μs |     678.13 μs |     37.17 μs |    859.51 KB |
| SortedSet                 | RecordStructStrings | 10000   | False    |     6,691.2 μs |     249.05 μs |     13.65 μs |    859.47 KB |
| &#39;ImmutableList (Sorted)&#39;  | RecordStructStrings | 10000   | False    |     6,701.1 μs |     766.20 μs |     42.00 μs |   1484.52 KB |
| SortedList                | RecordStructStrings | 10000   | False    |     7,527.8 μs |   1,170.89 μs |     64.18 μs |    678.61 KB |
| ImmutableSortedDictionary | RecordStructStrings | 10000   | False    |    11,672.2 μs |   2,411.24 μs |    132.17 μs |   2422.64 KB |
|                           |                     |         |          |                |               |              |              |
| **ImmutableArray**            | **RecordStructStrings** | **10000**   | **True**     |       **108.5 μs** |      **12.00 μs** |      **0.66 μs** |    **234.42 KB** |
| Array                     | RecordStructStrings | 10000   | True     |       109.4 μs |       4.35 μs |      0.24 μs |    234.42 KB |
| ReadOnlyCollection        | RecordStructStrings | 10000   | True     |       110.5 μs |       7.56 μs |      0.41 μs |    234.45 KB |
| List                      | RecordStructStrings | 10000   | True     |       111.0 μs |      15.99 μs |      0.88 μs |    234.45 KB |
| LinkedList                | RecordStructStrings | 10000   | True     |       155.6 μs |      71.16 μs |      3.90 μs |    625.07 KB |
| ImmutableList             | RecordStructStrings | 10000   | True     |       210.5 μs |      15.18 μs |      0.83 μs |    625.05 KB |
| &#39;ImmutableArray (Sorted)&#39; | RecordStructStrings | 10000   | True     |       558.7 μs |      46.04 μs |      2.52 μs |    234.42 KB |
| HashSet                   | RecordStructStrings | 10000   | True     |       698.1 μs |     192.64 μs |     10.56 μs |    355.36 KB |
| Dictionary                | RecordStructStrings | 10000   | True     |       782.3 μs |      46.56 μs |      2.55 μs |    434.28 KB |
| ReadOnlyDictionary        | RecordStructStrings | 10000   | True     |       787.1 μs |     192.41 μs |     10.55 μs |    434.32 KB |
| FrozenSet                 | RecordStructStrings | 10000   | True     |     1,470.0 μs |      72.77 μs |      3.99 μs |   1219.77 KB |
| FrozenDictionary          | RecordStructStrings | 10000   | True     |     1,511.2 μs |     109.91 μs |      6.02 μs |   1385.44 KB |
| ImmutableHashSet          | RecordStructStrings | 10000   | True     |     2,820.3 μs |     127.65 μs |      7.00 μs |    703.21 KB |
| ImmutableDictionary       | RecordStructStrings | 10000   | True     |     3,143.3 μs |     391.13 μs |     21.44 μs |    781.46 KB |
| &#39;Array (Sorted)&#39;          | RecordStructStrings | 10000   | True     |     3,723.7 μs |     415.31 μs |     22.76 μs |    234.42 KB |
| &#39;List (Sorted)&#39;           | RecordStructStrings | 10000   | True     |     3,816.7 μs |      52.21 μs |      2.86 μs |    234.45 KB |
| SortedSet                 | RecordStructStrings | 10000   | True     |     4,368.5 μs |     176.10 μs |      9.65 μs |    859.47 KB |
| ImmutableSortedSet        | RecordStructStrings | 10000   | True     |     4,477.8 μs |     459.51 μs |     25.19 μs |    859.51 KB |
| &#39;ImmutableList (Sorted)&#39;  | RecordStructStrings | 10000   | True     |     4,512.7 μs |     509.85 μs |     27.95 μs |   1484.52 KB |
| SortedList                | RecordStructStrings | 10000   | True     |     5,151.8 μs |     884.04 μs |     48.46 μs |    678.61 KB |
| SortedDictionary          | RecordStructStrings | 10000   | True     |     7,489.4 μs |     582.00 μs |     31.90 μs |   1137.59 KB |
| ImmutableSortedDictionary | RecordStructStrings | 10000   | True     |    13,689.5 μs |   3,153.91 μs |    172.88 μs |   2422.64 KB |
|                           |                     |         |          |                |               |              |              |
| **List**                      | **RecordStructStrings** | **1000000** | **False**    |     **9,259.2 μs** |   **1,292.89 μs** |     **70.87 μs** |  **23437.62 KB** |
| ReadOnlyCollection        | RecordStructStrings | 1000000 | False    |     9,307.7 μs |     979.57 μs |     53.69 μs |  23437.61 KB |
| ImmutableArray            | RecordStructStrings | 1000000 | False    |     9,444.1 μs |     566.46 μs |     31.05 μs |  23437.59 KB |
| Array                     | RecordStructStrings | 1000000 | False    |     9,510.5 μs |     611.69 μs |     33.53 μs |  23437.59 KB |
| ImmutableList             | RecordStructStrings | 1000000 | False    |    82,798.1 μs |  10,955.30 μs |    600.50 μs |  62500.23 KB |
| LinkedList                | RecordStructStrings | 1000000 | False    |    82,806.8 μs |  45,501.07 μs |  2,494.07 μs |  62500.26 KB |
| HashSet                   | RecordStructStrings | 1000000 | False    |   125,852.4 μs |  18,131.15 μs |    993.83 μs |  40876.04 KB |
| ReadOnlyDictionary        | RecordStructStrings | 1000000 | False    |   131,012.5 μs |  13,871.31 μs |    760.33 μs |  49959.55 KB |
| Dictionary                | RecordStructStrings | 1000000 | False    |   134,952.6 μs |  44,339.87 μs |  2,430.42 μs |  49959.52 KB |
| FrozenSet                 | RecordStructStrings | 1000000 | False    |   274,479.2 μs |  79,764.26 μs |  4,372.15 μs | 132428.42 KB |
| FrozenDictionary          | RecordStructStrings | 1000000 | False    |   283,767.8 μs |  75,920.75 μs |  4,161.47 μs | 150301.13 KB |
| ImmutableHashSet          | RecordStructStrings | 1000000 | False    | 1,145,315.5 μs | 328,191.79 μs | 17,989.30 μs |  70321.09 KB |
| ImmutableDictionary       | RecordStructStrings | 1000000 | False    | 1,227,295.7 μs | 234,140.70 μs | 12,834.04 μs |  78133.21 KB |
| &#39;Array (Sorted)&#39;          | RecordStructStrings | 1000000 | False    | 1,507,109.5 μs |  42,355.67 μs |  2,321.66 μs |  23437.91 KB |
| &#39;ImmutableArray (Sorted)&#39; | RecordStructStrings | 1000000 | False    | 1,508,957.0 μs | 154,047.80 μs |  8,443.88 μs |  46875.44 KB |
| &#39;List (Sorted)&#39;           | RecordStructStrings | 1000000 | False    | 1,551,474.3 μs | 729,010.11 μs | 39,959.50 μs |  23437.95 KB |
| &#39;ImmutableList (Sorted)&#39;  | RecordStructStrings | 1000000 | False    | 1,657,942.0 μs | 159,922.62 μs |  8,765.90 μs | 148437.68 KB |
| ImmutableSortedSet        | RecordStructStrings | 1000000 | False    | 1,706,557.2 μs | 230,089.73 μs | 12,611.99 μs |     85938 KB |
| SortedSet                 | RecordStructStrings | 1000000 | False    | 1,724,518.4 μs | 163,221.95 μs |  8,946.75 μs |  85937.68 KB |
| SortedList                | RecordStructStrings | 1000000 | False    | 1,826,587.8 μs | 540,373.79 μs | 29,619.71 μs |  74373.95 KB |
| SortedDictionary          | RecordStructStrings | 1000000 | False    | 2,305,865.1 μs | 365,597.05 μs | 20,039.61 μs | 120272.13 KB |
| ImmutableSortedDictionary | RecordStructStrings | 1000000 | False    | 4,077,824.1 μs | 463,964.17 μs | 25,431.44 μs | 242110.66 KB |
|                           |                     |         |          |                |               |              |              |
| **Array**                     | **RecordStructStrings** | **1000000** | **True**     |    **16,592.8 μs** |   **1,023.57 μs** |     **56.11 μs** |   **23437.6 KB** |
| ImmutableArray            | RecordStructStrings | 1000000 | True     |    16,688.3 μs |   3,034.81 μs |    166.35 μs |   23437.6 KB |
| List                      | RecordStructStrings | 1000000 | True     |    16,801.9 μs |   1,826.15 μs |    100.10 μs |  23437.63 KB |
| ReadOnlyCollection        | RecordStructStrings | 1000000 | True     |    16,802.8 μs |   1,938.50 μs |    106.26 μs |  23437.62 KB |
| ImmutableList             | RecordStructStrings | 1000000 | True     |    98,327.3 μs |  13,109.25 μs |    718.56 μs |  62500.24 KB |
| LinkedList                | RecordStructStrings | 1000000 | True     |   104,024.1 μs |  46,652.31 μs |  2,557.17 μs |  62500.31 KB |
| &#39;ImmutableArray (Sorted)&#39; | RecordStructStrings | 1000000 | True     |   156,884.1 μs |  13,461.55 μs |    737.87 μs |  23437.62 KB |
| HashSet                   | RecordStructStrings | 1000000 | True     |   190,732.3 μs |  41,452.44 μs |  2,272.15 μs |  40875.99 KB |
| ReadOnlyDictionary        | RecordStructStrings | 1000000 | True     |   269,814.9 μs |  31,711.56 μs |  1,738.22 μs |  49959.57 KB |
| Dictionary                | RecordStructStrings | 1000000 | True     |   281,131.2 μs | 119,976.50 μs |  6,576.32 μs |  49959.53 KB |
| FrozenSet                 | RecordStructStrings | 1000000 | True     |   435,732.6 μs | 128,467.27 μs |  7,041.72 μs | 132428.59 KB |
| FrozenDictionary          | RecordStructStrings | 1000000 | True     |   519,579.4 μs | 219,505.30 μs | 12,031.83 μs | 150301.16 KB |
| &#39;List (Sorted)&#39;           | RecordStructStrings | 1000000 | True     | 1,227,750.5 μs |  10,215.12 μs |    559.93 μs |  23437.95 KB |
| &#39;Array (Sorted)&#39;          | RecordStructStrings | 1000000 | True     | 1,239,819.4 μs | 269,185.78 μs | 14,754.98 μs |  23437.91 KB |
| ImmutableHashSet          | RecordStructStrings | 1000000 | True     | 1,263,848.3 μs | 171,521.93 μs |  9,401.70 μs |  70318.62 KB |
| ImmutableDictionary       | RecordStructStrings | 1000000 | True     | 1,360,223.1 μs | 145,305.83 μs |  7,964.70 μs |  78133.12 KB |
| &#39;ImmutableList (Sorted)&#39;  | RecordStructStrings | 1000000 | True     | 1,381,403.5 μs | 143,336.52 μs |  7,856.76 μs | 148438.01 KB |
| SortedSet                 | RecordStructStrings | 1000000 | True     | 1,414,749.6 μs | 111,430.07 μs |  6,107.86 μs |  85937.96 KB |
| ImmutableSortedSet        | RecordStructStrings | 1000000 | True     | 1,453,673.0 μs | 124,924.82 μs |  6,847.55 μs |     85938 KB |
| SortedDictionary          | RecordStructStrings | 1000000 | True     | 1,476,652.0 μs |  50,142.82 μs |  2,748.50 μs | 120272.13 KB |
| SortedList                | RecordStructStrings | 1000000 | True     | 1,655,944.9 μs | 216,528.62 μs | 11,868.66 μs |  74373.95 KB |
| ImmutableSortedDictionary | RecordStructStrings | 1000000 | True     | 2,537,376.7 μs | 120,931.49 μs |  6,628.66 μs | 242110.66 KB |
