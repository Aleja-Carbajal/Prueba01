using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Parcial02.Context;
using Parcial02.Entities.Questions;
using Parcial02.Entities.Users;

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
                    // Creando el usuario
                    User newUser = new User();
                    newUser.CardId = txtIdSign.Text;
                    newUser.UserName = txtUserSign.Text;
                    newUser.Password = txtPasswordSign.Text;
                    newUser.SecurityAnswer = txtQuestionSign.Text;
                    Question question = (Question) cmbQuestions.SelectedItem;

                    var db = new UcaClinicContext();
                    Question ques = db.Set<Question>()
                        .SingleOrDefault(q => q.Id == question.Id);

                    newUser.SecurityQuestion = ques;

                    db.Add(newUser);
                    db.SaveChanges();

                    MessageBox.Show("Usuario creado con exito! Ahora inicie sesion", "Registro terminado",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();

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

        // Combobox
        private void frmSignIn_Load(object sender, EventArgs e)
        {
            var db = new UcaClinicContext();

            cmbQuestions.DataSource = db.Questions.ToList();
            cmbQuestions.DisplayMember = "SecurityQuestion";
            cmbQuestions.ValueMember = "Id"; 
        }

       
    }
}