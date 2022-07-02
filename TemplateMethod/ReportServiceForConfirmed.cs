namespace TemplateMethod;

public class ReportServiceForConfirmed : ReportService
{
    /// <inheritdoc />
    protected override string GetHeader()
    {
        return "Report on registered and confirmed members.";
    }

    /// <inheritdoc />
    protected override ICollection<Member> GetMembers(ICollection<Member> members)
    {
        return members.Where(m => m.State == MemberState.Registered || m.State == MemberState.Confirm).ToList();
    }
}