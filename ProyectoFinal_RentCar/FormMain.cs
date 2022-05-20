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

namespace ProyectoFinal_RentCar
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            this.Text = string.Empty;
            this.ControlBox = false;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);


        private Form activeForm;
        private Button currentButton;


        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelDesktop.Controls.Add(childForm);
            this.panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblTitulo.Text = childForm.Text;
        }

        private void DisableButton()
        {
            foreach (Control previousBtn in panelMenu.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(51, 51, 76);
                    previousBtn.ForeColor = Color.Gainsboro;
                    previousBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnRentaDevo_Click(object sender, EventArgs e)
        {

        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.Clientes(), sender);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.Vehiculo(), sender);
        }

        private void btnEmpleado_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.Empleados(), sender);

        }

        private void btnInspeccion_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.Inspeccion(), sender);

        }

        private void btnCerrarChild_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
                activeForm.Close();
            Reset();
        }

        private void Reset()
        {
            lblTitulo.Text = "HOME";
            currentButton = null;
            btnCerrarChild.Visible = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
                activeForm.Close();
            lblTitulo.Text = "HOME";
        }

        private void panelTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle,0x112,0xf012,0);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMaxi_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;
        }

        private void btnMini_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnMarcas_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.Marcas(), sender);

        }

        private void btnModelos_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.Modelos(), sender);

        }

        private void btnCombustibles_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.Combustibles(), sender);

        }

        private void btnTipoVehiculo_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.TipoVehiculo(), sender);

        }
    }
}
