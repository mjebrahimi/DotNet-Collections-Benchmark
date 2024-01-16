```

BenchmarkDotNet v0.13.11, Windows 11 (10.0.22631.2861/23H2/2023Update/SunValley3)
AMD Ryzen 7 5800H with Radeon Graphics, 1 CPU, 16 logical and 8 physical cores
.NET SDK 8.0.100
  [Host]   : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                    | DataType           | Length  | Sorted   | Mean             | Error            | StdDev         | Allocated    |
|-------------------------- |------------------- |-------- |--------- |-----------------:|-----------------:|---------------:|-------------:|
| **Array**                     | **RecordClassStrings** | **10000**   | **False**    |         **3.349 μs** |         **6.508 μs** |      **0.3567 μs** |     **78.15 KB** |
| ImmutableArray            | RecordClassStrings | 10000   | False    |         3.350 μs |         5.654 μs |      0.3099 μs |     78.15 KB |
| ReadOnlyCollection        | RecordClassStrings | 10000   | False    |         3.355 μs |         8.361 μs |      0.4583 μs |     78.17 KB |
| List                      | RecordClassStrings | 10000   | False    |         3.877 μs |         3.190 μs |      0.1749 μs |     78.18 KB |
| LinkedList                | RecordClassStrings | 10000   | False    |       132.172 μs |        38.099 μs |      2.0883 μs |    468.82 KB |
| ImmutableList             | RecordClassStrings | 10000   | False    |       171.943 μs |        82.880 μs |      4.5430 μs |     468.8 KB |
| HashSet                   | RecordClassStrings | 10000   | False    |       493.711 μs |       265.995 μs |     14.5801 μs |    197.49 KB |
| Dictionary                | RecordClassStrings | 10000   | False    |       527.394 μs |        37.806 μs |      2.0723 μs |    276.41 KB |
| ReadOnlyDictionary        | RecordClassStrings | 10000   | False    |       566.916 μs |        79.996 μs |      4.3849 μs |    276.45 KB |
| FrozenSet                 | RecordClassStrings | 10000   | False    |     1,205.622 μs |       238.893 μs |     13.0945 μs |    748.11 KB |
| FrozenDictionary          | RecordClassStrings | 10000   | False    |     1,323.209 μs |       288.466 μs |     15.8118 μs |    914.99 KB |
| ImmutableHashSet          | RecordClassStrings | 10000   | False    |     2,805.189 μs |       270.989 μs |     14.8538 μs |    546.96 KB |
| ImmutableDictionary       | RecordClassStrings | 10000   | False    |     2,898.711 μs |       126.108 μs |      6.9124 μs |    625.19 KB |
| &#39;ImmutableArray (Sorted)&#39; | RecordClassStrings | 10000   | False    |     5,707.202 μs |       557.591 μs |     30.5634 μs |     156.3 KB |
| &#39;Array (Sorted)&#39;          | RecordClassStrings | 10000   | False    |     5,710.599 μs |        28.867 μs |      1.5823 μs |     78.15 KB |
| &#39;List (Sorted)&#39;           | RecordClassStrings | 10000   | False    |     5,731.839 μs |       482.524 μs |     26.4488 μs |     78.18 KB |
| SortedSet                 | RecordClassStrings | 10000   | False    |     6,403.660 μs |       423.738 μs |     23.2265 μs |    546.95 KB |
| ImmutableSortedSet        | RecordClassStrings | 10000   | False    |     6,496.165 μs |       419.177 μs |     22.9765 μs |    546.99 KB |
| &#39;ImmutableList (Sorted)&#39;  | RecordClassStrings | 10000   | False    |     6,517.718 μs |       610.222 μs |     33.4483 μs |   1015.75 KB |
| SortedDictionary          | RecordClassStrings | 10000   | False    |     6,712.728 μs |       522.562 μs |     28.6434 μs |    823.45 KB |
| SortedList                | RecordClassStrings | 10000   | False    |     7,006.464 μs |     1,696.750 μs |     93.0046 μs |    364.46 KB |
| ImmutableSortedDictionary | RecordClassStrings | 10000   | False    |    11,810.306 μs |       244.544 μs |     13.4043 μs |   1172.61 KB |
|                           |                    |         |          |                  |                  |                |              |
| **ImmutableArray**            | **RecordClassStrings** | **10000**   | **True**     |         **2.981 μs** |         **1.039 μs** |      **0.0569 μs** |     **78.15 KB** |
| Array                     | RecordClassStrings | 10000   | True     |         3.254 μs |         5.240 μs |      0.2872 μs |     78.15 KB |
| List                      | RecordClassStrings | 10000   | True     |         3.345 μs |         1.265 μs |      0.0693 μs |     78.18 KB |
| ReadOnlyCollection        | RecordClassStrings | 10000   | True     |         3.536 μs |         5.236 μs |      0.2870 μs |     78.17 KB |
| LinkedList                | RecordClassStrings | 10000   | True     |       131.705 μs |        38.013 μs |      2.0836 μs |    468.82 KB |
| ImmutableList             | RecordClassStrings | 10000   | True     |       168.528 μs |        18.054 μs |      0.9896 μs |     468.8 KB |
| &#39;ImmutableArray (Sorted)&#39; | RecordClassStrings | 10000   | True     |       507.635 μs |        57.395 μs |      3.1460 μs |     78.15 KB |
| HashSet                   | RecordClassStrings | 10000   | True     |       568.376 μs |       173.323 μs |      9.5004 μs |    197.49 KB |
| ReadOnlyDictionary        | RecordClassStrings | 10000   | True     |       607.477 μs |        92.844 μs |      5.0891 μs |    276.45 KB |
| Dictionary                | RecordClassStrings | 10000   | True     |       639.324 μs |        79.616 μs |      4.3640 μs |    276.41 KB |
| FrozenSet                 | RecordClassStrings | 10000   | True     |     1,409.665 μs |        86.398 μs |      4.7358 μs |    748.11 KB |
| FrozenDictionary          | RecordClassStrings | 10000   | True     |     1,516.703 μs |       115.079 μs |      6.3079 μs |    914.99 KB |
| ImmutableHashSet          | RecordClassStrings | 10000   | True     |     2,972.986 μs |       211.050 μs |     11.5683 μs |    546.96 KB |
| ImmutableDictionary       | RecordClassStrings | 10000   | True     |     3,101.142 μs |       353.294 μs |     19.3652 μs |    625.19 KB |
| &#39;List (Sorted)&#39;           | RecordClassStrings | 10000   | True     |     3,899.622 μs |       469.731 μs |     25.7475 μs |     78.18 KB |
| &#39;Array (Sorted)&#39;          | RecordClassStrings | 10000   | True     |     4,078.451 μs |       347.625 μs |     19.0545 μs |     78.15 KB |
| SortedSet                 | RecordClassStrings | 10000   | True     |     4,528.383 μs |       215.859 μs |     11.8320 μs |    546.95 KB |
| &#39;ImmutableList (Sorted)&#39;  | RecordClassStrings | 10000   | True     |     4,591.297 μs |       299.633 μs |     16.4239 μs |   1015.75 KB |
| ImmutableSortedSet        | RecordClassStrings | 10000   | True     |     4,659.316 μs |       495.693 μs |     27.1706 μs |    546.99 KB |
| SortedList                | RecordClassStrings | 10000   | True     |     5,177.425 μs |        71.172 μs |      3.9012 μs |    364.46 KB |
| SortedDictionary          | RecordClassStrings | 10000   | True     |     7,981.768 μs |     2,134.929 μs |    117.0227 μs |    823.45 KB |
| ImmutableSortedDictionary | RecordClassStrings | 10000   | True     |    14,415.510 μs |     3,126.759 μs |    171.3882 μs |   1172.61 KB |
|                           |                    |         |          |                  |                  |                |              |
| **ImmutableArray**            | **RecordClassStrings** | **1000000** | **False**    |     **3,282.731 μs** |        **92.482 μs** |      **5.0692 μs** |   **7812.54 KB** |
| ReadOnlyCollection        | RecordClassStrings | 1000000 | False    |     3,286.470 μs |       424.873 μs |     23.2887 μs |   7812.57 KB |
| List                      | RecordClassStrings | 1000000 | False    |     3,298.947 μs |       722.678 μs |     39.6124 μs |   7812.57 KB |
| Array                     | RecordClassStrings | 1000000 | False    |     3,307.651 μs |       344.320 μs |     18.8734 μs |   7812.54 KB |
| ImmutableList             | RecordClassStrings | 1000000 | False    |    56,876.248 μs |     3,236.740 μs |    177.4166 μs |  46875.13 KB |
| LinkedList                | RecordClassStrings | 1000000 | False    |    77,498.105 μs |    87,420.284 μs |  4,791.8007 μs |  46875.19 KB |
| Dictionary                | RecordClassStrings | 1000000 | False    |   111,311.340 μs |    39,190.830 μs |  2,148.1816 μs |  31792.37 KB |
| ReadOnlyDictionary        | RecordClassStrings | 1000000 | False    |   111,836.913 μs |    39,595.189 μs |  2,170.3459 μs |  31792.47 KB |
| HashSet                   | RecordClassStrings | 1000000 | False    |   118,752.847 μs |    22,219.875 μs |  1,217.9463 μs |  22708.95 KB |
| FrozenSet                 | RecordClassStrings | 1000000 | False    |   247,040.000 μs |    64,741.139 μs |  3,548.6803 μs |  83011.25 KB |
| FrozenDictionary          | RecordClassStrings | 1000000 | False    |   265,990.750 μs |   167,791.858 μs |  9,197.2379 μs |    100884 KB |
| ImmutableHashSet          | RecordClassStrings | 1000000 | False    | 1,160,763.567 μs |   348,453.985 μs | 19,099.9387 μs |  54693.03 KB |
| ImmutableDictionary       | RecordClassStrings | 1000000 | False    | 1,164,108.000 μs |   308,173.451 μs | 16,892.0267 μs |  62506.65 KB |
| &#39;List (Sorted)&#39;           | RecordClassStrings | 1000000 | False    | 1,692,189.200 μs |   185,708.764 μs | 10,179.3240 μs |   7812.95 KB |
| &#39;ImmutableArray (Sorted)&#39; | RecordClassStrings | 1000000 | False    | 1,700,343.400 μs |    98,558.371 μs |  5,402.3169 μs |  15625.44 KB |
| &#39;Array (Sorted)&#39;          | RecordClassStrings | 1000000 | False    | 1,723,026.467 μs |   147,235.576 μs |  8,070.4788 μs |   7812.91 KB |
| &#39;ImmutableList (Sorted)&#39;  | RecordClassStrings | 1000000 | False    | 1,809,876.100 μs |   304,030.761 μs | 16,664.9519 μs | 101562.73 KB |
| SortedSet                 | RecordClassStrings | 1000000 | False    | 1,930,465.767 μs |    86,345.623 μs |  4,732.8949 μs |  54687.96 KB |
| ImmutableSortedSet        | RecordClassStrings | 1000000 | False    | 1,946,018.867 μs |    40,982.699 μs |  2,246.4000 μs |     54688 KB |
| SortedList                | RecordClassStrings | 1000000 | False    | 2,043,428.367 μs |   615,532.997 μs | 33,739.4406 μs |  40581.68 KB |
| SortedDictionary          | RecordClassStrings | 1000000 | False    | 2,546,313.000 μs |   417,423.261 μs | 22,880.3775 μs |  86480.13 KB |
| ImmutableSortedDictionary | RecordClassStrings | 1000000 | False    | 3,897,755.767 μs | 1,191,609.598 μs | 65,316.1430 μs |  117188.7 KB |
|                           |                    |         |          |                  |                  |                |              |
| **List**                      | **RecordClassStrings** | **1000000** | **True**     |     **5,572.833 μs** |     **1,104.928 μs** |     **60.5648 μs** |   **7812.57 KB** |
| ReadOnlyCollection        | RecordClassStrings | 1000000 | True     |     5,578.555 μs |     1,184.159 μs |     64.9077 μs |   7812.57 KB |
| ImmutableArray            | RecordClassStrings | 1000000 | True     |     5,580.492 μs |        39.649 μs |      2.1733 μs |   7812.54 KB |
| Array                     | RecordClassStrings | 1000000 | True     |     5,642.840 μs |       690.206 μs |     37.8325 μs |   7812.54 KB |
| ImmutableList             | RecordClassStrings | 1000000 | True     |    62,545.704 μs |     4,774.878 μs |    261.7272 μs |   46875.1 KB |
| LinkedList                | RecordClassStrings | 1000000 | True     |    94,607.424 μs |    97,553.434 μs |  5,347.2329 μs |  46875.22 KB |
| &#39;ImmutableArray (Sorted)&#39; | RecordClassStrings | 1000000 | True     |   173,624.989 μs |    14,513.292 μs |    795.5225 μs |   7812.65 KB |
| ReadOnlyDictionary        | RecordClassStrings | 1000000 | True     |   194,706.833 μs |    48,445.515 μs |  2,655.4621 μs |  31792.52 KB |
| Dictionary                | RecordClassStrings | 1000000 | True     |   197,542.911 μs |    45,803.469 μs |  2,510.6427 μs |  31792.48 KB |
| HashSet                   | RecordClassStrings | 1000000 | True     |   202,440.711 μs |    29,663.680 μs |  1,625.9664 μs |     22709 KB |
| FrozenDictionary          | RecordClassStrings | 1000000 | True     |   470,388.933 μs |   124,918.942 μs |  6,847.2288 μs | 100884.17 KB |
| FrozenSet                 | RecordClassStrings | 1000000 | True     |   496,427.167 μs |   188,444.900 μs | 10,329.3008 μs |  83011.61 KB |
| ImmutableHashSet          | RecordClassStrings | 1000000 | True     | 1,313,633.200 μs |   549,452.473 μs | 30,117.3441 μs |  54693.17 KB |
| ImmutableDictionary       | RecordClassStrings | 1000000 | True     | 1,316,530.100 μs |   425,628.774 μs | 23,330.1493 μs |  62507.52 KB |
| &#39;Array (Sorted)&#39;          | RecordClassStrings | 1000000 | True     | 1,434,924.700 μs |   243,821.616 μs | 13,364.6855 μs |   7812.91 KB |
| &#39;List (Sorted)&#39;           | RecordClassStrings | 1000000 | True     | 1,438,051.333 μs |    32,191.134 μs |  1,764.5047 μs |   7812.95 KB |
| SortedDictionary          | RecordClassStrings | 1000000 | True     | 1,503,189.433 μs |    95,711.163 μs |  5,246.2518 μs |  86480.41 KB |
| SortedSet                 | RecordClassStrings | 1000000 | True     | 1,622,614.400 μs |   212,850.182 μs | 11,667.0367 μs |  54687.96 KB |
| &#39;ImmutableList (Sorted)&#39;  | RecordClassStrings | 1000000 | True     | 1,643,588.667 μs |   129,423.515 μs |  7,094.1396 μs | 101563.01 KB |
| ImmutableSortedSet        | RecordClassStrings | 1000000 | True     | 1,644,704.967 μs |   288,499.353 μs | 15,813.6230 μs |     54688 KB |
| SortedList                | RecordClassStrings | 1000000 | True     | 1,829,603.667 μs |   197,155.345 μs | 10,806.7497 μs |  40581.96 KB |
| ImmutableSortedDictionary | RecordClassStrings | 1000000 | True     | 2,486,785.633 μs |    59,862.862 μs |  3,281.2854 μs | 117188.41 KB |
