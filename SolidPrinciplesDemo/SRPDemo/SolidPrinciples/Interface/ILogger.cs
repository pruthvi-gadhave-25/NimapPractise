using System;

namespace SolidPrinciples.Interface
{
    public interface ILogger
    {
        string Info(string message);
        string Error(string message);
        string Debug(string message,Exception ex) ;
    }
}
