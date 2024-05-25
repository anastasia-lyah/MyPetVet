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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();

            this.txtPass.AutoSize=false;
            this.txtPass.Size = new Size(this.txtPass.Size.Width, 37);

            txtLogin.Text = "Логін";
            txtLogin.ForeColor = Color.Gray;
            txtPass.Text = "Пароль";
            txtPass.ForeColor = Color.Gray;
            txtPass.PasswordChar = '\0';
            txtPass.UseSystemPasswordChar = false;

            this.ActiveControl = label1;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            String login = txtLogin.Text;
            String password = txtPass.Text;

            DB db = new DB();
            DataTable table = new DataTable();
            MySqlDataAdapter adapret = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT * FROM `workers` WHERE `login` = @l AND `password` = @p", db.getConnection());
            command.Parameters.Add("@l", MySqlDbType.VarChar).Value = login;
            command.Parameters.Add("@p", MySqlDbType.VarChar).Value = password;

            adapret.SelectCommand = command;
            adapret.Fill(table);

            if (table.Rows.Count > 0)
            {
                this.Hide();
                MenuForm menuForm = new MenuForm();
                menuForm.Show();
            }              
            
            else
                MessageBox.Show("Неправильний логін або пароль. Спробуйте знову.");

            
        }

        private void lblRegistr_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegistrForm registrForm = new RegistrForm();
            registrForm.Show();
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

        private void lblRegistr_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void lblRegistr_MouseEnter(object sender, EventArgs e)
        {
            lblRegistr.ForeColor = Color.Brown;
        }

        private void lblRegistr_MouseLeave(object sender, EventArgs e)
        {
            lblRegistr.ForeColor = Color.Black;
        }
    }
}
