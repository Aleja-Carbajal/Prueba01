using System;
using System.Windows.Forms;

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
        private void btnCheck_Click(object sender, EventArgs e)
        {
            if (txtCarneChangePassword.Text.Equals("00253720") && txtQuestionChangePassword.Text.Equals("ala"))
            {
                MessageBox.Show("Datos correctos! Ahora puede cambiar la contrasena.", "Exito", MessageBoxButtons.OK);
                btnChangePassword.Show();
                grpUpdatePassword.Show();
               
            }
            else if (txtCarneChangePassword.Text.Length < 0 || txtQuestionChangePassword.Text.Length < 0)
            {
                MessageBox.Show("Datos Incompletos!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                MessageBox.Show("No existe una cuenta con dicho carne o la respuesta de seguridad es incorrecta!",
                    "Datos erroneos!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        // Segunda parte del cambio de contrasena. Nueva contrasena escrita.
        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            if (txtChangePassword.Text.Equals(txtChangePassword2.Text))
            {
                this.DialogResult = DialogResult.OK;
                // UPDATE PASSWORD HERE
                this.Close();
            }
            else if (txtChangePassword.Text.Length < 0 || txtChangePassword2.Text.Length < 0)
            {
                MessageBox.Show("Datos Incompletos!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                MessageBox.Show("Las contrasenas no coinciden!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}