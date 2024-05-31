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
    public partial class LogForm : Form
    {
        NewLogForm form;
        public LogForm()
        {
            InitializeComponent();
            form = new NewLogForm(this);

            dgvLog.Columns.Clear();            
            
            this.id_visit.Name = "id_visit";
            this.client.Name = "client";
            this.animal.Name = "animal";
            this.worker.Name = "worker";
            this.date.Name = "date";
            this.time.Name = "time";
            this.symptoms.Name = "symptoms";
            this.update_log.Name = "update_log";
            this.delete_log.Name = "delete_log";

            this.id_client.HeaderText = "ID Client";
            this.id_client.Name = "id_client";
            this.id_client.Visible = false;

            this.id_animal.HeaderText = "ID Animal";
            this.id_animal.Name = "id_animal";
            this.id_animal.Visible = false;

            this.id_worker.HeaderText = "ID Worker";
            this.id_worker.Name = "id_worker";
            this.id_worker.Visible = false;

            this.dgvLog.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_visit,
            this.client,
            this.animal,
            this.worker,
            this.date,
            this.time,
            this.symptoms,
            this.update_log,
            this.delete_log,
            this.id_client,
            this.id_animal,
            this.id_worker,
        });
            dgvLog.Columns["symptoms"].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
        }
        public void Display()
        {
            DB.DisplayAndSearchLog(@"SELECT 
                                    v.id_visit,
                                    c.fullname AS client,
                                    a.name AS animal,
                                    w.firstname AS worker,
                                    v.date,
                                    v.time,
                                    v.symptoms,
                                    v.id_client,
                                    v.id_animal,
                                    v.id_worker
                                FROM 
                                    visit_log v
                                JOIN 
                                    client c ON v.id_client = c.id_client
                                JOIN 
                                    animal a ON v.id_animal = a.id_animal
                                JOIN 
                                    worker w ON v.id_worker = w.id_worker;", dgvLog);
        }        
        
        private void lblBack3_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuForm menuForm = new MenuForm();
            menuForm.ShowDialog();
        }
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
        private void btnNewAnimal_Click(object sender, EventArgs e)
        {
            form.Clear();
            form.SaveInfo();
            form.ShowDialog();
        }
        private void LogForm_Load(object sender, EventArgs e)
        {
            Display();
        }
        private void dgvLog_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (e.ColumnIndex == dgvLog.Columns["update_log"].Index)
                {
                    form.Clear();

                    form.id = Convert.ToInt32(dgvLog.Rows[e.RowIndex].Cells["id_visit"].Value);
                    form.date = Convert.ToDateTime(dgvLog.Rows[e.RowIndex].Cells["date"].Value);
                    form.time = TimeSpan.Parse(dgvLog.Rows[e.RowIndex].Cells["time"].Value.ToString());
                    form.symptoms = dgvLog.Rows[e.RowIndex].Cells["symptoms"].Value.ToString();
                    form.idClient = Convert.ToInt32(dgvLog.Rows[e.RowIndex].Cells["id_client"].Value);
                    form.idAnimal = Convert.ToInt32(dgvLog.Rows[e.RowIndex].Cells["id_animal"].Value);
                    form.idWorker = Convert.ToInt32(dgvLog.Rows[e.RowIndex].Cells["id_worker"].Value);

                    form.UpdateInfo();
                    form.ShowDialog();
                }
                else if (e.ColumnIndex == dgvLog.Columns["delete_log"].Index)
                {
                    if (MessageBox.Show("Ви бажаєте видалити запис?", "Інформація", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        DB.DeleteLog(Convert.ToInt32(dgvLog.Rows[e.RowIndex].Cells["id_visit"].Value));
                        Display();
                    }
                }
            }
        }
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            DB.DisplayAndSearchLog(@"SELECT 
                                    v.id_visit,
                                    c.fullname AS client,
                                    a.name AS animal,
                                    w.firstname AS worker,
                                    v.date,
                                    v.time,
                                    v.symptoms
                                FROM 
                                    visit_log v
                                JOIN 
                                    client c ON v.id_client = c.id_client
                                JOIN 
                                    animal a ON v.id_animal = a.id_animal
                                JOIN 
                                    worker w ON v.id_worker = w.id_worker
                                WHERE 
                                    c.fullname LIKE '%" + txtSearch.Text + "%' OR " +
                                    "a.name LIKE '%" + txtSearch.Text + "%' OR " +
                                    "w.firstname LIKE '%" + txtSearch.Text + "%'", dgvLog);
        }
    }
}
