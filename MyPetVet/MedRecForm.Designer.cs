namespace MyPetVet
{
    partial class MedRecForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MedRecForm));
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvMedRec = new System.Windows.Forms.DataGridView();
            this.id_medrec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.animal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.worker = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diagnosis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.recommendations = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.update_rec = new System.Windows.Forms.DataGridViewButtonColumn();
            this.delete_rec = new System.Windows.Forms.DataGridViewButtonColumn();
            this.id_animal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_worker = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnNewRec = new System.Windows.Forms.Button();
            this.lblBack3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedRec)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.dgvMedRec);
            this.panel2.Controls.Add(this.txtSearch);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.btnNewRec);
            this.panel2.Location = new System.Drawing.Point(25, 125);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1054, 434);
            this.panel2.TabIndex = 18;
            // 
            // dgvMedRec
            // 
            this.dgvMedRec.AllowUserToAddRows = false;
            this.dgvMedRec.AllowUserToDeleteRows = false;
            this.dgvMedRec.AllowUserToResizeColumns = false;
            this.dgvMedRec.AllowUserToResizeRows = false;
            this.dgvMedRec.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvMedRec.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvMedRec.BackgroundColor = System.Drawing.Color.White;
            this.dgvMedRec.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvMedRec.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            this.dgvMedRec.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
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
            this.id_worker});
            this.dgvMedRec.GridColor = System.Drawing.Color.White;
            this.dgvMedRec.Location = new System.Drawing.Point(27, 87);
            this.dgvMedRec.MultiSelect = false;
            this.dgvMedRec.Name = "dgvMedRec";
            this.dgvMedRec.ReadOnly = true;
            this.dgvMedRec.RowHeadersVisible = false;
            this.dgvMedRec.RowHeadersWidth = 51;
            this.dgvMedRec.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvMedRec.RowTemplate.Height = 24;
            this.dgvMedRec.ShowEditingIcon = false;
            this.dgvMedRec.Size = new System.Drawing.Size(1002, 307);
            this.dgvMedRec.TabIndex = 0;
            this.dgvMedRec.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMedRec_CellClick);
            this.dgvMedRec.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLog_CellContentClick);
            // 
            // id_medrec
            // 
            this.id_medrec.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.id_medrec.DataPropertyName = "id_medrec";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            this.id_medrec.DefaultCellStyle = dataGridViewCellStyle1;
            this.id_medrec.FillWeight = 187.1657F;
            this.id_medrec.HeaderText = "id";
            this.id_medrec.MinimumWidth = 6;
            this.id_medrec.Name = "id_medrec";
            this.id_medrec.ReadOnly = true;
            this.id_medrec.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.id_medrec.Width = 50;
            // 
            // animal
            // 
            this.animal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.animal.DataPropertyName = "id_animal";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            this.animal.DefaultCellStyle = dataGridViewCellStyle2;
            this.animal.FillWeight = 85.47237F;
            this.animal.HeaderText = "Тварина";
            this.animal.MinimumWidth = 6;
            this.animal.Name = "animal";
            this.animal.ReadOnly = true;
            this.animal.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.animal.Width = 125;
            // 
            // worker
            // 
            this.worker.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.worker.DataPropertyName = "id_worker";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            this.worker.DefaultCellStyle = dataGridViewCellStyle3;
            this.worker.FillWeight = 85.47237F;
            this.worker.HeaderText = "Лікар";
            this.worker.MinimumWidth = 6;
            this.worker.Name = "worker";
            this.worker.ReadOnly = true;
            this.worker.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.worker.Width = 130;
            // 
            // date
            // 
            this.date.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.date.DataPropertyName = "date";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            this.date.DefaultCellStyle = dataGridViewCellStyle4;
            this.date.HeaderText = "Дата";
            this.date.MinimumWidth = 6;
            this.date.Name = "date";
            this.date.ReadOnly = true;
            this.date.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.date.Width = 125;
            // 
            // description
            // 
            this.description.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.description.DataPropertyName = "description";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            this.description.DefaultCellStyle = dataGridViewCellStyle5;
            this.description.HeaderText = "Опис";
            this.description.MinimumWidth = 100;
            this.description.Name = "description";
            this.description.ReadOnly = true;
            // 
            // diagnosis
            // 
            this.diagnosis.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.diagnosis.DataPropertyName = "diagnosis";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            this.diagnosis.DefaultCellStyle = dataGridViewCellStyle6;
            this.diagnosis.HeaderText = "Діагноз";
            this.diagnosis.MinimumWidth = 100;
            this.diagnosis.Name = "diagnosis";
            this.diagnosis.ReadOnly = true;
            // 
            // recommendations
            // 
            this.recommendations.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.recommendations.DataPropertyName = "recommendations";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            this.recommendations.DefaultCellStyle = dataGridViewCellStyle7;
            this.recommendations.HeaderText = "Рекомендації";
            this.recommendations.MinimumWidth = 100;
            this.recommendations.Name = "recommendations";
            this.recommendations.ReadOnly = true;
            // 
            // update_rec
            // 
            this.update_rec.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(211)))), ((int)(((byte)(11)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(211)))), ((int)(((byte)(11)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black;
            this.update_rec.DefaultCellStyle = dataGridViewCellStyle8;
            this.update_rec.FillWeight = 85.47237F;
            this.update_rec.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.update_rec.HeaderText = "";
            this.update_rec.MinimumWidth = 6;
            this.update_rec.Name = "update_rec";
            this.update_rec.ReadOnly = true;
            this.update_rec.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.update_rec.Text = "Редагувати";
            this.update_rec.UseColumnTextForButtonValue = true;
            this.update_rec.Width = 125;
            // 
            // delete_rec
            // 
            this.delete_rec.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.OrangeRed;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Onest", 10F);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.OrangeRed;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Black;
            this.delete_rec.DefaultCellStyle = dataGridViewCellStyle9;
            this.delete_rec.FillWeight = 85.47237F;
            this.delete_rec.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delete_rec.HeaderText = "";
            this.delete_rec.MinimumWidth = 6;
            this.delete_rec.Name = "delete_rec";
            this.delete_rec.ReadOnly = true;
            this.delete_rec.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.delete_rec.Text = "Видалити";
            this.delete_rec.UseColumnTextForButtonValue = true;
            this.delete_rec.Width = 125;
            // 
            // id_animal
            // 
            this.id_animal.HeaderText = "Column1";
            this.id_animal.MinimumWidth = 6;
            this.id_animal.Name = "id_animal";
            this.id_animal.ReadOnly = true;
            this.id_animal.Width = 88;
            // 
            // id_worker
            // 
            this.id_worker.HeaderText = "Column1";
            this.id_worker.MinimumWidth = 6;
            this.id_worker.Name = "id_worker";
            this.id_worker.ReadOnly = true;
            this.id_worker.Width = 88;
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearch.Location = new System.Drawing.Point(778, 30);
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(252, 29);
            this.txtSearch.TabIndex = 7;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(211)))), ((int)(((byte)(11)))));
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBox1.Location = new System.Drawing.Point(729, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 29);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // btnNewRec
            // 
            this.btnNewRec.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(211)))), ((int)(((byte)(11)))));
            this.btnNewRec.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnNewRec.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNewRec.FlatAppearance.BorderSize = 0;
            this.btnNewRec.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(156)))), ((int)(((byte)(7)))));
            this.btnNewRec.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(156)))), ((int)(((byte)(7)))));
            this.btnNewRec.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewRec.Font = new System.Drawing.Font("Onest", 10F);
            this.btnNewRec.Location = new System.Drawing.Point(27, 23);
            this.btnNewRec.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnNewRec.MaximumSize = new System.Drawing.Size(252, 47);
            this.btnNewRec.Name = "btnNewRec";
            this.btnNewRec.Size = new System.Drawing.Size(170, 36);
            this.btnNewRec.TabIndex = 6;
            this.btnNewRec.Text = "Додати запис";
            this.btnNewRec.UseVisualStyleBackColor = false;
            this.btnNewRec.Click += new System.EventHandler(this.btnNewRec_Click);
            // 
            // lblBack3
            // 
            this.lblBack3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(211)))), ((int)(((byte)(11)))));
            this.lblBack3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblBack3.Font = new System.Drawing.Font("Onest ExtraBold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblBack3.Location = new System.Drawing.Point(4, 0);
            this.lblBack3.Name = "lblBack3";
            this.lblBack3.Size = new System.Drawing.Size(42, 44);
            this.lblBack3.TabIndex = 17;
            this.lblBack3.Text = "←";
            this.lblBack3.Click += new System.EventHandler(this.lblBack3_Click);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(211)))), ((int)(((byte)(11)))));
            this.label4.Dock = System.Windows.Forms.DockStyle.Top;
            this.label4.Font = new System.Drawing.Font("Onest Medium", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(1106, 100);
            this.label4.TabIndex = 16;
            this.label4.Text = "Медичні записи";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MedRecForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1106, 571);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lblBack3);
            this.Controls.Add(this.label4);
            this.Font = new System.Drawing.Font("Onest", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MedRecForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Медичні записи";
            this.Load += new System.EventHandler(this.MedRecForm_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedRec)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvMedRec;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnNewRec;
        private System.Windows.Forms.Label lblBack3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_medrec;
        private System.Windows.Forms.DataGridViewTextBoxColumn animal;
        private System.Windows.Forms.DataGridViewTextBoxColumn worker;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.DataGridViewTextBoxColumn description;
        private System.Windows.Forms.DataGridViewTextBoxColumn diagnosis;
        private System.Windows.Forms.DataGridViewTextBoxColumn recommendations;
        private System.Windows.Forms.DataGridViewButtonColumn update_rec;
        private System.Windows.Forms.DataGridViewButtonColumn delete_rec;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_animal;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_worker;
    }
}