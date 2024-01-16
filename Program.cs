using BenchmarkDotNetVisualizer;
using BenchmarkDotNetVisualizer.Utilities;

#region Create reports from artifacts
//var directory = DirectoryHelper.GetProjectBenchmarkArtifactResultsDirectory();

//var initializeBenchmarkInfo = BenchmarkInfo.CreateFromDirectory(directory, searchPattern: "Benchmarks.InitializeBenchmark*-report-github.md").ToArray();
//await VisualizeInitializeBenchmarks(initializeBenchmarkInfo);

//var containsBenchmarkInfo = BenchmarkInfo.CreateFromDirectory(directory, searchPattern: "Benchmarks.ContainsBenchmark*-report-github.md").ToArray();
//await VisualizeContainsBenchmarks(containsBenchmarkInfo);

//var tryGetValueBenchmarkInfo = BenchmarkInfo.CreateFromDirectory(directory, searchPattern: "Benchmarks.TryGetValueBenchmark*-report-github.md").ToArray();
//await VisualizeTryGetValueBenchmarks(tryGetValueBenchmarkInfo);

//return;
#endregion

var benchmarkInfo = BenchmarkAutoRunner.SwitcherRun(typeof(Program).Assembly).GetBenchmarkInfo().ToArray();

DirectoryHelper.MoveBenchmarkArtifactsToProjectDirectory();

#region Create reports from summaries
var initializeBenchmarkInfo2 = Array.FindAll(benchmarkInfo, p => p.BenchmarkType.GetGenericTypeDefinition() == typeof(Benchmarks.InitializeBenchmark<>));
await VisualizeInitializeBenchmarks(initializeBenchmarkInfo2);

var containsBenchmarkInfo2 = Array.FindAll(benchmarkInfo, p => p.BenchmarkType.GetGenericTypeDefinition() == typeof(Benchmarks.ContainsBenchmark<>));
await VisualizeContainsBenchmarks(containsBenchmarkInfo2);

var tryGetValueBenchmarkInfo2 = Array.FindAll(benchmarkInfo, p => p.BenchmarkType.GetGenericTypeDefinition() == typeof(Benchmarks.TryGetValueBenchmark<>));
await VisualizeTryGetValueBenchmarks(tryGetValueBenchmarkInfo2);
#endregion

Console.ReadLine();

#region Visualizer Customization
static async Task VisualizeInitializeBenchmarks(BenchmarkInfo[] benchmarkInfo)
{
    if (benchmarkInfo is not { Length: > 0 })
        return;

    var options = new JoinReportHtmlOptions()
    {
        Title = null!, //Set per case
        MainColumn = "Method",
        GroupByColumns = ["Length", "Sorted"],
        PivotProperty = "DataType",
        StatisticColumns = null!, //Set per case
        ColumnsOrder = ["Int32", "String", "StructInts", "ClassInts", "RecordStructInts", "RecordClassInts", "StructStrings", "ClassStrings", "RecordStructStrings", "RecordClassStrings"],
        SpectrumStatisticColumn = true,
        HighlightGroups = true,
        DividerMode = RenderTableDividerMode.SeparateTables,
        HtmlWrapMode = HtmlDocumentWrapMode.RichDataTables,
    };

    options.Title = "Benchmark of Collection Initializing in terms of Execution Time (Mean)";
    options.StatisticColumns = ["Mean"];
    await benchmarkInfo.JoinReportsAndSaveAsHtmlAndImageAsync(
        htmlPath: Path.Combine(DirectoryHelper.GetProjectBenchmarkArtifactsDirectory(), "Benchmark-Initialize-Mean.html"),
        imagePath: Path.Combine(DirectoryHelper.GetProjectBenchmarkArtifactsDirectory(), "Benchmark-Initialize-Mean.webp"),
        options: options);

    options.Title = "Benchmark of Collection Initializing in terms of Allocation Size";
    options.StatisticColumns = ["Allocated"];
    await benchmarkInfo.JoinReportsAndSaveAsHtmlAndImageAsync(
        htmlPath: Path.Combine(DirectoryHelper.GetProjectBenchmarkArtifactsDirectory(), "Benchmark-Initialize-Allocated.html"),
        imagePath: Path.Combine(DirectoryHelper.GetProjectBenchmarkArtifactsDirectory(), "Benchmark-Initialize-Allocated.webp"),
        options: options);
}

