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
    public partial class AnimalForm : Form
    {
        NewAnimalForm form;
        public AnimalForm()
        {
            InitializeComponent();
            form = new NewAnimalForm(this);
            
            dgvAnimals.Columns.Clear();
            
            this.id_client = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_species = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_breed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            
            this.id_client.HeaderText = "ID Client";
            this.id_client.Name = "id_client";
            this.id_client.Visible = false; 

            this.id_species.HeaderText = "ID Species";
            this.id_species.Name = "id_species";
            this.id_species.Visible = false;

            this.id_breed.HeaderText = "ID Breed";
            this.id_breed.Name = "id_breed";
            this.id_breed.Visible = false; 
           
            this.dgvAnimals.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
                this.id_animal,
                this.fullname,
                this.species,
                this.breed,
                this.name,
                this.date_birth,
                this.update_animal,
                this.delete_animal,
                this.id_client,
                this.id_species,
                this.id_breed
            });
        }
        public void Display()
        {
            DB.DisplayAndSearchAnimals(@"SELECT 
                                                a.id_animal,
                                                c.fullname,
                                                s.name AS species,
                                                b.name AS breed,
                                                a.name,
                                                a.date_birth,
                                                a.id_client,
                                                a.id_species,
                                                a.id_breed
                                            FROM 
                                                animal a
                                            JOIN 
                                                client c ON a.id_client = c.id_client
                                            JOIN 
                                                species s ON a.id_species = s.id_species
                                            JOIN 
                                                breeds b ON a.id_breed = b.id_breeds;", dgvAnimals);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void AnimalForm_Load(object sender, EventArgs e)
        {
            Display();
        }

        private void btnNewAnimal_Click(object sender, EventArgs e)
        {
            form.Clear();
            form.SaveInfo();
            form.ShowDialog();
        }
        private void AnimalForm_Shown(object sender, EventArgs e)
        {
            
        }
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            
        }
        private void dgvAnimals_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
        private void dgvAnimals_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (e.ColumnIndex == dgvAnimals.Columns["update_animal"].Index)
                {
                    form.Clear();

                    form.id = Convert.ToInt32(dgvAnimals.Rows[e.RowIndex].Cells["id_animal"].Value);
                    form.name = dgvAnimals.Rows[e.RowIndex].Cells["name"].Value.ToString();
                    form.dateBirth = Convert.ToDateTime(dgvAnimals.Rows[e.RowIndex].Cells["date_birth"].Value);
                    form.idClient = Convert.ToInt32(dgvAnimals.Rows[e.RowIndex].Cells["id_client"].Value);
                    form.idSpecies = Convert.ToInt32(dgvAnimals.Rows[e.RowIndex].Cells["id_species"].Value);
                    form.idBreed = Convert.ToInt32(dgvAnimals.Rows[e.RowIndex].Cells["id_breed"].Value);

                    form.UpdateInfo();
                    form.ShowDialog();
                }
                else if (e.ColumnIndex == dgvAnimals.Columns["delete_animal"].Index)
                {
                    if (MessageBox.Show("Ви бажаєте видалити дані про тварину?", "Інформація", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        DB.DeleteAnimal(Convert.ToInt32(dgvAnimals.Rows[e.RowIndex].Cells["id_animal"].Value));
                        Display();
                    }
                }
            }
        }
        private void txtSearch_TextChanged_1(object sender, EventArgs e)
        {
            DB.DisplayAndSearchAnimals(@"SELECT 
                                        a.id_animal AS 'id_animal',
                                        a.name AS 'name',
                                        a.date_birth AS 'date_birth',
                                        c.fullname AS 'fullname',
                                        s.name AS 'species',
                                        b.name AS 'breed'
                                     FROM 
                                        animal a
                                     JOIN 
                                        client c ON a.id_client = c.id_client
                                     JOIN 
                                        species s ON a.id_species = s.id_species
                                     JOIN 
                                        breeds b ON a.id_breed = b.id_breeds
                                     WHERE a.name LIKE '%" + txtSearch.Text + "%'", dgvAnimals);
        }
        private void lblBack2_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuForm menuForm = new MenuForm();
            menuForm.ShowDialog();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            

        }
        private void label4_Click(object sender, EventArgs e)
        {

        }
        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
