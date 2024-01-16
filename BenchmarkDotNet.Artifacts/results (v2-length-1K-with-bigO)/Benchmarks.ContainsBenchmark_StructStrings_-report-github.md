```

BenchmarkDotNet v0.13.12, Windows 11 (10.0.22631.3007/23H2/2023Update/SunValley3)
AMD Ryzen 7 5800H with Radeon Graphics, 1 CPU, 16 logical and 8 physical cores
.NET SDK 8.0.101
  [Host]   : .NET 8.0.1 (8.0.123.58001), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.1 (8.0.123.58001), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                                   | Categories | DataType      | Length | Existed | Mean          | Error         | StdDev       | Allocated |
|----------------------------------------- |----------- |-------------- |------- |-------- |--------------:|--------------:|-------------:|----------:|
| **FrozenDictionary**                         | **O(1)**       | **StructStrings** | **1000**   | **False**   |      **56.80 ns** |      **4.859 ns** |     **0.266 ns** |      **40 B** |
| HashSet                                  | O(1)       | StructStrings | 1000   | False   |      57.13 ns |      2.984 ns |     0.164 ns |      40 B |
| ReadOnlyDictionary                       | O(1)       | StructStrings | 1000   | False   |      57.50 ns |      7.221 ns |     0.396 ns |      40 B |
| Dictionary                               | O(1)       | StructStrings | 1000   | False   |      57.91 ns |     13.571 ns |     0.744 ns |      40 B |
| ImmutableHashSet                         | O(1)       | StructStrings | 1000   | False   |      59.30 ns |      1.081 ns |     0.059 ns |      40 B |
| FrozenSet                                | O(1)       | StructStrings | 1000   | False   |      60.97 ns |      3.211 ns |     0.176 ns |      40 B |
| ImmutableDictionary                      | O(1)       | StructStrings | 1000   | False   |      62.08 ns |     20.492 ns |     1.123 ns |      40 B |
|                                          |            |               |        |         |               |               |              |           |
| **FrozenSet**                                | **O(1)**       | **StructStrings** | **1000**   | **True**    |     **256.57 ns** |     **31.197 ns** |     **1.710 ns** |     **168 B** |
| FrozenDictionary                         | O(1)       | StructStrings | 1000   | True    |     263.21 ns |     53.618 ns |     2.939 ns |     168 B |
| ReadOnlyDictionary                       | O(1)       | StructStrings | 1000   | True    |     266.99 ns |     16.972 ns |     0.930 ns |     168 B |
| HashSet                                  | O(1)       | StructStrings | 1000   | True    |     271.87 ns |     29.282 ns |     1.605 ns |     168 B |
| Dictionary                               | O(1)       | StructStrings | 1000   | True    |     276.13 ns |     61.244 ns |     3.357 ns |     168 B |
| ImmutableHashSet                         | O(1)       | StructStrings | 1000   | True    |     280.04 ns |     53.317 ns |     2.922 ns |     168 B |
| ImmutableDictionary                      | O(1)       | StructStrings | 1000   | True    |     289.31 ns |     34.407 ns |     1.886 ns |     168 B |
|                                          |            |               |        |         |               |               |              |           |
| **&#39;Array (Sorted + BinarySearch)&#39;**          | **O(log(N))**  | **StructStrings** | **1000**   | **False**   |     **294.83 ns** |     **29.025 ns** |     **1.591 ns** |         **-** |
| SortedSet                                | O(log(N))  | StructStrings | 1000   | False   |     296.09 ns |     76.284 ns |     4.181 ns |         - |
| &#39;List (Sorted + BinarySearch)&#39;           | O(log(N))  | StructStrings | 1000   | False   |     298.54 ns |     64.107 ns |     3.514 ns |         - |
| &#39;ImmutableArray (Sorted + BinarySearch)&#39; | O(log(N))  | StructStrings | 1000   | False   |     304.61 ns |     31.650 ns |     1.735 ns |         - |
| ImmutableSortedSet                       | O(log(N))  | StructStrings | 1000   | False   |     309.61 ns |     27.325 ns |     1.498 ns |         - |
| &#39;ImmutableList (Sorted + BinarySearch)&#39;  | O(log(N))  | StructStrings | 1000   | False   |     320.08 ns |     28.887 ns |     1.583 ns |         - |
| ImmutableSortedDictionary                | O(log(N))  | StructStrings | 1000   | False   |     323.76 ns |    118.316 ns |     6.485 ns |         - |
| SortedDictionary                         | O(log(N))  | StructStrings | 1000   | False   |     325.09 ns |     18.702 ns |     1.025 ns |      40 B |
| SortedList                               | O(log(N))  | StructStrings | 1000   | False   |     368.81 ns |     45.007 ns |     2.467 ns |      40 B |
|                                          |            |               |        |         |               |               |              |           |
| **&#39;Array (Sorted + BinarySearch)&#39;**          | **O(log(N))**  | **StructStrings** | **1000**   | **True**    |     **221.92 ns** |     **20.011 ns** |     **1.097 ns** |         **-** |
| &#39;List (Sorted + BinarySearch)&#39;           | O(log(N))  | StructStrings | 1000   | True    |     224.35 ns |     76.979 ns |     4.219 ns |         - |
| &#39;ImmutableArray (Sorted + BinarySearch)&#39; | O(log(N))  | StructStrings | 1000   | True    |     230.65 ns |     87.768 ns |     4.811 ns |         - |
| ImmutableSortedSet                       | O(log(N))  | StructStrings | 1000   | True    |     241.52 ns |     13.170 ns |     0.722 ns |         - |
| SortedSet                                | O(log(N))  | StructStrings | 1000   | True    |     247.00 ns |     15.143 ns |     0.830 ns |         - |
| ImmutableSortedDictionary                | O(log(N))  | StructStrings | 1000   | True    |     248.20 ns |     35.410 ns |     1.941 ns |         - |
| SortedList                               | O(log(N))  | StructStrings | 1000   | True    |     252.39 ns |     75.484 ns |     4.138 ns |      40 B |
| &#39;ImmutableList (Sorted + BinarySearch)&#39;  | O(log(N))  | StructStrings | 1000   | True    |     275.92 ns |     12.859 ns |     0.705 ns |         - |
| SortedDictionary                         | O(log(N))  | StructStrings | 1000   | True    |     282.88 ns |     37.253 ns |     2.042 ns |      40 B |
|                                          |            |               |        |         |               |               |              |           |
| **ImmutableArray**                           | **O(N)**       | **StructStrings** | **1000**   | **False**   | **109,484.52 ns** | **13,859.366 ns** |   **759.679 ns** |  **128001 B** |
| ReadOnlyCollection                       | O(N)       | StructStrings | 1000   | False   | 111,861.43 ns | 11,224.447 ns |   615.250 ns |  128001 B |
| List                                     | O(N)       | StructStrings | 1000   | False   | 115,935.57 ns | 24,527.404 ns | 1,344.430 ns |  128000 B |
| Array                                    | O(N)       | StructStrings | 1000   | False   | 116,172.02 ns |  4,091.926 ns |   224.292 ns |  128000 B |
|                                          |            |               |        |         |               |               |              |           |
| **Array**                                    | **O(N)**       | **StructStrings** | **1000**   | **True**    |  **52,394.98 ns** |  **5,239.521 ns** |   **287.196 ns** |   **61441 B** |
| List                                     | O(N)       | StructStrings | 1000   | True    |  52,441.47 ns |  2,993.712 ns |   164.095 ns |   61441 B |
| ReadOnlyCollection                       | O(N)       | StructStrings | 1000   | True    |  53,566.95 ns | 12,081.919 ns |   662.251 ns |   61441 B |
| ImmutableArray                           | O(N)       | StructStrings | 1000   | True    |  56,109.08 ns |  2,176.064 ns |   119.277 ns |   61441 B |
