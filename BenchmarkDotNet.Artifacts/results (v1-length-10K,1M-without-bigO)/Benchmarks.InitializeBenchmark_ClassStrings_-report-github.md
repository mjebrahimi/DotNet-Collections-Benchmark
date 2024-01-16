```

BenchmarkDotNet v0.13.11, Windows 11 (10.0.22631.2861/23H2/2023Update/SunValley3)
AMD Ryzen 7 5800H with Radeon Graphics, 1 CPU, 16 logical and 8 physical cores
.NET SDK 8.0.100
  [Host]   : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                    | DataType     | Length  | Sorted   | Mean             | Error           | StdDev         | Allocated    |
|-------------------------- |------------- |-------- |--------- |-----------------:|----------------:|---------------:|-------------:|
| **List**                      | **ClassStrings** | **10000**   | **False**    |         **3.129 μs** |       **0.9526 μs** |      **0.0522 μs** |     **78.18 KB** |
| ImmutableArray            | ClassStrings | 10000   | False    |         3.346 μs |       3.6727 μs |      0.2013 μs |     78.15 KB |
| Array                     | ClassStrings | 10000   | False    |         3.454 μs |       4.7862 μs |      0.2623 μs |     78.15 KB |
| ReadOnlyCollection        | ClassStrings | 10000   | False    |         3.660 μs |       9.2893 μs |      0.5092 μs |     78.17 KB |
| LinkedList                | ClassStrings | 10000   | False    |       133.071 μs |      34.4856 μs |      1.8903 μs |    468.82 KB |
| ImmutableList             | ClassStrings | 10000   | False    |       170.977 μs |       7.0154 μs |      0.3845 μs |     468.8 KB |
| HashSet                   | ClassStrings | 10000   | False    |       498.867 μs |      46.6805 μs |      2.5587 μs |    197.49 KB |
| ReadOnlyDictionary        | ClassStrings | 10000   | False    |       519.752 μs |     318.0008 μs |     17.4307 μs |    276.45 KB |
| Dictionary                | ClassStrings | 10000   | False    |       521.498 μs |     325.0701 μs |     17.8182 μs |    276.41 KB |
| FrozenSet                 | ClassStrings | 10000   | False    |     1,155.110 μs |     227.4981 μs |     12.4699 μs |    748.11 KB |
| FrozenDictionary          | ClassStrings | 10000   | False    |     1,242.227 μs |     277.1897 μs |     15.1937 μs |    914.99 KB |
| ImmutableHashSet          | ClassStrings | 10000   | False    |     2,784.962 μs |     278.6110 μs |     15.2716 μs |    546.96 KB |
| ImmutableDictionary       | ClassStrings | 10000   | False    |     3,038.927 μs |     878.1792 μs |     48.1360 μs |    625.19 KB |
| &#39;ImmutableArray (Sorted)&#39; | ClassStrings | 10000   | False    |     5,723.010 μs |   2,715.1622 μs |    148.8272 μs |     156.3 KB |
| &#39;Array (Sorted)&#39;          | ClassStrings | 10000   | False    |     5,754.522 μs |   1,018.9461 μs |     55.8519 μs |     78.15 KB |
| &#39;List (Sorted)&#39;           | ClassStrings | 10000   | False    |     5,844.496 μs |   1,461.4863 μs |     80.1090 μs |     78.18 KB |
| SortedSet                 | ClassStrings | 10000   | False    |     6,252.427 μs |     341.5633 μs |     18.7222 μs |    546.95 KB |
| ImmutableSortedSet        | ClassStrings | 10000   | False    |     6,342.280 μs |     223.8494 μs |     12.2699 μs |    546.99 KB |
| &#39;ImmutableList (Sorted)&#39;  | ClassStrings | 10000   | False    |     6,387.129 μs |      41.8035 μs |      2.2914 μs |   1015.75 KB |
| SortedDictionary          | ClassStrings | 10000   | False    |     6,724.190 μs |   1,103.1226 μs |     60.4659 μs |    823.45 KB |
| SortedList                | ClassStrings | 10000   | False    |     6,857.941 μs |     158.5896 μs |      8.6928 μs |    364.46 KB |
| ImmutableSortedDictionary | ClassStrings | 10000   | False    |    11,775.346 μs |     240.3825 μs |     13.1762 μs |   1172.61 KB |
|                           |              |         |          |                  |                 |                |              |
| **List**                      | **ClassStrings** | **10000**   | **True**     |         **2.976 μs** |       **2.3014 μs** |      **0.1261 μs** |     **78.18 KB** |
| ImmutableArray            | ClassStrings | 10000   | True     |         3.579 μs |       3.0988 μs |      0.1699 μs |     78.15 KB |
| Array                     | ClassStrings | 10000   | True     |         3.588 μs |       5.7965 μs |      0.3177 μs |     78.15 KB |
| ReadOnlyCollection        | ClassStrings | 10000   | True     |         3.778 μs |       6.2726 μs |      0.3438 μs |     78.17 KB |
| LinkedList                | ClassStrings | 10000   | True     |       136.625 μs |      21.0321 μs |      1.1528 μs |    468.82 KB |
| ImmutableList             | ClassStrings | 10000   | True     |       171.575 μs |      26.1532 μs |      1.4335 μs |     468.8 KB |
| &#39;ImmutableArray (Sorted)&#39; | ClassStrings | 10000   | True     |       526.995 μs |      20.3872 μs |      1.1175 μs |     78.15 KB |
| HashSet                   | ClassStrings | 10000   | True     |       549.739 μs |      65.7398 μs |      3.6034 μs |    197.49 KB |
| ReadOnlyDictionary        | ClassStrings | 10000   | True     |       579.102 μs |     181.7754 μs |      9.9637 μs |    276.45 KB |
| Dictionary                | ClassStrings | 10000   | True     |       588.393 μs |      61.7739 μs |      3.3860 μs |    276.41 KB |
| FrozenSet                 | ClassStrings | 10000   | True     |     1,398.326 μs |     502.6242 μs |     27.5505 μs |    748.11 KB |
| FrozenDictionary          | ClassStrings | 10000   | True     |     1,458.341 μs |     245.6969 μs |     13.4675 μs |    914.99 KB |
| ImmutableHashSet          | ClassStrings | 10000   | True     |     2,983.712 μs |     793.2004 μs |     43.4780 μs |    546.96 KB |
| ImmutableDictionary       | ClassStrings | 10000   | True     |     3,206.907 μs |     140.5311 μs |      7.7030 μs |    625.19 KB |
| &#39;List (Sorted)&#39;           | ClassStrings | 10000   | True     |     3,806.999 μs |   1,070.7553 μs |     58.6917 μs |     78.18 KB |
| &#39;Array (Sorted)&#39;          | ClassStrings | 10000   | True     |     3,855.092 μs |     640.8630 μs |     35.1279 μs |     78.15 KB |
| ImmutableSortedSet        | ClassStrings | 10000   | True     |     4,526.199 μs |     320.3398 μs |     17.5589 μs |    546.99 KB |
| &#39;ImmutableList (Sorted)&#39;  | ClassStrings | 10000   | True     |     4,585.707 μs |     391.7327 μs |     21.4722 μs |   1015.75 KB |
| SortedSet                 | ClassStrings | 10000   | True     |     4,656.899 μs |     726.3539 μs |     39.8139 μs |    546.95 KB |
| SortedList                | ClassStrings | 10000   | True     |     4,975.379 μs |     915.3141 μs |     50.1715 μs |    364.46 KB |
| SortedDictionary          | ClassStrings | 10000   | True     |     7,861.160 μs |   1,149.5581 μs |     63.0112 μs |    823.45 KB |
| ImmutableSortedDictionary | ClassStrings | 10000   | True     |    14,449.871 μs |   2,656.5008 μs |    145.6118 μs |   1172.61 KB |
|                           |              |         |          |                  |                 |                |              |
| **Array**                     | **ClassStrings** | **1000000** | **False**    |     **3,268.163 μs** |      **50.6116 μs** |      **2.7742 μs** |   **7812.54 KB** |
| ImmutableArray            | ClassStrings | 1000000 | False    |     3,272.491 μs |     371.9994 μs |     20.3905 μs |   7812.54 KB |
| List                      | ClassStrings | 1000000 | False    |     3,284.328 μs |     222.5354 μs |     12.1979 μs |   7812.57 KB |
| ReadOnlyCollection        | ClassStrings | 1000000 | False    |     3,311.382 μs |     303.4500 μs |     16.6331 μs |   7812.57 KB |
| ImmutableList             | ClassStrings | 1000000 | False    |    57,231.215 μs |   4,786.9266 μs |    262.3876 μs |  46875.13 KB |
| LinkedList                | ClassStrings | 1000000 | False    |    78,025.738 μs |  98,731.7196 μs |  5,411.8187 μs |  46875.23 KB |
| ReadOnlyDictionary        | ClassStrings | 1000000 | False    |   110,552.000 μs |  59,064.8845 μs |  3,237.5456 μs |  31792.41 KB |
| Dictionary                | ClassStrings | 1000000 | False    |   111,899.153 μs | 100,094.0351 μs |  5,486.4918 μs |  31792.43 KB |
| HashSet                   | ClassStrings | 1000000 | False    |   114,099.520 μs |  76,684.3443 μs |  4,203.3277 μs |  22708.95 KB |
| FrozenSet                 | ClassStrings | 1000000 | False    |   245,707.167 μs | 137,446.4043 μs |  7,533.9012 μs |  83011.25 KB |
| FrozenDictionary          | ClassStrings | 1000000 | False    |   262,421.450 μs |  87,484.4333 μs |  4,795.3170 μs | 100884.14 KB |
| ImmutableHashSet          | ClassStrings | 1000000 | False    | 1,115,422.667 μs | 522,282.1902 μs | 28,628.0492 μs |  54693.13 KB |
| ImmutableDictionary       | ClassStrings | 1000000 | False    | 1,135,339.300 μs | 171,690.5346 μs |  9,410.9375 μs |  62506.59 KB |
| &#39;Array (Sorted)&#39;          | ClassStrings | 1000000 | False    | 1,563,808.800 μs | 180,543.6837 μs |  9,896.2085 μs |   7812.91 KB |
| &#39;ImmutableArray (Sorted)&#39; | ClassStrings | 1000000 | False    | 1,567,698.933 μs | 184,090.4926 μs | 10,090.6211 μs |  15625.44 KB |
| &#39;List (Sorted)&#39;           | ClassStrings | 1000000 | False    | 1,597,649.833 μs | 422,622.8036 μs | 23,165.3819 μs |   7812.95 KB |
| &#39;ImmutableList (Sorted)&#39;  | ClassStrings | 1000000 | False    | 1,667,373.167 μs | 220,880.9180 μs | 12,107.2284 μs | 101563.01 KB |
| SortedSet                 | ClassStrings | 1000000 | False    | 1,777,829.900 μs | 698,416.0668 μs | 38,282.5413 μs |  54687.96 KB |
| ImmutableSortedSet        | ClassStrings | 1000000 | False    | 1,804,288.267 μs | 218,828.5200 μs | 11,994.7296 μs |     54688 KB |
| SortedList                | ClassStrings | 1000000 | False    | 1,886,570.833 μs | 179,310.0254 μs |  9,828.5875 μs |  40581.96 KB |
| SortedDictionary          | ClassStrings | 1000000 | False    | 2,417,957.433 μs | 367,463.0082 μs | 20,141.8874 μs |  86480.41 KB |
| ImmutableSortedDictionary | ClassStrings | 1000000 | False    | 3,697,727.067 μs | 487,878.1595 μs | 26,742.2482 μs | 117188.41 KB |
|                           |              |         |          |                  |                 |                |              |
| **ReadOnlyCollection**        | **ClassStrings** | **1000000** | **True**     |     **5,455.066 μs** |     **945.6646 μs** |     **51.8351 μs** |   **7812.57 KB** |
| List                      | ClassStrings | 1000000 | True     |     5,461.394 μs |     943.1650 μs |     51.6981 μs |   7812.57 KB |
| Array                     | ClassStrings | 1000000 | True     |     5,476.214 μs |     990.8790 μs |     54.3134 μs |   7812.54 KB |
| ImmutableArray            | ClassStrings | 1000000 | True     |     5,477.453 μs |     267.4659 μs |     14.6607 μs |   7812.54 KB |
| ImmutableList             | ClassStrings | 1000000 | True     |    63,083.425 μs |   3,442.8508 μs |    188.7143 μs |  46875.14 KB |
| LinkedList                | ClassStrings | 1000000 | True     |    93,205.919 μs | 105,145.2947 μs |  5,763.3684 μs |  46875.22 KB |
| &#39;ImmutableArray (Sorted)&#39; | ClassStrings | 1000000 | True     |   164,471.025 μs |  27,871.6321 μs |  1,527.7382 μs |   7812.62 KB |
| Dictionary                | ClassStrings | 1000000 | True     |   187,881.022 μs |  38,205.0568 μs |  2,094.1481 μs |  31792.48 KB |
| HashSet                   | ClassStrings | 1000000 | True     |   189,317.022 μs |  10,127.7366 μs |    555.1354 μs |     22709 KB |
| ReadOnlyDictionary        | ClassStrings | 1000000 | True     |   189,598.811 μs |  46,875.0600 μs |  2,569.3802 μs |  31792.52 KB |
| FrozenDictionary          | ClassStrings | 1000000 | True     |   442,312.200 μs |  82,655.7149 μs |  4,530.6386 μs | 100884.17 KB |
| FrozenSet                 | ClassStrings | 1000000 | True     |   450,568.600 μs | 136,342.5984 μs |  7,473.3979 μs |  83011.61 KB |
| &#39;List (Sorted)&#39;           | ClassStrings | 1000000 | True     | 1,293,602.933 μs | 291,111.8721 μs | 15,956.8240 μs |   7812.95 KB |
| ImmutableHashSet          | ClassStrings | 1000000 | True     | 1,305,933.000 μs | 355,561.8727 μs | 19,489.5460 μs |  54693.31 KB |
| ImmutableDictionary       | ClassStrings | 1000000 | True     | 1,315,924.700 μs | 402,773.0399 μs | 22,077.3494 μs |  62508.29 KB |
| &#39;Array (Sorted)&#39;          | ClassStrings | 1000000 | True     | 1,316,068.900 μs | 115,290.2935 μs |  6,319.4500 μs |   7812.91 KB |
| SortedDictionary          | ClassStrings | 1000000 | True     | 1,491,527.233 μs | 157,688.1287 μs |  8,643.4184 μs |  86480.13 KB |
| SortedSet                 | ClassStrings | 1000000 | True     | 1,516,966.767 μs | 280,063.1318 μs | 15,351.2053 μs |  54687.96 KB |
| &#39;ImmutableList (Sorted)&#39;  | ClassStrings | 1000000 | True     | 1,518,881.367 μs | 198,074.4324 μs | 10,857.1280 μs | 101563.01 KB |
| ImmutableSortedSet        | ClassStrings | 1000000 | True     | 1,534,986.133 μs | 137,762.1386 μs |  7,551.2077 μs |     54688 KB |
| SortedList                | ClassStrings | 1000000 | True     | 1,709,906.733 μs |  81,063.5399 μs |  4,443.3662 μs |  40581.96 KB |
| ImmutableSortedDictionary | ClassStrings | 1000000 | True     | 2,466,352.000 μs | 201,176.8378 μs | 11,027.1813 μs | 117188.41 KB |
