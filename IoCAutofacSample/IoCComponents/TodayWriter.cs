using System;

namespace IoCAutofacSample
{
    public interface IDateWriter
    {
        void WriteDate();
    }

    public class TodayWriter : IDateWriter
    {
        private IOutput output;

        public TodayWriter(IOutput output)
        {
            this.output = output;
        }

        public void WriteDate()
        {
            output.Write(DateTime.Today.ToShortDateString());
            output.Read();
        }
    }
}
