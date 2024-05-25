namespace MyPetVet
{
    partial class AnimalForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnimalForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvAnimals = new System.Windows.Forms.DataGridView();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnNewAnimal = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblBack2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.id_animal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fullname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.species = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.breed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date_birth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.update_animal = new System.Windows.Forms.DataGridViewButtonColumn();
            this.delete_animal = new System.Windows.Forms.DataGridViewButtonColumn();
            this.id_client = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_breed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_species = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAnimals)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.dgvAnimals);
            this.panel2.Controls.Add(this.txtSearch);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.btnNewAnimal);
            this.panel2.Location = new System.Drawing.Point(25, 122);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(930, 408);
            this.panel2.TabIndex = 12;
            // 
            // dgvAnimals
            // 
            this.dgvAnimals.AllowUserToAddRows = false;
            this.dgvAnimals.AllowUserToDeleteRows = false;
            this.dgvAnimals.AllowUserToResizeColumns = false;
            this.dgvAnimals.AllowUserToResizeRows = false;
            this.dgvAnimals.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvAnimals.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAnimals.BackgroundColor = System.Drawing.Color.White;
            this.dgvAnimals.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvAnimals.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
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
            this.id_breed,
            this.id_species});
            this.dgvAnimals.GridColor = System.Drawing.Color.White;
            this.dgvAnimals.Location = new System.Drawing.Point(27, 87);
            this.dgvAnimals.MultiSelect = false;
            this.dgvAnimals.Name = "dgvAnimals";
            this.dgvAnimals.ReadOnly = true;
            this.dgvAnimals.RowHeadersVisible = false;
            this.dgvAnimals.RowHeadersWidth = 51;
            this.dgvAnimals.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvAnimals.RowTemplate.Height = 24;
            this.dgvAnimals.ShowEditingIcon = false;
            this.dgvAnimals.Size = new System.Drawing.Size(878, 299);
            this.dgvAnimals.TabIndex = 0;
            this.dgvAnimals.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAnimals_CellClick_1);
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearch.Location = new System.Drawing.Point(654, 30);
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(252, 29);
            this.txtSearch.TabIndex = 7;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(211)))), ((int)(((byte)(11)))));
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBox1.Location = new System.Drawing.Point(605, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 29);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btnNewAnimal
            // 
            this.btnNewAnimal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(211)))), ((int)(((byte)(11)))));
            this.btnNewAnimal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnNewAnimal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNewAnimal.FlatAppearance.BorderSize = 0;
            this.btnNewAnimal.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(156)))), ((int)(((byte)(7)))));
            this.btnNewAnimal.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(156)))), ((int)(((byte)(7)))));
            this.btnNewAnimal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewAnimal.Font = new System.Drawing.Font("Onest", 10F);
            this.btnNewAnimal.Location = new System.Drawing.Point(27, 23);
            this.btnNewAnimal.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnNewAnimal.MaximumSize = new System.Drawing.Size(252, 47);
            this.btnNewAnimal.Name = "btnNewAnimal";
            this.btnNewAnimal.Size = new System.Drawing.Size(170, 36);
            this.btnNewAnimal.TabIndex = 6;
            this.btnNewAnimal.Text = "Додати тварину";
            this.btnNewAnimal.UseVisualStyleBackColor = false;
            this.btnNewAnimal.Click += new System.EventHandler(this.btnNewAnimal_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(211)))), ((int)(((byte)(11)))));
            this.label2.Font = new System.Drawing.Font("Onest ExtraBold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 44);
            this.label2.TabIndex = 11;
            this.label2.Text = "←";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Onest Medium", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(982, 553);
            this.label1.TabIndex = 10;
            this.label1.Text = "Клієнти";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(211)))), ((int)(((byte)(11)))));
            this.panel1.Controls.Add(this.lblBack2);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(982, 100);
            this.panel1.TabIndex = 13;
            // 
            // lblBack2
            // 
            this.lblBack2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(211)))), ((int)(((byte)(11)))));
            this.lblBack2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblBack2.Font = new System.Drawing.Font("Onest ExtraBold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblBack2.Location = new System.Drawing.Point(4, 0);
            this.lblBack2.Name = "lblBack2";
            this.lblBack2.Size = new System.Drawing.Size(42, 44);
            this.lblBack2.TabIndex = 9;
            this.lblBack2.Text = "←";
            this.lblBack2.Click += new System.EventHandler(this.lblBack2_Click);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(211)))), ((int)(((byte)(11)))));
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Onest Medium", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(982, 100);
            this.label4.TabIndex = 0;
            this.label4.Text = "Тварини";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // id_animal
            // 
            this.id_animal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.id_animal.DataPropertyName = "id_animal";
            this.id_animal.FillWeight = 187.1657F;
            this.id_animal.HeaderText = "id";
            this.id_animal.MinimumWidth = 6;
            this.id_animal.Name = "id_animal";
            this.id_animal.ReadOnly = true;
            this.id_animal.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.id_animal.Width = 50;
            // 
            // fullname
            // 
            this.fullname.DataPropertyName = "id_client";
            this.fullname.FillWeight = 85.47237F;
            this.fullname.HeaderText = "Власник";
            this.fullname.MinimumWidth = 6;
            this.fullname.Name = "fullname";
            this.fullname.ReadOnly = true;
            this.fullname.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // species
            // 
            this.species.DataPropertyName = "id_species";
            this.species.FillWeight = 85.47237F;
            this.species.HeaderText = "Вид";
            this.species.MinimumWidth = 6;
            this.species.Name = "species";
            this.species.ReadOnly = true;
            this.species.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // breed
            // 
            this.breed.DataPropertyName = "id_breed";
            this.breed.FillWeight = 85.47237F;
            this.breed.HeaderText = "Порода";
            this.breed.MinimumWidth = 6;
            this.breed.Name = "breed";
            this.breed.ReadOnly = true;
            this.breed.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // name
            // 
            this.name.DataPropertyName = "name";
            this.name.FillWeight = 85.47237F;
            this.name.HeaderText = "Ім\'я";
            this.name.MinimumWidth = 6;
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // date_birth
            // 
            this.date_birth.DataPropertyName = "date_birth";
            this.date_birth.HeaderText = "Дата народження";
            this.date_birth.MinimumWidth = 6;
            this.date_birth.Name = "date_birth";
            this.date_birth.ReadOnly = true;
            // 
            // update_animal
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(211)))), ((int)(((byte)(11)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(211)))), ((int)(((byte)(11)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            this.update_animal.DefaultCellStyle = dataGridViewCellStyle5;
            this.update_animal.FillWeight = 85.47237F;
            this.update_animal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.update_animal.HeaderText = "";
            this.update_animal.MinimumWidth = 6;
            this.update_animal.Name = "update_animal";
            this.update_animal.ReadOnly = true;
            this.update_animal.Text = "Редагувати";
            this.update_animal.UseColumnTextForButtonValue = true;
            // 
            // delete_animal
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.OrangeRed;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Onest", 10F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.OrangeRed;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            this.delete_animal.DefaultCellStyle = dataGridViewCellStyle6;
            this.delete_animal.FillWeight = 85.47237F;
            this.delete_animal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delete_animal.HeaderText = "";
            this.delete_animal.MinimumWidth = 6;
            this.delete_animal.Name = "delete_animal";
            this.delete_animal.ReadOnly = true;
            this.delete_animal.Text = "Видалити";
            this.delete_animal.UseColumnTextForButtonValue = true;
            // 
            // id_client
            // 
            this.id_client.HeaderText = "Column1";
            this.id_client.MinimumWidth = 6;
            this.id_client.Name = "id_client";
            this.id_client.ReadOnly = true;
            // 
            // id_breed
            // 
            this.id_breed.HeaderText = "Column1";
            this.id_breed.MinimumWidth = 6;
            this.id_breed.Name = "id_breed";
            this.id_breed.ReadOnly = true;
            // 
            // id_species
            // 
            this.id_species.HeaderText = "Column1";
            this.id_species.MinimumWidth = 6;
            this.id_species.Name = "id_species";
            this.id_species.ReadOnly = true;
            // 
            // AnimalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 553);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Onest", 10F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "AnimalForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AnimalForm";
            this.Load += new System.EventHandler(this.AnimalForm_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAnimals)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvAnimals;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnNewAnimal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblBack2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_animal;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullname;
        private System.Windows.Forms.DataGridViewTextBoxColumn species;
        private System.Windows.Forms.DataGridViewTextBoxColumn breed;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn date_birth;
        private System.Windows.Forms.DataGridViewButtonColumn update_animal;
        private System.Windows.Forms.DataGridViewButtonColumn delete_animal;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_client;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_breed;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_species;
    }
}