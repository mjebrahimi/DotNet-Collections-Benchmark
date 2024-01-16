```

BenchmarkDotNet v0.13.11, Windows 11 (10.0.22631.2861/23H2/2023Update/SunValley3)
AMD Ryzen 7 5800H with Radeon Graphics, 1 CPU, 16 logical and 8 physical cores
.NET SDK 8.0.100
  [Host]   : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                                   | DataType   | Length  | Existed | Mean             | Error             | StdDev         | Allocated  |
|----------------------------------------- |----------- |-------- |-------- |-----------------:|------------------:|---------------:|-----------:|
| **Dictionary**                               | **StructInts** | **10000**   | **False**   |         **14.71 ns** |          **4.200 ns** |       **0.230 ns** |       **32 B** |
| FrozenDictionary                         | StructInts | 10000   | False   |         15.29 ns |          6.150 ns |       0.337 ns |       32 B |
| FrozenSet                                | StructInts | 10000   | False   |         16.16 ns |          3.606 ns |       0.198 ns |       32 B |
| SortedSet                                | StructInts | 10000   | False   |         16.23 ns |          1.987 ns |       0.109 ns |          - |
| HashSet                                  | StructInts | 10000   | False   |         17.20 ns |          3.384 ns |       0.186 ns |       32 B |
| ReadOnlyDictionary                       | StructInts | 10000   | False   |         17.65 ns |          4.570 ns |       0.250 ns |       32 B |
| &#39;Array (Sorted + BinarySearch)&#39;          | StructInts | 10000   | False   |         21.46 ns |          2.982 ns |       0.163 ns |          - |
| &#39;ImmutableArray (Sorted + BinarySearch)&#39; | StructInts | 10000   | False   |         22.78 ns |          2.286 ns |       0.125 ns |          - |
| &#39;List (Sorted + BinarySearch)&#39;           | StructInts | 10000   | False   |         22.78 ns |          1.421 ns |       0.078 ns |          - |
| SortedList                               | StructInts | 10000   | False   |         23.28 ns |          3.375 ns |       0.185 ns |       32 B |
| ImmutableHashSet                         | StructInts | 10000   | False   |         28.63 ns |          3.475 ns |       0.190 ns |       32 B |
| ImmutableDictionary                      | StructInts | 10000   | False   |         28.71 ns |          1.219 ns |       0.067 ns |       32 B |
| SortedDictionary                         | StructInts | 10000   | False   |         29.70 ns |          3.564 ns |       0.195 ns |       32 B |
| &#39;ImmutableList (Sorted + BinarySearch)&#39;  | StructInts | 10000   | False   |         40.34 ns |          1.814 ns |       0.099 ns |          - |
| ImmutableSortedDictionary                | StructInts | 10000   | False   |         43.55 ns |         12.057 ns |       0.661 ns |          - |
| ImmutableSortedSet                       | StructInts | 10000   | False   |         45.47 ns |          0.685 ns |       0.038 ns |          - |
| Array                                    | StructInts | 10000   | False   |     91,558.62 ns |     12,610.088 ns |     691.201 ns |   640000 B |
| List                                     | StructInts | 10000   | False   |     91,588.08 ns |      8,255.343 ns |     452.503 ns |   640000 B |
| ReadOnlyCollection                       | StructInts | 10000   | False   |     92,368.89 ns |     25,429.917 ns |   1,393.900 ns |   640000 B |
| ImmutableArray                           | StructInts | 10000   | False   |     98,331.40 ns |     62,128.131 ns |   3,405.452 ns |   640000 B |
| LinkedList                               | StructInts | 10000   | False   |    123,329.43 ns |      2,243.716 ns |     122.986 ns |   640000 B |
| ImmutableList                            | StructInts | 10000   | False   |    206,594.15 ns |     30,957.518 ns |   1,696.886 ns |   640000 B |
|                                          |            |         |         |                  |                   |                |            |
| **SortedSet**                                | **StructInts** | **10000**   | **True**    |         **21.99 ns** |          **5.822 ns** |       **0.319 ns** |          **-** |
| &#39;ImmutableArray (Sorted + BinarySearch)&#39; | StructInts | 10000   | True    |         24.87 ns |          0.996 ns |       0.055 ns |          - |
| &#39;Array (Sorted + BinarySearch)&#39;          | StructInts | 10000   | True    |         25.06 ns |          1.030 ns |       0.056 ns |          - |
| &#39;List (Sorted + BinarySearch)&#39;           | StructInts | 10000   | True    |         25.19 ns |          4.959 ns |       0.272 ns |          - |
| Dictionary                               | StructInts | 10000   | True    |         27.61 ns |         12.702 ns |       0.696 ns |       96 B |
| HashSet                                  | StructInts | 10000   | True    |         27.81 ns |         20.284 ns |       1.112 ns |       96 B |
| SortedList                               | StructInts | 10000   | True    |         28.71 ns |          4.955 ns |       0.272 ns |       32 B |
| SortedDictionary                         | StructInts | 10000   | True    |         28.86 ns |          4.192 ns |       0.230 ns |       32 B |
| FrozenDictionary                         | StructInts | 10000   | True    |         29.19 ns |         13.863 ns |       0.760 ns |       96 B |
| FrozenSet                                | StructInts | 10000   | True    |         29.21 ns |         17.671 ns |       0.969 ns |       96 B |
| ReadOnlyDictionary                       | StructInts | 10000   | True    |         29.93 ns |         15.404 ns |       0.844 ns |       96 B |
| ImmutableSortedDictionary                | StructInts | 10000   | True    |         36.69 ns |          7.387 ns |       0.405 ns |          - |
| ImmutableSortedSet                       | StructInts | 10000   | True    |         37.18 ns |          1.334 ns |       0.073 ns |          - |
| ImmutableHashSet                         | StructInts | 10000   | True    |         39.02 ns |          7.550 ns |       0.414 ns |       96 B |
| ImmutableDictionary                      | StructInts | 10000   | True    |         40.36 ns |         17.847 ns |       0.978 ns |       96 B |
| &#39;ImmutableList (Sorted + BinarySearch)&#39;  | StructInts | 10000   | True    |         41.85 ns |          8.612 ns |       0.472 ns |          - |
| Array                                    | StructInts | 10000   | True    |     47,977.88 ns |     34,493.196 ns |   1,890.688 ns |   300576 B |
| ImmutableArray                           | StructInts | 10000   | True    |     48,032.19 ns |     36,802.162 ns |   2,017.251 ns |   300576 B |
| List                                     | StructInts | 10000   | True    |     48,057.02 ns |     30,102.097 ns |   1,649.997 ns |   300576 B |
| ReadOnlyCollection                       | StructInts | 10000   | True    |     48,769.86 ns |     37,705.280 ns |   2,066.754 ns |   300576 B |
| LinkedList                               | StructInts | 10000   | True    |     62,615.02 ns |     36,747.115 ns |   2,014.233 ns |   300576 B |
| ImmutableList                            | StructInts | 10000   | True    |     97,520.90 ns |     18,186.117 ns |     996.842 ns |   300576 B |
|                                          |            |         |         |                  |                   |                |            |
| **Dictionary**                               | **StructInts** | **1000000** | **False**   |         **15.05 ns** |          **3.162 ns** |       **0.173 ns** |       **32 B** |
| FrozenSet                                | StructInts | 1000000 | False   |         16.01 ns |          1.634 ns |       0.090 ns |       32 B |
| FrozenDictionary                         | StructInts | 1000000 | False   |         16.08 ns |          9.746 ns |       0.534 ns |       32 B |
| HashSet                                  | StructInts | 1000000 | False   |         17.19 ns |          2.105 ns |       0.115 ns |       32 B |
| ReadOnlyDictionary                       | StructInts | 1000000 | False   |         17.39 ns |          2.190 ns |       0.120 ns |       32 B |
| SortedSet                                | StructInts | 1000000 | False   |         29.01 ns |          1.390 ns |       0.076 ns |          - |
| &#39;ImmutableArray (Sorted + BinarySearch)&#39; | StructInts | 1000000 | False   |         30.80 ns |          1.926 ns |       0.106 ns |          - |
| &#39;Array (Sorted + BinarySearch)&#39;          | StructInts | 1000000 | False   |         30.85 ns |          0.469 ns |       0.026 ns |          - |
| &#39;List (Sorted + BinarySearch)&#39;           | StructInts | 1000000 | False   |         31.10 ns |          3.977 ns |       0.218 ns |          - |
| SortedList                               | StructInts | 1000000 | False   |         33.08 ns |          4.174 ns |       0.229 ns |       32 B |
| ImmutableDictionary                      | StructInts | 1000000 | False   |         53.67 ns |          4.921 ns |       0.270 ns |       32 B |
| SortedDictionary                         | StructInts | 1000000 | False   |         55.45 ns |          2.612 ns |       0.143 ns |       32 B |
| ImmutableSortedDictionary                | StructInts | 1000000 | False   |         56.64 ns |          3.236 ns |       0.177 ns |          - |
| ImmutableSortedSet                       | StructInts | 1000000 | False   |         59.59 ns |          0.731 ns |       0.040 ns |          - |
| ImmutableHashSet                         | StructInts | 1000000 | False   |         61.12 ns |          2.988 ns |       0.164 ns |       32 B |
| &#39;ImmutableList (Sorted + BinarySearch)&#39;  | StructInts | 1000000 | False   |         66.48 ns |          3.814 ns |       0.209 ns |          - |
| ReadOnlyCollection                       | StructInts | 1000000 | False   | 11,505,806.25 ns |  1,547,870.355 ns |  84,843.997 ns | 64000015 B |
| ImmutableArray                           | StructInts | 1000000 | False   | 11,510,954.86 ns |  2,357,028.643 ns | 129,196.693 ns | 64000009 B |
| List                                     | StructInts | 1000000 | False   | 11,768,493.06 ns |    742,327.257 ns |  40,689.462 ns | 64000015 B |
| LinkedList                               | StructInts | 1000000 | False   | 13,127,643.75 ns |    805,398.471 ns |  44,146.608 ns | 64000015 B |
| Array                                    | StructInts | 1000000 | False   | 13,377,476.39 ns | 10,637,272.605 ns | 583,064.805 ns | 64000009 B |
| ImmutableList                            | StructInts | 1000000 | False   | 42,748,819.44 ns |  4,137,001.989 ns | 226,763.039 ns | 64000037 B |
|                                          |            |         |         |                  |                   |                |            |
| **Dictionary**                               | **StructInts** | **1000000** | **True**    |         **28.08 ns** |          **4.137 ns** |       **0.227 ns** |       **96 B** |
| HashSet                                  | StructInts | 1000000 | True    |         28.41 ns |          2.731 ns |       0.150 ns |       96 B |
| SortedSet                                | StructInts | 1000000 | True    |         28.99 ns |          2.274 ns |       0.125 ns |          - |
| FrozenSet                                | StructInts | 1000000 | True    |         30.24 ns |          2.095 ns |       0.115 ns |       96 B |
| ReadOnlyDictionary                       | StructInts | 1000000 | True    |         30.75 ns |          2.535 ns |       0.139 ns |       96 B |
| FrozenDictionary                         | StructInts | 1000000 | True    |         30.80 ns |          9.541 ns |       0.523 ns |       96 B |
| &#39;ImmutableArray (Sorted + BinarySearch)&#39; | StructInts | 1000000 | True    |         32.82 ns |         13.867 ns |       0.760 ns |          - |
| &#39;Array (Sorted + BinarySearch)&#39;          | StructInts | 1000000 | True    |         34.00 ns |          2.219 ns |       0.122 ns |          - |
| &#39;List (Sorted + BinarySearch)&#39;           | StructInts | 1000000 | True    |         34.25 ns |          2.160 ns |       0.118 ns |          - |
| SortedList                               | StructInts | 1000000 | True    |         34.98 ns |          1.470 ns |       0.081 ns |       32 B |
| SortedDictionary                         | StructInts | 1000000 | True    |         51.75 ns |          4.608 ns |       0.253 ns |       32 B |
| ImmutableSortedSet                       | StructInts | 1000000 | True    |         52.72 ns |          0.723 ns |       0.040 ns |          - |
| ImmutableSortedDictionary                | StructInts | 1000000 | True    |         56.37 ns |          8.843 ns |       0.485 ns |          - |
| ImmutableDictionary                      | StructInts | 1000000 | True    |         63.32 ns |          8.806 ns |       0.483 ns |       96 B |
| ImmutableHashSet                         | StructInts | 1000000 | True    |         64.20 ns |          4.248 ns |       0.233 ns |       96 B |
| &#39;ImmutableList (Sorted + BinarySearch)&#39;  | StructInts | 1000000 | True    |         69.82 ns |          7.846 ns |       0.430 ns |          - |
| ImmutableArray                           | StructInts | 1000000 | True    |  5,009,893.52 ns |    279,104.864 ns |  15,298.679 ns | 27782356 B |
| ReadOnlyCollection                       | StructInts | 1000000 | True    |  5,134,358.02 ns |    626,319.629 ns |  34,330.692 ns | 27782359 B |
| Array                                    | StructInts | 1000000 | True    |  5,238,386.46 ns |  2,818,397.788 ns | 154,485.893 ns | 27782360 B |
| List                                     | StructInts | 1000000 | True    |  5,257,127.16 ns |  1,105,880.836 ns |  60,617.060 ns | 27782359 B |
| LinkedList                               | StructInts | 1000000 | True    |  5,998,905.21 ns |  1,153,770.973 ns |  63,242.080 ns | 27782360 B |
| ImmutableList                            | StructInts | 1000000 | True    | 18,012,040.74 ns |    157,717.320 ns |   8,645.019 ns | 27782372 B |
