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
    public partial class BreedForm : Form
    {
        public BreedForm()
        {
            InitializeComponent();
            LoadSpecies();
        }
        private void LoadSpecies()
        {
            DB db = new DB();
            MySqlCommand command = new MySqlCommand("SELECT id_species, name FROM species", db.getConnection());
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            cmbSpecies.DataSource = table;
            cmbSpecies.DisplayMember = "name";
            cmbSpecies.ValueMember = "id_species";
            db.closeConnection();
        }
        private void BreedForm_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtBreedName.Text.Trim().Length == 0)
            {
                MessageBox.Show("Введіть назву породи.");
                return;
            }
            if (cmbSpecies.SelectedIndex == -1)
            {
                MessageBox.Show("Виберіть вид.");
                return;
            }

            DB db = new DB();
            MySqlCommand command = new MySqlCommand("INSERT INTO breeds (name, id_species) VALUES (@name, @speciesId)", db.getConnection());
            command.Parameters.AddWithValue("@name", txtBreedName.Text.Trim());
            command.Parameters.AddWithValue("@speciesId", cmbSpecies.SelectedValue);
            db.openConnection();
            command.ExecuteNonQuery();
            db.closeConnection();

            this.Close();
        }
    }
}
