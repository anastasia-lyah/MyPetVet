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
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            ClientForm clientForm = new ClientForm();
            clientForm.ShowDialog();
        }
        private void btnAnimal_Click(object sender, EventArgs e)
        {
            this.Hide();
            AnimalForm animForm = new AnimalForm();
            animForm.ShowDialog();
        }
        private void MenuForm_Load(object sender, EventArgs e)
        {

        }
        private void btnLog_Click(object sender, EventArgs e)
        {
            this.Hide();
            LogForm logForm = new LogForm();
            logForm.ShowDialog();
        }
        private void btnMed_Click(object sender, EventArgs e)
        {
            this.Hide();
            MedRecForm medRecForm = new MedRecForm();
            medRecForm.ShowDialog();
        }
    }
}
