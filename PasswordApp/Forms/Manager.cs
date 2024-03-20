using System;
using System.Windows.Forms;
using Domain.Managers;

namespace PasswordApp.Forms
{
    public partial class Manager : Form
    {
        private PasswordManager _passwordManager;
        
        public Manager()
        {
            _passwordManager = new PasswordManager();
            
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
            
        }
    }
}