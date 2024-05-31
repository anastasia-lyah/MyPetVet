namespace MyPetVet
{
    partial class NewAnimalForm
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnAddSpecies = new System.Windows.Forms.Button();
            this.dtpBirth = new System.Windows.Forms.DateTimePicker();
            this.cmbSpecies = new System.Windows.Forms.ComboBox();
            this.cmbBreed = new System.Windows.Forms.ComboBox();
            this.cmbClient = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblText = new System.Windows.Forms.Label();
            this.lblText1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAddBreed = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.btnAddSpecies);
            this.panel2.Controls.Add(this.dtpBirth);
            this.panel2.Controls.Add(this.cmbSpecies);
            this.panel2.Controls.Add(this.cmbBreed);
            this.panel2.Controls.Add(this.cmbClient);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.btnSave);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txtName);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(26, 128);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(441, 445);
            this.panel2.TabIndex = 3;
            // 
            // btnAddSpecies
            // 
            this.btnAddSpecies.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(211)))), ((int)(((byte)(11)))));
            this.btnAddSpecies.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAddSpecies.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddSpecies.FlatAppearance.BorderSize = 0;
            this.btnAddSpecies.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(156)))), ((int)(((byte)(7)))));
            this.btnAddSpecies.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(156)))), ((int)(((byte)(7)))));
            this.btnAddSpecies.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddSpecies.Font = new System.Drawing.Font("Onest", 10F, System.Drawing.FontStyle.Bold);
            this.btnAddSpecies.Location = new System.Drawing.Point(364, 129);
            this.btnAddSpecies.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAddSpecies.MaximumSize = new System.Drawing.Size(252, 47);
            this.btnAddSpecies.Name = "btnAddSpecies";
            this.btnAddSpecies.Size = new System.Drawing.Size(35, 35);
            this.btnAddSpecies.TabIndex = 11;
            this.btnAddSpecies.Text = "+";
            this.btnAddSpecies.UseVisualStyleBackColor = false;
            this.btnAddSpecies.Click += new System.EventHandler(this.btnAddSpecies_Click);
            // 
            // dtpBirth
            // 
            this.dtpBirth.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtpBirth.Font = new System.Drawing.Font("Onest", 10F);
            this.dtpBirth.Location = new System.Drawing.Point(61, 338);
            this.dtpBirth.Name = "dtpBirth";
            this.dtpBirth.Size = new System.Drawing.Size(296, 29);
            this.dtpBirth.TabIndex = 14;
            this.dtpBirth.Value = new System.DateTime(2024, 5, 24, 15, 11, 4, 0);
            // 
            // cmbSpecies
            // 
            this.cmbSpecies.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbSpecies.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSpecies.Font = new System.Drawing.Font("Onest", 10F);
            this.cmbSpecies.FormattingEnabled = true;
            this.cmbSpecies.Location = new System.Drawing.Point(61, 129);
            this.cmbSpecies.Name = "cmbSpecies";
            this.cmbSpecies.Size = new System.Drawing.Size(296, 35);
            this.cmbSpecies.TabIndex = 13;
            // 
            // cmbBreed
            // 
            this.cmbBreed.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbBreed.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBreed.Font = new System.Drawing.Font("Onest", 10F);
            this.cmbBreed.FormattingEnabled = true;
            this.cmbBreed.Location = new System.Drawing.Point(61, 199);
            this.cmbBreed.Name = "cmbBreed";
            this.cmbBreed.Size = new System.Drawing.Size(296, 35);
            this.cmbBreed.TabIndex = 12;
            // 
            // cmbClient
            // 
            this.cmbClient.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbClient.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbClient.Font = new System.Drawing.Font("Onest", 10F);
            this.cmbClient.FormattingEnabled = true;
            this.cmbClient.Location = new System.Drawing.Point(61, 61);
            this.cmbClient.Name = "cmbClient";
            this.cmbClient.Size = new System.Drawing.Size(296, 35);
            this.cmbClient.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Onest", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(61, 237);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 27);
            this.label6.TabIndex = 10;
            this.label6.Text = "Ім\'я:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Onest", 10F);
            this.label4.Location = new System.Drawing.Point(61, 299);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(160, 27);
            this.label4.TabIndex = 9;
            this.label4.Text = "Дата народження:";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(211)))), ((int)(((byte)(11)))));
            this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(156)))), ((int)(((byte)(7)))));
            this.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(156)))), ((int)(((byte)(7)))));
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Onest", 10F);
            this.btnSave.Location = new System.Drawing.Point(127, 390);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSave.MaximumSize = new System.Drawing.Size(252, 47);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(170, 41);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Зберегти";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click_1);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Onest", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(61, 167);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 27);
            this.label5.TabIndex = 6;
            this.label5.Text = "Порода:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Onest", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(61, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 27);
            this.label3.TabIndex = 2;
            this.label3.Text = "Вид:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtName
            // 
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtName.Font = new System.Drawing.Font("Onest", 10F);
            this.txtName.Location = new System.Drawing.Point(61, 267);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(296, 29);
            this.txtName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Onest", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(61, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 27);
            this.label2.TabIndex = 0;
            this.label2.Text = "Власник:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblText
            // 
            this.lblText.BackColor = System.Drawing.SystemColors.Control;
            this.lblText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblText.Font = new System.Drawing.Font("Onest", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblText.Location = new System.Drawing.Point(0, 0);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(493, 597);
            this.lblText.TabIndex = 2;
            this.lblText.Text = "Додати клієнта";
            this.lblText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblText1
            // 
            this.lblText1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(211)))), ((int)(((byte)(11)))));
            this.lblText1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblText1.Font = new System.Drawing.Font("Onest", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblText1.Location = new System.Drawing.Point(0, 0);
            this.lblText1.Name = "lblText1";
            this.lblText1.Size = new System.Drawing.Size(493, 100);
            this.lblText1.TabIndex = 0;
            this.lblText1.Text = "Додати тварину";
            this.lblText1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(211)))), ((int)(((byte)(11)))));
            this.panel1.Controls.Add(this.lblText1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(493, 100);
            this.panel1.TabIndex = 4;
            // 
            // btnAddBreed
            // 
            this.btnAddBreed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(211)))), ((int)(((byte)(11)))));
            this.btnAddBreed.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAddBreed.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddBreed.FlatAppearance.BorderSize = 0;
            this.btnAddBreed.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(156)))), ((int)(((byte)(7)))));
            this.btnAddBreed.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(156)))), ((int)(((byte)(7)))));
            this.btnAddBreed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddBreed.Font = new System.Drawing.Font("Onest", 10F, System.Drawing.FontStyle.Bold);
            this.btnAddBreed.Location = new System.Drawing.Point(390, 327);
            this.btnAddBreed.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAddBreed.MaximumSize = new System.Drawing.Size(252, 47);
            this.btnAddBreed.Name = "btnAddBreed";
            this.btnAddBreed.Size = new System.Drawing.Size(35, 36);
            this.btnAddBreed.TabIndex = 15;
            this.btnAddBreed.Text = "+";
            this.btnAddBreed.UseVisualStyleBackColor = false;
            this.btnAddBreed.Click += new System.EventHandler(this.btnAddBreed_Click);
            // 
            // NewAnimalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 597);
            this.Controls.Add(this.btnAddBreed);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lblText);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "NewAnimalForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MyPetVet";
            this.Load += new System.EventHandler(this.NewAnimalForm_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblText;
        private System.Windows.Forms.Label lblText1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cmbClient;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpBirth;
        private System.Windows.Forms.ComboBox cmbSpecies;
        private System.Windows.Forms.ComboBox cmbBreed;
        private System.Windows.Forms.Button btnAddSpecies;
        private System.Windows.Forms.Button btnAddBreed;
    }
}