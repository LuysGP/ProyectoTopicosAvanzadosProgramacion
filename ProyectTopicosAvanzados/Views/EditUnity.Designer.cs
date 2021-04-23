namespace ProyectTopicosAvanzados.Views
{
    partial class EditUnity
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
            this.buttonDeleteUnity = new FontAwesome.Sharp.IconButton();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonUpdateUnit = new FontAwesome.Sharp.IconButton();
            this.textBoxPlant = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBoxUnity = new System.Windows.Forms.ComboBox();
            this.buttonSearchUnity = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxDoctorId = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBoxDoctorId);
            this.panel1.Controls.Add(this.buttonDeleteUnity);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.buttonUpdateUnit);
            this.panel1.Controls.Add(this.textBoxPlant);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.textBoxName);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 149);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 301);
            this.panel1.TabIndex = 34;
            // 
            // buttonDeleteUnity
            // 
            this.buttonDeleteUnity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(86)))), ((int)(((byte)(163)))));
            this.buttonDeleteUnity.FlatAppearance.BorderSize = 0;
            this.buttonDeleteUnity.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDeleteUnity.ForeColor = System.Drawing.Color.White;
            this.buttonDeleteUnity.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.buttonDeleteUnity.IconColor = System.Drawing.Color.White;
            this.buttonDeleteUnity.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.buttonDeleteUnity.IconSize = 15;
            this.buttonDeleteUnity.Location = new System.Drawing.Point(121, 231);
            this.buttonDeleteUnity.Name = "buttonDeleteUnity";
            this.buttonDeleteUnity.Size = new System.Drawing.Size(90, 30);
            this.buttonDeleteUnity.TabIndex = 47;
            this.buttonDeleteUnity.Text = "Eliminar";
            this.buttonDeleteUnity.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonDeleteUnity.UseVisualStyleBackColor = false;
            this.buttonDeleteUnity.Click += new System.EventHandler(this.buttonDeleteUnity_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(9, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 45;
            this.label4.Text = "Doctor id";
            // 
            // buttonUpdateUnit
            // 
            this.buttonUpdateUnit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(86)))), ((int)(((byte)(163)))));
            this.buttonUpdateUnit.FlatAppearance.BorderSize = 0;
            this.buttonUpdateUnit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUpdateUnit.ForeColor = System.Drawing.Color.White;
            this.buttonUpdateUnit.IconChar = FontAwesome.Sharp.IconChar.Check;
            this.buttonUpdateUnit.IconColor = System.Drawing.Color.White;
            this.buttonUpdateUnit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.buttonUpdateUnit.IconSize = 15;
            this.buttonUpdateUnit.Location = new System.Drawing.Point(12, 231);
            this.buttonUpdateUnit.Name = "buttonUpdateUnit";
            this.buttonUpdateUnit.Size = new System.Drawing.Size(90, 30);
            this.buttonUpdateUnit.TabIndex = 44;
            this.buttonUpdateUnit.Text = "Actualizar";
            this.buttonUpdateUnit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonUpdateUnit.UseVisualStyleBackColor = false;
            this.buttonUpdateUnit.Click += new System.EventHandler(this.buttonUpdateUnit_Click);
            // 
            // textBoxPlant
            // 
            this.textBoxPlant.Location = new System.Drawing.Point(12, 104);
            this.textBoxPlant.Name = "textBoxPlant";
            this.textBoxPlant.Size = new System.Drawing.Size(183, 20);
            this.textBoxPlant.TabIndex = 43;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 42;
            this.label3.Text = "Planta";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(12, 39);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(183, 20);
            this.textBoxName.TabIndex = 41;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 40;
            this.label2.Text = "Nombre";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.textBoxUnity);
            this.panel2.Controls.Add(this.buttonSearchUnity);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 149);
            this.panel2.TabIndex = 33;
            // 
            // textBoxUnity
            // 
            this.textBoxUnity.FormattingEnabled = true;
            this.textBoxUnity.Location = new System.Drawing.Point(12, 79);
            this.textBoxUnity.Name = "textBoxUnity";
            this.textBoxUnity.Size = new System.Drawing.Size(121, 21);
            this.textBoxUnity.TabIndex = 50;
            // 
            // buttonSearchUnity
            // 
            this.buttonSearchUnity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(86)))), ((int)(((byte)(163)))));
            this.buttonSearchUnity.FlatAppearance.BorderSize = 0;
            this.buttonSearchUnity.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSearchUnity.ForeColor = System.Drawing.Color.White;
            this.buttonSearchUnity.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.buttonSearchUnity.IconColor = System.Drawing.Color.White;
            this.buttonSearchUnity.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.buttonSearchUnity.IconSize = 15;
            this.buttonSearchUnity.Location = new System.Drawing.Point(12, 106);
            this.buttonSearchUnity.Name = "buttonSearchUnity";
            this.buttonSearchUnity.Size = new System.Drawing.Size(90, 30);
            this.buttonSearchUnity.TabIndex = 49;
            this.buttonSearchUnity.Text = "Buscar";
            this.buttonSearchUnity.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonSearchUnity.UseVisualStyleBackColor = false;
            this.buttonSearchUnity.Click += new System.EventHandler(this.buttonSearchUnity_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 30);
            this.label1.TabIndex = 15;
            this.label1.Text = "Detalles de la unidad";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(9, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 13);
            this.label5.TabIndex = 47;
            this.label5.Text = "Buscar unidad";
            // 
            // textBoxDoctorId
            // 
            this.textBoxDoctorId.FormattingEnabled = true;
            this.textBoxDoctorId.Location = new System.Drawing.Point(12, 168);
            this.textBoxDoctorId.Name = "textBoxDoctorId";
            this.textBoxDoctorId.Size = new System.Drawing.Size(121, 21);
            this.textBoxDoctorId.TabIndex = 48;
            // 
            // EditUnity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "EditUnity";
            this.Text = "EditUnity";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private FontAwesome.Sharp.IconButton buttonUpdateUnit;
        private System.Windows.Forms.TextBox textBoxPlant;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton buttonSearchUnity;
        private System.Windows.Forms.Label label5;
        private FontAwesome.Sharp.IconButton buttonDeleteUnity;
        private System.Windows.Forms.ComboBox textBoxUnity;
        private System.Windows.Forms.ComboBox textBoxDoctorId;
    }
}