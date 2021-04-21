using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;
using ProyectTopicosAvanzados.Views;

namespace ProyectTopicosAvanzados
{
    public partial class Layout : Form
    {
        private IconButton currentButton;
        private Panel leftBorderPanel;
        private Form actualChildForm;

        public Layout()
        {
            InitializeComponent();
            leftBorderPanel = new Panel();
            leftBorderPanel.Size = new Size(8, 50);
            mainPanel.Controls.Add(leftBorderPanel);
            CloseSubMenus();

            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        #region CloseSubmenus

        private void CloseSubMenus()
        {
            panelConsults.Visible = false;
            panelDoctors.Visible = false;
            panelPatients.Visible = false;
            panelUnity.Visible = false;
        }

        private void buttonConsults_Click(object sender, EventArgs e)
        {
            if (panelConsults.Visible)
            {
                panelConsults.Visible = false;
                ResetButton();
            }
            else
            {
                CloseSubMenus();
                panelConsults.Visible = true;
                ActivateButton(sender);
            }
        }
        private void homeButton_Click(object sender, EventArgs e)
        {
            CloseSubMenus();
            ActivateButton(sender);
            OpenChildForm(new HomeScreen());
        }

        private void buttonUnity_Click(object sender, EventArgs e)
        {
            if (panelUnity.Visible)
            {
                panelUnity.Visible = false;
                ResetButton();
            }
            else
            {
                CloseSubMenus();
                panelUnity.Visible = true;
                ActivateButton(sender);
            }

        }
        private void buttonPatients_Click(object sender, EventArgs e)
        {
            if (panelPatients.Visible)
            {
                panelPatients.Visible = false;
                ResetButton();
            }
            else
            {
                CloseSubMenus();
                panelPatients.Visible = true;
                ActivateButton(sender);
            }
        }

        private void buttonDoctors_Click(object sender, EventArgs e)
        {
            if (panelDoctors.Visible)
            {
                panelDoctors.Visible = false;
                ResetButton();
            }
            else
            {
                CloseSubMenus();
                panelDoctors.Visible = true;
                ActivateButton(sender);
            }
        }
        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region Methods
        private void ActivateButton(object button)
        {
            if (button != null)
            {
                DisableButton();
                currentButton = (IconButton)button;
                currentButton.BackColor = Color.FromArgb(58, 103, 195);


                leftBorderPanel.BackColor = Color.White;
                leftBorderPanel.Location = new Point(0, currentButton.Location.Y);
                leftBorderPanel.Visible = true;
                leftBorderPanel.BringToFront();

            }
        }
        private void DisableButton()
        {
            if (currentButton != null)
            {
                currentButton.BackColor = Color.FromArgb(49, 86, 163);
                currentButton.ForeColor = Color.White;
                currentButton.IconColor = Color.White;
            }
        }
        private void ResetButton()
        {
            if (leftBorderPanel.Visible)
            {
                leftBorderPanel.Visible = false;
                currentButton.BackColor = Color.FromArgb(49, 86, 163);
            }
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panelHeader_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void OpenChildForm(Form childForm)
        {
            if(actualChildForm != null)
            {
                actualChildForm.Close();
            }
            actualChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            childForm.BackColor = Color.FromArgb(247, 248, 251);

            panelChildForm.Controls.Add(childForm);
            childForm.BringToFront();
            childForm.Show();

        }

        #endregion

        private void button6_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Patients());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenChildForm(new RegisterConsult());
        }

        private void buttonRegisterConsult_Click(object sender, EventArgs e)
        {
            OpenChildForm(new RegisterConsult());
        }

        private void buttonAllConsults_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Consults());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenChildForm(new EditConsult());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            OpenChildForm(new RegisterPatient());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            OpenChildForm(new EditPatient());
        }

        private void buttonAllDoctors_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Doctors());
        }

        private void buttonRegisterDoctor_Click(object sender, EventArgs e)
        {
            OpenChildForm(new RegisterDoctor());
        }

        private void button_Click(object sender, EventArgs e)
        {
            OpenChildForm(new EditDoctor());
        }


        private void buttonRegisterUnity_Click_1(object sender, EventArgs e)
        {
            CloseSubMenus();
            ActivateButton(sender);
            OpenChildForm(new Unity());
        }

        private void registerTreatment_Click(object sender, EventArgs e)
        {
            OpenChildForm(new RegisterTreatment());
        }
    }
}