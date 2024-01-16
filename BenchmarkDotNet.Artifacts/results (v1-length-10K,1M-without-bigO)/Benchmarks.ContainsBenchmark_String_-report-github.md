```

BenchmarkDotNet v0.13.11, Windows 11 (10.0.22631.2861/23H2/2023Update/SunValley3)
AMD Ryzen 7 5800H with Radeon Graphics, 1 CPU, 16 logical and 8 physical cores
.NET SDK 8.0.100
  [Host]   : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                                   | DataType | Length  | Existed | Mean              | Error             | StdDev          | Allocated |
|----------------------------------------- |--------- |-------- |-------- |------------------:|------------------:|----------------:|----------:|
| **FrozenSet**                                | **String**   | **10000**   | **False**   |          **4.146 ns** |         **0.4740 ns** |       **0.0260 ns** |         **-** |
| FrozenDictionary                         | String   | 10000   | False   |          4.281 ns |         0.7834 ns |       0.0429 ns |         - |
| HashSet                                  | String   | 10000   | False   |          6.404 ns |         1.0738 ns |       0.0589 ns |         - |
| Dictionary                               | String   | 10000   | False   |          6.983 ns |         0.3670 ns |       0.0201 ns |         - |
| ReadOnlyDictionary                       | String   | 10000   | False   |          8.762 ns |         0.7816 ns |       0.0428 ns |         - |
| ImmutableDictionary                      | String   | 10000   | False   |         19.108 ns |         3.5999 ns |       0.1973 ns |         - |
| ImmutableHashSet                         | String   | 10000   | False   |         33.802 ns |         5.1878 ns |       0.2844 ns |         - |
| SortedSet                                | String   | 10000   | False   |        413.465 ns |        50.1106 ns |       2.7467 ns |         - |
| &#39;Array (Sorted + BinarySearch)&#39;          | String   | 10000   | False   |        416.708 ns |        36.2792 ns |       1.9886 ns |         - |
| &#39;ImmutableArray (Sorted + BinarySearch)&#39; | String   | 10000   | False   |        416.878 ns |        29.3995 ns |       1.6115 ns |         - |
| &#39;List (Sorted + BinarySearch)&#39;           | String   | 10000   | False   |        420.819 ns |        20.6917 ns |       1.1342 ns |         - |
| SortedList                               | String   | 10000   | False   |        426.359 ns |        55.7233 ns |       3.0544 ns |         - |
| ImmutableSortedSet                       | String   | 10000   | False   |        428.503 ns |        23.1820 ns |       1.2707 ns |         - |
| ImmutableSortedDictionary                | String   | 10000   | False   |        430.717 ns |        31.2405 ns |       1.7124 ns |         - |
| SortedDictionary                         | String   | 10000   | False   |        469.235 ns |         9.8954 ns |       0.5424 ns |         - |
| &#39;ImmutableList (Sorted + BinarySearch)&#39;  | String   | 10000   | False   |        475.468 ns |        16.4684 ns |       0.9027 ns |         - |
| ReadOnlyCollection                       | String   | 10000   | False   |     21,694.218 ns |     1,769.4396 ns |      96.9890 ns |         - |
| LinkedList                               | String   | 10000   | False   |     24,308.705 ns |     1,730.9287 ns |      94.8780 ns |         - |
| List                                     | String   | 10000   | False   |     29,513.000 ns |    19,121.8701 ns |   1,048.1342 ns |         - |
| Array                                    | String   | 10000   | False   |     35,853.301 ns |     1,940.6152 ns |     106.3717 ns |         - |
| ImmutableArray                           | String   | 10000   | False   |     38,173.775 ns |     3,260.1747 ns |     178.7012 ns |         - |
| ImmutableList                            | String   | 10000   | False   |     92,908.209 ns |     4,318.0546 ns |     236.6871 ns |         - |
|                                          |          |         |         |                   |                   |                 |           |
| **FrozenSet**                                | **String**   | **10000**   | **True**    |          **4.323 ns** |         **1.1209 ns** |       **0.0614 ns** |         **-** |
| FrozenDictionary                         | String   | 10000   | True    |          4.983 ns |         0.9668 ns |       0.0530 ns |         - |
| HashSet                                  | String   | 10000   | True    |          8.387 ns |         1.1459 ns |       0.0628 ns |         - |
| Dictionary                               | String   | 10000   | True    |          8.838 ns |         1.2758 ns |       0.0699 ns |         - |
| ReadOnlyDictionary                       | String   | 10000   | True    |         10.280 ns |         2.0560 ns |       0.1127 ns |         - |
| ImmutableDictionary                      | String   | 10000   | True    |         25.425 ns |         2.9324 ns |       0.1607 ns |         - |
| ImmutableHashSet                         | String   | 10000   | True    |         34.575 ns |         5.2317 ns |       0.2868 ns |         - |
| ImmutableSortedSet                       | String   | 10000   | True    |        336.006 ns |        15.9313 ns |       0.8732 ns |         - |
| ImmutableSortedDictionary                | String   | 10000   | True    |        342.335 ns |        13.7278 ns |       0.7525 ns |         - |
| SortedSet                                | String   | 10000   | True    |        351.983 ns |        18.9757 ns |       1.0401 ns |         - |
| SortedDictionary                         | String   | 10000   | True    |        367.917 ns |        64.7961 ns |       3.5517 ns |         - |
| &#39;ImmutableList (Sorted + BinarySearch)&#39;  | String   | 10000   | True    |        373.013 ns |        19.8803 ns |       1.0897 ns |         - |
| &#39;Array (Sorted + BinarySearch)&#39;          | String   | 10000   | True    |        379.904 ns |        28.8972 ns |       1.5840 ns |         - |
| SortedList                               | String   | 10000   | True    |        386.037 ns |        26.0655 ns |       1.4287 ns |         - |
| &#39;ImmutableArray (Sorted + BinarySearch)&#39; | String   | 10000   | True    |        386.241 ns |        37.2749 ns |       2.0432 ns |         - |
| &#39;List (Sorted + BinarySearch)&#39;           | String   | 10000   | True    |        435.445 ns |        10.8558 ns |       0.5950 ns |         - |
| LinkedList                               | String   | 10000   | True    |      9,844.716 ns |     1,841.7377 ns |     100.9519 ns |         - |
| ReadOnlyCollection                       | String   | 10000   | True    |     10,619.006 ns |       483.0964 ns |      26.4801 ns |         - |
| ImmutableArray                           | String   | 10000   | True    |     13,480.941 ns |       642.8473 ns |      35.2366 ns |         - |
| Array                                    | String   | 10000   | True    |     14,524.384 ns |     3,099.8992 ns |     169.9159 ns |         - |
| List                                     | String   | 10000   | True    |     15,294.420 ns |     2,032.4756 ns |     111.4068 ns |         - |
| ImmutableList                            | String   | 10000   | True    |     32,141.534 ns |     6,077.6203 ns |     333.1349 ns |         - |
|                                          |          |         |         |                   |                   |                 |           |
| **FrozenDictionary**                         | **String**   | **1000000** | **False**   |          **4.839 ns** |         **0.9657 ns** |       **0.0529 ns** |         **-** |
| FrozenSet                                | String   | 1000000 | False   |          5.124 ns |         0.2471 ns |       0.0135 ns |         - |
| Dictionary                               | String   | 1000000 | False   |          7.386 ns |         0.3532 ns |       0.0194 ns |         - |
| HashSet                                  | String   | 1000000 | False   |          7.526 ns |         0.9901 ns |       0.0543 ns |         - |
| ReadOnlyDictionary                       | String   | 1000000 | False   |          9.113 ns |         0.1614 ns |       0.0088 ns |         - |
| ImmutableDictionary                      | String   | 1000000 | False   |         40.608 ns |         3.4549 ns |       0.1894 ns |         - |
| ImmutableHashSet                         | String   | 1000000 | False   |         64.713 ns |         1.5368 ns |       0.0842 ns |         - |
| SortedSet                                | String   | 1000000 | False   |        648.175 ns |        19.8562 ns |       1.0884 ns |         - |
| &#39;Array (Sorted + BinarySearch)&#39;          | String   | 1000000 | False   |        655.283 ns |        38.9319 ns |       2.1340 ns |         - |
| &#39;List (Sorted + BinarySearch)&#39;           | String   | 1000000 | False   |        659.754 ns |        16.7238 ns |       0.9167 ns |         - |
| &#39;ImmutableArray (Sorted + BinarySearch)&#39; | String   | 1000000 | False   |        662.038 ns |        33.0121 ns |       1.8095 ns |         - |
| SortedList                               | String   | 1000000 | False   |        672.929 ns |        15.8055 ns |       0.8664 ns |         - |
| ImmutableSortedSet                       | String   | 1000000 | False   |        684.525 ns |        12.4542 ns |       0.6827 ns |         - |
| ImmutableSortedDictionary                | String   | 1000000 | False   |        685.953 ns |        28.4825 ns |       1.5612 ns |         - |
| &#39;ImmutableList (Sorted + BinarySearch)&#39;  | String   | 1000000 | False   |        739.653 ns |        29.0325 ns |       1.5914 ns |         - |
| SortedDictionary                         | String   | 1000000 | False   |        774.635 ns |         4.6144 ns |       0.2529 ns |         - |
| ReadOnlyCollection                       | String   | 1000000 | False   |  2,921,597.778 ns |   218,782.2334 ns |  11,992.1925 ns |       4 B |
| LinkedList                               | String   | 1000000 | False   |  3,443,091.880 ns |   384,548.1602 ns |  21,078.3823 ns |       5 B |
| ImmutableArray                           | String   | 1000000 | False   |  3,473,889.583 ns |   148,186.9965 ns |   8,122.6293 ns |       5 B |
| Array                                    | String   | 1000000 | False   |  3,650,953.241 ns |   118,604.2690 ns |   6,501.1002 ns |       5 B |
| List                                     | String   | 1000000 | False   |  3,928,190.657 ns | 2,076,501.6229 ns | 113,820.0608 ns |       6 B |
| ImmutableList                            | String   | 1000000 | False   | 28,501,944.444 ns | 1,395,981.0527 ns |  76,518.4320 ns |      61 B |
|                                          |          |         |         |                   |                   |                 |           |
| **FrozenDictionary**                         | **String**   | **1000000** | **True**    |          **5.434 ns** |         **0.2489 ns** |       **0.0136 ns** |         **-** |
| FrozenSet                                | String   | 1000000 | True    |          5.471 ns |         1.1485 ns |       0.0630 ns |         - |
| Dictionary                               | String   | 1000000 | True    |          8.762 ns |         1.6089 ns |       0.0882 ns |         - |
| HashSet                                  | String   | 1000000 | True    |          9.826 ns |         0.4149 ns |       0.0227 ns |         - |
| ReadOnlyDictionary                       | String   | 1000000 | True    |         10.779 ns |         0.6034 ns |       0.0331 ns |         - |
| ImmutableDictionary                      | String   | 1000000 | True    |         44.980 ns |         1.1765 ns |       0.0645 ns |         - |
| ImmutableHashSet                         | String   | 1000000 | True    |         58.440 ns |         2.8327 ns |       0.1553 ns |         - |
| ImmutableSortedSet                       | String   | 1000000 | True    |        542.477 ns |         3.9527 ns |       0.2167 ns |         - |
| ImmutableSortedDictionary                | String   | 1000000 | True    |        554.557 ns |        24.0546 ns |       1.3185 ns |         - |
| &#39;Array (Sorted + BinarySearch)&#39;          | String   | 1000000 | True    |        586.908 ns |         7.2460 ns |       0.3972 ns |         - |
| SortedSet                                | String   | 1000000 | True    |        589.195 ns |         8.9755 ns |       0.4920 ns |         - |
| &#39;ImmutableArray (Sorted + BinarySearch)&#39; | String   | 1000000 | True    |        595.616 ns |        40.4926 ns |       2.2195 ns |         - |
| &#39;List (Sorted + BinarySearch)&#39;           | String   | 1000000 | True    |        597.252 ns |        13.6393 ns |       0.7476 ns |         - |
| &#39;ImmutableList (Sorted + BinarySearch)&#39;  | String   | 1000000 | True    |        600.707 ns |         4.8144 ns |       0.2639 ns |         - |
| SortedDictionary                         | String   | 1000000 | True    |        605.633 ns |        23.5147 ns |       1.2889 ns |         - |
| SortedList                               | String   | 1000000 | True    |        607.082 ns |         7.7659 ns |       0.4257 ns |         - |
| ReadOnlyCollection                       | String   | 1000000 | True    |  1,175,715.191 ns |   385,583.9111 ns |  21,135.1553 ns |       1 B |
| LinkedList                               | String   | 1000000 | True    |  1,189,904.275 ns |    23,479.1838 ns |   1,286.9733 ns |       1 B |
| ImmutableArray                           | String   | 1000000 | True    |  1,288,914.062 ns |   182,454.0633 ns |  10,000.9229 ns |       1 B |
| List                                     | String   | 1000000 | True    |  1,297,331.662 ns |   175,405.8835 ns |   9,614.5884 ns |       1 B |
| Array                                    | String   | 1000000 | True    |  1,540,435.503 ns |   126,062.9561 ns |   6,909.9360 ns |       2 B |
| ImmutableList                            | String   | 1000000 | True    |  8,809,013.889 ns |   277,098.3763 ns |  15,188.6970 ns |      12 B |
