using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using MySql.Data.MySqlClient;
using Mysqlx.Crud;


namespace MyPetVet
{
    public partial class NewLogForm : Form
    {
        private readonly LogForm _parent;
        public int id, idClient, idAnimal, idWorker;
        public DateTime date;
        public TimeSpan time;
        public string symptoms;
        public NewLogForm(LogForm parent)
        {
            InitializeComponent();
            _parent = parent;
            LoadClients();
            LoadAnimals();
            LoadWorkers();

            cmbClient.SelectedIndexChanged += cmbClient_SelectedIndexChanged;
        }
        private void cmbClient_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadAnimalForSelectedClient();
        }
        private void LoadAnimalForSelectedClient()
        {
            if (cmbClient.SelectedValue == null)
                return;

            int selectedClientId = (int)cmbClient.SelectedValue;

            DB db = new DB();
            MySqlCommand command = new MySqlCommand("SELECT id_animal, name FROM animal WHERE id_client = @clientId", db.getConnection());
            command.Parameters.AddWithValue("@clientId", selectedClientId);
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            cmbAnimal.DataSource = table;
            cmbAnimal.DisplayMember = "name";
            cmbAnimal.ValueMember = "id_animal";
            db.closeConnection();
        }
        public void UpdateInfo()
        {
            btnSave.Text = "Оновити";
            lblText1.Text = "Редагувати запис";
            dtpDate.Value = date;
            dtpTime.Value = DateTime.Today.Add(time);
            txtSymptoms.Text = symptoms;
            cmbClient.SelectedValue = idClient;
            cmbAnimal.SelectedValue = idAnimal;
            cmbWorker.SelectedValue = idWorker;
        }
        public void SaveInfo()
        {
            lblText1.Text = "Додати запис";
            btnSave.Text = "Зберегти";
        }
        public void Clear()
        {
            dtpDate.Value = DateTime.Now;
            dtpTime.Value = DateTime.Now;
            txtSymptoms.Text = string.Empty;
            cmbClient.SelectedIndex = -1;
            cmbAnimal.SelectedIndex = -1;
            cmbWorker.SelectedIndex = -1;
        }       

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (cmbClient.SelectedIndex == -1 || cmbAnimal.SelectedIndex == -1 || cmbWorker.SelectedIndex == -1 || txtSymptoms.Text.Trim().Length == 0)
            {
                MessageBox.Show("Будь ласка, заповніть всі поля.");
                return;
            }

            Log log = new Log(
                (int)cmbClient.SelectedValue,
                (int)cmbAnimal.SelectedValue,
                (int)cmbWorker.SelectedValue,
                dtpDate.Value,
                dtpTime.Value.TimeOfDay,
                txtSymptoms.Text.Trim()
            );

            if (btnSave.Text == "Зберегти")
            {
                DB.AddLog(log);
                Clear();
            }
            if (btnSave.Text == "Оновити")
            {
                DB.UpdateLog(log, id);
            }
            _parent.Display();
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
        private void LoadWorkers()
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
        private void NewLogForm_Load(object sender, EventArgs e)
        {

        }
    }
}
