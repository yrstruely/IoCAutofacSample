using System;

namespace IoCAutofacSample
{
    public interface IOutput
    {
        void Write(string content);
        string Read();
    }

    public class ConsoleOutput : IOutput
    {
        public void Write(string content)
        {
            Console.WriteLine(content);
        }
        
        public string Read()
        {
            return Console.ReadLine();
        }
    }
}
