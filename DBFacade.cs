using Microsoft.Data.Sqlite;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace FurnitureStoreDBMS
{
    public class DBFacade : IDBFacade
    {
        private SqliteConnection connection;

        public DBFacade(string dbPath)
        {
            connection = new SqliteConnection(dbPath);
        }

        public void ExecuteVoidCommand(string sqlCommand, params (string name, object value)[] parameters)
        {
            using (var command = new SqliteCommand(sqlCommand, connection))
            {
                connection.Open();
                foreach (var parameter in parameters)
                {
                    command.Parameters.AddWithValue(parameter.name, parameter.value);
                }
                command.ExecuteNonQuery();
            }
        }

        public SqliteDataReader ExecuteReaderCommand(string sqlCommand)
        {
            var command = new SqliteCommand(sqlCommand, connection);
            connection.Open();
            return command.ExecuteReader(CommandBehavior.CloseConnection);
        }

        public string[][] Select(string sqlCommand)
        {
            var command = new SqliteCommand(sqlCommand, connection);
            connection.Open();

            List<string[]> table = new List<string[]>();

            using (var reader = command.ExecuteReader(CommandBehavior.CloseConnection))
            {

                while (reader.Read())
                {
                    string[] values = new string[reader.FieldCount];

                    for (int i = 0; i != reader.FieldCount; i++)
                    {
                        values[i] = reader.GetValue(i).ToString();
                    }

                    table.Add(values);
                }

            }

            return table.ToArray();
        }

    }


    public interface IDBFacade
    {
        void ExecuteVoidCommand(string sqlCommand, params (string name, object value)[] parameters);
        SqliteDataReader ExecuteReaderCommand(string sqlCommand);
        string[][] Select(string sqlComman);
    }
    public class DBInstaller
    {
        IDBFacade dBFacade;
        public void Install(IDBFacade dBFacade)
        {
            this.dBFacade = dBFacade;
            CreateTable_FurnitureArrival();
            CreateTable_FurnitureSale();
            CreateTable_FurnitureRefund();
            CreateTable_Suppliers();
            CreateTable_FurnitureTypes();
            CreateTable_Shops();
            CreateTable_Customers();
        }

        public void CreateTable_FurnitureArrival()
        {
            string sql = @"
            CREATE TABLE IF NOT EXISTS furnitureArrival (
                id INTEGER PRIMARY KEY AUTOINCREMENT,
                name TEXT NOT NULL,
                typeId INTEGER NOT NULL,
                supplierId INTEGER NOT NULL,
                ammount INTEGER NOT NULL,
                price INTEGER NOT NULL,
                date TEXT NOT NULL
            )";

            dBFacade.ExecuteVoidCommand(sql);
        }
        public void CreateTable_FurnitureSale()
        {
            string sql = @"
            CREATE TABLE IF NOT EXISTS furnitureSale (
                id INTEGER PRIMARY KEY AUTOINCREMENT,
                furnitureArrivalId INTEGER NOT NULL,
                typeId INTEGER NOT NULL,
                ammount INTEGER NOT NULL,
                shopId INTEGER NOT NULL,
                customerId INTEGER NOT NULL
            )";

            dBFacade.ExecuteVoidCommand(sql);
        }
        public void CreateTable_FurnitureRefund()
        {
            string sql = @"
            CREATE TABLE IF NOT EXISTS furnitureRefund (
                id INTEGER PRIMARY KEY AUTOINCREMENT,
                furnitureArrivalId INTEGER NOT NULL,
                typeId INTEGER NOT NULL,
                ammount INTEGER NOT NULL,
                shopId INTEGER NOT NULL,
                refundReason TEXT NOT NULL
            )";

            dBFacade.ExecuteVoidCommand(sql);
        }

        public void CreateTable_Suppliers()
        {
            string sql = @"
            CREATE TABLE IF NOT EXISTS suppliers (
                id INTEGER PRIMARY KEY AUTOINCREMENT,
                name TEXT NOT NULL
            )";

            dBFacade.ExecuteVoidCommand(sql);
        }

        public void CreateTable_FurnitureTypes()
        {
            string sql = @"
            CREATE TABLE IF NOT EXISTS furnitureTypes (
                id INTEGER PRIMARY KEY AUTOINCREMENT,
                name TEXT NOT NULL
            )";

            dBFacade.ExecuteVoidCommand(sql);
        }

        public void CreateTable_Shops()
        {
            string sql = @"
            CREATE TABLE IF NOT EXISTS shops (
                id INTEGER PRIMARY KEY AUTOINCREMENT,
                name TEXT NOT NULL,
                adress TEXT NOT NULL,
                chiefName TEXT NOT NULL,
                chiefPhone TEXT NOT NULL
            )";

            dBFacade.ExecuteVoidCommand(sql);
        }

        public void CreateTable_Customers()
        {
            string sql = @"
            CREATE TABLE IF NOT EXISTS customers (
                id INTEGER PRIMARY KEY AUTOINCREMENT,
                name TEXT NOT NULL
            )";
            dBFacade.ExecuteVoidCommand(sql);
        }
    }

    public class DBService
    {
        private IDBFacade dBFacade;
        public IDBFacade DBFacade { get { return dBFacade; } }

        public DBService(IDBFacade dBFacade)
        {
            this.dBFacade = dBFacade;
        }


        public string[] GetAllSupliers()
        {
            string sql = "SELECT id, name FROM suppliers ORDER BY id";
            List<string> supplier = new List<string>();

            using (var reader = dBFacade.ExecuteReaderCommand(sql))
            {
                int nameOrdinal = reader.GetOrdinal("name");

                while (reader.Read())
                {
                    supplier.Add(reader.GetString(nameOrdinal));
                }
            }
            return supplier.ToArray();
        }
        public string[] GetAllFurnitureTypes()
        {
            string sql = "SELECT id, name FROM furnitureTypes ORDER BY id";
            List<string> supplier = new List<string>();

            using (var reader = dBFacade.ExecuteReaderCommand(sql))
            {
                int nameOrdinal = reader.GetOrdinal("name");

                while (reader.Read())
                {
                    supplier.Add(reader.GetString(nameOrdinal));
                }
            }
            return supplier.ToArray();
        }
        public string[] GetAllShops()
        {
            string sql = "SELECT id, name FROM shops ORDER BY id";
            List<string> supplier = new List<string>();

            using (var reader = dBFacade.ExecuteReaderCommand(sql))
            {
                int nameOrdinal = reader.GetOrdinal("name");

                while (reader.Read())
                {
                    supplier.Add(reader.GetString(nameOrdinal));
                }
            }
            return supplier.ToArray();
        }
        public string[] GetAllCustomers()
        {
            string sql = "SELECT id, name FROM customers ORDER BY id";
            List<string> supplier = new List<string>();

            using (var reader = dBFacade.ExecuteReaderCommand(sql))
            {
                int nameOrdinal = reader.GetOrdinal("name");

                while (reader.Read())
                {
                    supplier.Add(reader.GetString(nameOrdinal));
                }
            }
            return supplier.ToArray();
        }

        public string[] GetAllFurnitureArrivalRecords()
        {
            string sql = "SELECT id, name FROM furnitureArrival ORDER BY id";
            List<string> supplier = new List<string>();

            using (var reader = dBFacade.ExecuteReaderCommand(sql))
            {
                int nameOrdinal = reader.GetOrdinal("name");

                while (reader.Read())
                {
                    supplier.Add(reader.GetString(nameOrdinal));
                }
            }
            return supplier.ToArray();
        }


        public void AddFurnitureArrival(
            string name,
            int typeId,
            int supplierId,
            int amount,
            int price,
            string date)
        {
            string sql = @"
            INSERT INTO furnitureArrival (name, typeId, supplierId, ammount, price, date)
            VALUES (@name, @typeId, @supplierId, @ammount, @price, @date)";

            dBFacade.ExecuteVoidCommand(sql,
            ("@name", name),
            ("@typeId", typeId),
            ("@supplierId", supplierId),
            ("@ammount", amount),
            ("@price", price),
            ("@date", date)
                );
        }

        public void AddFurnitureSale(
    int furnitureArrivalId,
    int typeId,
    int amount,
    int shopId,
    int customerId)
        {
            string sql = @"
    INSERT INTO furnitureSale (furnitureArrivalId, typeId, ammount, shopId, customerId)
    VALUES (@furnitureArrivalId, @typeId, @ammount, @shopId, @customerId)";

            dBFacade.ExecuteVoidCommand(sql,
                ("@furnitureArrivalId", furnitureArrivalId),
                ("@typeId", typeId),
                ("@ammount", amount),
                ("@shopId", shopId),
                ("@customerId", customerId));
        }

        public void AddFurnitureRefund(
            int furnitureArrivalId,
            int typeId,
            int amount,
            int shopId,
            string refundReason)
        {
            string sql = @"
    INSERT INTO furnitureRefund (furnitureArrivalId, typeId, ammount, shopId, refundReason)
    VALUES (@furnitureArrivalId, @typeId, @ammount, @shopId, @refundReason)";

            dBFacade.ExecuteVoidCommand(sql,
                ("@furnitureArrivalId", furnitureArrivalId),
                ("@typeId", typeId),
                ("@ammount", amount),
                ("@shopId", shopId),
                ("@refundReason", refundReason));
        }

        public void AddSupplier(string name)
        {
            string sql = @"
    INSERT INTO suppliers (name)
    VALUES (@name)";

            dBFacade.ExecuteVoidCommand(sql,
                ("@name", name));
        }

        public void AddFurnitureType(string name)
        {
            string sql = @"
    INSERT INTO furnitureTypes (name)
    VALUES (@name)";

            dBFacade.ExecuteVoidCommand(sql,
                ("@name", name));
        }

        public void AddShop(
            string name,
            string address,
            string chiefName,
            string chiefPhone)
        {
            string sql = @"
    INSERT INTO shops (name, adress, chiefName, chiefPhone)
    VALUES (@name, @adress, @chiefName, @chiefPhone)";

            dBFacade.ExecuteVoidCommand(sql,
                ("@name", name),
                ("@adress", address),
                ("@chiefName", chiefName),
                ("@chiefPhone", chiefPhone));
        }

        public void AddCustomer(string name)
        {
            string sql = @"
    INSERT INTO customers (name)
    VALUES (@name)";

            dBFacade.ExecuteVoidCommand(sql,
                ("@name", name));
        }



    }

}
