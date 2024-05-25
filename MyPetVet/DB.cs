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
            MySqlCommand command = new MySqlCommand("INSERT INTO `vet_db`.`client` (`fullname`, `address`, `phone`) VALUES (@FullName, @Address, @Phone)", db.getConnection());
            command.Parameters.Add("@FullName", MySqlDbType.VarChar).Value = clnt.FullName;
            command.Parameters.Add("@Address", MySqlDbType.VarChar).Value = clnt.Address;
            command.Parameters.Add("@Phone", MySqlDbType.VarChar).Value = clnt.Phone;

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
            MySqlCommand command = new MySqlCommand("UPDATE `vet_db`.`client` SET fullname = @FullName, address = @Address, phone = @Phone WHERE id_client = @ID", db.getConnection());
            command.Parameters.Add("@FullName", MySqlDbType.VarChar).Value = clnt.FullName;
            command.Parameters.Add("@Address", MySqlDbType.VarChar).Value = clnt.Address;
            command.Parameters.Add("@Phone", MySqlDbType.VarChar).Value = clnt.Phone;
            command.Parameters.Add("@ID", MySqlDbType.VarChar).Value = id;

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
            MySqlCommand command = new MySqlCommand("DELETE FROM `vet_db`.`client` WHERE id_client = @ID", db.getConnection());
            command.Parameters.Add("@ID", MySqlDbType.VarChar).Value = id;

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
            MySqlCommand command = new MySqlCommand(@"INSERT INTO `vet_db`.`animal` 
                                               (`id_client`, `id_species`, `id_breed`, `name`, `date_birth`) 
                                               VALUES (@IdClient, @IdSpecies, @IdBreed, @Name, @DateBirth)", db.getConnection());
            command.Parameters.Add("@IdClient", MySqlDbType.Int32).Value = animal.IdClient;
            command.Parameters.Add("@IdSpecies", MySqlDbType.Int32).Value = animal.IdSpecies;
            command.Parameters.Add("@IdBreed", MySqlDbType.Int32).Value = animal.IdBreed;
            command.Parameters.Add("@Name", MySqlDbType.VarChar).Value = animal.Name;
            command.Parameters.Add("@DateBirth", MySqlDbType.Date).Value = animal.DateBirth;

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
            MySqlCommand command = new MySqlCommand(@"UPDATE `vet_db`.`animal` 
                                               SET `id_client` = @IdClient, `id_species` = @IdSpecies, `id_breed` = @IdBreed, 
                                                   `name` = @Name, `date_birth` = @DateBirth 
                                               WHERE `id_animal` = @ID", db.getConnection());
            command.Parameters.Add("@IdClient", MySqlDbType.Int32).Value = animal.IdClient;
            command.Parameters.Add("@IdSpecies", MySqlDbType.Int32).Value = animal.IdSpecies;
            command.Parameters.Add("@IdBreed", MySqlDbType.Int32).Value = animal.IdBreed;
            command.Parameters.Add("@Name", MySqlDbType.VarChar).Value = animal.Name;
            command.Parameters.Add("@DateBirth", MySqlDbType.Date).Value = animal.DateBirth;
            command.Parameters.Add("@ID", MySqlDbType.Int32).Value = id;

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
            MySqlCommand command = new MySqlCommand("DELETE FROM `vet_db`.`animal` WHERE `id_animal` = @ID", db.getConnection());
            command.Parameters.Add("@ID", MySqlDbType.Int32).Value = id;

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

            // Переконайтеся, що DataGridView не додає зайві колонки автоматично
            dgv.AutoGenerateColumns = false;

            dgv.DataSource = table;

            // Вручну встановіть колонки відповідно до DataTable
            dgv.Columns["id_animal"].DataPropertyName = "id_animal";
            dgv.Columns["fullname"].DataPropertyName = "fullname";
            dgv.Columns["species"].DataPropertyName = "species";
            dgv.Columns["breed"].DataPropertyName = "breed";
            dgv.Columns["name"].DataPropertyName = "name";
            dgv.Columns["date_birth"].DataPropertyName = "date_birth";

            db.closeConnection();
        }
    }
}
