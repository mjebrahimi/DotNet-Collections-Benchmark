using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Order;
using BenchmarkDotNet.Reports;
using BenchmarkDotNet.Running;
using System.Collections.Immutable;

public class CustomConfig : ManualConfig
{
    public CustomConfig()
    {
        Orderer = new CustomOerderer();
        SummaryStyle = DefaultConfig.Instance.SummaryStyle.WithMaxParameterColumnWidth(50);
    }

    private class CustomOerderer : IOrderer
    {
        public IEnumerable<BenchmarkCase> GetExecutionOrder(ImmutableArray<BenchmarkCase> benchmarksCase, IEnumerable<BenchmarkLogicalGroupRule> order = null)
            => benchmarksCase;

        public IEnumerable<BenchmarkCase> GetSummaryOrder(ImmutableArray<BenchmarkCase> benchmarksCases, Summary summary)
            => from benchmarkCase in benchmarksCases
               orderby
                   string.Join('_', benchmarkCase.Descriptor.Categories),
                   benchmarkCase.Parameters["Length"]?.ToString() ?? "",
                   benchmarkCase.Parameters["Sorted"]?.ToString() ?? "",
                   benchmarkCase.Parameters["Existed"]?.ToString() ?? "",
                   summary[benchmarkCase]?.ResultStatistics?.Mean ?? 0
               select benchmarkCase;

        public string GetHighlightGroupKey(BenchmarkCase benchmarkCase)
            => string.Join('_', string.Join('_', benchmarkCase.Descriptor.Categories), benchmarkCase.Parameters["Length"], benchmarkCase.Parameters["Sorted"], benchmarkCase.Parameters["Existed"]);

        public string GetLogicalGroupKey(ImmutableArray<BenchmarkCase> allBenchmarksCases, BenchmarkCase benchmarkCase)
            => string.Join('_', string.Join('_', benchmarkCase.Descriptor.Categories), benchmarkCase.Parameters["Length"], benchmarkCase.Parameters["Sorted"], benchmarkCase.Parameters["Existed"]);

        public IEnumerable<IGrouping<string, BenchmarkCase>> GetLogicalGroupOrder(IEnumerable<IGrouping<string, BenchmarkCase>> logicalGroups, IEnumerable<BenchmarkLogicalGroupRule> order = null)
            => logicalGroups.OrderBy(it => it.Key);

        public bool SeparateLogicalGroups => true;
    }
}