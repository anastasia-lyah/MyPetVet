﻿using System;
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
    public partial class NewClientForm : Form
    {
        private readonly ClientForm _parent;
        public string id, lastname, firstname, address, phone;
        public NewClientForm(ClientForm parent)
        {
            InitializeComponent();
            _parent = parent;
        }
        public void UpdateInfo()
        {
            lblText.Text = "Редагувати дані про клієнта";
            btnSave.Text = "Оновити";
            txtLastName.Text = lastname;
            txtFirstName.Text = firstname;
            txtAddress.Text = address;
            txtPhone.Text = phone;
        }

        public void SaveInfo()
        {
            lblText.Text = "Додати клієнта";
            btnSave.Text = "Зберегти";
        }
        public void Clear()
        {
            txtLastName.Text = txtFirstName.Text = txtAddress.Text = txtPhone.Text = string.Empty;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtLastName.Text.Trim().Length == 0) 
            {
                MessageBox.Show("Введіть прізвище клієнта.");
                return;
            }
            if (txtFirstName.Text.Trim().Length == 0)
            {
                MessageBox.Show("Введіть ім'я клієнта.");
                return;
            }
            if (txtAddress.Text.Trim().Length == 0)
            {
                MessageBox.Show("Введіть адресу клієнта.");
                return;
            }
            if (txtPhone.Text.Trim().Length == 0)
            {
                MessageBox.Show("Введіть номер телефону клієнта.");
                return;
            }
            if(btnSave.Text == "Зберегти")
            {
                Client clnt = new Client(txtLastName.Text.Trim(), txtFirstName.Text.Trim(), txtAddress.Text.Trim(), txtPhone.Text.Trim());
                DB.AddClient(clnt);
                Clear();
            }
            if (btnSave.Text == "Оновити")
            {
                Client clnt = new Client(txtLastName.Text.Trim(), txtFirstName.Text.Trim(), txtAddress.Text.Trim(), txtPhone.Text.Trim());
                DB.UpdateClient(clnt, id);
            }
            _parent.Display();
        }

        private void NewClientForm_Load(object sender, EventArgs e)
        {

        }
    }
}
