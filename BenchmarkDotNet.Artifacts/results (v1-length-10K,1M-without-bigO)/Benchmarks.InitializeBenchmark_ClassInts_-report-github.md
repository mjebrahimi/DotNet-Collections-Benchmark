```

BenchmarkDotNet v0.13.11, Windows 11 (10.0.22631.2861/23H2/2023Update/SunValley3)
AMD Ryzen 7 5800H with Radeon Graphics, 1 CPU, 16 logical and 8 physical cores
.NET SDK 8.0.100
  [Host]   : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                    | DataType  | Length  | Sorted   | Mean             | Error           | StdDev         | Allocated    |
|-------------------------- |---------- |-------- |--------- |-----------------:|----------------:|---------------:|-------------:|
| **ReadOnlyCollection**        | **ClassInts** | **10000**   | **False**    |         **3.492 μs** |       **5.8591 μs** |      **0.3212 μs** |     **78.17 KB** |
| Array                     | ClassInts | 10000   | False    |         3.529 μs |       2.7510 μs |      0.1508 μs |     78.15 KB |
| ImmutableArray            | ClassInts | 10000   | False    |         3.551 μs |       4.7998 μs |      0.2631 μs |     78.15 KB |
| List                      | ClassInts | 10000   | False    |         3.688 μs |       4.2192 μs |      0.2313 μs |     78.18 KB |
| LinkedList                | ClassInts | 10000   | False    |       129.972 μs |      29.7079 μs |      1.6284 μs |    468.82 KB |
| ImmutableList             | ClassInts | 10000   | False    |       170.240 μs |      54.2766 μs |      2.9751 μs |     468.8 KB |
| HashSet                   | ClassInts | 10000   | False    |       226.485 μs |       9.7914 μs |      0.5367 μs |    197.49 KB |
| Dictionary                | ClassInts | 10000   | False    |       255.905 μs |      20.8061 μs |      1.1405 μs |    276.41 KB |
| ReadOnlyDictionary        | ClassInts | 10000   | False    |       256.470 μs |      37.0336 μs |      2.0299 μs |    276.45 KB |
| FrozenSet                 | ClassInts | 10000   | False    |       643.034 μs |      17.3007 μs |      0.9483 μs |    748.11 KB |
| &#39;ImmutableArray (Sorted)&#39; | ClassInts | 10000   | False    |       747.096 μs |     376.9818 μs |     20.6636 μs |     156.3 KB |
| &#39;Array (Sorted)&#39;          | ClassInts | 10000   | False    |       747.774 μs |     251.9339 μs |     13.8093 μs |     78.15 KB |
| &#39;List (Sorted)&#39;           | ClassInts | 10000   | False    |       754.041 μs |     211.5730 μs |     11.5970 μs |     78.18 KB |
| FrozenDictionary          | ClassInts | 10000   | False    |       756.472 μs |     110.4375 μs |      6.0535 μs |    914.99 KB |
| SortedSet                 | ClassInts | 10000   | False    |       885.444 μs |     354.9983 μs |     19.4587 μs |    546.95 KB |
| ImmutableSortedSet        | ClassInts | 10000   | False    |       971.541 μs |     415.4508 μs |     22.7723 μs |    546.98 KB |
| SortedList                | ClassInts | 10000   | False    |     1,190.681 μs |     227.6526 μs |     12.4784 μs |    364.46 KB |
| &#39;ImmutableList (Sorted)&#39;  | ClassInts | 10000   | False    |     1,403.213 μs |     179.2919 μs |      9.8276 μs |   1015.74 KB |
| SortedDictionary          | ClassInts | 10000   | False    |     2,217.730 μs |     390.3709 μs |     21.3975 μs |    823.45 KB |
| ImmutableDictionary       | ClassInts | 10000   | False    |     2,612.836 μs |     493.7384 μs |     27.0635 μs |    625.19 KB |
| ImmutableHashSet          | ClassInts | 10000   | False    |     2,738.551 μs |     182.4666 μs |     10.0016 μs |    546.96 KB |
| ImmutableSortedDictionary | ClassInts | 10000   | False    |     3,654.423 μs |     308.1428 μs |     16.8903 μs |    1172.6 KB |
|                           |           |         |          |                  |                 |                |              |
| **ImmutableArray**            | **ClassInts** | **10000**   | **True**     |         **3.451 μs** |       **6.0629 μs** |      **0.3323 μs** |     **78.15 KB** |
| List                      | ClassInts | 10000   | True     |         3.547 μs |       0.0605 μs |      0.0033 μs |     78.18 KB |
| ReadOnlyCollection        | ClassInts | 10000   | True     |         3.607 μs |      10.1051 μs |      0.5539 μs |     78.17 KB |
| Array                     | ClassInts | 10000   | True     |         4.005 μs |      11.6877 μs |      0.6406 μs |     78.15 KB |
| &#39;ImmutableArray (Sorted)&#39; | ClassInts | 10000   | True     |        43.909 μs |       1.0825 μs |      0.0593 μs |     78.15 KB |
| LinkedList                | ClassInts | 10000   | True     |       130.148 μs |      16.6345 μs |      0.9118 μs |    468.82 KB |
| ImmutableList             | ClassInts | 10000   | True     |       171.507 μs |      32.3104 μs |      1.7710 μs |     468.8 KB |
| &#39;List (Sorted)&#39;           | ClassInts | 10000   | True     |       258.926 μs |       9.6854 μs |      0.5309 μs |     78.18 KB |
| &#39;Array (Sorted)&#39;          | ClassInts | 10000   | True     |       272.357 μs |      38.9991 μs |      2.1377 μs |     78.15 KB |
| HashSet                   | ClassInts | 10000   | True     |       273.213 μs |      45.6883 μs |      2.5043 μs |    197.49 KB |
| ReadOnlyDictionary        | ClassInts | 10000   | True     |       304.997 μs |      76.2978 μs |      4.1821 μs |    276.45 KB |
| Dictionary                | ClassInts | 10000   | True     |       306.255 μs |      11.5883 μs |      0.6352 μs |    276.41 KB |
| SortedSet                 | ClassInts | 10000   | True     |       391.434 μs |      41.8729 μs |      2.2952 μs |    546.95 KB |
| ImmutableSortedSet        | ClassInts | 10000   | True     |       494.140 μs |      61.4013 μs |      3.3656 μs |    546.98 KB |
| SortedList                | ClassInts | 10000   | True     |       684.466 μs |     209.1178 μs |     11.4625 μs |    364.46 KB |
| FrozenSet                 | ClassInts | 10000   | True     |       698.686 μs |      52.0729 μs |      2.8543 μs |    748.11 KB |
| FrozenDictionary          | ClassInts | 10000   | True     |       819.518 μs |      39.7627 μs |      2.1795 μs |    914.99 KB |
| &#39;ImmutableList (Sorted)&#39;  | ClassInts | 10000   | True     |       888.906 μs |     161.3588 μs |      8.8446 μs |   1015.74 KB |
| SortedDictionary          | ClassInts | 10000   | True     |     1,907.664 μs |     135.4527 μs |      7.4246 μs |    823.45 KB |
| ImmutableHashSet          | ClassInts | 10000   | True     |     2,616.598 μs |     111.1312 μs |      6.0915 μs |    546.96 KB |
| ImmutableDictionary       | ClassInts | 10000   | True     |     2,828.422 μs |     870.6159 μs |     47.7214 μs |    625.19 KB |
| ImmutableSortedDictionary | ClassInts | 10000   | True     |     3,041.821 μs |     556.7378 μs |     30.5167 μs |    1172.6 KB |
|                           |           |         |          |                  |                 |                |              |
| **Array**                     | **ClassInts** | **1000000** | **False**    |     **1,685.417 μs** |      **96.5385 μs** |      **5.2916 μs** |   **7812.56 KB** |
| ImmutableArray            | ClassInts | 1000000 | False    |     1,698.699 μs |     296.8925 μs |     16.2737 μs |   7812.54 KB |
| List                      | ClassInts | 1000000 | False    |     1,914.800 μs |     107.0677 μs |      5.8687 μs |   7813.07 KB |
| ReadOnlyCollection        | ClassInts | 1000000 | False    |     1,952.889 μs |     236.2889 μs |     12.9518 μs |   7813.05 KB |
| HashSet                   | ClassInts | 1000000 | False    |    54,644.158 μs |  16,654.6479 μs |    912.8974 μs |  22712.03 KB |
| Dictionary                | ClassInts | 1000000 | False    |    60,327.741 μs |   8,742.9974 μs |    479.2332 μs |  31792.52 KB |
| ReadOnlyDictionary        | ClassInts | 1000000 | False    |    62,046.867 μs |  47,312.2428 μs |  2,593.3437 μs |  31792.58 KB |
| ImmutableList             | ClassInts | 1000000 | False    |    71,489.821 μs |  26,429.8280 μs |  1,448.7081 μs |  46875.37 KB |
| LinkedList                | ClassInts | 1000000 | False    |    90,952.739 μs |  21,698.8660 μs |  1,189.3881 μs |   46875.5 KB |
| FrozenDictionary          | ClassInts | 1000000 | False    |   161,481.422 μs |  26,312.0337 μs |  1,442.2514 μs | 100884.11 KB |
| FrozenSet                 | ClassInts | 1000000 | False    |   175,773.058 μs | 423,012.3466 μs | 23,186.7341 μs |  83013.53 KB |
| &#39;ImmutableArray (Sorted)&#39; | ClassInts | 1000000 | False    |   194,048.133 μs |  59,493.1494 μs |  3,261.0203 μs |  15625.18 KB |
| &#39;Array (Sorted)&#39;          | ClassInts | 1000000 | False    |   197,477.022 μs |  14,204.3976 μs |    778.5910 μs |   7812.65 KB |
| &#39;List (Sorted)&#39;           | ClassInts | 1000000 | False    |   220,972.511 μs | 135,884.4293 μs |  7,448.2841 μs |   7812.68 KB |
| SortedList                | ClassInts | 1000000 | False    |   301,168.667 μs | 113,274.0864 μs |  6,208.9349 μs |  40585.89 KB |
| ImmutableSortedSet        | ClassInts | 1000000 | False    |   314,867.617 μs |  15,416.6875 μs |    845.0407 μs |  54688.02 KB |
| SortedSet                 | ClassInts | 1000000 | False    |   315,448.083 μs |  28,627.1042 μs |  1,569.1482 μs |  54687.98 KB |
| &#39;ImmutableList (Sorted)&#39;  | ClassInts | 1000000 | False    |   378,184.633 μs |  57,153.9437 μs |  3,132.8005 μs | 101563.36 KB |
| SortedDictionary          | ClassInts | 1000000 | False    | 1,067,929.233 μs | 124,945.4454 μs |  6,848.6815 μs |  86492.76 KB |
| ImmutableDictionary       | ClassInts | 1000000 | False    | 1,123,025.100 μs | 457,014.6377 μs | 25,050.5144 μs |  62508.02 KB |
| ImmutableHashSet          | ClassInts | 1000000 | False    | 1,155,167.933 μs | 381,194.4579 μs | 20,894.5545 μs |  54699.92 KB |
| ImmutableSortedDictionary | ClassInts | 1000000 | False    | 1,667,027.167 μs | 437,656.1922 μs | 23,989.4127 μs | 117193.05 KB |
|                           |           |         |          |                  |                 |                |              |
| **ImmutableArray**            | **ClassInts** | **1000000** | **True**     |     **3,018.099 μs** |     **102.4420 μs** |      **5.6152 μs** |   **7812.58 KB** |
| Array                     | ClassInts | 1000000 | True     |     3,035.039 μs |     627.9158 μs |     34.4182 μs |   7812.58 KB |
| ReadOnlyCollection        | ClassInts | 1000000 | True     |     3,181.845 μs |     316.7816 μs |     17.3639 μs |   7813.23 KB |
| List                      | ClassInts | 1000000 | True     |     3,199.480 μs |     598.9896 μs |     32.8326 μs |   7813.24 KB |
| &#39;ImmutableArray (Sorted)&#39; | ClassInts | 1000000 | True     |    28,134.218 μs |   1,811.3124 μs |     99.2841 μs |   7812.59 KB |
| ImmutableList             | ClassInts | 1000000 | True     |    81,404.257 μs |  30,632.4172 μs |  1,679.0662 μs |  46875.36 KB |
| &#39;List (Sorted)&#39;           | ClassInts | 1000000 | True     |   100,802.133 μs |   7,981.6599 μs |    437.5017 μs |   7812.69 KB |
| LinkedList                | ClassInts | 1000000 | True     |   104,472.178 μs |  30,043.5969 μs |  1,646.7909 μs |  46875.48 KB |
| &#39;Array (Sorted)&#39;          | ClassInts | 1000000 | True     |   104,549.827 μs |  10,400.8401 μs |    570.1051 μs |   7812.66 KB |
| Dictionary                | ClassInts | 1000000 | True     |   120,166.687 μs |  23,512.9987 μs |  1,288.8268 μs |  31792.49 KB |
| ReadOnlyDictionary        | ClassInts | 1000000 | True     |   122,204.400 μs |  23,107.0980 μs |  1,266.5780 μs |  31792.59 KB |
| HashSet                   | ClassInts | 1000000 | True     |   137,878.008 μs | 239,899.9314 μs | 13,149.7247 μs |  22711.04 KB |
| SortedSet                 | ClassInts | 1000000 | True     |   216,388.522 μs |  38,814.2436 μs |  2,127.5397 μs |  54690.08 KB |
| ImmutableSortedSet        | ClassInts | 1000000 | True     |   225,921.800 μs |  49,507.1133 μs |  2,713.6519 μs |  54687.97 KB |
| FrozenDictionary          | ClassInts | 1000000 | True     |   259,589.817 μs |  47,758.5898 μs |  2,617.8095 μs | 100884.43 KB |
| SortedList                | ClassInts | 1000000 | True     |   278,611.633 μs |  44,818.3232 μs |  2,456.6435 μs |  40585.89 KB |
| FrozenSet                 | ClassInts | 1000000 | True     |   288,380.600 μs | 151,778.6812 μs |  8,319.5017 μs |  83011.55 KB |
| &#39;ImmutableList (Sorted)&#39;  | ClassInts | 1000000 | True     |   371,582.167 μs |  77,190.6806 μs |  4,231.0817 μs | 101563.06 KB |
| SortedDictionary          | ClassInts | 1000000 | True     |   564,813.300 μs | 526,043.0897 μs | 28,834.1968 μs |  86485.45 KB |
| ImmutableSortedDictionary | ClassInts | 1000000 | True     |   649,206.133 μs |  59,728.3417 μs |  3,273.9120 μs | 117195.74 KB |
| ImmutableHashSet          | ClassInts | 1000000 | True     | 1,248,229.333 μs | 394,033.6411 μs | 21,598.3135 μs |  54700.17 KB |
| ImmutableDictionary       | ClassInts | 1000000 | True     | 1,267,845.800 μs | 490,560.5013 μs | 26,889.2764 μs |  62507.74 KB |
