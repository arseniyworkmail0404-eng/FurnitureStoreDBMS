namespace FurnitureStoreDBMS
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            furnitureArrivalButton = new Button();
            furnitureSaleButton = new Button();
            furnitureRefundButton = new Button();
            addSupplierButton = new Button();
            AddFurnitureTypeButon = new Button();
            AddShopButton = new Button();
            AddCustomerButton = new Button();
            dataGridView = new DataGridView();
            tableSelectButton = new Button();
            sqlCommandTextBox = new TextBox();
            showShopsButton = new Button();
            showCustomersButton = new Button();
            showFurnitureTypesButton = new Button();
            showSuppliersButton = new Button();
            showFurnitureRefundButton = new Button();
            showFurnitureSaleButton = new Button();
            showFurnitureArrivalButton = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // furnitureArrivalButton
            // 
            furnitureArrivalButton.Location = new Point(170, 13);
            furnitureArrivalButton.Name = "furnitureArrivalButton";
            furnitureArrivalButton.Size = new Size(152, 23);
            furnitureArrivalButton.TabIndex = 0;
            furnitureArrivalButton.Text = "Добавить Приход";
            furnitureArrivalButton.UseVisualStyleBackColor = true;
            furnitureArrivalButton.Click += furnitureArrivalButton_Click;
            // 
            // furnitureSaleButton
            // 
            furnitureSaleButton.Location = new Point(170, 42);
            furnitureSaleButton.Name = "furnitureSaleButton";
            furnitureSaleButton.Size = new Size(152, 23);
            furnitureSaleButton.TabIndex = 0;
            furnitureSaleButton.Text = "Добавить Продажу";
            furnitureSaleButton.UseVisualStyleBackColor = true;
            furnitureSaleButton.Click += furnitureSaleButton_Click;
            // 
            // furnitureRefundButton
            // 
            furnitureRefundButton.Location = new Point(170, 71);
            furnitureRefundButton.Name = "furnitureRefundButton";
            furnitureRefundButton.Size = new Size(152, 23);
            furnitureRefundButton.TabIndex = 0;
            furnitureRefundButton.Text = "Добавить Возврат";
            furnitureRefundButton.UseVisualStyleBackColor = true;
            furnitureRefundButton.Click += furnitureRefundButton_Click;
            // 
            // addSupplierButton
            // 
            addSupplierButton.Location = new Point(170, 168);
            addSupplierButton.Name = "addSupplierButton";
            addSupplierButton.Size = new Size(152, 23);
            addSupplierButton.TabIndex = 1;
            addSupplierButton.Text = "Добавить Поставщика";
            addSupplierButton.UseVisualStyleBackColor = true;
            addSupplierButton.Click += addSupplierButton_Click;
            // 
            // AddFurnitureTypeButon
            // 
            AddFurnitureTypeButon.Location = new Point(170, 197);
            AddFurnitureTypeButon.Name = "AddFurnitureTypeButon";
            AddFurnitureTypeButon.Size = new Size(152, 23);
            AddFurnitureTypeButon.TabIndex = 1;
            AddFurnitureTypeButon.Text = "Добавить Тип Мебели";
            AddFurnitureTypeButon.UseVisualStyleBackColor = true;
            AddFurnitureTypeButon.Click += AddFurnitureTypeButon_Click;
            // 
            // AddShopButton
            // 
            AddShopButton.Location = new Point(170, 226);
            AddShopButton.Name = "AddShopButton";
            AddShopButton.Size = new Size(152, 23);
            AddShopButton.TabIndex = 1;
            AddShopButton.Text = "Добавить Магазин";
            AddShopButton.UseVisualStyleBackColor = true;
            AddShopButton.Click += AddShopButton_Click;
            // 
            // AddCustomerButton
            // 
            AddCustomerButton.Location = new Point(170, 255);
            AddCustomerButton.Name = "AddCustomerButton";
            AddCustomerButton.Size = new Size(152, 23);
            AddCustomerButton.TabIndex = 2;
            AddCustomerButton.Text = "Добавить Покупателя";
            AddCustomerButton.UseVisualStyleBackColor = true;
            AddCustomerButton.Click += AddCustomerButton_Click;
            // 
            // dataGridView
            // 
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Location = new Point(328, 43);
            dataGridView.Name = "dataGridView";
            dataGridView.Size = new Size(800, 400);
            dataGridView.TabIndex = 3;
            // 
            // tableSelectButton
            // 
            tableSelectButton.Location = new Point(1053, 13);
            tableSelectButton.Name = "tableSelectButton";
            tableSelectButton.Size = new Size(75, 23);
            tableSelectButton.TabIndex = 4;
            tableSelectButton.Text = "Update";
            tableSelectButton.UseVisualStyleBackColor = true;
            tableSelectButton.Click += tableSelectButton_Click;
            // 
            // sqlCommandTextBox
            // 
            sqlCommandTextBox.AcceptsReturn = true;
            sqlCommandTextBox.Location = new Point(328, 13);
            sqlCommandTextBox.Name = "sqlCommandTextBox";
            sqlCommandTextBox.Size = new Size(719, 23);
            sqlCommandTextBox.TabIndex = 5;
            sqlCommandTextBox.TextChanged += sqlCommandTextBox_TextChanged;
            // 
            // showShopsButton
            // 
            showShopsButton.Location = new Point(12, 226);
            showShopsButton.Name = "showShopsButton";
            showShopsButton.Size = new Size(152, 23);
            showShopsButton.TabIndex = 6;
            showShopsButton.Text = "Магазины";
            showShopsButton.UseVisualStyleBackColor = true;
            showShopsButton.Click += showShopsButton_Click;
            // 
            // showCustomersButton
            // 
            showCustomersButton.Location = new Point(12, 255);
            showCustomersButton.Name = "showCustomersButton";
            showCustomersButton.Size = new Size(152, 23);
            showCustomersButton.TabIndex = 6;
            showCustomersButton.Text = "Покупатели";
            showCustomersButton.UseVisualStyleBackColor = true;
            showCustomersButton.Click += showCustomersButton_Click;
            // 
            // showFurnitureTypesButton
            // 
            showFurnitureTypesButton.Location = new Point(12, 197);
            showFurnitureTypesButton.Name = "showFurnitureTypesButton";
            showFurnitureTypesButton.Size = new Size(152, 23);
            showFurnitureTypesButton.TabIndex = 6;
            showFurnitureTypesButton.Text = "Типы Мебели";
            showFurnitureTypesButton.UseVisualStyleBackColor = true;
            showFurnitureTypesButton.Click += showFurnitureTypesButton_Click;
            // 
            // showSuppliersButton
            // 
            showSuppliersButton.Location = new Point(12, 168);
            showSuppliersButton.Name = "showSuppliersButton";
            showSuppliersButton.Size = new Size(152, 23);
            showSuppliersButton.TabIndex = 6;
            showSuppliersButton.Text = "Поставщики";
            showSuppliersButton.UseVisualStyleBackColor = true;
            showSuppliersButton.Click += showSuppliersButton_Click;
            // 
            // showFurnitureRefundButton
            // 
            showFurnitureRefundButton.Location = new Point(12, 71);
            showFurnitureRefundButton.Name = "showFurnitureRefundButton";
            showFurnitureRefundButton.Size = new Size(152, 23);
            showFurnitureRefundButton.TabIndex = 7;
            showFurnitureRefundButton.Text = "Возврат Мебели";
            showFurnitureRefundButton.UseVisualStyleBackColor = true;
            showFurnitureRefundButton.Click += showFurnitureRefundButton_Click;
            // 
            // showFurnitureSaleButton
            // 
            showFurnitureSaleButton.Location = new Point(12, 42);
            showFurnitureSaleButton.Name = "showFurnitureSaleButton";
            showFurnitureSaleButton.Size = new Size(152, 23);
            showFurnitureSaleButton.TabIndex = 7;
            showFurnitureSaleButton.Text = "Продажа Мебели";
            showFurnitureSaleButton.UseVisualStyleBackColor = true;
            showFurnitureSaleButton.Click += showFurnitureSaleButton_Click;
            // 
            // showFurnitureArrivalButton
            // 
            showFurnitureArrivalButton.Location = new Point(12, 13);
            showFurnitureArrivalButton.Name = "showFurnitureArrivalButton";
            showFurnitureArrivalButton.Size = new Size(152, 23);
            showFurnitureArrivalButton.TabIndex = 7;
            showFurnitureArrivalButton.Text = "Приход Мебели";
            showFurnitureArrivalButton.UseVisualStyleBackColor = true;
            showFurnitureArrivalButton.Click += showFurnitureArrivalButton_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1144, 461);
            Controls.Add(showFurnitureArrivalButton);
            Controls.Add(showFurnitureSaleButton);
            Controls.Add(showFurnitureRefundButton);
            Controls.Add(showSuppliersButton);
            Controls.Add(showFurnitureTypesButton);
            Controls.Add(showCustomersButton);
            Controls.Add(showShopsButton);
            Controls.Add(sqlCommandTextBox);
            Controls.Add(tableSelectButton);
            Controls.Add(dataGridView);
            Controls.Add(AddCustomerButton);
            Controls.Add(AddShopButton);
            Controls.Add(AddFurnitureTypeButon);
            Controls.Add(addSupplierButton);
            Controls.Add(furnitureRefundButton);
            Controls.Add(furnitureSaleButton);
            Controls.Add(furnitureArrivalButton);
            Name = "MainForm";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button furnitureArrivalButton;
        private Button furnitureSaleButton;
        private Button furnitureRefundButton;
        private Button addSupplierButton;
        private Button AddFurnitureTypeButon;
        private Button AddShopButton;
        private Button AddCustomerButton;
        private DataGridView dataGridView;
        private Button tableSelectButton;
        private TextBox sqlCommandTextBox;
        private Button showShopsButton;
        private Button showCustomersButton;
        private Button showFurnitureTypesButton;
        private Button showSuppliersButton;
        private Button showFurnitureRefundButton;
        private Button showFurnitureSaleButton;
        private Button showFurnitureArrivalButton;
    }
}
