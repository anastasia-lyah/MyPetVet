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
    public partial class SpeciesForm : Form
    {
        public SpeciesForm()
        {
            InitializeComponent();
        }
        private void SpeciesForm_Load(object sender, EventArgs e)
        {

        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtSpeciesName.Text.Trim().Length == 0)
            {
                MessageBox.Show("Введіть назву виду.");
                return;
            }

            DB db = new DB();
            MySqlCommand command = new MySqlCommand("INSERT INTO species (name) VALUES (@name)", db.getConnection());
            command.Parameters.AddWithValue("@name", txtSpeciesName.Text.Trim());
            db.openConnection();
            command.ExecuteNonQuery();
            db.closeConnection();

            this.Close();
        }    
    }
}
