```

BenchmarkDotNet v0.13.11, Windows 11 (10.0.22631.2861/23H2/2023Update/SunValley3)
AMD Ryzen 7 5800H with Radeon Graphics, 1 CPU, 16 logical and 8 physical cores
.NET SDK 8.0.100
  [Host]   : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                                   | DataType        | Length  | Existed | Mean              | Error             | StdDev          | Allocated |
|----------------------------------------- |---------------- |-------- |-------- |------------------:|------------------:|----------------:|----------:|
| **FrozenDictionary**                         | **RecordClassInts** | **10000**   | **False**   |          **5.049 ns** |         **0.1944 ns** |       **0.0107 ns** |         **-** |
| HashSet                                  | RecordClassInts | 10000   | False   |          7.395 ns |         0.9240 ns |       0.0506 ns |         - |
| Dictionary                               | RecordClassInts | 10000   | False   |          7.460 ns |         1.2012 ns |       0.0658 ns |         - |
| FrozenSet                                | RecordClassInts | 10000   | False   |          8.498 ns |         0.6917 ns |       0.0379 ns |         - |
| ReadOnlyDictionary                       | RecordClassInts | 10000   | False   |          9.681 ns |         2.7495 ns |       0.1507 ns |         - |
| ImmutableHashSet                         | RecordClassInts | 10000   | False   |         13.835 ns |         1.1327 ns |       0.0621 ns |         - |
| ImmutableDictionary                      | RecordClassInts | 10000   | False   |         16.456 ns |         0.8176 ns |       0.0448 ns |         - |
| &#39;List (Sorted + BinarySearch)&#39;           | RecordClassInts | 10000   | False   |         43.318 ns |        14.5365 ns |       0.7968 ns |         - |
| SortedList                               | RecordClassInts | 10000   | False   |         49.380 ns |         2.4262 ns |       0.1330 ns |         - |
| SortedSet                                | RecordClassInts | 10000   | False   |         51.391 ns |         0.6498 ns |       0.0356 ns |         - |
| &#39;ImmutableArray (Sorted + BinarySearch)&#39; | RecordClassInts | 10000   | False   |         51.690 ns |         3.4638 ns |       0.1899 ns |         - |
| &#39;Array (Sorted + BinarySearch)&#39;          | RecordClassInts | 10000   | False   |         54.720 ns |        10.5286 ns |       0.5771 ns |         - |
| ImmutableSortedDictionary                | RecordClassInts | 10000   | False   |         67.161 ns |         1.3177 ns |       0.0722 ns |         - |
| ImmutableSortedSet                       | RecordClassInts | 10000   | False   |         67.798 ns |         7.8776 ns |       0.4318 ns |         - |
| SortedDictionary                         | RecordClassInts | 10000   | False   |         85.953 ns |         4.2206 ns |       0.2313 ns |         - |
| &#39;ImmutableList (Sorted + BinarySearch)&#39;  | RecordClassInts | 10000   | False   |         96.304 ns |         4.3427 ns |       0.2380 ns |         - |
| ReadOnlyCollection                       | RecordClassInts | 10000   | False   |     19,167.628 ns |     1,783.9556 ns |      97.7846 ns |         - |
| Array                                    | RecordClassInts | 10000   | False   |     26,017.898 ns |     2,105.1779 ns |     115.3919 ns |         - |
| List                                     | RecordClassInts | 10000   | False   |     26,051.807 ns |     2,989.2929 ns |     163.8532 ns |         - |
| ImmutableArray                           | RecordClassInts | 10000   | False   |     26,396.190 ns |     6,559.5571 ns |     359.5515 ns |         - |
| LinkedList                               | RecordClassInts | 10000   | False   |     26,815.738 ns |     1,699.3025 ns |      93.1445 ns |         - |
| ImmutableList                            | RecordClassInts | 10000   | False   |    266,327.224 ns |    43,262.3541 ns |   2,371.3556 ns |         - |
|                                          |                 |         |         |                   |                   |                 |           |
| **FrozenDictionary**                         | **RecordClassInts** | **10000**   | **True**    |          **8.736 ns** |         **0.8027 ns** |       **0.0440 ns** |         **-** |
| Dictionary                               | RecordClassInts | 10000   | True    |         10.971 ns |         0.2006 ns |       0.0110 ns |         - |
| HashSet                                  | RecordClassInts | 10000   | True    |         11.091 ns |         0.5048 ns |       0.0277 ns |         - |
| ReadOnlyDictionary                       | RecordClassInts | 10000   | True    |         13.553 ns |         2.6638 ns |       0.1460 ns |         - |
| FrozenSet                                | RecordClassInts | 10000   | True    |         14.472 ns |         0.8365 ns |       0.0459 ns |         - |
| ImmutableHashSet                         | RecordClassInts | 10000   | True    |         20.968 ns |         1.0399 ns |       0.0570 ns |         - |
| ImmutableDictionary                      | RecordClassInts | 10000   | True    |         25.437 ns |         3.8172 ns |       0.2092 ns |         - |
| &#39;Array (Sorted + BinarySearch)&#39;          | RecordClassInts | 10000   | True    |         48.590 ns |         7.6703 ns |       0.4204 ns |         - |
| &#39;List (Sorted + BinarySearch)&#39;           | RecordClassInts | 10000   | True    |         48.760 ns |         1.6838 ns |       0.0923 ns |         - |
| ImmutableSortedSet                       | RecordClassInts | 10000   | True    |         52.274 ns |         2.8422 ns |       0.1558 ns |         - |
| ImmutableSortedDictionary                | RecordClassInts | 10000   | True    |         54.513 ns |        14.3502 ns |       0.7866 ns |         - |
| &#39;ImmutableArray (Sorted + BinarySearch)&#39; | RecordClassInts | 10000   | True    |         54.751 ns |         5.5656 ns |       0.3051 ns |         - |
| SortedList                               | RecordClassInts | 10000   | True    |         55.756 ns |         1.8296 ns |       0.1003 ns |         - |
| SortedSet                                | RecordClassInts | 10000   | True    |         59.835 ns |         6.7564 ns |       0.3703 ns |         - |
| SortedDictionary                         | RecordClassInts | 10000   | True    |         74.428 ns |        16.9004 ns |       0.9264 ns |         - |
| &#39;ImmutableList (Sorted + BinarySearch)&#39;  | RecordClassInts | 10000   | True    |         89.553 ns |         3.2890 ns |       0.1803 ns |         - |
| ReadOnlyCollection                       | RecordClassInts | 10000   | True    |      8,910.776 ns |       561.2264 ns |      30.7627 ns |         - |
| ImmutableArray                           | RecordClassInts | 10000   | True    |     12,177.394 ns |       316.3498 ns |      17.3402 ns |         - |
| List                                     | RecordClassInts | 10000   | True    |     12,276.785 ns |     1,946.6334 ns |     106.7015 ns |         - |
| Array                                    | RecordClassInts | 10000   | True    |     12,324.663 ns |     1,470.9639 ns |      80.6285 ns |         - |
| LinkedList                               | RecordClassInts | 10000   | True    |     12,436.257 ns |       448.2376 ns |      24.5694 ns |         - |
| ImmutableList                            | RecordClassInts | 10000   | True    |    122,902.466 ns |     3,563.5391 ns |     195.3296 ns |         - |
|                                          |                 |         |         |                   |                   |                 |           |
| **FrozenDictionary**                         | **RecordClassInts** | **1000000** | **False**   |          **5.286 ns** |         **0.1528 ns** |       **0.0084 ns** |         **-** |
| Dictionary                               | RecordClassInts | 1000000 | False   |          7.268 ns |         1.3293 ns |       0.0729 ns |         - |
| HashSet                                  | RecordClassInts | 1000000 | False   |          7.391 ns |         0.9125 ns |       0.0500 ns |         - |
| FrozenSet                                | RecordClassInts | 1000000 | False   |          8.730 ns |         0.3777 ns |       0.0207 ns |         - |
| ReadOnlyDictionary                       | RecordClassInts | 1000000 | False   |          9.852 ns |         1.5223 ns |       0.0834 ns |         - |
| ImmutableHashSet                         | RecordClassInts | 1000000 | False   |         30.661 ns |         1.2402 ns |       0.0680 ns |         - |
| ImmutableDictionary                      | RecordClassInts | 1000000 | False   |         33.670 ns |         6.2636 ns |       0.3433 ns |         - |
| &#39;List (Sorted + BinarySearch)&#39;           | RecordClassInts | 1000000 | False   |         67.704 ns |         1.7345 ns |       0.0951 ns |         - |
| SortedList                               | RecordClassInts | 1000000 | False   |         69.353 ns |         2.2354 ns |       0.1225 ns |         - |
| &#39;Array (Sorted + BinarySearch)&#39;          | RecordClassInts | 1000000 | False   |         72.273 ns |        14.5770 ns |       0.7990 ns |         - |
| &#39;ImmutableArray (Sorted + BinarySearch)&#39; | RecordClassInts | 1000000 | False   |         72.347 ns |         4.0056 ns |       0.2196 ns |         - |
| SortedSet                                | RecordClassInts | 1000000 | False   |         75.786 ns |        14.7938 ns |       0.8109 ns |         - |
| ImmutableSortedSet                       | RecordClassInts | 1000000 | False   |        102.827 ns |        17.2356 ns |       0.9447 ns |         - |
| ImmutableSortedDictionary                | RecordClassInts | 1000000 | False   |        102.917 ns |        10.1100 ns |       0.5542 ns |         - |
| SortedDictionary                         | RecordClassInts | 1000000 | False   |        132.590 ns |         7.4814 ns |       0.4101 ns |         - |
| &#39;ImmutableList (Sorted + BinarySearch)&#39;  | RecordClassInts | 1000000 | False   |        148.384 ns |        12.6701 ns |       0.6945 ns |         - |
| ReadOnlyCollection                       | RecordClassInts | 1000000 | False   |  2,165,413.889 ns |   247,792.0202 ns |  13,582.3168 ns |      20 B |
| ImmutableArray                           | RecordClassInts | 1000000 | False   |  2,866,699.074 ns |   100,082.6845 ns |   5,485.8697 ns |       4 B |
| List                                     | RecordClassInts | 1000000 | False   |  2,866,752.778 ns |    58,959.8989 ns |   3,231.7910 ns |       4 B |
| Array                                    | RecordClassInts | 1000000 | False   |  2,877,782.963 ns |    84,593.0945 ns |   4,636.8330 ns |       4 B |
| LinkedList                               | RecordClassInts | 1000000 | False   |  3,137,116.667 ns |   229,054.9630 ns |  12,555.2754 ns |       5 B |
| ImmutableList                            | RecordClassInts | 1000000 | False   | 42,360,266.667 ns | 2,913,041.7803 ns | 159,673.6496 ns |      61 B |
|                                          |                 |         |         |                   |                   |                 |           |
| **FrozenDictionary**                         | **RecordClassInts** | **1000000** | **True**    |          **9.610 ns** |         **0.4586 ns** |       **0.0251 ns** |         **-** |
| Dictionary                               | RecordClassInts | 1000000 | True    |         11.060 ns |         1.3420 ns |       0.0736 ns |         - |
| HashSet                                  | RecordClassInts | 1000000 | True    |         11.124 ns |         0.6404 ns |       0.0351 ns |         - |
| ReadOnlyDictionary                       | RecordClassInts | 1000000 | True    |         13.681 ns |         0.5726 ns |       0.0314 ns |         - |
| FrozenSet                                | RecordClassInts | 1000000 | True    |         14.720 ns |         0.6467 ns |       0.0354 ns |         - |
| ImmutableHashSet                         | RecordClassInts | 1000000 | True    |         39.262 ns |         3.1282 ns |       0.1715 ns |         - |
| ImmutableDictionary                      | RecordClassInts | 1000000 | True    |         43.746 ns |         8.3712 ns |       0.4589 ns |         - |
| &#39;ImmutableArray (Sorted + BinarySearch)&#39; | RecordClassInts | 1000000 | True    |         63.724 ns |         3.0870 ns |       0.1692 ns |         - |
| &#39;List (Sorted + BinarySearch)&#39;           | RecordClassInts | 1000000 | True    |         66.624 ns |         9.0223 ns |       0.4945 ns |         - |
| &#39;Array (Sorted + BinarySearch)&#39;          | RecordClassInts | 1000000 | True    |         67.319 ns |         1.8484 ns |       0.1013 ns |         - |
| SortedList                               | RecordClassInts | 1000000 | True    |         71.864 ns |         3.4371 ns |       0.1884 ns |         - |
| ImmutableSortedSet                       | RecordClassInts | 1000000 | True    |         83.024 ns |         2.8507 ns |       0.1563 ns |         - |
| ImmutableSortedDictionary                | RecordClassInts | 1000000 | True    |         87.398 ns |         3.5069 ns |       0.1922 ns |         - |
| SortedSet                                | RecordClassInts | 1000000 | True    |         88.118 ns |        10.4529 ns |       0.5730 ns |         - |
| SortedDictionary                         | RecordClassInts | 1000000 | True    |        117.158 ns |        33.8854 ns |       1.8574 ns |         - |
| &#39;ImmutableList (Sorted + BinarySearch)&#39;  | RecordClassInts | 1000000 | True    |        137.305 ns |         3.8657 ns |       0.2119 ns |         - |
| ReadOnlyCollection                       | RecordClassInts | 1000000 | True    |    943,186.111 ns |     7,833.3684 ns |     429.3734 ns |       1 B |
| Array                                    | RecordClassInts | 1000000 | True    |  1,245,295.356 ns |     8,935.4155 ns |     489.7803 ns |       1 B |
| ImmutableArray                           | RecordClassInts | 1000000 | True    |  1,246,554.970 ns |   125,614.4327 ns |   6,885.3509 ns |       1 B |
| List                                     | RecordClassInts | 1000000 | True    |  1,256,322.244 ns |   356,641.4487 ns |  19,548.7212 ns |       1 B |
| LinkedList                               | RecordClassInts | 1000000 | True    |  1,371,423.003 ns |   118,128.3834 ns |   6,475.0153 ns |       2 B |
| ImmutableList                            | RecordClassInts | 1000000 | True    | 18,802,785.185 ns | 1,173,789.6151 ns |  64,339.3696 ns |      20 B |
