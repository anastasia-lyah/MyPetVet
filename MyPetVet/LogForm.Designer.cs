namespace MyPetVet
{
    partial class LogForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvLog = new System.Windows.Forms.DataGridView();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnNewLog = new System.Windows.Forms.Button();
            this.lblBack3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.id_visit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.client = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.animal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.worker = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.symptoms = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.update_log = new System.Windows.Forms.DataGridViewButtonColumn();
            this.delete_log = new System.Windows.Forms.DataGridViewButtonColumn();
            this.id_client = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_animal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_worker = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLog)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.dgvLog);
            this.panel2.Controls.Add(this.txtSearch);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.btnNewLog);
            this.panel2.Location = new System.Drawing.Point(25, 122);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1018, 408);
            this.panel2.TabIndex = 15;
            // 
            // dgvLog
            // 
            this.dgvLog.AllowUserToAddRows = false;
            this.dgvLog.AllowUserToDeleteRows = false;
            this.dgvLog.AllowUserToResizeColumns = false;
            this.dgvLog.AllowUserToResizeRows = false;
            this.dgvLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvLog.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLog.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvLog.BackgroundColor = System.Drawing.Color.White;
            this.dgvLog.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvLog.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            this.dgvLog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
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
            this.id_worker});
            this.dgvLog.GridColor = System.Drawing.Color.White;
            this.dgvLog.Location = new System.Drawing.Point(27, 87);
            this.dgvLog.MultiSelect = false;
            this.dgvLog.Name = "dgvLog";
            this.dgvLog.ReadOnly = true;
            this.dgvLog.RowHeadersVisible = false;
            this.dgvLog.RowHeadersWidth = 51;
            this.dgvLog.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvLog.RowTemplate.Height = 24;
            this.dgvLog.ShowEditingIcon = false;
            this.dgvLog.Size = new System.Drawing.Size(966, 299);
            this.dgvLog.TabIndex = 0;
            this.dgvLog.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLog_CellClick);
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearch.Location = new System.Drawing.Point(742, 30);
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
            this.pictureBox1.Location = new System.Drawing.Point(693, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 29);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // btnNewLog
            // 
            this.btnNewLog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(211)))), ((int)(((byte)(11)))));
            this.btnNewLog.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnNewLog.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNewLog.FlatAppearance.BorderSize = 0;
            this.btnNewLog.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(156)))), ((int)(((byte)(7)))));
            this.btnNewLog.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(156)))), ((int)(((byte)(7)))));
            this.btnNewLog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewLog.Font = new System.Drawing.Font("Onest", 10F);
            this.btnNewLog.Location = new System.Drawing.Point(27, 23);
            this.btnNewLog.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnNewLog.MaximumSize = new System.Drawing.Size(252, 47);
            this.btnNewLog.Name = "btnNewLog";
            this.btnNewLog.Size = new System.Drawing.Size(170, 36);
            this.btnNewLog.TabIndex = 6;
            this.btnNewLog.Text = "Додати запис";
            this.btnNewLog.UseVisualStyleBackColor = false;
            this.btnNewLog.Click += new System.EventHandler(this.btnNewAnimal_Click);
            // 
            // lblBack3
            // 
            this.lblBack3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(211)))), ((int)(((byte)(11)))));
            this.lblBack3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblBack3.Font = new System.Drawing.Font("Onest ExtraBold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblBack3.Location = new System.Drawing.Point(3, 0);
            this.lblBack3.Name = "lblBack3";
            this.lblBack3.Size = new System.Drawing.Size(42, 44);
            this.lblBack3.TabIndex = 14;
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
            this.label4.Size = new System.Drawing.Size(1070, 100);
            this.label4.TabIndex = 13;
            this.label4.Text = "Журнал відвідувань";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // id_visit
            // 
            this.id_visit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.id_visit.DataPropertyName = "id_visit";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            this.id_visit.DefaultCellStyle = dataGridViewCellStyle1;
            this.id_visit.FillWeight = 187.1657F;
            this.id_visit.HeaderText = "id";
            this.id_visit.MinimumWidth = 6;
            this.id_visit.Name = "id_visit";
            this.id_visit.ReadOnly = true;
            this.id_visit.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.id_visit.Width = 50;
            // 
            // client
            // 
            this.client.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.client.DataPropertyName = "id_client";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            this.client.DefaultCellStyle = dataGridViewCellStyle2;
            this.client.FillWeight = 85.47237F;
            this.client.HeaderText = "Клієнт";
            this.client.MinimumWidth = 100;
            this.client.Name = "client";
            this.client.ReadOnly = true;
            this.client.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.client.Width = 120;
            // 
            // animal
            // 
            this.animal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.animal.DataPropertyName = "id_animal";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            this.animal.DefaultCellStyle = dataGridViewCellStyle3;
            this.animal.FillWeight = 85.47237F;
            this.animal.HeaderText = "Тварина";
            this.animal.MinimumWidth = 100;
            this.animal.Name = "animal";
            this.animal.ReadOnly = true;
            this.animal.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // worker
            // 
            this.worker.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.worker.DataPropertyName = "id_worker";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            this.worker.DefaultCellStyle = dataGridViewCellStyle4;
            this.worker.FillWeight = 85.47237F;
            this.worker.HeaderText = "Лікар";
            this.worker.MinimumWidth = 100;
            this.worker.Name = "worker";
            this.worker.ReadOnly = true;
            this.worker.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.worker.Width = 120;
            // 
            // date
            // 
            this.date.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.date.DataPropertyName = "date";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            this.date.DefaultCellStyle = dataGridViewCellStyle5;
            this.date.HeaderText = "Дата";
            this.date.MinimumWidth = 75;
            this.date.Name = "date";
            this.date.ReadOnly = true;
            this.date.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.date.Width = 125;
            // 
            // time
            // 
            this.time.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.time.DataPropertyName = "time";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            this.time.DefaultCellStyle = dataGridViewCellStyle6;
            this.time.HeaderText = "Час";
            this.time.MinimumWidth = 75;
            this.time.Name = "time";
            this.time.ReadOnly = true;
            this.time.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.time.Width = 75;
            // 
            // symptoms
            // 
            this.symptoms.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.symptoms.DataPropertyName = "symptoms";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            this.symptoms.DefaultCellStyle = dataGridViewCellStyle7;
            this.symptoms.HeaderText = "Симптоми";
            this.symptoms.MinimumWidth = 100;
            this.symptoms.Name = "symptoms";
            this.symptoms.ReadOnly = true;
            // 
            // update_log
            // 
            this.update_log.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(211)))), ((int)(((byte)(11)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(211)))), ((int)(((byte)(11)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black;
            this.update_log.DefaultCellStyle = dataGridViewCellStyle8;
            this.update_log.FillWeight = 85.47237F;
            this.update_log.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.update_log.HeaderText = "";
            this.update_log.MinimumWidth = 100;
            this.update_log.Name = "update_log";
            this.update_log.ReadOnly = true;
            this.update_log.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.update_log.Text = "Редагувати";
            this.update_log.UseColumnTextForButtonValue = true;
            this.update_log.Width = 125;
            // 
            // delete_log
            // 
            this.delete_log.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.OrangeRed;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Onest", 10F);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.OrangeRed;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Black;
            this.delete_log.DefaultCellStyle = dataGridViewCellStyle9;
            this.delete_log.FillWeight = 85.47237F;
            this.delete_log.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delete_log.HeaderText = "";
            this.delete_log.MinimumWidth = 6;
            this.delete_log.Name = "delete_log";
            this.delete_log.ReadOnly = true;
            this.delete_log.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.delete_log.Text = "Видалити";
            this.delete_log.UseColumnTextForButtonValue = true;
            this.delete_log.Width = 125;
            // 
            // id_client
            // 
            this.id_client.HeaderText = "Column1";
            this.id_client.MinimumWidth = 6;
            this.id_client.Name = "id_client";
            this.id_client.ReadOnly = true;
            // 
            // id_animal
            // 
            this.id_animal.HeaderText = "Column1";
            this.id_animal.MinimumWidth = 6;
            this.id_animal.Name = "id_animal";
            this.id_animal.ReadOnly = true;
            // 
            // id_worker
            // 
            this.id_worker.HeaderText = "Column1";
            this.id_worker.MinimumWidth = 6;
            this.id_worker.Name = "id_worker";
            this.id_worker.ReadOnly = true;
            // 
            // LogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1070, 553);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lblBack3);
            this.Controls.Add(this.label4);
            this.Font = new System.Drawing.Font("Onest", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "LogForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Журнал відвідувань";
            this.Load += new System.EventHandler(this.LogForm_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLog)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvLog;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnNewLog;
        private System.Windows.Forms.Label lblBack3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_visit;
        private System.Windows.Forms.DataGridViewTextBoxColumn client;
        private System.Windows.Forms.DataGridViewTextBoxColumn animal;
        private System.Windows.Forms.DataGridViewTextBoxColumn worker;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.DataGridViewTextBoxColumn time;
        private System.Windows.Forms.DataGridViewTextBoxColumn symptoms;
        private System.Windows.Forms.DataGridViewButtonColumn update_log;
        private System.Windows.Forms.DataGridViewButtonColumn delete_log;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_client;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_animal;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_worker;
    }
}