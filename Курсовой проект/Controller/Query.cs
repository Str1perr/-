using System.Data;
using System.Data.OleDb;

namespace Курсовой_проект.Controller
{
    internal class Query
    {
        OleDbConnection connection;
        OleDbCommand command;
        OleDbDataAdapter dataAdapter;
        DataTable bufferTable;
        public Query(string Conn)
        {
            connection = new OleDbConnection(Conn);
            bufferTable = new DataTable();
        }

        public DataTable UpdateTable(string table, string sortParameter)
        {
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
            dataAdapter = new OleDbDataAdapter($"SELECT * FROM [{table}] ORDER BY {sortParameter}", connection);
            bufferTable.Clear();
            bufferTable.Columns.Clear();
            dataAdapter.Fill(bufferTable);
            connection.Close();
            return bufferTable;
        }

        public DataTable UpdateUsersTable(string sortParameter) 
        {
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
            dataAdapter = new OleDbDataAdapter($"SELECT * FROM [User] INNER JOIN [Wallet] ON [Wallet].[id] = [User].[id] ORDER BY {sortParameter}", connection);
            bufferTable.Clear();
            bufferTable.Columns.Clear();
            dataAdapter.Fill(bufferTable);
            connection.Close();
            return bufferTable;
        }

        public void AddUser(string FIO, string address, string phoneNumber) 
        {   
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
            command = new OleDbCommand("INSERT INTO [User] ([FIO], [phoneNumber], [address]) VALUES (@FIO, @phoneNumber, @address)", connection);
            command.Parameters.AddWithValue("FIO", FIO);
            command.Parameters.AddWithValue("phoneNumber", phoneNumber);
            command.Parameters.AddWithValue("address", address);
            command.ExecuteNonQuery();
            connection.Close();
        }

        private int GetID(string table)
        {
            int ID;
            dataAdapter = new OleDbDataAdapter($"SELECT [id] FROM [{table}] WHERE [id] = (SELECT MAX([id]) FROM [{table}])", connection);
            bufferTable.Clear();
            bufferTable.Columns.Clear();
            dataAdapter.Fill(bufferTable);
            ID = (int)bufferTable.Rows[0]["ID"];
            return ID;
        }

        public void InsetIntoWallet(string currency) 
        {
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
            int walletID = GetID("User");
            command = new OleDbCommand($"INSERT INTO [Wallet] ([id], [currency]) VALUES ({walletID}, '{currency}')", connection);
            command.ExecuteNonQuery();
        }

        public void AddTransactionProtocol(int user_id, string transaction_type, int transaction_sum, string transaction_date) 
        {
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
            command = new OleDbCommand("INSERT INTO [Transaction] ([user_id], [transaction_type], [transaction_sum], [transaction_date]) VALUES (user_id, @transaction_type, transaction_sum, @transaction_date)", connection);
            command.Parameters.AddWithValue("user_id", user_id);
            command.Parameters.AddWithValue("transaction_type", transaction_type);
            command.Parameters.AddWithValue("transaction_sum", transaction_sum);
            command.Parameters.AddWithValue("transaction_date", transaction_date);
            command.ExecuteNonQuery();
            connection.Close();
        }

        public void UpdateBalance(string transaction_type, int sum, int id) 
        {
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
            switch (transaction_type)
            {
                case "Списание":
                    {
                        command = new OleDbCommand($"UPDATE [Wallet] SET [balance] = [balance] - {sum} WHERE [id] = {id}", connection);
                        command.ExecuteNonQuery();
                        connection.Close();
                        break;
                    }
                case "Пополнение":
                    {
                        command = new OleDbCommand($"UPDATE [Wallet] SET [balance] = [balance] + {sum} WHERE [Wallet].[id] = {id}", connection);
                        command.ExecuteNonQuery();
                        connection.Close();
                        break;
                    }
            }
        }

        public void DeleteUser(int id) 
        {
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
            command = new OleDbCommand($"DELETE* FROM [User] WHERE id = {id}", connection);
            command.ExecuteNonQuery();
            connection.Close();
        }

        public void UpdateUser(string FIO, string phoneNumber, string address, int id) 
        {
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
            command = new OleDbCommand($"UPDATE [User] SET [FIO] = '{FIO}', [phoneNumber] = '{phoneNumber}', [address] = '{address}' WHERE [User].[id] = {id}", connection);
            command.ExecuteNonQuery();
            connection.Close();
        }
        public void UpdateWallet(string currency, int id)
        {
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
            command = new OleDbCommand("UPDATE [Wallet] SET [currency] = @currency WHERE [id] = id", connection);
            command.Parameters.AddWithValue("currency", currency);
            command.Parameters.AddWithValue("id", id);
            command.ExecuteNonQuery();
            connection.Close();
        }

        public DataTable SearchUserInfo(string inputString, string searchingParameter) 
        {
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
            dataAdapter = new OleDbDataAdapter($"SELECT* FROM [User] INNER JOIN [Wallet] ON [User].[id] = [Wallet].[id] WHERE {searchingParameter} LIKE '{inputString}'", connection);
            bufferTable.Clear();
            dataAdapter.Fill(bufferTable);
            connection.Close();
            return bufferTable;
        }
        public DataTable SearchTransactionInfo(string inputString, string searchingParameter) 
        {
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
            dataAdapter = new OleDbDataAdapter($"SELECT* FROM [Transaction] WHERE {searchingParameter} LIKE '{inputString}'", connection);
            bufferTable.Clear();
            dataAdapter.Fill(bufferTable);
            connection.Close();
            return bufferTable;
        }
    }
}