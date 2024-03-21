namespace Ksh.ProjectName.Abstractions.Exceptions;

[ExcludeFromCodeCoverage]
public class ProjectNameException : Exception
{
    public ProjectNameException()
    {
    }

    public ProjectNameException(string message) : base(message)
    {
    }

    public ProjectNameException(string message, Exception inner) : base(message, inner)
    {
    }
}