using Microsoft.VisualBasic;
using System.Data;
using System.Windows.Forms;
using System.Xml.Linq;
using Microsoft.Data.Sqlite;

namespace FurnitureStoreDBMS
{
    public partial class MainForm : Form
    {
        DBService dBService;

        public MainForm(DBService dBService)
        {
            InitializeComponent();
            this.dBService = dBService;
        }

        private void furnitureArrivalButton_Click(object sender, EventArgs e)
        {
            try
            {
                string name = Interaction.InputBox("Введите название мебели", "Приход мебели", "");
                int type = DropDownDialogService.InputBox("Выберите тип мебели", "Приход мебели", dBService.GetAllFurnitureTypes());
                int supplier = DropDownDialogService.InputBox("Выберите поставщика", "Приход мебели", dBService.GetAllSupliers());
                int count = int.Parse(Interaction.InputBox("Введите количество", "Приход мебели", ""));
                int price = int.Parse(Interaction.InputBox("Введите цену за ШТ", "Приход мебели", ""));
                DateTime dateTime = DateTime.Now;

                dBService.AddFurnitureArrival(name, type, supplier, count, price, dateTime.ToString("HH:mm:ss dd-MM-yyyy"));

                MessageBox.Show("Успешно выполнено!");
            }
            catch
            {
                MessageBox.Show("Ошибка");
            }
        }

        private void furnitureSaleButton_Click(object sender, EventArgs e)
        {
            try
            {
                int furnitureArrivalId = DropDownDialogService.InputBox("Выберите продаваемую мебель", "Продажа мебели", dBService.GetAllFurnitureArrivalRecords());
                int type = DropDownDialogService.InputBox("Выберите тип мебели", "Продажа мебели", dBService.GetAllFurnitureTypes());
                int ammount = int.Parse(Interaction.InputBox("Введите количество продаваемой мебели", "Продажа мебели", ""));
                int shopId = DropDownDialogService.InputBox("Выберите магазин", "Продажа мебели", dBService.GetAllShops());
                int customerId = DropDownDialogService.InputBox("Выберите покупателя", "Продажа мебели", dBService.GetAllCustomers());

                dBService.AddFurnitureSale(furnitureArrivalId, type, ammount, shopId, customerId);

                MessageBox.Show("Успешно выполнено!");

                string check = "ЧЕК ПОКУПАТЕЛЯ\n" +
                    "--------------\n" +
                    $"furnitureArrivalId = {furnitureArrivalId}\n" +
                    $"type = {type}\n" +
                    $"ammount = {ammount}\n" +
                    $"shopId = {shopId}\n" +
                    $"customerId = {customerId}\n";

                MessageBox.Show(check);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка " + ex.Message);
            }
        }

        private void furnitureRefundButton_Click(object sender, EventArgs e)
        {
            try
            {
                int furnitureArrivalId = DropDownDialogService.InputBox("Выберите возвращаемую мебель", "Возврат мебели", dBService.GetAllFurnitureArrivalRecords());
                int type = DropDownDialogService.InputBox("Выберите тип мебели", "Возврат мебели", dBService.GetAllFurnitureTypes());
                int ammount = int.Parse(Interaction.InputBox("Введите количество возвращаемой мебели", "Возврат мебели", ""));
                int shopId = DropDownDialogService.InputBox("Выберите магазин", "Возврат мебели", dBService.GetAllShops());
                int customerId = DropDownDialogService.InputBox("Выберите покупателя", "Возврат мебели", dBService.GetAllCustomers());
                string refundReason = Interaction.InputBox("Причина возврата", "Возврат мебели", "");

                dBService.AddFurnitureRefund(furnitureArrivalId, type, ammount, shopId, refundReason);

                MessageBox.Show("Успешно выполнено!");
            }
            catch
            {
                MessageBox.Show("Ошибка");
            }
        }

        private void AddShopButton_Click(object sender, EventArgs e)
        {
            try
            {
                string name = Interaction.InputBox("Введите название магазина", "Добавить Магазин", "");
                string address = Interaction.InputBox("Введите адрес магазина", "Добавить Магазин", "");
                string chiefName = Interaction.InputBox("Введите имя заведующего", "Добавить Магазин", "");
                string chiefPhone = Interaction.InputBox("Введите телефон заведующего", "Добавить Магазин", "");
                dBService.AddShop(name, address, chiefName, chiefPhone);

                MessageBox.Show("Успешно выполнено!");
            }
            catch
            {
                MessageBox.Show("Ошибка");
            }
        }

        private void addSupplierButton_Click(object sender, EventArgs e)
        {
            try
            {
                string name = Interaction.InputBox("Введите название поставщика", "Добавить Поставщика", "");
                dBService.AddSupplier(name);
                MessageBox.Show("Успешно выполнено!");
            }
            catch
            {
                MessageBox.Show("Ошибка");
            }
        }

        private void AddFurnitureTypeButon_Click(object sender, EventArgs e)
        {
            try
            {
                string name = Interaction.InputBox("Введите название типа мебели", "Добавить Тип Мебели", "");
                dBService.AddFurnitureType(name);
                MessageBox.Show("Успешно выполнено!");
            }
            catch
            {
                MessageBox.Show("Ошибка");
            }
        }

        private void AddCustomerButton_Click(object sender, EventArgs e)
        {
            try
            {
                string name = Interaction.InputBox("Введите название покупателя", "Добавить Покупателя", "");
                dBService.AddCustomer(name);
                MessageBox.Show("Успешно выполнено!");
            }
            catch
            {
                MessageBox.Show("Ошибка");
            }
        }

        private void tableSelectButton_Click(object sender, EventArgs e)
        {
            UpdateSQLTable();
        }

        private void sqlCommandTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void UpdateSQLTable()
        {
            string sql = sqlCommandTextBox.Text;
            var reader = dBService.DBFacade.ExecuteReaderCommand(sql);


            var table = new DataTable();
            table.Load(reader);

            dataGridView.DataSource = table;
        }

        private void showCustomersButton_Click(object sender, EventArgs e)
        {
            sqlCommandTextBox.Text = "SELECT * FROM customers";
            UpdateSQLTable();
        }

        private void showShopsButton_Click(object sender, EventArgs e)
        {
            sqlCommandTextBox.Text = "SELECT * FROM shops";
            UpdateSQLTable();
        }

        private void showFurnitureTypesButton_Click(object sender, EventArgs e)
        {
            sqlCommandTextBox.Text = "SELECT * FROM furnitureTypes";
            UpdateSQLTable();
        }

        private void showSuppliersButton_Click(object sender, EventArgs e)
        {
            sqlCommandTextBox.Text = "SELECT * FROM suppliers";
            UpdateSQLTable();
        }

        private void showFurnitureArrivalButton_Click(object sender, EventArgs e)
        {
            sqlCommandTextBox.Text = "SELECT * FROM furnitureArrival";
            UpdateSQLTable();
        }

        private void showFurnitureSaleButton_Click(object sender, EventArgs e)
        {
            sqlCommandTextBox.Text = "SELECT * FROM furnitureSale";
            UpdateSQLTable();
        }

        private void showFurnitureRefundButton_Click(object sender, EventArgs e)
        {
            sqlCommandTextBox.Text = "SELECT * FROM furnitureRefund";
            UpdateSQLTable();
        }
    }
}
