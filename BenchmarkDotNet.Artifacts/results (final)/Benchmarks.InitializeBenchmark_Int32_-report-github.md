```

BenchmarkDotNet v0.13.11, Windows 11 (10.0.22631.2861/23H2/2023Update/SunValley3)
AMD Ryzen 7 5800H with Radeon Graphics, 1 CPU, 16 logical and 8 physical cores
.NET SDK 8.0.100
  [Host]   : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                    | DataType | Length  | Sorted   | Mean           | Error          | StdDev         | Allocated   |
|-------------------------- |--------- |-------- |--------- |---------------:|---------------:|---------------:|------------:|
| **Array**                     | **Int32**    | **10000**   | **False**    |       **2.020 μs** |       **3.082 μs** |      **0.1689 μs** |    **39.09 KB** |
| ReadOnlyCollection        | Int32    | 10000   | False    |       2.065 μs |       2.090 μs |      0.1146 μs |    39.11 KB |
| ImmutableArray            | Int32    | 10000   | False    |       2.125 μs |       4.685 μs |      0.2568 μs |    39.09 KB |
| List                      | Int32    | 10000   | False    |       2.247 μs |       2.916 μs |      0.1598 μs |    39.12 KB |
| LinkedList                | Int32    | 10000   | False    |     114.877 μs |      54.824 μs |      3.0051 μs |   468.82 KB |
| ImmutableList             | Int32    | 10000   | False    |     116.774 μs |      37.014 μs |      2.0288 μs |    468.8 KB |
| Dictionary                | Int32    | 10000   | False    |     140.964 μs |      39.301 μs |      2.1542 μs |   197.47 KB |
| ReadOnlyDictionary        | Int32    | 10000   | False    |     143.362 μs |      39.663 μs |      2.1741 μs |   197.51 KB |
| HashSet                   | Int32    | 10000   | False    |     148.196 μs |      13.772 μs |      0.7549 μs |   158.02 KB |
| &#39;Array (Sorted)&#39;          | Int32    | 10000   | False    |     324.932 μs |      77.056 μs |      4.2237 μs |    39.09 KB |
| &#39;List (Sorted)&#39;           | Int32    | 10000   | False    |     326.058 μs |     124.881 μs |      6.8452 μs |    39.12 KB |
| &#39;ImmutableArray (Sorted)&#39; | Int32    | 10000   | False    |     326.504 μs |      25.961 μs |      1.4230 μs |    78.17 KB |
| FrozenSet                 | Int32    | 10000   | False    |     407.216 μs |      41.615 μs |      2.2811 μs |   394.34 KB |
| SortedSet                 | Int32    | 10000   | False    |     414.855 μs |      41.650 μs |      2.2830 μs |   429.76 KB |
| FrozenDictionary          | Int32    | 10000   | False    |     444.312 μs |      61.724 μs |      3.3833 μs |   521.73 KB |
| ImmutableSortedSet        | Int32    | 10000   | False    |     456.041 μs |       5.283 μs |      0.2896 μs |   507.92 KB |
| SortedList                | Int32    | 10000   | False    |     628.833 μs |     122.316 μs |      6.7046 μs |   246.45 KB |
| &#39;ImmutableList (Sorted)&#39;  | Int32    | 10000   | False    |     654.541 μs |      35.198 μs |      1.9293 μs |   976.68 KB |
| SortedDictionary          | Int32    | 10000   | False    |   1,289.650 μs |      65.041 μs |      3.5651 μs |   666.38 KB |
| ImmutableSortedDictionary | Int32    | 10000   | False    |   1,953.540 μs |      42.558 μs |      2.3328 μs |   938.21 KB |
| ImmutableHashSet          | Int32    | 10000   | False    |   1,979.512 μs |     392.789 μs |     21.5301 μs |   546.96 KB |
| ImmutableDictionary       | Int32    | 10000   | False    |   2,228.753 μs |     291.313 μs |     15.9679 μs |   547.06 KB |
|                           |          |         |          |                |                |                |             |
| **Array**                     | **Int32**    | **10000**   | **True**     |       **1.849 μs** |       **3.742 μs** |      **0.2051 μs** |    **39.09 KB** |
| ReadOnlyCollection        | Int32    | 10000   | True     |       1.950 μs |       3.864 μs |      0.2118 μs |    39.11 KB |
| ImmutableArray            | Int32    | 10000   | True     |       2.096 μs |       4.382 μs |      0.2402 μs |    39.09 KB |
| List                      | Int32    | 10000   | True     |       2.301 μs |       4.683 μs |      0.2567 μs |    39.12 KB |
| &#39;ImmutableArray (Sorted)&#39; | Int32    | 10000   | True     |       8.295 μs |       6.966 μs |      0.3818 μs |    39.09 KB |
| &#39;Array (Sorted)&#39;          | Int32    | 10000   | True     |      40.223 μs |       8.734 μs |      0.4788 μs |    39.09 KB |
| &#39;List (Sorted)&#39;           | Int32    | 10000   | True     |      40.531 μs |      13.599 μs |      0.7454 μs |    39.12 KB |
| ImmutableList             | Int32    | 10000   | True     |     116.066 μs |      26.013 μs |      1.4259 μs |    468.8 KB |
| LinkedList                | Int32    | 10000   | True     |     116.991 μs |      26.339 μs |      1.4437 μs |   468.82 KB |
| ReadOnlyDictionary        | Int32    | 10000   | True     |     136.765 μs |      31.299 μs |      1.7156 μs |   197.51 KB |
| SortedSet                 | Int32    | 10000   | True     |     137.815 μs |      27.523 μs |      1.5086 μs |   429.76 KB |
| Dictionary                | Int32    | 10000   | True     |     142.937 μs |      21.222 μs |      1.1632 μs |   197.47 KB |
| HashSet                   | Int32    | 10000   | True     |     147.227 μs |      22.300 μs |      1.2223 μs |   158.02 KB |
| ImmutableSortedSet        | Int32    | 10000   | True     |     172.463 μs |       9.007 μs |      0.4937 μs |   507.92 KB |
| SortedList                | Int32    | 10000   | True     |     245.120 μs |      63.995 μs |      3.5078 μs |   246.45 KB |
| &#39;ImmutableList (Sorted)&#39;  | Int32    | 10000   | True     |     366.517 μs |     152.518 μs |      8.3600 μs |   976.68 KB |
| FrozenSet                 | Int32    | 10000   | True     |     399.679 μs |      47.596 μs |      2.6089 μs |   394.34 KB |
| FrozenDictionary          | Int32    | 10000   | True     |     436.484 μs |      17.724 μs |      0.9715 μs |   521.73 KB |
| SortedDictionary          | Int32    | 10000   | True     |     743.652 μs |      20.063 μs |      1.0997 μs |   666.38 KB |
| ImmutableHashSet          | Int32    | 10000   | True     |   1,035.964 μs |     253.499 μs |     13.8951 μs |   546.95 KB |
| ImmutableSortedDictionary | Int32    | 10000   | True     |   1,045.619 μs |      14.165 μs |      0.7764 μs |    938.2 KB |
| ImmutableDictionary       | Int32    | 10000   | True     |   1,381.476 μs |     113.956 μs |      6.2463 μs |   547.06 KB |
|                           |          |         |          |                |                |                |             |
| **ReadOnlyCollection**        | **Int32**    | **1000000** | **False**    |     **504.324 μs** |     **186.396 μs** |     **10.2170 μs** |  **3906.34 KB** |
| Array                     | Int32    | 1000000 | False    |     515.856 μs |     125.916 μs |      6.9019 μs |  3906.32 KB |
| ImmutableArray            | Int32    | 1000000 | False    |     516.147 μs |     143.627 μs |      7.8727 μs |  3906.32 KB |
| List                      | Int32    | 1000000 | False    |     529.806 μs |     138.811 μs |      7.6087 μs |  3906.35 KB |
| Dictionary                | Int32    | 1000000 | False    |  31,995.977 μs |  13,732.043 μs |    752.6996 μs | 22709.02 KB |
| ReadOnlyDictionary        | Int32    | 1000000 | False    |  32,691.544 μs |  26,134.909 μs |  1,432.5426 μs | 22709.06 KB |
| HashSet                   | Int32    | 1000000 | False    |  33,712.833 μs |  30,348.962 μs |  1,663.5290 μs | 18168.91 KB |
| &#39;List (Sorted)&#39;           | Int32    | 1000000 | False    |  51,104.713 μs |   1,295.765 μs |     71.0253 μs |  3906.44 KB |
| &#39;Array (Sorted)&#39;          | Int32    | 1000000 | False    |  51,494.177 μs |   6,891.472 μs |    377.7448 μs |   3906.4 KB |
| &#39;ImmutableArray (Sorted)&#39; | Int32    | 1000000 | False    |  51,958.013 μs |   1,990.885 μs |    109.1271 μs |  7812.77 KB |
| ImmutableList             | Int32    | 1000000 | False    |  70,960.167 μs |  19,283.238 μs |  1,056.9793 μs | 46875.68 KB |
| LinkedList                | Int32    | 1000000 | False    |  82,392.728 μs |  83,234.849 μs |  4,562.3829 μs | 46875.79 KB |
| SortedList                | Int32    | 1000000 | False    | 113,853.193 μs |  52,341.034 μs |  2,868.9887 μs | 27591.96 KB |
| ImmutableSortedSet        | Int32    | 1000000 | False    | 123,215.547 μs |  66,828.835 μs |  3,663.1140 μs | 50783.16 KB |
| FrozenDictionary          | Int32    | 1000000 | False    | 125,824.411 μs |  27,243.491 μs |  1,493.3076 μs | 58008.48 KB |
| SortedSet                 | Int32    | 1000000 | False    | 132,993.567 μs |  44,723.839 μs |  2,451.4645 μs |  42969.5 KB |
| FrozenSet                 | Int32    | 1000000 | False    | 139,661.489 μs |  32,847.584 μs |  1,800.4869 μs | 44677.32 KB |
| &#39;ImmutableList (Sorted)&#39;  | Int32    | 1000000 | False    | 225,373.189 μs |  59,358.257 μs |  3,253.6263 μs | 97657.35 KB |
| SortedDictionary          | Int32    | 1000000 | False    | 609,980.667 μs | 318,107.221 μs | 17,436.5302 μs | 69596.26 KB |
| ImmutableHashSet          | Int32    | 1000000 | False    | 940,782.600 μs |  94,809.276 μs |  5,196.8163 μs |  54691.8 KB |
| ImmutableSortedDictionary | Int32    | 1000000 | False    | 968,602.200 μs | 461,182.617 μs | 25,278.9754 μs | 93757.37 KB |
| ImmutableDictionary       | Int32    | 1000000 | False    | 985,886.700 μs |  51,637.095 μs |  2,830.4034 μs | 54698.62 KB |
|                           |          |         |          |                |                |                |             |
| **ReadOnlyCollection**        | **Int32**    | **1000000** | **True**     |     **507.657 μs** |     **315.933 μs** |     **17.3174 μs** |  **3906.34 KB** |
| Array                     | Int32    | 1000000 | True     |     517.425 μs |     108.189 μs |      5.9302 μs |  3906.32 KB |
| ImmutableArray            | Int32    | 1000000 | True     |     520.356 μs |      63.329 μs |      3.4713 μs |  3906.32 KB |
| List                      | Int32    | 1000000 | True     |     533.574 μs |     207.440 μs |     11.3705 μs |  3906.35 KB |
| &#39;ImmutableArray (Sorted)&#39; | Int32    | 1000000 | True     |   1,201.790 μs |      45.822 μs |      2.5116 μs |   3906.4 KB |
| &#39;Array (Sorted)&#39;          | Int32    | 1000000 | True     |   5,856.667 μs |     195.599 μs |     10.7214 μs |   3906.4 KB |
| &#39;List (Sorted)&#39;           | Int32    | 1000000 | True     |   5,877.452 μs |     558.147 μs |     30.5939 μs |  3906.43 KB |
| Dictionary                | Int32    | 1000000 | True     |  32,210.608 μs |  12,988.959 μs |    711.9687 μs | 22709.02 KB |
| ReadOnlyDictionary        | Int32    | 1000000 | True     |  33,912.242 μs |  39,660.125 μs |  2,173.9053 μs | 22709.06 KB |
| HashSet                   | Int32    | 1000000 | True     |  35,300.460 μs |  46,691.059 μs |  2,559.2945 μs | 18169.71 KB |
| SortedList                | Int32    | 1000000 | True     |  51,409.652 μs |  19,555.315 μs |  1,071.8928 μs | 27591.97 KB |
| ImmutableList             | Int32    | 1000000 | True     |  67,951.648 μs |  46,361.522 μs |  2,541.2315 μs | 46875.67 KB |
| ImmutableSortedSet        | Int32    | 1000000 | True     |  75,711.886 μs |  21,057.926 μs |  1,154.2560 μs | 50781.94 KB |
| LinkedList                | Int32    | 1000000 | True     |  84,287.589 μs | 101,287.555 μs |  5,551.9127 μs |  46875.8 KB |
| SortedSet                 | Int32    | 1000000 | True     |  90,717.528 μs |  26,335.174 μs |  1,443.5198 μs |  42969.5 KB |
| FrozenDictionary          | Int32    | 1000000 | True     | 112,082.172 μs |  25,774.533 μs |  1,412.7891 μs | 58008.48 KB |
| FrozenSet                 | Int32    | 1000000 | True     | 129,252.750 μs |  62,632.327 μs |  3,433.0892 μs | 44677.28 KB |
| &#39;ImmutableList (Sorted)&#39;  | Int32    | 1000000 | True     | 176,902.744 μs |  65,298.617 μs |  3,579.2375 μs | 97657.34 KB |
| SortedDictionary          | Int32    | 1000000 | True     | 180,298.967 μs |   6,202.504 μs |    339.9802 μs | 69585.11 KB |
| ImmutableHashSet          | Int32    | 1000000 | True     | 251,731.117 μs |  77,326.832 μs |  4,238.5446 μs | 54689.05 KB |
| ImmutableDictionary       | Int32    | 1000000 | True     | 279,102.817 μs |  31,053.597 μs |  1,702.1524 μs | 54688.41 KB |
| ImmutableSortedDictionary | Int32    | 1000000 | True     | 288,083.850 μs | 124,698.653 μs |  6,835.1540 μs | 93751.88 KB |
