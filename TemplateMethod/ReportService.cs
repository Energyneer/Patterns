namespace TemplateMethod;

/// <summary>
/// Abstract report service class
/// </summary>
public abstract class ReportService : IReportService
{
    /// <inheritdoc />
    public Report GenerateReport(ICollection<Member> members)
    {
        var selectedMembers = GetMembers(members);

        return new Report
        {
            Header = GetHeader(),
            Count = selectedMembers.Count,
            FullNames = GetFullNameMembers(selectedMembers)
        };
    }

    /// <summary>
    /// Returns a collection of strings with basic information about the member.
    /// </summary>
    /// <param name="members">Collection of members</param>
    /// <returns>Strings containing index and full name</returns>
    private ICollection<string> GetFullNameMembers(ICollection<Member> members)
    {
        return members.Select((m, index) => $"{index + 1}. {m.LastName} {m.FirstName}").ToList();
    }

    /// <summary>
    /// Returns a report title.
    /// </summary>
    /// <returns>Report title</returns>
    protected abstract string GetHeader();

    /// <summary>
    /// Filters the list of members by certain criteria.
    /// </summary>
    /// <param name="members">Collection of all members</param>
    /// <returns>Collection of selected members</returns>
    protected abstract ICollection<Member> GetMembers(ICollection<Member> members);
}