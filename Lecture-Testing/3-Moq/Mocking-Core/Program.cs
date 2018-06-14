using System;
using System.IO;

namespace Mocking_Core
{
    public interface ISaveable
    {
        void Save(string text);
    }

    public class FileSaver : ISaveable
    {
        public void Save(string text)
        {
            File.WriteAllText(Path.GetTempFileName(), text);
        }
    }

    public class Calculator
    {
        private readonly ISaveable _saver;

        public Calculator(ISaveable saver) =>
            _saver = saver ?? throw new ArgumentNullException(nameof(saver));

        public int AddWithSave(int first, int second)
        {
            int result = first + second;
            _saver.Save(result.ToString());
            return result;
        }
    }

    public static class Program
    {
        public static void Main(string[] args)
        {

        }
    }
}