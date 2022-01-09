using System;

namespace testInterface

{

    class ConsoleDateProcessor : IDateProcessor
    {
        void IDateProcessor.ProcessorDate(IDataProvider dateProvider)
        {
            Console.WriteLine(dateProvider.GetDate());
        }
    }

    class DbDateProvider : IDataProvider
    {
        public string GetDate()
        {
            return "Данные из БД";
        }
    }

    class FileProvider : IDataProvider
    {
        public string GetDate()
        {
            return "Данные из файла";
        }
    }

    class APIDataProvider : IDataProvider
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
            dateProcessor.ProcessorDate(new APIDataProvider());
        }
    }
}
