```

BenchmarkDotNet v0.13.11, Windows 11 (10.0.22631.2861/23H2/2023Update/SunValley3)
AMD Ryzen 7 5800H with Radeon Graphics, 1 CPU, 16 logical and 8 physical cores
.NET SDK 8.0.100
  [Host]   : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                    | DataType      | Length  | Sorted   | Mean           | Error           | StdDev       | Allocated    |
|-------------------------- |-------------- |-------- |--------- |---------------:|----------------:|-------------:|-------------:|
| **ImmutableArray**            | **StructStrings** | **10000**   | **False**    |       **107.2 μs** |        **21.39 μs** |      **1.17 μs** |    **234.42 KB** |
| List                      | StructStrings | 10000   | False    |       109.9 μs |         6.47 μs |      0.35 μs |    234.45 KB |
| ReadOnlyCollection        | StructStrings | 10000   | False    |       110.8 μs |         7.93 μs |      0.43 μs |    234.45 KB |
| Array                     | StructStrings | 10000   | False    |       111.9 μs |        22.23 μs |      1.22 μs |    234.42 KB |
| LinkedList                | StructStrings | 10000   | False    |       158.3 μs |         4.43 μs |      0.24 μs |    625.07 KB |
| ImmutableList             | StructStrings | 10000   | False    |       212.7 μs |        41.07 μs |      2.25 μs |    625.05 KB |
| HashSet                   | StructStrings | 10000   | False    |       948.9 μs |       216.89 μs |     11.89 μs |    745.99 KB |
| ReadOnlyDictionary        | StructStrings | 10000   | False    |     1,018.5 μs |       310.46 μs |     17.02 μs |    824.95 KB |
| Dictionary                | StructStrings | 10000   | False    |     1,023.8 μs |       109.53 μs |      6.00 μs |    824.91 KB |
| FrozenSet                 | StructStrings | 10000   | False    |     2,043.1 μs |       246.52 μs |     13.51 μs |   1999.95 KB |
| FrozenDictionary          | StructStrings | 10000   | False    |     2,052.6 μs |       189.97 μs |     10.41 μs |   2166.84 KB |
| ImmutableHashSet          | StructStrings | 10000   | False    |     3,093.5 μs |       453.25 μs |     24.84 μs |   1093.83 KB |
| ImmutableDictionary       | StructStrings | 10000   | False    |     3,957.3 μs |       149.76 μs |      8.21 μs |   1172.08 KB |
| &#39;Array (Sorted)&#39;          | StructStrings | 10000   | False    |     5,916.1 μs |       699.48 μs |     38.34 μs |    234.42 KB |
| &#39;List (Sorted)&#39;           | StructStrings | 10000   | False    |     6,068.8 μs |     1,124.87 μs |     61.66 μs |    234.46 KB |
| &#39;ImmutableArray (Sorted)&#39; | StructStrings | 10000   | False    |     6,239.0 μs |       552.32 μs |     30.27 μs |    468.85 KB |
| SortedDictionary          | StructStrings | 10000   | False    |     6,509.8 μs |       462.50 μs |     25.35 μs |   1528.21 KB |
| SortedSet                 | StructStrings | 10000   | False    |     6,563.2 μs |       116.79 μs |      6.40 μs |    859.47 KB |
| &#39;ImmutableList (Sorted)&#39;  | StructStrings | 10000   | False    |     6,757.5 μs |       442.53 μs |     24.26 μs |   1484.52 KB |
| ImmutableSortedSet        | StructStrings | 10000   | False    |     7,287.7 μs |       491.17 μs |     26.92 μs |    859.51 KB |
| SortedList                | StructStrings | 10000   | False    |     7,631.9 μs |       791.79 μs |     43.40 μs |   1069.23 KB |
| ImmutableSortedDictionary | StructStrings | 10000   | False    |    11,453.6 μs |     1,818.30 μs |     99.67 μs |   2422.64 KB |
|                           |               |         |          |                |                 |              |              |
| **ImmutableArray**            | **StructStrings** | **10000**   | **True**     |       **108.4 μs** |        **18.62 μs** |      **1.02 μs** |    **234.42 KB** |
| List                      | StructStrings | 10000   | True     |       110.0 μs |         7.01 μs |      0.38 μs |    234.45 KB |
| ReadOnlyCollection        | StructStrings | 10000   | True     |       110.3 μs |        12.24 μs |      0.67 μs |    234.45 KB |
| Array                     | StructStrings | 10000   | True     |       110.6 μs |        10.55 μs |      0.58 μs |    234.42 KB |
| LinkedList                | StructStrings | 10000   | True     |       155.2 μs |         9.46 μs |      0.52 μs |    625.07 KB |
| ImmutableList             | StructStrings | 10000   | True     |       213.8 μs |        18.83 μs |      1.03 μs |    625.05 KB |
| &#39;ImmutableArray (Sorted)&#39; | StructStrings | 10000   | True     |       552.4 μs |        44.75 μs |      2.45 μs |    234.42 KB |
| HashSet                   | StructStrings | 10000   | True     |     1,024.8 μs |       505.45 μs |     27.71 μs |    745.99 KB |
| ReadOnlyDictionary        | StructStrings | 10000   | True     |     1,041.7 μs |       131.24 μs |      7.19 μs |    824.95 KB |
| Dictionary                | StructStrings | 10000   | True     |     1,044.8 μs |        84.90 μs |      4.65 μs |    824.91 KB |
| FrozenSet                 | StructStrings | 10000   | True     |     2,089.5 μs |       108.72 μs |      5.96 μs |   1999.93 KB |
| FrozenDictionary          | StructStrings | 10000   | True     |     2,094.7 μs |       337.07 μs |     18.48 μs |   2166.79 KB |
| ImmutableHashSet          | StructStrings | 10000   | True     |     3,264.9 μs |       440.68 μs |     24.16 μs |   1093.83 KB |
| &#39;List (Sorted)&#39;           | StructStrings | 10000   | True     |     3,702.6 μs |       458.48 μs |     25.13 μs |    234.45 KB |
| &#39;Array (Sorted)&#39;          | StructStrings | 10000   | True     |     3,726.6 μs |       360.94 μs |     19.78 μs |    234.42 KB |
| ImmutableDictionary       | StructStrings | 10000   | True     |     4,178.5 μs |       451.80 μs |     24.76 μs |   1172.08 KB |
| SortedSet                 | StructStrings | 10000   | True     |     4,392.3 μs |       755.31 μs |     41.40 μs |    859.47 KB |
| ImmutableSortedSet        | StructStrings | 10000   | True     |     4,429.0 μs |       201.89 μs |     11.07 μs |    859.51 KB |
| &#39;ImmutableList (Sorted)&#39;  | StructStrings | 10000   | True     |     4,647.5 μs |     1,156.65 μs |     63.40 μs |   1484.52 KB |
| SortedList                | StructStrings | 10000   | True     |     5,475.3 μs |       533.84 μs |     29.26 μs |   1069.23 KB |
| SortedDictionary          | StructStrings | 10000   | True     |     7,726.8 μs |     2,040.07 μs |    111.82 μs |   1528.21 KB |
| ImmutableSortedDictionary | StructStrings | 10000   | True     |    13,620.9 μs |     2,916.70 μs |    159.87 μs |   2422.64 KB |
|                           |               |         |          |                |                 |              |              |
| **Array**                     | **StructStrings** | **1000000** | **False**    |     **9,537.0 μs** |     **1,348.43 μs** |     **73.91 μs** |  **23437.59 KB** |
| ReadOnlyCollection        | StructStrings | 1000000 | False    |     9,988.4 μs |     1,479.96 μs |     81.12 μs |  23437.61 KB |
| List                      | StructStrings | 1000000 | False    |    10,443.0 μs |       356.79 μs |     19.56 μs |  23437.62 KB |
| ImmutableArray            | StructStrings | 1000000 | False    |    10,483.7 μs |     2,358.57 μs |    129.28 μs |  23437.59 KB |
| LinkedList                | StructStrings | 1000000 | False    |    83,882.4 μs |    42,193.06 μs |  2,312.74 μs |  62500.32 KB |
| ImmutableList             | StructStrings | 1000000 | False    |    86,172.9 μs |    20,428.01 μs |  1,119.73 μs |  62500.18 KB |
| HashSet                   | StructStrings | 1000000 | False    |   166,453.3 μs |    15,051.16 μs |    825.00 μs |  79957.29 KB |
| ReadOnlyDictionary        | StructStrings | 1000000 | False    |   169,061.4 μs |    47,946.58 μs |  2,628.11 μs |  89039.28 KB |
| Dictionary                | StructStrings | 1000000 | False    |   169,128.5 μs |    48,220.19 μs |  2,643.11 μs |  89040.86 KB |
| FrozenDictionary          | StructStrings | 1000000 | False    |   336,933.9 μs |   151,446.42 μs |  8,301.29 μs |  228443.2 KB |
| FrozenSet                 | StructStrings | 1000000 | False    |   352,984.7 μs |    52,695.21 μs |  2,888.40 μs | 210573.43 KB |
| &#39;List (Sorted)&#39;           | StructStrings | 1000000 | False    | 1,510,138.4 μs |   213,283.79 μs | 11,690.80 μs |  23437.95 KB |
| ImmutableHashSet          | StructStrings | 1000000 | False    | 1,510,336.7 μs |   561,319.12 μs | 30,767.80 μs |  109426.2 KB |
| &#39;ImmutableArray (Sorted)&#39; | StructStrings | 1000000 | False    | 1,537,310.0 μs |   548,591.70 μs | 30,070.16 μs |  46875.44 KB |
| &#39;Array (Sorted)&#39;          | StructStrings | 1000000 | False    | 1,561,056.7 μs | 1,375,566.68 μs | 75,399.45 μs |  23437.91 KB |
| ImmutableDictionary       | StructStrings | 1000000 | False    | 1,605,377.8 μs |   301,974.25 μs | 16,552.23 μs | 117223.37 KB |
| &#39;ImmutableList (Sorted)&#39;  | StructStrings | 1000000 | False    | 1,698,900.6 μs |   193,759.21 μs | 10,620.60 μs | 148437.73 KB |
| SortedSet                 | StructStrings | 1000000 | False    | 1,702,656.9 μs |   375,073.95 μs | 20,559.07 μs |  85937.96 KB |
| ImmutableSortedSet        | StructStrings | 1000000 | False    | 1,749,357.3 μs |   528,976.55 μs | 28,994.99 μs |     85938 KB |
| SortedList                | StructStrings | 1000000 | False    | 1,878,580.4 μs |    86,719.28 μs |  4,753.38 μs | 113453.33 KB |
| SortedDictionary          | StructStrings | 1000000 | False    | 2,303,442.4 μs |   277,885.52 μs | 15,231.84 μs | 159351.57 KB |
| ImmutableSortedDictionary | StructStrings | 1000000 | False    | 4,135,377.6 μs | 1,334,550.56 μs | 73,151.22 μs | 242110.66 KB |
|                           |               |         |          |                |                 |              |              |
| **Array**                     | **StructStrings** | **1000000** | **True**     |    **16,601.8 μs** |     **2,837.73 μs** |    **155.55 μs** |   **23437.6 KB** |
| ReadOnlyCollection        | StructStrings | 1000000 | True     |    16,916.9 μs |     4,886.35 μs |    267.84 μs |  23437.62 KB |
| List                      | StructStrings | 1000000 | True     |    17,928.5 μs |     5,204.23 μs |    285.26 μs |  23437.63 KB |
| ImmutableArray            | StructStrings | 1000000 | True     |    18,501.8 μs |     6,120.80 μs |    335.50 μs |   23437.6 KB |
| ImmutableList             | StructStrings | 1000000 | True     |   102,191.5 μs |    44,565.18 μs |  2,442.77 μs |  62500.24 KB |
| LinkedList                | StructStrings | 1000000 | True     |   105,297.4 μs |     4,372.18 μs |    239.65 μs |  62500.32 KB |
| &#39;ImmutableArray (Sorted)&#39; | StructStrings | 1000000 | True     |   156,783.3 μs |     2,086.43 μs |    114.36 μs |  23437.62 KB |
| ReadOnlyDictionary        | StructStrings | 1000000 | True     |   278,656.2 μs |    17,277.78 μs |    947.05 μs |  89040.11 KB |
| Dictionary                | StructStrings | 1000000 | True     |   281,732.3 μs |   108,332.07 μs |  5,938.05 μs |  89039.55 KB |
| HashSet                   | StructStrings | 1000000 | True     |   282,177.2 μs |    98,231.69 μs |  5,384.41 μs |  79955.34 KB |
| FrozenDictionary          | StructStrings | 1000000 | True     |   561,942.3 μs |   178,399.93 μs |  9,778.70 μs | 228444.45 KB |
| FrozenSet                 | StructStrings | 1000000 | True     |   566,892.6 μs |    87,510.61 μs |  4,796.75 μs | 210569.13 KB |
| &#39;List (Sorted)&#39;           | StructStrings | 1000000 | True     | 1,213,193.5 μs |   261,992.30 μs | 14,360.68 μs |  23437.95 KB |
| &#39;Array (Sorted)&#39;          | StructStrings | 1000000 | True     | 1,222,815.8 μs |   142,337.66 μs |  7,802.01 μs |  23437.91 KB |
| &#39;ImmutableList (Sorted)&#39;  | StructStrings | 1000000 | True     | 1,470,650.3 μs | 1,183,743.79 μs | 64,884.99 μs | 148438.01 KB |
| SortedDictionary          | StructStrings | 1000000 | True     | 1,487,667.4 μs |    50,399.61 μs |  2,762.57 μs | 159352.07 KB |
| ImmutableSortedSet        | StructStrings | 1000000 | True     | 1,489,399.2 μs |   506,247.59 μs | 27,749.14 μs |  85937.72 KB |
| SortedSet                 | StructStrings | 1000000 | True     | 1,508,580.2 μs | 1,000,212.82 μs | 54,825.04 μs |  85937.68 KB |
| ImmutableHashSet          | StructStrings | 1000000 | True     | 1,630,119.1 μs |   962,419.32 μs | 52,753.45 μs | 109421.66 KB |
| SortedList                | StructStrings | 1000000 | True     | 1,676,060.0 μs |   731,207.19 μs | 40,079.93 μs | 113455.11 KB |
| ImmutableDictionary       | StructStrings | 1000000 | True     | 1,732,876.9 μs |   458,950.67 μs | 25,156.63 μs | 117220.78 KB |
| ImmutableSortedDictionary | StructStrings | 1000000 | True     | 2,430,546.8 μs |   193,499.32 μs | 10,606.35 μs | 242110.38 KB |
