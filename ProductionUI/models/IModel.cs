using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductionUI.models
{
    public interface IModel
    {
        DataView GetData();

        int TryAdd(ProductDto product);

        int TryDelete(ProductDto product);

        void Sort(string column, string order);

        void Filter(string column, string filter);
    }
}
