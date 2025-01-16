using System;
using SolidPrinciples.Interface;

namespace SolidPrinciples
{
    internal class Logger : ILogger
    {   
        public string Debug(string message, Exception ex)
        {
            Console.WriteLine(message, ex);
            return message;
        }

        public string Error(string message)
        {
            return message;
        }

        public string Info(string message)
        {
           
            return message;
        }
    }
}
