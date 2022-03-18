using System;

public class ErrorException : System.Exception
{
    public ErrorException() { }
    public ErrorException(string message) : base(message) { }
    public ErrorException(string message, System.Exception inner) : base(message, inner) { }
    protected ErrorException(
        System.Runtime.Serialization.SerializationInfo info,
        System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
}