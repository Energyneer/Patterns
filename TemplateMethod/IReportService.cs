namespace TemplateMethod;

public interface IReportService
{
    /// <summary>
    /// Generates a user report.
    /// </summary>
    /// <param name="members">Members collection</param>
    /// <returns>Report entity</returns>
    Report GenerateReport(ICollection<Member> members);
}