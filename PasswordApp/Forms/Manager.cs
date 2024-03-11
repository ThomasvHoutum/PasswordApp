using System;
using System.Windows.Forms;
using Domain.Interfaces.LoginDetails;
using Microsoft.Extensions.DependencyInjection;

namespace PasswordApp.Forms
{
    public partial class Manager : Form
    {
        private readonly ILoginDetailService _loginDetailService;
        
        public Manager(ILoginDetailService loginDetailService)
        {
            _loginDetailService = loginDetailService;
            InitializeComponent();
            
            PopulateLoginDetailTable();
        }

        private void PopulateLoginDetailTable()
        {
            var loginDetails = _loginDetailService.GeAllLoginDetails();

            foreach (var loginDetail in loginDetails)
            {
                LoginDetailTable.Rows.Add(new { loginDetail.Username, loginDetail.Application });
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

        private void AddLoginDetailButton_Click(object sender, EventArgs e)
        {
            var addLoginDetailForm = Program.ServiceProvider.GetRequiredService<AddLoginDetail>();
            addLoginDetailForm.Show();
        }
    }
}