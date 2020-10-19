using System;

namespace Example2.Services
{
    public class MyDependency : IMyDependency
    {
        public MyDependency()
        {

        }

        public void WriteMessage(string message)
        {
            Console.WriteLine($"MyDependency.WriteMessage called. Message: {message}");
        }
    }
}
