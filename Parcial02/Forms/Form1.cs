using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parcial02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Abrir Form de registro. Y Usuario nuevo registrado
        private void btnSignIn_Click(object sender, EventArgs e)
        {
            using (frmSignIn signInForm = new frmSignIn())
            {
                DialogResult result = signInForm.ShowDialog();
                
                if (result == DialogResult.OK)
                {
                    MessageBox.Show("Registro exitoso. Inicie sesion.", "Registro",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        // Abrir Form para recuperar/cambiar contrasena. Y Contrasena cambiada.
        private void lblNewPassword_Click(object sender, EventArgs e)
        {
            using (frmChangePassword changePassword = new frmChangePassword())
            {
                DialogResult result = changePassword.ShowDialog();

                if (result == DialogResult.OK)
                {
                    MessageBox.Show("Cambio de clave exitoso!", "Clave",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}