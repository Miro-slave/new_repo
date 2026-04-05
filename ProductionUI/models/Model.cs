using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductionUI.models
{
    public class Model : IModel
    {
        private SqlDataAdapter _productAdapter;
        private DataSet _dataSet;
        private DataTable _dataTable;
        private SqlCommandBuilder _commandBuilder;
        private List<ProductDto> _products;
        private string _sortString = "Name ASC";
        private string _filterString = "";
        public Model()
        {
            string connectionString = "Data Source=localhost\\SQLEXPRESS;Trusted_Connection=True;Connect Timeout=30;Encrypt=False";
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            string selectCommand = "SELECT [ProductId], [Name], [ProductNumber], [SafetyStockLevel] FROM [AdventureWorks2017].[Production].[Product]";

            _productAdapter = new SqlDataAdapter(
                selectCommand,
                connectionString);

            _commandBuilder = new SqlCommandBuilder(_productAdapter);

            _dataSet = new DataSet();
            _productAdapter.Fill(_dataSet, "Product");

            _dataTable = _dataSet.Tables["Product"];

            _products = new List<ProductDto>();

            foreach (DataRow row in _dataTable.Rows)
            {
                ProductDto product = new ProductDto();

                product.Name = row["Name"].ToString();
                product.Number = row["ProductNumber"].ToString();
                product.SafetyStockNumber = uint.Parse(row["SafetyStockLevel"].ToString());

                _products.Add(product);
            }
        }

        public DataView GetData()
        {
            DataView dataView = new DataView(_dataTable);
            dataView.Sort = _sortString;
            dataView.RowFilter = _filterString; 
            return dataView;
        }

        public int TryAdd(ProductDto product)
        {
            DataRow dataRow = _dataTable.NewRow();

            dataRow["Name"] = product.Name;
            dataRow["ProductNumber"] = product.Number;
            dataRow["SafetyStockLevel"] = product.SafetyStockNumber;

            _dataTable.Rows.Add(dataRow);

            try
            {
                _productAdapter.Update(_dataTable);
            }
            catch
            {
                dataRow.Delete();

                return 0;
            }

            _products.Add(product);

            _dataSet.Clear();
            _productAdapter.Fill(_dataSet, "Product");
            _dataTable = _dataSet.Tables["Product"];

            return 1;
        }
        public int TryDelete(ProductDto product)
        {
            DataRow rowToDelete = _dataTable.AsEnumerable().Where(x => x["Name"].ToString() == product.Name).FirstOrDefault();

            if (rowToDelete != null)
            {
                rowToDelete.Delete();
            }

            try
            {
                _productAdapter.Update(_dataTable);
            }
            catch
            {
                rowToDelete.RejectChanges();

                return 0;
            }

            _products.RemoveAll(x => x.Name == product.Name);

            _dataSet.Clear();
            _productAdapter.Fill(_dataSet, "Product");
            _dataTable = _dataSet.Tables["Product"];

            return 1;
        }
        public void Sort(string column, string order)
        {
            _sortString = $"{column} {order}";
        }
        public void Filter(string column, string filter)
        {
            _filterString = $"{column} LIKE '%{filter}%'";
        }
    }
}
