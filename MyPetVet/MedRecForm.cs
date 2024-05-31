using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace MyPetVet
{
    public partial class MedRecForm : Form
    {
        NewMedRecForm form;
        public MedRecForm()
        {
            InitializeComponent();
            form = new NewMedRecForm(this);

            dgvMedRec.Columns.Clear();

            this.id_medrec.Name = "id_medrec";
            this.animal.Name = "animal";
            this.worker.Name = "worker";
            this.date.Name = "date";
            this.description.Name = "description";
            this.diagnosis.Name = "diagnosis";
            this.recommendations.Name = "recommendations";
            this.update_rec.Name = "update_rec";
            this.delete_rec.Name = "delete_rec";

            this.id_animal.HeaderText = "ID Animal";
            this.id_animal.Name = "id_animal";
            this.id_animal.Visible = false;

            this.id_worker.HeaderText = "ID Worker";
            this.id_worker.Name = "id_worker";
            this.id_worker.Visible = false;

            this.dgvMedRec.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_medrec,
            this.animal,
            this.worker,
            this.date,
            this.description,
            this.diagnosis,
            this.recommendations,
            this.update_rec,
            this.delete_rec,
            this.id_animal,
            this.id_worker,
        });
            dgvMedRec.Columns["description"].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dgvMedRec.Columns["diagnosis"].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dgvMedRec.Columns["recommendations"].DefaultCellStyle.WrapMode = DataGridViewTriState.True;

            Display();
        }
        public void Display()
        {
            DB.DisplayAndSearchMedRecord(@"SELECT 
                                        m.id_medrec,
                                        a.name AS animal,
                                        w.firstname AS worker,
                                        m.date,
                                        m.description,
                                        m.diagnosis,
                                        m.recommendations
                                    FROM 
                                        medical_record m
                                    JOIN 
                                        animal a ON m.id_animal = a.id_animal
                                    JOIN 
                                        worker w ON m.id_worker = w.id_worker;", dgvMedRec);
        }
        private void btnNewRec_Click(object sender, EventArgs e)
        {
            form.Clear();
            form.SaveInfo();
            form.ShowDialog();
        }
        private void lblBack3_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuForm menuForm = new MenuForm();
            menuForm.ShowDialog();
        }
        private void MedRecForm_Load(object sender, EventArgs e)
        {
            Display();
        }
        private void dgvLog_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void dgvMedRec_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (e.ColumnIndex == dgvMedRec.Columns["update_rec"].Index)
                {
                    form.Clear();

                    form.id = Convert.ToInt32(dgvMedRec.Rows[e.RowIndex].Cells["id_medrec"].Value);
                    form.date = Convert.ToDateTime(dgvMedRec.Rows[e.RowIndex].Cells["date"].Value);
                    form.description = dgvMedRec.Rows[e.RowIndex].Cells["description"].Value.ToString();
                    form.diagnosis = dgvMedRec.Rows[e.RowIndex].Cells["diagnosis"].Value.ToString();
                    form.recommendations = dgvMedRec.Rows[e.RowIndex].Cells["recommendations"].Value.ToString();
                    form.idAnimal = Convert.ToInt32(dgvMedRec.Rows[e.RowIndex].Cells["id_animal"].Value);
                    form.idWorker = Convert.ToInt32(dgvMedRec.Rows[e.RowIndex].Cells["id_worker"].Value);

                    form.UpdateInfo();
                    form.ShowDialog();
                }
                else if (e.ColumnIndex == dgvMedRec.Columns["delete_rec"].Index)
                {
                    if (MessageBox.Show("Ви бажаєте видалити запис?", "Інформація", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        DB.DeleteMedicalRecord(Convert.ToInt32(dgvMedRec.Rows[e.RowIndex].Cells["id_medrec"].Value));
                        Display();
                    }
                }
            }
        }
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            DB.DisplayAndSearchMedRecord(@"SELECT 
                                    m.id_medrec,
                                    a.name AS animal,
                                    w.firstname AS worker,
                                    m.date,
                                    m.description,
                                    m.diagnosis,
                                    m.recommendations
                                FROM 
                                    medical_record m
                                JOIN 
                                    animal a ON m.id_animal = a.id_animal
                                JOIN 
                                    worker w ON m.id_worker = w.id_worker
                                WHERE 
                                    a.name LIKE '%" + txtSearch.Text + "%'", dgvMedRec);
        }
    }
}
