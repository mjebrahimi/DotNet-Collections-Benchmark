```

BenchmarkDotNet v0.13.11, Windows 11 (10.0.22631.2861/23H2/2023Update/SunValley3)
AMD Ryzen 7 5800H with Radeon Graphics, 1 CPU, 16 logical and 8 physical cores
.NET SDK 8.0.100
  [Host]   : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                    | DataType         | Length  | Sorted   | Mean            | Error          | StdDev        | Allocated    |
|-------------------------- |----------------- |-------- |--------- |----------------:|---------------:|--------------:|-------------:|
| **List**                      | **RecordStructInts** | **10000**   | **False**    |        **48.78 μs** |       **5.770 μs** |      **0.316 μs** |    **117.25 KB** |
| Array                     | RecordStructInts | 10000   | False    |        48.85 μs |       6.869 μs |      0.377 μs |    117.22 KB |
| ImmutableArray            | RecordStructInts | 10000   | False    |        49.25 μs |       4.620 μs |      0.253 μs |    117.22 KB |
| ReadOnlyCollection        | RecordStructInts | 10000   | False    |        49.46 μs |      13.220 μs |      0.725 μs |    117.25 KB |
| ImmutableList             | RecordStructInts | 10000   | False    |       122.80 μs |      29.208 μs |      1.601 μs |    546.92 KB |
| LinkedList                | RecordStructInts | 10000   | False    |       122.81 μs |      50.041 μs |      2.743 μs |    546.95 KB |
| HashSet                   | RecordStructInts | 10000   | False    |       197.72 μs |      68.509 μs |      3.755 μs |    236.96 KB |
| ReadOnlyDictionary        | RecordStructInts | 10000   | False    |       277.06 μs |      39.110 μs |      2.144 μs |    276.45 KB |
| Dictionary                | RecordStructInts | 10000   | False    |       280.11 μs |      38.446 μs |      2.107 μs |    276.41 KB |
| &#39;Array (Sorted)&#39;          | RecordStructInts | 10000   | False    |       487.19 μs |     152.865 μs |      8.379 μs |    117.22 KB |
| &#39;ImmutableArray (Sorted)&#39; | RecordStructInts | 10000   | False    |       489.48 μs |      52.791 μs |      2.894 μs |    234.45 KB |
| &#39;List (Sorted)&#39;           | RecordStructInts | 10000   | False    |       503.64 μs |     147.205 μs |      8.069 μs |    117.25 KB |
| FrozenSet                 | RecordStructInts | 10000   | False    |       605.76 μs |      60.908 μs |      3.339 μs |    865.77 KB |
| SortedSet                 | RecordStructInts | 10000   | False    |       615.15 μs |     250.291 μs |     13.719 μs |    586.02 KB |
| FrozenDictionary          | RecordStructInts | 10000   | False    |       621.41 μs |     116.699 μs |      6.397 μs |    954.07 KB |
| ImmutableSortedSet        | RecordStructInts | 10000   | False    |       652.53 μs |     114.006 μs |      6.249 μs |    664.18 KB |
| &#39;ImmutableList (Sorted)&#39;  | RecordStructInts | 10000   | False    |       853.70 μs |     373.844 μs |     20.492 μs |   1211.07 KB |
| SortedList                | RecordStructInts | 10000   | False    |       956.76 μs |      97.545 μs |      5.347 μs |    403.53 KB |
| SortedDictionary          | RecordStructInts | 10000   | False    |     1,526.66 μs |     165.698 μs |      9.082 μs |    823.45 KB |
| ImmutableHashSet          | RecordStructInts | 10000   | False    |     2,263.04 μs |     415.953 μs |     22.800 μs |    625.08 KB |
| ImmutableDictionary       | RecordStructInts | 10000   | False    |     2,376.88 μs |      85.831 μs |      4.705 μs |    625.19 KB |
| ImmutableSortedDictionary | RecordStructInts | 10000   | False    |     2,613.99 μs |     561.021 μs |     30.751 μs |    1797.6 KB |
|                           |                  |         |          |                 |                |               |              |
| **ReadOnlyCollection**        | **RecordStructInts** | **10000**   | **True**     |        **48.99 μs** |       **1.586 μs** |      **0.087 μs** |    **117.25 KB** |
| ImmutableArray            | RecordStructInts | 10000   | True     |        49.22 μs |       5.135 μs |      0.281 μs |    117.22 KB |
| List                      | RecordStructInts | 10000   | True     |        49.33 μs |      11.013 μs |      0.604 μs |    117.25 KB |
| Array                     | RecordStructInts | 10000   | True     |        50.55 μs |      16.307 μs |      0.894 μs |    117.22 KB |
| &#39;ImmutableArray (Sorted)&#39; | RecordStructInts | 10000   | True     |        59.56 μs |       2.643 μs |      0.145 μs |    117.22 KB |
| ImmutableList             | RecordStructInts | 10000   | True     |       121.17 μs |      68.895 μs |      3.776 μs |    546.92 KB |
| LinkedList                | RecordStructInts | 10000   | True     |       126.81 μs |      78.018 μs |      4.276 μs |    546.95 KB |
| &#39;Array (Sorted)&#39;          | RecordStructInts | 10000   | True     |       142.19 μs |       4.652 μs |      0.255 μs |    117.22 KB |
| &#39;List (Sorted)&#39;           | RecordStructInts | 10000   | True     |       142.27 μs |      29.161 μs |      1.598 μs |    117.25 KB |
| HashSet                   | RecordStructInts | 10000   | True     |       202.42 μs |      27.464 μs |      1.505 μs |    236.96 KB |
| SortedSet                 | RecordStructInts | 10000   | True     |       270.67 μs |     170.209 μs |      9.330 μs |    586.02 KB |
| ReadOnlyDictionary        | RecordStructInts | 10000   | True     |       273.74 μs |      35.339 μs |      1.937 μs |    276.45 KB |
| Dictionary                | RecordStructInts | 10000   | True     |       275.55 μs |      13.569 μs |      0.744 μs |    276.41 KB |
| ImmutableSortedSet        | RecordStructInts | 10000   | True     |       299.38 μs |     202.201 μs |     11.083 μs |    664.18 KB |
| SortedList                | RecordStructInts | 10000   | True     |       460.78 μs |     111.991 μs |      6.139 μs |    403.53 KB |
| &#39;ImmutableList (Sorted)&#39;  | RecordStructInts | 10000   | True     |       518.67 μs |     163.843 μs |      8.981 μs |   1211.07 KB |
| FrozenSet                 | RecordStructInts | 10000   | True     |       606.19 μs |      44.825 μs |      2.457 μs |    865.77 KB |
| FrozenDictionary          | RecordStructInts | 10000   | True     |       619.25 μs |     131.720 μs |      7.220 μs |    954.07 KB |
| SortedDictionary          | RecordStructInts | 10000   | True     |       997.43 μs |      54.492 μs |      2.987 μs |    823.45 KB |
| ImmutableSortedDictionary | RecordStructInts | 10000   | True     |     1,386.34 μs |     320.962 μs |     17.593 μs |    1797.6 KB |
| ImmutableHashSet          | RecordStructInts | 10000   | True     |     2,246.62 μs |     251.906 μs |     13.808 μs |    625.08 KB |
| ImmutableDictionary       | RecordStructInts | 10000   | True     |     2,392.36 μs |     218.937 μs |     12.001 μs |    625.19 KB |
|                           |                  |         |          |                 |                |               |              |
| **ReadOnlyCollection**        | **RecordStructInts** | **1000000** | **False**    |     **3,348.69 μs** |     **549.708 μs** |     **30.131 μs** |  **11718.91 KB** |
| List                      | RecordStructInts | 1000000 | False    |     3,351.13 μs |     598.177 μs |     32.788 μs |  11718.92 KB |
| Array                     | RecordStructInts | 1000000 | False    |     3,361.73 μs |     639.698 μs |     35.064 μs |  11718.89 KB |
| ImmutableArray            | RecordStructInts | 1000000 | False    |     3,440.68 μs |   2,346.593 μs |    128.625 μs |  11718.88 KB |
| HashSet                   | RecordStructInts | 1000000 | False    |    55,756.19 μs |  16,673.385 μs |    913.924 μs |  27251.66 KB |
| &#39;List (Sorted)&#39;           | RecordStructInts | 1000000 | False    |    68,037.01 μs |   8,964.530 μs |    491.376 μs |  11718.93 KB |
| &#39;Array (Sorted)&#39;          | RecordStructInts | 1000000 | False    |    69,650.39 μs |   2,476.247 μs |    135.731 μs |   11718.9 KB |
| &#39;ImmutableArray (Sorted)&#39; | RecordStructInts | 1000000 | False    |    71,666.14 μs |   4,964.801 μs |    272.138 μs |  23437.67 KB |
| ReadOnlyDictionary        | RecordStructInts | 1000000 | False    |    82,703.11 μs |  38,939.721 μs |  2,134.417 μs |  31792.54 KB |
| ImmutableList             | RecordStructInts | 1000000 | False    |    83,067.50 μs |  13,968.112 μs |    765.639 μs |   54688.2 KB |
| Dictionary                | RecordStructInts | 1000000 | False    |    86,209.48 μs |  33,527.047 μs |  1,837.731 μs |   31792.5 KB |
| LinkedList                | RecordStructInts | 1000000 | False    |    96,208.36 μs |  49,082.653 μs |  2,690.386 μs |  54688.28 KB |
| ImmutableSortedSet        | RecordStructInts | 1000000 | False    |   152,072.15 μs |  35,390.229 μs |  1,939.858 μs |  66406.89 KB |
| SortedSet                 | RecordStructInts | 1000000 | False    |   160,096.23 μs |  38,402.447 μs |  2,104.968 μs |  58594.55 KB |
| FrozenSet                 | RecordStructInts | 1000000 | False    |   161,055.81 μs | 250,952.080 μs | 13,755.530 μs |  95365.64 KB |
| FrozenDictionary          | RecordStructInts | 1000000 | False    |   176,315.19 μs |  47,187.299 μs |  2,586.495 μs | 104790.37 KB |
| SortedList                | RecordStructInts | 1000000 | False    |   183,632.01 μs | 171,266.984 μs |  9,387.721 μs |  44488.06 KB |
| &#39;ImmutableList (Sorted)&#39;  | RecordStructInts | 1000000 | False    |   246,561.13 μs | 138,628.328 μs |  7,598.686 μs | 121094.77 KB |
| SortedDictionary          | RecordStructInts | 1000000 | False    |   745,543.80 μs | 446,861.760 μs | 24,494.001 μs |  86481.09 KB |
| ImmutableDictionary       | RecordStructInts | 1000000 | False    | 1,061,682.70 μs | 118,735.166 μs |  6,508.275 μs |  62513.92 KB |
| ImmutableHashSet          | RecordStructInts | 1000000 | False    | 1,088,117.17 μs | 868,255.070 μs | 47,591.990 μs |  62507.03 KB |
| ImmutableSortedDictionary | RecordStructInts | 1000000 | False    | 1,434,820.20 μs | 378,733.883 μs | 20,759.682 μs | 179629.06 KB |
|                           |                  |         |          |                 |                |               |              |
| **Array**                     | **RecordStructInts** | **1000000** | **True**     |     **3,378.33 μs** |     **601.245 μs** |     **32.956 μs** |  **11718.89 KB** |
| ImmutableArray            | RecordStructInts | 1000000 | True     |     3,390.09 μs |     616.969 μs |     33.818 μs |  11718.89 KB |
| ReadOnlyCollection        | RecordStructInts | 1000000 | True     |     3,390.67 μs |   1,116.618 μs |     61.206 μs |  11718.91 KB |
| List                      | RecordStructInts | 1000000 | True     |     3,445.90 μs |   1,606.524 μs |     88.059 μs |  11718.92 KB |
| &#39;ImmutableArray (Sorted)&#39; | RecordStructInts | 1000000 | True     |     4,579.29 μs |   3,319.088 μs |    181.930 μs |   11718.9 KB |
| &#39;Array (Sorted)&#39;          | RecordStructInts | 1000000 | True     |    17,908.28 μs |   3,159.306 μs |    173.172 μs |   11718.9 KB |
| &#39;List (Sorted)&#39;           | RecordStructInts | 1000000 | True     |    21,601.00 μs |   4,710.103 μs |    258.177 μs |  11718.93 KB |
| HashSet                   | RecordStructInts | 1000000 | True     |    57,191.87 μs |  48,542.766 μs |  2,660.793 μs |  27251.66 KB |
| Dictionary                | RecordStructInts | 1000000 | True     |    82,675.68 μs |  19,301.110 μs |  1,057.959 μs |   31792.5 KB |
| ReadOnlyDictionary        | RecordStructInts | 1000000 | True     |    82,684.19 μs |  48,334.416 μs |  2,649.372 μs |  31792.54 KB |
| ImmutableList             | RecordStructInts | 1000000 | True     |    83,139.71 μs |  27,460.904 μs |  1,505.225 μs |  54688.21 KB |
| LinkedList                | RecordStructInts | 1000000 | True     |    94,499.33 μs |  19,041.802 μs |  1,043.745 μs |  54688.35 KB |
| ImmutableSortedSet        | RecordStructInts | 1000000 | True     |   107,157.75 μs |  59,578.522 μs |  3,265.700 μs |     66407 KB |
| SortedSet                 | RecordStructInts | 1000000 | True     |   112,447.05 μs |  68,333.935 μs |  3,745.614 μs |  58594.55 KB |
| SortedList                | RecordStructInts | 1000000 | True     |   118,840.49 μs |  76,662.813 μs |  4,202.147 μs |  44487.96 KB |
| FrozenSet                 | RecordStructInts | 1000000 | True     |   163,747.90 μs | 308,646.118 μs | 16,917.935 μs |  95365.64 KB |
| FrozenDictionary          | RecordStructInts | 1000000 | True     |   178,418.33 μs |  53,088.838 μs |  2,909.978 μs | 104790.37 KB |
| &#39;ImmutableList (Sorted)&#39;  | RecordStructInts | 1000000 | True     |   217,747.91 μs |  36,389.124 μs |  1,994.611 μs | 121094.82 KB |
| SortedDictionary          | RecordStructInts | 1000000 | True     |   262,830.27 μs | 122,076.540 μs |  6,691.427 μs |  86480.75 KB |
| ImmutableSortedDictionary | RecordStructInts | 1000000 | True     |   465,749.07 μs |  90,058.186 μs |  4,936.393 μs | 179627.27 KB |
| ImmutableHashSet          | RecordStructInts | 1000000 | True     | 1,068,130.90 μs | 217,194.311 μs | 11,905.153 μs |  62514.63 KB |
| ImmutableDictionary       | RecordStructInts | 1000000 | True     | 1,081,328.97 μs | 687,335.557 μs | 37,675.181 μs |  62507.17 KB |