static async Task VisualizeContainsBenchmarks(BenchmarkInfo[] benchmarkInfo)
{
    if (benchmarkInfo is not { Length: > 0 })
        return;

    ChangeColorAndNameOfBigOColumn(benchmarkInfo);

    var options = new JoinReportHtmlOptions()
    {
        Title = null!, //Set per case
        MainColumn = "Method",
        GroupByColumns = ["Existed"],
        PivotProperty = "DataType",
        StatisticColumns = null!, //Set per case
        OtherColumnsToSelect = ["Big O", "Length"],
        ColumnsOrder = ["Int32", "String", "StructInts", "ClassInts", "RecordStructInts", "RecordClassInts", "StructStrings", "ClassStrings", "RecordStructStrings", "RecordClassStrings"],
        SpectrumStatisticColumn = true,
        HighlightGroups = true,
        DividerMode = RenderTableDividerMode.SeparateTables,
        HtmlWrapMode = HtmlDocumentWrapMode.RichDataTables,
    };

    options.Title = "Benchmark of Collection Searching (Contains method) in terms of Execution Time (Mean)";
    options.StatisticColumns = ["Mean"];
    await benchmarkInfo.JoinReportsAndSaveAsHtmlAndImageAsync(
        htmlPath: Path.Combine(DirectoryHelper.GetProjectBenchmarkArtifactsDirectory(), "Benchmark-SearchContains-Mean.html"),
        imagePath: Path.Combine(DirectoryHelper.GetProjectBenchmarkArtifactsDirectory(), "Benchmark-SearchContains-Mean.webp"),
        options: options);

    options.Title = "Benchmark of Collection Searching (Contains method) in terms of Allocation Size";
    options.StatisticColumns = ["Allocated"];
    await benchmarkInfo.JoinReportsAndSaveAsHtmlAndImageAsync(
        htmlPath: Path.Combine(DirectoryHelper.GetProjectBenchmarkArtifactsDirectory(), "Benchmark-SearchContains-Allocated.html"),
        imagePath: Path.Combine(DirectoryHelper.GetProjectBenchmarkArtifactsDirectory(), "Benchmark-SearchContains-Allocated.webp"),
        options: options);
}

static async Task VisualizeTryGetValueBenchmarks(BenchmarkInfo[] benchmarkInfo)
{
    if (benchmarkInfo is not { Length: > 0 })
        return;

    ChangeColorAndNameOfBigOColumn(benchmarkInfo);

    var options = new JoinReportHtmlOptions()
    {
        Title = null!, //Set per case
        MainColumn = "Method",
        GroupByColumns = ["Existed"],
        PivotProperty = "DataType",
        StatisticColumns = null!, //Set per case
        OtherColumnsToSelect = ["Big O", "Length"],
        ColumnsOrder = ["Int32", "String", "StructInts", "ClassInts", "RecordStructInts", "RecordClassInts", "StructStrings", "ClassStrings", "RecordStructStrings", "RecordClassStrings"],
        SpectrumStatisticColumn = true,
        HighlightGroups = true,
        DividerMode = RenderTableDividerMode.SeparateTables,
        HtmlWrapMode = HtmlDocumentWrapMode.RichDataTables,
    };

    options.Title = "Benchmark of Collection Searching (TryGetValue method) in terms of Execution Time (Mean)";
    options.StatisticColumns = ["Mean"];
    await benchmarkInfo.JoinReportsAndSaveAsHtmlAndImageAsync(
        htmlPath: Path.Combine(DirectoryHelper.GetProjectBenchmarkArtifactsDirectory(), "Benchmark-SearchTryGetValue-Mean.html"),
        imagePath: Path.Combine(DirectoryHelper.GetProjectBenchmarkArtifactsDirectory(), "Benchmark-SearchTryGetValue-Mean.webp"),
        options: options);

    options.Title = "Benchmark of Collection Searching (TryGetValue method) in terms of Allocation Size";
    options.StatisticColumns = ["Allocated"];
    await benchmarkInfo.JoinReportsAndSaveAsHtmlAndImageAsync(
        htmlPath: Path.Combine(DirectoryHelper.GetProjectBenchmarkArtifactsDirectory(), "Benchmark-SearchTryGetValue-Allocated.html"),
        imagePath: Path.Combine(DirectoryHelper.GetProjectBenchmarkArtifactsDirectory(), "Benchmark-SearchTryGetValue-Allocated.webp"),
        options: options);
}

static void ChangeColorAndNameOfBigOColumn(BenchmarkInfo[] benchmarkInfo)
{
    const string srcPropertyName = "Categories";
    const string destPropertyName = "Big O";

    foreach (var item in benchmarkInfo)
    {
        item.Table = item.Table.Select(expando =>
        {
            if (expando is not null)
            {
                expando.ChangePropertyName(srcPropertyName, destPropertyName);
                expando.TransferColumnOrder(srcPropertyName, destPropertyName);
                var value = expando.GetProperty(destPropertyName).ToString().RemoveMarkdownBold();
                var color = GetColor(value);
                expando.SetMetaProperty($"{destPropertyName}.background-color", color);
            }
            return expando;
        });
    }

    static string GetColor(string value)
    {
        return value switch
        {
            "O(1)" => "#99FF99",
            "O(log(N))" => "#FFFF99",
            "O(N)" => "#FF9999",
            _ => throw new ArgumentOutOfRangeException()
        };
    }
}
#endregion