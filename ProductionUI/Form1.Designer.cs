namespace ProductionUI
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.sortOrderComboBox = new System.Windows.Forms.ComboBox();
            this.productNameTextBox = new System.Windows.Forms.TextBox();
            this.productNumberTextBox = new System.Windows.Forms.TextBox();
            this.productStockTextBox = new System.Windows.Forms.TextBox();
            this.insertButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.nameLabel = new System.Windows.Forms.Label();
            this.numberLabel = new System.Windows.Forms.Label();
            this.stockLabel = new System.Windows.Forms.Label();
            this.sortLabel = new System.Windows.Forms.Label();
            this.applyButton = new System.Windows.Forms.Button();
            this.filterLabel = new System.Windows.Forms.Label();
            this.filterColumnComboBox = new System.Windows.Forms.ComboBox();
            this.filterTextBox = new System.Windows.Forms.TextBox();
            this.sortColumnComboBox = new System.Windows.Forms.ComboBox();
            this.errorRichTextBox = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(369, 101);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(240, 326);
            this.dataGridView1.TabIndex = 0;
            // 
            // sortOrderComboBox
            // 
            this.sortOrderComboBox.Items.AddRange(new object[] {
            "ASC",
            "DESC"});
            this.sortOrderComboBox.Location = new System.Drawing.Point(1033, 114);
            this.sortOrderComboBox.Name = "sortOrderComboBox";
            this.sortOrderComboBox.Size = new System.Drawing.Size(121, 28);
            this.sortOrderComboBox.TabIndex = 1;
            this.sortOrderComboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // productNameTextBox
            // 
            this.productNameTextBox.Location = new System.Drawing.Point(74, 101);
            this.productNameTextBox.Name = "productNameTextBox";
            this.productNameTextBox.Size = new System.Drawing.Size(108, 26);
            this.productNameTextBox.TabIndex = 2;
            // 
            // productNumberTextBox
            // 
            this.productNumberTextBox.Location = new System.Drawing.Point(74, 184);
            this.productNumberTextBox.Name = "productNumberTextBox";
            this.productNumberTextBox.Size = new System.Drawing.Size(108, 26);
            this.productNumberTextBox.TabIndex = 3;
            // 
            // productStockTextBox
            // 
            this.productStockTextBox.Location = new System.Drawing.Point(74, 257);
            this.productStockTextBox.Name = "productStockTextBox";
            this.productStockTextBox.Size = new System.Drawing.Size(108, 26);
            this.productStockTextBox.TabIndex = 4;
            // 
            // insertButton
            // 
            this.insertButton.Location = new System.Drawing.Point(74, 341);
            this.insertButton.Name = "insertButton";
            this.insertButton.Size = new System.Drawing.Size(75, 33);
            this.insertButton.TabIndex = 5;
            this.insertButton.Text = "Insert";
            this.insertButton.UseVisualStyleBackColor = true;
            this.insertButton.Click += new System.EventHandler(this.insertButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(74, 394);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(75, 33);
            this.deleteButton.TabIndex = 6;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(70, 56);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(51, 20);
            this.nameLabel.TabIndex = 7;
            this.nameLabel.Text = "Name";
            // 
            // numberLabel
            // 
            this.numberLabel.AutoSize = true;
            this.numberLabel.Location = new System.Drawing.Point(70, 150);
            this.numberLabel.Name = "numberLabel";
            this.numberLabel.Size = new System.Drawing.Size(65, 20);
            this.numberLabel.TabIndex = 8;
            this.numberLabel.Text = "Number";
            // 
            // stockLabel
            // 
            this.stockLabel.AutoSize = true;
            this.stockLabel.Location = new System.Drawing.Point(70, 225);
            this.stockLabel.Name = "stockLabel";
            this.stockLabel.Size = new System.Drawing.Size(50, 20);
            this.stockLabel.TabIndex = 9;
            this.stockLabel.Text = "Stock";
            // 
            // sortLabel
            // 
            this.sortLabel.AutoSize = true;
            this.sortLabel.Location = new System.Drawing.Point(1043, 71);
            this.sortLabel.Name = "sortLabel";
            this.sortLabel.Size = new System.Drawing.Size(39, 20);
            this.sortLabel.TabIndex = 10;
            this.sortLabel.Text = "Sort";
            // 
            // applyButton
            // 
            this.applyButton.Location = new System.Drawing.Point(1031, 362);
            this.applyButton.Name = "applyButton";
            this.applyButton.Size = new System.Drawing.Size(75, 33);
            this.applyButton.TabIndex = 11;
            this.applyButton.Text = "Apply";
            this.applyButton.UseVisualStyleBackColor = true;
            this.applyButton.Click += new System.EventHandler(this.applyButton_Click);
            // 
            // filterLabel
            // 
            this.filterLabel.AutoSize = true;
            this.filterLabel.Location = new System.Drawing.Point(1027, 211);
            this.filterLabel.Name = "filterLabel";
            this.filterLabel.Size = new System.Drawing.Size(44, 20);
            this.filterLabel.TabIndex = 12;
            this.filterLabel.Text = "Filter";
            // 
            // filterColumnComboBox
            // 
            this.filterColumnComboBox.FormattingEnabled = true;
            this.filterColumnComboBox.Items.AddRange(new object[] {
            "Name",
            "Number",
            "Stock"});
            this.filterColumnComboBox.Location = new System.Drawing.Point(1031, 254);
            this.filterColumnComboBox.Name = "filterColumnComboBox";
            this.filterColumnComboBox.Size = new System.Drawing.Size(121, 28);
            this.filterColumnComboBox.TabIndex = 13;
            // 
            // filterTextBox
            // 
            this.filterTextBox.Location = new System.Drawing.Point(1031, 314);
            this.filterTextBox.Name = "filterTextBox";
            this.filterTextBox.Size = new System.Drawing.Size(100, 26);
            this.filterTextBox.TabIndex = 14;
            // 
            // sortColumnComboBox
            // 
            this.sortColumnComboBox.FormattingEnabled = true;
            this.sortColumnComboBox.Location = new System.Drawing.Point(1033, 153);
            this.sortColumnComboBox.Name = "sortColumnComboBox";
            this.sortColumnComboBox.Size = new System.Drawing.Size(121, 28);
            this.sortColumnComboBox.TabIndex = 15;
            // 
            // errorRichTextBox
            // 
            this.errorRichTextBox.Location = new System.Drawing.Point(1242, 114);
            this.errorRichTextBox.Name = "errorRichTextBox";
            this.errorRichTextBox.Size = new System.Drawing.Size(221, 313);
            this.errorRichTextBox.TabIndex = 16;
            this.errorRichTextBox.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1502, 569);
            this.Controls.Add(this.errorRichTextBox);
            this.Controls.Add(this.sortColumnComboBox);
            this.Controls.Add(this.filterTextBox);
            this.Controls.Add(this.filterColumnComboBox);
            this.Controls.Add(this.filterLabel);
            this.Controls.Add(this.applyButton);
            this.Controls.Add(this.sortLabel);
            this.Controls.Add(this.stockLabel);
            this.Controls.Add(this.numberLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.insertButton);
            this.Controls.Add(this.productStockTextBox);
            this.Controls.Add(this.productNumberTextBox);
            this.Controls.Add(this.productNameTextBox);
            this.Controls.Add(this.sortOrderComboBox);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox sortOrderComboBox;
        private System.Windows.Forms.TextBox productNameTextBox;
        private System.Windows.Forms.TextBox productNumberTextBox;
        private System.Windows.Forms.TextBox productStockTextBox;
        private System.Windows.Forms.Button insertButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label numberLabel;
        private System.Windows.Forms.Label stockLabel;
        private System.Windows.Forms.Label sortLabel;
        private System.Windows.Forms.Button applyButton;
        private System.Windows.Forms.Label filterLabel;
        private System.Windows.Forms.ComboBox filterColumnComboBox;
        private System.Windows.Forms.TextBox filterTextBox;
        private System.Windows.Forms.ComboBox sortColumnComboBox;
        private System.Windows.Forms.RichTextBox errorRichTextBox;
    }
}

