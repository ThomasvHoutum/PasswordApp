using System;
using System.Windows.Forms;
using Domain.Managers;

namespace PasswordApp.Forms
{
    public partial class Manager : Form
    {
        private readonly AuthenticationManager _authenticationManager;
        private PasswordManager _passwordManager;
        private SearchManager _searchManager;
        
        public Manager(AuthenticationManager authenticationManager)
        {
            _authenticationManager = authenticationManager;

            if (!_authenticationManager.IsLoggedIn())
            {
                var masterLoginForm = new MasterLogin(_authenticationManager);
                masterLoginForm.LoginSuccessful += Initialize;
                masterLoginForm.Show();
                masterLoginForm.Focus();
            }
            else
            {
                Initialize();
            }
            
        }

        /// <summary>
        /// Add new entry to login table
        /// </summary>
        /// <param name="username"></param>
        /// <param name="application"></param>
        public void AddToLoginTable(string username = "", string application = "")
        {
            LoginDetailTable.Rows.Add(username, application);
        }
        
        /// <summary>
        /// Initialize form
        /// </summary>
        private void Initialize()
        {
            _passwordManager = new PasswordManager();
            _searchManager = new SearchManager();
            InitializeComponent();
            
            PopulateLoginDetailTable();
        }

        /// <summary>
        /// Initially populate login table
        /// </summary>
        private void PopulateLoginDetailTable()
        {
            LoginDetailTable.AllowUserToAddRows = false;
            LoginDetailTable.Rows.Clear();
            
            foreach (var loginDetail in _passwordManager.LoginDetailRepository.Entries)
                LoginDetailTable.Rows.Add(loginDetail.Username, loginDetail.ApplicationName);
            
            foreach (var creditCard in _passwordManager.CreditCardRepository.Entries)
                LoginDetailTable.Rows.Add(creditCard.Issuer, creditCard.Number.ToString());
            
            foreach (var bankDetail in _passwordManager.BankDetailRepository.Entries)
                LoginDetailTable.Rows.Add(bankDetail.BankName, bankDetail.Username);
        }
        
        private void loginDetailTable_CellContentClick(object sender, DataGridViewCellEventArgs cellEventArgs)
        {
            var pressedColumn = LoginDetailTable.Columns[cellEventArgs.ColumnIndex];

            if (pressedColumn.GetType() == typeof(DataGridViewButtonColumn) && pressedColumn.Name == ModifyButton.Name)
                ModifyButton_Pressed(cellEventArgs.RowIndex);
        }

        private void ModifyButton_Pressed(int rowIndex)
        {
            // TODO: Get table entry based on rowindex
        }

        private void AddLoginDetailButton_Click(object sender, EventArgs e) => 
            new AddLoginDetail(this, _passwordManager).Show();

        private void AddCreditCardButton_Click(object sender, EventArgs e) =>
            new AddCreditCard(this, _passwordManager).Show();

        private void AddBankDetailButton_Click(object sender, EventArgs e) =>
            new AddBankDetail(this, _passwordManager).Show();

        /// <summary>
        ///  On every input change, filter the repositories based on the search query
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SearchTextBox_TextChanged(object sender, EventArgs e)
        {
            var searchQuery = SearchTextBox.Text;
            
            // If no search query, reset the table
            if (string.IsNullOrEmpty(searchQuery))
            {
                PopulateLoginDetailTable();
                return;
            }
            
            var filteredBankDetails = _searchManager.Search(_passwordManager.BankDetailRepository.Entries, searchQuery);
            var filteredCreditCards = _searchManager.Search(_passwordManager.CreditCardRepository.Entries, searchQuery);
            var filteredLoginDetails = _searchManager.Search(_passwordManager.LoginDetailRepository.Entries, searchQuery);
            
            LoginDetailTable.Rows.Clear();
            
            foreach (var bankDetail in filteredBankDetails)
                LoginDetailTable.Rows.Add(bankDetail.BankName, bankDetail.Username);
            
            foreach (var creditCard in filteredCreditCards)
                LoginDetailTable.Rows.Add(creditCard.Issuer, creditCard.Number.ToString());
            
            foreach (var loginDetail in filteredLoginDetails)
                LoginDetailTable.Rows.Add(loginDetail.Username, loginDetail.ApplicationName);
        }
    }
}