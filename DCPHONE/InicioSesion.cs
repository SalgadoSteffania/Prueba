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

namespace DCPHONE.Forms
{
    public partial class InicioSesion : Form
    {
        public InicioSesion()
        {
            InitializeComponent();
            CustomizeComponents();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void CustomizeComponents()
        {
            //txtUsuario
            txtUsuario.AutoSize = false;
            txtUsuario.Size = new Size(315, 28);
            //txtContraseña
            txtContraseña.AutoSize = false;
            txtContraseña.Size = new Size(315, 28);
        }

        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "USUARIO")
            {
                txtUsuario.Text = "";
                txtUsuario.ForeColor = Color.LightBlue;
            }
        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "")
            {
                txtUsuario.Text = "USUARIO";
                txtUsuario.ForeColor = Color.LightBlue;
            }
        }

        private void txtContraseña_Enter(object sender, EventArgs e)
        {
            if (txtContraseña.Text == "CONTRASEÑA")
            {
                txtContraseña.Text = "";
                txtContraseña.ForeColor = Color.LightBlue;
                txtContraseña.UseSystemPasswordChar = true;
            }
        }

        private void txtContraseña_Leave(object sender, EventArgs e)
        {
            if (txtContraseña.Text == "")
            {
                txtContraseña.Text = "CONTRASEÑA";
                txtContraseña.ForeColor = Color.LightBlue;
                txtContraseña.UseSystemPasswordChar = false;
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void InicioSesion_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panelLogin_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnAcceder_Click(object sender, EventArgs e)
        {
            Form inventario = new MenuForm();


            String usuario = txtUsuario.Text;
            string contraseña = txtContraseña.Text;

            if (usuario == "Kennet" && contraseña == "Kennet123")
            {
                MessageBox.Show("Bienvenido al Sistema de Inventario y Facturación");
                this.Hide();
                inventario.Show();
            }
            else if (usuario == "" || contraseña == "")
            {
                MessageBox.Show("No se permiten campos vacios!");
            }
            //else if (usuario != "jerulu" )
            //  {
            //      MessageBox.Show("Usuario Icorrecto");
            //  }
            //  else if (contraseña != "crack123")
            //  {
            //      MessageBox.Show("Contraseña Incorrecta");
            //  }
            else if (usuario != "Kennet" || contraseña != "Kennet123")
            {
                MessageBox.Show("Usuario y Contraseña no coinciden!");
            }
        }
    }
}
