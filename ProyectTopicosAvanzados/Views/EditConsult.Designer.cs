
namespace ProyectTopicosAvanzados.Views
{
    partial class EditConsult
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBoxID = new System.Windows.Forms.ComboBox();
            this.buttonSearchConsult = new FontAwesome.Sharp.IconButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonDeleteConsult = new FontAwesome.Sharp.IconButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.textBoxPatient = new System.Windows.Forms.ComboBox();
            this.textBoxRegister = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxSymptom = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonUpdateConsult = new FontAwesome.Sharp.IconButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBoxID);
            this.panel1.Controls.Add(this.buttonSearchConsult);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 144);
            this.panel1.TabIndex = 0;
            // 
            // textBoxID
            // 
            this.textBoxID.FormattingEnabled = true;
            this.textBoxID.Location = new System.Drawing.Point(12, 77);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(121, 21);
            this.textBoxID.TabIndex = 25;
            // 
            // buttonSearchConsult
            // 
            this.buttonSearchConsult.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(86)))), ((int)(((byte)(163)))));
            this.buttonSearchConsult.FlatAppearance.BorderSize = 0;
            this.buttonSearchConsult.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSearchConsult.ForeColor = System.Drawing.Color.White;
            this.buttonSearchConsult.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.buttonSearchConsult.IconColor = System.Drawing.Color.White;
            this.buttonSearchConsult.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.buttonSearchConsult.IconSize = 15;
            this.buttonSearchConsult.Location = new System.Drawing.Point(12, 104);
            this.buttonSearchConsult.Name = "buttonSearchConsult";
            this.buttonSearchConsult.Size = new System.Drawing.Size(90, 30);
            this.buttonSearchConsult.TabIndex = 24;
            this.buttonSearchConsult.Text = "Buscar";
            this.buttonSearchConsult.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonSearchConsult.UseVisualStyleBackColor = false;
            this.buttonSearchConsult.Click += new System.EventHandler(this.buttonSearchConsult_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "Ingresa el id de la consulta";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 30);
            this.label1.TabIndex = 22;
            this.label1.Text = "Editar consulta";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.buttonDeleteConsult);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.buttonUpdateConsult);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 144);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 392);
            this.panel2.TabIndex = 1;
            // 
            // buttonDeleteConsult
            // 
            this.buttonDeleteConsult.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(86)))), ((int)(((byte)(163)))));
            this.buttonDeleteConsult.FlatAppearance.BorderSize = 0;
            this.buttonDeleteConsult.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDeleteConsult.ForeColor = System.Drawing.Color.White;
            this.buttonDeleteConsult.IconChar = FontAwesome.Sharp.IconChar.Check;
            this.buttonDeleteConsult.IconColor = System.Drawing.Color.White;
            this.buttonDeleteConsult.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.buttonDeleteConsult.IconSize = 15;
            this.buttonDeleteConsult.Location = new System.Drawing.Point(141, 303);
            this.buttonDeleteConsult.Name = "buttonDeleteConsult";
            this.buttonDeleteConsult.Size = new System.Drawing.Size(90, 30);
            this.buttonDeleteConsult.TabIndex = 49;
            this.buttonDeleteConsult.Text = "Eliminar";
            this.buttonDeleteConsult.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonDeleteConsult.UseVisualStyleBackColor = false;
            this.buttonDeleteConsult.Click += new System.EventHandler(this.buttonDeleteConsult_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dataGridView1);
            this.panel3.Controls.Add(this.textBoxPatient);
            this.panel3.Controls.Add(this.textBoxRegister);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.textBoxSymptom);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(800, 305);
            this.panel3.TabIndex = 48;
            // 
            // textBoxPatient
            // 
            this.textBoxPatient.FormattingEnabled = true;
            this.textBoxPatient.Location = new System.Drawing.Point(12, 31);
            this.textBoxPatient.Name = "textBoxPatient";
            this.textBoxPatient.Size = new System.Drawing.Size(121, 21);
            this.textBoxPatient.TabIndex = 35;
            // 
            // textBoxRegister
            // 
            this.textBoxRegister.Location = new System.Drawing.Point(17, 186);
            this.textBoxRegister.Name = "textBoxRegister";
            this.textBoxRegister.Size = new System.Drawing.Size(200, 20);
            this.textBoxRegister.TabIndex = 34;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(14, 156);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 33;
            this.label5.Text = "Fecha";
            // 
            // textBoxSymptom
            // 
            this.textBoxSymptom.Location = new System.Drawing.Point(17, 104);
            this.textBoxSymptom.Name = "textBoxSymptom";
            this.textBoxSymptom.Size = new System.Drawing.Size(183, 20);
            this.textBoxSymptom.TabIndex = 32;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(14, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 31;
            this.label4.Text = "Sintomas";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 29;
            this.label3.Text = "Paciente SS";
            // 
            // buttonUpdateConsult
            // 
            this.buttonUpdateConsult.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(86)))), ((int)(((byte)(163)))));
            this.buttonUpdateConsult.FlatAppearance.BorderSize = 0;
            this.buttonUpdateConsult.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUpdateConsult.ForeColor = System.Drawing.Color.White;
            this.buttonUpdateConsult.IconChar = FontAwesome.Sharp.IconChar.Check;
            this.buttonUpdateConsult.IconColor = System.Drawing.Color.White;
            this.buttonUpdateConsult.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.buttonUpdateConsult.IconSize = 15;
            this.buttonUpdateConsult.Location = new System.Drawing.Point(12, 303);
            this.buttonUpdateConsult.Name = "buttonUpdateConsult";
            this.buttonUpdateConsult.Size = new System.Drawing.Size(90, 30);
            this.buttonUpdateConsult.TabIndex = 47;
            this.buttonUpdateConsult.Text = "Actualizar";
            this.buttonUpdateConsult.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonUpdateConsult.UseVisualStyleBackColor = false;
            this.buttonUpdateConsult.Click += new System.EventHandler(this.buttonUpdateConsult_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(303, 18);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(485, 272);
            this.dataGridView1.TabIndex = 36;
            // 
            // EditConsult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 534);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "EditConsult";
            this.Text = "EditConsult";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton buttonSearchConsult;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private FontAwesome.Sharp.IconButton buttonUpdateConsult;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox textBoxSymptom;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private FontAwesome.Sharp.IconButton buttonDeleteConsult;
        private System.Windows.Forms.DateTimePicker textBoxRegister;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox textBoxID;
        private System.Windows.Forms.ComboBox textBoxPatient;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}