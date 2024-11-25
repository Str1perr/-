using System;
using System.Windows.Forms;
using Курсовой_проект.Controller;

namespace Курсовой_проект
{
    public partial class MainAdministrationWindow : Form
    {
        private const string UserTable = "User"; 
        private const string WalletTable = "Wallet"; 
        private const string TransactionTable = "Transaction"; 

        Query controller;
        AddUser addUser;
        AddTransaction addTransaction;
        Search search;
        DataBank bank;
        public MainAdministrationWindow()
        {
            InitializeComponent();
            controller = new Query(ConnectionString.ConnStr);
            addUser = new AddUser();
            addTransaction = new AddTransaction();
            search = new Search();
            bank = new DataBank();
        }
        private void MainAdministrationWindow_Load(object sender, EventArgs e)
        {
            CenterToScreen();
            bank.currentTable = UserTable;
            SortParameters.Items.Clear();
            SortParameters.Items.Add("По коду");
            SortParameters.Items.Add("По валюте");
            SortParameters.Items.Add("По Ф.И.О.");
            SortParameters.SelectedItem = SortParameters.Items[0];
            dataGridView1.DataSource = controller.UpdateUsersTable(SortParametersInterpretator(SortParameters.SelectedItem.ToString()));
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnShowUsers_Click(object sender, EventArgs e)
        {
            bank.currentTable = UserTable;
            SortParameters.Items.Clear();
            SortParameters.Items.Add("По коду");
            SortParameters.Items.Add("По валюте");
            SortParameters.Items.Add("По Ф.И.О.");
            SortParameters.SelectedItem = SortParameters.Items[0];
            dataGridView1.DataSource = controller.UpdateUsersTable(SortParametersInterpretator(SortParameters.SelectedItem.ToString()));
        }


        private void btnShowTransactions_Click(object sender, EventArgs e)
        {
            bank.currentTable = TransactionTable;
            SortParameters.Items.Clear();
            SortParameters.Items.Add("По коду транзакции");
            SortParameters.Items.Add("По коду пользователя");
            SortParameters.Items.Add("По типу транзакции");
            SortParameters.SelectedItem = SortParameters.Items[0];
            try
            {
                dataGridView1.DataSource = controller.UpdateTable(TransactionTable, SortParametersInterpretator(SortParameters.SelectedItem.ToString()));
            }
            catch (Exception ex) 
            {
                MessageBox.Show($"Ошибка: {ex}", "Ошибка");
            }
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            if (addUser.ShowDialog() == DialogResult.OK) 
            {
                try
                {
                    controller.AddUser(addUser.tbFIO.Text, addUser.tbAddress.Text, addUser.tbPhoneNumber.Text);
                    controller.InsetIntoWallet(addUser.Currency.Text);
                    dataGridView1.DataSource = controller.UpdateUsersTable(SortParametersInterpretator(SortParameters.SelectedItem.ToString()));
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка: {ex}", "Ошибка");
                }
            }
        }

        private void btnAddTransaction_Click(object sender, EventArgs e)
        {
            if (addTransaction.ShowDialog() == DialogResult.OK) 
            {
                try
                {
                    controller.AddTransactionProtocol(int.Parse(addTransaction.tbUser_id.Text), addTransaction.operationType.Text, int.Parse(addTransaction.tbSum.Text), addTransaction.dateTimePicker.Text);
                    controller.UpdateBalance(addTransaction.operationType.Text, int.Parse(addTransaction.tbSum.Text), int.Parse(addTransaction.tbUser_id.Text));
                    dataGridView1.DataSource = controller.UpdateUsersTable(SortParametersInterpretator(SortParameters.SelectedItem.ToString()));
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка: {ex}", "Ошибка");
                }

            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            switch (bank.currentTable) 
            {
                case UserTable: 
                    {
                        try
                        {
                            int index = dataGridView1.CurrentRow.Index;
                            controller.DeleteUser((int)dataGridView1[0, index].Value);
                            dataGridView1.DataSource = controller.UpdateUsersTable(SortParametersInterpretator(SortParameters.SelectedItem.ToString()));
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Ошибка: {ex}", "Ошибка");
                        }
                        break;
                    }
                case TransactionTable: 
                    {
                        MessageBox.Show("Удалить транзакцию невозможно!", "Ошибка");
                        break;
                    }
            }
        }

        private void btnCange_Click(object sender, EventArgs e)
        {
            switch (bank.currentTable) 
            {
                case UserTable: 
                    {
                        try
                        {
                            addUser.button1.Text = "Изменить";
                            int index = dataGridView1.CurrentRow.Index;
                            string FIO = (string)dataGridView1[1, index].Value;
                            string phoneNumber = (string)dataGridView1[2, index].Value;
                            string address = (string)dataGridView1[3, index].Value;
                            string currency = (string)dataGridView1[6, index].Value;
                            addUser.tbFIO.Text = FIO;
                            addUser.tbPhoneNumber.Text = phoneNumber;
                            addUser.tbAddress.Text = address;
                            addUser.Currency.Text = currency;
                            int id = (int)dataGridView1[0, index].Value;
                            if (addUser.ShowDialog() == DialogResult.OK)
                            {
                                controller.UpdateUser(addUser.tbFIO.Text, addUser.tbPhoneNumber.Text, addUser.tbAddress.Text, id);
                                controller.UpdateWallet(addUser.Currency.Text, id);
                                addUser.button1.Text = "Добавить";
                            }
                            dataGridView1.DataSource = controller.UpdateUsersTable(SortParametersInterpretator(SortParameters.SelectedItem.ToString()));
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Ошибка: {ex}", "Ошибка");
                        }
                        break;
                    }
                case TransactionTable: 
                    {
                        MessageBox.Show("Изменить транзакцию невозможно!", "Ошибка");
                        break;
                    }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            switch (bank.currentTable)
            {
                case UserTable:
                    {
                        try
                        {
                            search.searchParameters.Items.Clear();
                            search.searchParameters.Items.Add("Ф.И.О.");
                            search.searchParameters.Items.Add("Коду");
                            search.searchParameters.Items.Add("Валюте кошелька");
                            if (search.ShowDialog() == DialogResult.OK)
                            {
                                if (SearchingParameterInterpretator(search.searchParameters.Text) == string.Empty)
                                {
                                    MessageBox.Show("Неопределённый метод поиска", "Ошибка поиска");
                                }
                                dataGridView1.DataSource = controller.SearchUserInfo(search.tbSearchString.Text, SearchingParameterInterpretator(search.searchParameters.Text));
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Ошибка: {ex}", "Ошибка");
                        }
                        break;
                    }
                case TransactionTable:
                    {
                        try
                        {
                            search.searchParameters.Items.Clear();
                            search.searchParameters.Items.Add("Коду транзакции");
                            search.searchParameters.Items.Add("Типу транзакции");
                            search.searchParameters.Items.Add("Коду пользователя");
                            if (search.ShowDialog() == DialogResult.OK)
                            {
                                if (SearchingParameterInterpretator(search.searchParameters.Text) == string.Empty)
                                {
                                    MessageBox.Show("Неопределённый метод поиска", "Ошибка поиска");
                                }
                                dataGridView1.DataSource = controller.SearchTransactionInfo(search.tbSearchString.Text, SearchingParameterInterpretator(search.searchParameters.Text));
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Ошибка: {ex}", "Ошибка");
                        }
                        break;
                    }
            }
        }

        private string SearchingParameterInterpretator(string inputString) 
        {
            switch (inputString) 
            {
                case "Ф.И.О.": 
                    {
                        return "[User].[FIO]";
                    }
                case "Коду":
                    {
                        return "[User].[id]";
                    }
                case "Валюте кошелька": 
                    {
                        return "[Wallet].[currency]";
                    }
                case "Коду транзакции": 
                    {
                        return "[Transaction].[id]";
                    }
                case "Типу транзакции": 
                    {
                        return "[Transaction].[transaction_type]";
                    }
                case "Коду пользователя": 
                    {
                        return "[Transaction].[user_id]";
                    }
            }
            return string.Empty;
        }

        private string SortParametersInterpretator(string inputString) 
        {
            switch (inputString) 
            {
                case "По коду": 
                    {
                        return "[User].[id]";
                    }
                case "По валюте": 
                    {
                        return "[Wallet].[currency]";
                    }
                case "По Ф.И.О.": 
                    {
                        return "[User].[FIO]";
                    }
                case "По коду транзакции": 
                    {
                        return "[Transaction].[id]";
                    }
                case "По типу транзакции": 
                    {
                        return "[Transaction].[transaction_type]";
                    }
                case "По коду пользователя": 
                    {
                        return "[Transaction].[user_id]";
                    }
            }
            return string.Empty;
        }

        private void SortParameters_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (bank.currentTable)
            {
                case UserTable:
                    {
                        try
                        {
                            dataGridView1.DataSource = controller.UpdateUsersTable(SortParametersInterpretator(SortParameters.SelectedItem.ToString()));
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Ошибка: {ex}", "Ошибка");
                        }
                        break;
                    }
                case TransactionTable:
                    {
                        try
                        {
                            dataGridView1.DataSource = controller.UpdateTable(TransactionTable, SortParametersInterpretator(SortParameters.SelectedItem.ToString()));
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Ошибка: {ex}", "Ошибка");
                        }
                        break;
                    }
            }
        }
    }
}
