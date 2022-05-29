using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinal_RentCar.Forms
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            
            if (txtUsuario.Text.ToString() == "Admin" && txtClave.Text.ToString() == "1234")
            {
                this.Hide();
                FormMain formMain = new FormMain();
                formMain.Show();
            }
            else
            {
                MessageBox.Show("Usuario o Clave incorrectos");

            }
            
        }

        private void Login_Load(object sender, EventArgs e)
        {
            Login login = new Login();
            login.CenterToScreen();
        }
    }
}
