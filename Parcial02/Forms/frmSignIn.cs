using System;
using System.Windows.Forms;

namespace Parcial02
{
    public partial class frmSignIn : Form
    {
        public frmSignIn()
        {
            InitializeComponent();
        }

        // Ventana de registro de usuario. Boton para guardar y registrar usuario nuevo.
        private void btnSignIn_Click(object sender, EventArgs e)
        {
            if (txtIdSign.Text.Length > 0 && txtUserSign.Text.Length > 0 && txtPasswordSign.Text.Length > 0 && 
                    txtPasswordSign2.Text.Length > 0 && txtQuestionSign.Text.Length > 0)
            {
                if (txtPasswordSign.Text.Equals(txtPasswordSign2.Text))
                {
                    this.DialogResult = DialogResult.OK;
                    // INSERT NEW USER TO THE DATA BASE
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Las contrasena no coincide, asegurese de que la contrasena sea la misma!", "Error!", 
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("Datos incompletos!", "Error!", 
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}