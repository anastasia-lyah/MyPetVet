using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace MyPetVet
{
    class DB
    {
        MySqlConnection conn = new MySqlConnection("server=localhost;port=3306;username=root;password=Snyusya_69;database=vet_db");
        public void openConnection()
        {
            if (conn.State == System.Data.ConnectionState.Closed)
                conn.Open();
        }
        public void closeConnection()
        {
            if (conn.State == System.Data.ConnectionState.Open)
                conn.Close();
        }
        public MySqlConnection getConnection()
        {
            return conn;
        }
        public static void AddClient(Client clnt)
        {
            DB db = new DB();
            MySqlCommand command = new MySqlCommand("AddClient", db.getConnection());
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@FullName", clnt.FullName);
            command.Parameters.AddWithValue("@Address", clnt.Address);
            command.Parameters.AddWithValue("@Phone", clnt.Phone);

            db.openConnection();

            if (command.ExecuteNonQuery() == 1)
                MessageBox.Show("Клієнта додано.");
            else
                MessageBox.Show("Не вийшло додати нового клієнта. Перевірьте дані.");

            db.closeConnection();
        }
        public static void UpdateClient(Client clnt, string id)
        {
            DB db = new DB();
            MySqlCommand command = new MySqlCommand("UpdateClient", db.getConnection());
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@ID", id);
            command.Parameters.AddWithValue("@FullName", clnt.FullName);
            command.Parameters.AddWithValue("@Address", clnt.Address);
            command.Parameters.AddWithValue("@Phone", clnt.Phone);

            db.openConnection();

            if (command.ExecuteNonQuery() == 1)
                MessageBox.Show("Дані про клієнта змінено.");
            else
                MessageBox.Show("Не вийшло змінити дані про клієнта. Перевірьте дані.");

            db.closeConnection();
        }
        public static void DeleteClient(string id)
        {
            DB db = new DB();
            MySqlCommand command = new MySqlCommand("DeleteClient", db.getConnection());
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@ID", id);

            db.openConnection();

            if (command.ExecuteNonQuery() == 1)
                MessageBox.Show("Клієнта було видалено.");
            else
                MessageBox.Show("Не вийшло видалити клієнта.");

            db.closeConnection();
        }
        public static void DisplayAndSearchClient(string query, DataGridView dgv)
        {
            string sql = query;
            DB db = new DB();
            MySqlCommand command = new MySqlCommand(sql, db.getConnection());
            MySqlDataAdapter adp = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adp.Fill(table);
            dgv.DataSource = table;
            db.closeConnection();
        }
        public static void AddAnimal(Animal animal)
        {
            DB db = new DB();
            MySqlCommand command = new MySqlCommand("AddAnimal", db.getConnection());
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@IdClient", animal.IdClient);
            command.Parameters.AddWithValue("@IdSpecies", animal.IdSpecies);
            command.Parameters.AddWithValue("@IdBreed", animal.IdBreed);
            command.Parameters.AddWithValue("@Name", animal.Name);
            command.Parameters.AddWithValue("@DateBirth", animal.DateBirth);

            db.openConnection();

            if (command.ExecuteNonQuery() == 1)
                MessageBox.Show("Тварину додано.");
            else
                MessageBox.Show("Не вийшло додати нову тварину. Перевірьте дані.");

            db.closeConnection();
        }
        public static void UpdateAnimal(Animal animal, int id)
        {
            DB db = new DB();
            MySqlCommand command = new MySqlCommand("UpdateAnimal", db.getConnection());
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@ID", id);
            command.Parameters.AddWithValue("@IdClient", animal.IdClient);
            command.Parameters.AddWithValue("@IdSpecies", animal.IdSpecies);
            command.Parameters.AddWithValue("@IdBreed", animal.IdBreed);
            command.Parameters.AddWithValue("@Name", animal.Name);
            command.Parameters.AddWithValue("@DateBirth", animal.DateBirth);

            db.openConnection();

            if (command.ExecuteNonQuery() == 1)
                MessageBox.Show("Дані про тварину змінено.");
            else
                MessageBox.Show("Не вийшло змінити дані про тварину. Перевірьте дані.");

            db.closeConnection();
        }
        public static void DeleteAnimal(int id)
        {
            DB db = new DB();
            MySqlCommand command = new MySqlCommand("DeleteAnimal", db.getConnection());
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@ID", id);

            db.openConnection();

            if (command.ExecuteNonQuery() == 1)
                MessageBox.Show("Тварину було видалено.");
            else
                MessageBox.Show("Не вийшло видалити тварину.");

            db.closeConnection();
        }
        public static void DisplayAndSearchAnimals(string query, DataGridView dgv)
        {
            DB db = new DB();
            MySqlCommand command = new MySqlCommand(query, db.getConnection());
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);

            dgv.AutoGenerateColumns = false;

            dgv.DataSource = table;

            dgv.Columns["id_animal"].DataPropertyName = "id_animal";
            dgv.Columns["fullname"].DataPropertyName = "fullname";
            dgv.Columns["species"].DataPropertyName = "species";
            dgv.Columns["breed"].DataPropertyName = "breed";
            dgv.Columns["name"].DataPropertyName = "name";
            dgv.Columns["date_birth"].DataPropertyName = "date_birth";

            db.closeConnection();
        }
        public static void AddLog(Log log)
        {
            DB db = new DB();
            MySqlCommand command = new MySqlCommand("AddVisitLog", db.getConnection());
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@IdClient", log.IdClient);
            command.Parameters.AddWithValue("@IdAnimal", log.IdAnimal);
            command.Parameters.AddWithValue("@IdWorker", log.IdWorker);
            command.Parameters.AddWithValue("@VisitDate", log.Date);
            command.Parameters.AddWithValue("@VisitTime", log.Time);
            command.Parameters.AddWithValue("@Symptoms", log.Symptoms);

            db.openConnection();

            if (command.ExecuteNonQuery() == 1)
                MessageBox.Show("Запис додано.");
            else
                MessageBox.Show("Не вийшло додати новий запис. Перевірьте дані.");

            db.closeConnection();
        }
        public static void UpdateLog(Log log, int id)
        {
            DB db = new DB();
            MySqlCommand command = new MySqlCommand("UpdateVisitLog", db.getConnection());
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@VisitID", id);
            command.Parameters.AddWithValue("@IdClient", log.IdClient);
            command.Parameters.AddWithValue("@IdAnimal", log.IdAnimal);
            command.Parameters.AddWithValue("@IdWorker", log.IdWorker);
            command.Parameters.AddWithValue("@VisitDate", log.Date);
            command.Parameters.AddWithValue("@VisitTime", log.Time);
            command.Parameters.AddWithValue("@Symptoms", log.Symptoms);

            db.openConnection();

            if (command.ExecuteNonQuery() == 1)
                MessageBox.Show("Дані про запис змінено.");
            else
                MessageBox.Show("Не вийшло змінити дані про запис. Перевірьте дані.");

            db.closeConnection();
        }
        public static void DeleteLog(int id)
        {
            DB db = new DB();
            MySqlCommand command = new MySqlCommand("DeleteVisitLog", db.getConnection());
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@VisitID", id);

            db.openConnection();

            if (command.ExecuteNonQuery() == 1)
                MessageBox.Show("Запис було видалено.");
            else
                MessageBox.Show("Не вийшло видалити запис.");

            db.closeConnection();
        }
        public static void DisplayAndSearchLog(string query, DataGridView dgv)
        {
            DB db = new DB();
            MySqlCommand command = new MySqlCommand(query, db.getConnection());
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);

            dgv.AutoGenerateColumns = false;
            dgv.DataSource = table;

            dgv.Columns["client"].DataPropertyName = "client";
            dgv.Columns["animal"].DataPropertyName = "animal";
            dgv.Columns["worker"].DataPropertyName = "worker";
            dgv.Columns["date"].DataPropertyName = "date";
            dgv.Columns["time"].DataPropertyName = "time";
            dgv.Columns["symptoms"].DataPropertyName = "symptoms";

            db.closeConnection();
        }
        public static void AddMedicalRecord(MedicalRecord record)
        {
            DB db = new DB();
            MySqlCommand command = new MySqlCommand("AddMedicalRecord", db.getConnection());
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@IdAnimal", record.IdAnimal);
            command.Parameters.AddWithValue("@IdWorker", record.IdWorker);
            command.Parameters.AddWithValue("@RecordDate", record.Date);
            command.Parameters.AddWithValue("@Description", record.Description);
            command.Parameters.AddWithValue("@Diagnosis", record.Diagnosis);
            command.Parameters.AddWithValue("@Recommendations", record.Recommendations);

            db.openConnection();

            if (command.ExecuteNonQuery() == 1)
                MessageBox.Show("Медичний запис додано.");
            else
                MessageBox.Show("Не вдалося додати медичний запис. Перевірьте дані.");

            db.closeConnection();
        }
        public static void UpdateMedicalRecord(MedicalRecord record, int id)
        {
            DB db = new DB();
            MySqlCommand command = new MySqlCommand("UpdateMedicalRecord", db.getConnection());
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@RecordID", id);
            command.Parameters.AddWithValue("@IdAnimal", record.IdAnimal);
            command.Parameters.AddWithValue("@IdWorker", record.IdWorker);
            command.Parameters.AddWithValue("@RecordDate", record.Date);
            command.Parameters.AddWithValue("@Description", record.Description);
            command.Parameters.AddWithValue("@Diagnosis", record.Diagnosis);
            command.Parameters.AddWithValue("@Recommendations", record.Recommendations);

            db.openConnection();

            if (command.ExecuteNonQuery() == 1)
                MessageBox.Show("Медичний запис оновлено.");
            else
                MessageBox.Show("Не вдалося оновити медичний запис. Перевірьте дані.");

            db.closeConnection();
        }
        public static void DeleteMedicalRecord(int id)
        {
            DB db = new DB();
            MySqlCommand command = new MySqlCommand(@"DELETE FROM `vet_db`.`medical_record` WHERE `id_medrec` = @ID", db.getConnection());
            command.Parameters.Add("@ID", MySqlDbType.Int32).Value = id;

            db.openConnection();

            if (command.ExecuteNonQuery() == 1)
                MessageBox.Show("Медичний запис видалено.");
            else
                MessageBox.Show("Не вдалося видалити медичний запис. Перевірьте дані.");

            db.closeConnection();
        }
        public static void DisplayAndSearchMedRecord(string query, DataGridView dgv)
        {
            DB db = new DB();
            MySqlCommand command = new MySqlCommand(query, db.getConnection());
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);

            dgv.AutoGenerateColumns = false;
            dgv.DataSource = table;
            
            dgv.Columns["animal"].DataPropertyName = "animal";
            dgv.Columns["worker"].DataPropertyName = "worker";
            dgv.Columns["date"].DataPropertyName = "date";
            dgv.Columns["description"].DataPropertyName = "description";
            dgv.Columns["diagnosis"].DataPropertyName = "diagnosis";
            dgv.Columns["recommendations"].DataPropertyName = "recommendations";

            db.closeConnection();
        }
    }
}
