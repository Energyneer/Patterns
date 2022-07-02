namespace TemplateMethod;

/// <summary>
/// Member of the site
/// </summary>
public class Member
{
    /// <summary>
    /// First name of member
    /// </summary>
    public string FirstName { get; set; }

    /// <summary>
    /// Last name of member
    /// </summary>
    public string LastName { get; set; }

    /// <summary>
    /// Current step of member
    /// </summary>
    public MemberState State { get; set; }
}

/// <summary>
/// State of request
/// </summary>
public enum MemberState
{
    /// <summary>
    /// Registered on the site
    /// </summary>
    Registered = 1,

    /// <summary>
    /// Confirmed own data
    /// </summary>
    Confirm = 2,

    /// <summary>
    /// Got an invitation
    /// </summary>
    Finished = 3
}