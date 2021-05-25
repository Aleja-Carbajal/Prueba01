using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using Parcial02.Context;
using Parcial02.Entities.Questions;
using User = Parcial02.Entities.Users.User;

namespace Parcial02
{
    public partial class frmChangePassword : Form
    {
        public frmChangePassword()
        {
            InitializeComponent();
        }
        
        // CHECK THIS 
        // Primera parte del cambio de contrasena. Verificando Carne y respuesta de seguridad.
        
        private void btnCheckCarne_Click(object sender, EventArgs e)
        {
            var db = new UcaClinicContext();
            List<User> users = db.Users
                .Include(u => u.SecurityQuestion)
                .ToList();

            string CardId = txtCarneChangePassword.Text;

            List<User> result = users
                .Where(u => u.CardId == CardId)
                .ToList();
            if (result.Count > 0)
            {
                grpCheckQuestion.Show(); 
            }
            else
            {
                MessageBox.Show("No existe una cuenta con ese carne, si no tiene cuenta registrese antes!", "Error!", 
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        // Segunda parte del cambio de contrasena. Pregunta
        private void btnCheckQuestion_Click(object sender, EventArgs e)
        {

            var db = new UcaClinicContext();
            List<User> users = db.Users
                .Include(u => u.SecurityQuestion)
                .ToList();

            string answer = txtQuestionChangePassword.Text;
            
            bool result = users
                .Where(u => u.SecurityAnswer == answer)
                .ToList().Count() > 0;

            if (result)
            {
                grpUpdatePassword.Show();
                btnChangePassword.Show();
            }
            else
            {
                MessageBox.Show("Datos Erroneos!", "Error!",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        
        
        
        // Tercera parte del cambio de contrasena. Update contrasena
        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            if (txtChangePassword.Text == txtChangePassword2.Text)
            {
                string newPassword = txtChangePassword.Text;
                
                var 
            }
            else
            {
                MessageBox.Show("Contrasenas no coinciden!", "Error!",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            
            
        }


        
    }
}