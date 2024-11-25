namespace Курсовой_проект
{
    partial class MainAdministrationWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.таблицыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.пользователиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.транзакцииToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьПользователяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьТранзакциюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.изменитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поискToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.приложениеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnShowUsers = new System.Windows.Forms.Button();
            this.btnShowTransactions = new System.Windows.Forms.Button();
            this.btnAddUser = new System.Windows.Forms.Button();
            this.btnAddTransaction = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCange = new System.Windows.Forms.Button();
            this.SortParameters = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.никитаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.таблицыToolStripMenuItem,
            this.файлToolStripMenuItem,
            this.приложениеToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1192, 28);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // таблицыToolStripMenuItem
            // 
            this.таблицыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.пользователиToolStripMenuItem,
            this.транзакцииToolStripMenuItem});
            this.таблицыToolStripMenuItem.Name = "таблицыToolStripMenuItem";
            this.таблицыToolStripMenuItem.Size = new System.Drawing.Size(85, 24);
            this.таблицыToolStripMenuItem.Text = "Таблицы";
            // 
            // пользователиToolStripMenuItem
            // 
            this.пользователиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.никитаToolStripMenuItem});
            this.пользователиToolStripMenuItem.Name = "пользователиToolStripMenuItem";
            this.пользователиToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.пользователиToolStripMenuItem.Text = "Пользователи";
            // 
            // транзакцииToolStripMenuItem
            // 
            this.транзакцииToolStripMenuItem.Name = "транзакцииToolStripMenuItem";
            this.транзакцииToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.транзакцииToolStripMenuItem.Text = "Транзакции";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьПользователяToolStripMenuItem,
            this.добавитьТранзакциюToolStripMenuItem,
            this.изменитьToolStripMenuItem,
            this.поискToolStripMenuItem,
            this.удалитьToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(59, 24);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // добавитьПользователяToolStripMenuItem
            // 
            this.добавитьПользователяToolStripMenuItem.Name = "добавитьПользователяToolStripMenuItem";
            this.добавитьПользователяToolStripMenuItem.Size = new System.Drawing.Size(259, 26);
            this.добавитьПользователяToolStripMenuItem.Text = "Добавить пользователя";
            // 
            // добавитьТранзакциюToolStripMenuItem
            // 
            this.добавитьТранзакциюToolStripMenuItem.Name = "добавитьТранзакциюToolStripMenuItem";
            this.добавитьТранзакциюToolStripMenuItem.Size = new System.Drawing.Size(259, 26);
            this.добавитьТранзакциюToolStripMenuItem.Text = "Добавить транзакцию";
            // 
            // изменитьToolStripMenuItem
            // 
            this.изменитьToolStripMenuItem.Name = "изменитьToolStripMenuItem";
            this.изменитьToolStripMenuItem.Size = new System.Drawing.Size(259, 26);
            this.изменитьToolStripMenuItem.Text = "Изменить";
            // 
            // поискToolStripMenuItem
            // 
            this.поискToolStripMenuItem.Name = "поискToolStripMenuItem";
            this.поискToolStripMenuItem.Size = new System.Drawing.Size(259, 26);
            this.поискToolStripMenuItem.Text = "Поиск";
            // 
            // удалитьToolStripMenuItem
            // 
            this.удалитьToolStripMenuItem.Name = "удалитьToolStripMenuItem";
            this.удалитьToolStripMenuItem.Size = new System.Drawing.Size(259, 26);
            this.удалитьToolStripMenuItem.Text = "Удалить";
            // 
            // приложениеToolStripMenuItem
            // 
            this.приложениеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.выходToolStripMenuItem});
            this.приложениеToolStripMenuItem.Name = "приложениеToolStripMenuItem";
            this.приложениеToolStripMenuItem.Size = new System.Drawing.Size(114, 24);
            this.приложениеToolStripMenuItem.Text = "Приложение";
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(136, 26);
            this.выходToolStripMenuItem.Text = "Выход";
            // 
            // btnShowUsers
            // 
            this.btnShowUsers.Location = new System.Drawing.Point(1030, 52);
            this.btnShowUsers.Name = "btnShowUsers";
            this.btnShowUsers.Size = new System.Drawing.Size(150, 48);
            this.btnShowUsers.TabIndex = 3;
            this.btnShowUsers.Text = "Пользователи";
            this.btnShowUsers.UseVisualStyleBackColor = true;
            this.btnShowUsers.Click += new System.EventHandler(this.btnShowUsers_Click);
            // 
            // btnShowTransactions
            // 
            this.btnShowTransactions.Location = new System.Drawing.Point(1030, 106);
            this.btnShowTransactions.Name = "btnShowTransactions";
            this.btnShowTransactions.Size = new System.Drawing.Size(150, 48);
            this.btnShowTransactions.TabIndex = 4;
            this.btnShowTransactions.Text = "Транзакции";
            this.btnShowTransactions.UseVisualStyleBackColor = true;
            this.btnShowTransactions.Click += new System.EventHandler(this.btnShowTransactions_Click);
            // 
            // btnAddUser
            // 
            this.btnAddUser.Location = new System.Drawing.Point(1030, 189);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(150, 48);
            this.btnAddUser.TabIndex = 5;
            this.btnAddUser.Text = "Добавить пользователя";
            this.btnAddUser.UseVisualStyleBackColor = true;
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // btnAddTransaction
            // 
            this.btnAddTransaction.Location = new System.Drawing.Point(1030, 243);
            this.btnAddTransaction.Name = "btnAddTransaction";
            this.btnAddTransaction.Size = new System.Drawing.Size(150, 48);
            this.btnAddTransaction.TabIndex = 6;
            this.btnAddTransaction.Text = "Добавить транзакцию";
            this.btnAddTransaction.UseVisualStyleBackColor = true;
            this.btnAddTransaction.Click += new System.EventHandler(this.btnAddTransaction_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnExit.Location = new System.Drawing.Point(1070, 556);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(110, 44);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "Выход";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1027, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Таблицы";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1027, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "Действия";
            // 
            // btnCange
            // 
            this.btnCange.Location = new System.Drawing.Point(1030, 297);
            this.btnCange.Name = "btnCange";
            this.btnCange.Size = new System.Drawing.Size(150, 48);
            this.btnCange.TabIndex = 10;
            this.btnCange.Text = "Изменить";
            this.btnCange.UseVisualStyleBackColor = true;
            this.btnCange.Click += new System.EventHandler(this.btnCange_Click);
            // 
            // SortParameters
            // 
            this.SortParameters.FormattingEnabled = true;
            this.SortParameters.Location = new System.Drawing.Point(1030, 493);
            this.SortParameters.Name = "SortParameters";
            this.SortParameters.Size = new System.Drawing.Size(150, 24);
            this.SortParameters.TabIndex = 11;
            this.SortParameters.SelectedIndexChanged += new System.EventHandler(this.SortParameters_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1027, 474);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 16);
            this.label3.TabIndex = 12;
            this.label3.Text = "Сортировать по";
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnDelete.Location = new System.Drawing.Point(1030, 405);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(150, 48);
            this.btnDelete.TabIndex = 13;
            this.btnDelete.Text = "Удалить";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(1030, 351);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(150, 48);
            this.btnSearch.TabIndex = 14;
            this.btnSearch.Text = "Поиск";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 31);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1009, 569);
            this.dataGridView1.TabIndex = 15;
            // 
            // никитаToolStripMenuItem
            // 
            this.никитаToolStripMenuItem.Name = "никитаToolStripMenuItem";
            this.никитаToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.никитаToolStripMenuItem.Text = "Никита";
            // 
            // MainAdministrationWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1192, 612);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.SortParameters);
            this.Controls.Add(this.btnCange);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnAddTransaction);
            this.Controls.Add(this.btnAddUser);
            this.Controls.Add(this.btnShowTransactions);
            this.Controls.Add(this.btnShowUsers);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainAdministrationWindow";
            this.Text = "База данных Предприятия";
            this.Load += new System.EventHandler(this.MainAdministrationWindow_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Button btnShowUsers;
        private System.Windows.Forms.Button btnShowTransactions;
        private System.Windows.Forms.Button btnAddUser;
        private System.Windows.Forms.Button btnAddTransaction;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCange;
        private System.Windows.Forms.ComboBox SortParameters;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.ToolStripMenuItem таблицыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem пользователиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem транзакцииToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьПользователяToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьТранзакциюToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem изменитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поискToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem приложениеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStripMenuItem никитаToolStripMenuItem;
    }
}