
namespace ProyectTopicosAvanzados.Views
{
    partial class RegisterConsult
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
            this.panel4 = new System.Windows.Forms.Panel();
            this.buttonRegisterConsult = new FontAwesome.Sharp.IconButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.textBoxSymptom = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxPatient = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 547);
            this.panel1.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.buttonRegisterConsult);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 366);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(800, 100);
            this.panel4.TabIndex = 29;
            // 
            // buttonRegisterConsult
            // 
            this.buttonRegisterConsult.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(86)))), ((int)(((byte)(163)))));
            this.buttonRegisterConsult.FlatAppearance.BorderSize = 0;
            this.buttonRegisterConsult.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRegisterConsult.ForeColor = System.Drawing.Color.White;
            this.buttonRegisterConsult.IconChar = FontAwesome.Sharp.IconChar.Check;
            this.buttonRegisterConsult.IconColor = System.Drawing.Color.White;
            this.buttonRegisterConsult.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.buttonRegisterConsult.IconSize = 15;
            this.buttonRegisterConsult.Location = new System.Drawing.Point(17, 23);
            this.buttonRegisterConsult.Name = "buttonRegisterConsult";
            this.buttonRegisterConsult.Size = new System.Drawing.Size(90, 30);
            this.buttonRegisterConsult.TabIndex = 37;
            this.buttonRegisterConsult.Text = "Registrar";
            this.buttonRegisterConsult.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonRegisterConsult.UseVisualStyleBackColor = false;
            this.buttonRegisterConsult.Click += new System.EventHandler(this.buttonRegisterConsult_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.textBoxPatient);
            this.panel3.Controls.Add(this.textBoxSymptom);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 61);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(800, 305);
            this.panel3.TabIndex = 28;
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
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 61);
            this.panel2.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 30);
            this.label1.TabIndex = 15;
            this.label1.Text = "Registrar consulta";
            // 
            // textBoxPatient
            // 
            this.textBoxPatient.FormattingEnabled = true;
            this.textBoxPatient.Location = new System.Drawing.Point(17, 32);
            this.textBoxPatient.Name = "textBoxPatient";
            this.textBoxPatient.Size = new System.Drawing.Size(121, 21);
            this.textBoxPatient.TabIndex = 36;
            // 
            // RegisterConsult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 547);
            this.Controls.Add(this.panel1);
            this.Name = "RegisterConsult";
            this.Text = "RegisteConsult";
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private FontAwesome.Sharp.IconButton buttonRegisterConsult;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox textBoxSymptom;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox textBoxPatient;
    }
}