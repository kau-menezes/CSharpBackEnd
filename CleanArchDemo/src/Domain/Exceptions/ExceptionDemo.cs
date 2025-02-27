namespace Server.Domain.Exceptions;

public class ExceptionDemo : Exception
{
    public ExceptionDemo(string text)
    : base("Something bad happends. :(")
}