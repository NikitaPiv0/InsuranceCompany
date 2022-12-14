using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Страховая_компания__2021_
{
    public partial class LoginForm : Form
    {
        private int userID;
        
        public LoginForm()
        {
            this.userID = -1;

            InitializeComponent();
        }

        public int UserID 
        {
            get { return userID; }
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled | ValidationConstraints.Visible))
            {
                string login = loginTextBox.Text;
                string password = passwordTextBox.Text;
                
                DataRow[] rows = this.insuranceCompanyDataSet.User.Select("login = \'" + login + "\' AND password = \'" + password + "\'");
                if (rows.GetLength(0) == 1)
                {
                    this.userID = Convert.ToInt32(rows[0]["ID"]);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Пользователь не найден.");
                    loginTextBox.Clear();
                    passwordTextBox.Clear();
                }
            }
        }

        private void string50RequestTB_Validating(object sender, CancelEventArgs e)
        {
            StringValidation.ContaierFunction(sender, e, errorProvider, StringValidation.StringStandard, 0, 50, false);
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "insuranceCompanyDataSet.User". При необходимости она может быть перемещена или удалена.
            this.userTableAdapter.Fill(this.insuranceCompanyDataSet.User);

            if (this.insuranceCompanyDataSet.User.Rows.Count < 1)
            {
                this.userTableAdapter.Insert("admin", "admin", "Иванов Иван Иванович", 1);
                this.userTableAdapter.Fill(this.insuranceCompanyDataSet.User);
            }
        }
    }
}
