
namespace ProyectTopicosAvanzados
{
    partial class Layout
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Layout));
            this.panelLogo = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.homeButton = new FontAwesome.Sharp.IconButton();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.buttonUnity = new FontAwesome.Sharp.IconButton();
            this.panelDoctors = new System.Windows.Forms.Panel();
            this.button = new System.Windows.Forms.Button();
            this.buttonRegisterDoctor = new System.Windows.Forms.Button();
            this.buttonAllDoctors = new System.Windows.Forms.Button();
            this.panelPatients = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.buttonAllPatientsView = new System.Windows.Forms.Button();
            this.buttonPatients = new FontAwesome.Sharp.IconButton();
            this.panelConsults = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.buttonRegisterConsult = new System.Windows.Forms.Button();
            this.buttonAllConsults = new System.Windows.Forms.Button();
            this.buttonConsults = new FontAwesome.Sharp.IconButton();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.buttonClose = new FontAwesome.Sharp.IconButton();
            this.panelChildForm = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.buttonDoctors = new FontAwesome.Sharp.IconButton();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.mainPanel.SuspendLayout();
            this.panelDoctors.SuspendLayout();
            this.panelPatients.SuspendLayout();
            this.panelConsults.SuspendLayout();
            this.panelHeader.SuspendLayout();
            this.panelChildForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.pictureBox1);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(198, 140);
            this.panelLogo.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(198, 140);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // homeButton
            // 
            this.homeButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.homeButton.FlatAppearance.BorderSize = 0;
            this.homeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.homeButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homeButton.ForeColor = System.Drawing.Color.White;
            this.homeButton.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.homeButton.IconColor = System.Drawing.Color.White;
            this.homeButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.homeButton.IconSize = 30;
            this.homeButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.homeButton.Location = new System.Drawing.Point(0, 140);
            this.homeButton.Name = "homeButton";
            this.homeButton.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.homeButton.Size = new System.Drawing.Size(198, 50);
            this.homeButton.TabIndex = 1;
            this.homeButton.Text = "Inicio";
            this.homeButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.homeButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.homeButton.UseVisualStyleBackColor = true;
            this.homeButton.Click += new System.EventHandler(this.homeButton_Click);
            // 
            // mainPanel
            // 
            this.mainPanel.AutoScroll = true;
            this.mainPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(86)))), ((int)(((byte)(163)))));
            this.mainPanel.Controls.Add(this.buttonUnity);
            this.mainPanel.Controls.Add(this.panelDoctors);
            this.mainPanel.Controls.Add(this.buttonDoctors);
            this.mainPanel.Controls.Add(this.panelPatients);
            this.mainPanel.Controls.Add(this.buttonPatients);
            this.mainPanel.Controls.Add(this.panelConsults);
            this.mainPanel.Controls.Add(this.buttonConsults);
            this.mainPanel.Controls.Add(this.homeButton);
            this.mainPanel.Controls.Add(this.panelLogo);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(215, 561);
            this.mainPanel.TabIndex = 0;
            // 
            // buttonUnity
            // 
            this.buttonUnity.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonUnity.FlatAppearance.BorderSize = 0;
            this.buttonUnity.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUnity.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUnity.ForeColor = System.Drawing.Color.White;
            this.buttonUnity.IconChar = FontAwesome.Sharp.IconChar.ChartLine;
            this.buttonUnity.IconColor = System.Drawing.Color.White;
            this.buttonUnity.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.buttonUnity.IconSize = 30;
            this.buttonUnity.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonUnity.Location = new System.Drawing.Point(0, 652);
            this.buttonUnity.Name = "buttonUnity";
            this.buttonUnity.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.buttonUnity.Size = new System.Drawing.Size(198, 50);
            this.buttonUnity.TabIndex = 9;
            this.buttonUnity.Text = "Unidad";
            this.buttonUnity.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonUnity.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonUnity.UseVisualStyleBackColor = true;
            this.buttonUnity.Click += new System.EventHandler(this.buttonUnity_Click);
            // 
            // panelDoctors
            // 
            this.panelDoctors.Controls.Add(this.button);
            this.panelDoctors.Controls.Add(this.buttonRegisterDoctor);
            this.panelDoctors.Controls.Add(this.buttonAllDoctors);
            this.panelDoctors.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelDoctors.Location = new System.Drawing.Point(0, 548);
            this.panelDoctors.Name = "panelDoctors";
            this.panelDoctors.Size = new System.Drawing.Size(198, 104);
            this.panelDoctors.TabIndex = 8;
            // 
            // button
            // 
            this.button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(107)))), ((int)(((byte)(53)))));
            this.button.Dock = System.Windows.Forms.DockStyle.Top;
            this.button.FlatAppearance.BorderSize = 0;
            this.button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button.ForeColor = System.Drawing.Color.White;
            this.button.Location = new System.Drawing.Point(0, 72);
            this.button.Name = "button";
            this.button.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.button.Size = new System.Drawing.Size(198, 36);
            this.button.TabIndex = 2;
            this.button.Text = "Editar doctor";
            this.button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button.UseVisualStyleBackColor = false;
            this.button.Click += new System.EventHandler(this.button_Click);
            // 
            // buttonRegisterDoctor
            // 
            this.buttonRegisterDoctor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(107)))), ((int)(((byte)(53)))));
            this.buttonRegisterDoctor.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonRegisterDoctor.FlatAppearance.BorderSize = 0;
            this.buttonRegisterDoctor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRegisterDoctor.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRegisterDoctor.ForeColor = System.Drawing.Color.White;
            this.buttonRegisterDoctor.Location = new System.Drawing.Point(0, 36);
            this.buttonRegisterDoctor.Name = "buttonRegisterDoctor";
            this.buttonRegisterDoctor.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.buttonRegisterDoctor.Size = new System.Drawing.Size(198, 36);
            this.buttonRegisterDoctor.TabIndex = 1;
            this.buttonRegisterDoctor.Text = "Registrar doctor";
            this.buttonRegisterDoctor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonRegisterDoctor.UseVisualStyleBackColor = false;
            this.buttonRegisterDoctor.Click += new System.EventHandler(this.buttonRegisterDoctor_Click);
            // 
            // buttonAllDoctors
            // 
            this.buttonAllDoctors.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(107)))), ((int)(((byte)(53)))));
            this.buttonAllDoctors.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonAllDoctors.FlatAppearance.BorderSize = 0;
            this.buttonAllDoctors.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAllDoctors.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAllDoctors.ForeColor = System.Drawing.Color.White;
            this.buttonAllDoctors.Location = new System.Drawing.Point(0, 0);
            this.buttonAllDoctors.Name = "buttonAllDoctors";
            this.buttonAllDoctors.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.buttonAllDoctors.Size = new System.Drawing.Size(198, 36);
            this.buttonAllDoctors.TabIndex = 0;
            this.buttonAllDoctors.Text = "Todos los doctores";
            this.buttonAllDoctors.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAllDoctors.UseVisualStyleBackColor = false;
            this.buttonAllDoctors.Click += new System.EventHandler(this.buttonAllDoctors_Click);
            // 
            // panelPatients
            // 
            this.panelPatients.Controls.Add(this.button4);
            this.panelPatients.Controls.Add(this.button5);
            this.panelPatients.Controls.Add(this.buttonAllPatientsView);
            this.panelPatients.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelPatients.Location = new System.Drawing.Point(0, 394);
            this.panelPatients.Name = "panelPatients";
            this.panelPatients.Size = new System.Drawing.Size(198, 104);
            this.panelPatients.TabIndex = 6;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(107)))), ((int)(((byte)(53)))));
            this.button4.Dock = System.Windows.Forms.DockStyle.Top;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(0, 72);
            this.button4.Name = "button4";
            this.button4.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.button4.Size = new System.Drawing.Size(198, 36);
            this.button4.TabIndex = 2;
            this.button4.Text = "Editar paciente";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(107)))), ((int)(((byte)(53)))));
            this.button5.Dock = System.Windows.Forms.DockStyle.Top;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(0, 36);
            this.button5.Name = "button5";
            this.button5.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.button5.Size = new System.Drawing.Size(198, 36);
            this.button5.TabIndex = 1;
            this.button5.Text = "Registrar paciente";
            this.button5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // buttonAllPatientsView
            // 
            this.buttonAllPatientsView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(107)))), ((int)(((byte)(53)))));
            this.buttonAllPatientsView.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonAllPatientsView.FlatAppearance.BorderSize = 0;
            this.buttonAllPatientsView.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAllPatientsView.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAllPatientsView.ForeColor = System.Drawing.Color.White;
            this.buttonAllPatientsView.Location = new System.Drawing.Point(0, 0);
            this.buttonAllPatientsView.Name = "buttonAllPatientsView";
            this.buttonAllPatientsView.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.buttonAllPatientsView.Size = new System.Drawing.Size(198, 36);
            this.buttonAllPatientsView.TabIndex = 0;
            this.buttonAllPatientsView.Text = "Todos los pacientes";
            this.buttonAllPatientsView.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAllPatientsView.UseVisualStyleBackColor = false;
            this.buttonAllPatientsView.Click += new System.EventHandler(this.button6_Click);
            // 
            // buttonPatients
            // 
            this.buttonPatients.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonPatients.FlatAppearance.BorderSize = 0;
            this.buttonPatients.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPatients.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPatients.ForeColor = System.Drawing.Color.White;
            this.buttonPatients.IconChar = FontAwesome.Sharp.IconChar.BookMedical;
            this.buttonPatients.IconColor = System.Drawing.Color.White;
            this.buttonPatients.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.buttonPatients.IconSize = 30;
            this.buttonPatients.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonPatients.Location = new System.Drawing.Point(0, 344);
            this.buttonPatients.Name = "buttonPatients";
            this.buttonPatients.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.buttonPatients.Size = new System.Drawing.Size(198, 50);
            this.buttonPatients.TabIndex = 5;
            this.buttonPatients.Text = "Pacientes";
            this.buttonPatients.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonPatients.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonPatients.UseVisualStyleBackColor = true;
            this.buttonPatients.Click += new System.EventHandler(this.buttonPatients_Click);
            // 
            // panelConsults
            // 
            this.panelConsults.Controls.Add(this.button3);
            this.panelConsults.Controls.Add(this.buttonRegisterConsult);
            this.panelConsults.Controls.Add(this.buttonAllConsults);
            this.panelConsults.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelConsults.Location = new System.Drawing.Point(0, 240);
            this.panelConsults.Name = "panelConsults";
            this.panelConsults.Size = new System.Drawing.Size(198, 104);
            this.panelConsults.TabIndex = 4;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(107)))), ((int)(((byte)(53)))));
            this.button3.Dock = System.Windows.Forms.DockStyle.Top;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(0, 72);
            this.button3.Name = "button3";
            this.button3.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.button3.Size = new System.Drawing.Size(198, 36);
            this.button3.TabIndex = 2;
            this.button3.Text = "Editar consulta";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // buttonRegisterConsult
            // 
            this.buttonRegisterConsult.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(107)))), ((int)(((byte)(53)))));
            this.buttonRegisterConsult.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonRegisterConsult.FlatAppearance.BorderSize = 0;
            this.buttonRegisterConsult.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRegisterConsult.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRegisterConsult.ForeColor = System.Drawing.Color.White;
            this.buttonRegisterConsult.Location = new System.Drawing.Point(0, 36);
            this.buttonRegisterConsult.Name = "buttonRegisterConsult";
            this.buttonRegisterConsult.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.buttonRegisterConsult.Size = new System.Drawing.Size(198, 36);
            this.buttonRegisterConsult.TabIndex = 1;
            this.buttonRegisterConsult.Text = "Registrar consulta";
            this.buttonRegisterConsult.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonRegisterConsult.UseVisualStyleBackColor = false;
            this.buttonRegisterConsult.Click += new System.EventHandler(this.buttonRegisterConsult_Click);
            // 
            // buttonAllConsults
            // 
            this.buttonAllConsults.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(107)))), ((int)(((byte)(53)))));
            this.buttonAllConsults.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonAllConsults.FlatAppearance.BorderSize = 0;
            this.buttonAllConsults.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAllConsults.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAllConsults.ForeColor = System.Drawing.Color.White;
            this.buttonAllConsults.Location = new System.Drawing.Point(0, 0);
            this.buttonAllConsults.Name = "buttonAllConsults";
            this.buttonAllConsults.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.buttonAllConsults.Size = new System.Drawing.Size(198, 36);
            this.buttonAllConsults.TabIndex = 0;
            this.buttonAllConsults.Text = "Todas las consultas";
            this.buttonAllConsults.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAllConsults.UseVisualStyleBackColor = false;
            this.buttonAllConsults.Click += new System.EventHandler(this.buttonAllConsults_Click);
            // 
            // buttonConsults
            // 
            this.buttonConsults.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonConsults.FlatAppearance.BorderSize = 0;
            this.buttonConsults.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonConsults.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConsults.ForeColor = System.Drawing.Color.White;
            this.buttonConsults.IconChar = FontAwesome.Sharp.IconChar.AddressBook;
            this.buttonConsults.IconColor = System.Drawing.Color.White;
            this.buttonConsults.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.buttonConsults.IconSize = 30;
            this.buttonConsults.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonConsults.Location = new System.Drawing.Point(0, 190);
            this.buttonConsults.Name = "buttonConsults";
            this.buttonConsults.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.buttonConsults.Size = new System.Drawing.Size(198, 50);
            this.buttonConsults.TabIndex = 3;
            this.buttonConsults.Text = "Consultas";
            this.buttonConsults.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonConsults.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonConsults.UseVisualStyleBackColor = true;
            this.buttonConsults.Click += new System.EventHandler(this.buttonConsults_Click);
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(57)))), ((int)(((byte)(144)))));
            this.panelHeader.Controls.Add(this.buttonClose);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(215, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(669, 59);
            this.panelHeader.TabIndex = 1;
            this.panelHeader.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelHeader_MouseDown);
            // 
            // buttonClose
            // 
            this.buttonClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonClose.FlatAppearance.BorderSize = 0;
            this.buttonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClose.IconChar = FontAwesome.Sharp.IconChar.WindowClose;
            this.buttonClose.IconColor = System.Drawing.Color.White;
            this.buttonClose.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.buttonClose.IconSize = 35;
            this.buttonClose.Location = new System.Drawing.Point(633, 0);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(36, 59);
            this.buttonClose.TabIndex = 0;
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // panelChildForm
            // 
            this.panelChildForm.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelChildForm.Controls.Add(this.pictureBox2);
            this.panelChildForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChildForm.Location = new System.Drawing.Point(215, 59);
            this.panelChildForm.Margin = new System.Windows.Forms.Padding(3, 3, 15, 3);
            this.panelChildForm.Name = "panelChildForm";
            this.panelChildForm.Size = new System.Drawing.Size(669, 502);
            this.panelChildForm.TabIndex = 2;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(669, 502);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // buttonDoctors
            // 
            this.buttonDoctors.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonDoctors.FlatAppearance.BorderSize = 0;
            this.buttonDoctors.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDoctors.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDoctors.ForeColor = System.Drawing.Color.White;
            this.buttonDoctors.IconChar = FontAwesome.Sharp.IconChar.User;
            this.buttonDoctors.IconColor = System.Drawing.Color.White;
            this.buttonDoctors.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.buttonDoctors.IconSize = 30;
            this.buttonDoctors.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonDoctors.Location = new System.Drawing.Point(0, 498);
            this.buttonDoctors.Name = "buttonDoctors";
            this.buttonDoctors.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.buttonDoctors.Size = new System.Drawing.Size(198, 50);
            this.buttonDoctors.TabIndex = 7;
            this.buttonDoctors.Text = "Doctores";
            this.buttonDoctors.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonDoctors.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonDoctors.UseVisualStyleBackColor = true;
            this.buttonDoctors.Click += new System.EventHandler(this.buttonDoctors_Click);
            // 
            // Layout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.panelChildForm);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.mainPanel);
            this.MinimumSize = new System.Drawing.Size(900, 600);
            this.Name = "Layout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Previmed Clínica";
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.mainPanel.ResumeLayout(false);
            this.panelDoctors.ResumeLayout(false);
            this.panelPatients.ResumeLayout(false);
            this.panelConsults.ResumeLayout(false);
            this.panelHeader.ResumeLayout(false);
            this.panelChildForm.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelLogo;
        private FontAwesome.Sharp.IconButton homeButton;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Panel panelConsults;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button buttonRegisterConsult;
        private System.Windows.Forms.Button buttonAllConsults;
        private FontAwesome.Sharp.IconButton buttonConsults;
        private System.Windows.Forms.Panel panelPatients;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button buttonAllPatientsView;
        private FontAwesome.Sharp.IconButton buttonPatients;
        private FontAwesome.Sharp.IconButton buttonUnity;
        private System.Windows.Forms.Panel panelDoctors;
        private System.Windows.Forms.Button button;
        private System.Windows.Forms.Button buttonRegisterDoctor;
        private System.Windows.Forms.Button buttonAllDoctors;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Panel panelChildForm;
        private FontAwesome.Sharp.IconButton buttonClose;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private FontAwesome.Sharp.IconButton buttonDoctors;
    }
}

