namespace TemplateMethod;

public class Program
{
    static void Main(string[] args)
    {
        PrintReportInConsole(new Report());
    }

    /// <summary>
    /// Prints the contents of the report to Console
    /// </summary>
    /// <param name="report">Report entity</param>
    private static void PrintReportInConsole(Report report)
    {
        var horizontalLine = new string('-', Console.WindowWidth);
        Console.Clear();
        Console.WriteLine(horizontalLine);
    }
}