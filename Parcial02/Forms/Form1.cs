using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using Parcial02.Context;
using User = Parcial02.Entities.Users.User;

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

        // Inicio de sesion
        private void btnLogIn_Click(object sender, EventArgs e)
        {
            var db = new UcaClinicContext();
            List<User> users = db.Users
                .Include(u => u.SecurityQuestion)
                .ToList();
            
            string userName = txtUser.Text;
            string password = txtPassword.Text;

            List<User> result = users
                .Where(u => u.UserName == userName &&
                            u.Password == password)
                .ToList();

            if (result.Count() > 0)
            {
                MessageBox.Show("Bienvenido!", "Clinica UCA", MessageBoxButtons.OK);
                //frmMain window = new frmMain(result[0]);
                //window.Show();
                this.Hide();
            }


        }
        
    }
}