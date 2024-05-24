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
            MySqlCommand command = new MySqlCommand("INSERT INTO `vet_db`.`client` (`firstname`, `lastname`, `address`, `phone`) VALUES (@FirstName, @LastName, @Address, @Phone)", db.getConnection());
            command.Parameters.Add("@LastName", MySqlDbType.VarChar).Value = clnt.LastName;
            command.Parameters.Add("@FirstName", MySqlDbType.VarChar).Value = clnt.FirstName;
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
            MySqlCommand command = new MySqlCommand("UPDATE `vet_db`.`client` SET firstname = @FirstName, lastname = @LastName, address = @Address, phone = @Phone WHERE id_client = @ID", db.getConnection());
            command.Parameters.Add("@LastName", MySqlDbType.VarChar).Value = clnt.LastName;
            command.Parameters.Add("@FirstName", MySqlDbType.VarChar).Value = clnt.FirstName;
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
    }
}
