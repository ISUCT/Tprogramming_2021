using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceTesting
{
    interface IDataProvider
    {
        string GetDate();

    }

    interface IDateProcessor
    {
        void ProcessorDate(IDataProvider dateProvider);
    }
}
