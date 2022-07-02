namespace TemplateMethod;

public class ReportServiceForRegistered : ReportService
{
    /// <inheritdoc />
    protected override string GetHeader()
    {
        return "Report on registered members.";
    }

    /// <inheritdoc />
    protected override ICollection<Member> GetMembers(ICollection<Member> members)
    {
        return members.Where(m => m.State == MemberState.Registered).ToList();
    }
}