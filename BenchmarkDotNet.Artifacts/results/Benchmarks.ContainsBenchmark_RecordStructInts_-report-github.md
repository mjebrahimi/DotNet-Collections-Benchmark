```

BenchmarkDotNet v0.13.12, Windows 11 (10.0.22631.3007/23H2/2023Update/SunValley3)
AMD Ryzen 7 5800H with Radeon Graphics, 1 CPU, 16 logical and 8 physical cores
.NET SDK 8.0.101
  [Host]   : .NET 8.0.1 (8.0.123.58001), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.1 (8.0.123.58001), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                                   | Categories | DataType         | Length | Existed | Mean       | Error       | StdDev    | Allocated |
|----------------------------------------- |----------- |----------------- |------- |-------- |-----------:|------------:|----------:|----------:|
| **FrozenSet**                                | **O(1)**       | **RecordStructInts** | **1000**   | **False**   |   **2.595 ns** |   **0.2810 ns** | **0.0154 ns** |         **-** |
| FrozenDictionary                         | O(1)       | RecordStructInts | 1000   | False   |   2.598 ns |   0.3018 ns | 0.0165 ns |         - |
| Dictionary                               | O(1)       | RecordStructInts | 1000   | False   |   4.380 ns |   0.2512 ns | 0.0138 ns |         - |
| HashSet                                  | O(1)       | RecordStructInts | 1000   | False   |   4.425 ns |   0.1250 ns | 0.0069 ns |         - |
| ReadOnlyDictionary                       | O(1)       | RecordStructInts | 1000   | False   |   4.576 ns |   0.2102 ns | 0.0115 ns |         - |
| ImmutableDictionary                      | O(1)       | RecordStructInts | 1000   | False   |   7.573 ns |   1.0966 ns | 0.0601 ns |         - |
| ImmutableHashSet                         | O(1)       | RecordStructInts | 1000   | False   |   7.642 ns |   1.5060 ns | 0.0826 ns |         - |
|                                          |            |                  |        |         |            |             |           |           |
| **FrozenSet**                                | **O(1)**       | **RecordStructInts** | **1000**   | **True**    |   **3.618 ns** |   **0.3391 ns** | **0.0186 ns** |         **-** |
| FrozenDictionary                         | O(1)       | RecordStructInts | 1000   | True    |   3.785 ns |   0.8025 ns | 0.0440 ns |         - |
| HashSet                                  | O(1)       | RecordStructInts | 1000   | True    |   4.911 ns |   1.7936 ns | 0.0983 ns |         - |
| Dictionary                               | O(1)       | RecordStructInts | 1000   | True    |   4.986 ns |   0.1465 ns | 0.0080 ns |         - |
| ReadOnlyDictionary                       | O(1)       | RecordStructInts | 1000   | True    |   5.399 ns |   0.4077 ns | 0.0223 ns |         - |
| ImmutableHashSet                         | O(1)       | RecordStructInts | 1000   | True    |   7.693 ns |   2.5277 ns | 0.1386 ns |         - |
| ImmutableDictionary                      | O(1)       | RecordStructInts | 1000   | True    |   7.904 ns |   1.8532 ns | 0.1016 ns |         - |
|                                          |            |                  |        |         |            |             |           |           |
| **SortedSet**                                | **O(log(N))**  | **RecordStructInts** | **1000**   | **False**   |  **13.978 ns** |   **0.7222 ns** | **0.0396 ns** |         **-** |
| &#39;Array (Sorted + BinarySearch)&#39;          | O(log(N))  | RecordStructInts | 1000   | False   |  18.674 ns |   1.9552 ns | 0.1072 ns |         - |
| &#39;ImmutableArray (Sorted + BinarySearch)&#39; | O(log(N))  | RecordStructInts | 1000   | False   |  18.848 ns |   1.2010 ns | 0.0658 ns |         - |
| &#39;List (Sorted + BinarySearch)&#39;           | O(log(N))  | RecordStructInts | 1000   | False   |  19.021 ns |   2.6577 ns | 0.1457 ns |         - |
| SortedList                               | O(log(N))  | RecordStructInts | 1000   | False   |  23.771 ns |   8.3139 ns | 0.4557 ns |      32 B |
| SortedDictionary                         | O(log(N))  | RecordStructInts | 1000   | False   |  24.974 ns |   2.8214 ns | 0.1547 ns |      32 B |
| &#39;ImmutableList (Sorted + BinarySearch)&#39;  | O(log(N))  | RecordStructInts | 1000   | False   |  31.460 ns |   3.6933 ns | 0.2024 ns |         - |
| ImmutableSortedDictionary                | O(log(N))  | RecordStructInts | 1000   | False   |  36.904 ns |   6.3120 ns | 0.3460 ns |         - |
| ImmutableSortedSet                       | O(log(N))  | RecordStructInts | 1000   | False   |  37.512 ns |   9.0715 ns | 0.4972 ns |         - |
|                                          |            |                  |        |         |            |             |           |           |
| **SortedSet**                                | **O(log(N))**  | **RecordStructInts** | **1000**   | **True**    |  **17.640 ns** |   **4.1919 ns** | **0.2298 ns** |         **-** |
| &#39;List (Sorted + BinarySearch)&#39;           | O(log(N))  | RecordStructInts | 1000   | True    |  20.606 ns |   2.4490 ns | 0.1342 ns |         - |
| &#39;ImmutableArray (Sorted + BinarySearch)&#39; | O(log(N))  | RecordStructInts | 1000   | True    |  20.637 ns |   2.3828 ns | 0.1306 ns |         - |
| &#39;Array (Sorted + BinarySearch)&#39;          | O(log(N))  | RecordStructInts | 1000   | True    |  20.843 ns |   1.4851 ns | 0.0814 ns |         - |
| SortedList                               | O(log(N))  | RecordStructInts | 1000   | True    |  26.691 ns |   8.7106 ns | 0.4775 ns |      32 B |
| ImmutableSortedDictionary                | O(log(N))  | RecordStructInts | 1000   | True    |  27.080 ns |   7.2256 ns | 0.3961 ns |         - |
| &#39;ImmutableList (Sorted + BinarySearch)&#39;  | O(log(N))  | RecordStructInts | 1000   | True    |  27.141 ns |   3.5392 ns | 0.1940 ns |         - |
| SortedDictionary                         | O(log(N))  | RecordStructInts | 1000   | True    |  27.407 ns |   7.4406 ns | 0.4078 ns |      32 B |
| ImmutableSortedSet                       | O(log(N))  | RecordStructInts | 1000   | True    |  29.574 ns |   3.2711 ns | 0.1793 ns |         - |
|                                          |            |                  |        |         |            |             |           |           |
| **Array**                                    | **O(N)**       | **RecordStructInts** | **1000**   | **False**   | **484.841 ns** |  **51.5342 ns** | **2.8248 ns** |         **-** |
| ImmutableArray                           | O(N)       | RecordStructInts | 1000   | False   | 493.708 ns |  63.8378 ns | 3.4992 ns |         - |
| List                                     | O(N)       | RecordStructInts | 1000   | False   | 495.131 ns | 161.4268 ns | 8.8483 ns |         - |
| ReadOnlyCollection                       | O(N)       | RecordStructInts | 1000   | False   | 512.845 ns | 119.1040 ns | 6.5285 ns |         - |
|                                          |            |                  |        |         |            |             |           |           |
| **List**                                     | **O(N)**       | **RecordStructInts** | **1000**   | **True**    | **252.419 ns** |  **24.8989 ns** | **1.3648 ns** |         **-** |
| ReadOnlyCollection                       | O(N)       | RecordStructInts | 1000   | True    | 253.197 ns |  21.8176 ns | 1.1959 ns |         - |
| Array                                    | O(N)       | RecordStructInts | 1000   | True    | 255.642 ns |  34.3234 ns | 1.8814 ns |         - |
| ImmutableArray                           | O(N)       | RecordStructInts | 1000   | True    | 257.205 ns |  12.2996 ns | 0.6742 ns |         - |
