
namespace ProyectTopicosAvanzados.Views
{
    partial class EditDoctor
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
            this.textBoxDoctor = new System.Windows.Forms.ComboBox();
            this.buttonSearchDoctor = new FontAwesome.Sharp.IconButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonDeleteDoctor = new FontAwesome.Sharp.IconButton();
            this.buttonUpdateDoctor = new FontAwesome.Sharp.IconButton();
            this.textBoxEspeciality = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.textBoxDoctor);
            this.panel2.Controls.Add(this.buttonSearchDoctor);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 157);
            this.panel2.TabIndex = 17;
            // 
            // textBoxDoctor
            // 
            this.textBoxDoctor.FormattingEnabled = true;
            this.textBoxDoctor.Location = new System.Drawing.Point(13, 68);
            this.textBoxDoctor.Name = "textBoxDoctor";
            this.textBoxDoctor.Size = new System.Drawing.Size(121, 21);
            this.textBoxDoctor.TabIndex = 17;
            // 
            // buttonSearchDoctor
            // 
            this.buttonSearchDoctor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(86)))), ((int)(((byte)(163)))));
            this.buttonSearchDoctor.FlatAppearance.BorderSize = 0;
            this.buttonSearchDoctor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSearchDoctor.ForeColor = System.Drawing.Color.White;
            this.buttonSearchDoctor.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.buttonSearchDoctor.IconColor = System.Drawing.Color.White;
            this.buttonSearchDoctor.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.buttonSearchDoctor.IconSize = 15;
            this.buttonSearchDoctor.Location = new System.Drawing.Point(12, 103);
            this.buttonSearchDoctor.Name = "buttonSearchDoctor";
            this.buttonSearchDoctor.Size = new System.Drawing.Size(90, 30);
            this.buttonSearchDoctor.TabIndex = 16;
            this.buttonSearchDoctor.Text = "Buscar";
            this.buttonSearchDoctor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonSearchDoctor.UseVisualStyleBackColor = false;
            this.buttonSearchDoctor.Click += new System.EventHandler(this.buttonSearchDoctor_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Ingresa el id del doctor a editar";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 30);
            this.label1.TabIndex = 13;
            this.label1.Text = "Editar doctor";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.buttonDeleteDoctor);
            this.panel1.Controls.Add(this.buttonUpdateDoctor);
            this.panel1.Controls.Add(this.textBoxEspeciality);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.textBoxName);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 157);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 293);
            this.panel1.TabIndex = 18;
            // 
            // buttonDeleteDoctor
            // 
            this.buttonDeleteDoctor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(86)))), ((int)(((byte)(163)))));
            this.buttonDeleteDoctor.FlatAppearance.BorderSize = 0;
            this.buttonDeleteDoctor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDeleteDoctor.ForeColor = System.Drawing.Color.White;
            this.buttonDeleteDoctor.IconChar = FontAwesome.Sharp.IconChar.Check;
            this.buttonDeleteDoctor.IconColor = System.Drawing.Color.White;
            this.buttonDeleteDoctor.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.buttonDeleteDoctor.IconSize = 15;
            this.buttonDeleteDoctor.Location = new System.Drawing.Point(117, 170);
            this.buttonDeleteDoctor.Name = "buttonDeleteDoctor";
            this.buttonDeleteDoctor.Size = new System.Drawing.Size(90, 30);
            this.buttonDeleteDoctor.TabIndex = 45;
            this.buttonDeleteDoctor.Text = "Eliminar";
            this.buttonDeleteDoctor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonDeleteDoctor.UseVisualStyleBackColor = false;
            this.buttonDeleteDoctor.Click += new System.EventHandler(this.buttonDeleteDoctor_Click);
            // 
            // buttonUpdateDoctor
            // 
            this.buttonUpdateDoctor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(86)))), ((int)(((byte)(163)))));
            this.buttonUpdateDoctor.FlatAppearance.BorderSize = 0;
            this.buttonUpdateDoctor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUpdateDoctor.ForeColor = System.Drawing.Color.White;
            this.buttonUpdateDoctor.IconChar = FontAwesome.Sharp.IconChar.Check;
            this.buttonUpdateDoctor.IconColor = System.Drawing.Color.White;
            this.buttonUpdateDoctor.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.buttonUpdateDoctor.IconSize = 15;
            this.buttonUpdateDoctor.Location = new System.Drawing.Point(12, 170);
            this.buttonUpdateDoctor.Name = "buttonUpdateDoctor";
            this.buttonUpdateDoctor.Size = new System.Drawing.Size(90, 30);
            this.buttonUpdateDoctor.TabIndex = 44;
            this.buttonUpdateDoctor.Text = "Actualizar";
            this.buttonUpdateDoctor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonUpdateDoctor.UseVisualStyleBackColor = false;
            this.buttonUpdateDoctor.Click += new System.EventHandler(this.buttonUpdateDoctor_Click);
            // 
            // textBoxEspeciality
            // 
            this.textBoxEspeciality.Location = new System.Drawing.Point(12, 104);
            this.textBoxEspeciality.Name = "textBoxEspeciality";
            this.textBoxEspeciality.Size = new System.Drawing.Size(183, 20);
            this.textBoxEspeciality.TabIndex = 43;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 42;
            this.label3.Text = "Especialidad";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(12, 39);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(183, 20);
            this.textBoxName.TabIndex = 41;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(9, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 40;
            this.label4.Text = "Nombre";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(262, 13);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(485, 272);
            this.dataGridView1.TabIndex = 37;
            // 
            // EditDoctor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "EditDoctor";
            this.Text = "EditDoctor";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private FontAwesome.Sharp.IconButton buttonSearchDoctor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton buttonUpdateDoctor;
        private System.Windows.Forms.TextBox textBoxEspeciality;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label label4;
        private FontAwesome.Sharp.IconButton buttonDeleteDoctor;
        private System.Windows.Forms.ComboBox textBoxDoctor;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}