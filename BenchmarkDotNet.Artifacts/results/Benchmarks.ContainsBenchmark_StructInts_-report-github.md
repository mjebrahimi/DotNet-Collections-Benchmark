```

BenchmarkDotNet v0.13.12, Windows 11 (10.0.22631.3007/23H2/2023Update/SunValley3)
AMD Ryzen 7 5800H with Radeon Graphics, 1 CPU, 16 logical and 8 physical cores
.NET SDK 8.0.101
  [Host]   : .NET 8.0.1 (8.0.123.58001), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.1 (8.0.123.58001), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                                   | Categories | DataType   | Length | Existed | Mean         | Error         | StdDev       | Allocated |
|----------------------------------------- |----------- |----------- |------- |-------- |-------------:|--------------:|-------------:|----------:|
| **FrozenSet**                                | **O(1)**       | **StructInts** | **1000**   | **False**   |     **20.32 ns** |      **5.697 ns** |     **0.312 ns** |      **32 B** |
| FrozenDictionary                         | O(1)       | StructInts | 1000   | False   |     20.49 ns |      3.656 ns |     0.200 ns |      32 B |
| HashSet                                  | O(1)       | StructInts | 1000   | False   |     22.29 ns |      7.726 ns |     0.423 ns |      32 B |
| ReadOnlyDictionary                       | O(1)       | StructInts | 1000   | False   |     22.84 ns |      0.328 ns |     0.018 ns |      32 B |
| Dictionary                               | O(1)       | StructInts | 1000   | False   |     24.19 ns |      2.166 ns |     0.119 ns |      32 B |
| ImmutableDictionary                      | O(1)       | StructInts | 1000   | False   |     25.33 ns |      3.162 ns |     0.173 ns |      32 B |
| ImmutableHashSet                         | O(1)       | StructInts | 1000   | False   |     27.69 ns |      8.744 ns |     0.479 ns |      32 B |
|                                          |            |            |        |         |              |               |              |           |
| **FrozenSet**                                | **O(1)**       | **StructInts** | **1000**   | **True**    |     **35.92 ns** |     **24.385 ns** |     **1.337 ns** |      **96 B** |
| FrozenDictionary                         | O(1)       | StructInts | 1000   | True    |     36.45 ns |     21.510 ns |     1.179 ns |      96 B |
| HashSet                                  | O(1)       | StructInts | 1000   | True    |     39.24 ns |     29.821 ns |     1.635 ns |      96 B |
| ImmutableDictionary                      | O(1)       | StructInts | 1000   | True    |     40.29 ns |     22.601 ns |     1.239 ns |      96 B |
| ReadOnlyDictionary                       | O(1)       | StructInts | 1000   | True    |     40.91 ns |     13.843 ns |     0.759 ns |      96 B |
| ImmutableHashSet                         | O(1)       | StructInts | 1000   | True    |     41.37 ns |     25.692 ns |     1.408 ns |      96 B |
| Dictionary                               | O(1)       | StructInts | 1000   | True    |     41.99 ns |     19.671 ns |     1.078 ns |      96 B |
|                                          |            |            |        |         |              |               |              |           |
| **SortedSet**                                | **O(log(N))**  | **StructInts** | **1000**   | **False**   |     **12.96 ns** |      **7.283 ns** |     **0.399 ns** |         **-** |
| &#39;Array (Sorted + BinarySearch)&#39;          | O(log(N))  | StructInts | 1000   | False   |     18.93 ns |      2.100 ns |     0.115 ns |         - |
| &#39;List (Sorted + BinarySearch)&#39;           | O(log(N))  | StructInts | 1000   | False   |     19.17 ns |      2.258 ns |     0.124 ns |         - |
| &#39;ImmutableArray (Sorted + BinarySearch)&#39; | O(log(N))  | StructInts | 1000   | False   |     19.19 ns |      1.790 ns |     0.098 ns |         - |
| SortedList                               | O(log(N))  | StructInts | 1000   | False   |     23.86 ns |      6.965 ns |     0.382 ns |      32 B |
| SortedDictionary                         | O(log(N))  | StructInts | 1000   | False   |     24.52 ns |      6.728 ns |     0.369 ns |      32 B |
| &#39;ImmutableList (Sorted + BinarySearch)&#39;  | O(log(N))  | StructInts | 1000   | False   |     31.48 ns |      7.400 ns |     0.406 ns |         - |
| ImmutableSortedSet                       | O(log(N))  | StructInts | 1000   | False   |     37.11 ns |      5.834 ns |     0.320 ns |         - |
| ImmutableSortedDictionary                | O(log(N))  | StructInts | 1000   | False   |     37.15 ns |      5.070 ns |     0.278 ns |         - |
|                                          |            |            |        |         |              |               |              |           |
| **SortedSet**                                | **O(log(N))**  | **StructInts** | **1000**   | **True**    |     **17.81 ns** |      **3.540 ns** |     **0.194 ns** |         **-** |
| &#39;Array (Sorted + BinarySearch)&#39;          | O(log(N))  | StructInts | 1000   | True    |     20.24 ns |      4.076 ns |     0.223 ns |         - |
| &#39;ImmutableArray (Sorted + BinarySearch)&#39; | O(log(N))  | StructInts | 1000   | True    |     20.27 ns |      0.536 ns |     0.029 ns |         - |
| &#39;List (Sorted + BinarySearch)&#39;           | O(log(N))  | StructInts | 1000   | True    |     20.60 ns |      4.917 ns |     0.270 ns |         - |
| SortedDictionary                         | O(log(N))  | StructInts | 1000   | True    |     24.90 ns |      1.297 ns |     0.071 ns |      32 B |
| SortedList                               | O(log(N))  | StructInts | 1000   | True    |     25.58 ns |      3.680 ns |     0.202 ns |      32 B |
| &#39;ImmutableList (Sorted + BinarySearch)&#39;  | O(log(N))  | StructInts | 1000   | True    |     27.15 ns |      2.459 ns |     0.135 ns |         - |
| ImmutableSortedDictionary                | O(log(N))  | StructInts | 1000   | True    |     29.41 ns |      1.524 ns |     0.084 ns |         - |
| ImmutableSortedSet                       | O(log(N))  | StructInts | 1000   | True    |     29.56 ns |      6.592 ns |     0.361 ns |         - |
|                                          |            |            |        |         |              |               |              |           |
| **Array**                                    | **O(N)**       | **StructInts** | **1000**   | **False**   | **12,463.03 ns** | **11,691.582 ns** |   **640.855 ns** |   **64000 B** |
| List                                     | O(N)       | StructInts | 1000   | False   | 13,190.33 ns |  9,086.595 ns |   498.067 ns |   64000 B |
| ImmutableArray                           | O(N)       | StructInts | 1000   | False   | 13,202.27 ns | 20,087.818 ns | 1,101.081 ns |   64000 B |
| ReadOnlyCollection                       | O(N)       | StructInts | 1000   | False   | 13,302.69 ns | 15,827.541 ns |   867.561 ns |   64000 B |
|                                          |            |            |        |         |              |               |              |           |
| **Array**                                    | **O(N)**       | **StructInts** | **1000**   | **True**    |  **6,322.55 ns** |  **5,531.420 ns** |   **303.196 ns** |   **30901 B** |
| ImmutableArray                           | O(N)       | StructInts | 1000   | True    |  6,373.33 ns |  5,837.792 ns |   319.989 ns |   30901 B |
| List                                     | O(N)       | StructInts | 1000   | True    |  6,377.23 ns |  4,884.856 ns |   267.755 ns |   30901 B |
| ReadOnlyCollection                       | O(N)       | StructInts | 1000   | True    |  6,487.09 ns |  7,103.222 ns |   389.352 ns |   30901 B |
