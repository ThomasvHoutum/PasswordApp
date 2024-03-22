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
            _passwordManager = new PasswordManager();

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
        /// Initialize form
        /// </summary>
        private void Initialize()
        {
            InitializeComponent();
            
            PopulateLoginDetailTable();
        }

        private void PopulateLoginDetailTable()
        {

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

        private void AddLoginDetailButton_Click(object sender, EventArgs e)
        {
            new AddLoginDetail(_passwordManager).Show();
        }
    }
}