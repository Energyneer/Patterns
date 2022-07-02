namespace TemplateMethod;

/// <summary>
/// Output entry of report
/// </summary>
public class Report
{
    /// <summary>
    /// Header of report
    /// </summary>
    public string Header { get; set; }

    /// <summary>
    /// Number of members in the report
    /// </summary>
    public int Count { get; set; }

    /// <summary>
    /// Full names of all members in the report
    /// </summary>
    public IEnumerable<string> FullNames { get; set; }
}