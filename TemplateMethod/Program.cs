using System.Text;

namespace TemplateMethod;

public class Program
{
    static void Main(string[] args)
    {
        var members = CreateTestMembers();
        var services = GetReportServices();
        foreach (var service in services)
        {
            var report = service.GenerateReport(members);
            PrintReportInConsole(report);
        }
    }

    /// <summary>
    /// Prints the contents of the report to Console
    /// </summary>
    /// <param name="report">Report entity</param>
    private static void PrintReportInConsole(Report report)
    {
        var horizontalLine = new string('-', Console.WindowWidth);
        var builder = new StringBuilder(horizontalLine);
        builder.AppendLine(report.Header);
        builder.AppendLine($"Members: {report.Count}");
        builder.AppendJoin("\n", report.FullNames);
        builder.AppendLine();

        Console.WriteLine(builder.ToString());
    }

    /// <summary>
    /// Creates a test members collection.
    /// </summary>
    /// <returns>Collection of members</returns>
    private static ICollection<Member> CreateTestMembers()
    {
        return new List<Member>
        {
            new Member
            {
                FirstName = "James",
                LastName = "Williams",
                State = MemberState.Registered
            },
            new Member
            {
                FirstName = "Patricia",
                LastName = "Miller",
                State = MemberState.Registered
            },
            new Member
            {
                FirstName = "Mary",
                LastName = "Johnson",
                State = MemberState.Registered
            },
            new Member
            {
                FirstName = "David",
                LastName = "Brown",
                State = MemberState.Confirm
            },
            new Member
            {
                FirstName = "Margaret",
                LastName = "Garcia",
                State = MemberState.Confirm
            },
            new Member
            {
                FirstName = "Thomas",
                LastName = "Wilson",
                State = MemberState.Finished
            },
        };
    }

    /// <summary>
    /// Creates a different report services.
    /// </summary>
    /// <returns>Collection of report services</returns>
    private static ICollection<IReportService> GetReportServices()
    {
        return new List<IReportService>()
        {
            new ReportServiceForRegistered(), new ReportServiceForConfirmed(), new ReportServiceForFinished()
        };
    }
}