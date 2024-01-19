```

BenchmarkDotNet v0.13.12, Windows 11 (10.0.22631.3007/23H2/2023Update/SunValley3)
AMD Ryzen 7 5800H with Radeon Graphics, 1 CPU, 16 logical and 8 physical cores
.NET SDK 8.0.101
  [Host]   : .NET 8.0.1 (8.0.123.58001), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.1 (8.0.123.58001), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                                   | Categories | DataType         | Length | Existed | Mean       | Error       | StdDev     | Allocated |
|----------------------------------------- |----------- |----------------- |------- |-------- |-----------:|------------:|-----------:|----------:|
| **FrozenDictionary**                         | **O(1)**       | **RecordStructInts** | **1000**   | **False**   |   **2.496 ns** |   **0.1072 ns** |  **0.0059 ns** |         **-** |
| Dictionary                               | O(1)       | RecordStructInts | 1000   | False   |   2.594 ns |   0.4020 ns |  0.0220 ns |         - |
| FrozenSet                                | O(1)       | RecordStructInts | 1000   | False   |   2.770 ns |   0.4245 ns |  0.0233 ns |         - |
| HashSet                                  | O(1)       | RecordStructInts | 1000   | False   |   4.426 ns |   0.5854 ns |  0.0321 ns |         - |
| ReadOnlyDictionary                       | O(1)       | RecordStructInts | 1000   | False   |   4.541 ns |   0.7166 ns |  0.0393 ns |         - |
| ImmutableDictionary                      | O(1)       | RecordStructInts | 1000   | False   |   7.737 ns |   1.1004 ns |  0.0603 ns |         - |
| ImmutableHashSet                         | O(1)       | RecordStructInts | 1000   | False   |   7.797 ns |   4.0188 ns |  0.2203 ns |         - |
|                                          |            |                  |        |         |            |             |            |           |
| **Dictionary**                               | **O(1)**       | **RecordStructInts** | **1000**   | **True**    |   **3.575 ns** |   **0.8067 ns** |  **0.0442 ns** |         **-** |
| FrozenDictionary                         | O(1)       | RecordStructInts | 1000   | True    |   3.898 ns |   0.3738 ns |  0.0205 ns |         - |
| HashSet                                  | O(1)       | RecordStructInts | 1000   | True    |   3.997 ns |   0.4230 ns |  0.0232 ns |         - |
| FrozenSet                                | O(1)       | RecordStructInts | 1000   | True    |   4.049 ns |   0.3128 ns |  0.0171 ns |         - |
| ReadOnlyDictionary                       | O(1)       | RecordStructInts | 1000   | True    |   5.672 ns |   1.2425 ns |  0.0681 ns |         - |
| ImmutableHashSet                         | O(1)       | RecordStructInts | 1000   | True    |   7.407 ns |   1.6315 ns |  0.0894 ns |         - |
| ImmutableDictionary                      | O(1)       | RecordStructInts | 1000   | True    |   7.762 ns |   1.5811 ns |  0.0867 ns |         - |
|                                          |            |                  |        |         |            |             |            |           |
| **SortedSet**                                | **O(log(N))**  | **RecordStructInts** | **1000**   | **False**   |  **12.721 ns** |   **0.4313 ns** |  **0.0236 ns** |         **-** |
| &#39;Array (Sorted + BinarySearch)&#39;          | O(log(N))  | RecordStructInts | 1000   | False   |  18.860 ns |   1.0939 ns |  0.0600 ns |         - |
| &#39;ImmutableArray (Sorted + BinarySearch)&#39; | O(log(N))  | RecordStructInts | 1000   | False   |  19.021 ns |   1.9994 ns |  0.1096 ns |         - |
| &#39;List (Sorted + BinarySearch)&#39;           | O(log(N))  | RecordStructInts | 1000   | False   |  19.119 ns |   1.4449 ns |  0.0792 ns |         - |
| SortedList                               | O(log(N))  | RecordStructInts | 1000   | False   |  23.539 ns |   2.1015 ns |  0.1152 ns |      32 B |
| SortedDictionary                         | O(log(N))  | RecordStructInts | 1000   | False   |  24.387 ns |   6.5638 ns |  0.3598 ns |      32 B |
| &#39;ImmutableList (Sorted + BinarySearch)&#39;  | O(log(N))  | RecordStructInts | 1000   | False   |  32.269 ns |   3.5497 ns |  0.1946 ns |         - |
| ImmutableSortedDictionary                | O(log(N))  | RecordStructInts | 1000   | False   |  36.601 ns |   1.5659 ns |  0.0858 ns |         - |
| ImmutableSortedSet                       | O(log(N))  | RecordStructInts | 1000   | False   |  37.911 ns |   8.9316 ns |  0.4896 ns |         - |
|                                          |            |                  |        |         |            |             |            |           |
| **SortedSet**                                | **O(log(N))**  | **RecordStructInts** | **1000**   | **True**    |  **18.607 ns** |   **3.8048 ns** |  **0.2086 ns** |         **-** |
| &#39;Array (Sorted + BinarySearch)&#39;          | O(log(N))  | RecordStructInts | 1000   | True    |  20.193 ns |   1.8159 ns |  0.0995 ns |         - |
| &#39;ImmutableArray (Sorted + BinarySearch)&#39; | O(log(N))  | RecordStructInts | 1000   | True    |  20.234 ns |   1.1731 ns |  0.0643 ns |         - |
| &#39;List (Sorted + BinarySearch)&#39;           | O(log(N))  | RecordStructInts | 1000   | True    |  20.436 ns |   3.1606 ns |  0.1732 ns |         - |
| SortedDictionary                         | O(log(N))  | RecordStructInts | 1000   | True    |  25.049 ns |   3.9722 ns |  0.2177 ns |      32 B |
| SortedList                               | O(log(N))  | RecordStructInts | 1000   | True    |  26.215 ns |   8.8085 ns |  0.4828 ns |      32 B |
| ImmutableSortedDictionary                | O(log(N))  | RecordStructInts | 1000   | True    |  28.917 ns |   0.9038 ns |  0.0495 ns |         - |
| ImmutableSortedSet                       | O(log(N))  | RecordStructInts | 1000   | True    |  30.016 ns |   7.7888 ns |  0.4269 ns |         - |
| &#39;ImmutableList (Sorted + BinarySearch)&#39;  | O(log(N))  | RecordStructInts | 1000   | True    |  31.714 ns |   5.4908 ns |  0.3010 ns |         - |
|                                          |            |                  |        |         |            |             |            |           |
| **List**                                     | **O(N)**       | **RecordStructInts** | **1000**   | **False**   | **491.131 ns** | **138.1953 ns** |  **7.5750 ns** |         **-** |
| Array                                    | O(N)       | RecordStructInts | 1000   | False   | 502.378 ns |  74.4153 ns |  4.0790 ns |         - |
| ImmutableArray                           | O(N)       | RecordStructInts | 1000   | False   | 505.744 ns |  95.9188 ns |  5.2576 ns |         - |
| ReadOnlyCollection                       | O(N)       | RecordStructInts | 1000   | False   | 513.425 ns | 296.4680 ns | 16.2504 ns |         - |
|                                          |            |                  |        |         |            |             |            |           |
| **ImmutableArray**                           | **O(N)**       | **RecordStructInts** | **1000**   | **True**    | **252.977 ns** |  **30.7549 ns** |  **1.6858 ns** |         **-** |
| List                                     | O(N)       | RecordStructInts | 1000   | True    | 253.244 ns |  28.3128 ns |  1.5519 ns |         - |
| Array                                    | O(N)       | RecordStructInts | 1000   | True    | 253.309 ns |  54.1572 ns |  2.9685 ns |         - |
| ReadOnlyCollection                       | O(N)       | RecordStructInts | 1000   | True    | 254.999 ns |  33.5267 ns |  1.8377 ns |         - |
