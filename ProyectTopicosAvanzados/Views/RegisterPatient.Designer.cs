
namespace ProyectTopicosAvanzados.Views
{
    partial class RegisterPatient
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonRegisterConsult = new FontAwesome.Sharp.IconButton();
            this.textBoxAge = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxSS = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxUnity = new System.Windows.Forms.ComboBox();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 61);
            this.panel2.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 30);
            this.label1.TabIndex = 15;
            this.label1.Text = "Registrar paciente";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBoxUnity);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.buttonRegisterConsult);
            this.panel1.Controls.Add(this.textBoxAge);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.textBoxSS);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.textBoxName);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 61);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 387);
            this.panel1.TabIndex = 29;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(14, 224);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 13);
            this.label5.TabIndex = 40;
            this.label5.Text = "Número de unidad";
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
            this.buttonRegisterConsult.Location = new System.Drawing.Point(17, 306);
            this.buttonRegisterConsult.Name = "buttonRegisterConsult";
            this.buttonRegisterConsult.Size = new System.Drawing.Size(90, 30);
            this.buttonRegisterConsult.TabIndex = 39;
            this.buttonRegisterConsult.Text = "Registrar";
            this.buttonRegisterConsult.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonRegisterConsult.UseVisualStyleBackColor = false;
            this.buttonRegisterConsult.Click += new System.EventHandler(this.buttonRegisterConsult_Click);
            // 
            // textBoxAge
            // 
            this.textBoxAge.Location = new System.Drawing.Point(17, 171);
            this.textBoxAge.Name = "textBoxAge";
            this.textBoxAge.Size = new System.Drawing.Size(183, 20);
            this.textBoxAge.TabIndex = 38;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(14, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 37;
            this.label4.Text = "Edad";
            // 
            // textBoxSS
            // 
            this.textBoxSS.Location = new System.Drawing.Point(17, 99);
            this.textBoxSS.Name = "textBoxSS";
            this.textBoxSS.Size = new System.Drawing.Size(183, 20);
            this.textBoxSS.TabIndex = 36;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 13);
            this.label3.TabIndex = 35;
            this.label3.Text = "Número de seguro social";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(17, 34);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(183, 20);
            this.textBoxName.TabIndex = 34;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 33;
            this.label2.Text = "Nombre";
            // 
            // textBoxUnity
            // 
            this.textBoxUnity.FormattingEnabled = true;
            this.textBoxUnity.Location = new System.Drawing.Point(17, 252);
            this.textBoxUnity.Name = "textBoxUnity";
            this.textBoxUnity.Size = new System.Drawing.Size(121, 21);
            this.textBoxUnity.TabIndex = 53;
            // 
            // RegisterPatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "RegisterPatient";
            this.Text = "RegisterPatient";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBoxAge;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxSS;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label label2;
        private FontAwesome.Sharp.IconButton buttonRegisterConsult;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox textBoxUnity;
    }
}