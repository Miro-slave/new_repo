using ProductionUI.presrnters;
using ProductionUI.views;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ProductionUI
{
    public partial class Form1 : Form, IView
    {
        private IPresenter _presenter = null;

        public IPresenter Presenter { set { _presenter = value; } }

        private List<string> _errorMessages;
        public Form1()
        {
            InitializeComponent();

            sortOrderComboBox.DataSource = new List<string> { "ASC", "DESC" };

            dataGridView1.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);

            sortColumnComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            sortOrderComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            filterColumnComboBox.DropDownStyle = ComboBoxStyle.DropDownList;

            errorRichTextBox.ReadOnly = true;

            _errorMessages = new List<string>();
        }

        public void SetPresenter(IPresenter presenter)
        {
            _presenter = presenter;
        }

        public void ViewProduction(DataView production)
        {
            dataGridView1.DataSource = production;

            List<string> columnNames = production.Table.Columns.Cast<DataColumn>().Select(x => x.ColumnName).ToList();
            List<string> stringColumnNames = production.Table.Columns.Cast<DataColumn>().Where(x => x.DataType == typeof(string)).Select(x => x.ColumnName).ToList();

            filterColumnComboBox.DataSource = stringColumnNames;
            sortColumnComboBox.DataSource = columnNames;

            int totalWidth = 18;

            foreach (DataGridViewColumn col in dataGridView1.Columns)
            {
                if (col.Visible)
                {
                    totalWidth += col.Width;
                }
            }

            dataGridView1.Width = totalWidth + (SystemInformation.BorderSize.Width * 2);
        }

        public void ViewErrors()
        {
            errorRichTextBox.Text = string.Join("\n", _errorMessages);
        }

        public void HideErrors()
        {
            errorRichTextBox.Text = null;
        }

        public bool ValidateAdd()
        {
            _errorMessages.Clear();

            if (productNameTextBox.Text.Length == 0)
            {
                _errorMessages.Add("Invalid \"Name\" field\n");
            }

            if (productNumberTextBox.Text.Length == 0)
            {
                _errorMessages.Add("Invalid \"Number\" field\n");
            }

            if (!uint.TryParse(productStockTextBox.Text, out uint productStock))
            {
                _errorMessages.Add("Invalid \"Stock\" field\n");
            }

            return _errorMessages.Count == 0;
        }

        public bool ValidateDelete()
        {
            return ValidateAdd();
        }

        public Dictionary<string, string> ReadValues()
        {
            Dictionary<string, string> values = new Dictionary<string, string>();

            values.Add("Name", productNameTextBox.Text);
            values.Add("Number", productNumberTextBox.Text);
            values.Add("SafetyStockLevel", productStockTextBox.Text);
            values.Add("SortColumn", sortColumnComboBox.Text);
            values.Add("SortOrder", sortOrderComboBox.Text);
            values.Add("FilterColumn", filterColumnComboBox.Text);
            values.Add("FilterPattern", filterTextBox.Text);

            return values;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // comboBox1.SelectedIndex;
        }

        private void insertButton_Click(object sender, EventArgs e)
        {
            _presenter.AddButtonTapped();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            _presenter.DeleteButtonTapped();
        }

        private void applyButton_Click(object sender, EventArgs e)
        {
            _presenter.ApplyFiltersButtonTapped();
        }
    }
}
