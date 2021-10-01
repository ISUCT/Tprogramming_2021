using System;

namespace ConsoleApp1

{
    interface IDateProvider
    {
        string GetDate();
    }
    interface IDateProcessor
    {
        void ProcessorDate(IDateProvider dateProvider);
    }

    class ConsoleDateProcessor : IDateProcessor
    {
        void IDateProcessor.ProcessorDate(IDateProvider dateProvider)
        {
            Console.WriteLine(dateProvider.GetDate());
        }
    }

    class DbDateProvider : IDateProvider
    {
        public string GetDate()
        {
            return "Данные из БД";
        }
    }

    class FileProvider : IDateProvider
    {
        public string GetDate()
        {
            return "Данные из файла";
        }
    }

    class APIDateProvider : IDateProvider
    {
        public string GetDate()
        {
            return "Данные из API";
        }
    }
    class Example
    {
        static void Main(string[] args)
        {
            IDateProcessor dateProcessor = new ConsoleDateProcessor();
            dateProcessor.ProcessorDate(new DbDateProvider());
            dateProcessor.ProcessorDate(new FileProvider());
            dateProcessor.ProcessorDate(new APIDateProvider());
        }
    }
}
