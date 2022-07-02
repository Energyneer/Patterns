namespace TemplateMethod;

public class ReportServiceForFinished : ReportService
{
    /// <inheritdoc />
    protected override string GetHeader()
    {
        return "Report on registered, confirmed and finished members.";
    }

    /// <inheritdoc />
    protected override ICollection<Member> GetMembers(ICollection<Member> members)
    {
        return members.Where(m =>
                m.State == MemberState.Registered || m.State == MemberState.Confirm || m.State == MemberState.Finished)
            .ToList();
    }
}