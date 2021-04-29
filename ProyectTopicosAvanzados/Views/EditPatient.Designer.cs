
namespace ProyectTopicosAvanzados.Views
{
    partial class EditPatient
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
            this.textBoxSS = new System.Windows.Forms.ComboBox();
            this.searchPatientButton = new FontAwesome.Sharp.IconButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBoxUnity = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonDelete = new FontAwesome.Sharp.IconButton();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.buttonRegisterConsult = new FontAwesome.Sharp.IconButton();
            this.textBoxAge = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.textBoxSS);
            this.panel2.Controls.Add(this.searchPatientButton);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 146);
            this.panel2.TabIndex = 15;
            // 
            // textBoxSS
            // 
            this.textBoxSS.FormattingEnabled = true;
            this.textBoxSS.Location = new System.Drawing.Point(12, 67);
            this.textBoxSS.Name = "textBoxSS";
            this.textBoxSS.Size = new System.Drawing.Size(121, 21);
            this.textBoxSS.TabIndex = 20;
            // 
            // searchPatientButton
            // 
            this.searchPatientButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(86)))), ((int)(((byte)(163)))));
            this.searchPatientButton.FlatAppearance.BorderSize = 0;
            this.searchPatientButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchPatientButton.ForeColor = System.Drawing.Color.White;
            this.searchPatientButton.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.searchPatientButton.IconColor = System.Drawing.Color.White;
            this.searchPatientButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.searchPatientButton.IconSize = 15;
            this.searchPatientButton.Location = new System.Drawing.Point(12, 103);
            this.searchPatientButton.Name = "searchPatientButton";
            this.searchPatientButton.Size = new System.Drawing.Size(90, 30);
            this.searchPatientButton.TabIndex = 19;
            this.searchPatientButton.Text = "Buscar";
            this.searchPatientButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.searchPatientButton.UseVisualStyleBackColor = false;
            this.searchPatientButton.Click += new System.EventHandler(this.searchPatientButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Ingresa el SS del paciente";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 30);
            this.label1.TabIndex = 13;
            this.label1.Text = "Pacientes";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.textBoxUnity);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.buttonDelete);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.buttonRegisterConsult);
            this.panel1.Controls.Add(this.textBoxAge);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.textBoxName);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 146);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 294);
            this.panel1.TabIndex = 16;
            // 
            // textBoxUnity
            // 
            this.textBoxUnity.FormattingEnabled = true;
            this.textBoxUnity.Location = new System.Drawing.Point(256, 37);
            this.textBoxUnity.Name = "textBoxUnity";
            this.textBoxUnity.Size = new System.Drawing.Size(121, 21);
            this.textBoxUnity.TabIndex = 52;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(253, 11);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 50;
            this.label6.Text = "Unidad";
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(86)))), ((int)(((byte)(163)))));
            this.buttonDelete.Enabled = false;
            this.buttonDelete.FlatAppearance.BorderSize = 0;
            this.buttonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDelete.ForeColor = System.Drawing.Color.White;
            this.buttonDelete.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.buttonDelete.IconColor = System.Drawing.Color.White;
            this.buttonDelete.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.buttonDelete.IconSize = 15;
            this.buttonDelete.Location = new System.Drawing.Point(122, 232);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(90, 30);
            this.buttonDelete.TabIndex = 49;
            this.buttonDelete.Text = "Eliminar";
            this.buttonDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(12, 102);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 48;
            this.dateTimePicker1.Value = new System.DateTime(2021, 4, 21, 9, 46, 25, 0);
            // 
            // buttonRegisterConsult
            // 
            this.buttonRegisterConsult.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(86)))), ((int)(((byte)(163)))));
            this.buttonRegisterConsult.Enabled = false;
            this.buttonRegisterConsult.FlatAppearance.BorderSize = 0;
            this.buttonRegisterConsult.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRegisterConsult.ForeColor = System.Drawing.Color.White;
            this.buttonRegisterConsult.IconChar = FontAwesome.Sharp.IconChar.Check;
            this.buttonRegisterConsult.IconColor = System.Drawing.Color.White;
            this.buttonRegisterConsult.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.buttonRegisterConsult.IconSize = 15;
            this.buttonRegisterConsult.Location = new System.Drawing.Point(12, 232);
            this.buttonRegisterConsult.Name = "buttonRegisterConsult";
            this.buttonRegisterConsult.Size = new System.Drawing.Size(90, 30);
            this.buttonRegisterConsult.TabIndex = 46;
            this.buttonRegisterConsult.Text = "Actualizar";
            this.buttonRegisterConsult.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonRegisterConsult.UseVisualStyleBackColor = false;
            this.buttonRegisterConsult.Click += new System.EventHandler(this.buttonRegisterConsult_Click);
            // 
            // textBoxAge
            // 
            this.textBoxAge.Location = new System.Drawing.Point(12, 174);
            this.textBoxAge.Name = "textBoxAge";
            this.textBoxAge.Size = new System.Drawing.Size(183, 20);
            this.textBoxAge.TabIndex = 45;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(9, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 44;
            this.label4.Text = "Edad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 13);
            this.label3.TabIndex = 42;
            this.label3.Text = "Fecha de ingreso";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(12, 37);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(183, 20);
            this.textBoxName.TabIndex = 41;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(9, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 40;
            this.label5.Text = "Nombre";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(256, 76);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(485, 208);
            this.dataGridView1.TabIndex = 37;
            // 
            // EditPatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "EditPatient";
            this.Text = "EditPatient";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton buttonRegisterConsult;
        private System.Windows.Forms.TextBox textBoxAge;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label label5;
        private FontAwesome.Sharp.IconButton searchPatientButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private FontAwesome.Sharp.IconButton buttonDelete;
        private System.Windows.Forms.ComboBox textBoxSS;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox textBoxUnity;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}