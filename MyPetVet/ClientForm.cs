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
    public partial class ClientForm : Form
    {
        NewClientForm form;
        public ClientForm()
        {
            InitializeComponent();
            form = new NewClientForm(this);
        }
        public void Display()
        {
            DB.DisplayAndSearchClient("SELECT id_client, lastname, firstname, address, phone FROM client", dgvClients);
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnNewClient_Click(object sender, EventArgs e)
        {
            form.Clear();
            form.SaveInfo();
            form.ShowDialog();
        }

        private void ClientForm_Load(object sender, EventArgs e)
        {

        }

        private void ClientForm_Shown(object sender, EventArgs e)
        {
            Display();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            DB.DisplayAndSearchClient("SELECT id_client, lastname, firstname, address, phone FROM client WHERE lastname LIKE '%"+ txtSearch.Text +"%'", dgvClients);
        }

        private void dgvClients_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == 0)
            {
                form.Clear();
                form.id = dgvClients.Rows[e.RowIndex].Cells[2].Value.ToString();
                form.lastname = dgvClients.Rows[e.RowIndex].Cells[3].Value.ToString();
                form.firstname = dgvClients.Rows[e.RowIndex].Cells[4].Value.ToString();
                form.address = dgvClients.Rows[e.RowIndex].Cells[5].Value.ToString();
                form.phone = dgvClients.Rows[e.RowIndex].Cells[6].Value.ToString();
                form.UpdateInfo();
                form.ShowDialog();
                return;
            }
            if(e.ColumnIndex == 1) 
            {
                if(MessageBox.Show("Ви бажаєте видалити дані про клієнта?", "Інформація", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    DB.DeleteClient(dgvClients.Rows[e.RowIndex].Cells[2].Value.ToString());
                    Display();
                }
                return;
            }
        }
    }
}
