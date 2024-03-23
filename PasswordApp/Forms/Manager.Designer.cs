namespace PasswordApp.Forms
{
    partial class Manager
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.LoginDetailTable = new System.Windows.Forms.DataGridView();
            this.Username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Application = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ModifyButton = new System.Windows.Forms.DataGridViewButtonColumn();
            this.AddLoginDetailButton = new System.Windows.Forms.Button();
            this.ControlLoginDetails = new System.Windows.Forms.Panel();
            this.AddBankDetailButton = new System.Windows.Forms.Button();
            this.AddCreditCardButton = new System.Windows.Forms.Button();
            this.ControlLoginDetailsTitle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize) (this.LoginDetailTable)).BeginInit();
            this.ControlLoginDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // LoginDetailTable
            // 
            this.LoginDetailTable.AllowUserToAddRows = false;
            this.LoginDetailTable.AllowUserToDeleteRows = false;
            this.LoginDetailTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.LoginDetailTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { this.Username, this.Application, this.ModifyButton });
            this.LoginDetailTable.Location = new System.Drawing.Point(12, 12);
            this.LoginDetailTable.MultiSelect = false;
            this.LoginDetailTable.Name = "LoginDetailTable";
            this.LoginDetailTable.ReadOnly = true;
            this.LoginDetailTable.Size = new System.Drawing.Size(776, 213);
            this.LoginDetailTable.TabIndex = 0;
            this.LoginDetailTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.loginDetailTable_CellContentClick);
            // 
            // Username
            // 
            this.Username.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Username.FillWeight = 284.7716F;
            this.Username.Frozen = true;
            this.Username.HeaderText = "Username";
            this.Username.MinimumWidth = 300;
            this.Username.Name = "Username";
            this.Username.ReadOnly = true;
            this.Username.Width = 300;
            // 
            // Application
            // 
            this.Application.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Application.FillWeight = 7.614212F;
            this.Application.HeaderText = "Application";
            this.Application.MinimumWidth = 300;
            this.Application.Name = "Application";
            this.Application.ReadOnly = true;
            this.Application.Width = 300;
            // 
            // ModifyButton
            // 
            this.ModifyButton.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.NullValue = "Modify";
            this.ModifyButton.DefaultCellStyle = dataGridViewCellStyle1;
            this.ModifyButton.FillWeight = 7.614212F;
            this.ModifyButton.HeaderText = "Modify";
            this.ModifyButton.MinimumWidth = 50;
            this.ModifyButton.Name = "ModifyButton";
            this.ModifyButton.ReadOnly = true;
            this.ModifyButton.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ModifyButton.Text = "Modify";
            this.ModifyButton.UseColumnTextForButtonValue = true;
            // 
            // AddLoginDetailButton
            // 
            this.AddLoginDetailButton.Location = new System.Drawing.Point(3, 84);
            this.AddLoginDetailButton.Name = "AddLoginDetailButton";
            this.AddLoginDetailButton.Size = new System.Drawing.Size(97, 35);
            this.AddLoginDetailButton.TabIndex = 1;
            this.AddLoginDetailButton.Text = "Add Login";
            this.AddLoginDetailButton.UseVisualStyleBackColor = true;
            this.AddLoginDetailButton.Click += new System.EventHandler(this.AddLoginDetailButton_Click);
            // 
            // ControlLoginDetails
            // 
            this.ControlLoginDetails.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ControlLoginDetails.Controls.Add(this.AddBankDetailButton);
            this.ControlLoginDetails.Controls.Add(this.AddCreditCardButton);
            this.ControlLoginDetails.Controls.Add(this.ControlLoginDetailsTitle);
            this.ControlLoginDetails.Controls.Add(this.AddLoginDetailButton);
            this.ControlLoginDetails.Location = new System.Drawing.Point(12, 231);
            this.ControlLoginDetails.Name = "ControlLoginDetails";
            this.ControlLoginDetails.Size = new System.Drawing.Size(346, 207);
            this.ControlLoginDetails.TabIndex = 2;
            // 
            // AddBankDetailButton
            // 
            this.AddBankDetailButton.Location = new System.Drawing.Point(246, 84);
            this.AddBankDetailButton.Name = "AddBankDetailButton";
            this.AddBankDetailButton.Size = new System.Drawing.Size(97, 35);
            this.AddBankDetailButton.TabIndex = 5;
            this.AddBankDetailButton.Text = "Add Bank Detail";
            this.AddBankDetailButton.UseVisualStyleBackColor = true;
            // 
            // AddCreditCardButton
            // 
            this.AddCreditCardButton.Location = new System.Drawing.Point(125, 86);
            this.AddCreditCardButton.Name = "AddCreditCardButton";
            this.AddCreditCardButton.Size = new System.Drawing.Size(97, 35);
            this.AddCreditCardButton.TabIndex = 4;
            this.AddCreditCardButton.Text = "Add Credit Card";
            this.AddCreditCardButton.UseVisualStyleBackColor = true;
            // 
            // ControlLoginDetailsTitle
            // 
            this.ControlLoginDetailsTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.ControlLoginDetailsTitle.Location = new System.Drawing.Point(0, 2);
            this.ControlLoginDetailsTitle.Name = "ControlLoginDetailsTitle";
            this.ControlLoginDetailsTitle.Size = new System.Drawing.Size(346, 28);
            this.ControlLoginDetailsTitle.TabIndex = 3;
            this.ControlLoginDetailsTitle.Text = "Control login details";
            // 
            // Manager
            // 
            this.AccessibleName = "";
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ControlLoginDetails);
            this.Controls.Add(this.LoginDetailTable);
            this.Name = "Manager";
            this.Text = "PasswordManager";
            ((System.ComponentModel.ISupportInitialize) (this.LoginDetailTable)).EndInit();
            this.ControlLoginDetails.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button AddCreditCardButton;
        private System.Windows.Forms.Button AddBankDetailButton;

        private System.Windows.Forms.Label ControlLoginDetailsTitle;

        private System.Windows.Forms.Button AddLoginDetailButton;
        private System.Windows.Forms.Panel ControlLoginDetails;

        private System.Windows.Forms.DataGridViewButtonColumn ModifyButton;

        private System.Windows.Forms.DataGridViewTextBoxColumn Username;
        private System.Windows.Forms.DataGridViewTextBoxColumn Application;

        private System.Windows.Forms.DataGridView LoginDetailTable;

        #endregion
    }
}