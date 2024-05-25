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
    public partial class NewAnimalForm : Form
    {
        private readonly AnimalForm _parent;
        public int id, idClient, idSpecies, idBreed;
        public string name;
        public DateTime dateBirth;
        public NewAnimalForm(AnimalForm parent)
        {
            InitializeComponent();
            _parent = parent;
            LoadClients();
            LoadSpecies();
            LoadBreeds();

            cmbSpecies.SelectedIndexChanged += cmbSpecies_SelectedIndexChanged;
        }
        private void cmbSpecies_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadBreedsForSelectedSpecies();
        }
        private void LoadBreedsForSelectedSpecies()
        {
            if (cmbSpecies.SelectedValue == null)
                return;

            int selectedSpeciesId = (int)cmbSpecies.SelectedValue;

            DB db = new DB();
            MySqlCommand command = new MySqlCommand("SELECT id_breeds, name FROM breeds WHERE id_species = @speciesId", db.getConnection());
            command.Parameters.AddWithValue("@speciesId", selectedSpeciesId);
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            cmbBreed.DataSource = table;
            cmbBreed.DisplayMember = "name";
            cmbBreed.ValueMember = "id_breeds";
            db.closeConnection();
        }
        public void UpdateInfo()
        {
            
            btnSave.Text = "Оновити";
            lblText1.Text = "Редагувати дані про тварину";
            txtName.Text = name;
            dtpBirth.Value = dateBirth;
            cmbClient.SelectedValue = idClient;
            cmbSpecies.SelectedValue = idSpecies;
            cmbBreed.SelectedValue = idBreed;
        }

        public void SaveInfo()
        {
            lblText1.Text = "Додати тварину";
            btnSave.Text = "Зберегти";
        }

        public void Clear()
        {
            txtName.Text = string.Empty;
            dtpBirth.Value = DateTime.Now;
            cmbClient.SelectedIndex = -1;
            cmbSpecies.SelectedIndex = -1;
            cmbBreed.SelectedIndex = -1;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void NewAnimalForm_Load(object sender, EventArgs e)
        {
            ToolTip toolTip1 = new ToolTip();
            toolTip1.SetToolTip(btnAddSpecies, "Додати новий вид");
            ToolTip toolTip2 = new ToolTip();
            toolTip1.SetToolTip(btnAddBreed, "Додати нову породу");
        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {
            if (txtName.Text.Trim().Length == 0)
            {
                MessageBox.Show("Введіть ім'я тварини.");
                return;
            }
            if (cmbClient.SelectedIndex == -1)
            {
                MessageBox.Show("Виберіть клієнта.");
                return;
            }
            if (cmbSpecies.SelectedIndex == -1)
            {
                MessageBox.Show("Виберіть вид.");
                return;
            }
            if (cmbBreed.SelectedIndex == -1)
            {
                MessageBox.Show("Виберіть породу.");
                return;
            }

            Animal animal = new Animal(
                (int)cmbClient.SelectedValue,
                (int)cmbSpecies.SelectedValue,
                (int)cmbBreed.SelectedValue,
                txtName.Text.Trim(),
                dtpBirth.Value
            );

            if (btnSave.Text == "Зберегти")
            {
                DB.AddAnimal(animal);
                Clear();
            }
            if (btnSave.Text == "Оновити")
            {
                DB.UpdateAnimal(animal, id);
            }
            _parent.Display();
        }

        private void btnAddBreed_Click(object sender, EventArgs e)
        {            
            BreedForm breedForm = new BreedForm();
            breedForm.ShowDialog();
            LoadBreeds();
        }

        private void btnAddSpecies_Click(object sender, EventArgs e)
        {            
            SpeciesForm speciesForm = new SpeciesForm();
            speciesForm.ShowDialog();
            LoadSpecies();
        }

        private void LoadClients()
        {
            DB db = new DB();
            MySqlCommand command = new MySqlCommand("SELECT id_client, fullname FROM client", db.getConnection());
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            cmbClient.DataSource = table;
            cmbClient.DisplayMember = "fullname";
            cmbClient.ValueMember = "id_client";
            db.closeConnection();
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

        private void LoadBreeds()
        {
            DB db = new DB();
            MySqlCommand command = new MySqlCommand("SELECT id_breeds, name FROM breeds", db.getConnection());
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            cmbBreed.DataSource = table;
            cmbBreed.DisplayMember = "name";
            cmbBreed.ValueMember = "id_breeds";
            db.closeConnection();
        }
    }
}
