using System;
using System.Windows.Forms;
using Domain.Managers;

namespace PasswordApp.Forms
{
    public partial class Manager : Form
    {
        private readonly AuthenticationManager _authenticationManager;
        private PasswordManager _passwordManager;
        
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
            InitializeComponent();
            
            PopulateLoginDetailTable();
        }

        /// <summary>
        /// Initially populate login table
        /// </summary>
        private void PopulateLoginDetailTable()
        {
            LoginDetailTable.AllowUserToAddRows = false;
            
            foreach (var loginDetail in _passwordManager.LoginDetails)
            {
                LoginDetailTable.Rows.Add(loginDetail.Username, loginDetail.ApplicationName);
            }
        }
        
        private void loginDetailTable_CellContentClick(object sender, DataGridViewCellEventArgs cellEventArgs)
        {
            var pressedColumn = LoginDetailTable.Columns[cellEventArgs.ColumnIndex];

            if (pressedColumn.GetType() == typeof(DataGridViewButtonColumn) && pressedColumn.Name == ModifyButton.Name)
                ModifyButton_Pressed(cellEventArgs.RowIndex);
        }

        private void ModifyButton_Pressed(int rowIndex)
        {
            // Get table entry based on rowindex
        }

        private void AddLoginDetailButton_Click(object sender, EventArgs e) => 
            new AddLoginDetail(this, _passwordManager).Show();
    }
}