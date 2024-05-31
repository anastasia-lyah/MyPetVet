using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyPetVet
{
    public partial class RegistrForm : Form
    {
        public RegistrForm()
        {
            InitializeComponent();

            this.txtPass.AutoSize = false;
            this.txtPass.Size = new Size(this.txtPass.Size.Width, 37);

            txtName.Text = "Прізвище та ім'я";
            txtName.ForeColor = Color.Gray;            
            txtWork.Text = "Посада";
            txtWork.ForeColor = Color.Gray;
            txtLogin.Text = "Логін";
            txtLogin.ForeColor = Color.Gray;
            txtPass.Text = "Пароль";
            txtPass.ForeColor = Color.Gray;
            txtPass.PasswordChar = '\0';
            txtPass.UseSystemPasswordChar=false;

            this.ActiveControl = label1;
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void label1_Click_1(object sender, EventArgs e)
        {

        }
        private void btnLogin_Click(object sender, EventArgs e)
        {

        }
        private void txtLogin_TextChanged(object sender, EventArgs e)
        {

        }
        private void txtPass_TextChanged(object sender, EventArgs e)
        {

        }
        private void MyPetVet_Load(object sender, EventArgs e)
        {

        }
        private void label1_Click_2(object sender, EventArgs e)
        {

        }
        private void txtName_Enter(object sender, EventArgs e)
        {
            if (txtName.Text == "Прізвище та ім'я")
            {
                txtName.Text = "";
                txtName.ForeColor = Color.Black;
            }            
        }
        private void txtName_Leave(object sender, EventArgs e)
        {
            if (txtName.Text == "")
            {
                txtName.Text = "Прізвище та ім'я";
                txtName.ForeColor = Color.Gray;
            }                
        }
        private void txtWork_Enter(object sender, EventArgs e)
        {
            if (txtWork.Text == "Посада")
            {
                txtWork.Text = "";
                txtWork.ForeColor = Color.Black;
            }
        }
        private void txtWork_Leave(object sender, EventArgs e)
        {
            if (txtWork.Text == "")
            {
                txtWork.Text = "Посада";
                txtWork.ForeColor = Color.Gray;
            }
        }
        private void txtLogin_Enter(object sender, EventArgs e)
        {
            if (txtLogin.Text == "Логін")
            {
                txtLogin.Text = "";
                txtLogin.ForeColor = Color.Black;
            }
        }
        private void txtLogin_Leave(object sender, EventArgs e)
        {
            if (txtLogin.Text == "")
            {
                txtLogin.Text = "Логін";
                txtLogin.ForeColor = Color.Gray;
            }
        }
        private void txtPass_Enter(object sender, EventArgs e)
        {
            if (txtPass.Text == "Пароль")
            {
                txtPass.Text = "";
                txtPass.ForeColor = Color.Black;
                txtPass.PasswordChar = '*';
                txtPass.UseSystemPasswordChar = true;
            }
        }
        private void txtPass_Leave(object sender, EventArgs e)
        {
            if (txtPass.Text == "")
            {
                txtPass.Text = "Пароль";
                txtPass.ForeColor = Color.Gray;
                txtPass.PasswordChar = '\0';
                txtPass.UseSystemPasswordChar = false;
            }
        }
        private void btnReg_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "Ім'я")
            {
                MessageBox.Show("Будь ласка, введіть свої прізвище та ім'я.");
                return;
            }            
            if (txtWork.Text == "Посада")
            {
                MessageBox.Show("Будь ласка, введіть свою посаду.");
                return;
            }
            if (txtLogin.Text == "Логін")
            {
                MessageBox.Show("Будь ласка, введіть свій логін.");
                return;
            }
            if (txtPass.Text == "Пароль")
            {
                MessageBox.Show("Будь ласка, введіть свій пароль.");
                return;
            }

            if (isUserExists())
                return;

            DB db = new DB();
            MySqlCommand command = new MySqlCommand("INSERT INTO `vet_db`.`worker` (`specialization`, `firstname`, `login`, `password`) VALUES (@work, @name, @login, @pass);", db.getConnection());
            command.Parameters.Add("@name", MySqlDbType.VarChar).Value = txtName.Text;            
            command.Parameters.Add("@work", MySqlDbType.VarChar).Value = txtWork.Text;
            command.Parameters.Add("@login", MySqlDbType.VarChar).Value = txtLogin.Text;
            command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = txtPass.Text;

            db.openConnection();

            if (command.ExecuteNonQuery() == 1)
                MessageBox.Show("Ваш акаунт створено.");
            else
                MessageBox.Show("Не вийшло створити новий акаунт. Перевірьте дані.");            

            db.closeConnection();
        }
        public Boolean isUserExists()
        {
            DB db = new DB();
            DataTable table = new DataTable();
            MySqlDataAdapter adapret = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT * FROM `worker` WHERE `login` = @l", db.getConnection());
            command.Parameters.Add("@l", MySqlDbType.VarChar).Value = txtLogin.Text;

            adapret.SelectCommand = command;
            adapret.Fill(table);

            if (table.Rows.Count > 0)
            {
                MessageBox.Show("Цей логін вже зайнятий, введіть інший.");
                return true;
            }
            else
            {
                return false;
            }
        }
        private void lblRegistr_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }
        private void lblLogin_MouseEnter(object sender, EventArgs e)
        {
            lblLogin.ForeColor = Color.Brown;
        }
        private void lblLogin_MouseLeave(object sender, EventArgs e)
        {
            lblLogin.ForeColor = Color.Black;
        }
    }
}
