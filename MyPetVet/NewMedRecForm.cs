using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Management.Instrumentation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyPetVet
{
    public partial class NewMedRecForm : Form
    {
        private readonly MedRecForm _parent;
        public int id, idAnimal, idWorker;
        public DateTime date;
        public string description, diagnosis, recommendations;
        public NewMedRecForm(MedRecForm parent)
        {
            InitializeComponent();
            _parent = parent;
            LoadAnimals();
            LoadVets();
        }
        public void UpdateInfo()
        {
            btnSave.Text = "Оновити";
            lblText1.Text = "Редагувати медичний запис";
            dtpDate.Value = date;
            txtDescription.Text = description;
            txtDiagnosis.Text = diagnosis;
            txtRecommendations.Text = recommendations;
            cmbAnimal.SelectedValue = idAnimal;
            cmbWorker.SelectedValue = idWorker;
        }
        public void SaveInfo()
        {
            lblText1.Text = "Додати медичний запис";
            btnSave.Text = "Зберегти";
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (cmbAnimal.SelectedIndex == -1 || cmbWorker.SelectedIndex == -1 || txtDescription.Text.Trim().Length == 0 || txtDiagnosis.Text.Trim().Length == 0 || txtRecommendations.Text.Trim().Length == 0)
            {
                MessageBox.Show("Будь ласка, заповніть всі поля.");
                return;
            }

            MedicalRecord record = new MedicalRecord(
                (int)cmbAnimal.SelectedValue,
                (int)cmbWorker.SelectedValue,
                dtpDate.Value,
                txtDescription.Text.Trim(),
                txtDiagnosis.Text.Trim(),
                txtRecommendations.Text.Trim()
            );

            if (btnSave.Text == "Зберегти")
            {
                DB.AddMedicalRecord(record);
                Clear();
            }
            if (btnSave.Text == "Оновити")
            {
                DB.UpdateMedicalRecord(record, id);
            }
            _parent.Display();
        }
        public void Clear()
        {
            dtpDate.Value = DateTime.Now;
            txtDescription.Text = string.Empty;
            txtDiagnosis.Text = string.Empty;
            txtRecommendations.Text = string.Empty;
            cmbAnimal.SelectedIndex = -1;
            cmbWorker.SelectedIndex = -1;
        }
        private void LoadAnimals()
        {
            DB db = new DB();
            MySqlCommand command = new MySqlCommand("SELECT id_animal, name FROM animal", db.getConnection());
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            cmbAnimal.DataSource = table;
            cmbAnimal.DisplayMember = "name";
            cmbAnimal.ValueMember = "id_animal";
            db.closeConnection();
        }
        private void LoadVets()
        {
            DB db = new DB();
            MySqlCommand command = new MySqlCommand("SELECT id_worker, firstname FROM worker", db.getConnection());
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            cmbWorker.DataSource = table;
            cmbWorker.DisplayMember = "firstname";
            cmbWorker.ValueMember = "id_worker";
            db.closeConnection();
        }
        private void label4_Click(object sender, EventArgs e)
        {

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void NewMedRecForm_Load(object sender, EventArgs e)
        {

        }
    }
}
