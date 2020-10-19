using System;

namespace Example1.Services
{
    public class MyDependency
    {
        public void WriteMessage(string message)
        {
            Console.WriteLine($"MyDependency.WriteMessage called. Message: {message}");
        }
    }
}
