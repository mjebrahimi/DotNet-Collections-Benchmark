```

BenchmarkDotNet v0.13.11, Windows 11 (10.0.22631.2861/23H2/2023Update/SunValley3)
AMD Ryzen 7 5800H with Radeon Graphics, 1 CPU, 16 logical and 8 physical cores
.NET SDK 8.0.100
  [Host]   : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                                   | DataType        | Length  | Existed | Mean              | Error              | StdDev            | Allocated |
|----------------------------------------- |---------------- |-------- |-------- |------------------:|-------------------:|------------------:|----------:|
| **FrozenDictionary**                         | **RecordClassInts** | **10000**   | **False**   |          **5.053 ns** |          **0.8885 ns** |         **0.0487 ns** |         **-** |
| FrozenSet                                | RecordClassInts | 10000   | False   |          5.101 ns |          0.6864 ns |         0.0376 ns |         - |
| Dictionary                               | RecordClassInts | 10000   | False   |          6.943 ns |          0.4197 ns |         0.0230 ns |         - |
| HashSet                                  | RecordClassInts | 10000   | False   |          7.213 ns |          0.3581 ns |         0.0196 ns |         - |
| ReadOnlyDictionary                       | RecordClassInts | 10000   | False   |          9.437 ns |          2.5296 ns |         0.1387 ns |         - |
| ImmutableDictionary                      | RecordClassInts | 10000   | False   |         16.281 ns |          1.0344 ns |         0.0567 ns |         - |
| ImmutableHashSet                         | RecordClassInts | 10000   | False   |         32.662 ns |          1.4213 ns |         0.0779 ns |         - |
| &#39;List (Sorted + BinarySearch)&#39;           | RecordClassInts | 10000   | False   |         46.515 ns |         26.0616 ns |         1.4285 ns |         - |
| &#39;ImmutableArray (Sorted + BinarySearch)&#39; | RecordClassInts | 10000   | False   |         49.156 ns |          9.1828 ns |         0.5033 ns |         - |
| &#39;Array (Sorted + BinarySearch)&#39;          | RecordClassInts | 10000   | False   |         50.934 ns |          6.7489 ns |         0.3699 ns |         - |
| SortedList                               | RecordClassInts | 10000   | False   |         51.811 ns |         21.8550 ns |         1.1979 ns |         - |
| SortedSet                                | RecordClassInts | 10000   | False   |         54.735 ns |          2.7531 ns |         0.1509 ns |         - |
| ImmutableSortedSet                       | RecordClassInts | 10000   | False   |         64.625 ns |          2.2337 ns |         0.1224 ns |         - |
| ImmutableSortedDictionary                | RecordClassInts | 10000   | False   |         69.944 ns |          6.1095 ns |         0.3349 ns |         - |
| SortedDictionary                         | RecordClassInts | 10000   | False   |         84.585 ns |         75.9917 ns |         4.1654 ns |         - |
| &#39;ImmutableList (Sorted + BinarySearch)&#39;  | RecordClassInts | 10000   | False   |         97.857 ns |         18.5145 ns |         1.0148 ns |         - |
| ReadOnlyCollection                       | RecordClassInts | 10000   | False   |     19,075.214 ns |      1,825.6494 ns |       100.0700 ns |         - |
| List                                     | RecordClassInts | 10000   | False   |     26,138.868 ns |      1,760.3428 ns |        96.4903 ns |         - |
| Array                                    | RecordClassInts | 10000   | False   |     26,160.339 ns |      1,970.7379 ns |       108.0228 ns |         - |
| ImmutableArray                           | RecordClassInts | 10000   | False   |     26,183.379 ns |        640.6142 ns |        35.1142 ns |         - |
| LinkedList                               | RecordClassInts | 10000   | False   |     26,638.289 ns |      2,295.3140 ns |       125.8139 ns |         - |
| ImmutableList                            | RecordClassInts | 10000   | False   |     85,206.958 ns |      5,899.7127 ns |       323.3832 ns |         - |
|                                          |                 |         |         |                   |                    |                   |           |
| **FrozenDictionary**                         | **RecordClassInts** | **10000**   | **True**    |          **8.937 ns** |          **1.8284 ns** |         **0.1002 ns** |         **-** |
| FrozenSet                                | RecordClassInts | 10000   | True    |          8.939 ns |          0.8094 ns |         0.0444 ns |         - |
| Dictionary                               | RecordClassInts | 10000   | True    |         10.733 ns |          0.3395 ns |         0.0186 ns |         - |
| HashSet                                  | RecordClassInts | 10000   | True    |         10.828 ns |          0.6921 ns |         0.0379 ns |         - |
| ReadOnlyDictionary                       | RecordClassInts | 10000   | True    |         12.929 ns |          1.3855 ns |         0.0759 ns |         - |
| ImmutableDictionary                      | RecordClassInts | 10000   | True    |         24.595 ns |          0.7916 ns |         0.0434 ns |         - |
| ImmutableHashSet                         | RecordClassInts | 10000   | True    |         34.798 ns |          7.1163 ns |         0.3901 ns |         - |
| &#39;List (Sorted + BinarySearch)&#39;           | RecordClassInts | 10000   | True    |         45.076 ns |         14.4306 ns |         0.7910 ns |         - |
| &#39;Array (Sorted + BinarySearch)&#39;          | RecordClassInts | 10000   | True    |         47.447 ns |          3.1052 ns |         0.1702 ns |         - |
| &#39;ImmutableArray (Sorted + BinarySearch)&#39; | RecordClassInts | 10000   | True    |         48.325 ns |          4.7927 ns |         0.2627 ns |         - |
| SortedList                               | RecordClassInts | 10000   | True    |         53.172 ns |          5.9284 ns |         0.3250 ns |         - |
| ImmutableSortedSet                       | RecordClassInts | 10000   | True    |         54.738 ns |          9.3623 ns |         0.5132 ns |         - |
| ImmutableSortedDictionary                | RecordClassInts | 10000   | True    |         55.279 ns |         25.7661 ns |         1.4123 ns |         - |
| SortedSet                                | RecordClassInts | 10000   | True    |         56.911 ns |         35.4445 ns |         1.9428 ns |         - |
| SortedDictionary                         | RecordClassInts | 10000   | True    |         71.985 ns |          3.1045 ns |         0.1702 ns |         - |
| &#39;ImmutableList (Sorted + BinarySearch)&#39;  | RecordClassInts | 10000   | True    |         88.888 ns |          1.3115 ns |         0.0719 ns |         - |
| ReadOnlyCollection                       | RecordClassInts | 10000   | True    |      8,943.348 ns |        561.7855 ns |        30.7934 ns |         - |
| ImmutableArray                           | RecordClassInts | 10000   | True    |     12,225.651 ns |      1,460.5379 ns |        80.0570 ns |         - |
| Array                                    | RecordClassInts | 10000   | True    |     12,237.074 ns |        150.8018 ns |         8.2660 ns |         - |
| List                                     | RecordClassInts | 10000   | True    |     12,331.722 ns |      2,809.2668 ns |       153.9854 ns |         - |
| LinkedList                               | RecordClassInts | 10000   | True    |     12,421.847 ns |        249.6809 ns |        13.6859 ns |         - |
| ImmutableList                            | RecordClassInts | 10000   | True    |     35,292.262 ns |      1,657.7999 ns |        90.8696 ns |         - |
|                                          |                 |         |         |                   |                    |                   |           |
| **FrozenSet**                                | **RecordClassInts** | **1000000** | **False**   |          **5.200 ns** |          **0.1230 ns** |         **0.0067 ns** |         **-** |
| FrozenDictionary                         | RecordClassInts | 1000000 | False   |          5.211 ns |          0.1850 ns |         0.0101 ns |         - |
| Dictionary                               | RecordClassInts | 1000000 | False   |          7.087 ns |          0.3129 ns |         0.0172 ns |         - |
| HashSet                                  | RecordClassInts | 1000000 | False   |          7.247 ns |          1.1984 ns |         0.0657 ns |         - |
| ReadOnlyDictionary                       | RecordClassInts | 1000000 | False   |          9.498 ns |          0.0840 ns |         0.0046 ns |         - |
| ImmutableDictionary                      | RecordClassInts | 1000000 | False   |         33.017 ns |          0.8800 ns |         0.0482 ns |         - |
| ImmutableHashSet                         | RecordClassInts | 1000000 | False   |         64.996 ns |          1.3253 ns |         0.0726 ns |         - |
| &#39;Array (Sorted + BinarySearch)&#39;          | RecordClassInts | 1000000 | False   |         65.375 ns |          7.1119 ns |         0.3898 ns |         - |
| &#39;List (Sorted + BinarySearch)&#39;           | RecordClassInts | 1000000 | False   |         66.877 ns |          6.2229 ns |         0.3411 ns |         - |
| &#39;ImmutableArray (Sorted + BinarySearch)&#39; | RecordClassInts | 1000000 | False   |         71.309 ns |          9.4224 ns |         0.5165 ns |         - |
| SortedList                               | RecordClassInts | 1000000 | False   |         74.894 ns |         11.5317 ns |         0.6321 ns |         - |
| SortedSet                                | RecordClassInts | 1000000 | False   |         89.541 ns |          2.3921 ns |         0.1311 ns |         - |
| ImmutableSortedDictionary                | RecordClassInts | 1000000 | False   |         99.442 ns |          6.1653 ns |         0.3379 ns |         - |
| ImmutableSortedSet                       | RecordClassInts | 1000000 | False   |        105.163 ns |         20.7200 ns |         1.1357 ns |         - |
| SortedDictionary                         | RecordClassInts | 1000000 | False   |        129.462 ns |          8.1785 ns |         0.4483 ns |         - |
| &#39;ImmutableList (Sorted + BinarySearch)&#39;  | RecordClassInts | 1000000 | False   |        146.302 ns |         26.3175 ns |         1.4426 ns |         - |
| ReadOnlyCollection                       | RecordClassInts | 1000000 | False   |  2,169,550.000 ns |     76,758.6643 ns |     4,207.4014 ns |       9 B |
| ImmutableArray                           | RecordClassInts | 1000000 | False   |  2,869,389.815 ns |     29,685.2852 ns |     1,627.1507 ns |       4 B |
| Array                                    | RecordClassInts | 1000000 | False   |  2,885,878.889 ns |    281,738.4411 ns |    15,443.0346 ns |       4 B |
| List                                     | RecordClassInts | 1000000 | False   |  2,888,478.148 ns |    476,973.8978 ns |    26,144.5488 ns |       4 B |
| LinkedList                               | RecordClassInts | 1000000 | False   |  3,173,465.079 ns |    746,607.2816 ns |    40,924.0644 ns |       4 B |
| ImmutableList                            | RecordClassInts | 1000000 | False   | 31,993,105.556 ns | 37,143,838.5452 ns | 2,035,979.1269 ns |      61 B |
|                                          |                 |         |         |                   |                    |                   |           |
| **FrozenSet**                                | **RecordClassInts** | **1000000** | **True**    |          **9.325 ns** |          **0.3512 ns** |         **0.0193 ns** |         **-** |
| FrozenDictionary                         | RecordClassInts | 1000000 | True    |          9.482 ns |          2.8113 ns |         0.1541 ns |         - |
| Dictionary                               | RecordClassInts | 1000000 | True    |         11.097 ns |          0.6673 ns |         0.0366 ns |         - |
| HashSet                                  | RecordClassInts | 1000000 | True    |         11.112 ns |          0.4354 ns |         0.0239 ns |         - |
| ReadOnlyDictionary                       | RecordClassInts | 1000000 | True    |         14.967 ns |          0.8817 ns |         0.0483 ns |         - |
| ImmutableDictionary                      | RecordClassInts | 1000000 | True    |         40.975 ns |          9.0237 ns |         0.4946 ns |         - |
| ImmutableHashSet                         | RecordClassInts | 1000000 | True    |         55.242 ns |          1.2062 ns |         0.0661 ns |         - |
| &#39;List (Sorted + BinarySearch)&#39;           | RecordClassInts | 1000000 | True    |         60.663 ns |          3.1266 ns |         0.1714 ns |         - |
| &#39;Array (Sorted + BinarySearch)&#39;          | RecordClassInts | 1000000 | True    |         60.935 ns |          4.2245 ns |         0.2316 ns |         - |
| &#39;ImmutableArray (Sorted + BinarySearch)&#39; | RecordClassInts | 1000000 | True    |         72.541 ns |          2.8135 ns |         0.1542 ns |         - |
| SortedSet                                | RecordClassInts | 1000000 | True    |         76.857 ns |          1.2624 ns |         0.0692 ns |         - |
| SortedList                               | RecordClassInts | 1000000 | True    |         77.355 ns |         10.9466 ns |         0.6000 ns |         - |
| ImmutableSortedSet                       | RecordClassInts | 1000000 | True    |         87.527 ns |          0.4318 ns |         0.0237 ns |         - |
| ImmutableSortedDictionary                | RecordClassInts | 1000000 | True    |         87.703 ns |          0.7931 ns |         0.0435 ns |         - |
| SortedDictionary                         | RecordClassInts | 1000000 | True    |        111.203 ns |          2.4467 ns |         0.1341 ns |         - |
| &#39;ImmutableList (Sorted + BinarySearch)&#39;  | RecordClassInts | 1000000 | True    |        130.098 ns |          4.4272 ns |         0.2427 ns |         - |
| ReadOnlyCollection                       | RecordClassInts | 1000000 | True    |    945,309.006 ns |     17,483.2468 ns |       958.3158 ns |       1 B |
| ImmutableArray                           | RecordClassInts | 1000000 | True    |  1,243,394.444 ns |     36,526.9073 ns |     2,002.1630 ns |       1 B |
| Array                                    | RecordClassInts | 1000000 | True    |  1,243,733.876 ns |      7,616.0324 ns |       417.4604 ns |       1 B |
| List                                     | RecordClassInts | 1000000 | True    |  1,247,648.568 ns |     56,194.7793 ns |     3,080.2255 ns |       1 B |
| LinkedList                               | RecordClassInts | 1000000 | True    |  1,376,089.670 ns |    285,870.3383 ns |    15,669.5179 ns |       2 B |
| ImmutableList                            | RecordClassInts | 1000000 | True    | 11,992,054.167 ns | 18,311,530.8196 ns | 1,003,716.7937 ns |      15 B |
